using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Students
{
    class Faculty
    {
        private List<Group> groups = new List<Group>();
        public void add_group()
        {
            Console.WriteLine("введiть назву групи:");
            string name = Console.ReadLine();
            groups.Add(new Group(name));
        }
        public void add_student_to_group()
        {
            Console.WriteLine("введiть назву групи:");
            string name = Console.ReadLine();
            Console.WriteLine("введiть iм'я студента:");
            string sname = Console.ReadLine();
            Console.WriteLine("введiть успiшнiсть студента good/bad:");
            string success = Console.ReadLine();
            
            if (success == "good")
            {
                groups.Find(a => a.GetName() == name).AddStudent(new GoodStudent(sname));
            }
            else
            {
                groups.Find(a => a.GetName() == name).AddStudent(new BadStudent(sname));
            }
        }
        public void get_info()
        {
          foreach(Group gr in groups)
            {
                gr.GetFullInfo();
            }
        }
    }
    class Group
    {
        private string name;
        private List<Student> group = new List<Student>();
        public Group(string name_)
        {
            name = name_;
        }
        public void AddStudent(Student sd)
        {
            group.Add(sd);
        }
        public void Getinfo()
        {
            Console.WriteLine(name); //ім'я групи
            foreach(Student s in group)
            {
                Console.WriteLine(s.GetName());
            };
        }
        public void GetFullInfo()
        {
            Console.WriteLine(name);
            foreach (Student s in group)
            {
                Console.Write(s.GetName() + " ");
                Console.WriteLine(s.GetState());
            };
        }
        public string GetName()
        {
            return name;
        }
    }
    abstract class Student
    {
        public Student(string name_)
        {
            name = name_;
            state = "";
        }
        public void Relax()
        {
            state += "Relax ";
        }
        public void Read()
        {
            state += "Read ";
        }
        public void Write()
        {
            state += "Write ";
        }
        abstract public void Study();
        public string GetName()
        {
            return name;
        }
        public string GetState()
        {
            return state;
        }
        protected string name;
        protected string state;
    }

    class GoodStudent : Student
    {
        public GoodStudent(string name_):base(name_)
        {
            state += "Good ";
        }
        public override void Study() 
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
        }
    }

    class BadStudent : Student
    {
        public BadStudent(string name_) : base(name_)
        {
            state += "Bad ";
        }
        public override void Study()
        {
            Relax();
            Relax();
            Relax();
            Relax();
            Read();
        }
    }
}
