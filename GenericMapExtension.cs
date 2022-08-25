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
        public static Derivate First(this GenericMap<Derivate> map) {
            return map[0];
        }
    }
}
