// See https://aka.ms/new-console-template for more information
using M02S05;

Console.WriteLine("Hello, World!");
var cavalo = new Cavalo("Cavalinho", 5);
var cachorro = new Cachorro("Luke", 3);
var preguica = new Preguica("Preguiçola", 2);
var veterinario = new Veterinario();

cavalo.EmitirSom();
cachorro.EmitirSom();
preguica.EmitirSom();
Console.WriteLine("Consulta veterinaria");
veterinario.Examinar(preguica);
veterinario.Examinar(cachorro);
veterinario.Examinar(cavalo);