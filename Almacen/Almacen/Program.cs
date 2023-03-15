// See https://aka.ms/new-console-template for more information

using Almacen.Models;


using (AlmacenContext db = new AlmacenContext())
{
    Producto producto = new Producto();

    Console.WriteLine("Ingrese nombre del producto");
    producto.Nombre = Console.ReadLine();

    Console.WriteLine("");

    Console.WriteLine("Ingrese descripcion del producto");
    producto.Descripcion = Console.ReadLine();

    Console.WriteLine("");

    Console.WriteLine("Ingrese precio del producto");
    producto.Precio = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("Ingrese el Stock");
    producto.Stock = Convert.ToInt32(Console.ReadLine());

    db.Productos.Add(producto);
    db.SaveChanges();



}

