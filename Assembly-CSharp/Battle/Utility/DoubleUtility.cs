// Decompiled with JetBrains decompiler
// Type: Battle.Utility.DoubleUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data.Board;
using Battle.RouteSearch;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Utility
{
  [Token(Token = "0x20022CD")]
  public sealed class DoubleUtility
  {
    [Token(Token = "0x600D43D")]
    [Address(RVA = "0x19E42D4", Offset = "0x19E42D4", VA = "0x19E42D4")]
    public static void CloneDoubleUnit(
      UnitParameterData src,
      out UnitParameterData leader,
      out UnitParameterData doubled)
    {
    }

    [Token(Token = "0x600D43E")]
    [Address(RVA = "0x19E43AC", Offset = "0x19E43AC", VA = "0x19E43AC")]
    public static void Double(
      BoardData board,
      UnitParameterData leader,
      UnitParameterData supporter)
    {
    }

    [Token(Token = "0x600D43F")]
    [Address(RVA = "0x19E4404", Offset = "0x19E4404", VA = "0x19E4404")]
    public static void Switch(BoardData board, UnitParameterData leader)
    {
    }

    [Token(Token = "0x600D440")]
    [Address(RVA = "0x19E4490", Offset = "0x19E4490", VA = "0x19E4490")]
    public static void GetUsableDoubleCommandFlags(
      UnitParameterData unit,
      AttackableAreaSearcher doubleSearcher,
      ref CommandType flags)
    {
    }

    [Token(Token = "0x600D441")]
    [Address(RVA = "0x19E45E8", Offset = "0x19E45E8", VA = "0x19E45E8")]
    public static bool CanDouble(UnitParameterData leader, UnitParameterData target) => new bool();

    [Token(Token = "0x600D442")]
    [Address(RVA = "0x19E4538", Offset = "0x19E4538", VA = "0x19E4538")]
    public static bool CanSwitch(UnitParameterData leader) => new bool();

    [Token(Token = "0x600D443")]
    [Address(RVA = "0x19E460C", Offset = "0x19E460C", VA = "0x19E460C")]
    public DoubleUtility()
    {
    }
  }
}
