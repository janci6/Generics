using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class smallstack
    {
        // nasa vlastna trieda v pripade ze by nebol system collections generic ...
        private int[] Pole = new int[10];

        private int index = 0;

        public void Push(int cislo)
        {
            if(index == Pole.Length -1)
            {
                // index uz je na konci pola a preto nesmiem pridat preto vyhadzujem vynimku
                throw new IndexOutOfRangeException();

                
            }
            Pole[index] = cislo;
            index++;
        }
        public int Pop()
        {
            if(index -1 < 0)
            { 
                throw new IndexOutOfRangeException();
            }
            return Pole[index--];
            
        }
    }
}
