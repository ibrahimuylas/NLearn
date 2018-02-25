using System;
using NLearn.DAL;

namespace NLearn.BO
{
    public class TestBO
    {
        public string GetUserName(){
            return DataContext.Instance.GetActiveUser();
        }
    }
}
