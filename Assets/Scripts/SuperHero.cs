using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero 
    {
       public string Name;
    public int Hp;
    public string SuitColor;
    private float armorStrenght;
    }
public SuperHero(string newName, int newHp, string newSuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;
        armorStrenght = 10;
    }
public void UpdateArmorStrenght(float strenght)
    {
        armorStrenght += strenght;
        Debug.Log($"{Name} updated armor to {armorStrenght}");
    }
public void TakeDamage(int Damage)
    {
        Hp -= Damage;
        Debug.Log($"When damaged{Hp}");

        if (IsDead());
       
    }
    public bool IsDead()
    {
        if (Hp <= 0)
        {
            Debug.Log($"IronMan is Dead");
        }
        return true;
    }