// Decompiled with JetBrains decompiler
// Type: Network.API.APITotal_missionAcceptResponse
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
  [Token(Token = "0x2001E84")]
  [Serializable]
  public class APITotal_missionAcceptResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4008323")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008324")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008325")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4008326")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<int> now_accepted_mission_ids;
    [Token(Token = "0x4008327")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<TotalMissionTabType> tab_infos;

    [Token(Token = "0x17002524")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B51D"), Address(RVA = "0x22E81EC", Offset = "0x22E81EC", VA = "0x22E81EC", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002525")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B51E"), Address(RVA = "0x22E81F4", Offset = "0x22E81F4", VA = "0x22E81F4", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002526")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B51F"), Address(RVA = "0x22E81FC", Offset = "0x22E81FC", VA = "0x22E81FC", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002527")]
    public List<int> NowAcceptedMissionIds
    {
      [Token(Token = "0x600B520"), Address(RVA = "0x22E8204", Offset = "0x22E8204", VA = "0x22E8204")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x17002528")]
    public List<TotalMissionTabType> TabInfos
    {
      [Token(Token = "0x600B521"), Address(RVA = "0x22E820C", Offset = "0x22E820C", VA = "0x22E820C")] get
      {
        return (List<TotalMissionTabType>) null;
      }
    }

    [Token(Token = "0x600B522")]
    [Address(RVA = "0x22E8214", Offset = "0x22E8214", VA = "0x22E8214")]
    public APITotal_missionAcceptResponse()
    {
    }
  }
}
