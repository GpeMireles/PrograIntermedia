using System;


namespace PrograIntermedia {
    internal class NullException : NullReferenceException {
        public NullException(string message) : base(message) { }
    }
}
