﻿// Declare
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

string Hero;
string devil;
string yes;
string no;

// Initialize

Hero = "caspian";
devil = "demogorgon";
yes = "devil kiled";
no = "caspian spared his life";

Console.WriteLine("Caspian enters the devil's cage and defeats the world´s strongest devil Demogorgon");
Console.WriteLine("Do you want Caspian to kill the devil?");

string input = Console.ReadLine();

if (input.ToUpper() == "YES")
{
    Console.WriteLine("Caspian killed the devil and became the world´s saviour, however that left him a bitter flavour");
    Console.WriteLine("Neutral ending");
}
else if (input.ToUpper() == "NO")
{
    Console.WriteLine("Caspian spared his life");
    Console.WriteLine("Should Caspian talk to the devil about human kindness?");

    string input2 = Console.ReadLine();

    if (input2.ToUpper() == "YES")
    {
        Console.WriteLine("The devil understands human kindness and begins a life of good deeds and spends the rest of his life redeeming his sins");
        Console.WriteLine("Good ending :)");
  }

    else if (input2.ToUpper() == "NO")
    {
        Console.WriteLine("The devil takes advantages of Caspian´s naiveness and kills him from the back");
        Console.WriteLine("Bad ending...");
    }
}




