using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
using NLearn.Common;
using NLearn.DAL.System;
using MongoDB.Driver.Linq;

namespace NLearn.DAL
{
    public class DataContext : Singleton<DataContext>
    {
        MongoClient _Client;
        IMongoDatabase _Database;
        public DataContext()
        {
            this._Client = new MongoClient("mongodb://localhost:27017");
            this._Database = _Client.GetDatabase("NLearnDb");

        }

        public List<SysUser> GetAllUser()
        {
            return _Database.GetCollection<SysUser>(EntityHelper.GetTableName<SysUser>()).AsQueryable<SysUser>().ToList();
        }

        public string GetActiveUser()
        {
            var ibrahim = _Database.GetCollection<SysUser>(EntityHelper.GetTableName<SysUser>()).Find(x => x.Name == "ibrahim").FirstOrDefault();
            return ibrahim.UserName;

        }

        public void UpdateUser(string username, SysUser user)
        {
            var collection = _Database.GetCollection<SysUser>(EntityHelper.GetTableName<SysUser>());
            collection.UpdateOne(
                Builders<SysUser>.Filter.Eq(x => x.UserName, username),
                Builders<SysUser>.Update.Set(x => x.Name, user.Name)
                .Set(x=> x.Surname, user.Surname));
            

        }

        public void DeleteUser(string username)
        {
            var collection = _Database.GetCollection<SysUser>(EntityHelper.GetTableName<SysUser>());
            collection.DeleteOne(Builders<SysUser>.Filter.Eq(x => x.UserName, username));
        }

        public void AddUser(SysUser user)
        {
            var collection = _Database.GetCollection<SysUser>(EntityHelper.GetTableName<SysUser>());
            collection.InsertOne(user);
        }

        public SysUser GetUser(string username)
        {
            return _Database.GetCollection<SysUser>(EntityHelper.GetTableName<SysUser>()).Find(x => x.UserName == username).FirstOrDefault();
        }
    }


}
