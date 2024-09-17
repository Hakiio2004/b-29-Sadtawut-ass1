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
        Debug.Log($" {Name} is LeapAndJump");
    }
    //กำหนด Rendom ดาเมท IronMan
    public void ThrowShield(IronMan target)
    {
        Debug.Log($" {Name} is  ThrowShield");
    }
}
