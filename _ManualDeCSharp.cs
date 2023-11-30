//Manual de c# conceptos básicos programacion en consola.
//Escribir con dos diagonales representa los comentarios //Esto es un comentario
//Lo que escribamos como comentario no sera ejecutado esto nos servira para poder dar una breve descripcion de lo que nuestro codigo esta ejecutando
//Tema 1 IDE necesario y Entorno
//Para poder programar en C# debemos utilizar el ide de Visual Studio. su descarga es gratuita desde el sitio web de microsoft
//o algun sitio web que tenga un compilador de C# aunque cabe mencionar que estos compiladores online nos limitaran muchas cosas 
//pero sirven para aprende y ejecutar lo escencial del lenguaje como sentencias y ciertas funciones siempre y cuando se encuentren en el mismo archivo o en este caso ventana activa 
//Para poder programar de manera funcional y gratuitamente debemos descargar la versión de Visual Studio Community, la descarga llevara cierto tiempo y dependera de la conexion a internet.
//Al momento de desarrollar en c# empezaremos creando aplicaciones en modo consola esto para familiarizarnos sobre todo con la sintaxis del lenguaje
//cuando empezamos con nuestra primera aplicación se cargaran automaticamente unas lineas de codigo por defecto
//las cuales solo cargan las clases necesarias para crear un programa basico en c#
//Estas lineas de codigo vienen por defecto
//NOTA: si haces prueba en compiladores online las partes de ReadLine(); puede que te marquen error si es asi quesolo agrega Console. al ReadLine por lo tanto quedaria Console.ReadLine();
using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Si queremos importar una clase hecha por nosotros se le manda a llamar desde esta sección de la siguiente manera
using NombreDeMiClase; 

namespace NombreDePaquete{ 		//namespace se usa para llamar paquetes
    //bloques de codigo
    class programa{            //Las clases nos permiten ejecutar nuestro programa
     	static void Main(string[]args){     //Se define la función principal del programa y la primera que se va a ejecutar, es muy semejante a Java - En ella se escriben las instrucciones en codigo que se van a ejecutar
           //instruccionbes de codigo
           Console.WriteLine("Hola esto es un texto en C#");         //Escribe una linea con la cadena de texto deseada
           Console.ReadKey();                                        //mantiene activa la consola
     	}    //Fin de la llave de la función principal
    }      //fin llave de la clase
}      //fin llave del namespace

//TEma 2  variables
//Las variables c# se manejan muy parecido a c++ o java
//Definicion: Variable es un espacio asignado en memoria para su uso dentro de nuestro programa
//se declara el tipo de variable seguido de su nombre y posteriormente se le asigna una inicialización.
//Estos unos ejemplo de las variables mas usadas a la hora de programar.
int  numero1 = 2;         	//Declaramos una variable del tipo entero - int - con el nombre de numero1; con un valor de inicialización de 2
char caracter ='s'; 		//Declaramos una variable del tipo caracter - char - con el nombre de caracter; con un valor de inicialización de la letra s
string cadena ="Hola ";     //Declaramos una variable del tipo entero - int - con el nombre de cadena; con un valor de inicialización de cadena de caracteres de Hola
double decimal =3.1416;     //Declaramos una variable del tipo doble que representa a numeros decimales - double - con el nombre de decimal; con un valor de inicialización de 3.1416
bool valor = true;          //Declaramos una variable del tipo booleano que representa ya sea que el valor es verdadero o falso - bool - con el nombre de valor; con un valor de inicialización de verdadero 

//Imprimir variables en consola
//La manera de mostrar las variables en pantalla se hace de las siguientes formas
Console.Write("Este el el valor de la variable numero1"+ numero1);
Console.Write("Asi tambien se imprime el valor de la variable numero1 {0}", numero1);
Console.Write("Asi tambien se imprime el valor de la variable numero1 {0} y cadena {1}", numero1, cadena); //utilizando sub indices podemos imprimir mas variables en una sola linea

// TEMA 3: Operadores logicos, expresiones logicas y Operadores Aritmeticos
// Operadores logicos: generalmente los usamos para realizar comparaciones de valores, 
// seran de mucho uso al momento de ejecutar instrucciones if, while, for, case, do while, foreach que veremos mas adelante
// 	=		Asignación: Sirve para asignar valor a una variable
//	==      Igualdad: Sirve para comparar valores que sean iguales
//  !=      Diferente de: Permite comparar valores que sean diferentes
// 	>       Mayor que
//  < 		Menor que
//  >=      Mayor o igual que
//  <=      Menor o igual que

// Expresiones logicas: Se utiliza para el cumplimiento de 1 o mas valores &&(y): Tiene que cumplirse ||(o): puede cumplirse o no  !(negación): no se tiene que cumplir
//  &&      Y
//  ||      Ó
//  !       Negación 

//Operadores aritmeticos: Como su nombre lo indica nos seran de utilidad para realizar operaciones aritmeticas
//  +		Suma
//  - 		Resta
//  *       Multiplicación
//  /       División
//  %       El residuo de una división, no es muy común su uso
//  Para hacer esto debemos utilizar variables cuyo tipo sean: int, double o float que son variables del tipo numerico de mayor uso
// ejemplo Suma
int resultado=3+5;
Console.Write("La suma es {0}", resultado);  //  Al hacer esto en resultado se mostrara el total de la suma de 3+5 que es 8
// ejemplo resta
int resultado=10-7;
Console.Write("La resta es {0}", resultado);  //  Al hacer esto en resultado se mostrara el total de la resta de 10-7 que es 3
// ejemplo multiplicación
int resultado=9*9;
Console.Write("La resta es {0}", resultado);  //  Al hacer esto en resultado se mostrara el total de la multiplicación de 9*9 que es 81
// ejemplo división
double resultado=10/3;  //Declaramos una variable double porque el resultado mas aproximado a esta operación es un numero con decimales si usaramos un int nos devolveria un valor entero
Console.Write("La resta es {0}", resultado);  //  Al hacer esto en resultado se mostrara el total de la multiplicación de 10/3 que es 3.33

// TEMA 4: Capturar informacion del teclado.
// La manera más sencilla de capturar información por medio del teclado para interactuar con los programas en tiempo real es la sig.
//Ejemplo
string nombre="";   //Declaramos una variable cadena para almacenar el nombre que el usurio capturara
Console.Write("Cual es tu nombre?");  //Escribimos por consola preguntando cual es el nombre del usuario
nombre = ReadLine();  //En la variable nombre guardaremos la informacion que el usuario teclee por medio del ReadLine();
Console.Write("Hola, mucho gusto en conocerte {0}", nombre); //De esta manera imprimimos el valor de la variable en pantalla
Console.ReadKey();        // De esta manera mantenmos activa la consola

// Tema 5: Sentencia if, if else y If anidado
// Los if son sentencias conocidas mas como condiciones y ejecutan una instruccion de codigo siempre y cuando se cumpla la condicion requerida
// para usarlas utilizamos los operadores logicos y también podemos usar las expresiones logicas de &&(y), ||(o) o !(negacion) o las tres al mismo tiempo
// IF sencillo
int edad=18;         //Se declara una variable del tipo integer que tendra un valor de 18
if (edad >= 18){     //Indicamos utilizando operadores logicos que si la variable edad que tiene un valor de 18 es MAYOR O IGUAL QUE... 18
	Console.Write("Ya eres mayor de edad");  //Si la condicion se cumple entonces se imprimira en pantalla Ya eres mayor de edad
}  //Cerramos llave del if

//Los if sencillos se usan para ejecutar solo una instrucción de codigo cuando esta se cumple o sea que sea verdadera,
// pero si nosotros requerimos que si NO se cumple la condicion se ejecute otra instruccion de codigo que sería la falsa
// para ello requerimos usar un else que vendría teniendo un significando - De lo contrario o entonces
// Para dejarlo en terminos practicos mas sencillos usaremos el mismo ejemplo de la mayoria de edad donde declarabamos si la edad era igual o mayor que 18 nos imprimiera Ya eres mayor de edad.
// Pero si la edad hubiera sido menor a 18 no hubiera pasado nada ya que no condicionamos que se tendría que ejecutar si la edad fuese menor que 18
// Para ello utilizaremos un if else
//if else
int edad=16;         //Se declara una variable del tipo integer que tendra un valor de 16
if (edad >= 18){     //Indicamos utilizando operadores logicos que si la variable edad que tiene un valor de 16 es MAYOR O IGUAL QUE... 18
	Console.Write("Ya eres mayor de edad");  //Si la condicion se cumple entonces se imprimira en pantalla Ya eres mayor de edad
}  //Cerramos llave del if
else {   //Al usar un else también abrimos y cerramos una llave y con esto indicamos: Si edad no es MAYOR O IGUAL QUE... 16 entonces
	Console.Write("Todavia no eres mayor de edad");    //Al no cumplirse la condicion indicamos que entonces imprima Todavia no eres mayor de edad
}     //Cerramos la llave del else

//De esta manera con un if else cubrimos una sentencia verdadera cuando se cumple la condición y una falsa cuando no la condición no se cumple

//IF anidado: El uso de estas condiciones son más detalladas generalmente las usamos cuando queremos dar más de dos respuestas haciendo mas de una condicion
//Para este ejemplo usaremos ahora las expresiones logicas != (diferente de) y && (y) para ver también su uso y con variables del tipo char y string para mostrar que también se utilizan en este tipo de valores
//Generalmente estos if anidados los podemos ver en los sistemas de login de usuarios
//Ejemplo de if Anidado 
string usuario="user";			//Se declara una variable del tipo string que su valor sera user
string contrasena="pass";       //Se declara una variable del tipo string que su valor sera pass
char letra='M';                 //Se declara una variable del tipo char que su valor sera M    Las variables del tipo char por el espacio de memoria que tinene solo pueden representar una sola letra
if(usuario=="user" && contrasena=="pass" && letra=="M"){  //Declaramos que tanto la variable usuario y contrasena y letra las tres deben cumplir con la condicion para que se ejecute la instrccion de codigo
	Console.Write("Hola {0} tanto tu contraseña como letra son correctas bienvenido", usuario);  
}
else if(usuario=="user" && contrasena=="pass" && letra!='M'){  
	Console.Write("Hola {0} tu contraseña es correcta pero tu letra no intentalo otra vez", usuario);  
}
else if(usuario=="user" && contrasena!="pass" && letra!='M'){
	Console.Write("Hola {0} tu contraseña y letra son incorrectas, intentalo otra vez", usuario);  
}
else if(usuario=="user" && contrasena!="pass" && letra=='M'){
	Console.Write("Hola {0} tu contraseña es incorrecta pero la letra es correcta, intentalo otra vez", usuario);  
}
else if(usuario=="user" && contrasena!="pass" && letra=='M'){
	Console.Write("Hola {0} tu nick y letra son correctas pero la contraseña es incorrecta, intentalo otra vez", usuario);  
}
else if(usuario!="user" && contrasena!="pass" && letra=='M'){
	Console.Write("Hola {0} tu nick y contraseña son incorrecta pero la letra es correcta, intentalo otra vez", usuario);  
}
else{
	Console.Write("Hola {0} toda tu información es incorrecta, Acaso me quieres ver la cara de estupida?", usuario); 	
}

//Como vemos en este ejemplo un if anidado nos permite generar bastantes condiciones y si acompoñamos los if de los operadores logicos && (y) o ||(o) podemos hacer condiciones mucho mas especificas
// al usar && (y) la condicion se debe cumplir en su totalidad 
// al usar || (o) con que una sola parte de la condición se cumpla sera suficiente auque los otras declaraciones no se cumplan

//Tema 6: Sentenica Switch case
// Esta sentencia se podría decir que es muy parecida a un if anidado donde ejecutamos diferentes bloques de codigo segun la condicion que se cumpla
// el Switch case funciona de manera un tanto similar, solo que aqui no esperamos que se cumpla una condicion sino que nosotros podemos elegir que parte del codigo queremos ejecutar
// dentro de consola su uso mas comun es para hacer un menu de opciones
//Ejemplo Switch case
string opcion=""; 
Console.Write("Elije una vocal: ");
opcion = ReadLine();
switch (opcion){
	case "a": case "A":
         Console.Write("La letra A es la letra 1 del abecedario");
	break;

	case "e": case "E":
         Console.Write("La letra E es la letra 5 del abecedario");
	break;

	case "i": case "I":
         Console.Write("La letra I es la letra 9 del abecedario");
	break;

	case "o": case "O":
         Console.Write("La letra O es la letra 15 del abecedario");
	break;

	case "u": case "U":
         Console.Write("La letra U es la letra 21 del abecedario");
	break;

	default:
		Console.Write("No mames wey esa no es una vocal, no te quieras pasar de verg...");
	break;
}

//En el ejemplo lo usamos con letras pero de igual menra lo podemos ejecutar con numeros o cadenas de texto

//TEMA  7: senstencia While
// Esta sentencia es muy parecida al if solo que esta se le conoce como ciclo
// lo que significa que mientras la condicion se cumpla esta se seguira ejecutando
// Para evitar ciclos infinitos necesitamos hacer que nuestra variable de comparacion tenga un incremento cada vez que la sentencia se ejecuta
// While significa mientras por lo tanto estaremos diciendo mientras la condición se cumpla ejecuta la instruccion
// Ejemplo While
int i = 1;     // inicializamos la variable i en 1 para que ese sea su valor de inicio
while (i <= 10){    //condicionamos que la instruccion se repetira hasta que la variable i sea menor o igual que 10
	Console.WriteLine("{0} - Hola amigo", i);  //Esta instrucción se ejecutara hasta que i sea menor  o igual a 10 por lo que Hola Amigo se escribira 10 veces
	i++;      //De esta manera se realiza el autoincremento al poner la variable y con doble signo de + le indicamos que aumentar 1, podemos aumentar segun queramos si quiero aumentar de dos en dos entonces el autoincremento quedaria: i+2
} 

// TEma 8: Sentencia Do While
// Do While tambien es un ciclo y significa: Haz mientras 
// La diferencia entre el while y do while es que el while primero evalua la condicion y despues ejecuta ejecuta la instrucción
// y el do while primero ejecuta la instruccion que esta dentro del do y posteriormente evalua la condición para determinar si se sigue repitiendo o no
// por lo cual la instruccion se va a ejecutar por lo menos una vez
int i=1;
do{                    //Con declaramos que se haga o ejecute la siguiente instruccion
	Console.WriteLine("Esto se hace con Do While {0} de 5", i);
	i++;                  //De esta manera se realiza el autoincremento
}
while(i <= 5);   ///Declaramos que la seccion del do se va repetir su ejecución hasta que i sea menor o igual a 5

// Tema 9: Sentencia For
// For tambien es un ciclo y significa: Para o por
// La diferencia de los otros ciclos es que en el for tenemos una condicion de inicio, una condicion de salida y una condicion de incremento
// Para este ejemplo realizaremos una tabla de multiplicar
// ejemplo
int i, j;              //Declaramos variables en esta ocacion no las inicializamos por que i sera inicializada por el usuario y j por el for
Console.Write("Que tabla de multiplicar quieres saber? ");    //Preguntamos que tabla de multiplicar quiere saber el usuario
i = Convert.ToInt32(Console.ReadLine());         //Esta parte es nueva y realizamos un parseo para capturar un valor para una variable del tipo numerico usando Convert.ToInt32 convertimos a entero la entrada del valor que el usuario teclee ya que por defecto la entrada se toma como String y con esto la convertimos a entero para su uso numerico
Console.WriteLine("Tabla de multiplicar del {0}", i);   //Solo imprimimos en consola que se va a mostrar la tabla de multiplicar que el usuario escogio al darle valor a la variable i
for(j=1; j<=10; j++){     //En el ciclo for primero le damos valor de inicio a j que es de 1, despues declaramos que el limite de la repeticion del ciclo for sera hasta que j sea menor o igual a 10 y posteriormente le indicamos que el incremento sera de 1 en 1 al usar j++
	Console.WriteLine("{0} * {1} = " + i*j , i, j);  //imprimimos nuestra tabla de multiplicar al hacer que el valor de i se multiplique desde el 1 hasta el 10
}   

//TEma 10: Arrays o arreglos
// Definicion: Un array o arreglo lo podriamos definir como una variable pero de mator capacidad, una coleccion de elementos 
// el conteo de los elementos en un array siempre comienza desde 0 por lo cual el primer elemento del arreglo siempre tomara el subindice 0
// Todo los elemento del arreglo deben ser del mismo tipo lo que quiere decir que si mi arreglo sera del tipo entero solo puede almacenar valores del tipo entero y asi con un arreglo string, char, double, etc
// Ejemplo
// un Array o arreglo esta estructurado de la siguiente manera 
//tipo [] NombreArray = new tipo [Tamaño-Numero de elementos que guardara el arreglo];
int [] miArreglo = new int [5];
//Maneras de almacenar valores en los elementos de un arreglo
//nombreArreglo [Sun-indice que ocupara: siempre iniciamos de [0]= Valor del elemento;
//Quedaria de la siguiente forma
miArreglo [0]= 5;
miArreglo [1]= 15;
miArreglo [2]= 2;
miArreglo [3]= 1;
miArreglo [4]= 50;
//Para mostrar la informacion del arreglo ne pantalla es de la siguiente manera
Console.WriteLine(miArreglo[0]);  //Con esto solo mostramos el valor del subindice 0 para cambiar ese valor solo tendriamos que colocar el numero del sun indice que queramos imprimir
Console.WriteLine(miArreglo[2]);
Console.WriteLine(miArreglo[3]);
//Esta manera es meramente instructiva y solo para conocer la declaracion y estructura de un arreglo ya que esta no es la manera apropiada de mostrar la informacion de un arreglo en pantalla 
// La manera mas apropiada para el uso y manejo de arreglos se hace mediante los ciclos que previamente ya habiamos usado como el for el mas comun para esto hasta el while
// Usar Ciclo For Tanto para llenarlo como para mostrar todos los elementos del arreglo con pocas lineas de codigo
// Declaramos nuestro arreglo
string[] nombres = new string [5];
for(int i=0; i<=4; i++){   //Con este for llenaremos los elementos del Arreglo
	Console.Write("Escribe un nombre: ");
	nombres[i] = Console.ReadLine(); 
}
for(int j=0; j<=4; j++){                //Con este for mostramos en pantalla todos los elementos del Arreglo que llenamos
	Console.WriteLine("El nombre es: "+nombres[j]);
}
//Tambien podemos llenar y mostrar un arreglo con el ciclo While que es muy parecido al anterior y usaremos el mismo ejemplo solo que usando el ciclo while tanto para llenar como para imprimir
string[] nombres = new string [5];
int i=0; 
while(i <= 4){         	////while para llenar los elementos del arreglo
	Console.Write("Escribe un nombre: ");
	nombres[i] = Console.ReadLine();
	i++;
}
int j=0;				 
while(j <= 4){     			//while para imprimir los elementos del arreglo
	Console.WriteLine("El nombre es: " +nombres[j]);   
	j++;
}

//Como limpiar un arreglo
//En C# podemos vaciar o limpiar los elementos de un arreglo esto lo hacemos por medio de la función:
//Array.Clear(NombreArreglo, 0-Este valor indica desde que sub indice queremos borrar, 5- Aqui ponemos el tamaño dew nuestro arreglo);
Array.Clear(nombres, 0, 5);

// Tema 12: MATRICES
	//Las matrices son una especie de arreglo pero su capacidad de almacenamiento es mas amplio en una definicion mas sencillo una matriz es un arreglo de dos dimensiones
// Para poder tener un visualizacion mas clara de esto podriamos decir que una matriz es una tabla
// una matriz esta estructurado de la siguiente manera 
//tipo [,] NombreMatriz = new tipo [Tamaño-Numero de elementos que guardara el arreglo, Tamaño-Numero de elementos que guardara el arreglo];
int [,] matriz = new int [3, 3];  //Primero se definen las columnas (→←) y luego las fila (↓↑)
//Maneras de almacenar valores en los elementos de una matriz
//nombreArreglo [Sun-indice de la columna, subindice de la fila] = Valor del elemento;
//Quedaria de la siguiente forma
matriz [0, 2]= 5;
matriz [1, 0]= 15;
matriz [2, 1]= 55;
matriz [0, 1]= 25;
matriz [2, 0]= 99;
matriz [2, 2]= 66;
matriz [1, 2]= 34;
matriz [2, 1]= 21;
matriz [2, 1]= 10;
//Para entenderlo de mejor forma la matriz se visualizaria de la siguiente forma
//   |0 |1 |2 |
//   |--|--|--|
// 0 |10|15|99|
// 1 |25|21|55|
// 2 |5 |34|66| 

//Para imprimir los elementos de la matriz seria de la siguiente manera
Console.WriteLine(matriz[0, 2]);  //Con esto solo mostramos el valor del subindice 0, 2 esto imprimiria el numero 5 para cambiar ese valor solo tendriamos que cambiar los numeros de los sub indices del valor que queramos mostrar

//En este ejemplo colocamos los numero eusando los sub indices de manera un tanto aleatoria para compreder de mejor manera donde se colocan los numeros en la matriz
// A pesar de que en teoria la matriz es pequeña al ser 3*3 cuando Lo anizamos esta matriz nos permite almacenar 9 elementos
// Para poder llenar una matriz de manera dinamica y optima necesitamos hacerlo por medio de un ciclo anidado.
                              //i  j
string[,] nombres = new string [3, 3];
for(int i=0; i<3; i++){                 //Este for se ejecutara para las columnas
   for(int j=0; j<3; j++){              //Este for es para las filas
   	Console.Write("Escribe un nombre: ");
     nombres[i,j] = Console.ReadLine(); 
 }
}
//Para mostrar todos los elementos de una matriz de igual modo necesitamos un for anidado
for(int i=0; i<3; i++){   
   for(int j=0; j<3; j++){               
	Console.WriteLine("El nombre es: "+nombres[i,j]);
	}
}

//Tema 13: ArrayList o coleccion
// Estas son una estructura de datos que  nos permitira almacenar informacion
//Array list: Es un arreglo que va a guardar nuestra informacion en forma de lista solo que este puede cambiar el tamaño de la lista de manera dinamica
// La diferencia entre un Array(arrglo) y ArrayList ademas de su uso dinamico es que en un ArrayList podemos guardar valores de diferente tipo 
// a diferencia de un arreglo donde todos sus elementos tienen que ser del mismo tipo
//Para usar este metodo debemos importar la funcion necesario que se colocara en las primeras lineas del programa y es:
// using System.Collections;
//Estructura del ArrayList
// ArrayList NombreArrayList = new ArrayList ();
ArrayList hardware = new ArrayList ();
//Agregar elementos al ArrayList
//NombreArrayList.Add("Elemeto a guardar");
hardware.Add("mouse");
hardware.Add("Teclado");
hardware.Add("Monitor");
hardware.Add("GPU");
//Imprimir Elemento del arrayList
Console.WriteLine(hardware[2]);  //Imprime un elemnto especifico del ArrayList
Console.WriteLine(hardware.Count);  //Imprime el numero de elemento que contiene el ArrayList
Console.WriteLine(hardware);         //Imprime que es un ArrayList


//Stack - pila
//es una estructura de datos con orden lifo ultimo en entrar primero en salir
////Estructura del Stack
// Stack <restriccion de tipo de dato> NombrePila = new Stack <restriccion de tipo de dato> ();
//La restriciion no es necesaria solo cuando queramos manejar un datos en especifico
//Por defecto al igual que el array list acepta cualquier tipo de dato
//push es para insertar elementos de la pila
//pop es para sacar el ultimo elemento de la pila
//Ingresamos elementos a la pila
Stack  miPila = new Stack (); 
miPila.Push(10);
miPila.Push(21);
miPila.Push(69);
miPila.Push(92);
//sacar elemento de la pila
int num=0;
num = (int)miPila.Pop();
Console.WriteLine("El ultimo elemento de la pila es "+ num);
//Vaciar Pila
miPila.Clear();

//Queue - Cola
//es una estructura de datos con orden fifo primero en entrar primero en salir
////Estructura del Queue
// Estructura cola
//Queue NombreQueue =new Queue ();
Queue fila= new Queue();
//Agregar elementos a la cola
fila.Enqueue(5);
fila.Enqueue(4);
fila.Enqueue(92);
fila.Enqueue(21);
//sacar elemento de la cola
Console.WriteLine("El primer elemento en salir es: "+ fila.Peek());
//Vaciar el elemnto de la cola
fila.Dequeue();
//Vaciar cola
fila.Clear();

//HashTable
//Estructura HashTable
// Hashtable NombreHashtable = new Hashtable(); 
Hashtable tabla = new Hashtable();
//Agregar elemento Hashtable
tabla.Add("Teclado", 850);
tabla.Add("CPU", 7300);
tabla.Add("Monitor", 3800);
//Imprimir elemeto de la tabla
Console.WriteLine("El precio es: {0} ", tabla["CPU"]);

//Tema 14: Ciclo Foreach
//Ciclo semejante al for solo que este este mas destinado al menjo de arreglos
//Vreamos un arreglo
String[] nombres = {"Rambo", "Robocop", "Terminator", "Nico"};
//Estrubtura foreach
foreach(String nombre in nombres){
 Console.WriteLine("Este es: "+ nombre);
}

//tema 15: Funciones 
// una funcion es segmento de codigo que ejecuta una tarea en especifico siempre que nosotros lo llamemos
// NOTA: No se puede declarar una funcion dentro de otra funcion, las funciones son bloques de codigo independiente que a pesar que pueden trabajar
// dependiendo de otras funciones nunca van dentro de otras en su codigo
// Estas para un mayor entendimiento las podemos clasificar de la siguiente manera
// FUNCIONES QUE EJECUTAN CODIGO, FUNCIONES QUE DEVUELVEN VALORES, FUNCIONES QUE RECIBEN VALORES, FUNCIONES QUE RECIBEN Y DEVUELVEN VALORES
// A - FUNCIONES QUE EJECUTAN CODIGO
   // Como se forma y declara una funcion sencilla
// Modificador de acceso: Indicaremos si sera función pública, privada o protegida
// Tipo de valor: Se pone en caso de que una función nos devuelva un valor 
// Nombre de la funcion: miFuncion(Aqui van parametros: valores que recibe una funcion)
//{ }: Se abre llave donde estara el bloque de codigo a ejecutar y se cierra la llave para terminar la función
// ejemplo:
// Al crear nuestra funcion lo hacemos fuera de la funcion principal del programa, como habiamos dicho una funcion no puede estar dentro de otra funcion
// pero en una funcion podemos mandar a llamar a otra funcion
static void Main(string[]args){     //Se define la función principal del programa y la primera que se va a ejecutar, es muy semejante a Java - En ella se escriben las instrucciones en codigo que se van a ejecutar
           //instruccionbes de codigo
           miFuncion();         //Asi es como dentro de una funcion mandamos a ejecutar a otra funcion: solo escribiendo el nombre de la funcion
                                                   
     	}   
static void miFuncion() {   //static- Se usa static porque es funcion que se ejecuta dentro del mismo programa, no es un archivo independiente 	void - Es para declarar una funcion que no devolvera ningun valor toda funcion basica lleva void  miFuncion- Nombre de lafuncion  ()-Función que solo ejecuta codigo no va a recibir parametros
	Console.WriteLine("Este es el texto de la funcion miFuncion");
}

// FUNCIONES QUE DEVUELVEN VALORES:
static void Main(string[]args){     //Se define la función principal del programa y la primera que se va a ejecutar, es muy semejante a Java - En ella se escriben las instrucciones en codigo que se van a ejecutar
           //instrucciones de codigo
			int n=10;
			Console.WriteLine(n);
			Console.WriteLine(funcionDaValor());  //Asi es como dentro de una funcion mandamos a ejecutar a la función solo que ahora dentro de un Cosole.WriteLine();
                                                   
     	}   
static int funcionDaValor() {   //static- Se usa static porque es funcion que se ejecuta dentro del mismo programa, no es un archivo independiente 	int - Indicamos que queremos devolver un valor de tipo entero  funcionDaValor- Nombre de lafuncion  ()-Función que solo ejecuta codigo no va a recibir parametros
	int suma=21+53;  // Creamos una variable que suma dos numeros
	return suma;    //return: regresa el valor de la variavble suma	
}

// FUNCIONES QUE RECIBEN VALORES:
static void Main(string[]args){     //Se define la función principal del programa y la primera que se va a ejecutar, es muy semejante a Java - En ella se escriben las instrucciones en codigo que se van a ejecutar
    //instrucciones de codigo		
	funcionMultiplica(5, 5);  //Asi es como dentro de una funcion mandamos a ejecutar a la función y dentro de los parentesis ponemos los valores que vamos a enviar a nuestra funcion
                                     
}   
static void funcionMultiplica(int n, int z) {   //static- Se usa static porque es funcion que se ejecuta dentro del mismo programa, no es un archivo independiente 	void - Es para declarar una funcion basica  funcionMultiplicar- Nombre de lafuncion  (int n, int z)-Declaramos los parametros con lo s que se ejecutara nuestra funcion al ser valores enteros los declaramos como si fuesen variables dentro de los parentesisa
	int multiplica=n * z;  // Creamos una variable que suma dos numeros
	Console.WriteLine("La multiplicacion es de: "+ multiplica);
}
// FUNCIONES QUE RECIBEN Y DEVUELVEN VALORES:
static void Main(string[]args){     //Se define la función principal del programa y la primera que se va a ejecutar, es muy semejante a Java - En ella se escriben las instrucciones en codigo que se van a ejecutar
    //instrucciones de codigo
			
	Console.WriteLine("Hubo en el torneo " +funcionDivide(450, 3) + " goles");  //Asi es como dentro de una funcion mandamos a ejecutar a la función y dentro de los parentesis ponemos los valores que vamos a enviar a nuestra funcion combinando texto
}
   
static int funcionDivide(int n, int z) {   //static- Se usa static porque es funcion que se ejecuta dentro del mismo programa, no es un archivo independiente   int - Indicamos que queremos devolver un valor de tipo entero   funcionDivide- Nombre de lafuncion  (int n, int z)-Declaramos los parametros con los que se ejecutara nuestra funcion al ser valores enteros los declaramos como si fuesen variables dentro de los parentesisa
	int division=n/z;  // Creamos una variable que divide dos numeros
	return division;    //return: regresa el valor de la variavble division	
}

//TEMA 16 Clases
// Es la manera de potencializar el uso de la programacion orientada a objetos en C#
// Usamos clases para desglozar un problema grande en pequeños fracmentos que contienen la solucion a dicho programa
// esto nos sirve para optimizar nuestro trabajo y hacer bloques de codigo con atributos y metodos bien definidos
//una clase se define dentro del namespace
//ejem
namespace Algunnombre {
	class nombreClase{
		//atributos: Datos para usar, color , precio, modelo
		//metodos: Funciones que sevan a ejecutar
	}
}

//Tema 17: Objeto
// Un objeto en definicion sencilla es una variable del tipo clase
// ejemplo
namespace objeto{
	class indice{
		static void Main(string[]args) {
		automovil auto = new automovil();
		auto.velocidad=280;
		auto.precio=750000;
		Console.WriteLine("La velocidad del carro es {0} km/h y su precio es de ${1}", auto.velocidad, auto.precio);
		auto.arrancar();

	}
	}
	
class automovil{
	//atributos datos
	public int precio;
	public int velocidad;

	//metodos funciones
	public void arrancar(){     //arrancar es una funcion de la clase automovil
		Console.WriteLine("El auto esta listo para usarse");
	}
}
}

//TEMA 18: Modificadores de acceso
//Se utilizan para cambiar la manera en la que nosotros accedemos o disponemos de la imformacion contenida en una variable
// public: con esta propiedad podremos acceder a cualquier clase o dato que contenga esta propiedad 
// private: private mantiene en privado el acceso a cualquier clase con esta propiedad y solo se accedera a estos por medio de metodos

//TEMA 19: GET y SET
// son propiedades asignadas para lectura y escritura
//Usaremos el ejemplo anterior pero haciendo los atributos privados y accederemos a ellos por medio de metodos
namespace objeto{
	class indice{
		static void Main(string[]args) {
		automovil auto = new automovil();
		Console.WriteLine("La velocidad del carro es {0} km/h y su precio es de ${1}", auto.speed, auto.costo);
	}
}
	
class automovil{
	//atributos datos
	private int precio=750000;
	private int velocidad =280;

	//metodos funciones
	public int speed{     //arrancar es una funcion de la clase automovil
		get{                    //get devuelve valor
				return velocidad;
		}
		set{                   //set define sobreescritura del metodo
				velocidad=value;
		}
	}

	public int costo{
	    get {
	        return precio;
	    }
	    set {
	        precio=value;
	    }
	}
}
}
