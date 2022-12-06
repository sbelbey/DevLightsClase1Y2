// 1. Dado un valor, devolver un mensaje que diga “El valor es mayor que 100”
//sólo cuando se cumpla dicha condición.


//int num = 101;
//if (num > 100)
//{
//Console.WriteLine("El valor es mayor que 100");
//}


//2. Pedir un número entero por teclado y calcular si es par o impar.

//Console.WriteLine("Ingrese un número");
//int num = int.TryParse(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine("Su número es par");
//} else
//{
//    Console.WriteLine("Su número es impar.");
//}

//3. Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble
//de un impar. Por ejemplo, 14 cumple con esta condición.

//Console.WriteLine("Ingrese un número");
//int num = int.Parse(Console.ReadLine());
//int numDoble = 0;


//for (var i = num; i > 0; i--)
//{
//    if(i * 2 == num && i % 2 !=0)
//    {
//        numDoble = i;
//    }
//}

//if (numDoble > 0)
//{
//    Console.WriteLine("El numero ingresado es el doble del impar: " + numDoble);
//}else
//{
//    Console.WriteLine("El numero ingresado no es el doble de ningún impar.");
//}

//4. Dada un número del 1 al 10, devolver su “versión” en números romanos.

//Console.WriteLine("Ingrese un número del 1 al 10:");
//int num = int.Parse(Console.ReadLine());

//switch (num)
//{
//    case 1:
//        Console.WriteLine("I");
//        break;
//    case 2:
//        Console.WriteLine("I");
//        break;
//    case 3:
//        Console.WriteLine("III");
//        break;
//    case 4:
//        Console.WriteLine("IV");
//        break;
//    case 5:
//        Console.WriteLine("V");
//        break;
//    case 6:
//        Console.WriteLine("VI");
//        break;
//    case 7:
//        Console.WriteLine("VII");
//        break;
//    case 8:
//        Console.WriteLine("VIII");
//        break;
//    case 9:
//        Console.WriteLine("IX");
//        break;
//    case 10:
//        Console.WriteLine("X");
//        break;
//    default:
//        Console.WriteLine("Debió ingresar un valor del 1 al 10.");
//        break;
//}

//5. Leer el nombre y las edades de dos personas y devolver el nombre del
//menor. En caso de que tengan la misma edad también debe indicarse.
//Devolver también la diferencia de edad en caso de corresponder.


//Console.WriteLine("Ingrese el nombre de la primer persona:");
//string person1 = Console.ReadLine();

//Console.WriteLine("Ingrese el nombre de la segunda persona:");
//string person2 = Console.ReadLine();

//Console.WriteLine("Ingrese la edad de la primer persona:");
//int edad1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Ingrese la edad de la segunda persona:");
//int edad2 = int.Parse(Console.ReadLine());

//int dif = 0;

//if (edad1 > edad2) {
//    dif = edad1 - edad2;
//    Console.WriteLine(person1 + " es " + dif + " años mayor que " + person2);
//}
//else if (edad2 > edad1) {
//    dif = edad2 - edad1;
//    Console.WriteLine(person2 + " es " + dif + " año/s mayor que " + person1);
//}
//else
//{
//    Console.WriteLine(person1 + " y " + person2 + " tienen la misma edad.");
//}

// 6. Escribir un programa que calcule el tipo de un triángulo conociendo la
//longitud de sus 3 lados. También que calcule su perímetro y su área.

//Console.WriteLine("Ingrese la longitud del primer lado:");
//int long1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Ingrese la longitud del segundo lado:");
//int long2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Ingrese la longitud del tercer lado:");
//int long3 = int.Parse(Console.ReadLine());

//if (long1 == long2 && long1 == long3)
//{
//    Console.WriteLine("El triangulo es equilátero");
//}else if (long1 != long2 && long1 != long3 && long2 != long3)
//{
//    Console.WriteLine("El triangulo es escaleno");

//}else
//{
//    Console.WriteLine("El triangulo es equilátero");

//}


//Console.WriteLine("El peímetro del triangulo es: " + (long1 + long2 + long3));

//int p = (long1 + long2 + long3) / 2;
//double area = Math.Sqrt(p * (p - long1) * (p - long2) * (p - long3));
//Console.WriteLine("El área del triángulo es: " + area);

//7.Desarrolle un programa que calcule el desglose de una cantidad dada, en
//billetes y monedas tal que se minimice la cantidad de monedas y billetes.
//Considere las denominaciones $1000, $500, $100, $50, $20, $10, $5, $2, $1,
//donde los últimos tres son monedas. (Por ejemplo, para $1,723 se debe
//imprimir: “1 billete de $1000, 1 billete de $500, 1 billete de $200, 1 billete de
//$20, 1 moneda de $2, 1 moneda de $1). Obviar los signos de billete ($) y
//tratar todos los valores como números, para los cálculos.

//Console.WriteLine("Ingrese el monto que desea calcular: ");
//double valor = 0;
//valor = int.Parse(Console.ReadLine());

//double mil = 0;
//double quinientos = 0;
//double cien = 0;
//double cincuenta = 0;
//double veinte = 0;
//double diez = 0;
//double cinco = 0;
//double dos = 0;
//double uno = 0;
//string mensaje = "";

//mil = Math.Floor(valor / 1000);
//valor = valor % 1000;
//quinientos = Math.Floor(valor / 500);
//valor = valor % 500;
//cien = Math.Floor(valor / 100);
//valor = valor % 100;
//cincuenta = Math.Floor(valor / 50);
//valor = valor % 50;
//veinte = Math.Floor(valor / 20);
//valor = valor % 20;
//diez = Math.Floor(valor / 10);
//valor = valor % 10;
//cinco = Math.Floor(valor / 5);
//valor = valor % 5;
//dos = Math.Floor(valor / 2);
//uno = valor % 2;

//if (mil > 0)
//{
//    mensaje += mil + " billetes de $1000, ";
//}
//if (quinientos > 0)
//{
//    mensaje += quinientos + " billetes de $500,";
//}
//if (cien > 0)
//{
//    mensaje += cien + " billetes de $10, ";
//}
//if (cincuenta > 0)
//{
//    mensaje += cincuenta + " billetes de $50, ";
//}
//if (veinte > 0)
//{
//    mensaje += veinte + " billetes de $20, ";
//}
//if (diez > 0)
//{
//    mensaje += diez + " billetes de $10, ";
//}
//if (cinco > 0)
//{
//    mensaje += cinco + " monedas de $5, ";
//}
//if (dos > 0)
//{
//    mensaje += dos + " monedas de $2, ";
//}
//if (uno > 0)
//{
//    mensaje += uno + " monedas de $1.";
//}

//Console.WriteLine(mensaje);

// 8. Pide un número N, y muestra todos los números del 1 al N.

//Console.WriteLine("Ingrese el numero que desea:");
//int valor = int.Parse(Console.ReadLine());

//for (var i = 1; i <= valor; i++)
//{
//    Console.WriteLine(i);
//}


//9. Pedir 15 números y escribir la suma total.

//int suma = 0;
//for (var i = 1; i <= 15; i++)
//{
//    Console.WriteLine("Ingrese el numero que desea sumar: ");
//    int valor = int.Parse(Console.ReadLine());
//    suma += valor;
//}

//Console.WriteLine("El resultado de la suma es: " + suma);


// 10.Pide 5 números e indica si alguno es múltiplo de 3.


//for (var i = 1; i <= 5; i++)
//{
//    Console.WriteLine("Ingrese el numero que desea: ");
//    int valor = int.Parse(Console.ReadLine());
//    if (valor % 3 == 0)
//    {
//        Console.WriteLine("El numero ingresado es multipo de 3");
//    } else
//    {
//        Console.WriteLine("El numero ingresado es no multipo de 3");
//    }
//}

//11. Escriba un programa que solicite una contraseña (el texto de la contraseña
//no es importante) y la vuelva a solicitar hasta que las dos contraseñas
//coincidan.

//while (true)
//{
//    Console.WriteLine("Ingrese la primera contraseña");
//    string pass1 = Console.ReadLine();
//    Console.WriteLine("Ingrese la segunda contraseña");
//    string pass2 = Console.ReadLine();
//    if (pass1 == pass2)
//    {
//        Console.WriteLine("Bien hecho!");

//        break;
//    }
//    Console.WriteLine("Contraseña mal ingresada, vuelva a intentarlo");

//}

//12.Mismo que el anterior pero con un límite de tres peticiones. Luego de las tres
//peticiones no debe solicitar más la contraseña y terminar el programa.

//int cont = 0;
//while (cont < 3)
//{
//    Console.WriteLine("Ingrese la primera contraseña");
//    string pass1 = Console.ReadLine();
//    Console.WriteLine("Ingrese la segunda contraseña");
//    string pass2 = Console.ReadLine();
//    if (pass1 == pass2)
//    {
//        Console.WriteLine("Bien hecho!");

//        break;
//    }
//    Console.WriteLine("Contraseña mal ingresada, vuelva a intentarlo");
//    cont++;
//}

//13.Proponer al usuario que adivine un número a base de intentarlo.

//int numero = 7342;

//Console.WriteLine("Ingrese el numero segun su pápito");
//int valor = int.Parse(Console.ReadLine());

//if (numero == valor)
//{
//    Console.WriteLine("Ganas te la Quiniela!");
//} else
//{
//    Console.WriteLine("Mejor suerte la próxima");
//}

//14.Modificar el programa anterior para que vaya dando pistas del tipo «mayor» o
//«menor».

//int numero = 7342;

//int valor = 0;


//do { 
//    Console.WriteLine("Ingrese el numero segun su pápito");
//    valor = int.Parse(Console.ReadLine());
//    if (numero < valor)
//    {
//        Console.WriteLine("Intenta con un numero menor");
//    }
//    else if (numero > valor) {
//        Console.WriteLine("Intenta con un numero mayor");
//    }
//} while (numero != valor) ;

//Console.WriteLine("Ganas te la Quiniela!");


//15.Crea un programa que permita sumar N números. El usuario decide cuándo
//termina de introducir números al indicar la palabra ‘fin’.

string numero;

int cont = 0;

do
{
    Console.WriteLine("Ingrese el numero a sumar");
    numero = Console.ReadLine();
    if (numero == "fin")
    {
        break;
    }
    cont += int.Parse(numero);
} while (true);

Console.WriteLine("La suma total es: " + cont);