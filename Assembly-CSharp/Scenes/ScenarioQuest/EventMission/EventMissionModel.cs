// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.EventMissionModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.API;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x2002986")]
  public class EventMissionModel
  {
    [Token(Token = "0x400B0D4")]
    [FieldOffset(Offset = "0x10")]
    private int _progressPoint;
    [Token(Token = "0x400B0D5")]
    [FieldOffset(Offset = "0x14")]
    private int _maxProgressPoint;
    [Token(Token = "0x400B0D6")]
    [FieldOffset(Offset = "0x18")]
    private MissionScheduleData _scheduleData;
    [Token(Token = "0x400B0D7")]
    [FieldOffset(Offset = "0x20")]
    private List<RewardConditionData> _rewardConditions;
    [Token(Token = "0x400B0D8")]
    [FieldOffset(Offset = "0x28")]
    public bool isBusy;
    [Token(Token = "0x400B0D9")]
    [FieldOffset(Offset = "0x30")]
    public Action<List<MissionDataList>> OnChangeMissionDataList;
    [Token(Token = "0x400B0DA")]
    [FieldOffset(Offset = "0x38")]
    public Action<int> OnProgressRank;
    [Token(Token = "0x400B0DB")]
    [FieldOffset(Offset = "0x40")]
    public Action<int, Action> OnUpdateProgressRank;
    [Token(Token = "0x400B0DC")]
    [FieldOffset(Offset = "0x48")]
    public Action<bool, int> onClickTreasure;
    [Token(Token = "0x400B0DD")]
    [FieldOffset(Offset = "0x50")]
    private APIMissionListResponse _apiMissionList;
    [Token(Token = "0x400B0DE")]
    [FieldOffset(Offset = "0x58")]
    private List<int> _acceptMissionProgressRewardIds;
    [Token(Token = "0x400B0DF")]
    [FieldOffset(Offset = "0x60")]
    private List<MissionData> _missionData;
    [Token(Token = "0x400B0E0")]
    [FieldOffset(Offset = "0x68")]
    private List<MissionDataList> _missionDataList;
    [Token(Token = "0x400B0E1")]
    [FieldOffset(Offset = "0x70")]
    private int _missionGroupId;
    [Token(Token = "0x400B0E8")]
    [FieldOffset(Offset = "0xA8")]
    private int _day;
    [Token(Token = "0x400B0E9")]
    [FieldOffset(Offset = "0xAC")]
    private int _hour;
    [Token(Token = "0x400B0EA")]
    [FieldOffset(Offset = "0xB0")]
    private int _min;

    [Token(Token = "0x14000150")]
    public event Action<List<RewardConditionData>> OnChangeRewardCondition
    {
      [Token(Token = "0x601050B"), Address(RVA = "0x475D450", Offset = "0x475D450", VA = "0x475D450")] add
      {
      }
      [Token(Token = "0x601050C"), Address(RVA = "0x475D500", Offset = "0x475D500", VA = "0x475D500")] remove
      {
      }
    }

    [Token(Token = "0x14000151")]
    private event Action<List<int>> OnclickReceiptButton
    {
      [Token(Token = "0x601050D"), Address(RVA = "0x475D5B0", Offset = "0x475D5B0", VA = "0x475D5B0")] add
      {
      }
      [Token(Token = "0x601050E"), Address(RVA = "0x475D660", Offset = "0x475D660", VA = "0x475D660")] remove
      {
      }
    }

    [Token(Token = "0x14000152")]
    public event Action<List<DisplayItemRewardInfoData>, Action> GetRewardAction
    {
      [Token(Token = "0x601050F"), Address(RVA = "0x475D710", Offset = "0x475D710", VA = "0x475D710")] add
      {
      }
      [Token(Token = "0x6010510"), Address(RVA = "0x475D7C0", Offset = "0x475D7C0", VA = "0x475D7C0")] remove
      {
      }
    }

    [Token(Token = "0x14000153")]
    public event Action<List<DisplayItemRewardInfoData>, Action> GetProgressRewardAction
    {
      [Token(Token = "0x6010511"), Address(RVA = "0x475D870", Offset = "0x475D870", VA = "0x475D870")] add
      {
      }
      [Token(Token = "0x6010512"), Address(RVA = "0x475D920", Offset = "0x475D920", VA = "0x475D920")] remove
      {
      }
    }

    [Token(Token = "0x14000154")]
    public event Action<int, int, int> OnChangeTime
    {
      [Token(Token = "0x6010513"), Address(RVA = "0x475D9D0", Offset = "0x475D9D0", VA = "0x475D9D0")] add
      {
      }
      [Token(Token = "0x6010514"), Address(RVA = "0x475DA80", Offset = "0x475DA80", VA = "0x475DA80")] remove
      {
      }
    }

    [Token(Token = "0x14000155")]
    public event Action OnExChangeStore
    {
      [Token(Token = "0x6010515"), Address(RVA = "0x475DB30", Offset = "0x475DB30", VA = "0x475DB30")] add
      {
      }
      [Token(Token = "0x6010516"), Address(RVA = "0x475DBCC", Offset = "0x475DBCC", VA = "0x475DBCC")] remove
      {
      }
    }

    [Token(Token = "0x1700390D")]
    public List<int> ClearMissionList
    {
      [Token(Token = "0x6010517"), Address(RVA = "0x475DC68", Offset = "0x475DC68", VA = "0x475DC68")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x6010518")]
    [Address(RVA = "0x475DE3C", Offset = "0x475DE3C", VA = "0x475DE3C")]
    public EventMissionModel()
    {
    }

    [Token(Token = "0x6010519")]
    [Address(RVA = "0x475DF94", Offset = "0x475DF94", VA = "0x475DF94")]
    public void Initialize(
      int missionGroupId,
      APIMissionListResponse missionList,
      Action<List<int>> receiptAction,
      Action<bool, int> receiptProgressAction)
    {
    }

    [Token(Token = "0x601051A")]
    [Address(RVA = "0x475EF04", Offset = "0x475EF04", VA = "0x475EF04")]
    public void Reflesh(APIMissionListResponse missionList)
    {
    }

    [Token(Token = "0x601051B")]
    [Address(RVA = "0x475DFD4", Offset = "0x475DFD4", VA = "0x475DFD4")]
    public void SetMissionListResponse()
    {
    }

    [Token(Token = "0x601051C")]
    [Address(RVA = "0x475EF38", Offset = "0x475EF38", VA = "0x475EF38")]
    public int GetMaxProgressPoint() => new int();

    [Token(Token = "0x601051D")]
    [Address(RVA = "0x475EF40", Offset = "0x475EF40", VA = "0x475EF40")]
    public int GetProgressPoint() => new int();

    [Token(Token = "0x601051E")]
    [Address(RVA = "0x475EF48", Offset = "0x475EF48", VA = "0x475EF48")]
    public void SetEventMissionProgress()
    {
    }

    [Token(Token = "0x601051F")]
    [Address(RVA = "0x475EF4C", Offset = "0x475EF4C", VA = "0x475EF4C")]
    public void OnBulkReceiptButton(List<int> missionIds)
    {
    }

    [Token(Token = "0x6010520")]
    [Address(RVA = "0x475EF68", Offset = "0x475EF68", VA = "0x475EF68")]
    private void SettingProgress()
    {
    }

    [Token(Token = "0x6010521")]
    [Address(RVA = "0x475F628", Offset = "0x475F628", VA = "0x475F628")]
    private void CountProgressPoint()
    {
    }

    [Token(Token = "0x6010522")]
    [Address(RVA = "0x475E468", Offset = "0x475E468", VA = "0x475E468")]
    private void SettingMissionDataList()
    {
    }

    [Token(Token = "0x6010523")]
    [Address(RVA = "0x475EBFC", Offset = "0x475EBFC", VA = "0x475EBFC")]
    private void ReflectView()
    {
    }

    [Token(Token = "0x6010524")]
    [Address(RVA = "0x475FD94", Offset = "0x475FD94", VA = "0x475FD94")]
    public void GetRewards(List<MissionRewardData> receivedItems, List<int> ids)
    {
    }

    [Token(Token = "0x6010525")]
    [Address(RVA = "0x476022C", Offset = "0x476022C", VA = "0x476022C")]
    public void GetProgressRewards(List<MissionRewardData> receivedItems, Action action = null)
    {
    }

    [Token(Token = "0x6010526")]
    [Address(RVA = "0x4760000", Offset = "0x4760000", VA = "0x4760000")]
    private void SetReceivedList(List<int> clearIds)
    {
    }

    [Token(Token = "0x6010527")]
    [Address(RVA = "0x4760494", Offset = "0x4760494", VA = "0x4760494")]
    public void SetMissionProgress()
    {
    }

    [Token(Token = "0x6010528")]
    [Address(RVA = "0x4760688", Offset = "0x4760688", VA = "0x4760688")]
    public void UpdateMissionProgress(Action OnCompleate)
    {
    }

    [Token(Token = "0x6010529")]
    [Address(RVA = "0x475FAB4", Offset = "0x475FAB4", VA = "0x475FAB4")]
    private TreasureType GetTreasureType(
      MissionProgressRewardData progressData,
      List<RewardConditionData> lastDataList)
    {
      return new TreasureType();
    }

    [Token(Token = "0x601052A")]
    [Address(RVA = "0x47608E4", Offset = "0x47608E4", VA = "0x47608E4")]
    private List<RewardConditionData> GetRewardCondition() => (List<RewardConditionData>) null;

    [Token(Token = "0x601052B")]
    [Address(RVA = "0x475FD4C", Offset = "0x475FD4C", VA = "0x475FD4C")]
    private int GetProgressRank() => new int();

    [Token(Token = "0x601052C")]
    [Address(RVA = "0x47608EC", Offset = "0x47608EC", VA = "0x47608EC")]
    private List<MissionDataList> GetMissionDataList() => (List<MissionDataList>) null;

    [Token(Token = "0x601052D")]
    [Address(RVA = "0x47608F4", Offset = "0x47608F4", VA = "0x47608F4")]
    public void Update()
    {
    }
  }
}
