using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Main : MonoBehaviour
{

    // ตัวรันชุดคำสั่งทั้งหมด
    void Start()
    {
        ironMan.Name("Milk");
        
        IronMan ironMan = new IronMan("Tony", 100, "Red");
        Debug.Log($"IronMan name:{ironMan.Name} HP:{ironMan.Hp} SuitColor:{ironMan.SuitColor}");

        ironMan.Fly();  
        ironMan.UpdateArmorStrenght(5.25f);

        CaptainAmerica captainAmerica  = new CaptainAmerica("Steve", 100, "Blue");
        Debug.Log($"CaptainAmerica name:{captainAmerica.Name} HP:{captainAmerica.Hp} SuitColor:{captainAmerica.SuitColor}");

        captainAmerica.LeapAndJump();
        captainAmerica.UpdateArmorStrenght(5.25f);

    }

    //เมื่อเลือดทั้ง 2 ตีไม่ตายจะตีวนลูปตีเรื่อยๆ
    private void updated ()
    {
          if(ironMan.IsDead() || captainAmerica.IsDead)
         {
            return;
         } 
          
           int randomDamage = Random.Range(10, 21);
           ironMan.ShootingLaser();
           captainAmerica.TakeDamage(randomDamage);

           randomDamage = Rendom.Range(10, 21);
           captainAmerica.ThrowShield();
           captainAmerica.TakeDamage(randomDamage);
    }
}
