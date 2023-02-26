//Ejercicios
class Ejercicios
{
    public void saludar() //Ejercicio 1
    {
        Console.WriteLine("Escribe tu nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine("Saludos " + nombre);
        Console.ReadKey();
    }
    public void rectangulo() //Ejercicio 2
    {
        Console.WriteLine("Escriba la base ");
        double valor1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escriba la altura ");
        double valor2 = Convert.ToDouble(Console.ReadLine());
        double perimetro = 2 * (valor1 + valor2);
        double area = (valor1 * valor2);
        Console.WriteLine("El perimetro total es " + perimetro);
        Console.WriteLine("El area total es " + area);
        Console.ReadKey();
    }
    public void raiz() //Ejercicio 3
    {
        Console.WriteLine("Escriba el cateto 1");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escriba el cateto 2");
        double b = Convert.ToDouble(Console.ReadLine());
        a = Math.Pow(a, 2);
        b = Math.Pow(b, 2);
        double hipotenusa = Math.Sqrt(a + b);
        Console.WriteLine("La hipotenusa es: " + hipotenusa);
        Console.ReadKey();
    }
    
    public void operaciones() //Ejercicio 4
    {
        Console.WriteLine("Escriba el primer valor");
        double valor1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escriba el segundo valor");
        double valor2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("La suma es: " + (valor1 + valor2));
        Console.WriteLine("La resta es: " + (valor1 - valor2));
        Console.WriteLine("La multiplicación es: " + (valor1 * valor2));
        Console.WriteLine("La division es: " + (valor1 / valor2));

    }

    public void conversion()//Ejercicio 5
    {
        Console.WriteLine("Escriba la termperatura");
        double temperatura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escriba la opcion de conversion \n 1.- Celsius \n 2.- Farenheit ");
        int op = Convert.ToInt32(Console.ReadLine());
        double resultado = 0.0;
        switch (op)
        {
            case 1:
                resultado = (temperatura - 32) * 5 / 9;
                Console.WriteLine("La temperatura en Celcius es: " + resultado);
                Console.ReadKey();
                break;
            case 2:
                resultado = (9 * (temperatura) / 5) + 32;
                Console.WriteLine("La temperatura en Farenheit es:" + resultado);
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("No existe es opcion por el momento");
                Console.ReadKey();
                break;
        }
    }

    public void media() //Ejercicio 6
    {
        Console.WriteLine("Escribe un valor entero");
        int val1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe un valor entero");
        int val2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe un valor entero");
        int val3 = Convert.ToInt32(Console.ReadLine());
        int media = (val1 + val2 + val3) / 3;
        Console.WriteLine("La media es: " + media);
        Console.ReadKey();
    }

    public void horasMinutos() //Ejercicio 7
    {
        Console.WriteLine("Escribe los minutos que quiera convertir a horas");
        int minutos = Convert.ToInt32(Console.ReadLine());
        int horas = minutos / 60;
        int minRestantes = minutos % 60;
        Console.WriteLine("Las horas son " + horas + " y los minutos son " + minRestantes);
        Console.ReadKey();
    }

    public void venta() //Ejercicio 8
    {
        Console.WriteLine("Escribe el sueldo base del trabajador");
        double sBase = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escribe el total de las tres ventas realizadas");
        double ventas = Convert.ToDouble(Console.ReadLine());
        double comisionVentas = (ventas * .10);
        Console.WriteLine("El sueldo a ganar al final de mes es: " + (sBase + comisionVentas));
        Console.ReadKey();
    }

    public void tienda() //Ejercicio 9
    {
        Console.WriteLine("Escribe el precio del producto a comprar");
        double precio = Convert.ToDouble(Console.ReadLine());
        double descuento = (precio * .15);
        double total = (precio - descuento);
        Console.WriteLine("El valor de descuento del producto fue: "+descuento+ "\nEl total a pagar por el producto es: " + total);
        Console.ReadKey();
    }

    public void calificacion() //Ejercicio 10
    {
        Console.WriteLine("Escribe la primera calificacion parcial");
        double c1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escribe la segunda calificacion parcial");
        double c2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escribe la tercera calificacion parcial");
        double c3 = Convert.ToDouble(Console.ReadLine());
        double promedio = (c1 + c2 + c3) / 3;
        double parcial = (promedio * .55);
        Console.WriteLine("Escriba la calificacion del examen");
        double examFinal = Convert.ToDouble(Console.ReadLine());
        examFinal = (examFinal * .30);
        Console.WriteLine("Escribe la calificacion del trabajo final");
        double trabFinal = Convert.ToDouble(Console.ReadLine());
        trabFinal = (trabFinal * .15);
        Console.WriteLine("Tu calificacion final es: " + (parcial + examFinal + trabFinal));
        Console.ReadKey();
    }
    static void Main(string[] args)
    {
        Ejercicios obj = new Ejercicios();
        //obj.saludar();
        //obj.rectangulo();
        //obj.raiz();
        //obj.operaciones();
        //obj.conversion();
        //obj.media();
        //obj.horasMinutos();
        //obj.venta();
        //obj.tienda();
        obj.calificacion();
    }
}

