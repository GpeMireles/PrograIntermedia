# PrograIntermedia
## 1. Operador ternario
#### En la clase Program.cs, cree una variable numerica de tipo entero con valor aleatorio de 0 a 999, posteriormente utilizando el operador ternario asigne a una variable string el texto “Greater than 500” cuando la variable numerica sea mayor que 500, o imprima “Less than” en caso contrario
#### Para el valor aleatorio puede utilizar: new Random().Next(0, 1000);
## 2. Creacion de Excepciones & Nullables
#### Cree una nueva Excepcion que herede de NullReferenceException, posteriormente en Program.cs asigne a una variable nullable(?) un valor nulo. A continuacion, utilice el operador ternario para arrojar la exception anterior cuando la variable nullable sea nula, en caso contrario imprimir en consola “Valor valido”. El bloque de codigo anterior Debera estar dentro de un try/catch() para no detener la ejecucion de program.cs.
## 3. Tipos anonimos y dinamicos.
### 3.1.Cree un tipo anonimo con las propiedades Name y Age, a continuacion imprima en consola ambas propiedes.
### 3.2.Declare una variable de tipo dinamico, asignele un valor numerico e imprima la variable en consola.
#### Asigne un valor de tipo string a la misma variable e imprimala en consola.
#### Nuevamente, asigne un valor a la misma variable, en esta occasion sera un nuevo objeto anonimo con 3 propiedades, imprima la variable en consola.
## 4. Generics & Indexers
### 4.1.Cree una clase abstracta que contenga dos propiedades, Key de tipo string y Value de tipo dinamico.
### 4.2. Cree una clase generica Map donde el parametro generico (T) solo permita clases derivadas de la clase abstracta anterior.
### 4.3. La clase Map Debera tener un arreglo privado de “T” como propiedad.
### 4.4. Utilizando indexacion, defina dos indexers publicos:
#### Donde el primer indexer reciba un valor entero que retorne el valor del arreglo en dicha posicion, o asignar un valor en el arreglo en dicha pocision cuando sea el caso.
#### El Segundo indexer recibira un valor de tipo string, y Debera retornar el valor del arreglo cuando la Key de este valor sea igual al valor proporcionado al indexer, y arrojar una exception en caso de no existir dicha Key.
#### 4.5.Muestre en Program.cs la funcionalidad de la clase generica y los indexers utilizando objetos de clases que deriven de la clase abstracta.
## 5. Extension de metodos
#### Cree un metodo de extension a la clase Map, el cual retorn el primer valor del arreglo T[].
#### Muestre un ejemplo de este metodo en Program.cs.
## 6. Regex
### Agregue un metodo de extension al tipo string , el cual utilice Regex para validar que la cadena de texto cumplas con:
#### Iniciar con 1 letra en Mayusculas, seguido de 3 letras minusculas y finalmente 4 digitos.
#### Ejemplos: Hola1234, Pass4332, ...
