using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGameLiAdv
{
    /// <summary>
    /// 怪物类
    /// </summary>
    public class Monster
    {
        public Monster(string name, int hp)
        {
            this.HP = hp;
            this.Name = name;
        }

        /// <summary>
        /// 怪物生命值
        /// </summary>
        public int HP { get; set; }
        /// <summary>
        /// 怪物的名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 怪物被攻击时，被调用的方法，用来处理被攻击后的状态更改
        /// </summary>
        /// <param name="loss">此次攻击损失的HP</param>
        public void Notify(int loss)
        {
            if (this.HP <= 0)
            {
                Console.WriteLine("此怪物已死");
                return;
            }
            this.HP -= loss;
            if (this.HP <= 0)
            {
                Console.WriteLine("怪物" + this.Name + "被打死。");
            }
            else
            {
                Console.WriteLine("怪物" + this.Name + "损失" + loss + "HP");
            }
        }
    }
}
