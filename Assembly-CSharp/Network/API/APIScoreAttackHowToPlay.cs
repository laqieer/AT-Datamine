// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackHowToPlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DFD")]
  public class APIScoreAttackHowToPlay
  {
    [Token(Token = "0x4008069")]
    public const string DefaultAPIPath = "api/v1/score_attack/how_to_play";
    [Token(Token = "0x400806D")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400806E")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIScoreAttackHowToPlayResponse> onSuccess;
    [Token(Token = "0x400806F")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002395")]
    public APIScoreAttackHowToPlayRequest Request
    {
      [Token(Token = "0x600B16F"), Address(RVA = "0x22DC7C4", Offset = "0x22DC7C4", VA = "0x22DC7C4")] private get
      {
        return (APIScoreAttackHowToPlayRequest) null;
      }
      [Token(Token = "0x600B170"), Address(RVA = "0x22DC7CC", Offset = "0x22DC7CC", VA = "0x22DC7CC")] set
      {
      }
    }

    [Token(Token = "0x17002396")]
    public APIScoreAttackHowToPlayResponse Response
    {
      [Token(Token = "0x600B171"), Address(RVA = "0x22DC7D4", Offset = "0x22DC7D4", VA = "0x22DC7D4")] get
      {
        return (APIScoreAttackHowToPlayResponse) null;
      }
      [Token(Token = "0x600B172"), Address(RVA = "0x22DC7DC", Offset = "0x22DC7DC", VA = "0x22DC7DC")] private set
      {
      }
    }

    [Token(Token = "0x17002397")]
    public int ResponseCode
    {
      [Token(Token = "0x600B173"), Address(RVA = "0x22DC7E4", Offset = "0x22DC7E4", VA = "0x22DC7E4")] get
      {
        return new int();
      }
      [Token(Token = "0x600B174"), Address(RVA = "0x22DC7EC", Offset = "0x22DC7EC", VA = "0x22DC7EC")] private set
      {
      }
    }

    [Token(Token = "0x17002398")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B175"), Address(RVA = "0x22DC7F4", Offset = "0x22DC7F4", VA = "0x22DC7F4")] set
      {
      }
      [Token(Token = "0x600B176"), Address(RVA = "0x22DC810", Offset = "0x22DC810", VA = "0x22DC810")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B177")]
    [Address(RVA = "0x22DC82C", Offset = "0x22DC82C", VA = "0x22DC82C")]
    public APIScoreAttackHowToPlay(string apiPath = "api/v1/score_attack/how_to_play")
    {
    }

    [Token(Token = "0x600B178")]
    [Address(RVA = "0x22DC8C4", Offset = "0x22DC8C4", VA = "0x22DC8C4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B179")]
    [Address(RVA = "0x22DC954", Offset = "0x22DC954", VA = "0x22DC954")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B17A")]
    [Address(RVA = "0x22DC960", Offset = "0x22DC960", VA = "0x22DC960")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B17B")]
    [Address(RVA = "0x22DCA34", Offset = "0x22DCA34", VA = "0x22DCA34")]
    private void OnSuccess(string json)
    {
    }
  }
}
