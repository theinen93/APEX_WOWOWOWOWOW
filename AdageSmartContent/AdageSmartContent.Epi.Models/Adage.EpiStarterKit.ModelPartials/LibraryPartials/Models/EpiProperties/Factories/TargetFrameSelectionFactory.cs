using EPiServer.DataAbstraction;
using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.Factories
{
    /// <summary>
    /// Selection Factory to display all Frames in the Frame Repository.  Adds a "default" empty target frame with text provided
    /// by Adage UX department
    /// </summary>
    /// <remarks> 
    /// This is based off the class EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors.SelectionFactories.PageTargetFrameSelectionFactory, which had
    /// notes as of 12-12-2017 saying that it was obsolete.  In the future, you may want to double-check to see what Episerver replaced this with
    /// in case we need to update the Editor Descriptor
    /// </remarks>
    [SelectionFactoryRegistration]
    public partial class AdagePageTargetFrameSelectionFactory : ISelectionFactory
    {
        #region Static Properties
        public const string UIHINT = "TargetFrame";
        #endregion

        #region Class Variables
        protected readonly IFrameRepository FrameRepository;
        #endregion

        #region Constructors
        public AdagePageTargetFrameSelectionFactory(IFrameRepository frameRepository)
        {
            if (frameRepository == null)
            {
                throw new ArgumentNullException(nameof(frameRepository));
            }

            this.FrameRepository = frameRepository;
        }
        #endregion

        #region ISelectionFactory Members
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            IEnumerable<Frame> targetFrameCollection = FrameRepository.List();

            if (targetFrameCollection != null)
            {
                yield return new SelectItem()
                {
                    Text = "Open the link in current tab",
                    Value = string.Empty
                };

                // Grab the frames from Admin Mode
                foreach (Frame frame in targetFrameCollection)
                {
                    yield return new SelectItem()
                    {
                        Text = frame.LocalizedDescription,
                        Value = (object)frame.ID
                    };
                }
            }
        }
        #endregion
    }
}
