using System;
using System.Collections.Generic;
using System.Text;

namespace Genericsintro
{
    class MyList<T>
    {
        T[] items;
        //constructor- bir class newlendiğinde çalışan eleman
        public MyList()
        {
            items = new T[0];
        }
        
        public void Add(T item)
        {

        }


    }
}
