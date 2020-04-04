using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MasterDegreeIndustrialComputerScience.AdvancedDatabasesArchitecture.Feature.VirtualDean.Models
{
    public class Classes
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ClassesId { get; set; }
        public int ClassNumber { get; set; }
        public DateTime DateTime { get; set; }
        [BsonId]
        public string ClassroomId { get; set; }
        [BsonId]
        public string GroupSubjectId { get; set; }
    }
}
