// Decompiled with JetBrains decompiler
// Type: Scenes.PaidCoinShopConfirmPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes
{
  [Token(Token = "0x200288D")]
  public class PaidCoinShopConfirmPopup : PopupBase
  {
    [Token(Token = "0x400ACF7")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text itemName;
    [Token(Token = "0x400ACF8")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private LimitLeftLabel limitLeftLabel;
    [Token(Token = "0x400ACF9")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text allStoneValue;
    [Token(Token = "0x400ACFA")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text paidGetCount;
    [Token(Token = "0x400ACFB")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject freeGroup;
    [Token(Token = "0x400ACFC")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text freeCommonGetCount;
    [Token(Token = "0x400ACFD")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text price;
    [Token(Token = "0x400ACFE")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private CommonButton confirmButton;
    [Token(Token = "0x400ACFF")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x400AD00")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400AD01")]
    [FieldOffset(Offset = "0xD8")]
    private BuyConfirmStonePopup buyConfirmStonePopup;
    [Token(Token = "0x400AD02")]
    [FieldOffset(Offset = "0xE0")]
    private PaidCoinShopPopup paidCoinShopPopup;
    [Token(Token = "0x400AD03")]
    [FieldOffset(Offset = "0xE8")]
    private PaidCoinShopPopupItemInfo info;
    [Token(Token = "0x400AD04")]
    [FieldOffset(Offset = "0xF0")]
    private AssetCachedSpawner spawner;

    [Token(Token = "0x600FF6D")]
    [Address(RVA = "0x40FA358", Offset = "0x40FA358", VA = "0x40FA358")]
    private void Awake()
    {
    }

    [Token(Token = "0x600FF6E")]
    [Address(RVA = "0x40FA4FC", Offset = "0x40FA4FC", VA = "0x40FA4FC")]
    public void Open(
      AssetCachedSpawner spawner,
      PaidCoinShopPopup paidCoinShopPopup,
      PaidCoinShopPopupItemInfo info)
    {
    }

    [Token(Token = "0x600FF6F")]
    [Address(RVA = "0x40FA70C", Offset = "0x40FA70C", VA = "0x40FA70C", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x600FF70")]
    [Address(RVA = "0x40F78A4", Offset = "0x40F78A4", VA = "0x40F78A4")]
    public void FalseButtonInteractable()
    {
    }

    [Token(Token = "0x600FF71")]
    [Address(RVA = "0x40FA79C", Offset = "0x40FA79C", VA = "0x40FA79C")]
    public void TrueButtonInteractable()
    {
    }

    [Token(Token = "0x600FF72")]
    [Address(RVA = "0x40FA7D4", Offset = "0x40FA7D4", VA = "0x40FA7D4")]
    private void OnConfirm()
    {
    }

    [Token(Token = "0x600FF73")]
    [Address(RVA = "0x40FA98C", Offset = "0x40FA98C", VA = "0x40FA98C")]
    public PaidCoinShopConfirmPopup()
    {
    }
  }
}
