using System;

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
