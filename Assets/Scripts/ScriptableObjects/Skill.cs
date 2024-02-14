using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects
{
    public class Skill : ScriptableObject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [ContextMenu("SetId")]
        public void SetId() 
        {
            Id = Guid.NewGuid();
        }
    }

}
