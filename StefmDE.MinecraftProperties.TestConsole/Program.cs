// See https://aka.ms/new-console-template for more information

using StefmDE.MinecraftProperties.Properties.Models;

ServerProperties properties = new ServerProperties();
properties.LoadFile("Samples/Server.properties", true);
properties.WriteFile("Samples/Server2.properties", false, false);
Console.WriteLine("Idle!");