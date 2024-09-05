// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnit_rankingRanking_topsResponse
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
  [Token(Token = "0x2001EE8")]
  [Serializable]
  public class APIUnit_rankingRanking_topsResponse : ICommonApiResult
  {
    [Token(Token = "0x40084B8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40084B9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<BaseRankingListType> ranking_tops;

    [Token(Token = "0x1700260D")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B796"), Address(RVA = "0x2131434", Offset = "0x2131434", VA = "0x2131434", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700260E")]
    public List<BaseRankingListType> RankingTops
    {
      [Token(Token = "0x600B797"), Address(RVA = "0x213143C", Offset = "0x213143C", VA = "0x213143C")] get
      {
        return (List<BaseRankingListType>) null;
      }
    }

    [Token(Token = "0x600B798")]
    [Address(RVA = "0x2131444", Offset = "0x2131444", VA = "0x2131444")]
    public APIUnit_rankingRanking_topsResponse()
    {
    }
  }
}
