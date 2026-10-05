using PokedexApi.Models;

namespace PokedexApi.Services;

public class PokemonService
{
    private List<Pokemon> _pokemonList = new();
    private int _nextId = 152;

    public PokemonService()
    {
        _pokemonList = new List<Pokemon>
        {
            new() { Id=1,   Name="Bulbasaur",   Types=new(){"Grass","Poison"},   Hp=45,  Attack=49,  Defense=49,  Speed=45  },
            new() { Id=2,   Name="Ivysaur",     Types=new(){"Grass","Poison"},   Hp=60,  Attack=62,  Defense=63,  Speed=60  },
            new() { Id=3,   Name="Venusaur",    Types=new(){"Grass","Poison"},   Hp=80,  Attack=82,  Defense=83,  Speed=80  },
            new() { Id=4,   Name="Charmander",  Types=new(){"Fire"},             Hp=39,  Attack=52,  Defense=43,  Speed=65  },
            new() { Id=5,   Name="Charmeleon",  Types=new(){"Fire"},             Hp=58,  Attack=64,  Defense=58,  Speed=80  },
            new() { Id=6,   Name="Charizard",   Types=new(){"Fire","Flying"},    Hp=78,  Attack=84,  Defense=78,  Speed=100 },
            new() { Id=7,   Name="Squirtle",    Types=new(){"Water"},            Hp=44,  Attack=48,  Defense=65,  Speed=43  },
            new() { Id=8,   Name="Wartortle",   Types=new(){"Water"},            Hp=59,  Attack=63,  Defense=80,  Speed=58  },
            new() { Id=9,   Name="Blastoise",   Types=new(){"Water"},            Hp=79,  Attack=83,  Defense=100, Speed=78  },
            new() { Id=10,  Name="Caterpie",    Types=new(){"Bug"},              Hp=45,  Attack=30,  Defense=35,  Speed=45  },
            new() { Id=11,  Name="Metapod",     Types=new(){"Bug"},              Hp=50,  Attack=20,  Defense=55,  Speed=30  },
            new() { Id=12,  Name="Butterfree",  Types=new(){"Bug","Flying"},     Hp=60,  Attack=45,  Defense=50,  Speed=70  },
            new() { Id=13,  Name="Weedle",      Types=new(){"Bug","Poison"},     Hp=40,  Attack=35,  Defense=30,  Speed=50  },
            new() { Id=14,  Name="Kakuna",      Types=new(){"Bug","Poison"},     Hp=45,  Attack=25,  Defense=50,  Speed=35  },
            new() { Id=15,  Name="Beedrill",    Types=new(){"Bug","Poison"},     Hp=65,  Attack=90,  Defense=40,  Speed=75  },
            new() { Id=16,  Name="Pidgey",      Types=new(){"Normal","Flying"},  Hp=40,  Attack=45,  Defense=40,  Speed=56  },
            new() { Id=17,  Name="Pidgeotto",   Types=new(){"Normal","Flying"},  Hp=63,  Attack=60,  Defense=55,  Speed=71  },
            new() { Id=18,  Name="Pidgeot",     Types=new(){"Normal","Flying"},  Hp=83,  Attack=80,  Defense=75,  Speed=101 },
            new() { Id=19,  Name="Rattata",     Types=new(){"Normal"},           Hp=30,  Attack=56,  Defense=35,  Speed=72  },
            new() { Id=20,  Name="Raticate",    Types=new(){"Normal"},           Hp=55,  Attack=81,  Defense=60,  Speed=97  },
            new() { Id=21,  Name="Spearow",     Types=new(){"Normal","Flying"},  Hp=40,  Attack=60,  Defense=30,  Speed=70  },
            new() { Id=22,  Name="Fearow",      Types=new(){"Normal","Flying"},  Hp=65,  Attack=90,  Defense=65,  Speed=100 },
            new() { Id=23,  Name="Ekans",       Types=new(){"Poison"},           Hp=35,  Attack=60,  Defense=44,  Speed=55  },
            new() { Id=24,  Name="Arbok",       Types=new(){"Poison"},           Hp=60,  Attack=95,  Defense=69,  Speed=80  },
            new() { Id=25,  Name="Pikachu",     Types=new(){"Electric"},         Hp=35,  Attack=55,  Defense=40,  Speed=90  },
            new() { Id=26,  Name="Raichu",      Types=new(){"Electric"},         Hp=60,  Attack=90,  Defense=55,  Speed=110 },
            new() { Id=27,  Name="Sandshrew",   Types=new(){"Ground"},           Hp=50,  Attack=75,  Defense=85,  Speed=40  },
            new() { Id=28,  Name="Sandslash",   Types=new(){"Ground"},           Hp=75,  Attack=100, Defense=110, Speed=65  },
            new() { Id=29,  Name="Nidoran-F",   Types=new(){"Poison"},           Hp=55,  Attack=47,  Defense=52,  Speed=41  },
            new() { Id=30,  Name="Nidorina",    Types=new(){"Poison"},           Hp=70,  Attack=62,  Defense=67,  Speed=56  },
            new() { Id=31,  Name="Nidoqueen",   Types=new(){"Poison","Ground"},  Hp=90,  Attack=92,  Defense=87,  Speed=76  },
            new() { Id=32,  Name="Nidoran-M",   Types=new(){"Poison"},           Hp=46,  Attack=57,  Defense=40,  Speed=50  },
            new() { Id=33,  Name="Nidorino",    Types=new(){"Poison"},           Hp=61,  Attack=72,  Defense=57,  Speed=65  },
            new() { Id=34,  Name="Nidoking",    Types=new(){"Poison","Ground"},  Hp=81,  Attack=102, Defense=77,  Speed=85  },
            new() { Id=35,  Name="Clefairy",    Types=new(){"Normal"},           Hp=70,  Attack=45,  Defense=48,  Speed=35  },
            new() { Id=36,  Name="Clefable",    Types=new(){"Normal"},           Hp=95,  Attack=70,  Defense=73,  Speed=60  },
            new() { Id=37,  Name="Vulpix",      Types=new(){"Fire"},             Hp=38,  Attack=41,  Defense=40,  Speed=65  },
            new() { Id=38,  Name="Ninetales",   Types=new(){"Fire"},             Hp=73,  Attack=76,  Defense=75,  Speed=100 },
            new() { Id=39,  Name="Jigglypuff",  Types=new(){"Normal"},           Hp=115, Attack=45,  Defense=20,  Speed=20  },
            new() { Id=40,  Name="Wigglytuff",  Types=new(){"Normal"},           Hp=140, Attack=70,  Defense=45,  Speed=45  },
            new() { Id=41,  Name="Zubat",       Types=new(){"Poison","Flying"},  Hp=40,  Attack=45,  Defense=35,  Speed=55  },
            new() { Id=42,  Name="Golbat",      Types=new(){"Poison","Flying"},  Hp=75,  Attack=80,  Defense=70,  Speed=90  },
            new() { Id=43,  Name="Oddish",      Types=new(){"Grass","Poison"},   Hp=45,  Attack=50,  Defense=55,  Speed=30  },
            new() { Id=44,  Name="Gloom",       Types=new(){"Grass","Poison"},   Hp=60,  Attack=65,  Defense=70,  Speed=40  },
            new() { Id=45,  Name="Vileplume",   Types=new(){"Grass","Poison"},   Hp=75,  Attack=80,  Defense=85,  Speed=50  },
            new() { Id=46,  Name="Paras",       Types=new(){"Bug","Grass"},      Hp=35,  Attack=70,  Defense=55,  Speed=25  },
            new() { Id=47,  Name="Parasect",    Types=new(){"Bug","Grass"},      Hp=60,  Attack=95,  Defense=80,  Speed=30  },
            new() { Id=48,  Name="Venonat",     Types=new(){"Bug","Poison"},     Hp=60,  Attack=55,  Defense=50,  Speed=45  },
            new() { Id=49,  Name="Venomoth",    Types=new(){"Bug","Poison"},     Hp=70,  Attack=65,  Defense=60,  Speed=90  },
            new() { Id=50,  Name="Diglett",     Types=new(){"Ground"},           Hp=10,  Attack=55,  Defense=25,  Speed=95  },
            new() { Id=51,  Name="Dugtrio",     Types=new(){"Ground"},           Hp=35,  Attack=80,  Defense=50,  Speed=120 },
            new() { Id=52,  Name="Meowth",      Types=new(){"Normal"},           Hp=40,  Attack=45,  Defense=35,  Speed=90  },
            new() { Id=53,  Name="Persian",     Types=new(){"Normal"},           Hp=65,  Attack=70,  Defense=60,  Speed=115 },
            new() { Id=54,  Name="Psyduck",     Types=new(){"Water"},            Hp=50,  Attack=52,  Defense=48,  Speed=55  },
            new() { Id=55,  Name="Golduck",     Types=new(){"Water"},            Hp=80,  Attack=82,  Defense=78,  Speed=85  },
            new() { Id=56,  Name="Mankey",      Types=new(){"Fighting"},         Hp=40,  Attack=80,  Defense=35,  Speed=70  },
            new() { Id=57,  Name="Primeape",    Types=new(){"Fighting"},         Hp=65,  Attack=105, Defense=60,  Speed=95  },
            new() { Id=58,  Name="Growlithe",   Types=new(){"Fire"},             Hp=55,  Attack=70,  Defense=45,  Speed=60  },
            new() { Id=59,  Name="Arcanine",    Types=new(){"Fire"},             Hp=90,  Attack=110, Defense=80,  Speed=95  },
            new() { Id=60,  Name="Poliwag",     Types=new(){"Water"},            Hp=40,  Attack=50,  Defense=40,  Speed=90  },
            new() { Id=61,  Name="Poliwhirl",   Types=new(){"Water"},            Hp=65,  Attack=65,  Defense=65,  Speed=90  },
            new() { Id=62,  Name="Poliwrath",   Types=new(){"Water","Fighting"}, Hp=90,  Attack=95,  Defense=95,  Speed=70  },
            new() { Id=63,  Name="Abra",        Types=new(){"Psychic"},          Hp=25,  Attack=20,  Defense=15,  Speed=90  },
            new() { Id=64,  Name="Kadabra",     Types=new(){"Psychic"},          Hp=40,  Attack=35,  Defense=30,  Speed=105 },
            new() { Id=65,  Name="Alakazam",    Types=new(){"Psychic"},          Hp=55,  Attack=50,  Defense=45,  Speed=120 },
            new() { Id=66,  Name="Machop",      Types=new(){"Fighting"},         Hp=70,  Attack=80,  Defense=50,  Speed=35  },
            new() { Id=67,  Name="Machoke",     Types=new(){"Fighting"},         Hp=80,  Attack=100, Defense=70,  Speed=45  },
            new() { Id=68,  Name="Machamp",     Types=new(){"Fighting"},         Hp=90,  Attack=130, Defense=80,  Speed=55  },
            new() { Id=69,  Name="Bellsprout",  Types=new(){"Grass","Poison"},   Hp=50,  Attack=75,  Defense=35,  Speed=40  },
            new() { Id=70,  Name="Weepinbell",  Types=new(){"Grass","Poison"},   Hp=65,  Attack=90,  Defense=50,  Speed=55  },
            new() { Id=71,  Name="Victreebel",  Types=new(){"Grass","Poison"},   Hp=80,  Attack=105, Defense=65,  Speed=70  },
            new() { Id=72,  Name="Tentacool",   Types=new(){"Water","Poison"},   Hp=40,  Attack=40,  Defense=35,  Speed=70  },
            new() { Id=73,  Name="Tentacruel",  Types=new(){"Water","Poison"},   Hp=80,  Attack=70,  Defense=65,  Speed=100 },
            new() { Id=74,  Name="Geodude",     Types=new(){"Rock","Ground"},    Hp=40,  Attack=80,  Defense=100, Speed=20  },
            new() { Id=75,  Name="Graveler",    Types=new(){"Rock","Ground"},    Hp=55,  Attack=95,  Defense=115, Speed=35  },
            new() { Id=76,  Name="Golem",       Types=new(){"Rock","Ground"},    Hp=80,  Attack=120, Defense=130, Speed=45  },
            new() { Id=77,  Name="Ponyta",      Types=new(){"Fire"},             Hp=50,  Attack=85,  Defense=55,  Speed=90  },
            new() { Id=78,  Name="Rapidash",    Types=new(){"Fire"},             Hp=65,  Attack=100, Defense=70,  Speed=105 },
            new() { Id=79,  Name="Slowpoke",    Types=new(){"Water","Psychic"},  Hp=90,  Attack=65,  Defense=65,  Speed=15  },
            new() { Id=80,  Name="Slowbro",     Types=new(){"Water","Psychic"},  Hp=95,  Attack=75,  Defense=110, Speed=30  },
            new() { Id=81,  Name="Magnemite",   Types=new(){"Electric"},         Hp=25,  Attack=35,  Defense=70,  Speed=45  },
            new() { Id=82,  Name="Magneton",    Types=new(){"Electric"},         Hp=50,  Attack=60,  Defense=95,  Speed=70  },
            new() { Id=83,  Name="Farfetchd",   Types=new(){"Normal","Flying"},  Hp=52,  Attack=65,  Defense=55,  Speed=60  },
            new() { Id=84,  Name="Doduo",       Types=new(){"Normal","Flying"},  Hp=35,  Attack=85,  Defense=45,  Speed=75  },
            new() { Id=85,  Name="Dodrio",      Types=new(){"Normal","Flying"},  Hp=60,  Attack=110, Defense=70,  Speed=100 },
            new() { Id=86,  Name="Seel",        Types=new(){"Water"},            Hp=65,  Attack=45,  Defense=55,  Speed=45  },
            new() { Id=87,  Name="Dewgong",     Types=new(){"Water","Ice"},      Hp=90,  Attack=70,  Defense=80,  Speed=70  },
            new() { Id=88,  Name="Grimer",      Types=new(){"Poison"},           Hp=80,  Attack=80,  Defense=50,  Speed=25  },
            new() { Id=89,  Name="Muk",         Types=new(){"Poison"},           Hp=105, Attack=105, Defense=75,  Speed=50  },
            new() { Id=90,  Name="Shellder",    Types=new(){"Water"},            Hp=30,  Attack=65,  Defense=100, Speed=40  },
            new() { Id=91,  Name="Cloyster",    Types=new(){"Water","Ice"},      Hp=50,  Attack=95,  Defense=180, Speed=70  },
            new() { Id=92,  Name="Gastly",      Types=new(){"Ghost","Poison"},   Hp=30,  Attack=35,  Defense=30,  Speed=80  },
            new() { Id=93,  Name="Haunter",     Types=new(){"Ghost","Poison"},   Hp=45,  Attack=50,  Defense=45,  Speed=95  },
            new() { Id=94,  Name="Gengar",      Types=new(){"Ghost","Poison"},   Hp=60,  Attack=65,  Defense=60,  Speed=110 },
            new() { Id=95,  Name="Onix",        Types=new(){"Rock","Ground"},    Hp=35,  Attack=45,  Defense=160, Speed=70  },
            new() { Id=96,  Name="Drowzee",     Types=new(){"Psychic"},          Hp=60,  Attack=48,  Defense=45,  Speed=42  },
            new() { Id=97,  Name="Hypno",       Types=new(){"Psychic"},          Hp=85,  Attack=73,  Defense=70,  Speed=67  },
            new() { Id=98,  Name="Krabby",      Types=new(){"Water"},            Hp=30,  Attack=105, Defense=90,  Speed=50  },
            new() { Id=99,  Name="Kingler",     Types=new(){"Water"},            Hp=55,  Attack=130, Defense=115, Speed=75  },
            new() { Id=100, Name="Voltorb",     Types=new(){"Electric"},         Hp=40,  Attack=30,  Defense=50,  Speed=100 },
            new() { Id=101, Name="Electrode",   Types=new(){"Electric"},         Hp=60,  Attack=50,  Defense=70,  Speed=140 },
            new() { Id=102, Name="Exeggcute",   Types=new(){"Grass","Psychic"},  Hp=60,  Attack=40,  Defense=80,  Speed=40  },
            new() { Id=103, Name="Exeggutor",   Types=new(){"Grass","Psychic"},  Hp=95,  Attack=95,  Defense=85,  Speed=55  },
            new() { Id=104, Name="Cubone",      Types=new(){"Ground"},           Hp=50,  Attack=50,  Defense=95,  Speed=35  },
            new() { Id=105, Name="Marowak",     Types=new(){"Ground"},           Hp=60,  Attack=80,  Defense=110, Speed=45  },
            new() { Id=106, Name="Hitmonlee",   Types=new(){"Fighting"},         Hp=50,  Attack=120, Defense=53,  Speed=87  },
            new() { Id=107, Name="Hitmonchan",  Types=new(){"Fighting"},         Hp=50,  Attack=105, Defense=79,  Speed=76  },
            new() { Id=108, Name="Lickitung",   Types=new(){"Normal"},           Hp=90,  Attack=55,  Defense=75,  Speed=30  },
            new() { Id=109, Name="Koffing",     Types=new(){"Poison"},           Hp=40,  Attack=65,  Defense=95,  Speed=35  },
            new() { Id=110, Name="Weezing",     Types=new(){"Poison"},           Hp=65,  Attack=90,  Defense=120, Speed=60  },
            new() { Id=111, Name="Rhyhorn",     Types=new(){"Ground","Rock"},    Hp=80,  Attack=85,  Defense=95,  Speed=25  },
            new() { Id=112, Name="Rhydon",      Types=new(){"Ground","Rock"},    Hp=105, Attack=130, Defense=120, Speed=40  },
            new() { Id=113, Name="Chansey",     Types=new(){"Normal"},           Hp=250, Attack=5,   Defense=5,   Speed=50  },
            new() { Id=114, Name="Tangela",     Types=new(){"Grass"},            Hp=65,  Attack=55,  Defense=115, Speed=60  },
            new() { Id=115, Name="Kangaskhan",  Types=new(){"Normal"},           Hp=105, Attack=95,  Defense=80,  Speed=90  },
            new() { Id=116, Name="Horsea",      Types=new(){"Water"},            Hp=30,  Attack=40,  Defense=70,  Speed=60  },
            new() { Id=117, Name="Seadra",      Types=new(){"Water"},            Hp=55,  Attack=65,  Defense=95,  Speed=85  },
            new() { Id=118, Name="Goldeen",     Types=new(){"Water"},            Hp=45,  Attack=67,  Defense=60,  Speed=63  },
            new() { Id=119, Name="Seaking",     Types=new(){"Water"},            Hp=80,  Attack=92,  Defense=65,  Speed=68  },
            new() { Id=120, Name="Staryu",      Types=new(){"Water"},            Hp=30,  Attack=45,  Defense=55,  Speed=85  },
            new() { Id=121, Name="Starmie",     Types=new(){"Water","Psychic"},  Hp=60,  Attack=75,  Defense=85,  Speed=115 },
            new() { Id=122, Name="Mr. Mime",    Types=new(){"Psychic"},          Hp=40,  Attack=45,  Defense=65,  Speed=90  },
            new() { Id=123, Name="Scyther",     Types=new(){"Bug","Flying"},     Hp=70,  Attack=110, Defense=80,  Speed=105 },
            new() { Id=124, Name="Jynx",        Types=new(){"Ice","Psychic"},    Hp=65,  Attack=50,  Defense=35,  Speed=95  },
            new() { Id=125, Name="Electabuzz",  Types=new(){"Electric"},         Hp=65,  Attack=83,  Defense=57,  Speed=105 },
            new() { Id=126, Name="Magmar",      Types=new(){"Fire"},             Hp=65,  Attack=95,  Defense=57,  Speed=93  },
            new() { Id=127, Name="Pinsir",      Types=new(){"Bug"},              Hp=65,  Attack=125, Defense=100, Speed=85  },
            new() { Id=128, Name="Tauros",      Types=new(){"Normal"},           Hp=75,  Attack=100, Defense=95,  Speed=110 },
            new() { Id=129, Name="Magikarp",    Types=new(){"Water"},            Hp=20,  Attack=10,  Defense=55,  Speed=80  },
            new() { Id=130, Name="Gyarados",    Types=new(){"Water","Flying"},   Hp=95,  Attack=125, Defense=79,  Speed=81  },
            new() { Id=131, Name="Lapras",      Types=new(){"Water","Ice"},      Hp=130, Attack=85,  Defense=80,  Speed=60  },
            new() { Id=132, Name="Ditto",       Types=new(){"Normal"},           Hp=48,  Attack=48,  Defense=48,  Speed=48  },
            new() { Id=133, Name="Eevee",       Types=new(){"Normal"},           Hp=55,  Attack=55,  Defense=50,  Speed=55  },
            new() { Id=134, Name="Vaporeon",    Types=new(){"Water"},            Hp=130, Attack=65,  Defense=60,  Speed=65  },
            new() { Id=135, Name="Jolteon",     Types=new(){"Electric"},         Hp=65,  Attack=65,  Defense=60,  Speed=130 },
            new() { Id=136, Name="Flareon",     Types=new(){"Fire"},             Hp=65,  Attack=130, Defense=60,  Speed=65  },
            new() { Id=137, Name="Porygon",     Types=new(){"Normal"},           Hp=65,  Attack=60,  Defense=70,  Speed=40  },
            new() { Id=138, Name="Omanyte",     Types=new(){"Rock","Water"},     Hp=35,  Attack=40,  Defense=100, Speed=35  },
            new() { Id=139, Name="Omastar",     Types=new(){"Rock","Water"},     Hp=70,  Attack=60,  Defense=125, Speed=55  },
            new() { Id=140, Name="Kabuto",      Types=new(){"Rock","Water"},     Hp=30,  Attack=80,  Defense=90,  Speed=55  },
            new() { Id=141, Name="Kabutops",    Types=new(){"Rock","Water"},     Hp=60,  Attack=115, Defense=105, Speed=80  },
            new() { Id=142, Name="Aerodactyl",  Types=new(){"Rock","Flying"},    Hp=80,  Attack=105, Defense=65,  Speed=130 },
            new() { Id=143, Name="Snorlax",     Types=new(){"Normal"},           Hp=160, Attack=110, Defense=65,  Speed=30  },
            new() { Id=144, Name="Articuno",    Types=new(){"Ice","Flying"},     Hp=90,  Attack=85,  Defense=100, Speed=85  },
            new() { Id=145, Name="Zapdos",      Types=new(){"Electric","Flying"},Hp=90,  Attack=90,  Defense=85,  Speed=100 },
            new() { Id=146, Name="Moltres",     Types=new(){"Fire","Flying"},    Hp=90,  Attack=100, Defense=90,  Speed=90  },
            new() { Id=147, Name="Dratini",     Types=new(){"Dragon"},           Hp=41,  Attack=64,  Defense=45,  Speed=50  },
            new() { Id=148, Name="Dragonair",   Types=new(){"Dragon"},           Hp=61,  Attack=84,  Defense=65,  Speed=70  },
            new() { Id=149, Name="Dragonite",   Types=new(){"Dragon","Flying"},  Hp=91,  Attack=134, Defense=95,  Speed=80  },
            new() { Id=150, Name="Mewtwo",      Types=new(){"Psychic"},          Hp=106, Attack=110, Defense=90,  Speed=130 },
            new() { Id=151, Name="Mew",         Types=new(){"Psychic"},          Hp=100, Attack=100, Defense=100, Speed=100 },
        };
    }

    public List<Pokemon> GetAll() => _pokemonList;

    public Pokemon? GetById(int id) =>
        _pokemonList.FirstOrDefault(p => p.Id == id);

    public Pokemon Add(Pokemon pokemon)
    {
        pokemon.Id = _nextId++;
        _pokemonList.Add(pokemon);
        return pokemon;
    }

    public Pokemon? Update(int id, Pokemon updated)
    {
        var existing = GetById(id);
        if (existing == null) return null;
        existing.Name = updated.Name;
        existing.Types = updated.Types;
        existing.Hp = updated.Hp;
        existing.Attack = updated.Attack;
        existing.Defense = updated.Defense;
        existing.Speed = updated.Speed;
        return existing;
    }

    public bool Delete(int id)
    {
        var pokemon = GetById(id);
        if (pokemon == null) return false;
        return _pokemonList.Remove(pokemon);
    }
}
