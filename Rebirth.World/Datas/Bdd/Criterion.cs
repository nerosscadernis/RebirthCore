using Rebirth.Common.Protocol.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Bdd
{
    public abstract class Criterion : ConditionExpression
    {
        public ComparaisonOperatorEnum Operator
        {
            get;
            set;
        }
        public string Literal
        {
            get;
            set;
        }
        public static ComparaisonOperatorEnum? TryGetOperator(char c)
        {
            ComparaisonOperatorEnum? result;
            if (c != '!')
            {
                switch (c)
                {
                    case '<':
                        result = new ComparaisonOperatorEnum?(ComparaisonOperatorEnum.INFERIOR);
                        break;
                    case '=':
                        result = new ComparaisonOperatorEnum?(ComparaisonOperatorEnum.EQUALS);
                        break;
                    case '>':
                        result = new ComparaisonOperatorEnum?(ComparaisonOperatorEnum.SUPERIOR);
                        break;
                    default:
                        if (c != '~')
                        {
                            result = null;
                        }
                        else
                        {
                            result = new ComparaisonOperatorEnum?(ComparaisonOperatorEnum.LIKE);
                        }
                        break;
                }
            }
            else
            {
                result = new ComparaisonOperatorEnum?(ComparaisonOperatorEnum.INEQUALS);
            }
            return result;
        }
        public static char GetOperatorChar(ComparaisonOperatorEnum op)
        {
            char result;
            switch (op)
            {
                case ComparaisonOperatorEnum.EQUALS:
                    result = '=';
                    break;
                case ComparaisonOperatorEnum.INEQUALS:
                    result = '!';
                    break;
                case ComparaisonOperatorEnum.SUPERIOR:
                    result = '>';
                    break;
                case ComparaisonOperatorEnum.INFERIOR:
                    result = '<';
                    break;
                case ComparaisonOperatorEnum.LIKE:
                    result = '~';
                    break;
                case ComparaisonOperatorEnum.STARTWITH:
                    result = 's';
                    break;
                case ComparaisonOperatorEnum.STARTWITHLIKE:
                    result = 'S';
                    break;
                case ComparaisonOperatorEnum.ENDWITH:
                    result = 'e';
                    break;
                case ComparaisonOperatorEnum.ENDWITHLIKE:
                    result = 'E';
                    break;
                case ComparaisonOperatorEnum.VALID:
                    result = 'v';
                    break;
                case ComparaisonOperatorEnum.INVALID:
                    result = 'i';
                    break;
                case ComparaisonOperatorEnum.UNKNOWN_1:
                    result = '#';
                    break;
                case ComparaisonOperatorEnum.UNKNOWN_2:
                    result = '/';
                    break;
                case ComparaisonOperatorEnum.UNKNOWN_3:
                    result = 'X';
                    break;
                default:
                    throw new System.Exception(string.Format("{0} is not a valid comparaison operator", op));
            }
            return result;
        }
        public static Criterion CreateCriterionByName(string name)
        {
            Criterion result;
            if (!StatsCriterion.IsStatsIdentifier(name))
            {
                switch (name)
                {
                    case "PO":
                        return new HasItemCriterion();
                }
                return new DefaultCriterion(name);
            }
            result = new StatsCriterion(name);
            return result;
        }
        public abstract void Build();
        protected bool Compare(object obj, object comparand)
        {
            bool result;
            switch (this.Operator)
            {
                case ComparaisonOperatorEnum.EQUALS:
                    result = obj.Equals(comparand);
                    break;
                case ComparaisonOperatorEnum.INEQUALS:
                    result = !obj.Equals(comparand);
                    break;
                default:
                    throw new System.NotImplementedException(string.Format("Cannot use {0} comparator on objects {1} and {2}", this.Operator, obj, comparand));
            }
            return result;
        }
        protected bool Compare<T>(System.IComparable<T> obj, T comparand)
        {
            int num = obj.CompareTo(comparand);
            bool result;
            switch (this.Operator)
            {
                case ComparaisonOperatorEnum.EQUALS:
                    result = (num == 0);
                    break;
                case ComparaisonOperatorEnum.INEQUALS:
                    result = (num != 0);
                    break;
                case ComparaisonOperatorEnum.SUPERIOR:
                    result = (num > 0);
                    break;
                case ComparaisonOperatorEnum.INFERIOR:
                    result = (num < 0);
                    break;
                default:
                    throw new System.NotImplementedException(string.Format("Cannot use {0} comparator on IComparable {1} and {2}", this.Operator, obj, comparand));
            }
            return result;
        }
        protected bool Compare(string str, string comparand)
        {
            switch (this.Operator)
            {
                case ComparaisonOperatorEnum.EQUALS:
                    {
                        bool result = str == comparand;
                        return result;
                    }
                case ComparaisonOperatorEnum.INEQUALS:
                    {
                        bool result = str != comparand;
                        return result;
                    }
                case ComparaisonOperatorEnum.LIKE:
                    {
                        bool result = str.Equals(comparand, System.StringComparison.OrdinalIgnoreCase);
                        return result;
                    }
                case ComparaisonOperatorEnum.STARTWITH:
                    {
                        bool result = str.StartsWith(comparand);
                        return result;
                    }
                case ComparaisonOperatorEnum.STARTWITHLIKE:
                    {
                        bool result = str.StartsWith(comparand, System.StringComparison.OrdinalIgnoreCase);
                        return result;
                    }
                case ComparaisonOperatorEnum.ENDWITH:
                    {
                        bool result = str.EndsWith(comparand);
                        return result;
                    }
                case ComparaisonOperatorEnum.ENDWITHLIKE:
                    {
                        bool result = str.EndsWith(comparand, System.StringComparison.OrdinalIgnoreCase);
                        return result;
                    }
            }
            throw new System.NotImplementedException(string.Format("Cannot use {0} comparator on strings '{1}' and '{2}'", this.Operator, str, comparand));
        }
        protected string FormatToString(string identifier)
        {
            return string.Format("{0}{1}{2}", identifier, Criterion.GetOperatorChar(this.Operator), this.Literal);
        }
    }
}
