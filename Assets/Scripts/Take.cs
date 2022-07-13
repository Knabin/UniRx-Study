using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class Take : Base
{
    void Start()
    {
        gameObject.transform.position = new Vector3(0, -1.5f, 0);
        this.UpdateAsObservable()
            .Take(100)
            .Subscribe(l => Move(0.01f, 0));
    }
}
