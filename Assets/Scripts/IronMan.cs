using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class IronMan : SuperHero
{
   
    public override void Move()
    {
        Debug.Log($" {_name} is flying");
    }
    //กำหนด Rendom ดาเมท CaptainAmerica
    public override void Attack()
    {
        Debug.Log($" {_name} is ShootingLaser");
    }
}