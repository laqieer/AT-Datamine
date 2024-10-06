// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.WeaponLimitBreak
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
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036AF")]
  public class WeaponLimitBreak : MonoBehaviour
  {
    [Token(Token = "0x400EE32")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private LimitBreakIcons iconBefore;
    [Token(Token = "0x400EE33")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private LimitBreakIcons iconAfter;
    [Token(Token = "0x400EE34")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform needMaterialTrans;
    [Token(Token = "0x400EE35")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400EE36")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton defaultButton;
    [Token(Token = "0x400EE37")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton minusButton;
    [Token(Token = "0x400EE38")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton plusButton;
    [Token(Token = "0x400EE39")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton maxButton;
    [Token(Token = "0x400EE3A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton limitBreakButton;
    [Token(Token = "0x400EE3B")]
    [FieldOffset(Offset = "0x60")]
    private WeaponDetailSubScene weaponDetailSubScene;
    [Token(Token = "0x400EE3C")]
    [FieldOffset(Offset = "0x68")]
    private Weapon dispWeapon;
    [Token(Token = "0x400EE3D")]
    [FieldOffset(Offset = "0x70")]
    private int limitBreakNum;
    [Token(Token = "0x400EE3E")]
    [FieldOffset(Offset = "0x74")]
    private int limitBreakNumMax;
    [Token(Token = "0x400EE3F")]
    [FieldOffset(Offset = "0x78")]
    private bool isEnoughCost;
    [Token(Token = "0x400EE40")]
    [FieldOffset(Offset = "0x79")]
    private bool isConnect;
    [Token(Token = "0x400EE41")]
    [FieldOffset(Offset = "0x80")]
    private ItemIcon materialItemIcon;
    [Token(Token = "0x400EE42")]
    [FieldOffset(Offset = "0x88")]
    private ItemDetailPopupProvider itemDetailPopupProvider;

    [Token(Token = "0x17004755")]
    private AssetCachedSpawner assetCachedSpawner
    {
      [Token(Token = "0x601586D"), Address(RVA = "0x1A5EA4C", Offset = "0x1A5EA4C", VA = "0x1A5EA4C")] get
      {
        return (AssetCachedSpawner) null;
      }
    }

    [Token(Token = "0x601586E")]
    [Address(RVA = "0x1A5C7E4", Offset = "0x1A5C7E4", VA = "0x1A5C7E4")]
    public static void Preload(AssetCachedSpawner assetCachedSpawner, Weapon weapon)
    {
    }

    [Token(Token = "0x601586F")]
    [Address(RVA = "0x1A59F20", Offset = "0x1A59F20", VA = "0x1A59F20")]
    public void Initialize(WeaponDetailSubScene weaponDetailSubScene)
    {
    }

    [Token(Token = "0x6015870")]
    [Address(RVA = "0x1A5EA70", Offset = "0x1A5EA70", VA = "0x1A5EA70")]
    private int CalcMaxNumCanLimitBreak() => new int();

    [Token(Token = "0x6015871")]
    [Address(RVA = "0x1A5EAF0", Offset = "0x1A5EAF0", VA = "0x1A5EAF0")]
    private void SetSideMenu()
    {
    }

    [Token(Token = "0x6015872")]
    [Address(RVA = "0x1A5EE90", Offset = "0x1A5EE90", VA = "0x1A5EE90")]
    private void OnClickPrevNext()
    {
    }

    [Token(Token = "0x6015873")]
    [Address(RVA = "0x1A5EE70", Offset = "0x1A5EE70", VA = "0x1A5EE70")]
    private bool IsEnabledLimitBreakButton() => new bool();

    [Token(Token = "0x6015874")]
    [Address(RVA = "0x1A5ECCC", Offset = "0x1A5ECCC", VA = "0x1A5ECCC")]
    private void SetMaterialIcon(ItemTypeEnum itemTypeEnum, int id, int amount, int needAmount)
    {
    }

    [Token(Token = "0x6015875")]
    [Address(RVA = "0x1A5EF74", Offset = "0x1A5EF74", VA = "0x1A5EF74")]
    private void SetMaterialIconImage(
      ItemTypeEnum itemTypeEnum,
      int id,
      int amount,
      int needAmount)
    {
    }

    [Token(Token = "0x6015876")]
    [Address(RVA = "0x1A5EBC4", Offset = "0x1A5EBC4", VA = "0x1A5EBC4")]
    private void SetButtonStatus()
    {
    }

    [Token(Token = "0x6015877")]
    [Address(RVA = "0x1A5F11C", Offset = "0x1A5F11C", VA = "0x1A5F11C")]
    private IEnumerator ConnectToApi(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x6015878")]
    [Address(RVA = "0x1A5F1B8", Offset = "0x1A5F1B8", VA = "0x1A5F1B8")]
    private IEnumerator EffectLimitBreak() => (IEnumerator) null;

    [Token(Token = "0x6015879")]
    [Address(RVA = "0x1A5F248", Offset = "0x1A5F248", VA = "0x1A5F248")]
    private void FinishEffectAction()
    {
    }

    [Token(Token = "0x601587A")]
    [Address(RVA = "0x1A5F33C", Offset = "0x1A5F33C", VA = "0x1A5F33C")]
    private void UpdateItemParameter()
    {
    }

    [Token(Token = "0x601587B")]
    [Address(RVA = "0x1A5F354", Offset = "0x1A5F354", VA = "0x1A5F354")]
    public WeaponLimitBreak()
    {
    }
  }
}
