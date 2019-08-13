using System.Threading.Tasks;
using System.Web.Mvc;
using JuCheap.Interfaces;
using JuCheap.Web.Models;

namespace JuCheap.Web.Controllers
{
    /// <summary>
    /// 系统管理
    /// </summary>
    public class SystemController : BaseController
    {
        private readonly IDatabaseInitService _databaseInitService;

        public SystemController(IDatabaseInitService databaseInitService)
        {
            _databaseInitService = databaseInitService;
        }

        /// <summary>
        /// 系统管理首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 重置路径码
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<JsonResult> ReloadPathCode()
        {
            var result = new JsonResultModel<bool>
            {
                flag = await _databaseInitService.InitPathCode()
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 重新加载Hangfire定时任务
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult ReloadTasks()
        {
            Startup.LoadRecurringTasks();
            return Ok();
        }
    }
}