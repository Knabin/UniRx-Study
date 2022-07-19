using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class SkipWhile : Base
{
    void Start()
    {
        gameObject.transform.position = new Vector3(0, 0.5f, 0);
        this.UpdateAsObservable()
            .SkipWhile(_ => !Input.GetMouseButton(0))
            .Subscribe(_ => Move(0.01f, 0));
    }
}
