using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class Skip : Base
{
    void Start()
    {
        gameObject.transform.position = new Vector3(0, 1f, 0);
        this.UpdateAsObservable()
            .Skip(100)
            .Subscribe(_ => Move(0.01f, 0));
    }
}
