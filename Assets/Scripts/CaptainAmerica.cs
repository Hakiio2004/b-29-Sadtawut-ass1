using Unity.VisualScripting;
using UnityEngine;

class CaptainAmerica : SuperHero
{
    public IronMan(string newName, int newHp, string newSuitColor) : base(newName, newHp, newSuitColor)
    {
        
    }
   
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
