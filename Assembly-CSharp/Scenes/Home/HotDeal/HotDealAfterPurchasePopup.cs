// Decompiled with JetBrains decompiler
// Type: Scenes.Home.HotDeal.HotDealAfterPurchasePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Home.HotDeal
{
  [Token(Token = "0x2002B0E")]
  internal class HotDealAfterPurchasePopup : PopupBase
  {
    [Token(Token = "0x400B72C")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    [Header("表示物")]
    private RectTransform parent;
    [Token(Token = "0x400B72D")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text beforePaidText;
    [Token(Token = "0x400B72E")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text afterPaidText;
    [Token(Token = "0x400B72F")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text beforeFreeText;
    [Token(Token = "0x400B730")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text afterFreeText;
    [Token(Token = "0x400B731")]
    [FieldOffset(Offset = "0xB0")]
    [Header("ボタン")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400B732")]
    [FieldOffset(Offset = "0xB8")]
    [Header("ベースImage")]
    [SerializeField]
    private Image textBoxImage;

    [Token(Token = "0x6010D3A")]
    [Address(RVA = "0x1C34B2C", Offset = "0x1C34B2C", VA = "0x1C34B2C")]
    public void BaseOn()
    {
    }

    [Token(Token = "0x6010D3B")]
    [Address(RVA = "0x1C34B74", Offset = "0x1C34B74", VA = "0x1C34B74")]
    public void SetData(
      HotDealController controller,
      int bp,
      int ap,
      int bf,
      int af,
      HotDealInfoType hotDeal,
      Action onClickClose)
    {
    }

    [Token(Token = "0x6010D3C")]
    [Address(RVA = "0x1C35104", Offset = "0x1C35104", VA = "0x1C35104")]
    public HotDealAfterPurchasePopup()
    {
    }
  }
}
