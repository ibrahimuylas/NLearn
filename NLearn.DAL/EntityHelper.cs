using System;
using NLearn.Common;

namespace NLearn.DAL
{
    public static class EntityHelper
    {
        public static string GetTableName<T>(){

            try
            {
                return ((TableNameAttribute)typeof(T).GetCustomAttributes(typeof(TableNameAttribute), true)[0]).Desc;
            }
            catch
            {
                throw new Exception($"Tablo adı bulunamadı. Lütfen { typeof(T).ToString() }' sınıfının TableNameAttribute değerini kontrol edin.");
            }
        }
    }
}
