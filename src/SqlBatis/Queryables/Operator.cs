﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SqlBatis
{
    /// <summary>
    /// 数据库操作符
    /// </summary>
    public class Operator
    {
        /// <summary>
        /// in
        /// </summary>
        /// <param name="column">字段</param>
        /// <param name="values">参数</param>
        /// <returns></returns>
        public static bool In(object column, IEnumerable values) => default;
        /// <summary>
        /// in
        /// </summary>
        /// <param name="column">字段</param>
        /// <param name="values">参数</param>
        /// <returns></returns>
        public static bool In(object column, params object[] values) => default;
        /// <summary>
        /// not in
        /// </summary>
        /// <param name="column">字段</param>
        /// <param name="values">参数</param>
        /// <returns></returns>
        public static bool NotIn(object column, IEnumerable values) => default;
        /// <summary>
        /// not in
        /// </summary>
        /// <param name="column">字段</param>
        /// <param name="values">参数</param>
        /// <returns></returns>
        public static bool NotIn(object column, params object[] values) => default;
        /// <summary>
        /// like %value%
        /// </summary>
        /// <param name="column">字段</param>
        /// <param name="value">参数</param>
        /// <returns></returns>
        public static bool Contains(string column, string value) => default;
        /// <summary>
        /// not like %value%
        /// </summary>
        /// <param name="column">字段</param>
        /// <param name="value">参数</param>
        /// <returns></returns>
        public static bool NotContains(string column, string value) => default;
        /// <summary>
        /// like value%
        /// </summary>
        /// <param name="column">字段</param>
        /// <param name="value">参数</param>
        /// <returns></returns>
        public static bool StartsWith(string column, string value) => default;
        /// <summary>
        /// not like value%
        /// </summary>
        /// <param name="column">字段</param>
        /// <param name="value">参数</param>
        /// <returns></returns>
        public static bool NotStartsWith(string column, string value) => default;
        /// <summary>
        /// like %value
        /// </summary>
        /// <param name="column">字段</param>
        /// <param name="value">参数</param>
        /// <returns></returns>
        public static bool EndsWith(string column, string value) => default;
        /// <summary>
        /// not like %value
        /// </summary>
        /// <param name="column">字段</param>
        /// <param name="value">参数</param>
        /// <returns></returns>
        public static bool NotEndsWith(string column, string value) => default;
        /// <summary>
        /// regex value
        /// </summary>
        /// <param name="column">字段</param>
        /// <param name="value">参数</param>
        /// <returns></returns>
        public static bool Regexp(string column, string value) => default;
        /// <summary>
        /// not regex value
        /// </summary>
        /// <param name="column">字段</param>
        /// <param name="value">参数</param>
        /// <returns></returns>
        public static bool NotRegexp(string column, string value) => default;
        /// <summary>
        /// 解析表达式
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        internal static string ResovleExpressionType(ExpressionType type)
        {
            var condition = string.Empty;
            switch (type)
            {
                case ExpressionType.Add:
                    condition = "+";
                    break;
                case ExpressionType.Subtract:
                    condition = "-";
                    break;
                case ExpressionType.Multiply:
                    condition = "*";
                    break;
                case ExpressionType.Divide:
                    condition = "/";
                    break;
                case ExpressionType.Modulo:
                    condition = "%";
                    break;
                case ExpressionType.Equal:
                    condition = "=";
                    break;
                case ExpressionType.NotEqual:
                    condition = "<>";
                    break;
                case ExpressionType.GreaterThan:
                    condition = ">";
                    break;
                case ExpressionType.GreaterThanOrEqual:
                    condition = ">=";
                    break;
                case ExpressionType.LessThan:
                    condition = "<";
                    break;
                case ExpressionType.LessThanOrEqual:
                    condition = "<=";
                    break;
                case ExpressionType.OrElse:
                    condition = "OR";
                    break;
                case ExpressionType.AndAlso:
                    condition = "AND";
                    break;
                case ExpressionType.Not:
                    condition = "NOT";
                    break;
                case ExpressionType.Or:
                    condition = "|";
                    break;
                case ExpressionType.And:
                    condition = "&";
                    break;
                case ExpressionType.ExclusiveOr:
                    condition = "^";
                    break;
                case ExpressionType.LeftShift:
                    condition = "<<";
                    break;
                case ExpressionType.RightShift:
                    condition = ">>";
                    break;
            }
            return condition;
        }
        /// <summary>
        /// 解析表达式
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal static string ResovleExpressionType(string name)
        {
            switch (name)
            {
                case nameof(Operator.In):
                    name = "IN";
                    break;
                case nameof(Operator.NotIn):
                    name = "NOT IN";
                    break;
                case nameof(Operator.Contains):
                case nameof(Operator.StartsWith):
                case nameof(Operator.EndsWith):
                    name = "LIKE";
                    break;
                case nameof(Operator.NotContains):
                case nameof(Operator.NotStartsWith):
                case nameof(Operator.NotEndsWith):
                    name = "NOT LIKE";
                    break;
                case nameof(Operator.Regexp):
                    name = "REGEXP";
                    break;
                case nameof(Operator.NotRegexp):
                    name = "NOT REGEXP";
                    break;
                case "IN":
                    name = "IN";
                    break;
                case "NOT":
                    name = "NOT";
                    break;
                case "~":
                    name = "~";
                    break;
            }
            return name;
        }
    }
}
