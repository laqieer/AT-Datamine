// Decompiled with JetBrains decompiler
// Type: Routine.NormalAttackKillableRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Score;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002251")]
  public class NormalAttackKillableRoutine : NormalAttackRoutine
  {
    [Token(Token = "0x600D093")]
    [Address(RVA = "0x4CDA4C4", Offset = "0x4CDA4C4", VA = "0x4CDA4C4", Slot = "10")]
    protected override IReadOnlyList<CommandScore> CreateCommandScores(
      UnitParameterData activator,
      GridData moveTarget,
      WeaponParameterData weaponParam,
      SkillParameterData skillParam,
      UnitParameterData mainTarget)
    {
      return (IReadOnlyList<CommandScore>) null;
    }

    [Token(Token = "0x600D094")]
    [Address(RVA = "0x4CDAAE0", Offset = "0x4CDAAE0", VA = "0x4CDAAE0")]
    public NormalAttackKillableRoutine()
    {
    }
  }
}
