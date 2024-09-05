// Decompiled with JetBrains decompiler
// Type: Routine.Optimized.AttackRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Score;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Routine.Optimized
{
  [Token(Token = "0x200225E")]
  public class AttackRoutine : Routine.AttackRoutine
  {
    [Token(Token = "0x600D0C6")]
    [Address(RVA = "0x4CDCC84", Offset = "0x4CDCC84", VA = "0x4CDCC84", Slot = "10")]
    protected override IReadOnlyList<CommandScore> CreateCommandScores(
      UnitParameterData activator,
      GridData moveTarget,
      WeaponParameterData weaponParam,
      SkillParameterData skillParam,
      UnitParameterData mainTarget)
    {
      return (IReadOnlyList<CommandScore>) null;
    }

    [Token(Token = "0x600D0C7")]
    [Address(RVA = "0x4CDE598", Offset = "0x4CDE598", VA = "0x4CDE598")]
    public AttackRoutine()
    {
    }
  }
}
