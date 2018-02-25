using System;
using System.Collections.Generic;
using NLearn.DAL;
using NLearn.DAL.System;

namespace NLearn.BO
{
    public class UserBO
    {
        public UserBO()
        {
        }

        public List<SysUser> GetAll(){
            return DataContext.Instance.GetAllUser();
        }

        public SysUser GetUserByName(string username)
        {
            return DataContext.Instance.GetUser(username);
        }

        public void AddUser(SysUser user)
        {
            DataContext.Instance.AddUser(user); 
        }

        public void UpdateUser(string username, SysUser user)
        {
            DataContext.Instance.UpdateUser(username, user); 
        }

        public void DeleteUser(string username)
        {
            DataContext.Instance.DeleteUser(username); 
        }
    }
}
