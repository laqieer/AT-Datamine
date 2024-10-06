// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackRankingRewardRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DFF")]
  [Serializable]
  public class APIScoreAttackRankingRewardRequest
  {
    [Token(Token = "0x4008074")]
    [FieldOffset(Offset = "0x10")]
    public int score_attack_event_id;

    [Token(Token = "0x600B182")]
    [Address(RVA = "0x22DCCB8", Offset = "0x22DCCB8", VA = "0x22DCCB8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B183")]
    [Address(RVA = "0x22DCD00", Offset = "0x22DCD00", VA = "0x22DCD00")]
    public APIScoreAttackRankingRewardRequest()
    {
    }
  }
}
