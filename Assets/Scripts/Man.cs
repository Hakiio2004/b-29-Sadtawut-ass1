using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Main : MonoBehaviour
{
    // ตัวรันชุดคำสั่งทั้งหมด
    void Start()
    {
        IronMan ironMan = new IronMan("Tony", 100, "Red");
        Debug.Log($"IronMan name:{ironMan.Name} HP:{ironMan.Hp} SuitColor:{ironMan.SuitColor}");

        ironMan.Fly();  
        ironMan.UpdateArmorStrenght(5.25f);

        CaptainAmerica captainAmerica  = new CaptainAmerica("Steve", 100, "Blue");
        Debug.Log($"CaptainAmerica name:{captainAmerica.Name} HP:{captainAmerica.Hp} SuitColor:{captainAmerica.SuitColor}");

        captainAmerica.LeapAndJump();
        captainAmerica.UpdateArmorStrenght(5.25f);

       //เมื่อเลือดทั้ง 2 ตีไม่ตายจะตีวนลูปตีเรื่อยๆ
        while (ironMan.Hp >= 0 && captainAmerica.Hp >= 0)
        {
            ironMan.ShootLaser(captainAmerica);
            captainAmerica.ThrowShield(ironMan);
        }    
    }
}
