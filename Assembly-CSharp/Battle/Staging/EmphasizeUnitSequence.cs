// Decompiled with JetBrains decompiler
// Type: Battle.Staging.EmphasizeUnitSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200257B")]
  public class EmphasizeUnitSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A100")]
    [FieldOffset(Offset = "0x10")]
    private IDirector director;
    [Token(Token = "0x400A101")]
    [FieldOffset(Offset = "0x18")]
    private IReadOnlyList<UnitParameterData> onBoardUnits;
    [Token(Token = "0x400A102")]
    [FieldOffset(Offset = "0x20")]
    private IReadOnlyList<UnitParameterData> targets;

    [Token(Token = "0x600E73B")]
    [Address(RVA = "0x487C924", Offset = "0x487C924", VA = "0x487C924")]
    public static EmphasizeUnitSequence Create(
      BoardData board,
      IDirector director,
      IReadOnlyList<UnitParameterData> targets)
    {
      return (EmphasizeUnitSequence) null;
    }

    [Token(Token = "0x17003188")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E73C"), Address(RVA = "0x487CAA8", Offset = "0x487CAA8", VA = "0x487CAA8", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E73D"), Address(RVA = "0x487CAB0", Offset = "0x487CAB0", VA = "0x487CAB0")] private set
      {
      }
    }

    [Token(Token = "0x600E73E")]
    [Address(RVA = "0x487CAA0", Offset = "0x487CAA0", VA = "0x487CAA0")]
    private EmphasizeUnitSequence()
    {
    }

    [Token(Token = "0x600E73F")]
    [Address(RVA = "0x487CABC", Offset = "0x487CABC", VA = "0x487CABC", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E740")]
    [Address(RVA = "0x487D264", Offset = "0x487D264", VA = "0x487D264", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E741")]
    [Address(RVA = "0x487D270", Offset = "0x487D270", VA = "0x487D270", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E742")]
    [Address(RVA = "0x487D27C", Offset = "0x487D27C", VA = "0x487D27C", Slot = "6")]
    public void Abort()
    {
    }
  }
}
