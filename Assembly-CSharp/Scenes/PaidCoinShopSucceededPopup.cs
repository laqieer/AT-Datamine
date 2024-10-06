// Decompiled with JetBrains decompiler
// Type: Scenes.PaidCoinShopSucceededPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes
{
  [Token(Token = "0x20028AE")]
  public class PaidCoinShopSucceededPopup : PopupBase
  {
    [Token(Token = "0x400ADAF")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text titleText;
    [Token(Token = "0x400ADB0")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text beforePaidStoneValue;
    [Token(Token = "0x400ADB1")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text beforeFreeCommonStoneValue;
    [Token(Token = "0x400ADB2")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text afterPaidStoneValue;
    [Token(Token = "0x400ADB3")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text afterFreeCommonStoneValue;
    [Token(Token = "0x400ADB4")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;

    [Token(Token = "0x6010021")]
    [Address(RVA = "0x4165EC0", Offset = "0x4165EC0", VA = "0x4165EC0")]
    public void Init(
      string productName,
      int beforePaid,
      int beforeFreeCommon,
      int afterPaid,
      int afterFreeCommon,
      BuyConfirmStonePopup buyConfirmStonePopup,
      AssetCachedSpawner spawner,
      Action finishAction)
    {
    }

    [Token(Token = "0x6010022")]
    [Address(RVA = "0x4166244", Offset = "0x4166244", VA = "0x4166244", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x6010023")]
    [Address(RVA = "0x41662E8", Offset = "0x41662E8", VA = "0x41662E8")]
    public PaidCoinShopSucceededPopup()
    {
    }
  }
}
