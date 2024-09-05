// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.Equipment.EquipmentCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize.Equipment
{
  [Token(Token = "0x2000500")]
  [Serializable]
  public class EquipmentCell : UnitDetailViewBaseInheritMonoBehaviour<ItemInfoBase>
  {
    [Token(Token = "0x4001ABA")]
    private const string EnableTweenName = "ListParts_Enable";
    [Token(Token = "0x4001ABB")]
    private const string DisableTweenName = "ListParts_Disable";
    [Token(Token = "0x4001ABC")]
    private const string DefaultContentTweenName = "Contents_Default";
    [Token(Token = "0x4001ABD")]
    private const string BlankContentTweenName = "Contents_Blank";
    [Token(Token = "0x4001ABE")]
    private const string UnequipContentTweenName = "Contents_Remove";
    [Token(Token = "0x4001ABF")]
    private const string ImpossibleContentTweenName = "Contents_NotEquip";
    [Token(Token = "0x4001AC0")]
    private const string NoneFrameTweenName = "Frame_None";
    [Token(Token = "0x4001AC1")]
    private const string ChangeFrameTweenName = "Frame_Change";
    [Token(Token = "0x4001AC2")]
    private const string SelectFrameTweenName = "Frame_Select";
    [Token(Token = "0x4001AC3")]
    private const string EquipedFrameTweenName = "Frame_Equip";
    [Token(Token = "0x4001AC4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UnitDetailItemIcon icon;
    [Token(Token = "0x4001AC5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI equipmentName;
    [Token(Token = "0x4001AC6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x4001AC7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI durability;
    [Token(Token = "0x4001AC8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UITweenGroup tweenGroup;

    [Token(Token = "0x17000398")]
    public Action<ItemInfoBase> OnSelect
    {
      [Token(Token = "0x6001CA2"), Address(RVA = "0x29F3D08", Offset = "0x29F3D08", VA = "0x29F3D08")] private get
      {
        return (Action<ItemInfoBase>) null;
      }
      [Token(Token = "0x6001CA3"), Address(RVA = "0x29F3D10", Offset = "0x29F3D10", VA = "0x29F3D10")] set
      {
      }
    }

    [Token(Token = "0x17000399")]
    public Action<ItemInfoBase> OnDetail
    {
      [Token(Token = "0x6001CA4"), Address(RVA = "0x29F3D18", Offset = "0x29F3D18", VA = "0x29F3D18")] private get
      {
        return (Action<ItemInfoBase>) null;
      }
      [Token(Token = "0x6001CA5"), Address(RVA = "0x29F3D20", Offset = "0x29F3D20", VA = "0x29F3D20")] set
      {
      }
    }

    [Token(Token = "0x6001CA6")]
    [Address(RVA = "0x29F3D28", Offset = "0x29F3D28", VA = "0x29F3D28", Slot = "4")]
    protected override void InitializeImpl()
    {
    }

    [Token(Token = "0x6001CA7")]
    [Address(RVA = "0x29F3E48", Offset = "0x29F3E48", VA = "0x29F3E48", Slot = "5")]
    protected override void UpdateViewImpl()
    {
    }

    [Token(Token = "0x6001CA8")]
    [Address(RVA = "0x29F406C", Offset = "0x29F406C", VA = "0x29F406C")]
    private void ShowWeapon(WeaponInfo weapon)
    {
    }

    [Token(Token = "0x6001CA9")]
    [Address(RVA = "0x29F412C", Offset = "0x29F412C", VA = "0x29F412C")]
    private void ShowAccessorie()
    {
    }

    [Token(Token = "0x6001CAA")]
    [Address(RVA = "0x29F40A4", Offset = "0x29F40A4", VA = "0x29F40A4")]
    private void ShowEquipment()
    {
    }

    [Token(Token = "0x6001CAB")]
    [Address(RVA = "0x29F4164", Offset = "0x29F4164", VA = "0x29F4164")]
    private void ShowUnitTrust()
    {
    }

    [Token(Token = "0x6001CAC")]
    [Address(RVA = "0x29F419C", Offset = "0x29F419C", VA = "0x29F419C")]
    private void ShowRemoveInfo()
    {
    }

    [Token(Token = "0x6001CAD")]
    [Address(RVA = "0x29F4214", Offset = "0x29F4214", VA = "0x29F4214")]
    private void ShowLockInfo()
    {
    }

    [Token(Token = "0x6001CAE")]
    [Address(RVA = "0x29F42BC", Offset = "0x29F42BC", VA = "0x29F42BC")]
    private void Empty()
    {
    }

    [Token(Token = "0x6001CAF")]
    [Address(RVA = "0x29F43D0", Offset = "0x29F43D0", VA = "0x29F43D0")]
    public void ShowEmpty()
    {
    }

    [Token(Token = "0x6001CB0")]
    [Address(RVA = "0x29F43D4", Offset = "0x29F43D4", VA = "0x29F43D4")]
    public void ShowSelect()
    {
    }

    [Token(Token = "0x6001CB1")]
    [Address(RVA = "0x29F448C", Offset = "0x29F448C", VA = "0x29F448C")]
    public void ShowNoFrame()
    {
    }

    [Token(Token = "0x6001CB2")]
    [Address(RVA = "0x29F4544", Offset = "0x29F4544", VA = "0x29F4544")]
    public void ShowEquip()
    {
    }

    [Token(Token = "0x6001CB3")]
    [Address(RVA = "0x29F45FC", Offset = "0x29F45FC", VA = "0x29F45FC")]
    private void OnClickButton()
    {
    }

    [Token(Token = "0x6001CB4")]
    [Address(RVA = "0x29F4658", Offset = "0x29F4658", VA = "0x29F4658")]
    private void OnLongPress()
    {
    }

    [Token(Token = "0x6001CB5")]
    [Address(RVA = "0x29F46B4", Offset = "0x29F46B4", VA = "0x29F46B4")]
    public EquipmentCell()
    {
    }
  }
}
