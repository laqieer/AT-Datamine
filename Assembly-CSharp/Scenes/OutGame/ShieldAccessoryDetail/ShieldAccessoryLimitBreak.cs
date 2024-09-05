// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ShieldAccessoryDetail.ShieldAccessoryLimitBreak
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using UI.Common;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.ShieldAccessoryDetail
{
  [Token(Token = "0x200339C")]
  public class ShieldAccessoryLimitBreak : MonoBehaviour
  {
    [Token(Token = "0x400E021")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private LimitBreakIcons iconBefore;
    [Token(Token = "0x400E022")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private LimitBreakIcons iconAfter;
    [Token(Token = "0x400E023")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform needMaterialTrans;
    [Token(Token = "0x400E024")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400E025")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton defaultButton;
    [Token(Token = "0x400E026")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton minusButton;
    [Token(Token = "0x400E027")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton plusButton;
    [Token(Token = "0x400E028")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton maxButton;
    [Token(Token = "0x400E029")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton limitBreakButton;
    [Token(Token = "0x400E02A")]
    [FieldOffset(Offset = "0x60")]
    private ShieldAccessoryDetailSubScene ShieldAccessoryDetailSubScene;
    [Token(Token = "0x400E02B")]
    [FieldOffset(Offset = "0x68")]
    private Accessory dispShieldAccessory;
    [Token(Token = "0x400E02C")]
    [FieldOffset(Offset = "0x70")]
    private int limitBreakNum;
    [Token(Token = "0x400E02D")]
    [FieldOffset(Offset = "0x74")]
    private int limitBreakNumMax;
    [Token(Token = "0x400E02E")]
    [FieldOffset(Offset = "0x78")]
    private bool isEnoughCost;
    [Token(Token = "0x400E02F")]
    [FieldOffset(Offset = "0x79")]
    private bool isConnect;
    [Token(Token = "0x400E030")]
    [FieldOffset(Offset = "0x80")]
    private ItemIcon materialItemIcon;
    [Token(Token = "0x400E031")]
    [FieldOffset(Offset = "0x88")]
    private ItemDetailPopupProvider itemDetailPopupProvider;

    [Token(Token = "0x170043AC")]
    private AssetCachedSpawner assetCachedSpawner
    {
      [Token(Token = "0x60144B2"), Address(RVA = "0x2068BE0", Offset = "0x2068BE0", VA = "0x2068BE0")] get
      {
        return (AssetCachedSpawner) null;
      }
    }

    [Token(Token = "0x60144B3")]
    [Address(RVA = "0x2066DD0", Offset = "0x2066DD0", VA = "0x2066DD0")]
    public static void Preload(AssetCachedSpawner assetCachedSpawner, Accessory shieldAccessory)
    {
    }

    [Token(Token = "0x60144B4")]
    [Address(RVA = "0x20646B4", Offset = "0x20646B4", VA = "0x20646B4")]
    public void Initialize(ShieldAccessoryDetailSubScene statusSubScene)
    {
    }

    [Token(Token = "0x60144B5")]
    [Address(RVA = "0x2068C04", Offset = "0x2068C04", VA = "0x2068C04")]
    private int CalcMaxNumCanLimitBreak() => new int();

    [Token(Token = "0x60144B6")]
    [Address(RVA = "0x2068C84", Offset = "0x2068C84", VA = "0x2068C84")]
    private void SetSideMenu()
    {
    }

    [Token(Token = "0x60144B7")]
    [Address(RVA = "0x2069024", Offset = "0x2069024", VA = "0x2069024")]
    private void OnClickPrevNext()
    {
    }

    [Token(Token = "0x60144B8")]
    [Address(RVA = "0x2069004", Offset = "0x2069004", VA = "0x2069004")]
    private bool IsEnabledLimitBreakButton() => new bool();

    [Token(Token = "0x60144B9")]
    [Address(RVA = "0x2068E60", Offset = "0x2068E60", VA = "0x2068E60")]
    private void SetMaterialIcon(ItemTypeEnum itemTypeEnum, int id, int amount, int needAmount)
    {
    }

    [Token(Token = "0x60144BA")]
    [Address(RVA = "0x2069108", Offset = "0x2069108", VA = "0x2069108")]
    private void SetMaterialIconImage(
      ItemTypeEnum itemTypeEnum,
      int id,
      int amount,
      int needAmount)
    {
    }

    [Token(Token = "0x60144BB")]
    [Address(RVA = "0x2068D58", Offset = "0x2068D58", VA = "0x2068D58")]
    private void SetButtonStatus()
    {
    }

    [Token(Token = "0x60144BC")]
    [Address(RVA = "0x20692B0", Offset = "0x20692B0", VA = "0x20692B0")]
    private IEnumerator ConnectToApi(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x60144BD")]
    [Address(RVA = "0x206934C", Offset = "0x206934C", VA = "0x206934C")]
    private IEnumerator EffectLimitBreak() => (IEnumerator) null;

    [Token(Token = "0x60144BE")]
    [Address(RVA = "0x20693DC", Offset = "0x20693DC", VA = "0x20693DC")]
    private void FinishEffectAction()
    {
    }

    [Token(Token = "0x60144BF")]
    [Address(RVA = "0x20694D0", Offset = "0x20694D0", VA = "0x20694D0")]
    private void UpdateItemParameter()
    {
    }

    [Token(Token = "0x60144C0")]
    [Address(RVA = "0x20694E8", Offset = "0x20694E8", VA = "0x20694E8")]
    public ShieldAccessoryLimitBreak()
    {
    }
  }
}
