using Unity.VisualScripting;
using UnityEngine;
class CaptainAmerica
{
    
    public string Name;
    public int Hp;
    public string SuitColor;
    private float armorStrenght;

    
    public CaptainAmerica(string newName, int newHp, string newSuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;
        armorStrenght = 10;
    }
    //ชือท่า
    public void LeapAndJump()
    {
        Debug.Log($" {Name} is LeapAndJump");
    }
    //กำหนด Rendom ดาเมท IronMan
    public void ThrowShield(IronMan target)
    {
        int damage = Random.Range(10, 20);
        Debug.Log($" {Name} is  ThrowShield");
        target.TakeDamage(damage);
    }
    public void UpdateArmorStrenght(float strenght)
    {
        armorStrenght += strenght;
        Debug.Log($"{Name} updated armor to {armorStrenght}");
    }
   //เมื่อค่า Hp เท่ากับ 0 คำสั่งนี้ก็จะทำงาน
    public bool IsDead ()
    {
        if (Hp <= 0)
        {
            Debug.Log($"CaptainAmerica is Dead");
        }
        return true;
    }
    //คำนวนรับค่าดาเมท เมื่อคำสั่ง is dead ทำงาน
    public void TakeDamage (int Damage)
    {
        Hp -= Damage;
        Debug.Log($"When damaged{Hp}");

        if (IsDead());
        
    }
}
