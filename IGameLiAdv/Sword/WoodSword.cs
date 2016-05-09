using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IGameLiAdv.Interface;

namespace IGameLiAdv.Sword
{
    /// <summary>
    /// 木刀攻击
    /// </summary>
    internal sealed class WoodSword:IAttackStrategy
    {
        public void AttackTarget(Monster monster)
        {
            monster.Notify(20);
        }
    }
}
