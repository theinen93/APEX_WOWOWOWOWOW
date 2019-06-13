using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using EPiServer.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Static.Validation
{
    public partial class ContentHighlightItemBlockValidator : IValidate<ContentHighlightItemBlock>
    {
        public IEnumerable<ValidationError> Validate(ContentHighlightItemBlock instance)
        {
            // Need to make CTA's url required
            if (CTALinkPopulated(instance))
            {
                return new[]
                {
                    new ValidationError()
                    {
                        ErrorMessage = "Link Url is required",
                        PropertyName = nameof(instance.LinkBlock.LinkUrl),
                        Severity = ValidationErrorSeverity.Error,
                        ValidationType = ValidationErrorType.Unspecified
                    }

                };
            }

            return Enumerable.Empty<ValidationError>();
        }

        private bool CTALinkPopulated(ContentHighlightItemBlock instance)
        {
            return instance.LinkBlock == null || instance.LinkBlock.LinkUrl == null;
        }
    }
}
