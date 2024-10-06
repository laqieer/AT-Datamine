// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.ApRecoveryPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.APRecovery
{
  [Token(Token = "0x200395C")]
  public class ApRecoveryPopup : PopupBase
  {
    [Token(Token = "0x400FAAD")]
    private const string AssetBundleName = "ui_page_aprecover_prefab";
    [Token(Token = "0x400FAAE")]
    private const string AssetName = "Container_APRecover_Popup";
    [Token(Token = "0x400FAAF")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ApRecoveryPresenter _presenter;
    [Token(Token = "0x400FAB0")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Transform _contentTrans;

    [Token(Token = "0x60168B8")]
    [Address(RVA = "0x42EE86C", Offset = "0x42EE86C", VA = "0x42EE86C")]
    public static IEnumerator RequestAsync(
      AssetCachedSpawner assetCachedSpawner,
      Action<string> onMessage = null,
      Action<ApRecoveryPopup> callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x17004A2E")]
    public Action OnRecoverySuccess
    {
      [Token(Token = "0x60168B9"), Address(RVA = "0x42ECA8C", Offset = "0x42ECA8C", VA = "0x42ECA8C")] set
      {
      }
    }

    [Token(Token = "0x17004A2F")]
    public Action OnRecoveryError
    {
      [Token(Token = "0x60168BA"), Address(RVA = "0x42ECAA8", Offset = "0x42ECAA8", VA = "0x42ECAA8")] set
      {
      }
    }

    [Token(Token = "0x17004A30")]
    public Action<string> OnMessage
    {
      [Token(Token = "0x60168BB"), Address(RVA = "0x42EE910", Offset = "0x42EE910", VA = "0x42EE910")] set
      {
      }
    }

    [Token(Token = "0x17004A31")]
    public Action OnSuccessPurchase
    {
      [Token(Token = "0x60168BC"), Address(RVA = "0x42ECAC4", Offset = "0x42ECAC4", VA = "0x42ECAC4")] set
      {
      }
    }

    [Token(Token = "0x60168BD")]
    [Address(RVA = "0x42EE950", Offset = "0x42EE950", VA = "0x42EE950")]
    public void Initialize(Action<string> onMessage = null)
    {
    }

    [Token(Token = "0x60168BE")]
    [Address(RVA = "0x42EEE3C", Offset = "0x42EEE3C", VA = "0x42EEE3C")]
    public void InitializeAndOpen(Action<string> onMessage = null)
    {
    }

    [Token(Token = "0x60168BF")]
    [Address(RVA = "0x42EEFCC", Offset = "0x42EEFCC", VA = "0x42EEFCC")]
    public void SetPosition(Transform transform)
    {
    }

    [Token(Token = "0x60168C0")]
    [Address(RVA = "0x42EF074", Offset = "0x42EF074", VA = "0x42EF074")]
    public void SetPosition(in Vector3 pos)
    {
    }

    [Token(Token = "0x60168C1")]
    [Address(RVA = "0x42EF150", Offset = "0x42EF150", VA = "0x42EF150")]
    public void ShiftContentTo(in Vector2 offset)
    {
    }

    [Token(Token = "0x60168C2")]
    [Address(RVA = "0x42EF1CC", Offset = "0x42EF1CC", VA = "0x42EF1CC")]
    public ApRecoveryPopup()
    {
    }
  }
}
