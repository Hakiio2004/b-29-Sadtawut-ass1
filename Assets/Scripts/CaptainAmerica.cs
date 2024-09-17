using Unity.VisualScripting;
using UnityEngine;

public class CaptainAmerica : SuperHero
{
    //ชือท่า
    public void LeapAndJump()
    {
        Debug.Log($" {name} is LeapAndJump");
    }
    //กำหนด Rendom ดาเมท IronMan
    public void ThrowShield(IronMan target)
    {
        Debug.Log($" {name} is  ThrowShield");
    }
}
