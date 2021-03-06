using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HtmlTags
{
#if !ASPNETCORE
    [Serializable]
#endif
    internal class Cache<TKey, TValue> : IEnumerable<TValue> where TValue : class
    {
        private readonly object _locker = new object();
        private readonly IDictionary<TKey, TValue> _values;

        private Func<TValue, TKey> _getKey = arg => { throw new NotImplementedException(); };

        private Func<TKey, TValue> _onMissing = key =>
        {
            var message = $"Key '{key}' could not be found";
            throw new KeyNotFoundException(message);
        };

        public Cache()
            : this(new Dictionary<TKey, TValue>())
        {
        }

        public Cache(Func<TKey, TValue> onMissing)
            : this(new Dictionary<TKey, TValue>(), onMissing)
        {
        }

        public Cache(IDictionary<TKey, TValue> dictionary, Func<TKey, TValue> onMissing)
            : this(dictionary)
        {
            _onMissing = onMissing;
        }

        public Cache(IDictionary<TKey, TValue> dictionary)
        {
            _values = dictionary;
        }

        public Func<TKey, TValue> OnMissing { set { _onMissing = value; } }

        public Func<TValue, TKey> GetKey { get { return _getKey; } set { _getKey = value; } }

        public int Count => _values.Count;

        public TValue First => _values.Select(pair => pair.Value).FirstOrDefault();

        public IDictionary<TKey, TValue> Inner => _values;


        public TValue this[TKey key]
        {
            get
            {
                if (!_values.ContainsKey(key))
                {
                    lock (_locker)
                    {
                        if (!_values.ContainsKey(key))
                        {
                            TValue value = _onMissing(key);
                            _values.Add(key, value);
                        }
                    }
                }

                return _values[key];
            }
            set
            {
                if (_values.ContainsKey(key))
                {
                    _values[key] = value;
                }
                else
                {
                    _values.Add(key, value);
                }
            }
        }

        #region IEnumerable<TValue> Members

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<TValue>) this).GetEnumerator();

        public IEnumerator<TValue> GetEnumerator() => _values.Values.GetEnumerator();

        #endregion

        public IEnumerable<TKey> GetKeys() => _values.Keys;

        public void Fill(TKey key, TValue value)
        {
            if (_values.ContainsKey(key))
            {
                return;
            }

            _values.Add(key, value);
        }

        public bool TryRetrieve(TKey key, out TValue value)
        {
            value = default(TValue);

            if (_values.ContainsKey(key))
            {
                value = _values[key];
                return true;
            }

            return false;
        }

        public void Each(Action<TValue> action)
        {
            foreach (var pair in _values)
            {
                action(pair.Value);
            }
        }

        public void Each(Action<TKey, TValue> action)
        {
            foreach (var pair in _values)
            {
                action(pair.Key, pair.Value);
            }
        }

        public bool Has(TKey key) => _values.ContainsKey(key);

        public bool Exists(Predicate<TValue> predicate)
        {
            var returnValue = false;

            Each(value => returnValue |= predicate(value));

            return returnValue;
        }

        public TValue Find(Predicate<TValue> predicate) => _values.Where(pair => predicate(pair.Value)).Select(pair => pair.Value).FirstOrDefault();

        public TValue[] GetAll()
        {
            var returnValue = new TValue[Count];
            _values.Values.CopyTo(returnValue, 0);

            return returnValue;
        }

        public void Remove(TKey key)
        {
            if (_values.ContainsKey(key))
            {
                _values.Remove(key);
            }
        }

        public void ClearAll() => _values.Clear();
    }
}