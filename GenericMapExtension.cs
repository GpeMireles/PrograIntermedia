using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrograIntermedia {
    internal static class GenericMapExtension {
        public static void aver() {
            Console.WriteLine();
        }
        public static T First<T>(this GenericMap<T> map) where T : Abstract {
            return map[0];
        }
    }
}
