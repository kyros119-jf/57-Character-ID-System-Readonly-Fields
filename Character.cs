using System;
namespace _57_Character_ID_System_Readonly_Fields
{
    public class Character
    {
        public readonly Guid CharacterId;
        public string Name { get; set; }
        public int Health { get; set; }


        public Character(string name, int health)
        {
            CharacterId = Guid.NewGuid();
            Name = name;
            Health = health;
        }
    }
}