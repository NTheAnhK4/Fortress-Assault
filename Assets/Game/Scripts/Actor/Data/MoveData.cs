using System;
using UnityEngine;

[System.Serializable]
public class MoveData : IData
{
    public float moveSpeed;
    public MoveId moveId;
}

public enum MoveId
{
    StraightMove
}
