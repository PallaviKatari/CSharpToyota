using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    //Student Table - Id,Name,Grade
    public class Student
    {
        //Properties
        //get and set accessors
        //get - read and set - write
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
    }
    //Course Table - CourseId, CourseName, StudentId
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int StudentId { get; set; }
    }
    /// <summary>
    /// LINQ - Language Integrated Query
    /// What is LINQ - A set of methods for querying collections in a more readable way
    /// Can connect to different data sources - Collections, Databases, XML, etc.
    /// </summary>
    public class LinqDemo
    {
        //LINQ Examples to connect to collections
        static void Main()
        {
            //var denotes implicit typing
            var numbers = new List<int> { 5, 10, 15, 20, 25, 30, 15, 20, 25 };

            //Student - Id, Name, Grade
            //insert some sample data
            var students = new List<Student>
            {
                //new keyword to create object of Student class
                //Id = 1, Name = "Alice", Grade = 85 assigning values to properties
                new Student { Id = 1, Name = "Alice", Grade = 85 },
                new Student { Id = 2, Name = "Bob", Grade = 92 },
                new Student { Id = 3, Name = "Charlie", Grade = 78 },
                new Student { Id = 4, Name = "Diana", Grade = 88 }
            };

            //Course - CourseId, CourseName, StudentId
            var courses = new List<Course>
            {
                new Course { CourseId = 101, CourseName = "Math", StudentId = 1 },
                new Course { CourseId = 102, CourseName = "Science", StudentId = 2 },
                new Course { CourseId = 103, CourseName = "History", StudentId = 3 },
                new Course { CourseId = 104, CourseName = "Literature", StudentId = 4 }
            };

            Console.WriteLine("=== LINQ Examples in C# Console Application ===\n");

            // 1. Filtering (Where)
            //var numbers = new List<int> { 5, 10, 15, 20, 25, 30, 15, 20, 25 };
            //=> filter numbers greater than 15
            var filteredNumbers = numbers.Where(n => n > 15);//20, 25, 30, 15, 20, 25
            Console.WriteLine("Numbers > 15:");
            //iterate through the filtered numbers
            foreach (var num in filteredNumbers) //20, 25, 30, 15, 20, 25
                Console.WriteLine(num);
            Console.WriteLine();

            // 2. Projection (Select)
            //Student - Id, Name, Grade - Select Name from Student;
            var studentNames = students.Select(s => s.Name); //Alice,Bob,Charlie,Diana
            Console.WriteLine("Student Names:");
            //iterate through the student names
            foreach (var name in studentNames)//Alice,Bob,Charlie,Diana
                Console.WriteLine(name);
            Console.WriteLine();

            // 3. Ordering (OrderBy / OrderByDescending)
            // Select Name, Grade from Student Order By Grade Desc;
            var orderedStudents = students.OrderByDescending(s => s.Grade);
            Console.WriteLine("Students ordered by Grade descending:");
            foreach (var s in orderedStudents)
                Console.WriteLine($"{s.Name} - {s.Grade}");
            Console.WriteLine();

            // 4. Grouping (GroupBy)
            // Select Grade, Count(*) from Student Group By Grade;
            var groupedByGrade = students.GroupBy(s => s.Grade >= 85 ? "Pass" : "Fail");
            Console.WriteLine("Students grouped by Pass/Fail:");
            foreach (var group in groupedByGrade)
            {
                Console.WriteLine($"{group.Key}:");
                foreach (var s in group)
                    Console.WriteLine($" - {s.Name}");
            }
            Console.WriteLine();

            // 5. Aggregation (Sum, Average, Min, Max)
            // Select Sum(Grade), Avg(Grade), Min(Grade), Max(Grade) from Student;
            int total = numbers.Sum();
            Console.WriteLine($"Sum of numbers: {total}");

            double averageGrade = students.Average(s => s.Grade);
            Console.WriteLine($"Average grade: {averageGrade}");

            int minGrade = students.Min(s => s.Grade);
            int maxGrade = students.Max(s => s.Grade);
            Console.WriteLine($"Min grade: {minGrade}");
            Console.WriteLine($"Max grade: {maxGrade}\n");

            // 6. Distinct
            // Select Distinct numbers from Numbers;
            var numbersWithDuplicates = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            var distinctNumbers = numbersWithDuplicates.Distinct();
            Console.WriteLine("Distinct numbers:");
            foreach (var num in distinctNumbers)
                Console.WriteLine(num);
            Console.WriteLine();

            // 7. Join
            // Select s.Name, c.CourseName from Student s Join Course c on s.Id = c.StudentId;
            var studentCourses = students.Join(courses,
                s => s.Id,
                c => c.StudentId,
                (s, c) => new { s.Name, c.CourseName });

            Console.WriteLine("Students and their courses:");
            foreach (var sc in studentCourses)
                Console.WriteLine($"{sc.Name} - {sc.CourseName}");
            Console.WriteLine();

            // 8. First / FirstOrDefault
            var firstHighGradeStudent = students.FirstOrDefault(s => s.Grade > 80);
            Console.WriteLine($"First student with grade > 80: {firstHighGradeStudent?.Name}");
            Console.WriteLine();

            // 9. Any / All
            bool hasFailing = students.Any(s => s.Grade < 70);
            Console.WriteLine($"Any student failing (grade < 70): {hasFailing}");

            bool allAbove75 = students.All(s => s.Grade > 75);
            Console.WriteLine($"All students have grades > 75: {allAbove75}");
            Console.WriteLine();

            // 10. Conversion to List / Array
            var topStudents = students.Where(s => s.Grade >= 85).ToList();
            var gradesArray = students.Select(s => s.Grade).ToArray();

            Console.WriteLine("Top students (grade >=85):");
            foreach (var s in topStudents)
                Console.WriteLine($"{s.Name} - {s.Grade}");
            Console.WriteLine();

            Console.WriteLine("Grades array:");
            foreach (var grade in gradesArray)
                Console.WriteLine(grade);
            Console.WriteLine();

            Console.WriteLine("=== End of LINQ Examples ===");
        }
    }  
}
