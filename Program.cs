using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema
{
    class Program
    {
        static void Main()
        {
            Student s1 = new Student("Ciotir","Ciprian","3122B",5);
            Student s2 = new Student("test", "test2", "another test", 4);
            Console.WriteLine(s1.Info());
            Console.WriteLine(s2.Info());
            Console.ReadKey();
        }
    }
}
