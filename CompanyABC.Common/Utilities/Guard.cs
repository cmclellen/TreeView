using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CompanyABC.Common.Utilities
{
    public static class Guard
    {
        public static void NotNull<T>(Expression<Func<T>> reference, T value)
        {
            if (value == null)
                throw new ArgumentNullException(GetParameterName(reference), "Parameter cannot be null.");
        }

        public static void NotNullOrEmpty(Expression<Func<string>> reference, string value)
        {
            NotNull<string>(reference, value);
            if (value.Length == 0)
                throw new ArgumentException("Parameter cannot be empty.", GetParameterName(reference));
        }

        public static void IsValid<T>(Expression<Func<T>> reference, T value, Func<T, bool> validate, string message)
        {
            if (!validate(value))
                throw new ArgumentException(message, GetParameterName(reference));
        }

        public static void IsValid<T>(Expression<Func<T>> reference, T value, Func<T, bool> validate, string format, params object[] args)
        {
            if (!validate(value))
                throw new ArgumentException(string.Format(format, args), GetParameterName(reference));
        }

        private static string GetParameterName(Expression reference)
        {
            var lambda = reference as LambdaExpression;
            var member = lambda.Body as MemberExpression;

            return member.Member.Name;
        }
    }
}
