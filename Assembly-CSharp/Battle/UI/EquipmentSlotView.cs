// Decompiled with JetBrains decompiler
// Type: Battle.UI.EquipmentSlotView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Scenes.OutGame.Info.Equipment;
using Scenes.OutGame.Info.Style;
using Scenes.OutGame.Info.Unit;
using System;
using System.Collections;
using TeamOrganization;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002383")]
  public class EquipmentSlotView : MonoBehaviour
  {
    [Token(Token = "0x400972F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SlotEquipmentGroupUI slotUI;
    [Token(Token = "0x4009730")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private DurableUI[] durableUIs;
    [Token(Token = "0x4009731")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject goDurableUI;
    [Token(Token = "0x4009732")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Tooltip("現在/最大がこの数値以下の時に赤字に変更する[%]")]
    private int redTextCondition;
    [Token(Token = "0x4009733")]
    [FieldOffset(Offset = "0x38")]
    private EquipmentSlotThumb slotPrefab;
    [Token(Token = "0x4009734")]
    [FieldOffset(Offset = "0x40")]
    private EquipmentSlotThumb[] thumbs;
    [Token(Token = "0x4009735")]
    [FieldOffset(Offset = "0x48")]
    private SlotEquipmentUI[] slotUIs;

    [Token(Token = "0x17002E9E")]
    public Action<OrganizationEquipmentSlot.EquipmentSlotType> OnClickEquipment
    {
      [Token(Token = "0x600D8E2"), Address(RVA = "0x1B99EB8", Offset = "0x1B99EB8", VA = "0x1B99EB8")] private get
      {
        return (Action<OrganizationEquipmentSlot.EquipmentSlotType>) null;
      }
      [Token(Token = "0x600D8E3"), Address(RVA = "0x1B99EC0", Offset = "0x1B99EC0", VA = "0x1B99EC0")] set
      {
      }
    }

    [Token(Token = "0x600D8E4")]
    [Address(RVA = "0x1B99EC8", Offset = "0x1B99EC8", VA = "0x1B99EC8")]
    public void Initialize(Action finishInitializeAction)
    {
    }

    [Token(Token = "0x600D8E5")]
    [Address(RVA = "0x1B9A204", Offset = "0x1B9A204", VA = "0x1B9A204")]
    public void SetActiveEquipmentDurableUI(bool isEnable)
    {
    }

    [Token(Token = "0x600D8E6")]
    [Address(RVA = "0x1B9A298", Offset = "0x1B9A298", VA = "0x1B9A298")]
    private EquipmentSlotThumb CreateEquipmentSlot(
      Transform parent,
      CommonButton button,
      CommonButton lockButton,
      OrganizationEquipmentSlot.EquipmentSlotType slot)
    {
      return (EquipmentSlotThumb) null;
    }

    [Token(Token = "0x600D8E7")]
    [Address(RVA = "0x1B9A3F4", Offset = "0x1B9A3F4", VA = "0x1B9A3F4")]
    public void UpdateView(UnitModelBase model)
    {
    }

    [Token(Token = "0x600D8E8")]
    [Address(RVA = "0x1B9A190", Offset = "0x1B9A190", VA = "0x1B9A190")]
    private IEnumerator LoadEquipments([CanBeNull] Action callback) => (IEnumerator) null;

    [Token(Token = "0x600D8E9")]
    [Address(RVA = "0x1B9A6B8", Offset = "0x1B9A6B8", VA = "0x1B9A6B8")]
    private void UpdateEquipmentThumb(
      OrganizationEquipmentSlot.EquipmentSlotType slotType,
      StyleModelBase styleModel,
      EquipmentSlotView.SlotModel model)
    {
    }

    [Token(Token = "0x600D8EA")]
    [Address(RVA = "0x1B9AA80", Offset = "0x1B9AA80", VA = "0x1B9AA80")]
    private bool IsRedText(int current, int max) => new bool();

    [Token(Token = "0x600D8EB")]
    [Address(RVA = "0x1B9ABA8", Offset = "0x1B9ABA8", VA = "0x1B9ABA8")]
    private void OnClickEquipmentSlot(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
    }

    [Token(Token = "0x600D8EC")]
    [Address(RVA = "0x1B9A608", Offset = "0x1B9A608", VA = "0x1B9A608")]
    private EquipmentSlotView.SlotModel Create(EquipmentWeaponModelBase model)
    {
      return new EquipmentSlotView.SlotModel();
    }

    [Token(Token = "0x600D8ED")]
    [Address(RVA = "0x1B9A90C", Offset = "0x1B9A90C", VA = "0x1B9A90C")]
    private EquipmentSlotView.SlotModel Create(EquipmentAccessoryModelBase model)
    {
      return new EquipmentSlotView.SlotModel();
    }

    [Token(Token = "0x600D8EE")]
    [Address(RVA = "0x1B9A998", Offset = "0x1B9A998", VA = "0x1B9A998")]
    private EquipmentSlotView.SlotModel Create(EquipmentTrustModelBase model)
    {
      return new EquipmentSlotView.SlotModel();
    }

    [Token(Token = "0x600D8EF")]
    [Address(RVA = "0x1B9A9F8", Offset = "0x1B9A9F8", VA = "0x1B9A9F8")]
    private EquipmentSlotView.SlotModel Create(EquipmentMindEquipmentModelBase model)
    {
      return new EquipmentSlotView.SlotModel();
    }

    [Token(Token = "0x600D8F0")]
    [Address(RVA = "0x1B9ABC4", Offset = "0x1B9ABC4", VA = "0x1B9ABC4")]
    public EquipmentSlotView()
    {
    }

    [Token(Token = "0x2002384")]
    private struct SlotModel
    {
      [Token(Token = "0x4009737")]
      [FieldOffset(Offset = "0x0")]
      public int id;
      [Token(Token = "0x4009738")]
      [FieldOffset(Offset = "0x4")]
      public int durable;
      [Token(Token = "0x4009739")]
      [FieldOffset(Offset = "0x8")]
      public int maxDurable;
      [Token(Token = "0x400973A")]
      [FieldOffset(Offset = "0xC")]
      public bool isUnknown;
      [Token(Token = "0x400973B")]
      [FieldOffset(Offset = "0x10")]
      public RarityTypeEnum RarityType;
    }
  }
}
