
using System;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Actor Data", menuName = "Data/Actor Data")]
public class ActorData : ScriptableObject
{
   public List<ActorParam> data;
}

[Serializable]
public class ActorParam
{
   public string name;
   public MoveData MoveData;
}