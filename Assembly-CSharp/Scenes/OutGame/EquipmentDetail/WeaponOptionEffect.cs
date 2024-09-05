// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.WeaponOptionEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036B6")]
  public class WeaponOptionEffect : MonoBehaviour
  {
    [Token(Token = "0x400EE58")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private WeaponOptionEffectContainer[] weaponOptionEffectContainers;
    [Token(Token = "0x400EE59")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400EE5A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform needMaterialTrans;
    [Token(Token = "0x400EE5B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text LotteryFrameNum;
    [Token(Token = "0x400EE5C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton defaultButton;
    [Token(Token = "0x400EE5D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton minusButton;
    [Token(Token = "0x400EE5E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton plusButton;
    [Token(Token = "0x400EE5F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton maxButton;
    [Token(Token = "0x400EE60")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton probabilityButton;
    [Token(Token = "0x400EE61")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton changeButton;
    [Token(Token = "0x400EE62")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Transform popupTrans;
    [Token(Token = "0x400EE63")]
    [FieldOffset(Offset = "0x70")]
    private WeaponDetailSubScene weaponDetailSubScene;
    [Token(Token = "0x400EE64")]
    [FieldOffset(Offset = "0x78")]
    private Weapon dispWeapon;
    [Token(Token = "0x400EE65")]
    private const int lotteryMin = 1;
    [Token(Token = "0x400EE66")]
    private const int lotteryMax = 10;
    [Token(Token = "0x400EE67")]
    [FieldOffset(Offset = "0x80")]
    private int lotteryNum;
    [Token(Token = "0x400EE68")]
    [FieldOffset(Offset = "0x84")]
    private bool isConnectApi;
    [Token(Token = "0x400EE69")]
    [FieldOffset(Offset = "0x88")]
    private int candidatesNum;
    [Token(Token = "0x400EE6A")]
    [FieldOffset(Offset = "0x90")]
    private List<PlayerGearOptionCandidateType> playerGearOptionCandidateType;
    [Token(Token = "0x400EE6B")]
    [FieldOffset(Offset = "0x98")]
    private ItemIcon materialItemIcon;
    [Token(Token = "0x400EE6C")]
    [FieldOffset(Offset = "0xA0")]
    private bool isEnoughCost;
    [Token(Token = "0x400EE6D")]
    [FieldOffset(Offset = "0xA8")]
    private ItemDetailPopupProvider itemDetailPopupProvider;
    [Token(Token = "0x400EE6E")]
    [FieldOffset(Offset = "0xB0")]
    private OptionEffectLotteryListPopup optionEffectLotteryListPopup;

    [Token(Token = "0x6015896")]
    [Address(RVA = "0x1A5C8E8", Offset = "0x1A5C8E8", VA = "0x1A5C8E8")]
    public static void Preload(AssetCachedSpawner assetCachedSpawner, Weapon weapon)
    {
    }

    [Token(Token = "0x6015897")]
    [Address(RVA = "0x1A597BC", Offset = "0x1A597BC", VA = "0x1A597BC")]
    public void Initialize(WeaponDetailSubScene statusSubScene, Weapon weapon)
    {
    }

    [Token(Token = "0x6015898")]
    [Address(RVA = "0x1A5AF48", Offset = "0x1A5AF48", VA = "0x1A5AF48")]
    public void SuspendResume(PlayerWeaponOptionChangePending pending)
    {
    }

    [Token(Token = "0x6015899")]
    [Address(RVA = "0x1A5FE08", Offset = "0x1A5FE08", VA = "0x1A5FE08")]
    private void SetSideMenu()
    {
    }

    [Token(Token = "0x601589A")]
    [Address(RVA = "0x1A5FD2C", Offset = "0x1A5FD2C", VA = "0x1A5FD2C")]
    private void setEffect()
    {
    }

    [Token(Token = "0x601589B")]
    [Address(RVA = "0x1A6020C", Offset = "0x1A6020C", VA = "0x1A6020C")]
    private int CalcNeedAmount(int lotteryNum) => new int();

    [Token(Token = "0x601589C")]
    [Address(RVA = "0x1A60328", Offset = "0x1A60328", VA = "0x1A60328")]
    private void SetMaterialIcon(ItemTypeEnum itemTypeEnum, int id, int amount, int needAmount)
    {
    }

    [Token(Token = "0x601589D")]
    [Address(RVA = "0x1A604BC", Offset = "0x1A604BC", VA = "0x1A604BC")]
    private void SetMaterialIconImage(
      ItemTypeEnum itemTypeEnum,
      int id,
      int amount,
      int needAmount)
    {
    }

    [Token(Token = "0x601589E")]
    [Address(RVA = "0x1A5FF68", Offset = "0x1A5FF68", VA = "0x1A5FF68")]
    private void SetButtonStatus()
    {
    }

    [Token(Token = "0x601589F")]
    [Address(RVA = "0x1A60664", Offset = "0x1A60664", VA = "0x1A60664")]
    private IEnumerator ConnectApi() => (IEnumerator) null;

    [Token(Token = "0x60158A0")]
    [Address(RVA = "0x1A606F4", Offset = "0x1A606F4", VA = "0x1A606F4")]
    private IEnumerator EffectLevelUP() => (IEnumerator) null;

    [Token(Token = "0x60158A1")]
    [Address(RVA = "0x1A60038", Offset = "0x1A60038", VA = "0x1A60038")]
    private void RequestConfirmation()
    {
    }

    [Token(Token = "0x60158A2")]
    [Address(RVA = "0x1A60BC0", Offset = "0x1A60BC0", VA = "0x1A60BC0")]
    private void UpdateItemParameter()
    {
    }

    [Token(Token = "0x60158A3")]
    [Address(RVA = "0x1A60BD8", Offset = "0x1A60BD8", VA = "0x1A60BD8")]
    public WeaponOptionEffect()
    {
    }
  }
}
