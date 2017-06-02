using Rebirth.World.Datas.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Bdd
{
    public class DefaultCriterion : Criterion
    {

        public string Identifier
        {
            get;
            private set;
        }

        public DefaultCriterion(string identifier)
        {
            this.Identifier = identifier;
        }

        public override bool Eval(Character character)
        {
            return true;
        }
        public override void Build()
        {

        }
        public override string ToString()
        {
            return base.FormatToString(this.Identifier);
        }
    }
}
