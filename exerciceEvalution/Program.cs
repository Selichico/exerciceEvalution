


using System.ComponentModel.Design;

Console.WriteLine("Bienvenue chez le cabinet orthophoniste, tu vas remplir tes information afin de mieux vous connaitre");

Console.WriteLine("introduit ton nom");
string Nom = Console.ReadLine();

//if (Nom = .IsNullOrEmpty(Nom))
//{
//    Console.WriteLine("please introduse name");
//     Nom  = Console.ReadLine();

//}

Console.WriteLine("introduit ton Prenom");
string PreNom = Console.ReadLine();

Console.WriteLine("introduit ton age");
string age = Console.ReadLine();
int Age = int.Parse(age);

Console.WriteLine("introduit ton sexe : H pour homme, et F pour femme");
string sexe = Console.ReadLine();

Console.WriteLine("introduit ta date de naissance jj/mm/aaaa");
string DateDeNaissance = Console.ReadLine();
_ = DateTime.Parse(DateDeNaissance);

Console.WriteLine("c'est quoi ton type de maladie?");
string typeDeMaladie = Console.ReadLine();


string[,] patients = { { Nom PreNom  sexe }, { DateDeNaissance  typeDeMaladie, "0" } };

//foreach(var element in patients)
//Console.WriteLine(element );




