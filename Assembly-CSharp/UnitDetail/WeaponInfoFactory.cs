// Decompiled with JetBrains decompiler
// Type: UnitDetail.WeaponInfoFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x2000499")]
  public class WeaponInfoFactory : ItemInfoFactory
  {
    [Token(Token = "0x400186A")]
    [FieldOffset(Offset = "0x10")]
    private IEnumerable<int> itemIdList;

    [Token(Token = "0x60019C9")]
    [Address(RVA = "0x2C2334C", Offset = "0x2C2334C", VA = "0x2C2334C")]
    public WeaponInfoFactory(IEnumerable<int> itemIdList)
    {
    }

    [Token(Token = "0x60019CA")]
    [Address(RVA = "0x2C233DC", Offset = "0x2C233DC", VA = "0x2C233DC", Slot = "4")]
    protected override List<ItemInfoBase> CreateItemList() => (List<ItemInfoBase>) null;
  }
}
