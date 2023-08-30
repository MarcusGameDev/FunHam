using UnityEngine;

public class Pokemon : MonoBehaviour
{
    // Public properties
    public string name;
    public string[] types;
    public int level;
    public int attack;
    public int specialAttack;
    public int defense;
    public int specialDefense;
    public int speed;
    public int hp;
    public string[] availableAttacks;

    // Constructor
    public Pokemon(string name, string[] types, int level, int attack, int specialAttack, int defense, int specialDefense, int speed, int hp, string[] availableAttacks)
    {
        this.name = name;
        this.types = types;
        this.level = level;
        this.attack = attack;
        this.specialAttack = specialAttack;
        this.defense = defense;
        this.specialDefense = specialDefense;
        this.speed = speed;
        this.hp = hp;
        this.availableAttacks = availableAttacks;
    }

    // Public methods
    public void Attack(Pokemon target, string attackName)
    {
        // TODO: Implement attack logic here
    }
}
