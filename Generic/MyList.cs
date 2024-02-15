using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
  
    class MyList<T>
    {

        T[] items;

        //Constructor 
        public MyList()
        {
            items = new T[0];    //ilk oluştuğunda 0 elemanlı bi dizi oluşturdu.
        }
        public void Add(T item)
        {
            T[] tempArray = items; //geçici dizi(tempArray)'ye  dizimin elemanları new'lediğim an(aşağıda olduğu gibi) önceki elemanlar uçmasın diye sabitledim.

            items = new T[items.Length+1]; //Dizimin eleman sayısını 1 artır. 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                
            }
            items[items.Length - 1] = item;
        }
        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
