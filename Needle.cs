using System;
namespace Assignment_6
{
    public class Needle
    {
        public int StrStr(string haystack, string needle)
        {
            int index = haystack.IndexOf(needle);
            return index;
        }
    }

}

