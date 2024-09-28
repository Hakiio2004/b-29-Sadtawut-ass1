using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class IronMan : SuperHero
{
    //ชื่อท่า
    public void Fly()
    {
        Debug.Log($" {_name} is flying");
    }
    //กำหนด Rendom ดาเมท CaptainAmerica
    public void ShootLaser()
    {
        Debug.Log($" {_name} is ShootingLaser");
    }
}