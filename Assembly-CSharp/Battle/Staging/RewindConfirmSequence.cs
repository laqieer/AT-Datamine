// Decompiled with JetBrains decompiler
// Type: Battle.Staging.RewindConfirmSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Battle.UI.Rewind;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x20025B7")]
  public class RewindConfirmSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A243")]
    [FieldOffset(Offset = "0x18")]
    private IDirector mainDirector;
    [Token(Token = "0x400A244")]
    [FieldOffset(Offset = "0x20")]
    private BattleCore core;
    [Token(Token = "0x400A245")]
    [FieldOffset(Offset = "0x28")]
    private BattleRewindManager.PanelType panelType;
    [Token(Token = "0x400A246")]
    [FieldOffset(Offset = "0x30")]
    private List<UnitParameterData> dieUnits;
    [Token(Token = "0x400A247")]
    [FieldOffset(Offset = "0x38")]
    private int prevRollbackCount;

    [Token(Token = "0x170031B1")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E8D5"), Address(RVA = "0x4C459B8", Offset = "0x4C459B8", VA = "0x4C459B8", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E8D6"), Address(RVA = "0x4C459C0", Offset = "0x4C459C0", VA = "0x4C459C0")] private set
      {
      }
    }

    [Token(Token = "0x170031B2")]
    public bool IsRollBackExecuted
    {
      [Token(Token = "0x600E8D7"), Address(RVA = "0x4C459CC", Offset = "0x4C459CC", VA = "0x4C459CC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E8D8")]
    [Address(RVA = "0x4C459FC", Offset = "0x4C459FC", VA = "0x4C459FC")]
    private RewindConfirmSequence()
    {
    }

    [Token(Token = "0x600E8D9")]
    [Address(RVA = "0x4C45A04", Offset = "0x4C45A04", VA = "0x4C45A04")]
    public static RewindConfirmSequence Create(
      IDirector mainDirector,
      BattleCore core,
      BattleRewindManager.PanelType panelType,
      List<UnitParameterData> dieUnits = null)
    {
      return (RewindConfirmSequence) null;
    }

    [Token(Token = "0x600E8DA")]
    [Address(RVA = "0x4C45AA0", Offset = "0x4C45AA0", VA = "0x4C45AA0", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E8DB")]
    [Address(RVA = "0x4C45E58", Offset = "0x4C45E58", VA = "0x4C45E58", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E8DC")]
    [Address(RVA = "0x4C45F28", Offset = "0x4C45F28", VA = "0x4C45F28", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E8DD")]
    [Address(RVA = "0x4C4605C", Offset = "0x4C4605C", VA = "0x4C4605C", Slot = "6")]
    public void Abort()
    {
    }
  }
}
