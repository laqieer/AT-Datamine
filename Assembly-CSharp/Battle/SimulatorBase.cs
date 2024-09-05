// Decompiled with JetBrains decompiler
// Type: Battle.SimulatorBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Logic.Prediction;
using Battle.Process;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle
{
  [Token(Token = "0x200229F")]
  public abstract class SimulatorBase
  {
    [Token(Token = "0x40091F6")]
    [FieldOffset(Offset = "0x10")]
    private int actionUnitId;
    [Token(Token = "0x40091F7")]
    [FieldOffset(Offset = "0x14")]
    private (int x, int y) actionUnitGridCoord;
    [Token(Token = "0x40091F9")]
    [FieldOffset(Offset = "0x28")]
    protected List<PredictionResult> GeneratedResults;

    [Token(Token = "0x17002DC0")]
    protected UnitParameterData ActionUnit
    {
      [Token(Token = "0x600D320"), Address(RVA = "0x19D4144", Offset = "0x19D4144", VA = "0x19D4144")] get
      {
        return (UnitParameterData) null;
      }
      [Token(Token = "0x600D321"), Address(RVA = "0x19D4E00", Offset = "0x19D4E00", VA = "0x19D4E00")] set
      {
      }
    }

    [Token(Token = "0x17002DC1")]
    protected GridData ActionUnitGrid
    {
      [Token(Token = "0x600D322"), Address(RVA = "0x19D4854", Offset = "0x19D4854", VA = "0x19D4854")] get
      {
        return (GridData) null;
      }
      [Token(Token = "0x600D323"), Address(RVA = "0x19D4CA0", Offset = "0x19D4CA0", VA = "0x19D4CA0")] set
      {
      }
    }

    [Token(Token = "0x17002DC2")]
    protected BattleCore Core
    {
      [Token(Token = "0x600D324"), Address(RVA = "0x19D4E34", Offset = "0x19D4E34", VA = "0x19D4E34")] get
      {
        return (BattleCore) null;
      }
      [Token(Token = "0x600D325"), Address(RVA = "0x19D4E3C", Offset = "0x19D4E3C", VA = "0x19D4E3C")] set
      {
      }
    }

    [Token(Token = "0x17002DC3")]
    protected BoardData CurrentBoard
    {
      [Token(Token = "0x600D326"), Address(RVA = "0x19D4748", Offset = "0x19D4748", VA = "0x19D4748")] get
      {
        return (BoardData) null;
      }
    }

    [Token(Token = "0x17002DC4")]
    public SimulatorBase.ResultInfo Result
    {
      [Token(Token = "0x600D327"), Address(RVA = "0x19D4E44", Offset = "0x19D4E44", VA = "0x19D4E44")] get
      {
        return (SimulatorBase.ResultInfo) null;
      }
      [Token(Token = "0x600D328"), Address(RVA = "0x19D4E4C", Offset = "0x19D4E4C", VA = "0x19D4E4C")] protected set
      {
      }
    }

    [Token(Token = "0x600D329")]
    [Address(RVA = "0x19D4980", Offset = "0x19D4980", VA = "0x19D4980")]
    public SimulatorBase(BattleCore core, UnitParameterData actionUnit)
    {
    }

    [Token(Token = "0x600D32A")]
    [Address(RVA = "0x19D4A28", Offset = "0x19D4A28", VA = "0x19D4A28")]
    protected void CreateResultInfo()
    {
    }

    [Token(Token = "0x600D32B")]
    public abstract void PrepareSimulate();

    [Token(Token = "0x600D32C")]
    public abstract void Simulate();

    [Token(Token = "0x20022A0")]
    public class ResultInfo
    {
      [Token(Token = "0x40091FD")]
      [FieldOffset(Offset = "0x20")]
      private Dictionary<int, UnitParameterChange> result;

      [Token(Token = "0x17002DC5")]
      public int ActionUnitParamId
      {
        [Token(Token = "0x600D32D"), Address(RVA = "0x19D4F54", Offset = "0x19D4F54", VA = "0x19D4F54")] get
        {
          return new int();
        }
        [Token(Token = "0x600D32E"), Address(RVA = "0x19D4F5C", Offset = "0x19D4F5C", VA = "0x19D4F5C")] private set
        {
        }
      }

      [Token(Token = "0x17002DC6")]
      public (int x, int y) ActionUnitGridCoord
      {
        [Token(Token = "0x600D32F"), Address(RVA = "0x19D4F64", Offset = "0x19D4F64", VA = "0x19D4F64")] get
        {
          return ();
        }
        [Token(Token = "0x600D330"), Address(RVA = "0x19D4F6C", Offset = "0x19D4F6C", VA = "0x19D4F6C")] private set
        {
        }
      }

      [Token(Token = "0x17002DC7")]
      public List<(int unitParamId, UnitParameterChange paramChange)> Params
      {
        [Token(Token = "0x600D331"), Address(RVA = "0x19D4F74", Offset = "0x19D4F74", VA = "0x19D4F74")] get
        {
          return (List<(int, UnitParameterChange)>) null;
        }
      }

      [Token(Token = "0x600D332")]
      [Address(RVA = "0x19D4E54", Offset = "0x19D4E54", VA = "0x19D4E54")]
      public ResultInfo(UnitParameterData actionUnit, GridData actionUnitGrid)
      {
      }

      [Token(Token = "0x600D333")]
      [Address(RVA = "0x19D4764", Offset = "0x19D4764", VA = "0x19D4764")]
      public void Add(UnitParameterData unit, UnitParameterChange parameterChange)
      {
      }
    }
  }
}
