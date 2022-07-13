using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class TakeWhile : Base
{
    void Start()
    {
        gameObject.transform.position = new Vector3(0, -2.0f, 0);
        this.UpdateAsObservable()
            .TakeWhile(l => gameObject.transform.position.x <= 2)
            .Subscribe(l => Move(0.01f, 0));
    }
}
