//日本語コメント可
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class ObjectToUISerectBase : MonoBehaviour
{
    /// <summary>
    /// ボタンの入力があった時に呼ぶ関数
    /// </summary>
    protected abstract void BehaviourOfObject();
    protected abstract void SelectionBehavior();
    protected abstract void NonSelectionBehavior();

    public void StateSpesificBehaviour(ButtonState buttonState)
    {
        switch (buttonState)
        {
            case ButtonState.SELECTED:
                SelectionBehavior();
                break;
            case ButtonState.DISIDED:
                BehaviourOfObject();
                break;
            default:
                NonSelectionBehavior();
                break;
        }
    }
}

/// <summary>
/// ボタンのステート
/// </summary>
public enum ButtonState : int
{
    NONE, //通常
    SELECTED, //選択中
    DISIDED //決定済み
}
