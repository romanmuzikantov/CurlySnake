using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewGameButton : MyButton<MainMenuHandler>
{
    public override void Awake()
    {
        base.SetUiHandler(ObjectsHandler.instance.mainMenuHandler.GetComponent<MainMenuHandler>());
        base.Awake();
    }

    public override void OnSubmit(BaseEventData eventData)
    {
        Debug.Log("New game button");
    }
}
