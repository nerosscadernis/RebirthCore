using Rebirth.Common.Protocol.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Bdd
{
    public class ConditionParser
    {
        private System.Collections.Generic.Dictionary<int, int> m_parentheses = new System.Collections.Generic.Dictionary<int, int>();
        public string String
        {
            get;
            private set;
        }
        public ConditionParser(string s)
        {
            this.String = s;
        }
        public ConditionExpression Parse()
        {
            this.TrimAllSpaces();
            PriorityOperator priorityOperator = null;
            this.ParseParentheses();
            while (this.m_parentheses.ContainsKey(0) && this.m_parentheses[0] == this.String.Length - 1)
            {
                this.String = this.String.Remove(this.String.Length - 1, 1).Remove(0, 1);
                if (priorityOperator != null)
                {
                    priorityOperator.Expression = new PriorityOperator();
                    priorityOperator = (priorityOperator.Expression as PriorityOperator);
                }
                else
                {
                    priorityOperator = new PriorityOperator();
                }
                this.ParseParentheses();
            }
            ConditionExpression conditionExpression = this.TryParseBoolOperator();
            ConditionExpression result;
            if (conditionExpression != null)
            {
                if (priorityOperator != null)
                {
                    priorityOperator.Expression = conditionExpression;
                    result = priorityOperator;
                }
                else
                {
                    result = conditionExpression;
                }
            }
            else
            {
                ConditionExpression conditionExpression2 = this.TryParseComparaisonOperator();
                if (conditionExpression2 == null)
                {
                    throw new System.Exception(string.Format("Cannot parse {0} : No operator found", this.String));
                }
                if (priorityOperator != null)
                {
                    priorityOperator.Expression = conditionExpression2;
                    result = priorityOperator;
                }
                else
                {
                    result = conditionExpression2;
                }
            }
            return result;
        }
        private void TrimAllSpaces()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            bool flag = false;
            for (int i = 0; i < this.String.Length; i++)
            {
                if (this.String[i] == '"')
                {
                    flag = !flag;
                }
                if (flag)
                {
                    stringBuilder.Append(this.String[i]);
                }
                else
                {
                    if (this.String[i] != ' ')
                    {
                        stringBuilder.Append(this.String[i]);
                    }
                }
            }
            this.String = stringBuilder.ToString();
        }
        private ConditionExpression TryParseBoolOperator()
        {
            bool flag = false;
            bool flag2 = false;
            ConditionExpression result;
            for (int i = 0; i < this.String.Length; i++)
            {
                if (this.String[i] == '"')
                {
                    flag = !flag;
                }
                else
                {
                    if (this.String[i] == '(')
                    {
                        flag2 = true;
                    }
                    else
                    {
                        if (this.String[i] == ')')
                        {
                            flag2 = false;
                        }
                        else
                        {
                            if (!flag && !flag2)
                            {
                                BoolOperatorEnum? boolOperatorEnum = BoolOperator.TryGetOperator(this.String[i]);
                                if (boolOperatorEnum.HasValue)
                                {
                                    if (i + 1 >= this.String.Length)
                                    {
                                        throw new System.Exception(string.Format("Cannot parse {0} :  Right Expression of bool operator index {1} is empty", this.String, i));
                                    }
                                    string text = this.String.Substring(0, i);
                                    if (string.IsNullOrEmpty(text))
                                    {
                                        throw new System.Exception(string.Format("Cannot parse {0} : Left Expression of bool operator index {1} is empty", this.String, i));
                                    }
                                    ConditionParser conditionParser = new ConditionParser(text);
                                    ConditionExpression left = conditionParser.Parse();
                                    string text2 = this.String.Substring(i + 1, this.String.Length - (i + 1));
                                    if (string.IsNullOrEmpty(text2))
                                    {
                                        throw new System.Exception(string.Format("Cannot parse {0} : Right Expression of bool operator index {1} is empty", this.String, i));
                                    }
                                    conditionParser = new ConditionParser(text2);
                                    ConditionExpression right = conditionParser.Parse();
                                    result = new BoolOperator(left, right, boolOperatorEnum.Value);
                                    return result;
                                }
                            }
                        }
                    }
                }
            }
            result = null;
            return result;
        }
        private ConditionExpression TryParseComparaisonOperator()
        {
            int i = 0;
            bool flag = false;
            bool flag2 = false;
            ConditionExpression result;
            while (i < this.String.Length)
            {
                if (this.String[i] == '"')
                {
                    flag = !flag;
                    i++;
                }
                else
                {
                    if (this.String[i] == '(')
                    {
                        flag2 = true;
                        i++;
                    }
                    else
                    {
                        if (this.String[i] == ')')
                        {
                            flag2 = false;
                            i++;
                        }
                        else
                        {
                            if (flag || flag2)
                            {
                                i++;
                            }
                            else
                            {
                                ComparaisonOperatorEnum? comparaisonOperatorEnum = Criterion.TryGetOperator(this.String[i]);
                                if (!comparaisonOperatorEnum.HasValue)
                                {
                                    i++;
                                }
                                else
                                {
                                    if (i + 1 >= this.String.Length)
                                    {
                                        throw new System.Exception(string.Format("Cannot parse {0} :  Right Expression of comparaison operator index {1} is empty", this.String, i));
                                    }
                                    string text = this.String.Substring(0, i);
                                    if (string.IsNullOrEmpty(text))
                                    {
                                        throw new System.Exception(string.Format("Cannot parse {0} : Left Expression of comparaison operator index {1} is empty", this.String, i));
                                    }
                                    Criterion criterion = Criterion.CreateCriterionByName(text);
                                    string text2 = this.String.Substring(i + 1, this.String.Length - (i + 1));
                                    if (string.IsNullOrEmpty(text2))
                                    {
                                        throw new System.Exception(string.Format("Cannot parse {0} : Right Expression of comparaison operator index {1} is empty", this.String, i));
                                    }
                                    criterion.Literal = text2;
                                    criterion.Operator = comparaisonOperatorEnum.Value;
                                    criterion.Build();
                                    result = criterion;
                                    return result;
                                }
                            }
                        }
                    }
                }
            }
            result = null;
            return result;
        }
        private void ParseParentheses()
        {
            this.m_parentheses.Clear();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < this.String.Length; i++)
            {
                if (this.String[i] == '(')
                {
                    stack.Push(i);
                }
                if (this.String[i] == ')' && stack.Count > 0)
                {
                    this.m_parentheses.Add(stack.Pop(), i);
                }
                else
                {
                    if (this.String[i] == ')' && stack.Count <= 0)
                    {
                        throw new System.Exception(string.Format("Cannot evaluate {0} : Parenthese at index {1} is not binded to an open parenthese", this.String, i));
                    }
                }
            }
            if (stack.Count > 0)
            {
                throw new System.Exception(string.Format("Cannot evaluate {0} : Parenthese at index {1} is not closed", this.String, stack.Pop()));
            }
        }
    }
}
