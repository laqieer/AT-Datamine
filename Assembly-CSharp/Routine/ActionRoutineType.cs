// Decompiled with JetBrains decompiler
// Type: Routine.ActionRoutineType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Routine
{
  [Token(Token = "0x200220F")]
  public enum ActionRoutineType
  {
    [Token(Token = "0x4008FD8")] Attack = 1,
    [Token(Token = "0x4008FDA")] AttackKillable = 2,
    [Token(Token = "0x4008FDB")] AttackPrevUnit = 9,
    [Token(Token = "0x4008FDC")] Stratagem = 49, // 0x00000031
    [Token(Token = "0x4008FDD")] StratagemBarrier = 54, // 0x00000036
    [Token(Token = "0x4008FDE")] Buff = 104, // 0x00000068
    [Token(Token = "0x4008FDF")] Debuff = 108, // 0x0000006C
    [Token(Token = "0x4008FE0")] Heal = 113, // 0x00000071
    [Token(Token = "0x4008FE1")] Move = 129, // 0x00000081
    [Token(Token = "0x4008FE2")] MoveTarget = 130, // 0x00000082
    [Token(Token = "0x4008FE3")] MoveDestPos = 144, // 0x00000090
    [Token(Token = "0x4008FE4")] MoveAlly = 145, // 0x00000091
    [Token(Token = "0x4008FE5")] InteractChest = 146, // 0x00000092
    [Token(Token = "0x4008FE6")] Interact = 147, // 0x00000093
    [Token(Token = "0x4008FE7")] Stay = 149, // 0x00000095
    [Token(Token = "0x4008FE8")] NormalAttack = 151, // 0x00000097
    [Token(Token = "0x4008FEA")] NormalAttackKillable = 152, // 0x00000098
    [Token(Token = "0x4008FEB")] NormalAttackCounter = 159, // 0x0000009F
    [Token(Token = "0x4008FEC")] AttackSkill = 161, // 0x000000A1
    [Token(Token = "0x4008FED")] AttackSkillPrevUnit = 167, // 0x000000A7
    [Token(Token = "0x4008FEE")] Fierce = 171, // 0x000000AB
    [Token(Token = "0x4008FEF")] MoveChest = 999, // 0x000003E7
    [Token(Token = "0x4008FF0")] ControlOnly = 1000, // 0x000003E8
    [Token(Token = "0x4008FD9")] AttackOp = 1001, // 0x000003E9
    [Token(Token = "0x4008FE9")] NormalAttackOp = 1151, // 0x0000047F
  }
}
