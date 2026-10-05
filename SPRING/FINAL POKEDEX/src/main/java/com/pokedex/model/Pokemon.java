package com.pokedex.model;

import java.util.List;

// MODEL - Blueprint for a Pokemon object
public class Pokemon {

    private int id;
    private String name;
    private List<String> types;
    private int hp;
    private int attack;
    private int defense;
    private int speed;

    // Default constructor (required for JSON)
    public Pokemon() {}

    // Constructor with all fields
    public Pokemon(int id, String name, List<String> types,
                   int hp, int attack, int defense, int speed) {
        this.id = id;
        this.name = name;
        this.types = types;
        this.hp = hp;
        this.attack = attack;
        this.defense = defense;
        this.speed = speed;
    }

    // Getters
    public int getId() { return id; }
    public String getName() { return name; }
    public List<String> getTypes() { return types; }
    public int getHp() { return hp; }
    public int getAttack() { return attack; }
    public int getDefense() { return defense; }
    public int getSpeed() { return speed; }

    // Setters
    public void setId(int id) { this.id = id; }
    public void setName(String name) { this.name = name; }
    public void setTypes(List<String> types) { this.types = types; }
    public void setHp(int hp) { this.hp = hp; }
    public void setAttack(int attack) { this.attack = attack; }
    public void setDefense(int defense) { this.defense = defense; }
    public void setSpeed(int speed) { this.speed = speed; }
}
