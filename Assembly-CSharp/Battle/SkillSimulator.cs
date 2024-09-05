// Decompiled with JetBrains decompiler
// Type: Battle.SkillSimulator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle
{
  [Token(Token = "0x20022A2")]
  public class SkillSimulator : SimulatorBase
  {
    [Token(Token = "0x40091FE")]
    [FieldOffset(Offset = "0x38")]
    private int mainTargetId;
    [Token(Token = "0x40091FF")]
    [FieldOffset(Offset = "0x3C")]
    private (int x, int y) mainTargetGridCoord;
    [Token(Token = "0x4009200")]
    [FieldOffset(Offset = "0x48")]
    private List<(int id, int x, int y)> targetInfos;
    [Token(Token = "0x4009201")]
    [FieldOffset(Offset = "0x50")]
    private List<int> supportIds;
    [Token(Token = "0x4009202")]
    [FieldOffset(Offset = "0x58")]
    private int usingWeaponIndex;
    [Token(Token = "0x4009203")]
    [FieldOffset(Offset = "0x5C")]
    private int usingSkillParamId;

    [Token(Token = "0x17002DC8")]
    protected UnitParameterData MainTarget
    {
      [Token(Token = "0x600D338"), Address(RVA = "0x19D54B0", Offset = "0x19D54B0", VA = "0x19D54B0")] get
      {
        return (UnitParameterData) null;
      }
      [Token(Token = "0x600D339"), Address(RVA = "0x19D54F4", Offset = "0x19D54F4", VA = "0x19D54F4")] set
      {
      }
    }

    [Token(Token = "0x17002DC9")]
    protected GridData MainTargetGrid
    {
      [Token(Token = "0x600D33A"), Address(RVA = "0x19D4440", Offset = "0x19D4440", VA = "0x19D4440")] get
      {
        return (GridData) null;
      }
      [Token(Token = "0x600D33B"), Address(RVA = "0x19D5528", Offset = "0x19D5528", VA = "0x19D5528")] set
      {
      }
    }

    [Token(Token = "0x17002DCA")]
    protected List<TargetPair> Targets
    {
      [Token(Token = "0x600D33C"), Address(RVA = "0x19D4188", Offset = "0x19D4188", VA = "0x19D4188")] get
      {
        return (List<TargetPair>) null;
      }
      [Token(Token = "0x600D33D"), Address(RVA = "0x19D5544", Offset = "0x19D5544", VA = "0x19D5544")] set
      {
      }
    }

    [Token(Token = "0x17002DCB")]
    protected List<UnitParameterData> Supporters
    {
      [Token(Token = "0x600D33E"), Address(RVA = "0x19D4510", Offset = "0x19D4510", VA = "0x19D4510")] get
      {
        return (List<UnitParameterData>) null;
      }
      [Token(Token = "0x600D33F"), Address(RVA = "0x19D57B0", Offset = "0x19D57B0", VA = "0x19D57B0")] set
      {
      }
    }

    [Token(Token = "0x17002DCC")]
    protected WeaponParameterData UsingWeaponParam
    {
      [Token(Token = "0x600D340"), Address(RVA = "0x19D446C", Offset = "0x19D446C", VA = "0x19D446C")] get
      {
        return (WeaponParameterData) null;
      }
      [Token(Token = "0x600D341"), Address(RVA = "0x19D59A8", Offset = "0x19D59A8", VA = "0x19D59A8")] set
      {
      }
    }

    [Token(Token = "0x17002DCD")]
    protected SkillParameterData UsingSkillParam
    {
      [Token(Token = "0x600D342"), Address(RVA = "0x19D44CC", Offset = "0x19D44CC", VA = "0x19D44CC")] get
      {
        return (SkillParameterData) null;
      }
      [Token(Token = "0x600D343"), Address(RVA = "0x19D5A88", Offset = "0x19D5A88", VA = "0x19D5A88")] set
      {
      }
    }

    [Token(Token = "0x600D344")]
    [Address(RVA = "0x19D3AD8", Offset = "0x19D3AD8", VA = "0x19D3AD8")]
    public SkillSimulator(
      BattleCore core,
      UnitParameterData actionUnit,
      GridData castFrom,
      List<TargetPair> attackTargets,
      GridData castTo,
      WeaponParameterData weaponParam,
      SkillParameterData skillParam,
      List<UnitParameterData> supporters)
    {
    }

    [Token(Token = "0x600D345")]
    [Address(RVA = "0x19D5AB0", Offset = "0x19D5AB0", VA = "0x19D5AB0", Slot = "4")]
    public override void PrepareSimulate()
    {
    }

    [Token(Token = "0x600D346")]
    [Address(RVA = "0x19D5AB4", Offset = "0x19D5AB4", VA = "0x19D5AB4", Slot = "5")]
    public override void Simulate()
    {
    }

    [Token(Token = "0x600D347")]
    [Address(RVA = "0x19D5AC0", Offset = "0x19D5AC0", VA = "0x19D5AC0", Slot = "6")]
    protected virtual void Predict()
    {
    }

    [Token(Token = "0x20022A3")]
    protected delegate ConditionParam CreateConditionParamDelegate(
      UnitParameterData triggerSkillActivator,
      UnitParameterData target);
  }
}
