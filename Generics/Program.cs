using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            telefonnyzoznam telefonnyzoznam = new telefonnyzoznam();

            telefonnyzoznam.Addstudent(new student { tcislo = "84984939393", meno = "ignac", });


            telefonnyzoznam.Addstudent(new student { tcislo = "84984939383", meno = "igor", });

            student s = new student();
            if(telefonnyzoznam.Find("84984939393", out s))
            {
                Console.WriteLine(s.meno);
                Console.WriteLine(s.tcislo);
            }

            if (telefonnyzoznam.Find("893", out s))
            {
                Console.WriteLine(s.meno);
                Console.WriteLine(s.tcislo);
            }
            else
            {
                Console.WriteLine("zaznam neexistuje");
            }

            Console.ReadLine();

        }
    }
}
