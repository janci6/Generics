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
            try
            {
                zoznam.Add(s.tcislo, s);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString()); // odchytenie  vinimky v pripade ze sa nepodari pridat kluc do dictionary ... napr duplicitny kluc 
            }
            
        }
        public bool Find(string tcislo, out student s)
        {
            return zoznam.TryGetValue(tcislo, out s);
        }
    }
}
