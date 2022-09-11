//See on kommentaar minu koodi kohta

//Rakendus küsib kasutaja nime
//Rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");
//OUTPUT

//string - sõne
string userName = Console.ReadLine();
//Loeb mida kasutaja kirjutab ja salvestab kasti userName
//INPUT

//Console.WriteLine("Hello" + ", " + userName + "!"); PIKK VARJANT
//OUTPUT

//string interpolation - LÜHEM VARIJANT
Console.WriteLine($"Hello, {userName}!");
//OUTPUT
