
A a = new A();
a.b.PropertyB();

Cinema  C1 = new Cinema("Rodina");

//Movie M3 = new Movie("Whatcher");
//Movie M4 = new Movie("Terrifier");
//Movie M5 = new Movie("Hellraiser");

//C1.AddMovie(M3);
//C1.AddMovie(M4);
//C1.AddMovie(M5);

C1.NewMovie("Amsterdam");
C1.NewMovie("Smile");
C1.NewMovie("Werewolf");

Cinema C2 = C1.Clone();

C1.ToString();
Console.WriteLine();
C2.ToString();

