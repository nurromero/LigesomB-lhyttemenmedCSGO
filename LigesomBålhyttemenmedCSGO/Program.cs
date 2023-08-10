namespace LigesomBålhyttemenmedCSGO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating a new instance of a player
            Player player1 = new Player(001, "Niya", 100, 37, 20);
            Player player2 = new Player(002, "kneeyaz", 100, 43, 25);
            Player player3 = new Player(003, "nukeSZN", 56, 54, 05);

            // printing it to the console
            Console.WriteLine(player1);
            Console.WriteLine(player2);
            Console.WriteLine(player3);


            // creating a new instance of a weapon
            Weapon weapon1 = new Weapon("AK-47", 150, 100, 0);
            Weapon weapon2 = new Weapon("AWP", 350, 10, 5);
            Weapon weapon3 = new Weapon("M4A4S", 145, 85, 5);

            // printing them to the console
            Console.WriteLine(weapon1);
            Console.WriteLine(weapon2);
            Console.WriteLine(weapon3);



        }
    }
}