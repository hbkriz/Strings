using System;
using System.Collections.Generic;
using System.Linq;

namespace Strings.Class
{
    public class Class1
    {
        public List<string> Processor(List<string> unprocessedStrings)
        {
            if(unprocessedStrings == null) return new List<string>();

            return unprocessedStrings.Where(m => !string.IsNullOrEmpty(m)).Select(i => i
                                .ExceedingMaxLength(Constants.maxLength)
                                .RemovingContiguousCharacters()
                                .ReplaceCharacterWithAnother(Constants.Dollar, Constants.Pound)
                                .ReplaceWithEmptyString(Constants.Symbol)
                                .ReplaceWithEmptyString(Constants.Number)).ToList();
        }
    }
}
