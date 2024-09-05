// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleLevelUpProcessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data;
using Battle.Data.Board;
using Battle.DuelScene;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002691")]
  public class BattleLevelUpProcessor
  {
    [Token(Token = "0x400A579")]
    [FieldOffset(Offset = "0x10")]
    private StoryBattleConfig config;
    [Token(Token = "0x400A57A")]
    [FieldOffset(Offset = "0x18")]
    private BoardData board;
    [Token(Token = "0x400A57B")]
    [FieldOffset(Offset = "0x20")]
    private IDirector mainDirector;
    [Token(Token = "0x400A57C")]
    [FieldOffset(Offset = "0x28")]
    private float backExpCorrection;
    [Token(Token = "0x400A57D")]
    [FieldOffset(Offset = "0x2C")]
    private int maxLevelDiffCorrection;
    [Token(Token = "0x400A57E")]
    [FieldOffset(Offset = "0x30")]
    private Decimal levelDiffCorrectionDivisor;
    [Token(Token = "0x400A57F")]
    [FieldOffset(Offset = "0x40")]
    private float gainExpCountAdjust;
    [Token(Token = "0x400A580")]
    [FieldOffset(Offset = "0x44")]
    private bool canGetStyleExp;
    [Token(Token = "0x400A581")]
    [FieldOffset(Offset = "0x45")]
    private bool canGetWeaponExp;
    [Token(Token = "0x400A582")]
    [FieldOffset(Offset = "0x48")]
    public Dictionary<int, int> UnitLevelReachedDic;

    [Token(Token = "0x600EEC3")]
    [Address(RVA = "0x444A4B8", Offset = "0x444A4B8", VA = "0x444A4B8")]
    private BattleLevelUpProcessor()
    {
    }

    [Token(Token = "0x600EEC4")]
    [Address(RVA = "0x444A534", Offset = "0x444A534", VA = "0x444A534")]
    public BattleLevelUpProcessor(
      StoryBattleConfig config,
      BoardData board,
      IDirector mainDirector,
      bool canGetStyleExp,
      bool canGetWeaponExp)
    {
    }

    [Token(Token = "0x600EEC5")]
    [Address(RVA = "0x444A6FC", Offset = "0x444A6FC", VA = "0x444A6FC")]
    public void ApplyBoard(BoardData board)
    {
    }

    [Token(Token = "0x600EEC6")]
    [Address(RVA = "0x444A71C", Offset = "0x444A71C", VA = "0x444A71C")]
    public List<BattleExpInfo> GainExp(UnitCommandBase command) => (List<BattleExpInfo>) null;

    [Token(Token = "0x600EEC7")]
    [Address(RVA = "0x444AA7C", Offset = "0x444AA7C", VA = "0x444AA7C")]
    private BattleExpInfo GetExpInfo(UnitCommandBase command) => (BattleExpInfo) null;

    [Token(Token = "0x600EEC8")]
    [Address(RVA = "0x444AF30", Offset = "0x444AF30", VA = "0x444AF30")]
    private BattleExpInfo GetExpInfo(SkillCommandBase command) => (BattleExpInfo) null;

    [Token(Token = "0x600EEC9")]
    [Address(RVA = "0x444ADF8", Offset = "0x444ADF8", VA = "0x444ADF8")]
    private BattleExpInfo GetExpInfo(DuelCommand command) => (BattleExpInfo) null;

    [Token(Token = "0x600EECA")]
    [Address(RVA = "0x444B044", Offset = "0x444B044", VA = "0x444B044")]
    private void CalcStyleExp(SkillCommandBase command, ref BattleExpInfo expInfo)
    {
    }

    [Token(Token = "0x600EECB")]
    [Address(RVA = "0x444B790", Offset = "0x444B790", VA = "0x444B790")]
    private void CalcStyleExpOnCounter(DuelData duelData, ref BattleExpInfo expInfo)
    {
    }

    [Token(Token = "0x600EECC")]
    [Address(RVA = "0x444BADC", Offset = "0x444BADC", VA = "0x444BADC")]
    private int GetExpBaseValueByDamage(
      UnitParameterData attacker,
      UnitParameterData target,
      int damage,
      bool isKill)
    {
      return new int();
    }

    [Token(Token = "0x600EECD")]
    [Address(RVA = "0x444B634", Offset = "0x444B634", VA = "0x444B634")]
    private void CalcWeaponExp(SkillCommandBase command, ref BattleExpInfo expInfo)
    {
    }

    [Token(Token = "0x600EECE")]
    [Address(RVA = "0x444B92C", Offset = "0x444B92C", VA = "0x444B92C")]
    private void CalcWeaponExpOnCounter(DuelData duelData, ref BattleExpInfo expInfo)
    {
    }

    [Token(Token = "0x600EECF")]
    [Address(RVA = "0x444AB54", Offset = "0x444AB54", VA = "0x444AB54")]
    private (bool, bool) ShowLevelUpEffect(BattleExpInfo front, BattleExpInfo back) => ();
  }
}
