using System;
using System.Collections.Generic;
using System.Linq;

namespace Strings.Class
{
    public static class BaseHelper
    {
        public static string ExceedingMaxLength(this string stringToAdd, int maxLength)
        {
            return stringToAdd.Length > maxLength ? stringToAdd.Substring(0, maxLength) : stringToAdd;
        }

        public static string RemovingContiguousCharacters(this string stringToAdd)
        {
            return new string(stringToAdd.ToCharArray().Distinct().ToArray());
        }

        public static string ReplaceCharacterWithAnother(this string stringToAdd, string replaceCharacter, string replaceWithCharacter)
        {
            return stringToAdd.Contains(replaceCharacter) ? stringToAdd.Replace(replaceCharacter, replaceWithCharacter) : stringToAdd;
        }

        public static string ReplaceWithEmptyString(this string stringToAdd, string replaceCharacter)
        {
            return stringToAdd.Contains(replaceCharacter) ? stringToAdd.Replace(replaceCharacter, string.Empty): stringToAdd;
        }
    }
}