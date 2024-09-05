// Decompiled with JetBrains decompiler
// Type: Battle.SimulatorFactory
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
  [Token(Token = "0x20022A1")]
  public static class SimulatorFactory
  {
    [Token(Token = "0x600D334")]
    [Address(RVA = "0x19D51AC", Offset = "0x19D51AC", VA = "0x19D51AC")]
    public static SimulatorBase CreateStaySimulator(
      BattleCore core,
      UnitParameterData actionUnit,
      GridData moveTarget)
    {
      return (SimulatorBase) null;
    }

    [Token(Token = "0x600D335")]
    [Address(RVA = "0x19D52C8", Offset = "0x19D52C8", VA = "0x19D52C8")]
    public static SimulatorBase CreateMoveSimulator(
      BattleCore core,
      UnitParameterData actionUnit,
      GridData moveTarget)
    {
      return (SimulatorBase) null;
    }

    [Token(Token = "0x600D336")]
    [Address(RVA = "0x19D5340", Offset = "0x19D5340", VA = "0x19D5340")]
    public static SimulatorBase CreateSkillSimulator(
      BattleCore core,
      UnitParameterData actionUnit,
      GridData moveTo,
      List<TargetPair> attackTargets,
      GridData castTo,
      WeaponParameterData weaponParam,
      SkillParameterData skillParam,
      List<UnitParameterData> supporters)
    {
      return (SimulatorBase) null;
    }

    [Token(Token = "0x600D337")]
    [Address(RVA = "0x19D5428", Offset = "0x19D5428", VA = "0x19D5428")]
    public static SimulatorBase CreateInteractSimulator(
      BattleCore core,
      UnitParameterData actionUnit,
      GridData moveTo,
      GridData interactTo)
    {
      return (SimulatorBase) null;
    }
  }
}
