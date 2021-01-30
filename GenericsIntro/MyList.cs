using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{           
    class MyList<T>//<içine istediğini yazabilirsin int, bool,string>
    {
        T[] items;
        public MyList()//ctor tab tab constructor 
        {
            items = new T[0];
        }
        public void Add(T item) //programcı mylist kullanırken içine ne koymuşsa pnu isteyecek add
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }

    }
}
