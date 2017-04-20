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
        var tag = GameObject.Find("Tag").GetComponent<Tag>();

        var root = new SelectorNode("/");
        root.Add("/",new DecoratorNode("/IsIt",() => tag.target == this.gameObject.transform));
        root.Add("/IsIt",new ActionNode("/IsIt/RunAfter",() => 
                                                                {
                                                                    move = GameObject.Find("Player").transform.position - this.transform.position;
                                                                    return true;
                                                                }));
        root.Add("/", new ActionNode("/RunAway", () =>
                                                  {
                                                      move = this.transform.position - tag.target.position;
                                                      return true;
                                                  }));

        this.UpdateAsObservable()
            .Subscribe(_ => {
                root.Excute();
        });
        
    }
}
