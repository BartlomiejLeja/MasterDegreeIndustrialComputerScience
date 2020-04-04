using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MasterDegreeIndustrialComputerScience.AdvancedDatabasesArchitecture.Feature.VirtualDean.Models
{
    public class Assignment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AssignmentId { get; set; }

        [BsonId]
        public string StudentId { get; set; }

        [BsonId]
        public string SubjectIdtId { get; set; }

        public string Grade { get; set; }


    }
}
