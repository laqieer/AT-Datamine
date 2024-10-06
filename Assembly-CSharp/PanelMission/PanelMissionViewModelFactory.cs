// Decompiled with JetBrains decompiler
// Type: PanelMission.PanelMissionViewModelFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Network.Param;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace PanelMission
{
  [Token(Token = "0x2000A3D")]
  public class PanelMissionViewModelFactory
  {
    [Token(Token = "0x4002F7C")]
    [FieldOffset(Offset = "0x10")]
    private readonly MasterDataManager _masterDataManager;
    [Token(Token = "0x4002F7D")]
    [FieldOffset(Offset = "0x18")]
    private DateTime _now;

    [Token(Token = "0x6003A70")]
    [Address(RVA = "0x3310698", Offset = "0x3310698", VA = "0x3310698")]
    public PanelMissionViewModelFactory()
    {
    }

    [Token(Token = "0x6003A71")]
    [Address(RVA = "0x33160FC", Offset = "0x33160FC", VA = "0x33160FC")]
    public void UpdateClock()
    {
    }

    [Token(Token = "0x6003A72")]
    [Address(RVA = "0x3316158", Offset = "0x3316158", VA = "0x3316158")]
    private List<int> GetAvailableScheduleIds() => (List<int>) null;

    [Token(Token = "0x6003A73")]
    [Address(RVA = "0x3315CBC", Offset = "0x3315CBC", VA = "0x3315CBC")]
    public List<PanelMissionViewModelFactory.PanelMissionAvailableInfo> GetAvailablePanelMissions()
    {
      return (List<PanelMissionViewModelFactory.PanelMissionAvailableInfo>) null;
    }

    [Token(Token = "0x6003A74")]
    [Address(RVA = "0x3316374", Offset = "0x3316374", VA = "0x3316374")]
    public PanelMissionViewModelFactory.PanelMissionAvailableInfo GetPanelMissionAvailableInfo(
      PanelMissionData panelMissionData)
    {
      return (PanelMissionViewModelFactory.PanelMissionAvailableInfo) null;
    }

    [Token(Token = "0x6003A75")]
    [Address(RVA = "0x3316614", Offset = "0x3316614", VA = "0x3316614")]
    private List<MissionData> GetMissionsByPage(int panelMissionGroupId)
    {
      return (List<MissionData>) null;
    }

    [Token(Token = "0x6003A76")]
    [Address(RVA = "0x3310018", Offset = "0x3310018", VA = "0x3310018")]
    public List<PanelMissionViewModelFactory.PanelMissionPage> GetPanelMissionPages(
      int panelMissionId)
    {
      return (List<PanelMissionViewModelFactory.PanelMissionPage>) null;
    }

    [Token(Token = "0x6003A77")]
    [Address(RVA = "0x33167AC", Offset = "0x33167AC", VA = "0x33167AC")]
    public int GetPanelMissionFirstViewGroupId(int panelMissionId) => new int();

    [Token(Token = "0x6003A78")]
    [Address(RVA = "0x3316C30", Offset = "0x3316C30", VA = "0x3316C30")]
    public bool IsScheduleOutPanelMission(int panelMissionId) => new bool();

    [Token(Token = "0x6003A79")]
    [Address(RVA = "0x3316CC0", Offset = "0x3316CC0", VA = "0x3316CC0")]
    public List<PanelMissionViewModelFactory.SideBannerViewModel> GetSideBannerModels()
    {
      return (List<PanelMissionViewModelFactory.SideBannerViewModel>) null;
    }

    [Token(Token = "0x6003A7A")]
    [Address(RVA = "0x3310C10", Offset = "0x3310C10", VA = "0x3310C10")]
    public bool CanReceiveAnyRewardByPanelMissionId(int panelMissionId) => new bool();

    [Token(Token = "0x6003A7B")]
    [Address(RVA = "0x3316D8C", Offset = "0x3316D8C", VA = "0x3316D8C")]
    private PanelMissionViewModelFactory.SideBannerViewModel CreateSideBannerViewModel(
      PanelMissionViewModelFactory.PanelMissionAvailableInfo info)
    {
      return (PanelMissionViewModelFactory.SideBannerViewModel) null;
    }

    [Token(Token = "0x6003A7C")]
    [Address(RVA = "0x33170B0", Offset = "0x33170B0", VA = "0x33170B0")]
    public PanelMissionViewModelFactory.LineProgressViewModel GetLineProgressViewModel(
      int panelMissionId,
      int pageIndex)
    {
      return (PanelMissionViewModelFactory.LineProgressViewModel) null;
    }

    [Token(Token = "0x6003A7D")]
    [Address(RVA = "0x3317250", Offset = "0x3317250", VA = "0x3317250")]
    private PanelMissionViewModelFactory.PanelViewModel CreatePanelViewModel(
      PanelMissionViewModelFactory.PanelMissionPage page)
    {
      return (PanelMissionViewModelFactory.PanelViewModel) null;
    }

    [Token(Token = "0x6003A7E")]
    [Address(RVA = "0x3317728", Offset = "0x3317728", VA = "0x3317728")]
    private bool IsPanelLocked(PanelMissionViewModelFactory.PanelMissionPage page) => new bool();

    [Token(Token = "0x6003A7F")]
    [Address(RVA = "0x3317848", Offset = "0x3317848", VA = "0x3317848")]
    private bool IsPanelCleared(int panelMissionGroupId) => new bool();

    [Token(Token = "0x6003A80")]
    [Address(RVA = "0x3317350", Offset = "0x3317350", VA = "0x3317350")]
    private List<PanelMissionViewModelFactory.PanelElementViewModel> CreatePanelElementViewModels(
      PanelMissionViewModelFactory.PanelMissionPage page)
    {
      return (List<PanelMissionViewModelFactory.PanelElementViewModel>) null;
    }

    [Token(Token = "0x6003A81")]
    [Address(RVA = "0x3317E08", Offset = "0x3317E08", VA = "0x3317E08")]
    private PanelMissionViewModelFactory.PanelElementViewModel CreatePanelElementViewModel(
      MissionData missionData,
      PanelMissionViewModelFactory.PanelMissionPage page,
      int panelId,
      [CanBeNull] PlayerMissionProgressType missionProgress)
    {
      return (PanelMissionViewModelFactory.PanelElementViewModel) null;
    }

    [Token(Token = "0x6003A82")]
    [Address(RVA = "0x33179A8", Offset = "0x33179A8", VA = "0x33179A8")]
    private List<PlayerMissionProgressType> GetMissionProgresses(int panelMissionGroupId)
    {
      return (List<PlayerMissionProgressType>) null;
    }

    [Token(Token = "0x6003A83")]
    [Address(RVA = "0x3318230", Offset = "0x3318230", VA = "0x3318230")]
    private RarityTypeEnum GetRewardRarity(MissionRewardData data) => new RarityTypeEnum();

    [Token(Token = "0x6003A84")]
    [Address(RVA = "0x33182BC", Offset = "0x33182BC", VA = "0x33182BC")]
    private RarityTypeEnum GetRewardRarity(RewardTypeEnum typeId, int id) => new RarityTypeEnum();

    [Token(Token = "0x6003A85")]
    [Address(RVA = "0x3318268", Offset = "0x3318268", VA = "0x3318268")]
    private ItemUtility.RarityViewTypeEnum GetRewardRarityView(RewardTypeEnum typeId, int id)
    {
      return new ItemUtility.RarityViewTypeEnum();
    }

    [Token(Token = "0x6003A86")]
    [Address(RVA = "0x33182F0", Offset = "0x33182F0", VA = "0x33182F0")]
    private string GetRewardName(MissionRewardData data) => (string) null;

    [Token(Token = "0x6003A87")]
    [Address(RVA = "0x3318328", Offset = "0x3318328", VA = "0x3318328")]
    private string GetRewardName(RewardTypeEnum typeId, int id) => (string) null;

    [Token(Token = "0x6003A88")]
    [Address(RVA = "0x3317F78", Offset = "0x3317F78", VA = "0x3317F78")]
    private MissionRewardData GetMissionReward(MissionData data) => (MissionRewardData) null;

    [Token(Token = "0x6003A89")]
    [Address(RVA = "0x3316988", Offset = "0x3316988", VA = "0x3316988")]
    public List<PanelMissionViewModelFactory.PanelViewModel> GetPanelViewModel(int panelMissionId)
    {
      return (List<PanelMissionViewModelFactory.PanelViewModel>) null;
    }

    [Token(Token = "0x6003A8A")]
    [Address(RVA = "0x3313870", Offset = "0x3313870", VA = "0x3313870")]
    public PanelMissionViewModelFactory.MissionClearDialogViewModel CreateMissionClearDialogViewModel(
      int panelMissionGroupId,
      int panelIndex)
    {
      return (PanelMissionViewModelFactory.MissionClearDialogViewModel) null;
    }

    [Token(Token = "0x6003A8B")]
    [Address(RVA = "0x331071C", Offset = "0x331071C", VA = "0x331071C")]
    public PanelMissionViewModelFactory.LineRewardEarnedDialogViewModel CreateLineRewardEarnedDialogViewModel(
      int panelMissionGroupId,
      int lineNum)
    {
      return (PanelMissionViewModelFactory.LineRewardEarnedDialogViewModel) null;
    }

    [Token(Token = "0x6003A8C")]
    [Address(RVA = "0x331839C", Offset = "0x331839C", VA = "0x331839C")]
    private PanelMissionViewModelFactory.MissionChallengeInfo GetChallengeInfo(
      MissionData missionData)
    {
      return (PanelMissionViewModelFactory.MissionChallengeInfo) null;
    }

    [Token(Token = "0x6003A8D")]
    [Address(RVA = "0x3318874", Offset = "0x3318874", VA = "0x3318874")]
    private PanelMissionViewModelFactory.MissionChallengeInfo CreateCannotChallengeInfo(
      MissionUnlockDescriptionData data)
    {
      return (PanelMissionViewModelFactory.MissionChallengeInfo) null;
    }

    [Token(Token = "0x6003A8E")]
    [Address(RVA = "0x3318804", Offset = "0x3318804", VA = "0x3318804")]
    private bool CanChallenge(MissionUnlockTypeEnum unlockType, int value1, int value2)
    {
      return new bool();
    }

    [Token(Token = "0x6003A8F")]
    [Address(RVA = "0x3318B28", Offset = "0x3318B28", VA = "0x3318B28")]
    private bool IsMissionCleared(int missionId) => new bool();

    [Token(Token = "0x6003A90")]
    [Address(RVA = "0x3318C40", Offset = "0x3318C40", VA = "0x3318C40")]
    public PanelMissionViewModelFactory.MissionDetailDialogViewModel CreateMissionDetailDialogViewModel(
      int panelMissionGroupId,
      int panelIndex)
    {
      return (PanelMissionViewModelFactory.MissionDetailDialogViewModel) null;
    }

    [Token(Token = "0x6003A91")]
    [Address(RVA = "0x3318F78", Offset = "0x3318F78", VA = "0x3318F78")]
    private List<MissionData> GetPanelMission(int panelMissionGroupId) => (List<MissionData>) null;

    [Token(Token = "0x6003A92")]
    [Address(RVA = "0x3313AC4", Offset = "0x3313AC4", VA = "0x3313AC4")]
    public List<PanelMissionLineRewardEffect.LineEffectId> GetPanelMissionClearedLineIds(
      int panelMissionGroupId)
    {
      return (List<PanelMissionLineRewardEffect.LineEffectId>) null;
    }

    [Token(Token = "0x6003A93")]
    [Address(RVA = "0x3314C58", Offset = "0x3314C58", VA = "0x3314C58")]
    public int GetPanelMissionClearedLineNum(int panelMissionGroupId) => new int();

    [Token(Token = "0x6003A94")]
    [Address(RVA = "0x3319110", Offset = "0x3319110", VA = "0x3319110")]
    private PanelMissionViewModelFactory.MissionLineRewardViewModel CreateMissionLineRewardViewModel(
      MissionProgressRewardData reward,
      MissionProgressRewardDescriptionData firstViewReward,
      int totalLineCount)
    {
      return (PanelMissionViewModelFactory.MissionLineRewardViewModel) null;
    }

    [Token(Token = "0x6003A95")]
    [Address(RVA = "0x3319208", Offset = "0x3319208", VA = "0x3319208")]
    public List<PanelMissionViewModelFactory.MissionLineRewardViewModel> CreateMissionLineRewardViewModelList(
      int panelMissionGroupId)
    {
      return (List<PanelMissionViewModelFactory.MissionLineRewardViewModel>) null;
    }

    [Token(Token = "0x6003A96")]
    [Address(RVA = "0x331478C", Offset = "0x331478C", VA = "0x331478C")]
    public int GetPanelMissionIdByGroupId(int panelMissionGroupId) => new int();

    [Token(Token = "0x6003A97")]
    [Address(RVA = "0x3311958", Offset = "0x3311958", VA = "0x3311958")]
    public List<int> GetUnreceivedPanelIds(int panelMissionGroupId) => (List<int>) null;

    [Token(Token = "0x2000A3E")]
    public class SideBannerViewModel
    {
      [Token(Token = "0x4002F7E")]
      [FieldOffset(Offset = "0x10")]
      public int PanelMissionId;
      [Token(Token = "0x4002F7F")]
      [FieldOffset(Offset = "0x18")]
      public string MissionName;
      [Token(Token = "0x4002F80")]
      [FieldOffset(Offset = "0x20")]
      public int RemainDays;
      [Token(Token = "0x4002F81")]
      [FieldOffset(Offset = "0x24")]
      public int RemainHours;
      [Token(Token = "0x4002F82")]
      [FieldOffset(Offset = "0x28")]
      public int RemainMinutes;
      [Token(Token = "0x4002F83")]
      [FieldOffset(Offset = "0x2C")]
      public bool IsReceiveRewardPeriod;
      [Token(Token = "0x4002F84")]
      [FieldOffset(Offset = "0x30")]
      public int ReceiveRewardRemainDays;
      [Token(Token = "0x4002F85")]
      [FieldOffset(Offset = "0x34")]
      public int ReceiveRewardRemainHours;
      [Token(Token = "0x4002F86")]
      [FieldOffset(Offset = "0x38")]
      public int ReceiveRewardRemainMinutes;
      [Token(Token = "0x4002F87")]
      [FieldOffset(Offset = "0x3C")]
      public bool CanReceiveAnyRewards;

      [Token(Token = "0x6003A99")]
      [Address(RVA = "0x33170A8", Offset = "0x33170A8", VA = "0x33170A8")]
      public SideBannerViewModel()
      {
      }
    }

    [Token(Token = "0x2000A3F")]
    public class PanelMissionAvailableInfo
    {
      [Token(Token = "0x4002F88")]
      [FieldOffset(Offset = "0x10")]
      public int PanelMissionId;
      [Token(Token = "0x4002F89")]
      [FieldOffset(Offset = "0x14")]
      public int PanelMissionGroupId;
      [Token(Token = "0x4002F8A")]
      [FieldOffset(Offset = "0x18")]
      public bool IsAvailable;
      [Token(Token = "0x4002F8B")]
      [FieldOffset(Offset = "0x19")]
      public bool IsReceiveRewardOnly;
      [Token(Token = "0x4002F8C")]
      [FieldOffset(Offset = "0x1C")]
      public int AvailableScheduleId;
      [Token(Token = "0x4002F8D")]
      [FieldOffset(Offset = "0x20")]
      public int ReceiveRewardScheduleId;

      [Token(Token = "0x6003A9A")]
      [Address(RVA = "0x3316794", Offset = "0x3316794", VA = "0x3316794")]
      public PanelMissionAvailableInfo()
      {
      }
    }

    [Token(Token = "0x2000A40")]
    public class PanelMissionPage
    {
      [Token(Token = "0x4002F8E")]
      [FieldOffset(Offset = "0x10")]
      public int PanelMissionId;
      [Token(Token = "0x4002F8F")]
      [FieldOffset(Offset = "0x14")]
      public int PanelMissionGroupId;
      [Token(Token = "0x4002F90")]
      [FieldOffset(Offset = "0x18")]
      public int BannerId;
      [Token(Token = "0x4002F91")]
      [FieldOffset(Offset = "0x1C")]
      public int PageIndex;

      [Token(Token = "0x6003A9B")]
      [Address(RVA = "0x33197DC", Offset = "0x33197DC", VA = "0x33197DC")]
      public PanelMissionPage()
      {
      }
    }

    [Token(Token = "0x2000A41")]
    public class LineProgressViewModel
    {
      [Token(Token = "0x4002F92")]
      [FieldOffset(Offset = "0x10")]
      public int PanelMissionGroupId;
      [Token(Token = "0x4002F93")]
      [FieldOffset(Offset = "0x14")]
      public int PageIndex;
      [Token(Token = "0x4002F94")]
      [FieldOffset(Offset = "0x18")]
      public int LinesDone;
      [Token(Token = "0x4002F95")]
      [FieldOffset(Offset = "0x1C")]
      public int BannerId;

      [Token(Token = "0x6003A9C")]
      [Address(RVA = "0x3317248", Offset = "0x3317248", VA = "0x3317248")]
      public LineProgressViewModel()
      {
      }
    }

    [Token(Token = "0x2000A42")]
    public class PanelViewModel
    {
      [Token(Token = "0x4002F96")]
      [FieldOffset(Offset = "0x10")]
      public int PanelMissionId;
      [Token(Token = "0x4002F97")]
      [FieldOffset(Offset = "0x14")]
      public int PanelMissionGroupId;
      [Token(Token = "0x4002F98")]
      [FieldOffset(Offset = "0x18")]
      public int PageIndex;
      [Token(Token = "0x4002F99")]
      [FieldOffset(Offset = "0x20")]
      public string MissionName;
      [Token(Token = "0x4002F9A")]
      [FieldOffset(Offset = "0x28")]
      public List<PanelMissionViewModelFactory.PanelElementViewModel> Elements;
      [Token(Token = "0x4002F9B")]
      [FieldOffset(Offset = "0x30")]
      public bool IsLocked;

      [Token(Token = "0x6003A9D")]
      [Address(RVA = "0x3317838", Offset = "0x3317838", VA = "0x3317838")]
      public PanelViewModel()
      {
      }
    }

    [Token(Token = "0x2000A43")]
    public class PanelElementViewModel
    {
      [Token(Token = "0x4002F9C")]
      [FieldOffset(Offset = "0x10")]
      public int PanelMissionGroupId;
      [Token(Token = "0x4002F9D")]
      [FieldOffset(Offset = "0x14")]
      public int MissionId;
      [Token(Token = "0x4002F9E")]
      [FieldOffset(Offset = "0x18")]
      public int PanelIndex;
      [Token(Token = "0x4002F9F")]
      [FieldOffset(Offset = "0x1C")]
      public bool Cleared;
      [Token(Token = "0x4002FA0")]
      [FieldOffset(Offset = "0x1D")]
      public bool RewardReceived;
      [Token(Token = "0x4002FA1")]
      [FieldOffset(Offset = "0x20")]
      public int ProgressMax;
      [Token(Token = "0x4002FA2")]
      [FieldOffset(Offset = "0x24")]
      public int ProgressDone;
      [Token(Token = "0x4002FA3")]
      [FieldOffset(Offset = "0x28")]
      public string MissionTitle;
      [Token(Token = "0x4002FA4")]
      [FieldOffset(Offset = "0x30")]
      public RewardTypeEnum RewardTypeEnum;
      [Token(Token = "0x4002FA5")]
      [FieldOffset(Offset = "0x34")]
      public int ItemId;
      [Token(Token = "0x4002FA6")]
      [FieldOffset(Offset = "0x38")]
      public int ItemNum;
      [Token(Token = "0x4002FA7")]
      [FieldOffset(Offset = "0x3C")]
      public RarityTypeEnum ItemRarity;
      [Token(Token = "0x4002FA8")]
      [FieldOffset(Offset = "0x40")]
      public ItemUtility.RarityViewTypeEnum RarityViewType;

      [Token(Token = "0x6003A9E")]
      [Address(RVA = "0x331829C", Offset = "0x331829C", VA = "0x331829C")]
      public PanelElementViewModel()
      {
      }
    }

    [Token(Token = "0x2000A44")]
    public class MissionClearDialogViewModel
    {
      [Token(Token = "0x4002FA9")]
      [FieldOffset(Offset = "0x10")]
      public int PanelMissionGroupId;
      [Token(Token = "0x4002FAA")]
      [FieldOffset(Offset = "0x14")]
      public int MissionId;
      [Token(Token = "0x4002FAB")]
      [FieldOffset(Offset = "0x18")]
      public int PanelIndex;
      [Token(Token = "0x4002FAC")]
      [FieldOffset(Offset = "0x20")]
      public string ContentText;
      [Token(Token = "0x4002FAD")]
      [FieldOffset(Offset = "0x28")]
      public RewardTypeEnum RewardTypeEnum;
      [Token(Token = "0x4002FAE")]
      [FieldOffset(Offset = "0x2C")]
      public int RewardId;
      [Token(Token = "0x4002FAF")]
      [FieldOffset(Offset = "0x30")]
      public int RewardNum;
      [Token(Token = "0x4002FB0")]
      [FieldOffset(Offset = "0x34")]
      public RarityTypeEnum RewardRarity;

      [Token(Token = "0x6003A9F")]
      [Address(RVA = "0x3318374", Offset = "0x3318374", VA = "0x3318374")]
      public MissionClearDialogViewModel()
      {
      }
    }

    [Token(Token = "0x2000A45")]
    public class LineRewardEarnedDialogViewModel
    {
      [Token(Token = "0x4002FB1")]
      [FieldOffset(Offset = "0x10")]
      public int PanelMissionGroupId;
      [Token(Token = "0x4002FB2")]
      [FieldOffset(Offset = "0x14")]
      public int LineNum;
      [Token(Token = "0x4002FB3")]
      [FieldOffset(Offset = "0x18")]
      public string ContentText;
      [Token(Token = "0x4002FB4")]
      [FieldOffset(Offset = "0x20")]
      public RewardTypeEnum RewardTypeEnum;
      [Token(Token = "0x4002FB5")]
      [FieldOffset(Offset = "0x24")]
      public int RewardId;
      [Token(Token = "0x4002FB6")]
      [FieldOffset(Offset = "0x28")]
      public int RewardNum;
      [Token(Token = "0x4002FB7")]
      [FieldOffset(Offset = "0x2C")]
      public RarityTypeEnum RewardRarity;

      [Token(Token = "0x6003AA0")]
      [Address(RVA = "0x331838C", Offset = "0x331838C", VA = "0x331838C")]
      public LineRewardEarnedDialogViewModel()
      {
      }
    }

    [Token(Token = "0x2000A46")]
    public class MissionDetailDialogViewModel
    {
      [Token(Token = "0x4002FB8")]
      [FieldOffset(Offset = "0x10")]
      public int PanelMissionGroupId;
      [Token(Token = "0x4002FB9")]
      [FieldOffset(Offset = "0x14")]
      public int MissionId;
      [Token(Token = "0x4002FBA")]
      [FieldOffset(Offset = "0x18")]
      public int PanelIndex;
      [Token(Token = "0x4002FBB")]
      [FieldOffset(Offset = "0x20")]
      public DateTime TimeLimit;
      [Token(Token = "0x4002FBC")]
      [FieldOffset(Offset = "0x28")]
      public string MissionTitle;
      [Token(Token = "0x4002FBD")]
      [FieldOffset(Offset = "0x30")]
      public string MissionDescription;
      [Token(Token = "0x4002FBE")]
      [FieldOffset(Offset = "0x38")]
      public int MissionProgressDone;
      [Token(Token = "0x4002FBF")]
      [FieldOffset(Offset = "0x3C")]
      public int MissionProgressMax;
      [Token(Token = "0x4002FC0")]
      [FieldOffset(Offset = "0x40")]
      public bool CanMissionChallenge;
      [Token(Token = "0x4002FC1")]
      [FieldOffset(Offset = "0x48")]
      public string CannotChallengeToasterTitle;
      [Token(Token = "0x4002FC2")]
      [FieldOffset(Offset = "0x50")]
      public string CannotChallengeToasterMessage;
      [Token(Token = "0x4002FC3")]
      [FieldOffset(Offset = "0x58")]
      public string RewardName;
      [Token(Token = "0x4002FC4")]
      [FieldOffset(Offset = "0x60")]
      public RewardTypeEnum RewardTypeEnum;
      [Token(Token = "0x4002FC5")]
      [FieldOffset(Offset = "0x64")]
      public int RewardId;
      [Token(Token = "0x4002FC6")]
      [FieldOffset(Offset = "0x68")]
      public int RewardNum;
      [Token(Token = "0x4002FC7")]
      [FieldOffset(Offset = "0x6C")]
      public RarityTypeEnum RewardRarity;
      [Token(Token = "0x4002FC8")]
      [FieldOffset(Offset = "0x70")]
      public ItemUtility.RarityViewTypeEnum RewardRarityView;

      [Token(Token = "0x6003AA1")]
      [Address(RVA = "0x33197E4", Offset = "0x33197E4", VA = "0x33197E4")]
      private TimeSpan GetMissionTimeLimit() => new TimeSpan();

      [Token(Token = "0x17000864")]
      public int MissionTimeLimitDays
      {
        [Token(Token = "0x6003AA2"), Address(RVA = "0x3319914", Offset = "0x3319914", VA = "0x3319914")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17000865")]
      public int MissionTimeLimitHours
      {
        [Token(Token = "0x6003AA3"), Address(RVA = "0x33199A0", Offset = "0x33199A0", VA = "0x33199A0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17000866")]
      public int MissionTimeLimitMinutes
      {
        [Token(Token = "0x6003AA4"), Address(RVA = "0x3319A14", Offset = "0x3319A14", VA = "0x3319A14")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6003AA5")]
      [Address(RVA = "0x3318F68", Offset = "0x3318F68", VA = "0x3318F68")]
      public MissionDetailDialogViewModel()
      {
      }
    }

    [Token(Token = "0x2000A47")]
    private class MissionChallengeInfo
    {
      [Token(Token = "0x4002FC9")]
      [FieldOffset(Offset = "0x10")]
      public bool CanChallenge;
      [Token(Token = "0x4002FCA")]
      [FieldOffset(Offset = "0x18")]
      public string CannotChallengeReasonTitle;
      [Token(Token = "0x4002FCB")]
      [FieldOffset(Offset = "0x20")]
      public string CannotChallengeReasonMessage;

      [Token(Token = "0x6003AA6")]
      [Address(RVA = "0x33187FC", Offset = "0x33187FC", VA = "0x33187FC")]
      public MissionChallengeInfo()
      {
      }
    }

    [Token(Token = "0x2000A48")]
    public class MissionLineRewardViewModel
    {
      [Token(Token = "0x4002FCC")]
      [FieldOffset(Offset = "0x10")]
      public int PanelMissionGroupId;
      [Token(Token = "0x4002FCD")]
      [FieldOffset(Offset = "0x14")]
      public RewardTypeEnum RewardTypeEnum;
      [Token(Token = "0x4002FCE")]
      [FieldOffset(Offset = "0x18")]
      public int RewardId;
      [Token(Token = "0x4002FCF")]
      [FieldOffset(Offset = "0x1C")]
      public ItemUtility.RarityViewTypeEnum RarityViewType;
      [Token(Token = "0x4002FD0")]
      [FieldOffset(Offset = "0x20")]
      public RarityTypeEnum RewardRarity;
      [Token(Token = "0x4002FD1")]
      [FieldOffset(Offset = "0x24")]
      public int LineNum;
      [Token(Token = "0x4002FD2")]
      [FieldOffset(Offset = "0x28")]
      public bool Earned;

      [Token(Token = "0x6003AA7")]
      [Address(RVA = "0x33191F8", Offset = "0x33191F8", VA = "0x33191F8")]
      public MissionLineRewardViewModel()
      {
      }
    }
  }
}
