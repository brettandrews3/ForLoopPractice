using System;

namespace ForLoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentNames = new string[] { "Michael", "Anyong", "Lucille" };
            foreach (var student in studentNames)
            {
                Console.WriteLine(student);
            }

            
            }
        }
    }

