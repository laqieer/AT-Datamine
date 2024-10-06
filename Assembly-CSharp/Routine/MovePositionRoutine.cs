// Decompiled with JetBrains decompiler
// Type: Routine.MovePositionRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Battle.RouteSearch;
using Battle.Score;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Routine
{
  [Token(Token = "0x200224A")]
  public class MovePositionRoutine : MoveRoutine
  {
    [Token(Token = "0x400908A")]
    [FieldOffset(Offset = "0x60")]
    private ShortestPathSearcher shortest;
    [Token(Token = "0x400908B")]
    [FieldOffset(Offset = "0x68")]
    protected List<(int x, int y)> destList;

    [Token(Token = "0x600D076")]
    [Address(RVA = "0x4CD8924", Offset = "0x4CD8924", VA = "0x4CD8924", Slot = "4")]
    public override List<CommandScore> SimulateAction(
      BattleCore core,
      int actionUnitId,
      int requiredHit,
      int[] arg,
      int[] preference)
    {
      return (List<CommandScore>) null;
    }

    [Token(Token = "0x600D077")]
    [Address(RVA = "0x4CD91BC", Offset = "0x4CD91BC", VA = "0x4CD91BC", Slot = "5")]
    protected override void Initialize(
      BattleCore core,
      int actionUnitId,
      int requiredHit,
      int[] arg,
      int[] preference)
    {
    }

    [Token(Token = "0x600D078")]
    [Address(RVA = "0x4CD7DEC", Offset = "0x4CD7DEC", VA = "0x4CD7DEC", Slot = "8")]
    protected override bool Executable(UnitParameterData activator) => new bool();

    [Token(Token = "0x600D079")]
    [Address(RVA = "0x4CD9274", Offset = "0x4CD9274", VA = "0x4CD9274", Slot = "6")]
    protected override void SetArg(int[] arg, int[] preference)
    {
    }

    [Token(Token = "0x600D07A")]
    [Address(RVA = "0x4CD8F88", Offset = "0x4CD8F88", VA = "0x4CD8F88")]
    private int GetDestWay(UnitParameterData unit, int x, int y) => new int();

    [Token(Token = "0x600D07B")]
    [Address(RVA = "0x4CD81B0", Offset = "0x4CD81B0", VA = "0x4CD81B0")]
    public MovePositionRoutine()
    {
    }

    [Token(Token = "0x200224B")]
    private class MovePositionArg : MoveArg
    {
      [Token(Token = "0x600D07C")]
      [Address(RVA = "0x4CD931C", Offset = "0x4CD931C", VA = "0x4CD931C")]
      public MovePositionArg(int[] arg)
      {
      }

      [Token(Token = "0x600D07D")]
      [Address(RVA = "0x4CD9328", Offset = "0x4CD9328", VA = "0x4CD9328", Slot = "4")]
      protected override void SetArg(int[] arg)
      {
      }

      [Token(Token = "0x200224C")]
      private new enum ContextIndex
      {
        [Token(Token = "0x400908D")] ActionSetting,
        [Token(Token = "0x400908E")] MoveSetting,
        [Token(Token = "0x400908F")] DestPosX,
        [Token(Token = "0x4009090")] DestPosY,
        [Token(Token = "0x4009091")] DestSizeX,
        [Token(Token = "0x4009092")] DestSizeY,
      }
    }
  }
}
