<?php
    /*Definiciones
    Metodo constructor: El metodo constructor es un metodo mágico en PHP que se ejecuta al instanciar
    la clase lo que quiere decir que no es necesario llamarlo para poder ejecutarlo ya que lo hace de 
    manera automatica.
    Todas las clases tienen un método constructor solo que ne algunas no es necesario crearlo y en 
    otras si.
    Generalmente se usa para definir o dar valor a los atributos de la clase de inicio
    */
    class Contacts{
        public $name;
        public $age = 0;
        public $country;

        public function __construct($name, $age, $country){
            $this->name = $name;
            $this->age = $age;
            $this->country = $country;
            
        }

        public function saludo(){
            return 'saludos desde la clase que saluda '. $this->name;
        }
    }

    /*Cada vez que se instancie la clase sera necesario pasarle los parametros que en el cosntructor 
    se han definido de lo contrario marcara error
    Esto solo es en la clase no asi en los metodos
    */
    $contact = new Contacts('Rambo', 35, 'USA');
    print_r($contact);
    echo $contact->name;
    echo $contact->age .'<hr>';

    //Instanciamos el metodo saludo
    echo $saludo = $contact->saludo();