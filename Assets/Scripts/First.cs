using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class First : Base
{
    void Start()
    {
        gameObject.transform.position = new Vector3(0, -1f, 0);
        this.UpdateAsObservable()
            .First(l => Input.GetMouseButton(0))
            .Subscribe(l => Move(1.5f, 0));
    }
}
