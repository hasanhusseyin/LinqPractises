using System.Linq;
namespace LinqPractises.DbOperations
{
    public class DataGenerator
    {

        public static void Initialize()
        {

            using (var context = new LinqDbContext())
            {
                if (context.Students.Any())
                {
                    return;
                }

                context.Students.AddRange(
                    new Student()
                    {
                        StudentId = 1,
                        Name = "Ali",
                        Surname = "Veli",
                        ClassId = 4
                    },
                    new Student()
                    {
                        StudentId = 2,
                        Name = "Fatma",
                        Surname = "Matma",
                        ClassId = 3
                    },
                    new Student()
                    {
                        StudentId = 3,
                        Name = "Ahmet",
                        Surname = "Korkmaz",
                        ClassId = 7
                    },
                     new Student()
                    {
                        StudentId = 4,
                        Name = "Veli",
                        Surname = "Korkmaz",
                        ClassId = 1
                    }
                );
                context.SaveChanges();

            }
        }
    }
}