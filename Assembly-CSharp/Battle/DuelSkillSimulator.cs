// Decompiled with JetBrains decompiler
// Type: Battle.DuelSkillSimulator
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
  [Token(Token = "0x200229C")]
  public class DuelSkillSimulator : SkillSimulator
  {
    [Token(Token = "0x600D311")]
    [Address(RVA = "0x19D3ACC", Offset = "0x19D3ACC", VA = "0x19D3ACC")]
    public DuelSkillSimulator(
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

    [Token(Token = "0x600D312")]
    [Address(RVA = "0x19D3CA4", Offset = "0x19D3CA4", VA = "0x19D3CA4", Slot = "6")]
    protected override void Predict()
    {
    }
  }
}
