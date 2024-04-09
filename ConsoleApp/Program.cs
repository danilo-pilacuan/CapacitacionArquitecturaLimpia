using ApplicationCore;
using Infraestructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;


Console.WriteLine("Hello, World!");

// Create a service builder for a console application
var services = new ServiceCollection();

//Instance a configuration object
var configuration = new ConfigurationBuilder().Build();

//Register the dependencies
// Nota: En un ambiente real esto debe ejecutarse solo en ambiente de desarrollo, en ambiente de produccion se debe registrar el contexto de base de datos
Dependencias.ConfigureServices(services, configuration);    


services.AddScoped<IProductoRepository, ProductoRepository>();

//Create a service provider
var serviceProvider = services.BuildServiceProvider();

//Get the repository
var productoRepository = serviceProvider.GetService<IProductoRepository>();

//Get all the products
var productos = productoRepository.ObtenerTodosLosProductos();

foreach(var producto in productos)
{
    Console.WriteLine($"Id: {producto.Id}, Nombre: {producto.Nombre}, Precio: {producto.Precio}, Descuento: {producto.Descuento}");
}

