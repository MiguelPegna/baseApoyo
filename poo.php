<?php
    /*Definiciones
    Metodo constructor: El metodo constructor es un metodo mágico en PHP que se ejecuta al instanciar
    la clase lo que quiere decir que no es necesario llamarlo para poder ejecutarlo ya que lo hace de 
    manera automatica.
    Todas las clases tienen un método constructor solo que en algunas no es necesario crearlo y en 
    otras si.
    Generalmente se usa para definir o dar valor a los atributos de la clase desde el inicio

    Encapsulamiento: Basicamente se trata de esconder y proteger la información que manejara la clase
    Se usa para limitar el acceso a los atributos o metodos de una clase de la clase cuando creamos los 
    objetos esto se hace mediante los modificadores de acceso que nos permiten indicar los permisos que 
    tendrán los objetos para acceder a los metodos y propiedades de la clase
    public: Acceso desde cualquier parte del programa eso incluye otras clases e instancias del objetos 
    protected: Acceso solo en la misma clase y ne las clases que se heredan
    private: Acceso unicamente desde la misma clase

    GETTER y SETTER: Son metodos que le permiten a un objeto controlar el acceso a ciertas propiedades de 
    la clase (protegidas o Privadas)
    Getter: Permite obtener el valor de una propiedad de la clase y asi poder utilizar dicho valor en 
    doferentes metodos.
    Setter: Brinda acceso a propiedades especificas para poder signar un valor fuera de la clase

    Metodos o atributos estaticos: Se definen con la palabra reservada static estos deben ser siempre
    publicos y no se pueden instanciar simplemente se mandan a llamar por medio del operador llamado 
    Resolución de ámbito que se representa con el doble dos puntos :: que es un token que permite 
    acceder a elementos estáticos, constantes y sobrescribir propiedades y metodos de una clase
    Las propiedades estaticas no pueden ser accedidas por medio de un objeto
    static $atrEstatico = 'Esto es estatico';
    $Clase->$artEstatico;   //Si hacemos esto nos dara error
    $Clase::$atrEstatico    //Esta es la manera correcta de acceder a un atributo estatico

    Sin embargo los metodos estaticos si se pueden usar en objetos ejem.
    public static function metodo(){
        return 'Desde un metodo estatico';
    }
    $Clase = new Clase();
    $Clase->metodo();         //De esta manera se accede a un metodo estatico por medio de un objeto
    
    Los metodos estaticos no pueden acceder a propiedades que no sean estaticas. Si se quiere acceder 
    desde un metodo estatico a propiedades de tipo public, private o protected esto generara un error
    Para acceder a una propiedad estatica se usa la palabra reservada self de la sigs. maneras
    self::$atrEstatico;
    Clase::$atrEstatico;
    */
    
    class Contacts{
        public $name;
        public $age = 0;
        public $country;
        private $ine;

        public function __construct($name, $age, $country){
            $this->name = $name;
            $this->age = $age;
            $this->country = $country;
            
        }

        public function saludo(){
            return 'saludos desde la clase que saluda '. $this->name;
        }

        public static function frese(){
            return 'Esta es una frase del metodo estatico';
        }

        //ejemplo de setter
        public function setIne($ine){
            $this->ine = $ine;
        }

        //ejemplo de getter
        public function getIne(){
            return $this->ine;
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

    //usar un metodo estatico
    echo $this::frase();
