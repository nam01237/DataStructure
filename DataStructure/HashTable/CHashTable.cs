using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.HashTable
{
    public class CHashTable<K, T>
    {
        private int _slotSize;
        private List<HTNode>[] _slot;

        public CHashTable(int slotSize)
        {
            _slotSize = slotSize;
            _slot = new List<HTNode>[slotSize];

            for(int i = 0; i < _slot.Length; i++)
            {
                _slot[i] = new List<HTNode>();
            }
        }

        public bool Insert(K key, T value)
        {
            int index = key.GetHashCode() % _slotSize;

            if (_slot[index].Exists(x => x.Key.Equals(key)))
            {
                return false;                
            }

            _slot[index].Add(new HTNode(key, value));

            return true;
        }

        public T GetValue(K key)
        {
            if (Search(key) == null)
                return default(T);

            return Search(key).Value;
        }

        public bool Remove(K key)
        {
            if (Search(key) == null)
                return false;

            int index = key.GetHashCode() % _slotSize;

            _slot[index].Remove(Search(key));

            return true;
        }

        private HTNode Search(K key)
        {

            int index = key.GetHashCode() % _slotSize;

            if (_slot[index] == null)
                return null;

            return _slot[index].Find(x => x.Key.Equals(key));
        }  
        
        public void TestShow()
        {
  
            foreach(List<HTNode> item in _slot)
            {
                if( item.Count() == 1 )
                    Console.WriteLine(item[0].Key);

                if ( item.Count() == 2)
                    Console.WriteLine(item[1].Key);
            }

        }

        private class HTNode
        {
            public HTNode(K key, T value)
            {
                Key = key;
                Value = value;
            }

            public K Key { get; set; }
            public T Value { get; set; }
        }
    }


        
}
