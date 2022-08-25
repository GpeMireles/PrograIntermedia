using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograIntermedia {
    internal abstract class Abstract {
        public string Key;
        public dynamic Value;
    }

    internal class Derivate : Abstract {
        public Derivate(string key, dynamic value) {
            this.Key = key;
            this.Value = value;
        }
    }

}
