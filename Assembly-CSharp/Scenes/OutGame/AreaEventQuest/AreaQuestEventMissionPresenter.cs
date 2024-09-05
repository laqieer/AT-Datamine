// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaEventQuest.AreaQuestEventMissionPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.ScenarioQuest.EventMission;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.AreaEventQuest
{
  [Token(Token = "0x2003932")]
  public class AreaQuestEventMissionPresenter
  {
    [Token(Token = "0x400FA0F")]
    [FieldOffset(Offset = "0x10")]
    private EventMissionModel _model;
    [Token(Token = "0x400FA10")]
    [FieldOffset(Offset = "0x18")]
    private AreaQuestEventMissionView _view;

    [Token(Token = "0x60167B8")]
    [Address(RVA = "0x42E7444", Offset = "0x42E7444", VA = "0x42E7444")]
    public void Initialize(EventMissionModel model, AreaQuestEventMissionView view)
    {
    }

    [Token(Token = "0x60167B9")]
    [Address(RVA = "0x42E744C", Offset = "0x42E744C", VA = "0x42E744C")]
    public void Bind(EventMissionModel model, AreaQuestEventMissionView view)
    {
    }

    [Token(Token = "0x60167BA")]
    [Address(RVA = "0x42E77F0", Offset = "0x42E77F0", VA = "0x42E77F0")]
    public void SetTimeLimitText(int day, int hour, int minutes)
    {
    }

    [Token(Token = "0x60167BB")]
    [Address(RVA = "0x42E780C", Offset = "0x42E780C", VA = "0x42E780C")]
    private void ChangeRewardCondition(List<RewardConditionData> rewardConditions)
    {
    }

    [Token(Token = "0x60167BC")]
    [Address(RVA = "0x42E7864", Offset = "0x42E7864", VA = "0x42E7864")]
    private void ChangeMissionListData(List<MissionDataList> missionDataList)
    {
    }

    [Token(Token = "0x60167BD")]
    [Address(RVA = "0x42E7880", Offset = "0x42E7880", VA = "0x42E7880")]
    private void ViewGetReward(List<DisplayItemRewardInfoData> rewards, Action callback)
    {
    }

    [Token(Token = "0x60167BE")]
    [Address(RVA = "0x42E789C", Offset = "0x42E789C", VA = "0x42E789C")]
    public AreaQuestEventMissionPresenter()
    {
    }
  }
}
