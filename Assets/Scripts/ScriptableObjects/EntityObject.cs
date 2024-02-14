using Assets.Scripts.Enums;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects
{
    [System.Serializable]
    public class SerializableObjectReference<T> where T : Object
    {
        [SerializeField] private T _value;

        public T Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }

    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Entity", order = 1)]
    public class EntityObject : ScriptableObject
    {
        public EntityRarity Rarity;
        public EntityType Type;
        public bool CanDie;
        public SerializableObjectReference<Skill> Skill_01;
        public SerializableObjectReference<Skill> Skill_02;
        public SerializableObjectReference<Skill> Skill_03;
        public SerializableObjectReference<Skill> Skill_04;
        public SerializableObjectReference<Body> Body;
        public Stats Stats;
        public string IconImage;
        public string ClassImage;
        public Animator Animator;
    }
}
