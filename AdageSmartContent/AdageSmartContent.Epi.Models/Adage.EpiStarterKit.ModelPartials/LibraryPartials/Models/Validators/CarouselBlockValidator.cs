using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using EPiServer.Core;
using EPiServer.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.LibraryPartials.Models.Validators
{
    public partial class CarouselBlockValidator
    {
        public IEnumerable<ValidationError> Validate(CarouselItemBlock instance)
        {
            if (!(ContentReference.IsNullOrEmpty(instance.ImageFile) ^ string.IsNullOrWhiteSpace(instance.YouTubeId)))
            {
                return new[]
                {
                    new ValidationError
                    {
                        ErrorMessage = "Either Youtube ID or Image but not both must be specified",
                        PropertyName = instance.GetPropertyName(p => p.ImageFile),
                        Severity = ValidationErrorSeverity.Error,
                        RelatedProperties = new [] {  instance.GetPropertyName(p => p.YouTubeId) }
                    }
                };
            }

            return Enumerable.Empty<ValidationError>();
        }
    }
}
