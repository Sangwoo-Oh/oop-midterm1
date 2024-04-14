using System.Xml.Linq;
using static salary.CustomEnum;

namespace salary;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            CustomEnum customEnum = new CustomEnum("input.txt");

            // conditional max search
            bool l = false;
            double max = 0;
            Employee elem = new Employee();
            customEnum.read();
            while (customEnum.st == Status.norm)
            {
                if (!l && customEnum.e.name[0] == 'B')
                {
                    l = true;
                    max = customEnum.e.salary;
                    elem = customEnum.e;
                }

                if (l && customEnum.e.name[0] == 'B')
                {
                    if (customEnum.e.salary > max)
                    {
                        max = customEnum.e.salary;
                        elem = customEnum.e;
                    }                         
                }
                customEnum.read();
            }

            if (l)
            {
                Console.WriteLine("max: " + elem.ToString());
            }

        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
    }
}

