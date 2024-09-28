using Unity.VisualScripting;
using UnityEngine;

public class CaptainAmerica : SuperHero
{
   
    public override void Move()
    {
        Debug.Log($" {_name} is LeapAndJump");
    }
    //กำหนด Rendom ดาเมท IronMan
    public override void Attack()
    {
        Debug.Log($" {_name} is  ThrowShield");
    }
}
