// Decompiled with JetBrains decompiler
// Type: UnitView.Equipment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnitEquipmentView.UI;

#nullable disable
namespace UnitView
{
  [Token(Token = "0x20003C4")]
  public class Equipment : IEnumerable<ItemDetailData>, IEnumerable
  {
    [Token(Token = "0x4001638")]
    [FieldOffset(Offset = "0x10")]
    private readonly List<ItemDetailData> items;

    [Token(Token = "0x60015E4")]
    [Address(RVA = "0x2484CF0", Offset = "0x2484CF0", VA = "0x2484CF0")]
    public void Equip(ItemDetailData item)
    {
    }

    [Token(Token = "0x60015E5")]
    [Address(RVA = "0x2484EFC", Offset = "0x2484EFC", VA = "0x2484EFC")]
    public void UnEquip(ItemDetailData item)
    {
    }

    [Token(Token = "0x60015E6")]
    [Address(RVA = "0x2484F90", Offset = "0x2484F90", VA = "0x2484F90")]
    public bool IsEquipped(ItemDetailData item) => new bool();

    [Token(Token = "0x60015E7")]
    [Address(RVA = "0x24850AC", Offset = "0x24850AC", VA = "0x24850AC", Slot = "4")]
    public IEnumerator<ItemDetailData> GetEnumerator() => (IEnumerator<ItemDetailData>) null;

    [Token(Token = "0x60015E8")]
    [Address(RVA = "0x248514C", Offset = "0x248514C", VA = "0x248514C", Slot = "5")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60015E9")]
    [Address(RVA = "0x2484324", Offset = "0x2484324", VA = "0x2484324")]
    public Equipment()
    {
    }
  }
}
