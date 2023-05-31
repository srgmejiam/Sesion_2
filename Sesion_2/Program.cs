using Sesion_2;

Persona persona = new Persona();

persona.Nombre = "Marvin";
persona.Edad = 50;

Console.WriteLine(persona.GetEdad());
persona.Nombre = "Marvin";
Console.WriteLine(persona.Nombre);
Console.ReadLine();