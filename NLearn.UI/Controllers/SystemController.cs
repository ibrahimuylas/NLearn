using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NLearn.UI.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NLearn.UI.Controllers
{
    public class SystemController : Controller
    {
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task<ViewResult> SysUser()
        {
            var result = await SystemService.Instance.GetAllUsersAsync();

            return View(result);
        }
    }
}
