
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitmanTraining
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pitman Training. \nStudent Daily Report");
            
            Console.WriteLine("What course are you in?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine(yourCourse);


            Console.WriteLine("What page number");
            string pageNum = Console.ReadLine();
            Console.WriteLine("I am on  a page  : "+Convert.ToInt32(pageNum)+" .");
            
            Console.WriteLine("Do you need help with anything? Please answer with \"true\" or \"false\" .");
            
            string needHelp = Console.ReadLine();

            bool helpStatus = Convert.ToBoolean(needHelp);
            Console.WriteLine(helpStatus+" .");
            


            Console.WriteLine("Were there any positive experiences you'd like to share? Please provide specifics.");
            string posExp = Console.ReadLine(); 
            Console.WriteLine(posExp);

            Console.WriteLine("Is there any other feedback you’d like to provide?  Please be specific.");
            string othFeedback= Console.ReadLine();
            Console.WriteLine(othFeedback);


            Console.WriteLine("How many hours did you study today?");
            string qtyHours = Console.ReadLine();
            int qHours = Convert.ToInt32(qtyHours);
            Console.WriteLine("I studied for: \n" + qHours + " hours.");
            

            Console.WriteLine("Thank you for your responses.  An Instructor will respond shortly.  Have a great day!\nPress \"Enter\" Close ");
            Console.ReadLine();


        }
    }
}