using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorStrange : SuperHero
{
    public override void Move()
    {
        Debug.Log($" {_name} is Open the dimensional door");
    }
    //กำหนด Rendom ดาเมท IronMan
    public override void Attack()
    {
        Debug.Log($" {_name} is Casting Spells");
    }
    public override void SpecialBility()
    {
        Debug.Log($" {_name} is Mirror dimensional");
    }
}
