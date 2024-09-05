// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnit_rankingPower_rankingResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EE4")]
  [Serializable]
  public class APIUnit_rankingPower_rankingResponse : ICommonApiResult
  {
    [Token(Token = "0x40084A9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40084AA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BaseRankingListType power_ranking;
    [Token(Token = "0x40084AB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BasePowerRankingType my_ranking;
    [Token(Token = "0x40084AC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int ranking_count;

    [Token(Token = "0x17002603")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B77C"), Address(RVA = "0x2130EC8", Offset = "0x2130EC8", VA = "0x2130EC8", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002604")]
    public BaseRankingListType PowerRanking
    {
      [Token(Token = "0x600B77D"), Address(RVA = "0x2130ED0", Offset = "0x2130ED0", VA = "0x2130ED0")] get
      {
        return (BaseRankingListType) null;
      }
    }

    [Token(Token = "0x17002605")]
    public BasePowerRankingType MyRanking
    {
      [Token(Token = "0x600B77E"), Address(RVA = "0x2130ED8", Offset = "0x2130ED8", VA = "0x2130ED8")] get
      {
        return (BasePowerRankingType) null;
      }
    }

    [Token(Token = "0x17002606")]
    public int RankingCount
    {
      [Token(Token = "0x600B77F"), Address(RVA = "0x2130EE0", Offset = "0x2130EE0", VA = "0x2130EE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600B780")]
    [Address(RVA = "0x2130EE8", Offset = "0x2130EE8", VA = "0x2130EE8")]
    public APIUnit_rankingPower_rankingResponse()
    {
    }
  }
}
