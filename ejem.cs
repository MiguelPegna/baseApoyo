/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main(string[] args) {
        string password="";
        string nuevo="";
        int pos=0;
        Console.Write("Escribe la palabra: ");
        String entrada = Console.ReadLine();
        
        string cadenaLimpia=entrada.Replace(' ', '-').Replace("-a-","-de-").Replace("-de-",",");
        
        //generamos arreglo de las palabras que generamos quitando espacios y preposiciones
        string[] separado = cadenaLimpia.Split(new char[] { ',' });
        //convertimos los string en arreglos letra por letra
        char[] arreglo1 = separado[0].ToCharArray();
        char[] arreglo2 = separado[1].ToCharArray();
        int limite= arreglo1.Length + arreglo2.Length;
        //ya que tenemos posicion por letra pasamos los arreglos a listas
        
        for(int i=0; i<=arreglo1.Length; i++){                
	        Console.WriteLine(arreglo1[i]);
	    }
        Console.WriteLine(nuevo);
        Console.WriteLine(separado[1].Length);
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
class HelloWorld {
  static void Main(string[] args) {
        string password="";
        string nuevo="";
        int pos=0;
        Console.Write("Escribe la palabra: ");
        String entrada = Console.ReadLine();
        
        string cadenaLimpia=entrada.Replace(' ', '-').Replace("-a-","-de-").Replace("-de-",",");
        
        //generamos arreglo de las palabras que generamos quitando espacios y preposiciones
        string[] separado = cadenaLimpia.Split(new char[] { ',' });
        Console.WriteLine(cadenaLimpia);
        
        //convertimos los string en arreglos letra por letra
        char[] arreglo1 = separado[0].ToCharArray();
        char[] arreglo2 = separado[1].ToCharArray();
        int limite= arreglo1.Length + arreglo2.Length;
        
        //ya que tenemos posicion por letra pasamos los arreglos a listas
        List<char> lst1 = arreglo1.ToList();
        List<char> lst2 = arreglo2.ToList();
            foreach (var element1 in lst1)
            {
                Console.WriteLine(element1);
            }
            
            foreach (var element2 in lst2)
            {
                Console.WriteLine(element2);
            }
            
        
        //for(int j=0; j<=arreglo1.Length; j++){                
	    //    Console.Write(arreglo1[j]+", \n");
	    //}
        Console.WriteLine(nuevo);
        Console.WriteLine(separado[1].Length);
  }
}