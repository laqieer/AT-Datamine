// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleSupportValueInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x20026A7")]
  public class BattleSupportValueInfo
  {
    [Token(Token = "0x400A5CB")]
    [FieldOffset(Offset = "0x10")]
    public readonly CharacterSupportData Support;
    [Token(Token = "0x400A5CC")]
    [FieldOffset(Offset = "0x18")]
    public readonly UnitParameterData Unit1;
    [Token(Token = "0x400A5CD")]
    [FieldOffset(Offset = "0x20")]
    public readonly UnitParameterData Unit2;
    [Token(Token = "0x400A5CE")]
    [FieldOffset(Offset = "0x28")]
    public int GainSupportPoint;
    [Token(Token = "0x400A5CF")]
    [FieldOffset(Offset = "0x2C")]
    public readonly int PreSupportPoint;

    [Token(Token = "0x170032A6")]
    public int PostSupportPoint
    {
      [Token(Token = "0x600EF68"), Address(RVA = "0x40D87A8", Offset = "0x40D87A8", VA = "0x40D87A8")] get
      {
        return new int();
      }
      [Token(Token = "0x600EF69"), Address(RVA = "0x40D87B0", Offset = "0x40D87B0", VA = "0x40D87B0")] private set
      {
      }
    }

    [Token(Token = "0x600EF6A")]
    [Address(RVA = "0x40D87B8", Offset = "0x40D87B8", VA = "0x40D87B8")]
    public BattleSupportValueInfo(
      CharacterSupportData support,
      UnitParameterData unit1,
      UnitParameterData unit2)
    {
    }

    [Token(Token = "0x600EF6B")]
    [Address(RVA = "0x40D883C", Offset = "0x40D883C", VA = "0x40D883C")]
    public bool HasPair(UnitParameterData unit1, UnitParameterData unit2) => new bool();

    [Token(Token = "0x600EF6C")]
    [Address(RVA = "0x40D88F8", Offset = "0x40D88F8", VA = "0x40D88F8")]
    public void InjectSupport()
    {
    }
  }
}
