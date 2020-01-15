using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace CSharpLearn
{
    public class Student : Entity
    {
        private static ReaderDbHelper dbHelper;
        public Student()
        {
            if (dbHelper == null)
            {
                dbHelper = new ReaderDbHelper();
            }
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public void Save(DbConnection connection,string name)
        {
            dbHelper.ExecuteNonQuery($"INSERT Student VALUES(N'{Name}',{Age})",
               connection,name);
        }
        public void Delete(string name)
        {
            dbHelper.ExecuteNonQuery($"DELETE Student WHERE Id={Id}",
                dbHelper.LongConnection,name);
        }
        public static void GetSum(string name)
        {
            new ReaderDbHelper().ExecuteScalar($"SELECT COUNT(*) FROM Student",
                 new ReaderDbHelper().LongConnection,name);
            new ReaderDbHelper().LongConnection.Close();
        }
        public static IList<Student> GetStudent(string name)
        {
            DbDataReader reader = new ReaderDbHelper().ExecuteReader($"SELECT * FROM Student",
                new ReaderDbHelper().LongConnection,name);
            //bool HasRow= reader.Read();
            IList<Student> students = new List<Student>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    students.Add(map(reader));
                }
            }
            return students;
        }
        public static Student GetStudentByName(string name)
        {
            DbDataReader reader =
                new ReaderDbHelper().ExecuteReader(@"SELECT * FROM Student WHERE [Name]=@Name",
                 new ReaderDbHelper().LongConnection,name);
            
            reader.Read();
            return map(reader);
        }

        private static Student map(DbDataReader reader)
        {
            return new Student()
            {
                Id = (int)reader[0],
                Name = (string)reader["Name"],
                Age = (short)reader[2]
            };
        }
    }
}
