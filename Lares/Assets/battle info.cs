

namespace Lares
{

public struct AttackInfo
{
public int AttackValue {get; private set;) //the attackers physical or seri attack value 
public bool crit { get; private set; }

}

public class BattleInfo : MonoBehaviour
{
public int level { get; private set; }
public int HP { get; private set; } 
public int SP { get; private set; } 
public int EXP { get; private set; } 
public int physicalAttack { get; private set; }
public int physicalDefense { get; private set; } 
public int SeriAttack { get; private set; } 
public int SeriDefense { get; private set; }
public int agility { get; private set; }
public int luck { get; private set; } 

public SpecialAttack(AttackInfo attack) 
{
// performes on you to cause HP loss 
} 

public PhysicalAttack(AttackInfo) 
{
}

}
}
