// Decompiled with JetBrains decompiler
// Type: Battle.TargetSearch.SupporterSearcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.TargetSearch
{
  [Token(Token = "0x200246B")]
  public sealed class SupporterSearcher
  {
    [Token(Token = "0x4009C36")]
    public const int UsableSupportUnitCount = 4;
    [Token(Token = "0x4009C37")]
    [FieldOffset(Offset = "0x0")]
    private static readonly List<UnitParameterData> EmptyResult;
    [Token(Token = "0x4009C38")]
    [FieldOffset(Offset = "0x8")]
    private static readonly Comparison<(UnitParameterData unit, SupportRankTypeEnum rank)> SupportComparer;
    [Token(Token = "0x4009C39")]
    [FieldOffset(Offset = "0x10")]
    private static readonly Func<(UnitParameterData unit, SupportRankTypeEnum rank), UnitParameterData> SelectUnit;

    [Token(Token = "0x17002FDF")]
    public List<UnitParameterData> SearchResult
    {
      [Token(Token = "0x600DF46"), Address(RVA = "0x2018E84", Offset = "0x2018E84", VA = "0x2018E84")] get
      {
        return (List<UnitParameterData>) null;
      }
      [Token(Token = "0x600DF47"), Address(RVA = "0x2018E8C", Offset = "0x2018E8C", VA = "0x2018E8C")] private set
      {
      }
    }

    [Token(Token = "0x600DF48")]
    [Address(RVA = "0x2018E94", Offset = "0x2018E94", VA = "0x2018E94")]
    public static List<UnitParameterData> Find(
      BoardData board,
      UnitParameterData actionUnit,
      SkillParameterData usingSkill,
      TargetPair mainTarget)
    {
      return (List<UnitParameterData>) null;
    }

    [Token(Token = "0x600DF49")]
    [Address(RVA = "0x2018F8C", Offset = "0x2018F8C", VA = "0x2018F8C")]
    public void Search(
      BoardData board,
      UnitParameterData actionUnit,
      SkillParameterData usingSkill,
      TargetPair mainTarget)
    {
    }

    [Token(Token = "0x600DF4A")]
    [Address(RVA = "0x20191AC", Offset = "0x20191AC", VA = "0x20191AC")]
    private List<UnitParameterData> GetSupportUnitsFrom(
      BoardData board,
      IReadOnlyList<UnitParameterData> forceUnits,
      UnitParameterData actionUnit,
      SkillParameterData usingSkill,
      TargetPair mainTarget,
      IReadableCharacterSupportData supportData,
      Battle.RouteSearch.Node[,] searchNodes)
    {
      return (List<UnitParameterData>) null;
    }

    [Token(Token = "0x600DF4B")]
    [Address(RVA = "0x20193E4", Offset = "0x20193E4", VA = "0x20193E4")]
    private List<(UnitParameterData, SupportRankTypeEnum)> GetLinkageStratagemUnitsFrom(
      BoardData board,
      IReadOnlyList<UnitParameterData> forceUnits,
      UnitParameterData actionUnit,
      SkillParameterData usingSkill,
      TargetPair mainTarget,
      IReadableCharacterSupportData supportData,
      Battle.RouteSearch.Node[,] searchNodes)
    {
      return (List<(UnitParameterData, SupportRankTypeEnum)>) null;
    }

    [Token(Token = "0x600DF4C")]
    [Address(RVA = "0x2019810", Offset = "0x2019810", VA = "0x2019810")]
    private bool IsSupportableUnit(
      BoardData board,
      UnitParameterData actionUnit,
      UnitParameterData unit,
      SkillParameterData skill,
      TargetPair mainTarget,
      Battle.RouteSearch.Node[,] searchNodes)
    {
      return new bool();
    }

    [Token(Token = "0x600DF4D")]
    [Address(RVA = "0x2018F24", Offset = "0x2018F24", VA = "0x2018F24")]
    public SupporterSearcher()
    {
    }

    [Token(Token = "0x600DF4E")]
    [Address(RVA = "0x2019F20", Offset = "0x2019F20", VA = "0x2019F20")]
    static SupporterSearcher()
    {
    }
  }
}
