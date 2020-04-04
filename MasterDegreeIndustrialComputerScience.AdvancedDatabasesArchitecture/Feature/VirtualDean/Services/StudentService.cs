using System;
using System.Collections.Generic;
using System.Text;
using MasterDegreeIndustrialComputerScience.AdvancedDatabasesArchitecture.Feature.VirtualDean.Models;
using MongoDB.Driver;

namespace MasterDegreeIndustrialComputerScience.AdvancedDatabasesArchitecture.Feature.VirtualDean.Services
{
    public class StudentService
    {
        private readonly IMongoCollection<Student> students;

        public StudentService(string connectionString)
        {
            var client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase("virtualuniversity");
            students = database.GetCollection<Student>("student");
        }

        public IEnumerable<Student> Get()
        {
            return students.Find(student => true).ToList();
        }

        public Student Create(Student student)
        {
            students.InsertOne(student);
            return student;
        }
    }
}
