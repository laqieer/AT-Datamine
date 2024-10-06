// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.Equipment.DetailDataResistances
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace UnitEquipmentView.Equipment
{
  [Token(Token = "0x200048E")]
  public struct DetailDataResistances : IEnumerable<Parameter>, IEnumerable
  {
    [Token(Token = "0x400185C")]
    [FieldOffset(Offset = "0x0")]
    private List<Parameter> parameters;

    [Token(Token = "0x600199A")]
    [Address(RVA = "0x2C22900", Offset = "0x2C22900", VA = "0x2C22900")]
    private DetailDataResistances(List<Parameter> parameters)
    {
    }

    [Token(Token = "0x600199B")]
    [Address(RVA = "0x2C22908", Offset = "0x2C22908", VA = "0x2C22908")]
    public static DetailDataResistances CreateDummy() => new DetailDataResistances();

    [Token(Token = "0x600199C")]
    [Address(RVA = "0x2C22D28", Offset = "0x2C22D28", VA = "0x2C22D28")]
    private static int DummyValue() => new int();

    [Token(Token = "0x600199D")]
    [Address(RVA = "0x2C22D4C", Offset = "0x2C22D4C", VA = "0x2C22D4C", Slot = "4")]
    public IEnumerator<Parameter> GetEnumerator() => (IEnumerator<Parameter>) null;

    [Token(Token = "0x600199E")]
    [Address(RVA = "0x2C22DD8", Offset = "0x2C22DD8", VA = "0x2C22DD8", Slot = "5")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }
  }
}
