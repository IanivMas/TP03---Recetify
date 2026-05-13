namespace TP3_Recetify.Models;

public class SugeridorReceta
{
    public string nombre;
    public DateTime fechaNacimiento;
    public string tipoComida;
    public int presupuesto;
    public int comensales;
    public SugeridorReceta ()
    {

    }
    public SugeridorReceta (string nombre, DateTime fechaNacimiento, string tipoComida, int presupuesto, int comensales)
    {
        this.nombre = nombre;
        this.fechaNacimiento = fechaNacimiento;
        this.tipoComida = tipoComida;
        this.presupuesto = presupuesto;
        this.comensales = comensales;
    }
    public int CalcularEdad()
    {
        int edad = DateTime.Today - fechaNacimiento;
        return edad;
    }
}