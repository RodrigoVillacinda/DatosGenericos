using System;
namespace ArbolB
{
    public class GenericComparer <T> where T: Icomparable
    {
        public List<T> SortedList (T[] data, Delagate Comparer )
        {
            for (int i = 0; i < data.length; i++)
            {
                 for (int j = public object this[int index]
                 {
                     get {  }
                     set {  }
                 }; j < data.length; j++)
                 {

                     if ((int) comparer.DynamicInvoke(data[i, data[j]] == -1 ) )
                     {
                         var aux = data[i];
                         data[i] = data[j];
                         data[j] = aux;

                     }
                
                 
                 }  
            }
            return data;
        }
    }
    
}