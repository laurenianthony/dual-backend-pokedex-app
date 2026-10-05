package com.pokedex.service;

import com.pokedex.model.Pokemon;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Optional;

@Service
public class PokemonService {

    private List<Pokemon> pokemonList = new ArrayList<>();
    private int nextId = 152;

    public PokemonService() {
        pokemonList.addAll(Arrays.asList(
            new Pokemon(1,   "Bulbasaur",   List.of("Grass","Poison"),    45,  49,  49,  45),
            new Pokemon(2,   "Ivysaur",     List.of("Grass","Poison"),    60,  62,  63,  60),
            new Pokemon(3,   "Venusaur",    List.of("Grass","Poison"),    80,  82,  83,  80),
            new Pokemon(4,   "Charmander",  List.of("Fire"),              39,  52,  43,  65),
            new Pokemon(5,   "Charmeleon",  List.of("Fire"),              58,  64,  58,  80),
            new Pokemon(6,   "Charizard",   List.of("Fire","Flying"),     78,  84,  78,  100),
            new Pokemon(7,   "Squirtle",    List.of("Water"),             44,  48,  65,  43),
            new Pokemon(8,   "Wartortle",   List.of("Water"),             59,  63,  80,  58),
            new Pokemon(9,   "Blastoise",   List.of("Water"),             79,  83,  100, 78),
            new Pokemon(10,  "Caterpie",    List.of("Bug"),               45,  30,  35,  45),
            new Pokemon(11,  "Metapod",     List.of("Bug"),               50,  20,  55,  30),
            new Pokemon(12,  "Butterfree",  List.of("Bug","Flying"),      60,  45,  50,  70),
            new Pokemon(13,  "Weedle",      List.of("Bug","Poison"),      40,  35,  30,  50),
            new Pokemon(14,  "Kakuna",      List.of("Bug","Poison"),      45,  25,  50,  35),
            new Pokemon(15,  "Beedrill",    List.of("Bug","Poison"),      65,  90,  40,  75),
            new Pokemon(16,  "Pidgey",      List.of("Normal","Flying"),   40,  45,  40,  56),
            new Pokemon(17,  "Pidgeotto",   List.of("Normal","Flying"),   63,  60,  55,  71),
            new Pokemon(18,  "Pidgeot",     List.of("Normal","Flying"),   83,  80,  75,  101),
            new Pokemon(19,  "Rattata",     List.of("Normal"),            30,  56,  35,  72),
            new Pokemon(20,  "Raticate",    List.of("Normal"),            55,  81,  60,  97),
            new Pokemon(21,  "Spearow",     List.of("Normal","Flying"),   40,  60,  30,  70),
            new Pokemon(22,  "Fearow",      List.of("Normal","Flying"),   65,  90,  65,  100),
            new Pokemon(23,  "Ekans",       List.of("Poison"),            35,  60,  44,  55),
            new Pokemon(24,  "Arbok",       List.of("Poison"),            60,  95,  69,  80),
            new Pokemon(25,  "Pikachu",     List.of("Electric"),          35,  55,  40,  90),
            new Pokemon(26,  "Raichu",      List.of("Electric"),          60,  90,  55,  110),
            new Pokemon(27,  "Sandshrew",   List.of("Ground"),            50,  75,  85,  40),
            new Pokemon(28,  "Sandslash",   List.of("Ground"),            75,  100, 110, 65),
            new Pokemon(29,  "Nidoran-F",   List.of("Poison"),            55,  47,  52,  41),
            new Pokemon(30,  "Nidorina",    List.of("Poison"),            70,  62,  67,  56),
            new Pokemon(31,  "Nidoqueen",   List.of("Poison","Ground"),   90,  92,  87,  76),
            new Pokemon(32,  "Nidoran-M",   List.of("Poison"),            46,  57,  40,  50),
            new Pokemon(33,  "Nidorino",    List.of("Poison"),            61,  72,  57,  65),
            new Pokemon(34,  "Nidoking",    List.of("Poison","Ground"),   81,  102, 77,  85),
            new Pokemon(35,  "Clefairy",    List.of("Normal"),            70,  45,  48,  35),
            new Pokemon(36,  "Clefable",    List.of("Normal"),            95,  70,  73,  60),
            new Pokemon(37,  "Vulpix",      List.of("Fire"),              38,  41,  40,  65),
            new Pokemon(38,  "Ninetales",   List.of("Fire"),              73,  76,  75,  100),
            new Pokemon(39,  "Jigglypuff",  List.of("Normal"),            115, 45,  20,  20),
            new Pokemon(40,  "Wigglytuff",  List.of("Normal"),            140, 70,  45,  45),
            new Pokemon(41,  "Zubat",       List.of("Poison","Flying"),   40,  45,  35,  55),
            new Pokemon(42,  "Golbat",      List.of("Poison","Flying"),   75,  80,  70,  90),
            new Pokemon(43,  "Oddish",      List.of("Grass","Poison"),    45,  50,  55,  30),
            new Pokemon(44,  "Gloom",       List.of("Grass","Poison"),    60,  65,  70,  40),
            new Pokemon(45,  "Vileplume",   List.of("Grass","Poison"),    75,  80,  85,  50),
            new Pokemon(46,  "Paras",       List.of("Bug","Grass"),       35,  70,  55,  25),
            new Pokemon(47,  "Parasect",    List.of("Bug","Grass"),       60,  95,  80,  30),
            new Pokemon(48,  "Venonat",     List.of("Bug","Poison"),      60,  55,  50,  45),
            new Pokemon(49,  "Venomoth",    List.of("Bug","Poison"),      70,  65,  60,  90),
            new Pokemon(50,  "Diglett",     List.of("Ground"),            10,  55,  25,  95),
            new Pokemon(51,  "Dugtrio",     List.of("Ground"),            35,  80,  50,  120),
            new Pokemon(52,  "Meowth",      List.of("Normal"),            40,  45,  35,  90),
            new Pokemon(53,  "Persian",     List.of("Normal"),            65,  70,  60,  115),
            new Pokemon(54,  "Psyduck",     List.of("Water"),             50,  52,  48,  55),
            new Pokemon(55,  "Golduck",     List.of("Water"),             80,  82,  78,  85),
            new Pokemon(56,  "Mankey",      List.of("Fighting"),          40,  80,  35,  70),
            new Pokemon(57,  "Primeape",    List.of("Fighting"),          65,  105, 60,  95),
            new Pokemon(58,  "Growlithe",   List.of("Fire"),              55,  70,  45,  60),
            new Pokemon(59,  "Arcanine",    List.of("Fire"),              90,  110, 80,  95),
            new Pokemon(60,  "Poliwag",     List.of("Water"),             40,  50,  40,  90),
            new Pokemon(61,  "Poliwhirl",   List.of("Water"),             65,  65,  65,  90),
            new Pokemon(62,  "Poliwrath",   List.of("Water","Fighting"),  90,  95,  95,  70),
            new Pokemon(63,  "Abra",        List.of("Psychic"),           25,  20,  15,  90),
            new Pokemon(64,  "Kadabra",     List.of("Psychic"),           40,  35,  30,  105),
            new Pokemon(65,  "Alakazam",    List.of("Psychic"),           55,  50,  45,  120),
            new Pokemon(66,  "Machop",      List.of("Fighting"),          70,  80,  50,  35),
            new Pokemon(67,  "Machoke",     List.of("Fighting"),          80,  100, 70,  45),
            new Pokemon(68,  "Machamp",     List.of("Fighting"),          90,  130, 80,  55),
            new Pokemon(69,  "Bellsprout",  List.of("Grass","Poison"),    50,  75,  35,  40),
            new Pokemon(70,  "Weepinbell",  List.of("Grass","Poison"),    65,  90,  50,  55),
            new Pokemon(71,  "Victreebel",  List.of("Grass","Poison"),    80,  105, 65,  70),
            new Pokemon(72,  "Tentacool",   List.of("Water","Poison"),    40,  40,  35,  70),
            new Pokemon(73,  "Tentacruel",  List.of("Water","Poison"),    80,  70,  65,  100),
            new Pokemon(74,  "Geodude",     List.of("Rock","Ground"),     40,  80,  100, 20),
            new Pokemon(75,  "Graveler",    List.of("Rock","Ground"),     55,  95,  115, 35),
            new Pokemon(76,  "Golem",       List.of("Rock","Ground"),     80,  120, 130, 45),
            new Pokemon(77,  "Ponyta",      List.of("Fire"),              50,  85,  55,  90),
            new Pokemon(78,  "Rapidash",    List.of("Fire"),              65,  100, 70,  105),
            new Pokemon(79,  "Slowpoke",    List.of("Water","Psychic"),   90,  65,  65,  15),
            new Pokemon(80,  "Slowbro",     List.of("Water","Psychic"),   95,  75,  110, 30),
            new Pokemon(81,  "Magnemite",   List.of("Electric"),          25,  35,  70,  45),
            new Pokemon(82,  "Magneton",    List.of("Electric"),          50,  60,  95,  70),
            new Pokemon(83,  "Farfetchd",   List.of("Normal","Flying"),   52,  65,  55,  60),
            new Pokemon(84,  "Doduo",       List.of("Normal","Flying"),   35,  85,  45,  75),
            new Pokemon(85,  "Dodrio",      List.of("Normal","Flying"),   60,  110, 70,  100),
            new Pokemon(86,  "Seel",        List.of("Water"),             65,  45,  55,  45),
            new Pokemon(87,  "Dewgong",     List.of("Water","Ice"),       90,  70,  80,  70),
            new Pokemon(88,  "Grimer",      List.of("Poison"),            80,  80,  50,  25),
            new Pokemon(89,  "Muk",         List.of("Poison"),            105, 105, 75,  50),
            new Pokemon(90,  "Shellder",    List.of("Water"),             30,  65,  100, 40),
            new Pokemon(91,  "Cloyster",    List.of("Water","Ice"),       50,  95,  180, 70),
            new Pokemon(92,  "Gastly",      List.of("Ghost","Poison"),    30,  35,  30,  80),
            new Pokemon(93,  "Haunter",     List.of("Ghost","Poison"),    45,  50,  45,  95),
            new Pokemon(94,  "Gengar",      List.of("Ghost","Poison"),    60,  65,  60,  110),
            new Pokemon(95,  "Onix",        List.of("Rock","Ground"),     35,  45,  160, 70),
            new Pokemon(96,  "Drowzee",     List.of("Psychic"),           60,  48,  45,  42),
            new Pokemon(97,  "Hypno",       List.of("Psychic"),           85,  73,  70,  67),
            new Pokemon(98,  "Krabby",      List.of("Water"),             30,  105, 90,  50),
            new Pokemon(99,  "Kingler",     List.of("Water"),             55,  130, 115, 75),
            new Pokemon(100, "Voltorb",     List.of("Electric"),          40,  30,  50,  100),
            new Pokemon(101, "Electrode",   List.of("Electric"),          60,  50,  70,  140),
            new Pokemon(102, "Exeggcute",   List.of("Grass","Psychic"),   60,  40,  80,  40),
            new Pokemon(103, "Exeggutor",   List.of("Grass","Psychic"),   95,  95,  85,  55),
            new Pokemon(104, "Cubone",      List.of("Ground"),            50,  50,  95,  35),
            new Pokemon(105, "Marowak",     List.of("Ground"),            60,  80,  110, 45),
            new Pokemon(106, "Hitmonlee",   List.of("Fighting"),          50,  120, 53,  87),
            new Pokemon(107, "Hitmonchan",  List.of("Fighting"),          50,  105, 79,  76),
            new Pokemon(108, "Lickitung",   List.of("Normal"),            90,  55,  75,  30),
            new Pokemon(109, "Koffing",     List.of("Poison"),            40,  65,  95,  35),
            new Pokemon(110, "Weezing",     List.of("Poison"),            65,  90,  120, 60),
            new Pokemon(111, "Rhyhorn",     List.of("Ground","Rock"),     80,  85,  95,  25),
            new Pokemon(112, "Rhydon",      List.of("Ground","Rock"),     105, 130, 120, 40),
            new Pokemon(113, "Chansey",     List.of("Normal"),            250, 5,   5,   50),
            new Pokemon(114, "Tangela",     List.of("Grass"),             65,  55,  115, 60),
            new Pokemon(115, "Kangaskhan",  List.of("Normal"),            105, 95,  80,  90),
            new Pokemon(116, "Horsea",      List.of("Water"),             30,  40,  70,  60),
            new Pokemon(117, "Seadra",      List.of("Water"),             55,  65,  95,  85),
            new Pokemon(118, "Goldeen",     List.of("Water"),             45,  67,  60,  63),
            new Pokemon(119, "Seaking",     List.of("Water"),             80,  92,  65,  68),
            new Pokemon(120, "Staryu",      List.of("Water"),             30,  45,  55,  85),
            new Pokemon(121, "Starmie",     List.of("Water","Psychic"),   60,  75,  85,  115),
            new Pokemon(122, "Mr. Mime",    List.of("Psychic"),           40,  45,  65,  90),
            new Pokemon(123, "Scyther",     List.of("Bug","Flying"),      70,  110, 80,  105),
            new Pokemon(124, "Jynx",        List.of("Ice","Psychic"),     65,  50,  35,  95),
            new Pokemon(125, "Electabuzz",  List.of("Electric"),          65,  83,  57,  105),
            new Pokemon(126, "Magmar",      List.of("Fire"),              65,  95,  57,  93),
            new Pokemon(127, "Pinsir",      List.of("Bug"),               65,  125, 100, 85),
            new Pokemon(128, "Tauros",      List.of("Normal"),            75,  100, 95,  110),
            new Pokemon(129, "Magikarp",    List.of("Water"),             20,  10,  55,  80),
            new Pokemon(130, "Gyarados",    List.of("Water","Flying"),    95,  125, 79,  81),
            new Pokemon(131, "Lapras",      List.of("Water","Ice"),       130, 85,  80,  60),
            new Pokemon(132, "Ditto",       List.of("Normal"),            48,  48,  48,  48),
            new Pokemon(133, "Eevee",       List.of("Normal"),            55,  55,  50,  55),
            new Pokemon(134, "Vaporeon",    List.of("Water"),             130, 65,  60,  65),
            new Pokemon(135, "Jolteon",     List.of("Electric"),          65,  65,  60,  130),
            new Pokemon(136, "Flareon",     List.of("Fire"),              65,  130, 60,  65),
            new Pokemon(137, "Porygon",     List.of("Normal"),            65,  60,  70,  40),
            new Pokemon(138, "Omanyte",     List.of("Rock","Water"),      35,  40,  100, 35),
            new Pokemon(139, "Omastar",     List.of("Rock","Water"),      70,  60,  125, 55),
            new Pokemon(140, "Kabuto",      List.of("Rock","Water"),      30,  80,  90,  55),
            new Pokemon(141, "Kabutops",    List.of("Rock","Water"),      60,  115, 105, 80),
            new Pokemon(142, "Aerodactyl",  List.of("Rock","Flying"),     80,  105, 65,  130),
            new Pokemon(143, "Snorlax",     List.of("Normal"),            160, 110, 65,  30),
            new Pokemon(144, "Articuno",    List.of("Ice","Flying"),      90,  85,  100, 85),
            new Pokemon(145, "Zapdos",      List.of("Electric","Flying"), 90,  90,  85,  100),
            new Pokemon(146, "Moltres",     List.of("Fire","Flying"),     90,  100, 90,  90),
            new Pokemon(147, "Dratini",     List.of("Dragon"),            41,  64,  45,  50),
            new Pokemon(148, "Dragonair",   List.of("Dragon"),            61,  84,  65,  70),
            new Pokemon(149, "Dragonite",   List.of("Dragon","Flying"),   91,  134, 95,  80),
            new Pokemon(150, "Mewtwo",      List.of("Psychic"),           106, 110, 90,  130),
            new Pokemon(151, "Mew",         List.of("Psychic"),           100, 100, 100, 100)
        ));
    }

    public List<Pokemon> getAll() { return pokemonList; }

    public Optional<Pokemon> getById(int id) {
        return pokemonList.stream().filter(p -> p.getId() == id).findFirst();
    }

    public Pokemon add(Pokemon pokemon) {
        pokemon.setId(nextId++);
        pokemonList.add(pokemon);
        return pokemon;
    }

    public Optional<Pokemon> update(int id, Pokemon updated) {
        return getById(id).map(existing -> {
            existing.setName(updated.getName());
            existing.setTypes(updated.getTypes());
            existing.setHp(updated.getHp());
            existing.setAttack(updated.getAttack());
            existing.setDefense(updated.getDefense());
            existing.setSpeed(updated.getSpeed());
            return existing;
        });
    }

    public boolean delete(int id) {
        return pokemonList.removeIf(p -> p.getId() == id);
    }
}
