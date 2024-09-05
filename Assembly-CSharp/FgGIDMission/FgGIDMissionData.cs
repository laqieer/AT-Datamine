// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDMissionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x2001979")]
  public class FgGIDMissionData
  {
    [Token(Token = "0x17001768")]
    public int Id
    {
      [Token(Token = "0x6009159"), Address(RVA = "0x4D098EC", Offset = "0x4D098EC", VA = "0x4D098EC")] get
      {
        return new int();
      }
      [Token(Token = "0x600915A"), Address(RVA = "0x4D098F4", Offset = "0x4D098F4", VA = "0x4D098F4")] private set
      {
      }
    }

    [Token(Token = "0x17001769")]
    public int GameId
    {
      [Token(Token = "0x600915B"), Address(RVA = "0x4D098FC", Offset = "0x4D098FC", VA = "0x4D098FC")] get
      {
        return new int();
      }
      [Token(Token = "0x600915C"), Address(RVA = "0x4D09904", Offset = "0x4D09904", VA = "0x4D09904")] private set
      {
      }
    }

    [Token(Token = "0x1700176A")]
    public bool IsAchieved
    {
      [Token(Token = "0x600915D"), Address(RVA = "0x4D0990C", Offset = "0x4D0990C", VA = "0x4D0990C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600915E"), Address(RVA = "0x4D09914", Offset = "0x4D09914", VA = "0x4D09914")] private set
      {
      }
    }

    [Token(Token = "0x1700176B")]
    public bool IsReceived
    {
      [Token(Token = "0x600915F"), Address(RVA = "0x4D09920", Offset = "0x4D09920", VA = "0x4D09920")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009160"), Address(RVA = "0x4D09928", Offset = "0x4D09928", VA = "0x4D09928")] private set
      {
      }
    }

    [Token(Token = "0x1700176C")]
    public string Title
    {
      [Token(Token = "0x6009161"), Address(RVA = "0x4D09934", Offset = "0x4D09934", VA = "0x4D09934")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009162"), Address(RVA = "0x4D0993C", Offset = "0x4D0993C", VA = "0x4D0993C")] private set
      {
      }
    }

    [Token(Token = "0x1700176D")]
    public string Description
    {
      [Token(Token = "0x6009163"), Address(RVA = "0x4D09944", Offset = "0x4D09944", VA = "0x4D09944")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009164"), Address(RVA = "0x4D0994C", Offset = "0x4D0994C", VA = "0x4D0994C")] private set
      {
      }
    }

    [Token(Token = "0x1700176E")]
    public string RewardText
    {
      [Token(Token = "0x6009165"), Address(RVA = "0x4D09954", Offset = "0x4D09954", VA = "0x4D09954")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009166"), Address(RVA = "0x4D0995C", Offset = "0x4D0995C", VA = "0x4D0995C")] private set
      {
      }
    }

    [Token(Token = "0x1700176F")]
    public DateTime ChallengeEndAt
    {
      [Token(Token = "0x6009167"), Address(RVA = "0x4D09964", Offset = "0x4D09964", VA = "0x4D09964")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x6009168"), Address(RVA = "0x4D0996C", Offset = "0x4D0996C", VA = "0x4D0996C")] private set
      {
      }
    }

    [Token(Token = "0x17001770")]
    public DateTime RewardEndAt
    {
      [Token(Token = "0x6009169"), Address(RVA = "0x4D09974", Offset = "0x4D09974", VA = "0x4D09974")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600916A"), Address(RVA = "0x4D0997C", Offset = "0x4D0997C", VA = "0x4D0997C")] private set
      {
      }
    }

    [Token(Token = "0x17001771")]
    public bool IsReceivable
    {
      [Token(Token = "0x600916B"), Address(RVA = "0x4D09518", Offset = "0x4D09518", VA = "0x4D09518")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001772")]
    public List<FgGIDMissionRewardData> RewardData
    {
      [Token(Token = "0x600916C"), Address(RVA = "0x4D09984", Offset = "0x4D09984", VA = "0x4D09984")] get
      {
        return (List<FgGIDMissionRewardData>) null;
      }
      [Token(Token = "0x600916D"), Address(RVA = "0x4D0998C", Offset = "0x4D0998C", VA = "0x4D0998C")] private set
      {
      }
    }

    [Token(Token = "0x17001773")]
    public bool IsCoinMission
    {
      [Token(Token = "0x600916E"), Address(RVA = "0x4D09994", Offset = "0x4D09994", VA = "0x4D09994")] get
      {
        return new bool();
      }
      [Token(Token = "0x600916F"), Address(RVA = "0x4D0999C", Offset = "0x4D0999C", VA = "0x4D0999C")] private set
      {
      }
    }

    [Token(Token = "0x6009170")]
    [Address(RVA = "0x4D099A8", Offset = "0x4D099A8", VA = "0x4D099A8")]
    public static FgGIDMissionData CreateDummyData(
      string title,
      string description,
      string rewardText,
      string challengeEndAt,
      string rewardEndAt,
      bool isReceivable)
    {
      return (FgGIDMissionData) null;
    }

    [Token(Token = "0x6009171")]
    [Address(RVA = "0x4D09AB4", Offset = "0x4D09AB4", VA = "0x4D09AB4")]
    public static FgGIDMissionData CreateFromServerData(PlayerFggIDAchievementMission serverData)
    {
      return (FgGIDMissionData) null;
    }

    [Token(Token = "0x6009172")]
    [Address(RVA = "0x4D09DC8", Offset = "0x4D09DC8", VA = "0x4D09DC8")]
    public static List<FgGIDMissionData> CreateFromServerData(
      IEnumerable<PlayerFggIDAchievementMission> serverDatas)
    {
      return (List<FgGIDMissionData>) null;
    }

    [Token(Token = "0x6009173")]
    [Address(RVA = "0x4D09EDC", Offset = "0x4D09EDC", VA = "0x4D09EDC")]
    public static FgGIDMissionData CreateFromServerData(
      int ownGameId,
      PlayerFggfcCoinMission serverData)
    {
      return (FgGIDMissionData) null;
    }

    [Token(Token = "0x6009174")]
    [Address(RVA = "0x4D0A244", Offset = "0x4D0A244", VA = "0x4D0A244")]
    public static List<FgGIDMissionData> CreateFromServerData(
      int ownGameId,
      IEnumerable<PlayerFggfcCoinMission> serverDatas)
    {
      return (List<FgGIDMissionData>) null;
    }

    [Token(Token = "0x6009175")]
    [Address(RVA = "0x4D09374", Offset = "0x4D09374", VA = "0x4D09374")]
    public void ApplyReceived(bool isReceived)
    {
    }

    [Token(Token = "0x6009176")]
    [Address(RVA = "0x4D09AAC", Offset = "0x4D09AAC", VA = "0x4D09AAC")]
    public FgGIDMissionData()
    {
    }
  }
}
