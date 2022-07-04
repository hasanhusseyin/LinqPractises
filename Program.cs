using System;
using System.Linq;
using LinqPractises;
using LinqPractises.DbOperations;


DataGenerator.Initialize();
LinqDbContext _context = new LinqDbContext();
var students = _context.Students.ToList<Student>();