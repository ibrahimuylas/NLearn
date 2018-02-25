using System;
using MongoDB.Bson;

namespace NLearn.DAL
{
    public class EntityBase
    {
        public ObjectId _id
        {
            get;
            set;
        }
    }
}
