using System;
namespace examen;

    public class Producto:ordenbase
{
      
      public string nombre_sabor1 {get; set;}
      public string nombre_sabor2 {get; set;}
      public string nombre_sabor3 {get; set;}

      public int precio {get; set;}
    
    public Producto ( string nombre_sabor1, string, int precio);
    {
      nombre_sabor1 = Nombre_sabor1
      nombre_sabor2 = Nombre_sabor2
      nombre_sabor3 = Nombre_sabor3
      precio = Precio
    }

      public abstract doble calcularpreciototal(); 
}
