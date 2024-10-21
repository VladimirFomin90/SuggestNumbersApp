using System;
using System.Numerics;

namespace SuggestNumbersApp
{
    internal class NumericTypeSuggester
    {
        public const string BigInteger = "BigInteger";
        public const string ULong = "ulong";
        public const string UInt = "uint";
        public const string UShort = "ushort";
        public const string Byte = "byte";
        public const string Long = "long";
        public const string Int = "int";
        public const string Short = "short";
        public const string SByte = "sbyte";
        public const string Decimal = "decimal";
        public const string Double = "double";
        public const string Float = "float";
        public const string ImpossibleRepresentation =
            "Impossible representation";

        public static string GetName(BigInteger minValue, 
                                       BigInteger maxValue, 
                                       bool IntegersOnly, 
                                       bool Accuracy)
        {
            return IntegersOnly ? GetIntegralNumberName(minValue, maxValue) :
                                  GetFloatingPointNumberName(minValue, maxValue, Accuracy);
        }

        private static string GetFloatingPointNumberName(BigInteger minValue, BigInteger maxValue, bool accuracy)
        {
            throw new NotImplementedException();
        }

        private static string GetIntegralNumberName(BigInteger minValue, BigInteger maxValue)
        {
            throw new NotImplementedException();
        }
    }
}