// Decompiled with JetBrains decompiler
// Type: Scenes.PaidCoinShopParentConfirmationPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using PurchaseModule.Product;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes
{
  [Token(Token = "0x200288E")]
  public class PaidCoinShopParentConfirmationPopup : PopupBase
  {
    [Token(Token = "0x400AD05")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text price;
    [Token(Token = "0x400AD06")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject txtCaution1;
    [Token(Token = "0x400AD07")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject txtCaution1Dmm;
    [Token(Token = "0x400AD08")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject AgeLimit;
    [Token(Token = "0x400AD09")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject AgeLimitDmm;
    [Token(Token = "0x400AD0A")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x400AD0B")]
    [FieldOffset(Offset = "0xB8")]
    private BuyConfirmStonePopup buyConfirmStonePopup;
    [Token(Token = "0x400AD0C")]
    [FieldOffset(Offset = "0xC0")]
    private AssetCachedSpawner spawner;

    [Token(Token = "0x17003827")]
    public Action OnClickToCancelAction
    {
      [Token(Token = "0x600FF76"), Address(RVA = "0x40FAAC8", Offset = "0x40FAAC8", VA = "0x40FAAC8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x600FF77"), Address(RVA = "0x40FAAD0", Offset = "0x40FAAD0", VA = "0x40FAAD0")] set
      {
      }
    }

    [Token(Token = "0x600FF78")]
    [Address(RVA = "0x40FAAD8", Offset = "0x40FAAD8", VA = "0x40FAAD8")]
    private void Awake()
    {
    }

    [Token(Token = "0x600FF79")]
    [Address(RVA = "0x40FAB6C", Offset = "0x40FAB6C", VA = "0x40FAB6C")]
    public void Open(
      PaidCoinShopPopup paidCoinShopPopup,
      PaidCoinShopPopupItemInfo info,
      BuyConfirmStonePopup buyConfirmStonePopup,
      Action finishAction)
    {
    }

    [Token(Token = "0x600FF7A")]
    [Address(RVA = "0x40FAD80", Offset = "0x40FAD80", VA = "0x40FAD80")]
    public void Open(
      ProductInfo productInfo,
      AssetCachedSpawner spawner,
      Action<ProductInfo> onConfirm)
    {
    }

    [Token(Token = "0x600FF7B")]
    [Address(RVA = "0x40FAD20", Offset = "0x40FAD20", VA = "0x40FAD20")]
    private void SetActiveStoreType()
    {
    }

    [Token(Token = "0x600FF7C")]
    [Address(RVA = "0x40FAF54", Offset = "0x40FAF54", VA = "0x40FAF54")]
    private void OnConfirm(PaidCoinShopPopup paidCoinShopPopup, PaidCoinShopPopupItemInfo info)
    {
    }

    [Token(Token = "0x600FF7D")]
    [Address(RVA = "0x40FB044", Offset = "0x40FB044", VA = "0x40FB044")]
    private void OnCancel()
    {
    }

    [Token(Token = "0x600FF7E")]
    [Address(RVA = "0x40FB14C", Offset = "0x40FB14C", VA = "0x40FB14C")]
    public PaidCoinShopParentConfirmationPopup()
    {
    }
  }
}
