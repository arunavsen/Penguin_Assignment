using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Routine> routines = new List<Routine>();
            
            routines.Add(new Routine()
            {
                Id = 0,
                Subject = "English Grammar",
                Teacher = "John Smith"
            });
            routines.Add(new Routine()
            {
                Id = 4,
                Subject = "Mathematics",
                Teacher = "Lara Gilbert"
            });
            routines.Add(new Routine()
            {
                Id = 2,
                Subject = "Physics",
                Teacher = "Johanna Kabir"
            });
            routines.Add(new Routine()
            {
                Id = 3,
                Subject = "Chemistry",
                Teacher = "Danniel Robertson"
            });
            routines.Add(new Routine()
            {
                Id = 1,
                Subject = "Biology",
                Teacher = "Larry Cooper"
            });
            
            Console.WriteLine("A. Create Routin \nB. Show Routine \nC. List Courses with Teachers Name");
            var input = Console.ReadLine();

            if (input == "C")
            {
                foreach (var f in routines)
                {
                    Console.WriteLine(f.Subject +","+f.Teacher);
                }
            }else if (input == "A")
            {
                foreach (var f in routines)
                {
                    Console.WriteLine(f.Id + ". " + f.Subject);
                }
            }else if (input == "B")
            {
                
                    for (int i = 0; i < 4; i++)
                    {
                        foreach (var g in routines)
                        {
                            if (i == g.Id)
                            {
                                Console.WriteLine("0 " + g.Id + " " + g.Subject);
                                break;
                            }
                        }
                    }
                
            }
        }

        
    }
}
