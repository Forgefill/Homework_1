using System;
using System.Collections.Generic;
using System.Net.Security;

namespace Students
{
    class Students
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Перелiк команд:\nдодати нову групу: add_group\nдодати студента до групи:add_student\nотримати iнформацiю про факультет:get_info");

            Faculty faculty = new Faculty(); // класс факультет для більш простої роботи з набором груп

            while(true)   // взаємодія з користувачем через консоль
            {
                string s = Console.ReadLine();
                if (s == "end") break;
                else if (s == "add_group")
                {
                    faculty.add_group();
                }
                else if (s == "add_student")
                {
                    faculty.add_student_to_group();
                }
                else if(s == "get_info")
                {
                    faculty.get_info();
                }
            }
        }
    }
}
