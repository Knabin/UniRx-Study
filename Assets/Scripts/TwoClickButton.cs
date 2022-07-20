using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class TwoClickButton : Base
{
    public Button button;
    void Start()
    {
        gameObject.transform.position = new Vector3(0, 1.5f);
        button.onClick
            .AsObservable().Skip(1)
            .Subscribe(u => Move(1f, 0));
    }
}
