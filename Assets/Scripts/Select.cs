using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class Select : Base {
    void Start()
    {
        Observable.Return(new Vector3(0, 1.5f, 0))
            .Subscribe(v => gameObject.transform.position = v);

        this.UpdateAsObservable().Select(_ => 2)
        .Subscribe(l => Move(0.01f * l, 0));
    }
}