// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

String strUser = string.Empty;
String strPass = string.Empty;

//                                  //Vamos a crear nuestro cliente
//                                  //  de nuestra interfaz.
ServiceReferenceLogin.IloginServiceClient objCliente = 
    new ServiceReferenceLogin.IloginServiceClient();

//                                  //Ya que tenemos nuestro cliente, 
//                                  //    entonces ya podemos simular
//                                  //    el uso de nuestro servicio.
Console.WriteLine("Ingresar Usuario:");
strUser = Console.ReadLine();

Console.WriteLine("Ingresar la contraseña:");
strPass = Console.ReadLine();

//                                  //Mandamos a llamar a nuestro
//                                  //    servicio para validar.
if (
    await objCliente.boolValidateLoginAsync(strUser, strPass)
    )
{
    Console.WriteLine("Conexion exitosa");
}
else
{
    Console.WriteLine("Conexion fallida");
}

Console.ReadKey();


