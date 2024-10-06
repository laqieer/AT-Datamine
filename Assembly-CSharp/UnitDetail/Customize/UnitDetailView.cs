// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.UnitDetailView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnitDetail.Customize.Equipment;
using UnitDetail.Customize.Status;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize
{
  [Token(Token = "0x20004EA")]
  public class UnitDetailView : MonoBehaviour
  {
    [Token(Token = "0x40019A5")]
    private const string EquipChangeOpenAnimationName = "EquipChange_In";
    [Token(Token = "0x40019A6")]
    private const string EquipChangeCloseAnimationName = "EquipChange_Out";
    [Token(Token = "0x40019A7")]
    private const string InventoryOpenAnimationName = "In_Inventry";
    [Token(Token = "0x40019A8")]
    private const string InventoryCloseAnimationName = "Out_Inventry";
    [Token(Token = "0x40019A9")]
    private const string SlideInLeftAnimationName = "Chara_In_L";
    [Token(Token = "0x40019AA")]
    private const string SlideOutLeftAnimationName = "Chara_Out_L";
    [Token(Token = "0x40019AB")]
    private const string SlideInRightAnimationName = "Chara_In_R";
    [Token(Token = "0x40019AC")]
    private const string SlideOutRightAnimationName = "Chara_Out_R";
    [Token(Token = "0x40019AD")]
    private const string StatusPartsAssetName = "UnitDetail_Status_Parts";
    [Token(Token = "0x40019AE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40019AF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x40019B0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TrainingStatusPane trainingStatusPane;
    [Token(Token = "0x40019B1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private EquippedPane equippedPane;
    [Token(Token = "0x40019B2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private FeatureIcon[] featureIcons;
    [Token(Token = "0x40019B3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text level;
    [Token(Token = "0x40019B4")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text maxLevel;
    [Token(Token = "0x40019B5")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text nextExp;
    [Token(Token = "0x40019B6")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Slider expSlider;
    [Token(Token = "0x40019B7")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text combatPower;
    [Token(Token = "0x40019B8")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private RectTransform[] parameterCellRootList;
    [Token(Token = "0x40019B9")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text move;
    [Token(Token = "0x40019BA")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text hp;
    [Token(Token = "0x40019BB")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text physicsAttack;
    [Token(Token = "0x40019BC")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text magicAttack;
    [Token(Token = "0x40019BD")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text physicsDefence;
    [Token(Token = "0x40019BE")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text magicDefence;
    [Token(Token = "0x40019BF")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text avoid;
    [Token(Token = "0x40019C0")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text critical;
    [Token(Token = "0x40019C1")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text hit;
    [Token(Token = "0x40019C2")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text range;
    [Token(Token = "0x40019C3")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private WeaponMasteryIcon[] weaponMasteries;
    [Token(Token = "0x40019C4")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private InventoryScrollPane inventoryScrollPane;
    [Token(Token = "0x40019C5")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private EquipmentCell equipmentCell;
    [Token(Token = "0x40019C6")]
    [FieldOffset(Offset = "0xD8")]
    private ParameterCell parameterCellPrefab;
    [Token(Token = "0x40019C7")]
    [FieldOffset(Offset = "0xE0")]
    private List<ParameterCell> parameterCellList;
    [Token(Token = "0x40019C8")]
    [FieldOffset(Offset = "0xE8")]
    private Action<bool, ItemInfoBase> closeAction;
    [Token(Token = "0x40019C9")]
    [FieldOffset(Offset = "0xF0")]
    private Style style;
    [Token(Token = "0x40019CA")]
    [FieldOffset(Offset = "0xF8")]
    public Action OnOpenStyleLvupPopup;
    [Token(Token = "0x40019CB")]
    [FieldOffset(Offset = "0x100")]
    public Action OnOpenLimitBreakPopup;
    [Token(Token = "0x40019CC")]
    [FieldOffset(Offset = "0x108")]
    public Action OnOpenWeaponProficiencyPopup;

    [Token(Token = "0x17000386")]
    public UITweenGroup TweenGroup
    {
      [Token(Token = "0x6001BFB"), Address(RVA = "0x2C318A0", Offset = "0x2C318A0", VA = "0x2C318A0")] get
      {
        return (UITweenGroup) null;
      }
    }

    [Token(Token = "0x6001BFC")]
    [Address(RVA = "0x2C2DA38", Offset = "0x2C2DA38", VA = "0x2C2DA38")]
    public void Initialize(UnitCustomizeStateHandler handler)
    {
    }

    [Token(Token = "0x6001BFD")]
    [Address(RVA = "0x2C2DE20", Offset = "0x2C2DE20", VA = "0x2C2DE20")]
    public void DisableButtons()
    {
    }

    [Token(Token = "0x6001BFE")]
    [Address(RVA = "0x2C31A74", Offset = "0x2C31A74", VA = "0x2C31A74")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6001BFF")]
    [Address(RVA = "0x2C31DC8", Offset = "0x2C31DC8", VA = "0x2C31DC8")]
    public void OnSelectItem(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001C00")]
    [Address(RVA = "0x2C31DCC", Offset = "0x2C31DCC", VA = "0x2C31DCC")]
    private void OnDetailItem(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001C01")]
    [Address(RVA = "0x2C31DD0", Offset = "0x2C31DD0", VA = "0x2C31DD0")]
    public void ShowView(Action<bool, ItemInfoBase> action)
    {
    }

    [Token(Token = "0x6001C02")]
    [Address(RVA = "0x2C31EA4", Offset = "0x2C31EA4", VA = "0x2C31EA4")]
    public void ShowHide()
    {
    }

    [Token(Token = "0x6001C03")]
    [Address(RVA = "0x2C31F7C", Offset = "0x2C31F7C", VA = "0x2C31F7C")]
    private void SetNoActive()
    {
    }

    [Token(Token = "0x6001C04")]
    [Address(RVA = "0x2C32024", Offset = "0x2C32024", VA = "0x2C32024")]
    public void OnChangeEquipMent()
    {
    }

    [Token(Token = "0x6001C05")]
    [Address(RVA = "0x2C30270", Offset = "0x2C30270", VA = "0x2C30270")]
    public void Show()
    {
    }

    [Token(Token = "0x6001C06")]
    [Address(RVA = "0x2C2DE00", Offset = "0x2C2DE00", VA = "0x2C2DE00")]
    public void Hide()
    {
    }

    [Token(Token = "0x6001C07")]
    [Address(RVA = "0x2C3076C", Offset = "0x2C3076C", VA = "0x2C3076C")]
    public void ShowInventory(ItemInfoBase itemInfoBase)
    {
    }

    [Token(Token = "0x6001C08")]
    [Address(RVA = "0x2C32134", Offset = "0x2C32134", VA = "0x2C32134")]
    public void SetInventoryItem(List<ItemInfoBase> itemInfos, EquipInfo equipItem)
    {
    }

    [Token(Token = "0x6001C09")]
    [Address(RVA = "0x2C312E8", Offset = "0x2C312E8", VA = "0x2C312E8")]
    public void HideInventory()
    {
    }

    [Token(Token = "0x6001C0A")]
    [Address(RVA = "0x2C30398", Offset = "0x2C30398", VA = "0x2C30398")]
    public void PlaySlideInLeft()
    {
    }

    [Token(Token = "0x6001C0B")]
    [Address(RVA = "0x2C30290", Offset = "0x2C30290", VA = "0x2C30290")]
    public void PlaySlideOutLeft()
    {
    }

    [Token(Token = "0x6001C0C")]
    [Address(RVA = "0x2C302E8", Offset = "0x2C302E8", VA = "0x2C302E8")]
    public void PlaySlideInRight()
    {
    }

    [Token(Token = "0x6001C0D")]
    [Address(RVA = "0x2C30340", Offset = "0x2C30340", VA = "0x2C30340")]
    public void PlaySlideOutRight()
    {
    }

    [Token(Token = "0x6001C0E")]
    [Address(RVA = "0x2C2F274", Offset = "0x2C2F274", VA = "0x2C2F274")]
    public void UpdateUnit(UnitDetailInfo unitDetailInfo)
    {
    }

    [Token(Token = "0x6001C0F")]
    [Address(RVA = "0x2C321CC", Offset = "0x2C321CC", VA = "0x2C321CC")]
    private void UpdateFeatureIcon(UnitDetailInfo unitDetailInfo)
    {
    }

    [Token(Token = "0x6001C10")]
    [Address(RVA = "0x2C3274C", Offset = "0x2C3274C", VA = "0x2C3274C")]
    private void UpdateWeaponMastery(Style style)
    {
    }

    [Token(Token = "0x6001C11")]
    [Address(RVA = "0x2C32284", Offset = "0x2C32284", VA = "0x2C32284")]
    private void UpdateParameters(Style style)
    {
    }

    [Token(Token = "0x6001C12")]
    [Address(RVA = "0x2C329FC", Offset = "0x2C329FC", VA = "0x2C329FC")]
    private void UpdateParameterCell(
      BasicParameterType basicParameterType,
      Style style,
      IBasicParameter changedParameter)
    {
    }

    [Token(Token = "0x6001C13")]
    [Address(RVA = "0x2C2F618", Offset = "0x2C2F618", VA = "0x2C2F618")]
    public void UpdateCheckEquipment(Style style, ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001C14")]
    [Address(RVA = "0x2C32B14", Offset = "0x2C32B14", VA = "0x2C32B14")]
    public void OnClickToStyleLevelup()
    {
    }

    [Token(Token = "0x6001C15")]
    [Address(RVA = "0x2C32B30", Offset = "0x2C32B30", VA = "0x2C32B30")]
    public void OnClickToLimitBreak()
    {
    }

    [Token(Token = "0x6001C16")]
    [Address(RVA = "0x2C32B4C", Offset = "0x2C32B4C", VA = "0x2C32B4C")]
    public void OnClickToWeaponProficiency()
    {
    }

    [Token(Token = "0x6001C17")]
    [Address(RVA = "0x2C32B68", Offset = "0x2C32B68", VA = "0x2C32B68")]
    public UnitDetailView()
    {
    }
  }
}
