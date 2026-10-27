using System.Collections.Generic;
using UnityEngine;

namespace HunterAllen.StateMachine
{
    public static class Extensions
    {
        /// <summary>
        /// Specifically made for dictionaries with lists as the value.
        /// <para>Creates a list if one doesn't exist for the value, adds to it otherwise.</para>
        /// </summary>
        public static void AddCreateIfNull<T1, T2>(this Dictionary<T1, List<T2>> self, T1 key, T2 value)
        {
            if (self.TryGetValue(key, out var value_))
            {
                value_.Add(value);
            }
            else
            {
                self[key] = new() { value };
            }
        }
    }
}
