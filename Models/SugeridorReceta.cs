namespace TP3_Recetify.Models;

public class SugeridorReceta
{
    public string nombre {get; set;}
    public DateTime fechaNacimiento {get; set;}
    public string tipoComida {get; set;}
    public int presupuesto {get; set;}
    public int comensales {get; set;}
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
    public int calcularEdad()
    {
        DateTime hoy = DateTime.Today;
    int edad = hoy.Year - fechaNacimiento.Year;

    
     if (fechaNacimiento.Date > hoy.AddYears(-edad))
    {
        edad--;
    }

    return edad;
        
    }
    public string devolverComida()
    {
        string comida = "";
        if (tipoComida == "caliente" && presupuesto <= 3000)
        {
            comida = "Fideos con manteca";
        } 
        else if (tipoComida == "caliente" && presupuesto >3000 && presupuesto <= 7000)
        {
            comida = "Arroz con verduras salteadas";
        } 
        else if (tipoComida == "caliente" && presupuesto > 7000)
        {
            comida = "Pollo al horno con guarnición";
        } 
        else if (tipoComida == "fria" && presupuesto < 3000)
        {
            comida = "Ensalada simple";
        } 
        else if (tipoComida == "fria" && presupuesto >3000 && presupuesto <= 7000)
        {
            comida = "Ensalada completa con proteína";
        } 
         else if (tipoComida == "fria" && presupuesto > 7000)
        {
            comida = "Tabla de fiambres y quesos";
        } 
        return comida;
    }
    public int calcularTiempo()
    {
        int tiempo = 0;
        if (tipoComida == "caliente" && comensales >= 1 && comensales <= 3)
        {
            tiempo = 20;
        }
        else if (tipoComida == "caliente" && comensales >= 4 && comensales <= 7)
        {
            tiempo = 40;
        }
        else if (tipoComida == "caliente" && comensales >= 8)
        {
            tiempo = 80;
        }
        else if (tipoComida == "fria" && comensales >= 1 && comensales <= 3)
        {
            tiempo = 10;
        }
        else if (tipoComida == "fria" && comensales >= 4 && comensales <= 7)
        {
            tiempo = 20;
        }
        else if (tipoComida == "fria" && comensales >= 8)
        {
            tiempo = 40;
        }
        return tiempo;
    }
    public string determinarDificultad()
    {
        string dificultad = "";
        if (presupuesto <= 3000 && comensales >= 1 && comensales <= 3)
        {
            dificultad = "principiante";
        }
        else if(presupuesto <= 3000 && comensales >= 4 && comensales <= 7)
        {
            dificultad = "intermedio";
        }
        else if(presupuesto >3000 && presupuesto <= 7000 && comensales >= 1 && comensales <= 3)
        {
            dificultad = "intermedio";
        }
        else if(presupuesto >3000 && presupuesto <= 7000 && comensales >= 4)
        {
            dificultad = "intermedio";
        }
        else if(presupuesto >7000 &&  comensales >= 1 && comensales <= 7)
        {
            dificultad = "intermedio";
        }
        else if(presupuesto >7000 &&  comensales >= 8)
        {
            dificultad = "intermedio";
        }
        return dificultad;
    }
} 