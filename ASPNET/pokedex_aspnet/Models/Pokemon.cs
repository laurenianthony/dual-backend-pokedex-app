namespace PokedexApi.Models;

// MODEL - Blueprint for a Pokemon object
public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public List<string> Types { get; set; } = new();
    public int Hp { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Speed { get; set; }
}
