using System.Security.Cryptography.X509Certificates;
using W7_assignment_template.Interfaces;
using W7_assignment_template.Services;

namespace W7_assignment_template.Models.Characters;

public class Vampire : CharacterBase, ILootable, IFlyable
{
    public string Treasure { get; set; }

    public Vampire() : base() { }

    public Vampire(string name, string type, int level, int hp, string treasure, IRoom startingRoom) : base(name, type, level, hp, startingRoom)
    {
        Treasure = treasure;
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} flies high.");
    }


    public override void UniqueBehavior()
    {
        throw new NotImplementedException();
    }
}
