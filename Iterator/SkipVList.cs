using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class SkipVList : IEnumerable
    {
        IEnumerable<string> collection;
        public SkipVList(IEnumerable<string> collection)
        {
            this.collection = collection;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in collection)
            {
                if (item.StartsWith("V"))
                {
                    continue;
                }
                yield return item;
            }
        }
    }
}
