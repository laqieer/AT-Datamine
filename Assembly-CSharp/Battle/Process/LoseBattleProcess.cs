// Decompiled with JetBrains decompiler
// Type: Battle.Process.LoseBattleProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.UI.Rewind;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002656")]
  public sealed class LoseBattleProcess : BattleProcessBase, IRewindPanelEventHandler
  {
    [Token(Token = "0x400A489")]
    [FieldOffset(Offset = "0x24")]
    private LoseBattleProcess.State state;
    [Token(Token = "0x400A48A")]
    [FieldOffset(Offset = "0x28")]
    private LoseBattleProcess.RollBackResult rollBackResult;
    [Token(Token = "0x400A48B")]
    [FieldOffset(Offset = "0x30")]
    private BoardData orgBoard;

    [Token(Token = "0x600ED65")]
    [Address(RVA = "0x449B770", Offset = "0x449B770", VA = "0x449B770", Slot = "10")]
    public override void Initialize(IProcessOwner<ProcessCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600ED66")]
    [Address(RVA = "0x449B91C", Offset = "0x449B91C", VA = "0x449B91C", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600ED67")]
    [Address(RVA = "0x449BDDC", Offset = "0x449BDDC", VA = "0x449BDDC", Slot = "11")]
    protected override void Finish(ProcessCode nextProcess)
    {
    }

    [Token(Token = "0x600ED68")]
    [Address(RVA = "0x449BBC8", Offset = "0x449BBC8", VA = "0x449BBC8")]
    private void ShowRollbackDialog()
    {
    }

    [Token(Token = "0x600ED69")]
    [Address(RVA = "0x449BDA0", Offset = "0x449BDA0", VA = "0x449BDA0")]
    private void RollbackToTheBattle()
    {
    }

    [Token(Token = "0x600ED6A")]
    [Address(RVA = "0x449BEC4", Offset = "0x449BEC4", VA = "0x449BEC4", Slot = "16")]
    public void OnHideRewindPanel()
    {
    }

    [Token(Token = "0x600ED6B")]
    [Address(RVA = "0x449C0FC", Offset = "0x449C0FC", VA = "0x449C0FC", Slot = "17")]
    public void OnSelectRollbackTo(int index)
    {
    }

    [Token(Token = "0x600ED6C")]
    [Address(RVA = "0x449C5E4", Offset = "0x449C5E4", VA = "0x449C5E4", Slot = "18")]
    public void OnExecRollback(int idx)
    {
    }

    [Token(Token = "0x600ED6D")]
    [Address(RVA = "0x449C8E4", Offset = "0x449C8E4", VA = "0x449C8E4", Slot = "19")]
    public void OnCancelRollback()
    {
    }

    [Token(Token = "0x600ED6E")]
    [Address(RVA = "0x449C210", Offset = "0x449C210", VA = "0x449C210")]
    private void UpdateSelectableUnit(bool isPreview)
    {
    }

    [Token(Token = "0x600ED6F")]
    [Address(RVA = "0x449C9F4", Offset = "0x449C9F4", VA = "0x449C9F4")]
    private bool isSelectableUnit(UnitParameterData unit) => new bool();

    [Token(Token = "0x600ED70")]
    [Address(RVA = "0x449CA64", Offset = "0x449CA64", VA = "0x449CA64", Slot = "20")]
    public void ShowBattleLogViewIntoRewind()
    {
    }

    [Token(Token = "0x600ED71")]
    [Address(RVA = "0x449CC00", Offset = "0x449CC00", VA = "0x449CC00", Slot = "21")]
    public void HideBattleLogViewIntoRewind()
    {
    }

    [Token(Token = "0x600ED72")]
    [Address(RVA = "0x449CCC0", Offset = "0x449CCC0", VA = "0x449CCC0", Slot = "22")]
    public void SetActiveBattleLogView(bool isActive)
    {
    }

    [Token(Token = "0x600ED73")]
    [Address(RVA = "0x448CA18", Offset = "0x448CA18", VA = "0x448CA18")]
    public LoseBattleProcess()
    {
    }

    [Token(Token = "0x2002657")]
    private enum State
    {
      [Token(Token = "0x400A48D")] Staging,
      [Token(Token = "0x400A48E")] RollBackCheck,
      [Token(Token = "0x400A48F")] RollBackCheckWait,
      [Token(Token = "0x400A490")] Finish,
      [Token(Token = "0x400A491")] Rollback,
    }

    [Token(Token = "0x2002658")]
    private enum RollBackResult
    {
      [Token(Token = "0x400A493")] Cancel,
      [Token(Token = "0x400A494")] Execute,
    }
  }
}
