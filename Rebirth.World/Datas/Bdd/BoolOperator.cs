using Rebirth.World.Datas.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Bdd
{
    public class BoolOperator : ConditionExpression
    {
        public ConditionExpression Left
        {
            get;
            set;
        }
        public ConditionExpression Right
        {
            get;
            set;
        }
        public BoolOperatorEnum Operator
        {
            get;
            set;
        }
        public static BoolOperatorEnum? TryGetOperator(char c)
        {
            BoolOperatorEnum? result;
            if (c != '&')
            {
                if (c != '|')
                {
                    result = null;
                }
                else
                {
                    result = new BoolOperatorEnum?(BoolOperatorEnum.OR);
                }
            }
            else
            {
                result = new BoolOperatorEnum?(BoolOperatorEnum.AND);
            }
            return result;
        }
        public static char GetOperatorChar(BoolOperatorEnum op)
        {
            char result;
            switch (op)
            {
                case BoolOperatorEnum.AND:
                    result = '&';
                    break;
                case BoolOperatorEnum.OR:
                    result = '|';
                    break;
                default:
                    throw new System.Exception(string.Format("{0} is not a valid bool operator", op));
            }
            return result;
        }
        public BoolOperator(ConditionExpression left, ConditionExpression right, BoolOperatorEnum @operator)
        {
            this.Left = left;
            this.Right = right;
            this.Operator = @operator;
        }
        public override bool Eval(Character character)
        {
            if (this.Operator != BoolOperatorEnum.AND && this.Operator != BoolOperatorEnum.OR)
            {
                throw new System.Exception(string.Format("Cannot evaluate {0} : illegal bool operator {1}", this, this.Operator));
            }
            bool flag = this.Left.Eval(character);
            bool result;
            if (this.Operator == BoolOperatorEnum.AND && !flag)
            {
                result = false;
            }
            else
            {
                if (this.Operator == BoolOperatorEnum.OR && flag)
                {
                    result = true;
                }
                else
                {
                    bool flag2 = this.Right.Eval(character);
                    if (this.Operator == BoolOperatorEnum.AND)
                    {
                        result = (flag && flag2);
                    }
                    else
                    {
                        if (this.Operator != BoolOperatorEnum.OR)
                        {
                            throw new System.Exception(string.Format("Cannot evaluate {0}", this));
                        }
                        result = (flag || flag2);
                    }
                }
            }
            return result;
        }
        public override string ToString()
        {
            return string.Format("{0}{1}{2}", this.Left, BoolOperator.GetOperatorChar(this.Operator), this.Right);
        }
    }
}
