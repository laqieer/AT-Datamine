// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleCommandLogCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data.Board;
using Battle.DuelScene;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002693")]
  public class BattleCommandLogCreator : BattleLogCreator
  {
    [Token(Token = "0x600EED2")]
    [Address(RVA = "0x444BDDC", Offset = "0x444BDDC", VA = "0x444BDDC")]
    public BattleCommandLogCreator(
      IReadOnlyDictionary<int, BattleLogTextFormatData> dic,
      BoardData boardData)
    {
    }

    [Token(Token = "0x600EED3")]
    [Address(RVA = "0x444BDE4", Offset = "0x444BDE4", VA = "0x444BDE4")]
    public List<BattleLogData> CreateCommandLog(Queue<UnitCommandBase> unitCommandQueue)
    {
      return (List<BattleLogData>) null;
    }

    [Token(Token = "0x600EED4")]
    [Address(RVA = "0x444C318", Offset = "0x444C318", VA = "0x444C318")]
    private void DuelAction(DuelCommand command)
    {
    }

    [Token(Token = "0x600EED5")]
    [Address(RVA = "0x444C804", Offset = "0x444C804", VA = "0x444C804")]
    private void SkillAction(SkillCommand command)
    {
    }

    [Token(Token = "0x600EED6")]
    [Address(RVA = "0x444E5A0", Offset = "0x444E5A0", VA = "0x444E5A0")]
    private void CreateUseSkill(SkillCommand command, ActionData action)
    {
    }

    [Token(Token = "0x600EED7")]
    [Address(RVA = "0x444DF00", Offset = "0x444DF00", VA = "0x444DF00")]
    private void CreateDuelActionLog(ActionData action, DuelData duelData = null, bool normalAttackLog = true)
    {
    }

    [Token(Token = "0x600EED8")]
    [Address(RVA = "0x444CC30", Offset = "0x444CC30", VA = "0x444CC30")]
    private void CreateDouble(DoubleCommand command)
    {
    }

    [Token(Token = "0x600EED9")]
    [Address(RVA = "0x444CE14", Offset = "0x444CE14", VA = "0x444CE14")]
    private void CreateSwitchDouble(SwitchDoubleCommand command)
    {
    }

    [Token(Token = "0x600EEDA")]
    [Address(RVA = "0x444CEC8", Offset = "0x444CEC8", VA = "0x444CEC8")]
    private void CreateReleaseDouble(ReleaseDoubleCommand command)
    {
    }

    [Token(Token = "0x600EEDB")]
    [Address(RVA = "0x444ECF8", Offset = "0x444ECF8", VA = "0x444ECF8")]
    private void CreateSupportGuard(int unitId)
    {
    }

    [Token(Token = "0x600EEDC")]
    [Address(RVA = "0x444D1F4", Offset = "0x444D1F4", VA = "0x444D1F4")]
    private void CreateUseItem(UseItemCommand command)
    {
    }

    [Token(Token = "0x600EEDD")]
    [Address(RVA = "0x444D4A0", Offset = "0x444D4A0", VA = "0x444D4A0")]
    private void CreateInteract(InteractCommand command)
    {
    }

    [Token(Token = "0x600EEDE")]
    [Address(RVA = "0x444CAEC", Offset = "0x444CAEC", VA = "0x444CAEC")]
    private void CreateChargeSkill(ChargeStartCommand command)
    {
    }

    [Token(Token = "0x600EEDF")]
    [Address(RVA = "0x444EB04", Offset = "0x444EB04", VA = "0x444EB04")]
    private void CheckChargeSkillStopped(ActionData action)
    {
    }

    [Token(Token = "0x600EEE0")]
    [Address(RVA = "0x444F3F4", Offset = "0x444F3F4", VA = "0x444F3F4")]
    private void CheckChargeSkillStopped(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EEE1")]
    [Address(RVA = "0x444F2A0", Offset = "0x444F2A0", VA = "0x444F2A0")]
    private void CreateChargeStopped(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EEE2")]
    [Address(RVA = "0x444DB5C", Offset = "0x444DB5C", VA = "0x444DB5C")]
    private void CreateMoveLog(MoveCommand command)
    {
    }

    [Token(Token = "0x600EEE3")]
    [Address(RVA = "0x444DD34", Offset = "0x444DD34", VA = "0x444DD34")]
    private void CreateStayLog(StayCommand command)
    {
    }

    [Token(Token = "0x600EEE4")]
    [Address(RVA = "0x444E840", Offset = "0x444E840", VA = "0x444E840")]
    private bool SkipActionData(ActionData action) => new bool();

    [Token(Token = "0x600EEE5")]
    [Address(RVA = "0x444E880", Offset = "0x444E880", VA = "0x444E880")]
    private bool CheckOnceLog(string name) => new bool();
  }
}
