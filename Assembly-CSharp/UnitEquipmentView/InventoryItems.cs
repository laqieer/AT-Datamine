// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.InventoryItems
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnitEquipmentView.UI;

#nullable disable
namespace UnitEquipmentView
{
  [Token(Token = "0x2000421")]
  public class InventoryItems : IEnumerable<ItemDetailData>, IEnumerable
  {
    [Token(Token = "0x4001776")]
    [FieldOffset(Offset = "0x10")]
    private List<ItemDetailData> sortedItems;

    [Token(Token = "0x170002A3")]
    public ItemDetailData this[int index]
    {
      [Token(Token = "0x600175A"), Address(RVA = "0x248BDD8", Offset = "0x248BDD8", VA = "0x248BDD8")] get
      {
        return new ItemDetailData();
      }
    }

    [Token(Token = "0x170002A4")]
    public int Count
    {
      [Token(Token = "0x600175B"), Address(RVA = "0x248BE5C", Offset = "0x248BE5C", VA = "0x248BE5C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600175C")]
    [Address(RVA = "0x248BEA4", Offset = "0x248BEA4", VA = "0x248BEA4")]
    public void Filtering(IEnumerable<ItemDetailData> list, Func<ItemDetailData, bool> predicate)
    {
    }

    [Token(Token = "0x600175D")]
    [Address(RVA = "0x248C004", Offset = "0x248C004", VA = "0x248C004")]
    public void UpdateSortByCategory(IEnumerable<ItemDetailData> list)
    {
    }

    [Token(Token = "0x600175E")]
    [Address(RVA = "0x248C128", Offset = "0x248C128", VA = "0x248C128", Slot = "4")]
    public IEnumerator<ItemDetailData> GetEnumerator() => (IEnumerator<ItemDetailData>) null;

    [Token(Token = "0x600175F")]
    [Address(RVA = "0x248C1C8", Offset = "0x248C1C8", VA = "0x248C1C8", Slot = "5")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6001760")]
    [Address(RVA = "0x248C1CC", Offset = "0x248C1CC", VA = "0x248C1CC")]
    public InventoryItems()
    {
    }
  }
}
