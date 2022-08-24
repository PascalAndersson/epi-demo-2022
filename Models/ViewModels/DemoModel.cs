using EPiServer.Find.Statistics.Api;
using demo_episerver11.Models.ViewModels;
using System.Collections.Generic;
using System.Web;
using EPiServer.Find.Statistics;
using demo_episerver11.Models.Pages;

namespace demo_episerver11.Models.ViewModels
{
    public class DemoModel : PageViewModel<DemoPage>
    {
        public DemoModel(DemoPage currentPage) : base(currentPage)
        {
        }
    }
}
