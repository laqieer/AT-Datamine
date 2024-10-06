// Decompiled with JetBrains decompiler
// Type: Battle.Command.InteractCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024AC")]
  public sealed class InteractCommand : UnitCommandBase
  {
    [Token(Token = "0x17003053")]
    public override CommandType CommandType
    {
      [Token(Token = "0x600E153"), Address(RVA = "0x425C64C", Offset = "0x425C64C", VA = "0x425C64C", Slot = "10")] get
      {
        return new CommandType();
      }
    }

    [Token(Token = "0x17003054")]
    public FacilityData TargetFacility
    {
      [Token(Token = "0x600E154"), Address(RVA = "0x425C654", Offset = "0x425C654", VA = "0x425C654")] get
      {
        return (FacilityData) null;
      }
      [Token(Token = "0x600E155"), Address(RVA = "0x425C65C", Offset = "0x425C65C", VA = "0x425C65C")] private set
      {
      }
    }

    [Token(Token = "0x17003055")]
    public GridData TargetGrid
    {
      [Token(Token = "0x600E156"), Address(RVA = "0x425C664", Offset = "0x425C664", VA = "0x425C664")] get
      {
        return (GridData) null;
      }
      [Token(Token = "0x600E157"), Address(RVA = "0x425C66C", Offset = "0x425C66C", VA = "0x425C66C")] private set
      {
      }
    }

    [Token(Token = "0x600E158")]
    [Address(RVA = "0x425C674", Offset = "0x425C674", VA = "0x425C674")]
    public InteractCommand(
      BattleCore core,
      UnitParameterData unit,
      FacilityData facility,
      GridData targetGrid)
    {
    }

    [Token(Token = "0x600E159")]
    [Address(RVA = "0x425C6B8", Offset = "0x425C6B8", VA = "0x425C6B8", Slot = "4")]
    public override bool Validate() => new bool();

    [Token(Token = "0x600E15A")]
    [Address(RVA = "0x425C818", Offset = "0x425C818", VA = "0x425C818", Slot = "5")]
    public override void Prepare()
    {
    }

    [Token(Token = "0x600E15B")]
    [Address(RVA = "0x425C848", Offset = "0x425C848", VA = "0x425C848", Slot = "6")]
    protected override void ExecuteInternal()
    {
    }

    [Token(Token = "0x600E15C")]
    [Address(RVA = "0x425CA1C", Offset = "0x425CA1C", VA = "0x425CA1C")]
    private void ExecInternalEffectSequence(List<FacilityData> activates)
    {
    }

    [Token(Token = "0x600E15D")]
    [Address(RVA = "0x425D270", Offset = "0x425D270", VA = "0x425D270")]
    private void PlayVoice()
    {
    }

    [Token(Token = "0x600E15E")]
    [Address(RVA = "0x425D468", Offset = "0x425D468", VA = "0x425D468", Slot = "8")]
    protected override void CompleteInternal()
    {
    }

    [Token(Token = "0x600E15F")]
    [Address(RVA = "0x425D57C", Offset = "0x425D57C", VA = "0x425D57C", Slot = "9")]
    protected override void CanceledInternal()
    {
    }
  }
}
