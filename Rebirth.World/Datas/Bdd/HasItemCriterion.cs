using Rebirth.Common.Protocol.Enums;
using Rebirth.World.Datas.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Bdd
{
    public class HasItemCriterion : Criterion
    {
        public const string Identifier = "PO";
        public int Item
        {
            get;
            set;
        }
        public override bool Eval(Character character)
        {
            bool result;
            if (base.Operator == ComparaisonOperatorEnum.EQUALS)
            {
                //var test = character.Inventory.GetItemByTemplateId((uint)this.Item);
                //result = result = character.Inventory.Items.Any((PlayerItem entry) => entry.Template.id == this.Item);
            }
            else
            {
                //result = (base.Operator != ComparaisonOperatorEnum.INEQUALS || character.Inventory.Items.All((PlayerItem entry) => entry.Template.id != this.Item));
            }
            return false;
        }
        public override void Build()
        {
            int item;
            if (!int.TryParse(base.Literal, out item))
            {
                throw new System.Exception(string.Format("Cannot build HasItemCriterion, {0} is not a valid item id", base.Literal));
            }
            this.Item = item;
        }
        public override string ToString()
        {
            return base.FormatToString("PO");
        }
    }
}
