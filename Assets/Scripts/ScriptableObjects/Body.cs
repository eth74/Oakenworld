using Assets.Scripts.ScriptableObjects;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Body", order = 1)]
public class Body : ScriptableObject
{
    public SerializableObjectReference<BodyPart> Head;
    public SerializableObjectReference<BodyPart> Chest;
    public SerializableObjectReference<BodyPart> LeftArm;
    public SerializableObjectReference<BodyPart> RightArm;
    public SerializableObjectReference<BodyPart> LeftLeg;
    public SerializableObjectReference<BodyPart> RightLeg;
    public SerializableObjectReference<BodyPart> Horns;
    public SerializableObjectReference<BodyPart> Eyes;
    public SerializableObjectReference<BodyPart> Tail;
    public SerializableObjectReference<BodyPart> Wings;
}

