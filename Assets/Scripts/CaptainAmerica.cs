using Unity.VisualScripting;
using UnityEngine;

public class CaptainAmerica : SuperHero
{
   
    public void LeapAndJump()
    {
        Debug.Log($" {_name} is LeapAndJump");
    }
    //กำหนด Rendom ดาเมท IronMan
    public void ThrowShield()
    {
        Debug.Log($" {_name} is  ThrowShield");
    }
}
