using UnityEngine;
using static UnityEngine.GraphicsBuffer;
class IronMan : SuperHero
{
    public IronMan(string newName, int newHp, string newSuitColor) : base(newName, newHp, newSuitColor)
    {

    }
   
    //ชื่อท่า
    public void Fly()
    {
        Debug.Log($" {name} is flying");
    }
    //กำหนด Rendom ดาเมท CaptainAmerica
    public void ShootLaser(CaptainAmerica target)
    {
        Debug.Log($" {name} is ShootingLaser");
    }
}