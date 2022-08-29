using System;
using System.Linq;

namespace PrograIntermedia {
    internal class GenericMap<T> where T : Abstract {
        private T[] arr = new T[5] ;
        
        /// <summary>
        /// Returns or Sets a 'T' element of the array 'arr' at the index 'i'
        /// </summary>
        /// <param name="i">index</param>
        /// <returns> T element </returns>
        public T this [int i] {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        /// <summary>
        /// Returns o Sets the value of the element where the 'key' is equal to 'index'
        /// </summary>
        /// <param name="index"></param>
        /// <returns>int value</returns>
        /// <exception cref="Exception">If the key doesn't exist</exception>
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
