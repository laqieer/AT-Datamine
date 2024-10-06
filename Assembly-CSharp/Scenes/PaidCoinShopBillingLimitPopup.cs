// Decompiled with JetBrains decompiler
// Type: Scenes.PaidCoinShopBillingLimitPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes
{
  [Token(Token = "0x200288A")]
  public class PaidCoinShopBillingLimitPopup : PopupBase
  {
    [Token(Token = "0x400ACEC")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text limitText;
    [Token(Token = "0x400ACED")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text totalText;
    [Token(Token = "0x400ACEE")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text limitTextDmm;
    [Token(Token = "0x400ACEF")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text totalTextDmm;
    [Token(Token = "0x400ACF0")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject ContentsOther;
    [Token(Token = "0x400ACF1")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject ContentsDmm;

    [Token(Token = "0x17003826")]
    public Action OnCloseCallback
    {
      [Token(Token = "0x600FF5F"), Address(RVA = "0x40F9A18", Offset = "0x40F9A18", VA = "0x40F9A18")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x600FF60"), Address(RVA = "0x40F9A20", Offset = "0x40F9A20", VA = "0x40F9A20")] set
      {
      }
    }

    [Token(Token = "0x600FF61")]
    [Address(RVA = "0x40F9A28", Offset = "0x40F9A28", VA = "0x40F9A28")]
    public void Open(
      BuyConfirmStonePopup buyConfirmStonePopup,
      AssetCachedSpawner spawner,
      float limit,
      float total,
      Action finishAction = null)
    {
    }

    [Token(Token = "0x600FF62")]
    [Address(RVA = "0x40F9C88", Offset = "0x40F9C88", VA = "0x40F9C88")]
    public void Open(float limit, float total)
    {
    }

    [Token(Token = "0x600FF63")]
    [Address(RVA = "0x40F9BD0", Offset = "0x40F9BD0", VA = "0x40F9BD0")]
    private void SetText(float limit, float total)
    {
    }

    [Token(Token = "0x600FF64")]
    [Address(RVA = "0x40F9C50", Offset = "0x40F9C50", VA = "0x40F9C50")]
    private void SetActiveStoreType()
    {
    }

    [Token(Token = "0x600FF65")]
    [Address(RVA = "0x40F9DDC", Offset = "0x40F9DDC", VA = "0x40F9DDC")]
    public PaidCoinShopBillingLimitPopup()
    {
    }
  }
}
