using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class telefonnyzoznam
    {
        Dictionary<string, student> zoznam = new Dictionary<string, student>();

        public void Addstudent(student s)
        {
            zoznam.Add(s.tcislo, s);
        }
    }
}
