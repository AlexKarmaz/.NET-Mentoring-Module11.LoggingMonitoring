using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using MvcMusicStore.Models;
using MyLogger;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger logger;
        private readonly MusicStoreEntities _storeContext = new MusicStoreEntities();

        public HomeController(ILogger logger)
        {
            this.logger = logger;
            logger.Info("HomeController created");
        }

        // GET: /Home/
        public async Task<ActionResult> Index()
        {
            logger.Info("Homecontroller Index method started");
            return View(await _storeContext.Albums
                .OrderByDescending(a => a.OrderDetails.Count)
                .Take(6)
                .ToListAsync());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _storeContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}