// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleWeaponProficiencyProcessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data.Board;
using Battle.DuelScene;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x20026B0")]
  public class BattleWeaponProficiencyProcessor
  {
    [Token(Token = "0x400A5E6")]
    [FieldOffset(Offset = "0x10")]
    private BoardData boardData;
    [Token(Token = "0x400A5E7")]
    private const int MaxGetWeaponProficiency = 2;

    [Token(Token = "0x600EF93")]
    [Address(RVA = "0x40DA8C4", Offset = "0x40DA8C4", VA = "0x40DA8C4")]
    public BattleWeaponProficiencyProcessor(BoardData board)
    {
    }

    [Token(Token = "0x600EF94")]
    [Address(RVA = "0x40DA8EC", Offset = "0x40DA8EC", VA = "0x40DA8EC")]
    public void ApplyBoard(BoardData board)
    {
    }

    [Token(Token = "0x600EF95")]
    [Address(RVA = "0x40DA8F4", Offset = "0x40DA8F4", VA = "0x40DA8F4")]
    public void GainWeaponProficiency(UnitCommandBase command)
    {
    }

    [Token(Token = "0x600EF96")]
    [Address(RVA = "0x40DA9C8", Offset = "0x40DA9C8", VA = "0x40DA9C8")]
    private void GetWpInfo(DuelCommand command)
    {
    }

    [Token(Token = "0x600EF97")]
    [Address(RVA = "0x40DAF3C", Offset = "0x40DAF3C", VA = "0x40DAF3C")]
    private void GetWpInfo(SkillCommandBase command)
    {
    }

    [Token(Token = "0x600EF98")]
    [Address(RVA = "0x40DB318", Offset = "0x40DB318", VA = "0x40DB318")]
    private List<DuelData> GetDuelDataList(SkillCommandBase command) => (List<DuelData>) null;

    [Token(Token = "0x600EF99")]
    [Address(RVA = "0x40DB4EC", Offset = "0x40DB4EC", VA = "0x40DB4EC")]
    private bool IsDamagedTarget(ActionTargetResultData t) => new bool();

    [Token(Token = "0x600EF9A")]
    [Address(RVA = "0x40DB4D0", Offset = "0x40DB4D0", VA = "0x40DB4D0")]
    private void AddAchieveWeaponProficiency(UnitParameterData unit, int value)
    {
    }
  }
}
