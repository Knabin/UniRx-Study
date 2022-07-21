using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class SafeUpdateTwo : Base
{
    void Start()
    {
        gameObject.transform.position = new Vector3(0, 3f, 0);
        // 5초 후, gameObject가 죽는다!
        Observable.Timer(TimeSpan.FromSeconds(5))
            .Subscribe(_ => Destroy(gameObject));

        // 0.5초마다, 오른쪽으로 움직인다.
        Observable.Interval(TimeSpan.FromMilliseconds(500))
            .TakeUntilDestroy(this)
            .Subscribe(l => Move(0.5f, 0));
    }
}
