using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/BodyPart", order = 1)]
    public class BodyPart : ScriptableObject
    {
        public bool IsBroken;
        public double Health;
        public double HealthLimit;
        public Guid DropItem;
    }
}
