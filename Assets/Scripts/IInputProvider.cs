using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public interface IInputProvider
{
    IReadOnlyReactiveProperty<Vector3> MoveDirection { get; }
}
