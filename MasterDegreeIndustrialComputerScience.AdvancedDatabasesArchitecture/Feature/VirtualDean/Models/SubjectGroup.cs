using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MasterDegreeIndustrialComputerScience.AdvancedDatabasesArchitecture.Feature.VirtualDean.Models
{
    public class SubjectGroup
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SubjectGroupId { get; set; }
        [BsonId]
        public string EmployeeId { get; set; }

        [BsonId]
        public string SubjectId { get; set; }
        public string GroupName { get; set; }

     

    }
}
