using Rebirth.World.Datas.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Bdd
{
    public abstract class ConditionExpression
    {
        public static ConditionExpression Parse(string str)
        {
            ConditionParser conditionParser = new ConditionParser(str);
            return conditionParser.Parse();
        }
        public abstract bool Eval(Character character);
    }
}
