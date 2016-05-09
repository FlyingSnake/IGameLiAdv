using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IGameLiAdv.Interface;

namespace IGameLiAdv.Sword
{
    /// <summary>
    /// 铁刀
    /// </summary>
    internal sealed class IronSword:IAttackStrategy
    {
        public void AttackTarget(Monster monster)
        {
            monster.Notify(50);
        }
    }
}
