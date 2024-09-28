using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Main : MonoBehaviour
{
    public IronMan ironMan;
    public CaptainAmerica captainAmerica ;

    // ตัวรันชุดคำสั่งทั้งหมด
    void Start()
    {
        ironMan.Name = "";

        Debug.Log($"IronMan name:{ironMan.Name} HP:{ironMan.Hp} SuitColor:{ironMan.SuitColor}");
        Debug.Log($"CaptainAmerica name:{captainAmerica.Name} HP:{captainAmerica.Hp} SuitColor:{captainAmerica.SuitColor}");

        ironMan.UpdateArmorStrenght(5.25f);
        captainAmerica.UpdateArmorStrenght(5.25f);

        while (ironMan.IsDead() || captainAmerica.IsDead())
        {
            break;
        }
    }

    //เมื่อเลือดทั้ง 2 ตีไม่ตายจะตีวนลูปตีเรื่อยๆ
    private void Update ()
    {
           int randomDamage = Random.Range(10, 21);
           ironMan.Attack();
           captainAmerica.TakeDamage(randomDamage);

           randomDamage = Random.Range(10, 21);
           captainAmerica.Attack();
           captainAmerica.TakeDamage(randomDamage);
    }
}
