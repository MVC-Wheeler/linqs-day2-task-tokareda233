namespace Linq_sheet
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public double GPA { get; set; }
    }
    
public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
    }
    
public class Enrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            var students = new List<Student>
            {
             new Student { Id = 1, Name = "Ahmed Ali", Age = 21, Department = "CS", GPA = 3.6 },
             new Student { Id = 2, Name = "Sara Mohamed", Age = 20, Department = "IT", GPA = 3.2 },
             new Student { Id = 3, Name = "Omar Hassan", Age = 22, Department = "CS", GPA = 2.8 },
             new Student { Id = 4, Name = "Mona Adel", Age = 19, Department = "IS", GPA = 3.9 },
             new Student { Id = 5, Name = "Youssef Kamal", Age = 23, Department = "CS", GPA = 2.4 },
             new Student { Id = 6, Name = "Aya Mostafa", Age = 21, Department = "IT", GPA = 3.5 },
             new Student { Id = 7, Name = "Hassan Mahmoud", Age = 24, Department = "IS", GPA = 1.9 },
             new Student { Id = 8, Name = "Nada Fathy", Age = 20, Department = "CS", GPA = 3.1 },
             new Student { Id = 9, Name = "Ali Samir", Age = 18, Department = "IT", GPA = 2.6 },
             new Student { Id = 10, Name = "Reem Tarek", Age = 22, Department = "IS", GPA = 3.7 },
             new Student { Id = 11, Name = "Amr Nabil", Age = 21, Department = "CS", GPA = 4.0 },
             new Student { Id = 12, Name = "Laila Ashraf", Age = 19, Department = "IT", GPA = 2.2 }
            };



            var courses = new List<Course>
 {
     new Course { Id = 1, Title = "C# Fundamentals", Credits = 3 },
     new Course { Id = 2, Title = "OOP", Credits = 4 },
     new Course { Id = 3, Title = "Databases", Credits = 3 },
     new Course { Id = 4, Title = "ASP.NET MVC", Credits = 4 },
     new Course { Id = 5, Title = "LINQ Deep Dive", Credits = 2 }
 };



            var enrollments = new List<Enrollment>
{
    new Enrollment { StudentId = 1, CourseId = 1 },
    new Enrollment { StudentId = 1, CourseId = 2 },

    new Enrollment { StudentId = 2, CourseId = 1 },
    new Enrollment { StudentId = 2, CourseId = 3 },

    new Enrollment { StudentId = 3, CourseId = 2 },

    new Enrollment { StudentId = 4, CourseId = 4 },
    new Enrollment { StudentId = 4, CourseId = 5 },

    new Enrollment { StudentId = 6, CourseId = 3 },
    new Enrollment { StudentId = 6, CourseId = 4 },

    new Enrollment { StudentId = 8, CourseId = 1 },

    new Enrollment { StudentId = 10, CourseId = 2 },
    new Enrollment { StudentId = 10, CourseId = 3 },

    new Enrollment { StudentId = 11, CourseId = 5 }
};

            //1

            //var names=students.Select(x => x.Name).ToList();
            //foreach(var name in names)
            //{
            //    Console.WriteLine($"Name: {name}");
            //}


            //2

            //var n_gpa = students.Select(e => new { e.Name, e.GPA });
            //foreach(var n in n_gpa)
            //{
            //    Console.WriteLine($"Name: {n.Name} , GPA: {n.GPA}");
            //}

            //3

            //var check_gpa = students.Any(e => e.GPA > 3.8);
            //Console.WriteLine(check_gpa);

            //4

            //var check_Age = students.All(e => e.Age > 18);
            //Console.WriteLine(check_Age);


            //level 1 - 1 1.	Get students whose age is greater than 20.

            //var s_greater20 = students.Where(e => e.Age > 20).ToList();
            //foreach(Student student in s_greater20)
            //{
            //    Console.WriteLine($"Name: {student.Name} , Age: {student.Age}");
            //}


            //2 2.	Get students from the "CS" department.
            //var csstud = students.Where(e => e.Department == "CS").ToList();
            //foreach(var cs in csstud)
            //{
            //    Console.WriteLine($"Name: {cs.Name} , Department: {cs.Department}");
            //}



            //3 3.	Select Name and Department for all students.
            //var n_Department = students.Select(e => new { e.Name, e.Department });
            //foreach(var n in n_Department)
            //{
            //    Console.WriteLine($"Name: {n.Name} , Department: {n.Department}");
            //}


            //4 4.	Order students by GPA ascending.
            //var GPA_order=students.OrderBy(e=>e.GPA).ToList();
            //foreach (var n in GPA_order)
            //{
            //    Console.WriteLine($"Name: {n.Name} , GPA: {n.GPA}");
            //}


            //5 5.	Order students by GPA descending then Name ascending.
            //var GPA_Names_order=students.OrderByDescending(e=>e.GPA).ThenBy(e=>e.Name).ToList();
            //foreach (var n in GPA_Names_order)
            //{
            //    Console.WriteLine($"Name: {n.Name} , GPA: {n.GPA}");
            //}


            // 6 6.	Get the top 5 students by GPA
            //var top5=students.OrderByDescending(e=>e.GPA).Take(5).ToList();
            //foreach (var n in top5)
            //{
            //  Console.WriteLine($"Name: {n.Name} , GPA: {n.GPA}");
            //}


            //7 7.	Check if any student has GPA less than 2.0.
            //var check_GPA_less2 = students.Any(e => e.GPA < 2.0);
            //Console.WriteLine(check_GPA_less2);

            //8 8.	Check if all students have GPA ≥ 2.0.
            //var c = students.All(e => e.GPA >= 2.0);
            //Console.WriteLine(c);


            //9 9.	Count total number of students.
            //var count= students.Count();
            //Console.WriteLine(count);

            //10 10.	Get students whose name length is more than 5 characters.
            //var n = students.Where(e=>e.Name.Length>5).ToList();
            //foreach (var i in n)
            //{
            //  Console.WriteLine($"Name: {i.Name} , GPA: {i.GPA}");
            //}



            //Level TWO 
            //1 1.	Count total number of students.
            //var count = students.Count();
            //Console.WriteLine(count);


            //2 2.	Find the maximum GPA.
            //var x = students.Max(e => e.GPA);
            //var f=students.FindAll(e => e.GPA == x);
            //foreach( var e in f)
            //{
            //    Console.WriteLine($"Name: {e.Name} , Age: {e.Age} , GPA: {e.GPA}");
            //}


            //3 3.	Find the minimum GPA
            //var m = students.Min(e => e.GPA);
            //var f = students.FindAll(e => e.GPA == m);
            //foreach (var e in f)
            //{
            //    Console.WriteLine($"Name: {e.Name} , Age: {e.Age} , GPA: {e.GPA}");
            //}



            //4 4.	Calculate the average GPA of all students
            //var avg=students.Average(e=>e.GPA);
            //Console.WriteLine(avg);


            // 5 5.	Calculate the average GPA for students in the "CS" department.
            //var avg = students.Where(e => e.Department == "CS").Average(e => e.GPA);
            //Console.WriteLine(avg);

            //6 6.	Get the sum of GPAs.
            //var sum = students.Sum(e => e.GPA);
            //Console.WriteLine(sum);

            //7 7.	Count students whose GPA is greater than the average GPA
            //var c = students.Where(e => e.GPA > students.Average(E => e.GPA)).Count();
            //Console.WriteLine(c);

            // 8 8.Take top 3 students by GPA, then calculate their average GPA.
            //var avg = students.Take(3).Average(e => e.GPA);
            //Console.WriteLine(avg);

            //9 9.	Skip the lowest 2 GPAs, then calculate the average GPA of the remaining students
            var skip = students.OrderBy(e => e.GPA).Skip(2).ToList();
            var avg = skip.Average(e => e.GPA);
            Console.WriteLine(avg);

            //10 10.	Find the student(s) with the highest GPA.
            //var h= students.Where(e=>e.GPA==students.Max(e=>e.GPA)).ToList();
            //foreach(var s in h)
            //{
            //    Console.WriteLine($"Name: {s.Name}, GPA: {s.GPA}");
            //}


            //11 check if the total number of students is greater than 20.
            //bool c=false;
            //if(students.Count() > 20)
            //{
            //    c= true;
            //}
            //Console.WriteLine(c);


            //Level 33333333

            //1 1.	Group students by Department.  o Show Department Name +Student Count.

            //var s = students.GroupBy(e => e.Department).ToList();
            //foreach (var student in s)
            //{
            //    Console.WriteLine($"Name :{}");
            //}




        }
    }
}
