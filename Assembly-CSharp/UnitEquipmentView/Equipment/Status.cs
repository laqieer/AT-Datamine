// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.Equipment.Status
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitEquipmentView.Equipment
{
  [Token(Token = "0x2000490")]
  public struct Status
  {
    [Token(Token = "0x17000318")]
    public readonly DetailDataParameters Parameters
    {
      [Token(Token = "0x60019A8"), Address(RVA = "0x2C22E3C", Offset = "0x2C22E3C", VA = "0x2C22E3C")] get
      {
        return new DetailDataParameters();
      }
    }

    [Token(Token = "0x17000319")]
    public readonly DetailDataResistances Resistances
    {
      [Token(Token = "0x60019A9"), Address(RVA = "0x2C22E44", Offset = "0x2C22E44", VA = "0x2C22E44")] get
      {
        return new DetailDataResistances();
      }
    }

    [Token(Token = "0x60019AA")]
    [Address(RVA = "0x2C22E4C", Offset = "0x2C22E4C", VA = "0x2C22E4C")]
    private Status(DetailDataParameters parameters, DetailDataResistances resistances)
    {
    }

    [Token(Token = "0x60019AB")]
    [Address(RVA = "0x2C22E54", Offset = "0x2C22E54", VA = "0x2C22E54")]
    public static Status CreateDummy() => new Status();

    [Token(Token = "0x60019AC")]
    [Address(RVA = "0x2C2284C", Offset = "0x2C2284C", VA = "0x2C2284C")]
    public static int DummyValue() => new int();
  }
}
