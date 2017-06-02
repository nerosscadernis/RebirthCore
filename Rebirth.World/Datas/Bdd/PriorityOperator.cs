using Rebirth.World.Datas.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Bdd
{
    public class PriorityOperator : ConditionExpression
    {
        public ConditionExpression Expression
        {
            get;
            set;
        }
        public override bool Eval(Character character)
        {
            return this.Expression.Eval(character);
        }
        public override string ToString()
        {
            return string.Format("({0})", this.Expression);
        }
    }
}
