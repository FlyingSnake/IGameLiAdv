using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGameLiAdv.Interface
{
    internal interface IAttackStrategy
    {
        void AttackTarget(Monster monster);
    }
}
