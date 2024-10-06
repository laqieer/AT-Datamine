// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ShieldAccessoryDetail.ShieldAccessoryOptionEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.EquipmentDetail;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.ShieldAccessoryDetail
{
  [Token(Token = "0x20033A3")]
  public class ShieldAccessoryOptionEffect : MonoBehaviour
  {
    [Token(Token = "0x400E047")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private WeaponOptionEffectContainer[] accessoryOptionEffectContainers;
    [Token(Token = "0x400E048")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400E049")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform needMaterialTrans;
    [Token(Token = "0x400E04A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text LotteryFrameNum;
    [Token(Token = "0x400E04B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton defaultButton;
    [Token(Token = "0x400E04C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton minusButton;
    [Token(Token = "0x400E04D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton plusButton;
    [Token(Token = "0x400E04E")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton maxButton;
    [Token(Token = "0x400E04F")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton probabilityButton;
    [Token(Token = "0x400E050")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton changeButton;
    [Token(Token = "0x400E051")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Transform popupTrans;
    [Token(Token = "0x400E052")]
    [FieldOffset(Offset = "0x70")]
    private ShieldAccessoryDetailSubScene accessoryDetailSubScene;
    [Token(Token = "0x400E053")]
    [FieldOffset(Offset = "0x78")]
    private Accessory dispAccessory;
    [Token(Token = "0x400E054")]
    private const int lotteryMin = 1;
    [Token(Token = "0x400E055")]
    private const int lotteryMax = 10;
    [Token(Token = "0x400E056")]
    [FieldOffset(Offset = "0x80")]
    private int lotteryNum;
    [Token(Token = "0x400E057")]
    [FieldOffset(Offset = "0x84")]
    private bool isConnectApi;
    [Token(Token = "0x400E058")]
    [FieldOffset(Offset = "0x88")]
    private int candidatesNum;
    [Token(Token = "0x400E059")]
    [FieldOffset(Offset = "0x90")]
    private List<PlayerGearOptionCandidateType> playerGearOptionCandidateType;
    [Token(Token = "0x400E05A")]
    [FieldOffset(Offset = "0x98")]
    private ItemIcon materialItemIcon;
    [Token(Token = "0x400E05B")]
    [FieldOffset(Offset = "0xA0")]
    private bool isEnoughCost;
    [Token(Token = "0x400E05C")]
    [FieldOffset(Offset = "0xA8")]
    private ItemDetailPopupProvider itemDetailPopupProvider;
    [Token(Token = "0x400E05D")]
    [FieldOffset(Offset = "0xB0")]
    private OptionEffectLotteryListPopup optionEffectLotteryListPopup;

    [Token(Token = "0x60144DB")]
    [Address(RVA = "0x2066ED4", Offset = "0x2066ED4", VA = "0x2066ED4")]
    public static void Preload(AssetCachedSpawner assetCachedSpawner, Accessory shieldAccessory)
    {
    }

    [Token(Token = "0x60144DC")]
    [Address(RVA = "0x2063F44", Offset = "0x2063F44", VA = "0x2063F44")]
    public void Initialize(ShieldAccessoryDetailSubScene statusSubScene, Accessory accessory)
    {
    }

    [Token(Token = "0x60144DD")]
    [Address(RVA = "0x2065658", Offset = "0x2065658", VA = "0x2065658")]
    public void SuspendResume(PlayerAccessoriesOptionChangePending pending)
    {
    }

    [Token(Token = "0x60144DE")]
    [Address(RVA = "0x2069FA4", Offset = "0x2069FA4", VA = "0x2069FA4")]
    private void SetSideMenu()
    {
    }

    [Token(Token = "0x60144DF")]
    [Address(RVA = "0x2069EC0", Offset = "0x2069EC0", VA = "0x2069EC0")]
    private void setEffect()
    {
    }

    [Token(Token = "0x60144E0")]
    [Address(RVA = "0x206A3A8", Offset = "0x206A3A8", VA = "0x206A3A8")]
    private int CalcNeedAmount(int lotteryNum) => new int();

    [Token(Token = "0x60144E1")]
    [Address(RVA = "0x206A534", Offset = "0x206A534", VA = "0x206A534")]
    private void SetMaterialIcon(ItemTypeEnum itemTypeEnum, int id, int amount, int needAmount)
    {
    }

    [Token(Token = "0x60144E2")]
    [Address(RVA = "0x206A6C8", Offset = "0x206A6C8", VA = "0x206A6C8")]
    private void SetMaterialIconImage(
      ItemTypeEnum itemTypeEnum,
      int id,
      int amount,
      int needAmount)
    {
    }

    [Token(Token = "0x60144E3")]
    [Address(RVA = "0x206A104", Offset = "0x206A104", VA = "0x206A104")]
    private void SetButtonStatus()
    {
    }

    [Token(Token = "0x60144E4")]
    [Address(RVA = "0x206A870", Offset = "0x206A870", VA = "0x206A870")]
    private IEnumerator ConnectApi() => (IEnumerator) null;

    [Token(Token = "0x60144E5")]
    [Address(RVA = "0x206A900", Offset = "0x206A900", VA = "0x206A900")]
    private IEnumerator EffectLevelUP() => (IEnumerator) null;

    [Token(Token = "0x60144E6")]
    [Address(RVA = "0x206A1D4", Offset = "0x206A1D4", VA = "0x206A1D4")]
    private void RequestConfirmation()
    {
    }

    [Token(Token = "0x60144E7")]
    [Address(RVA = "0x206ADD0", Offset = "0x206ADD0", VA = "0x206ADD0")]
    private void UpdateItemParameter()
    {
    }

    [Token(Token = "0x60144E8")]
    [Address(RVA = "0x206ADE8", Offset = "0x206ADE8", VA = "0x206ADE8")]
    public ShieldAccessoryOptionEffect()
    {
    }
  }
}
