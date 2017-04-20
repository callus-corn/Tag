using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class COMInput : MonoBehaviour,IInputProvider
{
    private ReactiveProperty<Vector3> _moveDirection = new ReactiveProperty<Vector3>();
    public IReadOnlyReactiveProperty<Vector3> MoveDirection { get { return _moveDirection; } }

    void Start()
    {
        var ai = GetComponent<AI>();
        
        this.UpdateAsObservable()
            .Subscribe(_ => {
                _moveDirection.Value = new Vector3(ai.move.normalized.x * 0.9f, 0, ai.move.normalized.z * 0.9f);
            });
            
	}
}
