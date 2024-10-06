// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildAttendResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CA4")]
  [Serializable]
  public class APIGuildAttendResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007A71")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007A72")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007A73")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007A74")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int today_attend_count;
    [Token(Token = "0x4007A75")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int yesterday_attend_count;
    [Token(Token = "0x4007A76")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string attend_time_limit;
    [Token(Token = "0x4007A77")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<RewardGiveResultEntityType> reward_results;

    [Token(Token = "0x17002038")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A8B1"), Address(RVA = "0x1912CB8", Offset = "0x1912CB8", VA = "0x1912CB8", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002039")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A8B2"), Address(RVA = "0x1912CC0", Offset = "0x1912CC0", VA = "0x1912CC0", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x1700203A")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A8B3"), Address(RVA = "0x1912CC8", Offset = "0x1912CC8", VA = "0x1912CC8", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x1700203B")]
    public int TodayAttendCount
    {
      [Token(Token = "0x600A8B4"), Address(RVA = "0x1912CD0", Offset = "0x1912CD0", VA = "0x1912CD0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700203C")]
    public int YesterdayAttendCount
    {
      [Token(Token = "0x600A8B5"), Address(RVA = "0x1912CD8", Offset = "0x1912CD8", VA = "0x1912CD8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700203D")]
    public string AttendTimeLimit
    {
      [Token(Token = "0x600A8B6"), Address(RVA = "0x1912CE0", Offset = "0x1912CE0", VA = "0x1912CE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700203E")]
    public List<RewardGiveResultEntityType> RewardResults
    {
      [Token(Token = "0x600A8B7"), Address(RVA = "0x1912CE8", Offset = "0x1912CE8", VA = "0x1912CE8")] get
      {
        return (List<RewardGiveResultEntityType>) null;
      }
    }

    [Token(Token = "0x600A8B8")]
    [Address(RVA = "0x1912CF0", Offset = "0x1912CF0", VA = "0x1912CF0")]
    public APIGuildAttendResponse()
    {
    }
  }
}
