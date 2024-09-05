// Decompiled with JetBrains decompiler
// Type: Scenes.BirthdayRegistrationConfirmPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes
{
  [Token(Token = "0x2002880")]
  public class BirthdayRegistrationConfirmPopup : PopupBase
  {
    [Token(Token = "0x400ACB7")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text yearMonth;
    [Token(Token = "0x400ACB8")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Color yearMonthTextColor;
    [Token(Token = "0x400ACB9")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonButton confirmButton;
    [Token(Token = "0x400ACBA")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x400ACBB")]
    [FieldOffset(Offset = "0xB0")]
    private PaidCoinShopPopup paidCoinShopPopup;
    [Token(Token = "0x400ACBC")]
    [FieldOffset(Offset = "0xB8")]
    private PaidCoinShopPopupItemInfo info;
    [Token(Token = "0x400ACBD")]
    [FieldOffset(Offset = "0xC0")]
    private BirthdayRegistrationPopup beforePopup;
    [Token(Token = "0x400ACBE")]
    [FieldOffset(Offset = "0xC8")]
    private int year;
    [Token(Token = "0x400ACBF")]
    [FieldOffset(Offset = "0xCC")]
    private int month;

    [Token(Token = "0x17003820")]
    public Action OnIfPurchaseAction
    {
      [Token(Token = "0x600FF2A"), Address(RVA = "0x40F6EAC", Offset = "0x40F6EAC", VA = "0x40F6EAC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x600FF2B"), Address(RVA = "0x40F6EB4", Offset = "0x40F6EB4", VA = "0x40F6EB4")] set
      {
      }
    }

    [Token(Token = "0x600FF2C")]
    [Address(RVA = "0x40F6EBC", Offset = "0x40F6EBC", VA = "0x40F6EBC")]
    private void Awake()
    {
    }

    [Token(Token = "0x600FF2D")]
    [Address(RVA = "0x40F6F9C", Offset = "0x40F6F9C", VA = "0x40F6F9C")]
    private void SetYM(string year, string month)
    {
    }

    [Token(Token = "0x600FF2E")]
    [Address(RVA = "0x40F71DC", Offset = "0x40F71DC", VA = "0x40F71DC")]
    public void Open(
      PaidCoinShopPopup paidCoinShopPopup,
      PaidCoinShopPopupItemInfo info,
      string year,
      string month,
      BirthdayRegistrationPopup beforePopup)
    {
    }

    [Token(Token = "0x600FF2F")]
    [Address(RVA = "0x40F72C4", Offset = "0x40F72C4", VA = "0x40F72C4")]
    public void Open(
      string year,
      string month,
      Action onIfPurchaseAction,
      BirthdayRegistrationPopup beforePopup)
    {
    }

    [Token(Token = "0x600FF30")]
    [Address(RVA = "0x40F73A0", Offset = "0x40F73A0", VA = "0x40F73A0")]
    private void OnConfirm()
    {
    }

    [Token(Token = "0x600FF31")]
    [Address(RVA = "0x40F73F0", Offset = "0x40F73F0", VA = "0x40F73F0")]
    private IEnumerator APIAge() => (IEnumerator) null;

    [Token(Token = "0x600FF32")]
    [Address(RVA = "0x40F7480", Offset = "0x40F7480", VA = "0x40F7480")]
    public BirthdayRegistrationConfirmPopup()
    {
    }
  }
}
