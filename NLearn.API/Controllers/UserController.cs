using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NLearn.BO;
using NLearn.DAL.System;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NLearn.API.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public List<SysUser> Get()
        {
            UserBO userBo = new UserBO();
            return userBo.GetAll();
        }

        // GET api/values/5
        [HttpGet("{username}")]
        public SysUser Get(string username)
        {
            UserBO userBo = new UserBO();
            return userBo.GetUserByName(username);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]SysUser value)
        {
            new UserBO().AddUser(value);
        }

        // PUT api/values/5
        [HttpPut("{username}")]
        public void Put(string username, [FromBody]SysUser value)
        {
            new UserBO().UpdateUser(username, value);
        }

        // DELETE api/values/5
        [HttpDelete("{username}")]
        public void Delete(string username)
        {
            new UserBO().DeleteUser(username);
        }
    }
}
