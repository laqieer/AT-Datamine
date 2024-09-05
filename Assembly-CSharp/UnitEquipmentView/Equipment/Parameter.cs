// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.Equipment.Parameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitEquipmentView.Equipment
{
  [Token(Token = "0x200048F")]
  public struct Parameter
  {
    [Token(Token = "0x17000316")]
    public string Name
    {
      [Token(Token = "0x600199F"), Address(RVA = "0x2C22DDC", Offset = "0x2C22DDC", VA = "0x2C22DDC")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x60019A0"), Address(RVA = "0x2C22DE4", Offset = "0x2C22DE4", VA = "0x2C22DE4")] private set
      {
      }
    }

    [Token(Token = "0x17000317")]
    public int Value
    {
      [Token(Token = "0x60019A1"), Address(RVA = "0x2C22DEC", Offset = "0x2C22DEC", VA = "0x2C22DEC")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x60019A2"), Address(RVA = "0x2C22DF4", Offset = "0x2C22DF4", VA = "0x2C22DF4")] private set
      {
      }
    }

    [Token(Token = "0x60019A3")]
    [Address(RVA = "0x2C22840", Offset = "0x2C22840", VA = "0x2C22840")]
    public Parameter(string name, int value)
    {
    }

    [Token(Token = "0x60019A4")]
    [Address(RVA = "0x2C22DFC", Offset = "0x2C22DFC", VA = "0x2C22DFC")]
    public bool IsGreatherThan(int value) => new bool();

    [Token(Token = "0x60019A5")]
    [Address(RVA = "0x2C22E0C", Offset = "0x2C22E0C", VA = "0x2C22E0C")]
    public bool IsLessThan(int value) => new bool();

    [Token(Token = "0x60019A6")]
    [Address(RVA = "0x2C22E1C", Offset = "0x2C22E1C", VA = "0x2C22E1C")]
    public bool IsGreatherThan(Parameter parameter) => new bool();

    [Token(Token = "0x60019A7")]
    [Address(RVA = "0x2C22E2C", Offset = "0x2C22E2C", VA = "0x2C22E2C")]
    public bool IsLessThan(Parameter parameter) => new bool();
  }
}
