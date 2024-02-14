using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Helpers
{
    public static class Helpers
    {
        [System.Serializable]
        public static class SerializableObjectReference<T> where T : UnityEngine.Object
        {
            [SerializeField] private static T _value;

            public static T Value
            {
                get { return _value; }
                set { _value = value; }
            }
        }

    }
}
