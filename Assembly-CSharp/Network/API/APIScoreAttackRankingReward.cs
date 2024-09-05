// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackRankingReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E01")]
  public class APIScoreAttackRankingReward
  {
    [Token(Token = "0x4008076")]
    public const string DefaultAPIPath = "api/v1/score_attack/ranking_reward";
    [Token(Token = "0x400807A")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400807B")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIScoreAttackRankingRewardResponse> onSuccess;
    [Token(Token = "0x400807C")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700239C")]
    public APIScoreAttackRankingRewardRequest Request
    {
      [Token(Token = "0x600B186"), Address(RVA = "0x22DCD18", Offset = "0x22DCD18", VA = "0x22DCD18")] private get
      {
        return (APIScoreAttackRankingRewardRequest) null;
      }
      [Token(Token = "0x600B187"), Address(RVA = "0x22DCD20", Offset = "0x22DCD20", VA = "0x22DCD20")] set
      {
      }
    }

    [Token(Token = "0x1700239D")]
    public APIScoreAttackRankingRewardResponse Response
    {
      [Token(Token = "0x600B188"), Address(RVA = "0x22DCD28", Offset = "0x22DCD28", VA = "0x22DCD28")] get
      {
        return (APIScoreAttackRankingRewardResponse) null;
      }
      [Token(Token = "0x600B189"), Address(RVA = "0x22DCD30", Offset = "0x22DCD30", VA = "0x22DCD30")] private set
      {
      }
    }

    [Token(Token = "0x1700239E")]
    public int ResponseCode
    {
      [Token(Token = "0x600B18A"), Address(RVA = "0x22DCD38", Offset = "0x22DCD38", VA = "0x22DCD38")] get
      {
        return new int();
      }
      [Token(Token = "0x600B18B"), Address(RVA = "0x22DCD40", Offset = "0x22DCD40", VA = "0x22DCD40")] private set
      {
      }
    }

    [Token(Token = "0x1700239F")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B18C"), Address(RVA = "0x22DCD48", Offset = "0x22DCD48", VA = "0x22DCD48")] set
      {
      }
      [Token(Token = "0x600B18D"), Address(RVA = "0x22DCD64", Offset = "0x22DCD64", VA = "0x22DCD64")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B18E")]
    [Address(RVA = "0x22DCD80", Offset = "0x22DCD80", VA = "0x22DCD80")]
    public APIScoreAttackRankingReward(string apiPath = "api/v1/score_attack/ranking_reward")
    {
    }

    [Token(Token = "0x600B18F")]
    [Address(RVA = "0x22DCE18", Offset = "0x22DCE18", VA = "0x22DCE18")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B190")]
    [Address(RVA = "0x22DCEA8", Offset = "0x22DCEA8", VA = "0x22DCEA8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B191")]
    [Address(RVA = "0x22DCEB4", Offset = "0x22DCEB4", VA = "0x22DCEB4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B192")]
    [Address(RVA = "0x22DCF88", Offset = "0x22DCF88", VA = "0x22DCF88")]
    private void OnSuccess(string json)
    {
    }
  }
}
