using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class SafeUpdateThree : Base
{
    void Start()
    {
        gameObject.transform.position = Vector3.zero;
        IDisposable mover = Observable.Interval(TimeSpan.FromMilliseconds(500))
                                    .TakeUntilDestroy(this)
                                    .Subscribe(l => Move(0.1f, 0));
        
        // 0.5초마다, 오른쪽으로 움직인다.
        Observable.Timer(TimeSpan.FromSeconds(5))
                .Subscribe(_ => {
                    mover.Dispose();    // mover를 파괴하고 구독 중지한다.
                    Destroy(gameObject);
                });
    }
}
