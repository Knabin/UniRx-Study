using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class Where : Base {
    void Start()
    {
        // Return으로 (0, 0.5f, 0)라는 값을 Subscribe 안으로 흘려보낸다.
        Observable.Return(new Vector3(0, 0.5f, 0))
            .Subscribe(v => gameObject.transform.position = v);

        // 마우스 좌클릭 시 값을 푸시한다!
        this.UpdateAsObservable().Where(_ => Input.GetMouseButton(0))
            .Subscribe(l => Move(0.01f, 0));
    }
}