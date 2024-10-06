// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackBattleStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DF9")]
  public class APIScoreAttackBattleStart
  {
    [Token(Token = "0x400805C")]
    public const string DefaultAPIPath = "api/v1/score_attack/battle/start";
    [Token(Token = "0x4008060")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008061")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIScoreAttackBattleStartResponse> onSuccess;
    [Token(Token = "0x4008062")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700238E")]
    public APIScoreAttackBattleStartRequest Request
    {
      [Token(Token = "0x600B158"), Address(RVA = "0x22DC270", Offset = "0x22DC270", VA = "0x22DC270")] private get
      {
        return (APIScoreAttackBattleStartRequest) null;
      }
      [Token(Token = "0x600B159"), Address(RVA = "0x22DC278", Offset = "0x22DC278", VA = "0x22DC278")] set
      {
      }
    }

    [Token(Token = "0x1700238F")]
    public APIScoreAttackBattleStartResponse Response
    {
      [Token(Token = "0x600B15A"), Address(RVA = "0x22DC280", Offset = "0x22DC280", VA = "0x22DC280")] get
      {
        return (APIScoreAttackBattleStartResponse) null;
      }
      [Token(Token = "0x600B15B"), Address(RVA = "0x22DC288", Offset = "0x22DC288", VA = "0x22DC288")] private set
      {
      }
    }

    [Token(Token = "0x17002390")]
    public int ResponseCode
    {
      [Token(Token = "0x600B15C"), Address(RVA = "0x22DC290", Offset = "0x22DC290", VA = "0x22DC290")] get
      {
        return new int();
      }
      [Token(Token = "0x600B15D"), Address(RVA = "0x22DC298", Offset = "0x22DC298", VA = "0x22DC298")] private set
      {
      }
    }

    [Token(Token = "0x17002391")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B15E"), Address(RVA = "0x22DC2A0", Offset = "0x22DC2A0", VA = "0x22DC2A0")] set
      {
      }
      [Token(Token = "0x600B15F"), Address(RVA = "0x22DC2BC", Offset = "0x22DC2BC", VA = "0x22DC2BC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B160")]
    [Address(RVA = "0x22DC2D8", Offset = "0x22DC2D8", VA = "0x22DC2D8")]
    public APIScoreAttackBattleStart(string apiPath = "api/v1/score_attack/battle/start")
    {
    }

    [Token(Token = "0x600B161")]
    [Address(RVA = "0x22DC370", Offset = "0x22DC370", VA = "0x22DC370")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B162")]
    [Address(RVA = "0x22DC400", Offset = "0x22DC400", VA = "0x22DC400")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B163")]
    [Address(RVA = "0x22DC40C", Offset = "0x22DC40C", VA = "0x22DC40C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B164")]
    [Address(RVA = "0x22DC4E0", Offset = "0x22DC4E0", VA = "0x22DC4E0")]
    private void OnSuccess(string json)
    {
    }
  }
}
