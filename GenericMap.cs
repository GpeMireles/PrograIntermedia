using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograIntermedia {
    internal class GenericMap<T> where T : Abstract {
//        private List<T> array = new List<T>();
        private T[] arr = new T[5] ;
        
        public T this [int i] {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        public int this[string index] {
            get {
                int idx = arr.ToList<T>().FindIndex(a => a.Key == index);
                return idx >= 0 ? arr[idx].Value : throw new Exception("Key doesn't exist");
            }
            set {
                arr[arr.ToList<T>().FindIndex(a => a.Key == index)].Value = value;
            }
        }
    }
}
