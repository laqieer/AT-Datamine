// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackRuleRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E03")]
  [Serializable]
  public class APIScoreAttackRuleRequest
  {
    [Token(Token = "0x4008081")]
    [FieldOffset(Offset = "0x10")]
    public int score_attack_event_id;

    [Token(Token = "0x600B199")]
    [Address(RVA = "0x22DD20C", Offset = "0x22DD20C", VA = "0x22DD20C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B19A")]
    [Address(RVA = "0x22DD254", Offset = "0x22DD254", VA = "0x22DD254")]
    public APIScoreAttackRuleRequest()
    {
    }
  }
}
