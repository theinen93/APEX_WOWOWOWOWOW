using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Adage.EpiStarterKit.ModelPartials.Static;
using EPiServer.Shell.ObjectEditing;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(VideoBlock), GroupName = ContentGroupNames.BaseBlocks,
        DisplayName = "Video Block", GUID = "180deec9-f720-441b-9001-258b10bb9693", Description = "Container for a video, along with a caption.")]
    [SiteImagesUrl("Block-Video.png")]
    public partial class VideoBlock : AdageBaseBlock
    {
        [CultureSpecific]
        [Display(
            Name = "Title Tag",
            GroupName = SystemTabNames.Content,
            Description = "A short, meaningful description of the video.  This is best practice for accessibility.",
            Order = 100)]
        public virtual string TitleTag { get; set; }

        [CultureSpecific]
        [Display(
            Name = "YouTube ID",
            GroupName = SystemTabNames.Content,
            Description = "The ID for a Youtube video to display in this block",
            Order = 200)]
        public virtual string YouTubeId { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Vimeo ID",
            GroupName = SystemTabNames.Content,
            Description = "The ID for a Vimeo video to display in this block",
            Order = 300)]
        public virtual string VimeoId { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Video Reference",
            GroupName = SystemTabNames.Content,
            Description = "A video uploaded to Episerver to display in this block",
            Order = 400)]
        [UIHint(UIHint.Video)]
        public virtual ContentReference VideoReference { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Poster Image (CMS Video Only)",
            GroupName = SystemTabNames.Content,
            Description = "Thumbnail which displays for the video prior to play. Only used for CMS uploaded videos.",
            Order = 500)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference PosterImage { get; set; }
    }
}