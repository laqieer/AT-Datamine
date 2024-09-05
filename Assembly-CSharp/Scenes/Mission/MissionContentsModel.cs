// Decompiled with JetBrains decompiler
// Type: Scenes.Mission.MissionContentsModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network;
using Network.API;
using Network.Param;
using System;
using System.Collections;

#nullable disable
namespace Scenes.Mission
{
  [Token(Token = "0x2002A85")]
  public class MissionContentsModel
  {
    [Token(Token = "0x400B4FC")]
    [FieldOffset(Offset = "0x30")]
    private bool _useProgressReward;

    [Token(Token = "0x6010A42")]
    [Address(RVA = "0x4BCBE50", Offset = "0x4BCBE50", VA = "0x4BCBE50")]
    public static MissionContentsModel CreateDaily() => (MissionContentsModel) null;

    [Token(Token = "0x6010A43")]
    [Address(RVA = "0x4BCBFC0", Offset = "0x4BCBFC0", VA = "0x4BCBFC0")]
    public static MissionContentsModel CreateWeakly() => (MissionContentsModel) null;

    [Token(Token = "0x6010A44")]
    [Address(RVA = "0x4BCC0EC", Offset = "0x4BCC0EC", VA = "0x4BCC0EC")]
    public static MissionContentsModel CreateMain() => (MissionContentsModel) null;

    [Token(Token = "0x6010A45")]
    [Address(RVA = "0x4BCC218", Offset = "0x4BCC218", VA = "0x4BCC218")]
    public static MissionContentsModel CreateEvent() => (MissionContentsModel) null;

    [Token(Token = "0x6010A46")]
    [Address(RVA = "0x4BCC344", Offset = "0x4BCC344", VA = "0x4BCC344")]
    public static MissionContentsModel CreateDammy() => (MissionContentsModel) null;

    [Token(Token = "0x6010A47")]
    [Address(RVA = "0x4BCBF80", Offset = "0x4BCBF80", VA = "0x4BCBF80")]
    public MissionContentsModel(string title, int groupId, bool useProgressReward = false)
    {
    }

    [Token(Token = "0x170039B3")]
    public string Title
    {
      [Token(Token = "0x6010A48"), Address(RVA = "0x4BCC3C8", Offset = "0x4BCC3C8", VA = "0x4BCC3C8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170039B4")]
    public string AchivedTitle
    {
      [Token(Token = "0x6010A49"), Address(RVA = "0x4BCC3D0", Offset = "0x4BCC3D0", VA = "0x4BCC3D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170039B5")]
    public int GroupId
    {
      [Token(Token = "0x6010A4A"), Address(RVA = "0x4BCC460", Offset = "0x4BCC460", VA = "0x4BCC460")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170039B6")]
    public System.Collections.Generic.List<PlayerMissionProgressType> List
    {
      [Token(Token = "0x6010A4B"), Address(RVA = "0x4BCC468", Offset = "0x4BCC468", VA = "0x4BCC468")] get
      {
        return (System.Collections.Generic.List<PlayerMissionProgressType>) null;
      }
      [Token(Token = "0x6010A4C"), Address(RVA = "0x4BCC470", Offset = "0x4BCC470", VA = "0x4BCC470")] private set
      {
      }
    }

    [Token(Token = "0x170039B7")]
    public System.Collections.Generic.List<int> AcceptProgressRewardIds
    {
      [Token(Token = "0x6010A4D"), Address(RVA = "0x4BCC478", Offset = "0x4BCC478", VA = "0x4BCC478")] get
      {
        return (System.Collections.Generic.List<int>) null;
      }
      [Token(Token = "0x6010A4E"), Address(RVA = "0x4BCC480", Offset = "0x4BCC480", VA = "0x4BCC480")] private set
      {
      }
    }

    [Token(Token = "0x170039B8")]
    public bool UseProgressReward
    {
      [Token(Token = "0x6010A4F"), Address(RVA = "0x4BCBDC4", Offset = "0x4BCBDC4", VA = "0x4BCBDC4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6010A50")]
    [Address(RVA = "0x4BCBD5C", Offset = "0x4BCBD5C", VA = "0x4BCBD5C")]
    public IEnumerator Request() => (IEnumerator) null;

    [Token(Token = "0x6010A51")]
    [Address(RVA = "0x4BCC560", Offset = "0x4BCC560", VA = "0x4BCC560")]
    public System.Collections.Generic.List<PlayerMissionProgressType> VisibleList()
    {
      return (System.Collections.Generic.List<PlayerMissionProgressType>) null;
    }

    [Token(Token = "0x6010A52")]
    [Address(RVA = "0x4BCC71C", Offset = "0x4BCC71C", VA = "0x4BCC71C")]
    public bool HasAchivedNotAccepted() => new bool();

    [Token(Token = "0x6010A53")]
    [Address(RVA = "0x4BCAFB8", Offset = "0x4BCAFB8", VA = "0x4BCAFB8")]
    public IEnumerator RequestReceiveMissionReward(
      System.Collections.Generic.List<int> missionIds,
      Action<APIMissionAcceptResponse> successCallback,
      Func<NetworkErrorResult, IEnumerator> errorCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010A54")]
    [Address(RVA = "0x4BCB758", Offset = "0x4BCB758", VA = "0x4BCB758")]
    public IEnumerator RequestReceiveProgressReward(
      Action<APIMissionAccept_progress_rewardsResponse> successCallback,
      Func<NetworkErrorResult, IEnumerator> errorCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010A55")]
    [Address(RVA = "0x4BCB384", Offset = "0x4BCB384", VA = "0x4BCB384")]
    public int ProgressPoint() => new int();

    [Token(Token = "0x6010A56")]
    [Address(RVA = "0x4BCC890", Offset = "0x4BCC890", VA = "0x4BCC890")]
    public int ProgressPointMax() => new int();

    [Token(Token = "0x6010A57")]
    [Address(RVA = "0x4BCC964", Offset = "0x4BCC964", VA = "0x4BCC964")]
    public float ProgressViewRate() => new float();

    [Token(Token = "0x6010A58")]
    [Address(RVA = "0x4BCB5DC", Offset = "0x4BCB5DC", VA = "0x4BCB5DC")]
    public System.Collections.Generic.List<int> ProgressRewardsPoints() => (System.Collections.Generic.List<int>) null;

    [Token(Token = "0x6010A59")]
    [Address(RVA = "0x4BCC488", Offset = "0x4BCC488", VA = "0x4BCC488")]
    public bool HasProgressRewards() => new bool();

    [Token(Token = "0x6010A5A")]
    [Address(RVA = "0x4BCB7D4", Offset = "0x4BCB7D4", VA = "0x4BCB7D4")]
    public MissionProgressRewardDescriptionData GetProgressReward(int index)
    {
      return (MissionProgressRewardDescriptionData) null;
    }
  }
}
