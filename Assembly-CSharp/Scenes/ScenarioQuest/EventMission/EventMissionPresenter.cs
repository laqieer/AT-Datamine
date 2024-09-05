// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.EventMissionPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x2002994")]
  public class EventMissionPresenter
  {
    [Token(Token = "0x400B125")]
    [FieldOffset(Offset = "0x10")]
    private EventMissionModel _model;
    [Token(Token = "0x400B126")]
    [FieldOffset(Offset = "0x18")]
    private EventMissionView _view;

    [Token(Token = "0x601055B")]
    [Address(RVA = "0x4761BC8", Offset = "0x4761BC8", VA = "0x4761BC8")]
    public void Initialize(EventMissionModel model, EventMissionView view)
    {
    }

    [Token(Token = "0x601055C")]
    [Address(RVA = "0x4761BD0", Offset = "0x4761BD0", VA = "0x4761BD0")]
    public void Bind(EventMissionModel model, EventMissionView view)
    {
    }

    [Token(Token = "0x601055D")]
    [Address(RVA = "0x4761DE4", Offset = "0x4761DE4", VA = "0x4761DE4")]
    public void SetCharacterData(
      int characterNum,
      int firstStyleId = 0,
      int secondStyleId = 0,
      int thirdStyleId = 0)
    {
    }

    [Token(Token = "0x601055E")]
    [Address(RVA = "0x4761E00", Offset = "0x4761E00", VA = "0x4761E00")]
    public void SetTimeLimitText(int day, int hour, int minutes)
    {
    }

    [Token(Token = "0x601055F")]
    [Address(RVA = "0x4761E1C", Offset = "0x4761E1C", VA = "0x4761E1C")]
    private void ChangeRewardCondition(List<RewardConditionData> rewardConditions)
    {
    }

    [Token(Token = "0x6010560")]
    [Address(RVA = "0x4761E48", Offset = "0x4761E48", VA = "0x4761E48")]
    private void ChangeMissionListData(List<MissionDataList> missionDataList)
    {
    }

    [Token(Token = "0x6010561")]
    [Address(RVA = "0x47621A8", Offset = "0x47621A8", VA = "0x47621A8")]
    private void ViewGetReward(List<DisplayItemRewardInfoData> rewards, Action callback)
    {
    }

    [Token(Token = "0x6010562")]
    [Address(RVA = "0x4761E80", Offset = "0x4761E80", VA = "0x4761E80")]
    private void SetBulkReceiptButton(List<MissionDataList> missionDataList)
    {
    }

    [Token(Token = "0x6010563")]
    [Address(RVA = "0x47621CC", Offset = "0x47621CC", VA = "0x47621CC")]
    public EventMissionPresenter()
    {
    }
  }
}
