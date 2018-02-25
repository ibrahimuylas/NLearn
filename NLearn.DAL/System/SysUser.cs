using System;
using NLearn.Common;

namespace NLearn.DAL.System
{
    [TableNameAttribute("SYS_USER")]
    public class SysUser : EntityBase
    {
        public string Name
        {
            get;
            set;
        }

        public string Surname
        {
            get;
            set;
        }

        public string UserName
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }



    }
}
