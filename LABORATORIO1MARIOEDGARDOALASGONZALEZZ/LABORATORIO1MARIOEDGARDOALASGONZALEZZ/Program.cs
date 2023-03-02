//llamar a clases entidad y negocio
using LABORATORIO1MARIOEDGARDOALASGONZALEZZ.Entidades;
using LABORATORIO1MARIOEDGARDOALASGONZALEZZ.Negocio;

Persona persona = new Persona();
ClsPersona clspersona  = new ClsPersona();

Console.WriteLine("Ingresa tu nombre:");
persona.Nombre = Console.ReadLine();

Console.WriteLine("Ingresa tu edad:");
persona.Edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa tu sexo. solo M y H, :");
persona.Sexo = Console.ReadLine();

Console.WriteLine("Ingresa tu peso en kilogramos:");
persona.Peso = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa tu altura en metros:");
persona.Altura = float.Parse(Console.ReadLine());

//Convert.ToInt32

clspersona.CalcularIMC(persona);

clspersona.Esmayordeedad(persona);

Console.WriteLine("############################################################");
Console.WriteLine(" ");
Console.WriteLine(clspersona.CalcularIMC(persona));
Console.WriteLine("y");
Console.WriteLine(clspersona.Esmayordeedad(persona));
Console.WriteLine("############################################################");


