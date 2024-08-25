namespace Game
{
    internal class Program
    {
        Player player1 = new Player();
        Player player2 = new Player();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rumble Dice! \nGet ready to face your aponent!");

            
        }

    }

    class Player
    {
        private string name { get; set; }
        private int health { get; set; }

        private Weapon weapon { get; set; }

        public Player(string name, int health, string weapon)
        {
            this.name = name;
            this.health = health;
            this.weapon = weapon;
        }
        
    }
    class Weapon
    {
        string weaponType = "";
        string weaponAction = "";
    }

  
}