// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleEffectLogCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data;
using Battle.Data.Board;
using Battle.DuelScene;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002698")]
  public class BattleEffectLogCreator : BattleLogCreator
  {
    [Token(Token = "0x600EEEF")]
    [Address(RVA = "0x444E860", Offset = "0x444E860", VA = "0x444E860")]
    public BattleEffectLogCreator(
      IReadOnlyDictionary<int, BattleLogTextFormatData> dic,
      BoardData boardData)
    {
    }

    [Token(Token = "0x600EEF0")]
    [Address(RVA = "0x444E958", Offset = "0x444E958", VA = "0x444E958")]
    public List<BattleLogData> CheckActionEffect(ActionData action) => (List<BattleLogData>) null;

    [Token(Token = "0x600EEF1")]
    [Address(RVA = "0x444ED30", Offset = "0x444ED30", VA = "0x444ED30")]
    public List<BattleLogData> CheckActionEffect(ActionData action, ActionTargetResultData target)
    {
      return (List<BattleLogData>) null;
    }

    [Token(Token = "0x600EEF2")]
    [Address(RVA = "0x444FA2C", Offset = "0x444FA2C", VA = "0x444FA2C")]
    public List<BattleLogData> CreateLandEffectLog(
      UnitParameterChange paramChange,
      UnitParameterData unit,
      string landName = "")
    {
      return (List<BattleLogData>) null;
    }

    [Token(Token = "0x600EEF3")]
    [Address(RVA = "0x444FCB8", Offset = "0x444FCB8", VA = "0x444FCB8")]
    public List<BattleLogData> CreateTakeBadStatusDamageLog(
      UnitParameterChange target,
      UnitParameterData unit)
    {
      return (List<BattleLogData>) null;
    }

    [Token(Token = "0x600EEF4")]
    [Address(RVA = "0x444F8D0", Offset = "0x444F8D0", VA = "0x444F8D0")]
    public void CreateEffectLog(UnitParameterChange paramChange, UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EEF5")]
    [Address(RVA = "0x444E868", Offset = "0x444E868", VA = "0x444E868")]
    public List<BattleLogData> CreateDrainLog(UnitParameterChange param, UnitParameterData unit)
    {
      return (List<BattleLogData>) null;
    }

    [Token(Token = "0x600EEF6")]
    [Address(RVA = "0x444EDB4", Offset = "0x444EDB4", VA = "0x444EDB4")]
    public List<BattleLogData> CheckUseItemEffect(UseItemCommand command)
    {
      return (List<BattleLogData>) null;
    }

    [Token(Token = "0x600EEF7")]
    [Address(RVA = "0x444F528", Offset = "0x444F528", VA = "0x444F528")]
    private void CreateDealDamageLog(
      ActionTargetResultData target,
      UnitParameterData unit,
      UnitParameterData owner)
    {
    }

    [Token(Token = "0x600EEF8")]
    [Address(RVA = "0x444FF54", Offset = "0x444FF54", VA = "0x444FF54")]
    private void CreateHealLog(UnitParameterChange parameter, UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EEF9")]
    [Address(RVA = "0x4450290", Offset = "0x4450290", VA = "0x4450290")]
    private void CreateStockCounterLog(UnitParameterChange paramChange, UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EEFA")]
    [Address(RVA = "0x44534BC", Offset = "0x44534BC", VA = "0x44534BC")]
    private void CreateHpStoqLog(ActionTargetResultData target, UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EEFB")]
    [Address(RVA = "0x4453694", Offset = "0x4453694", VA = "0x4453694")]
    private void CreateLatentSkillLog(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EEFC")]
    [Address(RVA = "0x4450104", Offset = "0x4450104", VA = "0x4450104")]
    private void CreateTakeBadStatusLog(
      UnitParameterData unit,
      List<BattleBadStatusDetailData> badStatusList)
    {
    }

    [Token(Token = "0x600EEFD")]
    [Address(RVA = "0x4453288", Offset = "0x4453288", VA = "0x4453288")]
    private void CreateClearBadStatusLog(
      UnitParameterData unit,
      List<EffectParameterData> removeEffects)
    {
    }

    [Token(Token = "0x600EEFE")]
    [Address(RVA = "0x445068C", Offset = "0x445068C", VA = "0x445068C")]
    private void CheckAddedSkillEffect(UnitParameterData unit, List<EffectParameterData> effects)
    {
    }

    [Token(Token = "0x600EEFF")]
    [Address(RVA = "0x4453C74", Offset = "0x4453C74", VA = "0x4453C74")]
    private void CreateParameterLog(
      (int key, IEffectValue effectValue) mod,
      string text,
      EffectData effect,
      UnitParameterData unit)
    {
    }
  }
}
