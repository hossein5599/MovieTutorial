using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MovieTutorial.BasicSamples.Pages
{
    [PageAuthorize, Route("BasicSamples/[action]")]
    public partial class BasicSamplesController : Controller
    {
    }
}
