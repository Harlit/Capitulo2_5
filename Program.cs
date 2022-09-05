
int Perimetro_Poligono(int numeroLados, int largoDeLosLados){    
    return numeroLados * largoDeLosLados;
    //perimetro = numeroLados * largoDeLosLados
}

double PI = 3.14;
double convertir_Radianes(double grado){
    return grado * (PI/180);
}


int Centigrado_Fahrenheit(int C){    
     return (Convert.ToInt32(C * 1.8) + 32);
}

decimal dolarEuro(decimal tasaEuro, decimal cantidad){
    return cantidad * tasaEuro;
}


Console.WriteLine($"Perimetro del Poligono: {Perimetro_Poligono(28,7)}");
Console.WriteLine($"De Celsius a Radianes: {convertir_Radianes(11)}");
Console.WriteLine($"Centigrado a Fahrenheit: {Centigrado_Fahrenheit(98)}");

// programa que cambia divisas de 

Console.WriteLine("\n\nPrograma de Cambio Dolar--Euro: ");

Console.Write("Ingrese la tasa de cambio: ");
decimal tasaCambio = Convert.ToDecimal (Console.ReadLine());


Console.Write("Ingrese la cantidad de cambio: ");
decimal cantidadCambio =Convert.ToDecimal (Console.ReadLine());

Console.WriteLine($"Resultado: {dolarEuro(tasaCambio,cantidadCambio)} Euros");