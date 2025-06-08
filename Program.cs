public class Circulo
{
    private double radio; // Atributo que representa el radio del círculo

    // Constructor para inicializar el radio
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Método para calcular el área del círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Método para calcular el perímetro (circunferencia) del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase que representa un Cuadrado
public class Cuadrado
{
    private double lado; // Atributo que representa la longitud de un lado del cuadrado

    // Constructor para inicializar el lado
    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    // Método para calcular el área del cuadrado
    public double CalcularArea()
    {
        return lado * lado;
    }

    // Método para calcular el perímetro del cuadrado
    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}