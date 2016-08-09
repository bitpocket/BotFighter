using System.Threading.Tasks;
using System.Web.Mvc;
using GameServer;

namespace BotFighterServer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServer _server;

        public HomeController(IServer server)
        {
            _server = server;
        }

        public ActionResult Index()
        {
            return View();
        }

        public Task<JsonResult> GetGamesTypes()
        {
            return
                Task.FromResult(new JsonResult
                {
                    Data = _server.GetGameHeaders(),
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                });
        }
    }
}