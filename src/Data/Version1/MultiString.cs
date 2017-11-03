﻿
using System.Collections.Generic;
using System.Linq;

namespace PipServices.Quotes.Data.Version1
{
    // TODO: Move to Pip.Services.Common
    public class MultiString : Dictionary<string, string>
    {
        public MultiString(Dictionary<string, string> map)
            : base(map)
        {
        }

        public MultiString(string text)
            : this("en", text)
        {
        }

        public MultiString(string language, string text)
        {
            this[language] = text;
        }

        public override bool Equals(object obj)
        {
            var multiString = obj as MultiString;

            return multiString != null &&
                multiString.Count == Count && 
                !multiString.Except(this).Any();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}