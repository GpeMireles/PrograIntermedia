using System;

namespace PrograIntermedia {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            
            // 1.- Operador ternario
            Random random = new Random();
            int variableRandom = random.Next(0,1000);
            string texto = variableRandom > 500 ? "Grater than 500" : "Less than";

            // 2.- Nullable & Exceptions Creation
            double? nullable = null;
            try {
                bool xd = nullable == null ? new NullException("Valor invalido").ThrowNullException() : print("Valor Valido");
                //ternary(nullable);
            }
            catch(NullException e) {
                Console.WriteLine(e.Message);
            }

            // 3.- Anomymus & 
            var anonimo = new { Name = "Azereth", Age = 21};
            Console.WriteLine($"Name: {anonimo.Name}\nAge: {anonimo.Age}");
            dynamic dynamicVar = 5.2;
            Console.WriteLine(dynamicVar);
            dynamicVar = "I'm String";
            Console.WriteLine(dynamicVar);
            dynamicVar = new { Figure = "Triangle", Base = 3, height = 2.5 };
            Console.WriteLine(dynamicVar);
        }

        private static bool print(string _string) {
            Console.WriteLine(_string);
            return true;
        }
    }
}
