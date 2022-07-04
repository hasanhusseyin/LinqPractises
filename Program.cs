using System;
using System.Linq;
using LinqPractises;
using LinqPractises.DbOperations;


DataGenerator.Initialize();
LinqDbContext _context = new LinqDbContext();
var students = _context.Students.ToList<Student>();

//Find() 
var student = _context.Students.Where(x => x.StudentId == 1).FirstOrDefault(); // 1.Yol - Şart ile Arama
student = _context.Students.Find(3);                                           // 2.Yol - PrimaryKey ile Arama
Console.WriteLine("Find Metodu ------- " + student.Name + " " + student.Surname);

//FirstOrDefault --- İlk bulduğu veriyi döndürür, veri yoksa null...
student = _context.Students.Where(x => x.Name == "Ahmet").FirstOrDefault();
student = _context.Students.FirstOrDefault(x => x.Name == "Ahmet");
Console.WriteLine("FirstOrDefault Metodu ------- " + student.Name + " " + student.Surname);

//SingleOrDefault --- 1 veya 0 olarak Veri Döner, 1'den fazlada veride (kayıtta) hata döndürür. 
student = _context.Students.Where(x => x.Name == "Ali").SingleOrDefault();
student = _context.Students.SingleOrDefault(x => x.Name == "Ali");
Console.WriteLine("SingleOrDefault Metodu ------- " + student.Name + " " + student.Surname);

//ToList() --- Liste Döner 
var studentList = _context.Students.Where(x => x.Name == "Ahmet").ToList();
Console.WriteLine("ToList Metodu ------- " + studentList.Count());

// OrderBy  --- Artan sırlama A->Z
Console.WriteLine();
Console.WriteLine("**** Order By ****");
students = _context.Students.OrderBy(x => x.StudentId).ToList();
foreach (var st in students)
    Console.WriteLine(st.StudentId + " - " + st.Name + " - " + st.Surname);


// OrderByDescending   --- Azalan Sıralama Z-A
Console.WriteLine();
Console.WriteLine("**** OrderByDescending ****");
students = _context.Students.OrderByDescending(x => x.StudentId).ToList();
foreach (var st in students)
    Console.WriteLine(st.StudentId + " - " + st.Name + " - " + st.Surname);


// Anonymous Object Result
Console.WriteLine();
Console.WriteLine("**** Anonymous Object Result ****");
var anonymousObject = _context.Students
                     .Where(x => x.ClassId == 2)
                     .Select(x => new
                     {
                         Id = x.StudentId,
                         FullName = x.Name + " " + x.Surname
                     });
foreach (var obj in anonymousObject)
    Console.WriteLine(obj.Id + "" + obj.FullName);