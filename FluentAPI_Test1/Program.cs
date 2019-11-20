using System;

namespace FluentAPI_Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Model())
            {
                db.Students.Add(new Student { studetName = "student1" });
                db.Students.Add(new Student { studetName = "student2" });
                db.Students.Add(new Student { studetName = "student3" });
                db.SaveChanges();

            }
        }
    }
}
