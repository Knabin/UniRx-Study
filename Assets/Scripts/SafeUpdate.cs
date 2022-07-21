using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class SafeUpdate : Base
{
    void Start()
    {
        gameObject.transform.position = new Vector3(0, 1f, 0);
        // 5초 후, gameObject가 죽는다!
        Observable.Timer(TimeSpan.FromSeconds(5))
            .Subscribe(_ => Destroy(gameObject));

        // 0.5초마다, 오른쪽으로 움직인다.
        Observable.Interval(TimeSpan.FromMilliseconds(500))
            .Subscribe(l => Move(0.5f, 0))
            .AddTo(this);   // 이걸 지우면 등록을 해제할 수 없고, 예외 발생!
    }
}
