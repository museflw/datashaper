using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataShaper.Models
{
    public class Entity : DynamicObject, IDictionary<string, object>
    {
        private readonly IDictionary<string, object> _expando = null;

        public Entity()
        {
            this._expando = new ExpandoObject();
        }

        public object this[string key]
        {
            get => this._expando[key];
            set => this._expando[key] = value;
        }

        public ICollection<string> Keys => this._expando.Keys;

        public ICollection<object> Values => this._expando.Values;

        public int Count => this._expando.Count;

        public bool IsReadOnly => this._expando.IsReadOnly;

        public void Add(string key, object value)
        {
            this._expando.Add(key, value);
        }

        public void Add(KeyValuePair<string, object> item)
        {
            this._expando.Add(item);
        }

        public void Clear()
        {
            this._expando.Clear();
        }

        public bool Contains(KeyValuePair<string, object> item)
        {
            return this._expando.Contains(item);
        }

        public bool ContainsKey(string key)
        {
            return this._expando.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            this._expando.CopyTo(array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return this._expando.GetEnumerator();
        }

        public bool Remove(string key)
        {
            return this._expando.Remove(key);
        }

        public bool Remove(KeyValuePair<string, object> item)
        {
            return this._expando.Remove(item);
        }

        public bool TryGetValue(string key, [MaybeNullWhen(false)] out object value)
        {
            return this._expando.TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}