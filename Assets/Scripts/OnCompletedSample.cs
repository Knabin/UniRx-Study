using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class OnCompletedSample : Base
{
    void Start()
    {
        gameObject.transform.position = new Vector3(0, 1f, 0);

        // 100프레임만 오른쪽으로 이동하고, 끝났다면 더 이상 푸시되는 값이 없기 때문에 OnComplete로 가서 파랗게 된다!
        this.UpdateAsObservable()
            .Take(100).Subscribe(
                _ => { Move(0.01f, 0); },    // 푸시되었다면 오른쪽으로 이동
                // 전부 끝났다면 파랗게 만든다.
                () => { 
                    GetComponent<Renderer>().material.color = Color.blue;
                }
            );
    }
}
