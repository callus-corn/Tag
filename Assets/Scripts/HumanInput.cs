using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class HumanInput : MonoBehaviour ,IInputProvider
{
    public IReadOnlyReactiveProperty<Vector3> MoveDirection { get { return _moveDirection; } }
    private ReactiveProperty<Vector3> _moveDirection = new ReactiveProperty<Vector3>();

	void Start ()
    {
        this.UpdateAsObservable()
            .Select(_ => new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")))
            .Subscribe(move => _moveDirection.Value = move);
	}
}
