using System;
namespace examen;
    public abstract class ordenbase :Producto
    {
       public list <Producto> Helados = new list<Produc>{

        new Produc1 = ( nombre_sabor = "Yogurth", precio = "$ 3.25 ")
        new Produc2 = ( nombre_sabor = "chocolate", precio = "$ 3.50 ")
        new Produc3 = ( nombre_sabor = "Fresa", precio = "$ 3.00 ") 
       }

      public abstract doble calcularpreciototal(); 
    }
