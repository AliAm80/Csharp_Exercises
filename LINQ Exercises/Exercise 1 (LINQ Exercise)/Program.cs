using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var studentList = StudentDatabase.GetStudentsFromDb();
            // (1)
            var query1 = studentList.Where(x => x.IsActive == true &&
                                                x.Score > 80 &&
                                                x.City == "NYC");

            // (2)
            var query2 = studentList.Where(x => x.Score > 80 ||
                                                x.City == "CA")
                                    .Select(x => x.StudentName);
            // (3)
            var query3 = studentList.Where(x => x.StudentName.ToUpper().StartsWith('B'))
                                    .Select(x => new MinimalStudent()
                                    {
                                        StudentName = x.StudentName
                                    });
            // (4)
            var query4 = studentList.Where(x => x.IsActive == false)
                                    .OrderByDescending(x => x.Score);
            // (5)                  
            var query5 = studentList.Average(x => x.Score);
            // (6)
            var query6 = studentList.Where(x => x.City == "CA" &&
                                                 x.IsActive == true &&
                                                (x.StudentName.ToUpper().Contains("R") ||
                                                 x.StudentName.ToUpper().Contains("D")))
                                    .Average(x => x.Score);









        }
    }
}