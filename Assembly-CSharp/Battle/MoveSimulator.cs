// Decompiled with JetBrains decompiler
// Type: Battle.MoveSimulator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;

#nullable disable
namespace Battle
{
  [Token(Token = "0x200229E")]
  public class MoveSimulator : SimulatorBase
  {
    [Token(Token = "0x40091F4")]
    [FieldOffset(Offset = "0x38")]
    private (int x, int y) moveTargetGridCoord;
    [Token(Token = "0x40091F5")]
    [FieldOffset(Offset = "0x40")]
    private int moveDistance;

    [Token(Token = "0x17002DBF")]
    private GridData MoveTargetGrid
    {
      [Token(Token = "0x600D31B"), Address(RVA = "0x19D4BF0", Offset = "0x19D4BF0", VA = "0x19D4BF0")] get
      {
        return (GridData) null;
      }
      [Token(Token = "0x600D31C"), Address(RVA = "0x19D4C1C", Offset = "0x19D4C1C", VA = "0x19D4C1C")] set
      {
      }
    }

    [Token(Token = "0x600D31D")]
    [Address(RVA = "0x19D4C38", Offset = "0x19D4C38", VA = "0x19D4C38")]
    public MoveSimulator(BattleCore core, UnitParameterData actionUnit, GridData moveTo)
    {
    }

    [Token(Token = "0x600D31E")]
    [Address(RVA = "0x19D4CBC", Offset = "0x19D4CBC", VA = "0x19D4CBC", Slot = "4")]
    public override void PrepareSimulate()
    {
    }

    [Token(Token = "0x600D31F")]
    [Address(RVA = "0x19D4CC0", Offset = "0x19D4CC0", VA = "0x19D4CC0", Slot = "5")]
    public override void Simulate()
    {
    }
  }
}
