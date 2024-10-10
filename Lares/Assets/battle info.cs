

namespace Lares
{

public struct AttackInfo
{
public int attackValue { get; private set; } // the attackers physical attack or magic attack stat
public int attackPower {get; private set;) //the power of the attack
public int weaponModifier { get; private set; } // physical or seri modifier of the equipped weapon 
public bool crit { get; private set; }
public int attackCritMod { get; private set; } 
public int weaponCritMod { get; private set; } 
}

public class BattleInfo : MonoBehaviour
{
public int level { get; private set; }
public int HP { get; private set; } 
public int maxHP { get; private set; }
public int SP { get; private set; } 
public int maxSP { get; private set; } 
public int EXP { get; private set; } 
public int physicalAttack { get; private set; }
public int physicalDefense { get; private set; } 
public int SeriAttack { get; private set; } 
public int SeriDefense { get; private set; }
public int agility { get; private set; }
public int luck { get; private set; } 

public SeriAttack(AttackInfo attack) 
{
// performed on you to cause HP loss 
} 

public PhysicalAttack(AttackInfo attack) 
{

}
}

}
