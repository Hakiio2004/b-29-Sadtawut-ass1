using UnityEngine;
using static UnityEngine.GraphicsBuffer;
public Sclass IronMan : SuperHero
{
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