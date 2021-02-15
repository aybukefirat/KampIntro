using System;
using System.Collections.Generic;
using System.Text;

namespace DictHomeWork
{
    class MyDictionary<T,K>
    {
        T[] ItemKey;
        K[] ItemValue;
        public MyDictionary()
        {
            ItemKey = new T[0];
            ItemValue = new K[0];

        }

        public void Add(T key, K value)
        {
            T[] tempArrayK = ItemKey;
            K[] tempArrayV = ItemValue;

            ItemKey = new T[ItemKey.Length + 1];
            ItemValue = new K[ItemValue.Length + 1];

            for (int i = 0; i < tempArrayK.Length; i++)
            {
                ItemKey[i] = tempArrayK[i];
                ItemValue[i] = tempArrayV[i];

            }

            ItemKey[ItemKey.Length - 1] = key;
            ItemValue[ItemValue.Length - 1] = value;

        }
    }
}
