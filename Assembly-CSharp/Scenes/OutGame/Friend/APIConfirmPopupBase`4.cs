// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Friend.APIConfirmPopupBase`4
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Friend
{
  [Token(Token = "0x20035F6")]
  public abstract class APIConfirmPopupBase<TPopup, TAPI, TRequest, TResponse> : MonoBehaviour
    where TPopup : APIConfirmPopupBase<TPopup, TAPI, TRequest, TResponse>
    where TRequest : class, new()
  {
    [Token(Token = "0x400EAAA")]
    [FieldOffset(Offset = "0x0")]
    protected TRequest requestParameter;
    [Token(Token = "0x400EAAB")]
    [FieldOffset(Offset = "0x0")]
    protected Action<TResponse> onSuccess;
    [Token(Token = "0x400EAAC")]
    [FieldOffset(Offset = "0x0")]
    protected Action onFailure;
    [Token(Token = "0x400EAAD")]
    [FieldOffset(Offset = "0x0")]
    protected Action onCancel;
    [Token(Token = "0x400EAAE")]
    [FieldOffset(Offset = "0x0")]
    protected ConfirmationPopup popupInstance;
    [Token(Token = "0x400EAAF")]
    [FieldOffset(Offset = "0x0")]
    private CanvasGroup canvasGroup;

    [Token(Token = "0x60153D2")]
    public static void Open(
      TRequest requestParameter,
      Action<TResponse> onSuccess,
      Action onFailure,
      Action onCancel,
      APIConfirmPopupParameter parameter = null)
    {
    }

    [Token(Token = "0x60153D3")]
    public static void Open(
      string popupAssetBundleName,
      string popupAssetName,
      TRequest requestParameter,
      Action<TResponse> onSuccess,
      Action onFailure,
      Action onCancel,
      APIConfirmPopupParameter parameter = null)
    {
    }

    [Token(Token = "0x60153D4")]
    protected abstract void OnCreate(APIConfirmPopupParameter parameter = null);

    [Token(Token = "0x60153D5")]
    protected void SetData(string title, string message)
    {
    }

    [Token(Token = "0x60153D6")]
    protected void Close()
    {
    }

    [Token(Token = "0x60153D7")]
    private void OnClickDecision()
    {
    }

    [Token(Token = "0x60153D8")]
    private void OnClickCancel()
    {
    }

    [Token(Token = "0x60153D9")]
    private void DisbleInteractable()
    {
    }

    [Token(Token = "0x60153DA")]
    protected abstract IEnumerator SendRequest();

    [Token(Token = "0x60153DB")]
    protected APIConfirmPopupBase()
    {
    }
  }
}
