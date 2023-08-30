using UnityEngine;

[CreateAssetMenu(fileName = "New Pokemon", menuName = "Pokemon")]
public class PokemonScriptable : ScriptableObject
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
}
