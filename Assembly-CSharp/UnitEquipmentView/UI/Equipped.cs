// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.Equipped
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x2000435")]
  [Serializable]
  public class Equipped : ItemEasyDataUI.IItemSelectEvent
  {
    [Token(Token = "0x400179E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ItemEasyDataUI conceptDress;
    [Token(Token = "0x400179F")]
    [FieldOffset(Offset = "0x18")]
    private Equipped.IEquippedItemEvent eventReceiver;

    [Token(Token = "0x60017D4")]
    [Address(RVA = "0x248EF70", Offset = "0x248EF70", VA = "0x248EF70")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60017D5")]
    [Address(RVA = "0x248C95C", Offset = "0x248C95C", VA = "0x248C95C")]
    public void RegisterLongTapEvent(ItemEasyDataUI.IItemSelectLongTapEvent receiver)
    {
    }

    [Token(Token = "0x60017D6")]
    [Address(RVA = "0x248EF88", Offset = "0x248EF88", VA = "0x248EF88")]
    public void EventEnable()
    {
    }

    [Token(Token = "0x60017D7")]
    [Address(RVA = "0x248EF8C", Offset = "0x248EF8C", VA = "0x248EF8C")]
    public void EventDisable()
    {
    }

    [Token(Token = "0x60017D8")]
    [Address(RVA = "0x248EF90", Offset = "0x248EF90", VA = "0x248EF90")]
    public void SetReceiver(Equipped.IEquippedItemEvent eventReceiver)
    {
    }

    [Token(Token = "0x60017D9")]
    [Address(RVA = "0x248EF98", Offset = "0x248EF98", VA = "0x248EF98")]
    public void UIApply()
    {
    }

    [Token(Token = "0x60017DA")]
    [Address(RVA = "0x248EFB8", Offset = "0x248EFB8", VA = "0x248EFB8")]
    public void Reset()
    {
    }

    [Token(Token = "0x60017DB")]
    [Address(RVA = "0x248EFD8", Offset = "0x248EFD8", VA = "0x248EFD8")]
    public void AllDisable()
    {
    }

    [Token(Token = "0x60017DC")]
    [Address(RVA = "0x248EFF8", Offset = "0x248EFF8", VA = "0x248EFF8")]
    public void OnSelect(ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x60017DD")]
    [Address(RVA = "0x248F054", Offset = "0x248F054", VA = "0x248F054", Slot = "4")]
    private void UnitEquipmentView\u002EUI\u002EItemEasyDataUI\u002EIItemSelectEvent\u002EOnSelect(
      ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x60017DE")]
    [Address(RVA = "0x248F0FC", Offset = "0x248F0FC", VA = "0x248F0FC", Slot = "5")]
    private void UnitEquipmentView\u002EUI\u002EItemEasyDataUI\u002EIItemSelectEvent\u002EOnChangeEquipState(
      ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x60017DF")]
    [Address(RVA = "0x248F100", Offset = "0x248F100", VA = "0x248F100")]
    public Equipped()
    {
    }

    [Token(Token = "0x2000436")]
    public interface IEquippedItemEvent
    {
      [Token(Token = "0x60017E0")]
      void OnSelect(ItemEasyDataUI selectItem);
    }
  }
}
