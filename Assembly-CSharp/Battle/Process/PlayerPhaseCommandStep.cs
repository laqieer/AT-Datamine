// Decompiled with JetBrains decompiler
// Type: Battle.Process.PlayerPhaseCommandStep
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data.Board;
using Battle.Grid;
using Battle.Stage;
using Battle.UI;
using Battle.UI.Rewind;
using Il2CppDummyDll;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200266D")]
  public class PlayerPhaseCommandStep : 
    BattlePhaseStepBase,
    IStageEventHandler,
    ICommandPanelEventHandler,
    IRewindPanelEventHandler,
    IUnitListPanelEventHandler
  {
    [Token(Token = "0x400A4D7")]
    [FieldOffset(Offset = "0x24")]
    protected PlayerPhaseCommandStep.State state;
    [Token(Token = "0x400A4D8")]
    [FieldOffset(Offset = "0x28")]
    private UnitActionSelectorBase unitActionSelector;
    [Token(Token = "0x400A4D9")]
    [FieldOffset(Offset = "0x30")]
    private Queue<UnitCommandBase> commandQueue;
    [Token(Token = "0x400A4DA")]
    [FieldOffset(Offset = "0x38")]
    private Queue<UnitCommandBase> executedCommand;
    [Token(Token = "0x400A4DB")]
    [FieldOffset(Offset = "0x40")]
    private List<UnitParameterData> onActionUnits;
    [Token(Token = "0x400A4DC")]
    [FieldOffset(Offset = "0x48")]
    protected bool enableManualControl;
    [Token(Token = "0x400A4DD")]
    [FieldOffset(Offset = "0x49")]
    private bool forceEndAction;
    [Token(Token = "0x400A4DE")]
    [FieldOffset(Offset = "0x4A")]
    private bool needBoardBackup;
    [Token(Token = "0x400A4DF")]
    [FieldOffset(Offset = "0x50")]
    private List<(CancellationTokenSource tokenSource, Task task)> activeTaskInfo;
    [Token(Token = "0x400A4E0")]
    [FieldOffset(Offset = "0x58")]
    private bool hasFocus;
    [Token(Token = "0x400A4E1")]
    [FieldOffset(Offset = "0x59")]
    private bool isPaused;
    [Token(Token = "0x400A4E2")]
    [FieldOffset(Offset = "0x60")]
    private UnitParameterData selectedUnit;
    [Token(Token = "0x400A4E3")]
    [FieldOffset(Offset = "0x68")]
    private bool cancelable;
    [Token(Token = "0x400A4E4")]
    [FieldOffset(Offset = "0x70")]
    private BoardData orgBoard;

    [Token(Token = "0x1700328A")]
    private bool IsActivatableTask
    {
      [Token(Token = "0x600EDD2"), Address(RVA = "0x4435198", Offset = "0x4435198", VA = "0x4435198")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700328B")]
    private bool hasTutorealControll
    {
      [Token(Token = "0x600EDD3"), Address(RVA = "0x4435200", Offset = "0x4435200", VA = "0x4435200")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700328C")]
    private bool isAuto
    {
      [Token(Token = "0x600EDD4"), Address(RVA = "0x4435260", Offset = "0x4435260", VA = "0x4435260")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600EDD5")]
    [Address(RVA = "0x44352A0", Offset = "0x44352A0", VA = "0x44352A0", Slot = "10")]
    public override void Initialize(IProcessOwner<PhaseStepCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600EDD6")]
    [Address(RVA = "0x4435ECC", Offset = "0x4435ECC", VA = "0x4435ECC", Slot = "12")]
    public override void Dispose()
    {
    }

    [Token(Token = "0x600EDD7")]
    [Address(RVA = "0x44362BC", Offset = "0x44362BC", VA = "0x44362BC", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600EDD8")]
    [Address(RVA = "0x4436BAC", Offset = "0x4436BAC", VA = "0x4436BAC", Slot = "14")]
    public override void OnApplicationFocus(bool hasFocus)
    {
    }

    [Token(Token = "0x600EDD9")]
    [Address(RVA = "0x4436BC0", Offset = "0x4436BC0", VA = "0x4436BC0", Slot = "15")]
    public override void OnApplicationPause(bool isPaused)
    {
    }

    [Token(Token = "0x600EDDA")]
    [Address(RVA = "0x4436BD4", Offset = "0x4436BD4", VA = "0x4436BD4", Slot = "11")]
    protected override void Finish(PhaseStepCode nextProcess)
    {
    }

    [Token(Token = "0x600EDDB")]
    [Address(RVA = "0x4436868", Offset = "0x4436868", VA = "0x4436868")]
    protected void ProcAutoThink()
    {
    }

    [Token(Token = "0x600EDDC")]
    [Address(RVA = "0x4436FF0", Offset = "0x4436FF0", VA = "0x4436FF0")]
    protected Task ThinkNextAction() => (Task) null;

    [Token(Token = "0x600EDDD")]
    [Address(RVA = "0x44370B8", Offset = "0x44370B8", VA = "0x44370B8")]
    private void OnSelectedUnitCommand(bool canceled)
    {
    }

    [Token(Token = "0x600EDDE")]
    [Address(RVA = "0x44365E8", Offset = "0x44365E8", VA = "0x44365E8")]
    protected void ExecReservedCommand(UnitCommandLog command)
    {
    }

    [Token(Token = "0x600EDDF")]
    [Address(RVA = "0x4437574", Offset = "0x4437574", VA = "0x4437574")]
    protected void StartCommand(UnitParameterData actionUnit, Queue<UnitCommandBase> commands)
    {
    }

    [Token(Token = "0x600EDE0")]
    [Address(RVA = "0x4437980", Offset = "0x4437980", VA = "0x4437980")]
    private void StartCommand(UnitCommandBase command)
    {
    }

    [Token(Token = "0x600EDE1")]
    [Address(RVA = "0x4437BE4", Offset = "0x4437BE4", VA = "0x4437BE4")]
    private void OnFinishCommand(CommandBase command, bool canceled)
    {
    }

    [Token(Token = "0x600EDE2")]
    [Address(RVA = "0x44382A8", Offset = "0x44382A8", VA = "0x44382A8")]
    private void CommonEndAction()
    {
    }

    [Token(Token = "0x600EDE3")]
    [Address(RVA = "0x443847C", Offset = "0x443847C", VA = "0x443847C")]
    private void OnCurrentUnitEndAction()
    {
    }

    [Token(Token = "0x600EDE4")]
    [Address(RVA = "0x443856C", Offset = "0x443856C", VA = "0x443856C")]
    private void ExecEndActionEffects()
    {
    }

    [Token(Token = "0x600EDE5")]
    [Address(RVA = "0x4436158", Offset = "0x4436158", VA = "0x4436158")]
    private void CancelAsyncTask()
    {
    }

    [Token(Token = "0x600EDE6")]
    [Address(RVA = "0x4438EA4", Offset = "0x4438EA4", VA = "0x4438EA4")]
    private void ExecPhaseEndCheck()
    {
    }

    [Token(Token = "0x600EDE7")]
    [Address(RVA = "0x443932C", Offset = "0x443932C", VA = "0x443932C", Slot = "30")]
    protected virtual bool IsCommandStepEnd() => new bool();

    [Token(Token = "0x600EDE8")]
    [Address(RVA = "0x4439358", Offset = "0x4439358", VA = "0x4439358")]
    protected bool isSelectableUnit(UnitParameterData unit) => new bool();

    [Token(Token = "0x600EDE9")]
    [Address(RVA = "0x44393C8", Offset = "0x44393C8", VA = "0x44393C8", Slot = "31")]
    protected virtual void UpdateSelectableUnit()
    {
    }

    [Token(Token = "0x600EDEA")]
    [Address(RVA = "0x4439784", Offset = "0x4439784", VA = "0x4439784", Slot = "29")]
    public void OnSelectUnitEvent(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EDEB")]
    [Address(RVA = "0x44399AC", Offset = "0x44399AC", VA = "0x44399AC")]
    private bool IsEnableControl() => new bool();

    [Token(Token = "0x600EDEC")]
    [Address(RVA = "0x4439C24", Offset = "0x4439C24", VA = "0x4439C24", Slot = "16")]
    public void OnSelectGrid(GridObject targetGrid)
    {
    }

    [Token(Token = "0x600EDED")]
    [Address(RVA = "0x443A8FC", Offset = "0x443A8FC", VA = "0x443A8FC", Slot = "17")]
    public void OnHoldGrid(GridObject targetGrid)
    {
    }

    [Token(Token = "0x600EDEE")]
    [Address(RVA = "0x443A3CC", Offset = "0x443A3CC", VA = "0x443A3CC")]
    private void OnSelectActionableUnit(UnitParameterData unit, bool cancelable)
    {
    }

    [Token(Token = "0x600EDEF")]
    [Address(RVA = "0x443A824", Offset = "0x443A824", VA = "0x443A824")]
    private void OnSelectNoActionableUnit(UnitParameterData unit, GridData selectGrid)
    {
    }

    [Token(Token = "0x600EDF0")]
    [Address(RVA = "0x443AA5C", Offset = "0x443AA5C", VA = "0x443AA5C", Slot = "19")]
    public void OnPushUseItem()
    {
    }

    [Token(Token = "0x600EDF1")]
    [Address(RVA = "0x443ABD4", Offset = "0x443ABD4", VA = "0x443ABD4", Slot = "20")]
    public void OnPushRewind()
    {
    }

    [Token(Token = "0x600EDF2")]
    [Address(RVA = "0x443AF48", Offset = "0x443AF48", VA = "0x443AF48", Slot = "18")]
    public void OnPushTurnEnd()
    {
    }

    [Token(Token = "0x600EDF3")]
    [Address(RVA = "0x443AF54", Offset = "0x443AF54", VA = "0x443AF54", Slot = "22")]
    public void OnHideRewindPanel()
    {
    }

    [Token(Token = "0x600EDF4")]
    [Address(RVA = "0x443B19C", Offset = "0x443B19C", VA = "0x443B19C", Slot = "23")]
    public void OnSelectRollbackTo(int index)
    {
    }

    [Token(Token = "0x600EDF5")]
    [Address(RVA = "0x443B2C4", Offset = "0x443B2C4", VA = "0x443B2C4", Slot = "24")]
    public void OnExecRollback(int idx)
    {
    }

    [Token(Token = "0x600EDF6")]
    [Address(RVA = "0x443B674", Offset = "0x443B674", VA = "0x443B674", Slot = "25")]
    public void OnCancelRollback()
    {
    }

    [Token(Token = "0x600EDF7")]
    [Address(RVA = "0x443B798", Offset = "0x443B798", VA = "0x443B798")]
    public void OnSwitchDangerArea()
    {
    }

    [Token(Token = "0x600EDF8")]
    [Address(RVA = "0x443B854", Offset = "0x443B854", VA = "0x443B854")]
    public void OnSwitchStatusIcon()
    {
    }

    [Token(Token = "0x600EDF9")]
    [Address(RVA = "0x443A900", Offset = "0x443A900", VA = "0x443A900")]
    private void PlayVoice(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EDFA")]
    [Address(RVA = "0x443B8C8", Offset = "0x443B8C8", VA = "0x443B8C8", Slot = "21")]
    public void OnPushLog()
    {
    }

    [Token(Token = "0x600EDFB")]
    [Address(RVA = "0x443BC04", Offset = "0x443BC04", VA = "0x443BC04", Slot = "26")]
    public void ShowBattleLogViewIntoRewind()
    {
    }

    [Token(Token = "0x600EDFC")]
    [Address(RVA = "0x443BE98", Offset = "0x443BE98", VA = "0x443BE98", Slot = "27")]
    public void HideBattleLogViewIntoRewind()
    {
    }

    [Token(Token = "0x600EDFD")]
    [Address(RVA = "0x443BDCC", Offset = "0x443BDCC", VA = "0x443BDCC", Slot = "28")]
    public void SetActiveBattleLogView(bool isActive)
    {
    }

    [Token(Token = "0x600EDFE")]
    [Address(RVA = "0x443BF5C", Offset = "0x443BF5C", VA = "0x443BF5C")]
    public PlayerPhaseCommandStep()
    {
    }

    [Token(Token = "0x200266E")]
    public enum State
    {
      [Token(Token = "0x400A4E6")] Initialize,
      [Token(Token = "0x400A4E7")] SelectUnit,
      [Token(Token = "0x400A4E8")] SelectAction,
      [Token(Token = "0x400A4E9")] ExecuteCommand,
      [Token(Token = "0x400A4EA")] FinishCommand,
    }
  }
}
