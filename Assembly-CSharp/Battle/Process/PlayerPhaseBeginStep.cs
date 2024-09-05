// Decompiled with JetBrains decompiler
// Type: Battle.Process.PlayerPhaseBeginStep
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.UI.Rewind;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002668")]
  public class PlayerPhaseBeginStep : BattlePhaseStepBase, IRewindPanelEventHandler
  {
    [Token(Token = "0x400A4BC")]
    [FieldOffset(Offset = "0x24")]
    private PlayerPhaseBeginStep.RollBackState rollBackState;
    [Token(Token = "0x400A4BD")]
    [FieldOffset(Offset = "0x28")]
    protected PlayerPhaseBeginStep.State state;
    [Token(Token = "0x400A4BE")]
    [FieldOffset(Offset = "0x30")]
    protected GridData[] turretGrids;
    [Token(Token = "0x400A4BF")]
    [FieldOffset(Offset = "0x38")]
    protected int activeTurretIdx;
    [Token(Token = "0x400A4C0")]
    [FieldOffset(Offset = "0x40")]
    private BoardData orgBoard;

    [Token(Token = "0x600EDB7")]
    [Address(RVA = "0x449ECE0", Offset = "0x449ECE0", VA = "0x449ECE0", Slot = "10")]
    public override void Initialize(IProcessOwner<PhaseStepCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600EDB8")]
    [Address(RVA = "0x449EDEC", Offset = "0x449EDEC", VA = "0x449EDEC", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600EDB9")]
    [Address(RVA = "0x44A1710", Offset = "0x44A1710", VA = "0x44A1710", Slot = "11")]
    protected override void Finish(PhaseStepCode nextProcess)
    {
    }

    [Token(Token = "0x600EDBA")]
    [Address(RVA = "0x449F704", Offset = "0x449F704", VA = "0x449F704")]
    protected void UpdateSkillEffectCount()
    {
    }

    [Token(Token = "0x600EDBB")]
    [Address(RVA = "0x449F900", Offset = "0x449F900", VA = "0x449F900")]
    protected void ExecPassiveSkill()
    {
    }

    [Token(Token = "0x600EDBC")]
    [Address(RVA = "0x449FB6C", Offset = "0x449FB6C", VA = "0x449FB6C")]
    protected void ExecLandformEffects()
    {
    }

    [Token(Token = "0x600EDBD")]
    [Address(RVA = "0x44A01B0", Offset = "0x44A01B0", VA = "0x44A01B0")]
    protected void ExecRegenerateEffect()
    {
    }

    [Token(Token = "0x600EDBE")]
    [Address(RVA = "0x44A06B0", Offset = "0x44A06B0", VA = "0x44A06B0")]
    protected void ExecAutoTurret(int activeIdx)
    {
    }

    [Token(Token = "0x600EDBF")]
    [Address(RVA = "0x449F3BC", Offset = "0x449F3BC", VA = "0x449F3BC")]
    private void ShowRollbackDialog()
    {
    }

    [Token(Token = "0x600EDC0")]
    [Address(RVA = "0x44A17E4", Offset = "0x44A17E4", VA = "0x44A17E4", Slot = "16")]
    public void OnHideRewindPanel()
    {
    }

    [Token(Token = "0x600EDC1")]
    [Address(RVA = "0x44A1A1C", Offset = "0x44A1A1C", VA = "0x44A1A1C", Slot = "17")]
    public void OnSelectRollbackTo(int index)
    {
    }

    [Token(Token = "0x600EDC2")]
    [Address(RVA = "0x44A1EEC", Offset = "0x44A1EEC", VA = "0x44A1EEC", Slot = "18")]
    public void OnExecRollback(int idx)
    {
    }

    [Token(Token = "0x600EDC3")]
    [Address(RVA = "0x44A21EC", Offset = "0x44A21EC", VA = "0x44A21EC", Slot = "19")]
    public void OnCancelRollback()
    {
    }

    [Token(Token = "0x600EDC4")]
    [Address(RVA = "0x44A1B2C", Offset = "0x44A1B2C", VA = "0x44A1B2C")]
    private void UpdateSelectableUnit()
    {
    }

    [Token(Token = "0x600EDC5")]
    [Address(RVA = "0x44A22F8", Offset = "0x44A22F8", VA = "0x44A22F8")]
    private bool isSelectableUnit(UnitParameterData unit) => new bool();

    [Token(Token = "0x600EDC6")]
    [Address(RVA = "0x44A2368", Offset = "0x44A2368", VA = "0x44A2368", Slot = "23")]
    protected virtual void AddSecurityLog()
    {
    }

    [Token(Token = "0x600EDC7")]
    [Address(RVA = "0x44A2464", Offset = "0x44A2464", VA = "0x44A2464", Slot = "20")]
    public void ShowBattleLogViewIntoRewind()
    {
    }

    [Token(Token = "0x600EDC8")]
    [Address(RVA = "0x44A2600", Offset = "0x44A2600", VA = "0x44A2600", Slot = "21")]
    public void HideBattleLogViewIntoRewind()
    {
    }

    [Token(Token = "0x600EDC9")]
    [Address(RVA = "0x44A26C0", Offset = "0x44A26C0", VA = "0x44A26C0", Slot = "22")]
    public void SetActiveBattleLogView(bool isActive)
    {
    }

    [Token(Token = "0x600EDCA")]
    [Address(RVA = "0x44A2788", Offset = "0x44A2788", VA = "0x44A2788")]
    public PlayerPhaseBeginStep()
    {
    }

    [Token(Token = "0x2002669")]
    protected enum State
    {
      [Token(Token = "0x400A4C2")] ResetAIParam,
      [Token(Token = "0x400A4C3")] ResetUnitActionState,
      [Token(Token = "0x400A4C4")] Staging,
      [Token(Token = "0x400A4C5")] RollbackCheck,
      [Token(Token = "0x400A4C6")] RollbackCheckWait,
      [Token(Token = "0x400A4C7")] UpdateSkillEffectCount,
      [Token(Token = "0x400A4C8")] PassiveSkill,
      [Token(Token = "0x400A4C9")] LandformEffect,
      [Token(Token = "0x400A4CA")] Regenerate,
      [Token(Token = "0x400A4CB")] AutoTurret,
      [Token(Token = "0x400A4CC")] BattleADV,
      [Token(Token = "0x400A4CD")] Exit,
    }

    [Token(Token = "0x200266A")]
    private enum RollBackState
    {
      [Token(Token = "0x400A4CF")] None,
      [Token(Token = "0x400A4D0")] Open,
      [Token(Token = "0x400A4D1")] Execute,
      [Token(Token = "0x400A4D2")] Cancel,
    }
  }
}
