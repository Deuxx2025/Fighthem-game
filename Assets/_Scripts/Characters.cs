using UnityEngine;

[CreateAssetMenu(fileName = "Characters", menuName = "Scriptable Objects/Characters")]
public class Characters : ScriptableObject
{
    public string Name; 
    public string Class;
    public string Type;
    public int Health;
    public int Damage;
    public int Defense;
    public int Mana;
}
