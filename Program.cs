using System;

namespace PrograIntermedia {
    internal class Program {
        static void Main(string[] args) {
            
            // 1.- Operador ternario

            Random random = new Random();
            int variableRandom = random.Next(0,1000);
            string texto = variableRandom > 500 ? "Grater than 500" : "Less than";

            // 2.- Nullable & Exceptions Creation
            double? nullable = null;
            try {
                _ = nullable == null ? throw new NullException("Valor invalido") : print("Valor Valido");
            }
            catch(NullException e) {
                Console.WriteLine(e.Message);
            }

            // 3.- Anomymus & dynamic types
            var anonimo = new { Name = "Azereth", Age = 21};
            Console.WriteLine($"Name: {anonimo.Name}\nAge: {anonimo.Age}");
            
            dynamic dynamicVar = 5.2;
            Console.WriteLine(dynamicVar);

            dynamicVar = "I'm String";
            Console.WriteLine(dynamicVar);

            dynamicVar = new { Figure = "Triangle", Base = 3, height = 2.5 };
            Console.WriteLine(dynamicVar);

            // 4.- Generics & Indexers
            Derivate derivate = new Derivate("Key", 4);
            GenericMap<Derivate> genericMap = new GenericMap<Derivate>();
            genericMap[0] = derivate;
            genericMap[1] = new Derivate("Key2", false);

            print($"Value at 'Key': {genericMap["Key"]}");
            print($"Key: {genericMap[1].Key} Value: {genericMap[1].Value}");


            // 5.- Extension method
            _ = genericMap.First().Value == genericMap["Key"] ? print("Extension method correcto") : print("Extension method incorrecto");

        }

        private static bool print(string _string) {
            Console.WriteLine(_string);
            return true;
        }
    }
}
