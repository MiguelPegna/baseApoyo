<?php
// Conexión a la base de datos y otras configuraciones

// Obtener la clave de usuario de la solicitud
$userKey = $_SERVER['HTTP_AUTHORIZATION'] ?? '';

// Consultar la base de datos para obtener la clave de usuario asociada al usuario
// Aquí asumimos que $storedUserKey contiene la clave almacenada en la base de datos
$storedUserKey = "clave_del_usuario_desde_la_base_de_datos";

// Verificar si la clave de usuario proporcionada coincide con la clave almacenada
if ($userKey === $storedUserKey) {
    // Clave de usuario válida, permitir el acceso a la API
    // Aquí puedes continuar con el manejo de la solicitud de la API
    echo "Acceso concedido a la API";
} else {
    // Clave de usuario no válida, denegar el acceso a la API
    http_response_code(401); // Unauthorized
    echo "Acceso denegado. Clave de usuario inválida.";
}


///jwt sesion
require_once('vendor/autoload.php');

use \Firebase\JWT\JWT;

// Datos del usuario que inició sesión
$userData = array(
    "id" => 123,
    "username" => "usuario123",
    "role" => "admin"
);

$secretKey = "tu_clave_secreta";

// Generar el JWT
$jwt = JWT::encode($userData, $secretKey);

// Enviar el JWT al cliente (por ejemplo, en la respuesta a la solicitud de inicio de sesión)
echo json_encode(array("token" => $jwt));

//EVITAR CORS
// Permitir solicitudes desde cualquier origen
header("Access-Control-Allow-Origin: *");

// Permitir los métodos POST desde cualquier origen
header("Access-Control-Allow-Methods: POST");

// Permitir que las cabeceras sean enviadas con la solicitud
header("Access-Control-Allow-Headers: Content-Type");

// Establecer el tipo de contenido de la respuesta como JSON
header("Content-Type: application/json");

// Verificar que la solicitud sea de tipo POST
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Procesar la solicitud POST
    // Aquí puedes manejar la lógica de tu aplicación para la solicitud POST
    // Por ejemplo, recibir datos del formulario y procesarlos
    // Luego, enviar una respuesta JSON
    $response = array("message" => "Petición POST recibida correctamente");
    echo json_encode($response);
} else {
    // Si la solicitud no es de tipo POST, devolver un mensaje de error
    http_response_code(405); // Método no permitido
    $errorResponse = array("error" => "Método no permitido. Esta API solo acepta solicitudes POST.");
    echo json_encode($errorResponse);
}
?>