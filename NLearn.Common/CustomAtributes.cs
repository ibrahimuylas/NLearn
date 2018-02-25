using System;
namespace NLearn.Common
{
    public class TableNameAttribute : Attribute
    {
        string desc;
        public string Desc { get { return desc; } }
        public TableNameAttribute(string desc)
        {
            this.desc = desc;
        }
    }
}
