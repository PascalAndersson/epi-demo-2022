using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace demo_episerver11.Models.Pages
{
    [ContentType(DisplayName = "DemoPage", GUID = "92de7376-4c62-4760-beed-4fc37aa35b88", Description = "")]
    public class DemoPage : SitePageData
    {
        [CultureSpecific]
        [Display(
          Name = "Header",
          GroupName = SystemTabNames.Content,
          Order = 1)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}