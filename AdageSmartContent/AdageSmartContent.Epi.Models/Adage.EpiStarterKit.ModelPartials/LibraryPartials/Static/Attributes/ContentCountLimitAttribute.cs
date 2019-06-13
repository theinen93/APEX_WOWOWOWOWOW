using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Static.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public partial class ContentCountLimitAttribute : ValidationAttribute
    {
        protected readonly int MaxSize;
        protected readonly int MinSize;

        #region Constructors
        public ContentCountLimitAttribute(int min, int max)
        {
            MaxSize = max;
            MinSize = min;
        }
        #endregion

        #region Overrides
        public override bool RequiresValidationContext
        {
            get
            {
                return true;
            }
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Ignore if this is a new instance of a block.  Techncially allows user to bypass this check if min = 0 on initial create, but since you cannot instantiate
            // the content area with stuff already in there this is a tolerable exception
            if (validationContext.ObjectInstance is BlockData && validationContext.ObjectInstance is IVersionable version && version.Status == VersionStatus.NotCreated)
            {
                return null;
            }

            ValidationResult result = null;

            var isValid = CheckMinMax(value, validationContext);

            if (!isValid)
            {
                var errorMessage = !string.IsNullOrEmpty(this.ErrorMessage) ? ErrorMessage : $"ContentArea must contain between {GetActualMin(validationContext)} and {GetActualMax(validationContext)} items";
                result = new ValidationResult(errorMessage);
            }

            return result;
        }
        #endregion

        protected virtual bool CheckMinMax(object value, ValidationContext validationContext)
        {
            ContentArea contentArea = value as ContentArea;
            if (value != null && contentArea == null)
            {
                throw new ValidationException($"{nameof(ContentCountLimitAttribute)} is intended only for use with EPiServer.Core.ContentArea properties");
            }

            var actualMin = GetActualMin(validationContext);
            var contentAreaCount = contentArea != null ? contentArea.Count : 0;

            return value == null || (actualMin <= contentAreaCount && contentAreaCount <= GetActualMax(validationContext));
        }


        // GL:  If we create more attributes we need to override we may want to extract this out...
        protected int GetOverrideValue(ValidationContext validationContext, string attrPropertyName, int defaultValue)
        {
            var className = validationContext.ObjectType.BaseType.Name;
            var classPropertyName = validationContext.MemberName;
            var attrName = this.GetType().Name;

            string key = $"{className}_{classPropertyName}_{attrName}_{attrPropertyName}";
            var configValue = ConfigurationManager.AppSettings[key];
            return !string.IsNullOrEmpty(configValue) ? int.Parse(configValue) : defaultValue;
        }

        protected int GetActualMin(ValidationContext validationContext)
        {
            return GetOverrideValue(validationContext, nameof(MinSize), MinSize);
        }

        protected int GetActualMax(ValidationContext validationContext)
        {
            return GetOverrideValue(validationContext, nameof(MaxSize), MaxSize);
        }
    }
}
