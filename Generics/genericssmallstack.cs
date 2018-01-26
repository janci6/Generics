using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class genericssmallstack<T>
    {
        // nasa vlastna trieda v pripade ze by nebol system collections generic ...
        private T[] Pole = new T[10];

        private int index = 0;

        public void Push(T obj)
        {
            if (index == Pole.Length - 1)
            {
                // index uz je na konci pola a preto nesmiem pridat preto vyhadzujem vynimku
                throw new IndexOutOfRangeException();


            }
            Pole[index] = obj;
            index++;
        }
        public T Pop()
        {
            if (index - 1 < 0)
            {
                throw new IndexOutOfRangeException();
            }
            return Pole[index--];
        }
    }
}
