using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero 
{   
    {
       protected string name;
       public string Name
       {
            get
            {
                return name;
            }
            set
            {
                if (name == null || name "")
                {
                    name = "N/A";
                }
            }
       }

       protected int Hp; 
      
       public int Hp { get { return hp; } set { hp = value; } }

       public string SuitColor { get; set; }

       private float armorStrenght;

       public string GrtHp()
       {
            return hp;
       }

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
        Debug.Log($"{name} updated armor to {armorStrenght}");
    }

public void TakeDamage(int Damage)
    {
        Hp -= Damage;
        Debug.Log($"When damaged{Hp}");

        if (IsDead());
        {
            Debug.Log{$"{name} is Dead"}
        }
       
    }
    
    public bool IsDead()
    {
        return Hp <= 0;
    }
    
}