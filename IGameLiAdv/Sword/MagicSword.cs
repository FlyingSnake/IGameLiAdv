using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IGameLiAdv.Interface;

namespace IGameLiAdv.Sword
{
    internal sealed class MagicSword:IAttackStrategy
    {
        private Random _random = new Random();
        public void AttackTarget(Monster monster)
        {
            int loss = (_random.NextDouble() < 0.5) ? 100 : 200;
            if (loss == 200)
            {
                Console.WriteLine("出现暴击！！！");
            }
            monster.Notify(loss);
        }
    }
}
