// Decompiled with JetBrains decompiler
// Type: Routine.AttackKillableRoutine
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
  [Token(Token = "0x2002216")]
  public class AttackKillableRoutine : AttackRoutine
  {
    [Token(Token = "0x600CF9D")]
    [Address(RVA = "0x4CCA478", Offset = "0x4CCA478", VA = "0x4CCA478", Slot = "10")]
    protected override IReadOnlyList<CommandScore> CreateCommandScores(
      UnitParameterData activator,
      GridData moveTarget,
      WeaponParameterData weaponParam,
      SkillParameterData skillParam,
      UnitParameterData mainTarget)
    {
      return (IReadOnlyList<CommandScore>) null;
    }

    [Token(Token = "0x600CF9E")]
    [Address(RVA = "0x4CCAA94", Offset = "0x4CCAA94", VA = "0x4CCAA94")]
    public AttackKillableRoutine()
    {
    }
  }
}
