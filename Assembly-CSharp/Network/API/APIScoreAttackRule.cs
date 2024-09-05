// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackRule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E05")]
  public class APIScoreAttackRule
  {
    [Token(Token = "0x4008083")]
    public const string DefaultAPIPath = "api/v1/score_attack/rule";
    [Token(Token = "0x4008087")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008088")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIScoreAttackRuleResponse> onSuccess;
    [Token(Token = "0x4008089")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170023A3")]
    public APIScoreAttackRuleRequest Request
    {
      [Token(Token = "0x600B19D"), Address(RVA = "0x22DD26C", Offset = "0x22DD26C", VA = "0x22DD26C")] private get
      {
        return (APIScoreAttackRuleRequest) null;
      }
      [Token(Token = "0x600B19E"), Address(RVA = "0x22DD274", Offset = "0x22DD274", VA = "0x22DD274")] set
      {
      }
    }

    [Token(Token = "0x170023A4")]
    public APIScoreAttackRuleResponse Response
    {
      [Token(Token = "0x600B19F"), Address(RVA = "0x22DD27C", Offset = "0x22DD27C", VA = "0x22DD27C")] get
      {
        return (APIScoreAttackRuleResponse) null;
      }
      [Token(Token = "0x600B1A0"), Address(RVA = "0x22DD284", Offset = "0x22DD284", VA = "0x22DD284")] private set
      {
      }
    }

    [Token(Token = "0x170023A5")]
    public int ResponseCode
    {
      [Token(Token = "0x600B1A1"), Address(RVA = "0x22DD28C", Offset = "0x22DD28C", VA = "0x22DD28C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B1A2"), Address(RVA = "0x22DD294", Offset = "0x22DD294", VA = "0x22DD294")] private set
      {
      }
    }

    [Token(Token = "0x170023A6")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B1A3"), Address(RVA = "0x22DD29C", Offset = "0x22DD29C", VA = "0x22DD29C")] set
      {
      }
      [Token(Token = "0x600B1A4"), Address(RVA = "0x22DD2B8", Offset = "0x22DD2B8", VA = "0x22DD2B8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B1A5")]
    [Address(RVA = "0x22DD2D4", Offset = "0x22DD2D4", VA = "0x22DD2D4")]
    public APIScoreAttackRule(string apiPath = "api/v1/score_attack/rule")
    {
    }

    [Token(Token = "0x600B1A6")]
    [Address(RVA = "0x22DD36C", Offset = "0x22DD36C", VA = "0x22DD36C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B1A7")]
    [Address(RVA = "0x22DD3FC", Offset = "0x22DD3FC", VA = "0x22DD3FC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B1A8")]
    [Address(RVA = "0x22DD408", Offset = "0x22DD408", VA = "0x22DD408")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B1A9")]
    [Address(RVA = "0x22DD4DC", Offset = "0x22DD4DC", VA = "0x22DD4DC")]
    private void OnSuccess(string json)
    {
    }
  }
}
