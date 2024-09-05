// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardCustomaResumeResponse
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
  [Token(Token = "0x2001E90")]
  [Serializable]
  public class APIUnitAbilityboardCustomaResumeResponse
  {
    [Token(Token = "0x4008353")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string player_unit_id;
    [Token(Token = "0x4008354")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerUnitAbilityBoardCustomALotteryType> lottery_results;

    [Token(Token = "0x17002541")]
    public string PlayerUnitId
    {
      [Token(Token = "0x600B56A"), Address(RVA = "0x22E9228", Offset = "0x22E9228", VA = "0x22E9228")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002542")]
    public List<PlayerUnitAbilityBoardCustomALotteryType> LotteryResults
    {
      [Token(Token = "0x600B56B"), Address(RVA = "0x22E9230", Offset = "0x22E9230", VA = "0x22E9230")] get
      {
        return (List<PlayerUnitAbilityBoardCustomALotteryType>) null;
      }
    }

    [Token(Token = "0x600B56C")]
    [Address(RVA = "0x22E9238", Offset = "0x22E9238", VA = "0x22E9238")]
    public APIUnitAbilityboardCustomaResumeResponse()
    {
    }
  }
}
