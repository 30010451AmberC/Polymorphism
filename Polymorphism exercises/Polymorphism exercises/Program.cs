using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new ITStudent();
            s1.grade1 = 90;
            s1.grade2 = 100;
            s1.grade3 = 88;
            

            Student s2 = new BusinessStudent();

            Console.WriteLine($"Student Average: {s1.Sum()}");
            Console.WriteLine(s2.Highest());

            Student[] arr = new Student[2];
            arr[0] = s1;
            arr[1] = s2;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);

            /*foreach(object x in arr)
            {
                if (x.GetType().ToString() == "Console.App2.ITStudent")
                {
                    x.Sum();
                } else 
                {
                x.Highest();
                }
            }*/

        }
    }

    class Student
    {
        public int grade1 { get; set; }
        public int grade2 { get; set; }
        public int grade3 { get; set; }

        public virtual string Highest()
        {
            int highest = grade1;
            if (grade1 > grade2 && grade1 >grade3)
            {
                highest = grade1;
                return grade1.ToString();
            } else if (grade2 > grade1 && grade2 > grade3)
            {
                highest = grade2;
                return grade2.ToString();
            } else
            {
                return grade3.ToString();
            }
        }

        public virtual int Sum()
        {
            return grade1 + grade2 + grade3;
        }
    }

    class ITStudent : Student
    {
        public override int Sum()
        {
            return base.Sum() / 3;
        }
    }

    class BusinessStudent : Student
    {
        public override string Highest()
        {
            return $"{base.Highest()} is the largest grade for this student";
        }
        
    }
}
