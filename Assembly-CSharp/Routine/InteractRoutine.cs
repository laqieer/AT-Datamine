// Decompiled with JetBrains decompiler
// Type: Routine.InteractRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Battle.Score;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002234")]
  public class InteractRoutine : ActionRoutine
  {
    [Token(Token = "0x4009069")]
    [FieldOffset(Offset = "0x60")]
    protected readonly List<InteractRoutine.CachedInteractableInfo> InteractableList;

    [Token(Token = "0x17002D4C")]
    protected InteractArg Arg
    {
      [Token(Token = "0x600D024"), Address(RVA = "0x4CD2F7C", Offset = "0x4CD2F7C", VA = "0x4CD2F7C")] get
      {
        return (InteractArg) null;
      }
      [Token(Token = "0x600D025"), Address(RVA = "0x4CD2F84", Offset = "0x4CD2F84", VA = "0x4CD2F84")] set
      {
      }
    }

    [Token(Token = "0x17002D4D")]
    protected InteractRoutineValidator Validator
    {
      [Token(Token = "0x600D026"), Address(RVA = "0x4CD2F8C", Offset = "0x4CD2F8C", VA = "0x4CD2F8C")] get
      {
        return (InteractRoutineValidator) null;
      }
      [Token(Token = "0x600D027"), Address(RVA = "0x4CD2F94", Offset = "0x4CD2F94", VA = "0x4CD2F94")] set
      {
      }
    }

    [Token(Token = "0x600D028")]
    [Address(RVA = "0x4CD2F9C", Offset = "0x4CD2F9C", VA = "0x4CD2F9C", Slot = "4")]
    public override List<CommandScore> SimulateAction(
      BattleCore core,
      int actionUnitId,
      int requiredHit,
      int[] arg,
      int[] preference)
    {
      return (List<CommandScore>) null;
    }

    [Token(Token = "0x600D029")]
    [Address(RVA = "0x4CD350C", Offset = "0x4CD350C", VA = "0x4CD350C", Slot = "7")]
    protected override void SetValidator(UnitParameterData activator)
    {
    }

    [Token(Token = "0x600D02A")]
    [Address(RVA = "0x4CD3618", Offset = "0x4CD3618", VA = "0x4CD3618", Slot = "8")]
    protected override bool Executable(UnitParameterData activator) => new bool();

    [Token(Token = "0x600D02B")]
    [Address(RVA = "0x4CD4264", Offset = "0x4CD4264", VA = "0x4CD4264", Slot = "6")]
    protected override void SetArg(int[] arg, int[] preference)
    {
    }

    [Token(Token = "0x600D02C")]
    [Address(RVA = "0x4CD42D4", Offset = "0x4CD42D4", VA = "0x4CD42D4", Slot = "9")]
    protected override List<(int, int)> GetMoveGridList() => (List<(int, int)>) null;

    [Token(Token = "0x600D02D")]
    [Address(RVA = "0x4CD4304", Offset = "0x4CD4304", VA = "0x4CD4304")]
    protected int SortInteractableWay(
      InteractRoutine.CachedInteractableInfo a,
      InteractRoutine.CachedInteractableInfo b)
    {
      return new int();
    }

    [Token(Token = "0x600D02E")]
    [Address(RVA = "0x4CD2F00", Offset = "0x4CD2F00", VA = "0x4CD2F00")]
    public InteractRoutine()
    {
    }

    [Token(Token = "0x2002235")]
    public struct CachedInteractableInfo
    {
      [Token(Token = "0x400906A")]
      [FieldOffset(Offset = "0x0")]
      public (int x, int y) interactFrom;
      [Token(Token = "0x400906B")]
      [FieldOffset(Offset = "0x8")]
      public (int x, int y) interactTo;
      [Token(Token = "0x400906C")]
      [FieldOffset(Offset = "0x10")]
      public int way;

      [Token(Token = "0x600D02F")]
      [Address(RVA = "0x4CD4154", Offset = "0x4CD4154", VA = "0x4CD4154")]
      public CachedInteractableInfo(int fromX, int fromY, int toX, int toY, int way)
      {
      }
    }
  }
}
