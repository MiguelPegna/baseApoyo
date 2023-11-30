alert('Suma de dos números');
let numA = prompt('Introduce el primer número', 0);
let numB = prompt('Introduce el segundo número', 0);
alert('La suma de los números es: ' + numA + numB);
document.write('La suma de los números es: ' + numA + numB);
////////////////////////////////Javascript conceptos

console.log("message"); //ejecuta un texto en consola consoleva en minusculas
//console es el entorno
//log el metodo
// en los parentesis () va la accion
document.write("message");

prompt("Es una pregunta?"); //prompt es una funcion de captura de datos como un alert
let respuesta = prompt("Es una pregunta?"); // se pasa a una variable lo que se obtenga del prompt:: let es mas optimo para declarar vars let es una variable por bloque
alert("Tu te llamas "+ respuesta);  //el signo de suma sirve para concatenar valores ya sea variables string  y cadenas de texto

numero1.concat(numero2); //concat es una funcion de concatencacion
let Frase = 'Ella es ${Variable} una sexy lesbiana'; //forma de concatenar seguido llamado backticks
**=2 // representa operacion con exponente

parseInt() //funcion que convuerte a entero
let arreglo=[1, 2, 3, 4,];
let pcArray{   //array asociativo
	nombre: "PenhitaPC";
	cpu: "Ryzen 5 3400g";
	ram: "8gb";
	ssd: "120gb";
	hdd: "500gb";
	gpu: "No tengo"; 
}
document.write(pcArray["ram"]);

break; //se puede utilizar tambiewn en los ciclos whiles para ternimar el ciclo

array1=["Aiffe", "Aine", "Sasha"];
array2=["Joanna", "Lesley", "Liz", array1];
for( let array in array){
	if(array2== 2){
		for(let array of array1){
			document.write(array + "<br>");
			continue
		}
	}else{
		document.wirte(array2[array]+ "<br>");
	}
	}

function nombreFunction(){   //funcion fija
	parametros de la funcion 
}

nombreFunction(); //se llama la funcion

function functionSuma(n1, n2){   //Declaramos uso de variables sin valor
	let total=n1+n2;
	document.write(res)+"<br>";
}
functionSuma(32,99); //se llama la funcion y se declaran los valores de las variables a sumar


=> //flecha se usa en funciones que solo usan un parametro
Checar ejemplo 3:55:57

POO
CLASES
No se puede tener un objeto con el mismo nombre de la clase
Un metodo es una funcion dentro de una clase
class animal{
	constructor(especie, edad, color){
		this.especie= especie;
		this.edad=edad;
		this.color=color;
		this.info='Soy ${this.especie}, tengo${this.edad} años y soy de color ${this.color},'
	}
	verInfo(){
		document.write(this.info+"<br>");
	}
}

let perro = new animal("Perro", 5, "cafe");
perro.verInfo();

HERENCIA
class CPerro extends CAnimal{
	constructor(especie, edad, color, raza){
		super(especie, edad, color);
		this.raza=raza;
}
static ladrar(){
	alert("WAuW");
}
}
const perro = new CPerro("Perro", 5, "cafe", "Chihuahua");
perro.verInfo();
perro.ladrar();


SETTERS y GETTERS
class CPerro extends CAnimal{
	constructor(especie, edad, color, raza){
		super(especie, edad, color);
		this.raza=null;
}
set setRaza(newName){
	this.raza= newName;
}
get getRaza(){
	return this.raza;
}
}
const perro = new CPerro("Perro", 5, "cafe", "Chihuahua");
perro.setRaza="Pedro";
document.write(perro.getRaza);

//Checar 4:53:00 para ver ejemplo de herencia