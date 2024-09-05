// Decompiled with JetBrains decompiler
// Type: Battle.Utility.SearchUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.RouteSearch;
using Battle.Unit;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Utility
{
  [Token(Token = "0x20022D0")]
  public static class SearchUtility
  {
    [Token(Token = "0x600D454")]
    [Address(RVA = "0x19E4614", Offset = "0x19E4614", VA = "0x19E4614")]
    public static void SearchMoveAndAttackableAreas(
      BoardData board,
      UnitParameterData unit,
      SkillParameterData skill,
      ref MovableAreaSearcher moveSearcher,
      ref AttackableAreaSearcher atkSearcher)
    {
    }

    [Token(Token = "0x600D455")]
    [Address(RVA = "0x19E4670", Offset = "0x19E4670", VA = "0x19E4670")]
    public static void SearchMoveAndAttackableAreas(
      BoardData board,
      UnitParameterData unit,
      GridData baseGrid,
      SkillParameterData skill,
      ref MovableAreaSearcher moveSearcher,
      ref AttackableAreaSearcher atkSearcher)
    {
    }

    [Token(Token = "0x600D456")]
    [Address(RVA = "0x19E47B4", Offset = "0x19E47B4", VA = "0x19E47B4")]
    public static void SearchAttackableAreas(
      BoardData board,
      UnitParameterData unit,
      GridData baseGrid,
      SkillParameterData skill,
      MovableAreaSearcher moveSearcher,
      ref AttackableAreaSearcher atkSearcher,
      bool isReset = true)
    {
    }

    [Token(Token = "0x600D457")]
    [Address(RVA = "0x19E4A78", Offset = "0x19E4A78", VA = "0x19E4A78")]
    public static void SearchAttackableAreas(
      BoardData board,
      UnitParameterData unit,
      SkillParameterData skill,
      ref AttackableAreaSearcher atkSearcher)
    {
    }

    [Token(Token = "0x600D458")]
    [Address(RVA = "0x19E4928", Offset = "0x19E4928", VA = "0x19E4928")]
    public static void SearchAttackableAreas(
      BoardData board,
      UnitParameterData unit,
      GridData baseGrid,
      SkillParameterData skill,
      ref AttackableAreaSearcher atkSearcher,
      bool isReset = true)
    {
    }

    [Token(Token = "0x600D459")]
    [Address(RVA = "0x19E4AD0", Offset = "0x19E4AD0", VA = "0x19E4AD0")]
    public static void SearchAttackableAreasAutoTurret(
      BoardData board,
      BattlePlayerData player,
      GridData baseGrid,
      Actor.Direction direct,
      SkillParameterData skill,
      ref AttackableAreaSearcher atkSearcher,
      bool isReset = true)
    {
    }

    [Token(Token = "0x600D45A")]
    [Address(RVA = "0x19E4C44", Offset = "0x19E4C44", VA = "0x19E4C44")]
    public static void SearchDoublableAreas(
      BoardData board,
      UnitParameterData unit,
      MovableAreaSearcher moveSearcher,
      ref AttackableAreaSearcher atkSearcher)
    {
    }

    [Token(Token = "0x600D45B")]
    [Address(RVA = "0x19E4D40", Offset = "0x19E4D40", VA = "0x19E4D40")]
    public static void SearchReleaseDoubleAreas(
      BoardData board,
      UnitParameterData unit,
      GridData baseGrid,
      ref AttackableAreaSearcher atkSearcher)
    {
    }

    [Token(Token = "0x600D45C")]
    [Address(RVA = "0x19E4E64", Offset = "0x19E4E64", VA = "0x19E4E64")]
    public static void SearchInteractableAreas(
      BoardData board,
      UnitParameterData unit,
      MovableAreaSearcher moveSearcher,
      ref InteractableAreaSearcher interactAreaSeacher)
    {
    }

    [Token(Token = "0x600D45D")]
    [Address(RVA = "0x19E4F60", Offset = "0x19E4F60", VA = "0x19E4F60")]
    public static bool ContainsInResult(
      List<GridData> grids,
      PathSearcher2D searcher,
      out IReadOnlyList<GridData> contains)
    {
      return new bool();
    }

    [Token(Token = "0x600D45E")]
    [Address(RVA = "0x19E51B0", Offset = "0x19E51B0", VA = "0x19E51B0")]
    public static bool ContainsInResult(
      UnitParameterData unit,
      PathSearcher2D searcher,
      out IReadOnlyList<GridData> contains)
    {
      return new bool();
    }

    [Token(Token = "0x600D45F")]
    [Address(RVA = "0x19DFD20", Offset = "0x19DFD20", VA = "0x19DFD20")]
    public static bool ContainsInResult(UnitParameterData unit, PathSearcher2D searcher)
    {
      return new bool();
    }

    [Token(Token = "0x600D460")]
    [Address(RVA = "0x19E53D0", Offset = "0x19E53D0", VA = "0x19E53D0")]
    public static void SearchEffectiveRange(
      GridData castFrom,
      GridData castTo,
      SkillParameterData skill,
      ref AttackableAreaSearcher effectiveAreaSearcher)
    {
    }

    [Token(Token = "0x600D461")]
    [Address(RVA = "0x19E545C", Offset = "0x19E545C", VA = "0x19E545C")]
    public static void SearchEffectiveRange(
      BoardData board,
      UnitParameterData activator,
      GridData[] castFroms,
      GridData castTo,
      SkillParameterData skill,
      ref AttackableAreaSearcher effective,
      out TargetPair mainTarget,
      out Dictionary<int, List<TargetPair>> targetsInRange,
      out List<UnitParameterData> supportUnits,
      bool isReset = true)
    {
    }

    [Token(Token = "0x600D462")]
    [Address(RVA = "0x19E5C44", Offset = "0x19E5C44", VA = "0x19E5C44")]
    public static void SearchEffectiveRange(
      BoardData board,
      UnitParameterData activator,
      GridData[] castFroms,
      GridData castTo,
      SkillParameterData skill,
      ref AttackableAreaSearcher effective,
      out TargetPair mainTarget,
      out List<TargetPair> targetsInRange,
      out List<UnitParameterData> supportUnits,
      bool isReset = true)
    {
    }

    [Token(Token = "0x600D463")]
    [Address(RVA = "0x19E5550", Offset = "0x19E5550", VA = "0x19E5550")]
    public static void SearchEffectiveRange(
      BoardData board,
      UnitParameterData activator,
      GridData castFrom,
      GridData castTo,
      SkillParameterData skill,
      ref AttackableAreaSearcher effective,
      out TargetPair mainTarget,
      out Dictionary<int, List<TargetPair>> targetsByEffect,
      out List<UnitParameterData> supportUnits,
      bool isReset = true)
    {
    }

    [Token(Token = "0x600D464")]
    [Address(RVA = "0x19DF894", Offset = "0x19DF894", VA = "0x19DF894")]
    public static void SearchEffectiveRange(
      BoardData board,
      UnitParameterData activator,
      GridData castFrom,
      GridData castTo,
      SkillParameterData skill,
      ref AttackableAreaSearcher effective,
      out TargetPair mainTarget,
      out List<TargetPair> targetsInRange,
      out List<UnitParameterData> supportUnits,
      bool isReset = true)
    {
    }

    [Token(Token = "0x600D465")]
    [Address(RVA = "0x19E5D38", Offset = "0x19E5D38", VA = "0x19E5D38")]
    public static List<TargetPair> GetEffectableTargets(
      BoardData board,
      UnitParameterData activator,
      GridData castTo,
      EffectData effect,
      ref AttackableAreaSearcher effective)
    {
      return (List<TargetPair>) null;
    }

    [Token(Token = "0x600D466")]
    [Address(RVA = "0x19E61F4", Offset = "0x19E61F4", VA = "0x19E61F4")]
    public static void SearchEffectiveRange(
      GridData castFrom,
      GridData castTo,
      EffectData effect,
      ref AttackableAreaSearcher effectiveAreaSearcher)
    {
    }

    [Token(Token = "0x600D467")]
    [Address(RVA = "0x19E630C", Offset = "0x19E630C", VA = "0x19E630C")]
    public static void SearchEffectiveRange(
      BoardData board,
      UnitParameterData skillOwner,
      GridData castFrom,
      GridData castTo,
      EffectData effect,
      ref AttackableAreaSearcher effectiveAreaSearcher,
      out IReadOnlyList<TargetPair> targetsInRange)
    {
    }

    [Token(Token = "0x600D468")]
    [Address(RVA = "0x19E6378", Offset = "0x19E6378", VA = "0x19E6378")]
    public static void SearchEffectiveRange(
      BoardData board,
      BattlePlayerData actionPlayer,
      GridData castTo,
      SkillParameterData skill,
      ref AttackableAreaSearcher effective,
      out TargetPair mainTarget,
      out List<TargetPair> targetsInRange)
    {
    }

    [Token(Token = "0x600D469")]
    [Address(RVA = "0x19E6DA8", Offset = "0x19E6DA8", VA = "0x19E6DA8")]
    public static void SearchEffectiveRange(
      BoardData board,
      BattlePlayerData actionPlayer,
      GridData castFrom,
      GridData castTo,
      EffectData effect,
      ref AttackableAreaSearcher effectiveAreaSearcher,
      out IReadOnlyList<TargetPair> targetsInRange)
    {
    }

    [Token(Token = "0x600D46A")]
    [Address(RVA = "0x19E68F8", Offset = "0x19E68F8", VA = "0x19E68F8")]
    public static IReadOnlyList<TargetPair> GetEffectableTargets(
      BoardData board,
      AttackableAreaSearcher effectiveAreaSearcher,
      BattlePlayerData actionPlayer,
      EffectData skillEffect,
      GridData castTo)
    {
      return (IReadOnlyList<TargetPair>) null;
    }

    [Token(Token = "0x20022D1")]
    public class GridSearchComparer : IComparer<(int, int)>
    {
      [Token(Token = "0x600D46B")]
      [Address(RVA = "0x19E6E14", Offset = "0x19E6E14", VA = "0x19E6E14", Slot = "4")]
      public int Compare((int x, int y) a, (int x, int y) b) => new int();

      [Token(Token = "0x600D46C")]
      [Address(RVA = "0x19E6F94", Offset = "0x19E6F94", VA = "0x19E6F94")]
      public GridSearchComparer()
      {
      }
    }

    [Token(Token = "0x20022D2")]
    public class GridSearchSort : IComparer<Battle.RouteSearch.Node>, IComparer<GridData>
    {
      [Token(Token = "0x4009334")]
      [FieldOffset(Offset = "0x10")]
      private int rootX;
      [Token(Token = "0x4009335")]
      [FieldOffset(Offset = "0x14")]
      private int rootY;
      [Token(Token = "0x4009336")]
      [FieldOffset(Offset = "0x18")]
      private IComparer<(int, int)> comparer;

      [Token(Token = "0x600D46D")]
      [Address(RVA = "0x19E6F9C", Offset = "0x19E6F9C", VA = "0x19E6F9C")]
      public GridSearchSort(int rootX, int rootY)
      {
      }

      [Token(Token = "0x600D46E")]
      [Address(RVA = "0x19E701C", Offset = "0x19E701C", VA = "0x19E701C")]
      public GridSearchSort(Battle.RouteSearch.Node root)
      {
      }

      [Token(Token = "0x600D46F")]
      [Address(RVA = "0x19E70A8", Offset = "0x19E70A8", VA = "0x19E70A8")]
      public GridSearchSort(GridData root)
      {
      }

      [Token(Token = "0x600D470")]
      [Address(RVA = "0x19E7134", Offset = "0x19E7134", VA = "0x19E7134", Slot = "6")]
      public virtual int Compare(Battle.RouteSearch.Node a, Battle.RouteSearch.Node b) => new int();

      [Token(Token = "0x600D471")]
      [Address(RVA = "0x19E7264", Offset = "0x19E7264", VA = "0x19E7264", Slot = "5")]
      public int Compare(GridData a, GridData b) => new int();
    }

    [Token(Token = "0x20022D3")]
    public sealed class ShortestGridSearchSort : SearchUtility.GridSearchSort
    {
      [Token(Token = "0x4009337")]
      private const int ScoreOffset = 1000;

      [Token(Token = "0x600D472")]
      [Address(RVA = "0x19E7394", Offset = "0x19E7394", VA = "0x19E7394")]
      public ShortestGridSearchSort(int rootX, int rootY)
      {
      }

      [Token(Token = "0x600D473")]
      [Address(RVA = "0x19E7398", Offset = "0x19E7398", VA = "0x19E7398", Slot = "6")]
      public override int Compare(Battle.RouteSearch.Node a, Battle.RouteSearch.Node b)
      {
        return new int();
      }
    }
  }
}
