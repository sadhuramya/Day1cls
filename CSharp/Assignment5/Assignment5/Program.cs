
using System;

namespace Assignment5

{
    abstract class Student
    {
        public string Name; public int StudentId; public Double Grade;

        public abstract Boolean Ispassed(Double Grade);

    }

    class UnderGraduate : Student
    {
        public override Boolean Ispassed(Double Grade)

        { if (Grade >= 70) return true; 
            else return false; }

    }

    class Graduate : Student
    {
        public override Boolean Ispassed(Double Grade)
        {
            if (Grade >= 80) return true; 
            else return false;

        }
        static void Main(string[] args)
        {
            Student st = new UnderGraduate(); 
            st.StudentId = 101;
            Console.WriteLine("Student Id is : " + st.StudentId);

            st.Name = "Ramya";
            Console.WriteLine("Student Name is : " + st.Name);

            st.Grade = 70;
            Console.WriteLine("Student Grade for UnderGraduate is : " + st.Grade); 

            Console.WriteLine(st.Ispassed(70));

          

            st = new Graduate(); 
            st.Grade = 80;
            Console.WriteLine("Student Grade for Graduate is : " + st.Grade);
            Console.WriteLine(st.Ispassed(80));

            Console.Read();

        }

    }

}

