using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class AI : MonoBehaviour
{
    public Vector3 move { get; private set; }

    private void Awake()
    {
        move = new Vector3(0,0,0);

        var root = new DecoratorNode(
            () => GameObject.Find("Tag").GetComponent<Tag>().target != transform,
            "DecoratorTest",
            new ActionNode(() =>
            {
                var tag = GameObject.Find("Tag");
                move = tag.transform.position - transform.position;
                return true;
            }, "test")
            );

        this.UpdateAsObservable()
            .Subscribe(_ => {
                root.Excute();
        });
        
    }
}
