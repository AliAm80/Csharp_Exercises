using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class StudentDatabase
    {
       public static IQueryable<Student> GetStudentsFromDb()
        {
            return new[]
            {
                new Student() {StudentId = 1, StudentName = "John Nigel", Score = 86, City ="NYC", IsActive = true},
                new Student() {StudentId = 2, StudentName = "Alex Roma", Score = 76, City ="NYC", IsActive = false},
                new Student() {StudentId = 3, StudentName = "Noha Shamil", Score = 85, City ="CA", IsActive = true},
                new Student() {StudentId = 4, StudentName = "James Palatte", Score = 53, City ="NYC", IsActive = false},
                new Student() {StudentId = 5, StudentName = "Ron Jenova", Score = 70, City ="CA", IsActive = true},
                new Student() {StudentId = 6, StudentName = "Bill Allen", Score = 60, City ="NYC", IsActive = false},
                new Student() {StudentId = 7, StudentName = "Frank Daves", Score = 95, City ="CA", IsActive = true}

            }.AsQueryable();
        }

    }
}