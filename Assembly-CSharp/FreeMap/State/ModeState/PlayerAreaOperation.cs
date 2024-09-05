// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.PlayerAreaOperation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using FreeMap.State.Process;
using Il2CppDummyDll;
using System;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x200180C")]
  public class PlayerAreaOperation : IPlayerAreaOperationEvent
  {
    [Token(Token = "0x400693F")]
    [FieldOffset(Offset = "0x10")]
    private FreeMapStateManager entity;
    [Token(Token = "0x4006940")]
    [FieldOffset(Offset = "0x18")]
    private Action<FreeMapProcess> endedMethod;

    [Token(Token = "0x600880A")]
    [Address(RVA = "0x43D9614", Offset = "0x43D9614", VA = "0x43D9614")]
    public PlayerAreaOperation(FreeMapStateManager entity, Action<FreeMapProcess> endedMethod)
    {
    }

    [Token(Token = "0x600880B")]
    [Address(RVA = "0x43D9640", Offset = "0x43D9640", VA = "0x43D9640")]
    public void Start()
    {
    }

    [Token(Token = "0x600880C")]
    [Address(RVA = "0x43D9D50", Offset = "0x43D9D50", VA = "0x43D9D50")]
    public void OnUpdate()
    {
    }

    [Token(Token = "0x600880D")]
    [Address(RVA = "0x43D9D54", Offset = "0x43D9D54", VA = "0x43D9D54")]
    private void AddEnd(FreeMapProcess process)
    {
    }

    [Token(Token = "0x600880E")]
    [Address(RVA = "0x43D97E4", Offset = "0x43D97E4", VA = "0x43D97E4")]
    private void StartPlayerOperation()
    {
    }

    [Token(Token = "0x600880F")]
    [Address(RVA = "0x43D9D90", Offset = "0x43D9D90", VA = "0x43D9D90")]
    private void StopPlayerOperation()
    {
    }

    [Token(Token = "0x6008810")]
    [Address(RVA = "0x43D975C", Offset = "0x43D975C", VA = "0x43D975C")]
    public void OnEnded()
    {
    }

    [Token(Token = "0x6008811")]
    [Address(RVA = "0x43DA060", Offset = "0x43DA060", VA = "0x43DA060")]
    private void ShowMap()
    {
    }

    [Token(Token = "0x6008812")]
    [Address(RVA = "0x43DA0CC", Offset = "0x43DA0CC", VA = "0x43DA0CC")]
    private void SubQuestCancel(int subQuestID)
    {
    }

    [Token(Token = "0x6008813")]
    [Address(RVA = "0x43DA144", Offset = "0x43DA144", VA = "0x43DA144")]
    private void ChangeGlobalMenu()
    {
    }

    [Token(Token = "0x6008814")]
    [Address(RVA = "0x43DA1D4", Offset = "0x43DA1D4", VA = "0x43DA1D4")]
    private void OnDetailMainQuest()
    {
    }

    [Token(Token = "0x6008815")]
    [Address(RVA = "0x43DA2B8", Offset = "0x43DA2B8", VA = "0x43DA2B8")]
    private void OnDetailSubQuest(int subQuestID)
    {
    }

    [Token(Token = "0x6008816")]
    [Address(RVA = "0x43DA368", Offset = "0x43DA368", VA = "0x43DA368")]
    private void OnDetailAreaEventQuest(int areaEventQuestID)
    {
    }

    [Token(Token = "0x6008817")]
    [Address(RVA = "0x43DA418", Offset = "0x43DA418", VA = "0x43DA418")]
    public void OnClickPocketbookWithScheduleList()
    {
    }

    [Token(Token = "0x6008818")]
    [Address(RVA = "0x43DA4F4", Offset = "0x43DA4F4", VA = "0x43DA4F4")]
    public void OnClickPocketbookWithMapList()
    {
    }

    [Token(Token = "0x6008819")]
    [Address(RVA = "0x43DA5CC", Offset = "0x43DA5CC", VA = "0x43DA5CC")]
    public void OpenKizunaList()
    {
    }

    [Token(Token = "0x600881A")]
    [Address(RVA = "0x43DA6B4", Offset = "0x43DA6B4", VA = "0x43DA6B4")]
    private void OnExecuteClosedEvent(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x600881B")]
    [Address(RVA = "0x43DA6D8", Offset = "0x43DA6D8", VA = "0x43DA6D8")]
    public void OnIconEventExecute(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x600881C")]
    [Address(RVA = "0x43DA750", Offset = "0x43DA750", VA = "0x43DA750", Slot = "4")]
    public void FastTravel(ITransitionEvent transition, FreeMapUIParamBase targetParam)
    {
    }

    [Token(Token = "0x600881D")]
    [Address(RVA = "0x43DA6B8", Offset = "0x43DA6B8", VA = "0x43DA6B8", Slot = "5")]
    public void AutoMoveToEvent(FreeMapUIParamBase target)
    {
    }

    [Token(Token = "0x600881E")]
    [Address(RVA = "0x43DA7CC", Offset = "0x43DA7CC", VA = "0x43DA7CC", Slot = "6")]
    public void GotoTarget(FreeMapUIParamBase target)
    {
    }

    [Token(Token = "0x600881F")]
    [Address(RVA = "0x43DA8A4", Offset = "0x43DA8A4", VA = "0x43DA8A4", Slot = "7")]
    public void ChangeAreaAndAutoMove(ITransitionEvent transition, FreeMapUIParamBase target)
    {
    }

    [Token(Token = "0x6008820")]
    [Address(RVA = "0x43DAC68", Offset = "0x43DAC68", VA = "0x43DAC68", Slot = "8")]
    public void OnAutoMoveFinish(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6008821")]
    [Address(RVA = "0x43DA8DC", Offset = "0x43DA8DC", VA = "0x43DA8DC")]
    private void ChangeArea(ITransitionEvent transition)
    {
    }

    [Token(Token = "0x6008822")]
    [Address(RVA = "0x43DACE0", Offset = "0x43DACE0", VA = "0x43DACE0")]
    private void ChangeAreaByTransitionArea(string objectName)
    {
    }
  }
}
