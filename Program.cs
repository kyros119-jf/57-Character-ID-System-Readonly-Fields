using _57_Character_ID_System_Readonly_Fields;
public class Program
{
    public static void Main(string[] args)
    {
        Character character1 = new Character("Aragorn", 100);
        Console.WriteLine("Character Created:\n");
        Console.WriteLine($"Name: {character1.Name}");
        Console.WriteLine($"Health: {character1.Health}");
        Console.WriteLine($"Character ID: {character1.CharacterId}");
    }
}