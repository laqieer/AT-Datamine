// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.Equipment.DetailDataParameters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace UnitEquipmentView.Equipment
{
  [Token(Token = "0x200048D")]
  public struct DetailDataParameters : IEnumerable<Parameter>, IEnumerable
  {
    [Token(Token = "0x400185B")]
    [FieldOffset(Offset = "0x0")]
    private List<Parameter> parameters;

    [Token(Token = "0x6001995")]
    [Address(RVA = "0x2C223F4", Offset = "0x2C223F4", VA = "0x2C223F4")]
    private DetailDataParameters(List<Parameter> parameters)
    {
    }

    [Token(Token = "0x6001996")]
    [Address(RVA = "0x2C223FC", Offset = "0x2C223FC", VA = "0x2C223FC")]
    public static DetailDataParameters CreateDummy() => new DetailDataParameters();

    [Token(Token = "0x6001997")]
    [Address(RVA = "0x2C2281C", Offset = "0x2C2281C", VA = "0x2C2281C")]
    private static int DummyValue() => new int();

    [Token(Token = "0x6001998")]
    [Address(RVA = "0x2C22870", Offset = "0x2C22870", VA = "0x2C22870", Slot = "4")]
    public IEnumerator<Parameter> GetEnumerator() => (IEnumerator<Parameter>) null;

    [Token(Token = "0x6001999")]
    [Address(RVA = "0x2C228FC", Offset = "0x2C228FC", VA = "0x2C228FC", Slot = "5")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }
  }
}
