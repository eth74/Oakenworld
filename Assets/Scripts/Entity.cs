using Assets.Scripts.ScriptableObjects;
using System;
using UnityEngine;

[Serializable]
public class Entity : MonoBehaviour
{
    public Guid Id;
    public string Name;
    public int Level;
    public int Experience;
    public bool IsAssignedToPlayer;
    public EntityObject EntityObject;

    [ContextMenu("SetId")]
    public void SetId()
    {

    }
}

