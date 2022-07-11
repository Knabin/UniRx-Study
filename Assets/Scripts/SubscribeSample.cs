using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class SubscribeSample : MonoBehaviour {
    void Start () {
        // Return을 통해 (0, 1, 0)이라는 값을 Subscribe 안으로 흘려 보내 준다.
        Observable.Return(new Vector3(0, 1, 0))
                .Subscribe(v => gameObject.transform.position = v);
        
        // UpdateAsObservable로 Update마다 값을 넣어 준다.
        // update 이벤트는 없지만... this.update += _ => Move(0.01f, 0, 0);
        this.UpdateAsObservable().Subscribe(_ => Move(0.01f, 0, 0));
    }

    public void Move(float dx, float dy, float dz) {
        gameObject.transform.position += new Vector3(dx, dy, dz);
    }
}