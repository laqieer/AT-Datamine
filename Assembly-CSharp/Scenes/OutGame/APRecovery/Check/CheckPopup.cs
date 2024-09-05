// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.Check.CheckPopup
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
namespace Scenes.OutGame.APRecovery.Check
{
  [Token(Token = "0x2003973")]
  public class CheckPopup : PopupBase
  {
    [Token(Token = "0x400FB05")]
    private const string AssetBundleName = "ui_page_aprecover_prefab";
    [Token(Token = "0x400FB06")]
    private const string AssetName = "Com_Popup_APRecover_Variant";
    [Token(Token = "0x400FB07")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CheckPresenter _presenter;

    [Token(Token = "0x6016943")]
    [Address(RVA = "0x42EE4A4", Offset = "0x42EE4A4", VA = "0x42EE4A4")]
    public static IEnumerator RequestAsync(
      AssetCachedSpawner assetCachedSpawner,
      ApRecoveryModel apRecoveryModel,
      Action<CheckPopup> callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x17004A5A")]
    public Action OnRecoverySuccess
    {
      [Token(Token = "0x6016944"), Address(RVA = "0x42F0594", Offset = "0x42F0594", VA = "0x42F0594")] set
      {
      }
    }

    [Token(Token = "0x17004A5B")]
    public Action OnRecoveryError
    {
      [Token(Token = "0x6016945"), Address(RVA = "0x42F05B0", Offset = "0x42F05B0", VA = "0x42F05B0")] set
      {
      }
    }

    [Token(Token = "0x17004A5C")]
    public Action<string> OnMessage
    {
      [Token(Token = "0x6016946"), Address(RVA = "0x42EE270", Offset = "0x42EE270", VA = "0x42EE270")] set
      {
      }
    }

    [Token(Token = "0x17004A5D")]
    public Action Closure
    {
      [Token(Token = "0x6016947"), Address(RVA = "0x42F1B34", Offset = "0x42F1B34", VA = "0x42F1B34")] set
      {
      }
    }

    [Token(Token = "0x17004A5E")]
    public Action ClosureChain
    {
      [Token(Token = "0x6016948"), Address(RVA = "0x42F05CC", Offset = "0x42F05CC", VA = "0x42F05CC")] set
      {
      }
    }

    [Token(Token = "0x17004A5F")]
    public Action OnClose
    {
      [Token(Token = "0x6016949"), Address(RVA = "0x42EE28C", Offset = "0x42EE28C", VA = "0x42EE28C")] set
      {
      }
    }

    [Token(Token = "0x17004A60")]
    public Action OnSuccessPurchase
    {
      [Token(Token = "0x601694A"), Address(RVA = "0x42F05E8", Offset = "0x42F05E8", VA = "0x42F05E8")] set
      {
      }
    }

    [Token(Token = "0x601694B")]
    [Address(RVA = "0x42F1B50", Offset = "0x42F1B50", VA = "0x42F1B50")]
    public void Initialize(ApRecoveryModel apRecoveryModel)
    {
    }

    [Token(Token = "0x601694C")]
    [Address(RVA = "0x42F1D08", Offset = "0x42F1D08", VA = "0x42F1D08")]
    public void InitializeAndOpen(ApRecoveryModel apRecoveryModel)
    {
    }

    [Token(Token = "0x601694D")]
    [Address(RVA = "0x42F1E74", Offset = "0x42F1E74", VA = "0x42F1E74")]
    public CheckPopup()
    {
    }
  }
}
