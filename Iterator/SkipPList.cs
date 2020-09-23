using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class SkipPList : IEnumerable
    {
        IEnumerable<string> collection;
        public SkipPList(IEnumerable<string> collection)
        {
            this.collection = collection;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in collection)
            {
                if (item.StartsWith("P"))
                {
                    continue;
                }
                yield return item;
            }
        }
    }
}
