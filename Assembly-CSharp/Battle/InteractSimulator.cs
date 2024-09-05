// Decompiled with JetBrains decompiler
// Type: Battle.InteractSimulator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;

#nullable disable
namespace Battle
{
  [Token(Token = "0x200229D")]
  public class InteractSimulator : SimulatorBase
  {
    [Token(Token = "0x40091F2")]
    [FieldOffset(Offset = "0x38")]
    private (int x, int y) moveTargetGridCoord;
    [Token(Token = "0x40091F3")]
    [FieldOffset(Offset = "0x40")]
    private (int x, int y) interactGridCoord;

    [Token(Token = "0x17002DBC")]
    private GridData MoveTargetGrid
    {
      [Token(Token = "0x600D313"), Address(RVA = "0x19D4880", Offset = "0x19D4880", VA = "0x19D4880")] get
      {
        return (GridData) null;
      }
      [Token(Token = "0x600D314"), Address(RVA = "0x19D48AC", Offset = "0x19D48AC", VA = "0x19D48AC")] set
      {
      }
    }

    [Token(Token = "0x17002DBD")]
    private GridData InteractGrid
    {
      [Token(Token = "0x600D315"), Address(RVA = "0x19D48C8", Offset = "0x19D48C8", VA = "0x19D48C8")] get
      {
        return (GridData) null;
      }
      [Token(Token = "0x600D316"), Address(RVA = "0x19D48F4", Offset = "0x19D48F4", VA = "0x19D48F4")] set
      {
      }
    }

    [Token(Token = "0x17002DBE")]
    private FacilityData Facility
    {
      [Token(Token = "0x600D317"), Address(RVA = "0x19D4910", Offset = "0x19D4910", VA = "0x19D4910")] get
      {
        return (FacilityData) null;
      }
    }

    [Token(Token = "0x600D318")]
    [Address(RVA = "0x19D492C", Offset = "0x19D492C", VA = "0x19D492C")]
    public InteractSimulator(
      BattleCore core,
      UnitParameterData actionUnit,
      GridData moveTo,
      GridData interactGrid)
    {
    }

    [Token(Token = "0x600D319")]
    [Address(RVA = "0x19D4A24", Offset = "0x19D4A24", VA = "0x19D4A24", Slot = "4")]
    public override void PrepareSimulate()
    {
    }

    [Token(Token = "0x600D31A")]
    [Address(RVA = "0x19D4AB0", Offset = "0x19D4AB0", VA = "0x19D4AB0", Slot = "5")]
    public override void Simulate()
    {
    }
  }
}
