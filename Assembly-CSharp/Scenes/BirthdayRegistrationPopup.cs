// Decompiled with JetBrains decompiler
// Type: Scenes.BirthdayRegistrationPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes
{
  [Token(Token = "0x2002882")]
  public class BirthdayRegistrationPopup : PopupBase
  {
    [Token(Token = "0x400ACC4")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TMP_InputField inputYear;
    [Token(Token = "0x400ACC5")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TMP_InputField inputMonth;
    [Token(Token = "0x400ACC6")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject txtCaution002;
    [Token(Token = "0x400ACC7")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject txtCaution002Dmm;
    [Token(Token = "0x400ACC8")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject AgeLimit;
    [Token(Token = "0x400ACC9")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject AgeLimitDmm;
    [Token(Token = "0x400ACCA")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Color invalidInputTextColor;
    [Token(Token = "0x400ACCB")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private CommonButton confirmButton;
    [Token(Token = "0x400ACCC")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x400ACCD")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400ACCE")]
    [FieldOffset(Offset = "0xE0")]
    private BuyConfirmStonePopup buyConfirmStonePopup;
    [Token(Token = "0x400ACCF")]
    [FieldOffset(Offset = "0xE8")]
    private PaidCoinShopPopup paidCoinShopPopup;
    [Token(Token = "0x400ACD0")]
    [FieldOffset(Offset = "0xF0")]
    private PaidCoinShopPopupItemInfo info;
    [Token(Token = "0x400ACD1")]
    [FieldOffset(Offset = "0xF8")]
    private Color defaultInputTextColor;
    [Token(Token = "0x400ACD2")]
    [FieldOffset(Offset = "0x108")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x400ACD3")]
    [FieldOffset(Offset = "0x110")]
    private bool isClick;

    [Token(Token = "0x17003823")]
    public Action OnIfPurchaseAction
    {
      [Token(Token = "0x600FF3A"), Address(RVA = "0x40F794C", Offset = "0x40F794C", VA = "0x40F794C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x600FF3B"), Address(RVA = "0x40F7954", Offset = "0x40F7954", VA = "0x40F7954")] set
      {
      }
    }

    [Token(Token = "0x17003824")]
    public Action OnCancelCallback
    {
      [Token(Token = "0x600FF3C"), Address(RVA = "0x40F795C", Offset = "0x40F795C", VA = "0x40F795C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x600FF3D"), Address(RVA = "0x40F7964", Offset = "0x40F7964", VA = "0x40F7964")] set
      {
      }
    }

    [Token(Token = "0x600FF3E")]
    [Address(RVA = "0x40F796C", Offset = "0x40F796C", VA = "0x40F796C")]
    private void Awake()
    {
    }

    [Token(Token = "0x600FF3F")]
    [Address(RVA = "0x40F7B98", Offset = "0x40F7B98", VA = "0x40F7B98")]
    public void Open(
      AssetCachedSpawner spawner,
      PaidCoinShopPopup paidCoinShopPopup,
      PaidCoinShopPopupItemInfo info)
    {
    }

    [Token(Token = "0x600FF40")]
    [Address(RVA = "0x40F7CC8", Offset = "0x40F7CC8", VA = "0x40F7CC8")]
    public void Open(AssetCachedSpawner spawner, Action onIfPurchaseAction)
    {
    }

    [Token(Token = "0x600FF41")]
    [Address(RVA = "0x40F7C68", Offset = "0x40F7C68", VA = "0x40F7C68")]
    private void SetActiveStoreType()
    {
    }

    [Token(Token = "0x600FF42")]
    [Address(RVA = "0x40F7D8C", Offset = "0x40F7D8C", VA = "0x40F7D8C", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x600FF43")]
    [Address(RVA = "0x40F7E3C", Offset = "0x40F7E3C", VA = "0x40F7E3C")]
    private void OnConfirm()
    {
    }

    [Token(Token = "0x600FF44")]
    [Address(RVA = "0x40F80F8", Offset = "0x40F80F8", VA = "0x40F80F8")]
    private bool CheckInput() => new bool();

    [Token(Token = "0x600FF45")]
    [Address(RVA = "0x40F8390", Offset = "0x40F8390", VA = "0x40F8390")]
    public BirthdayRegistrationPopup()
    {
    }
  }
}
