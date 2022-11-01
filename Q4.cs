using System;

namespace Assesment
{
    internal class Design_display
    {
        static public void headerMessage(string Company_name)
        {
            Console.WriteLine(Company_name + " Employee Information");
        }
        static public void footerMessage(int Year)
        {
            Console.WriteLine("Copyright " + Year + "\nAll rights reserved");
        }
        static public void entireMessage(string Company_name, string Employee_name, string Project_Name, int Year)
        {
            headerMessage(Company_name);
            Console.WriteLine(Employee_name + "\n" + Project_Name);
            footerMessage(Year);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Company Name: ");
            string com_name = Console.ReadLine();
            Console.WriteLine("Enter the Employee Name: ");
            string emp_name = Console.ReadLine();
            Console.WriteLine("Enter the Project Name: ");
            string proj_name = Console.ReadLine();
            Console.WriteLine("Enter the Year: ");
            int year = int.Parse(Console.ReadLine());

            
            entireMessage(com_name,emp_name,proj_name,year);
        }
    }
}