using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class ClickButton : Base
{
    public Button button;
    void Start()
    {
        gameObject.transform.position = new Vector3(0, 1f);
        button.onClick
            .AsObservable().First()
            .Subscribe(l => Move(1f, 0));
    }
}
