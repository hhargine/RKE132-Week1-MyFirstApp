// This is a comment to my code

//rakendus küsib kasutajal sisestada oma nime

Console.WriteLine("Enter your name:");  //Output
//string - sõne
string userName = Console.ReadLine();   //Input

//raknedus tervitab kasutajat nimepidi
Console.WriteLine("Hello, " + userName + "!");  //Output

//string interpolation
Console.WriteLine($"Hello, {userName}!"); //Output

