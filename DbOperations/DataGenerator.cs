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
                        Name = "Ahmet",
                        Surname = "Veli",
                        ClassId = 4
                    },
                    new Student()
                    {
                        Name = "Fatma",
                        Surname = "Matma",
                        ClassId = 3
                    },
                    new Student()
                    {
                        Name = "Ahmet",
                        Surname = "Korkmaz",
                        ClassId = 7
                    },
                     new Student()
                     {
                         Name = "Ali",
                         Surname = "Korkmaz",
                         ClassId = 7
                     }
                );
                context.SaveChanges();

            }
        }
    }
}