using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SuperHero : MonoBehaviour
{
   
    protected string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (_name == null || _name == "")
            {
                _name = "N/A";
            }
            _name = value;
        }
    }
    public abstract void Move();
    public abstract void Attack();

    private void Start()
    {
        Move();
        Attack();
        SpecialBility();
    }

    public virtual void SpecialBility()
    {

    }
    protected int hp;

    public int Hp { get { return hp; } set { hp = value; } }

    public string SuitColor { get; protected set; }

    private float armorStrenght;

    public void UpdateArmorStrenght(float strenght)
    {
        armorStrenght += strenght;
        Debug.Log($"{_name} updated armor to {armorStrenght}");
    }

    public void TakeDamage(int Damage)
    {
        Hp -= Damage;
        Debug.Log($"When damaged{Hp}");

        if (IsDead());
        {
            Debug.Log($"{_name} is Dead");
        }

    }

    public bool IsDead()
    {
        return Hp <= 0;
    }
    
}