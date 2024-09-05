// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnit_rankingPower_ranking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EE5")]
  public class APIUnit_rankingPower_ranking
  {
    [Token(Token = "0x40084AD")]
    public const string DefaultAPIPath = "api/v1/unit_ranking/power_ranking";
    [Token(Token = "0x40084B1")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40084B2")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnit_rankingPower_rankingResponse> onSuccess;
    [Token(Token = "0x40084B3")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002607")]
    public APIUnit_rankingPower_rankingRequest Request
    {
      [Token(Token = "0x600B781"), Address(RVA = "0x2130EF0", Offset = "0x2130EF0", VA = "0x2130EF0")] private get
      {
        return (APIUnit_rankingPower_rankingRequest) null;
      }
      [Token(Token = "0x600B782"), Address(RVA = "0x2130EF8", Offset = "0x2130EF8", VA = "0x2130EF8")] set
      {
      }
    }

    [Token(Token = "0x17002608")]
    public APIUnit_rankingPower_rankingResponse Response
    {
      [Token(Token = "0x600B783"), Address(RVA = "0x2130F00", Offset = "0x2130F00", VA = "0x2130F00")] get
      {
        return (APIUnit_rankingPower_rankingResponse) null;
      }
      [Token(Token = "0x600B784"), Address(RVA = "0x2130F08", Offset = "0x2130F08", VA = "0x2130F08")] private set
      {
      }
    }

    [Token(Token = "0x17002609")]
    public int ResponseCode
    {
      [Token(Token = "0x600B785"), Address(RVA = "0x2130F10", Offset = "0x2130F10", VA = "0x2130F10")] get
      {
        return new int();
      }
      [Token(Token = "0x600B786"), Address(RVA = "0x2130F18", Offset = "0x2130F18", VA = "0x2130F18")] private set
      {
      }
    }

    [Token(Token = "0x1700260A")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B787"), Address(RVA = "0x2130F20", Offset = "0x2130F20", VA = "0x2130F20")] set
      {
      }
      [Token(Token = "0x600B788"), Address(RVA = "0x2130F3C", Offset = "0x2130F3C", VA = "0x2130F3C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B789")]
    [Address(RVA = "0x2130F58", Offset = "0x2130F58", VA = "0x2130F58")]
    public APIUnit_rankingPower_ranking(string apiPath = "api/v1/unit_ranking/power_ranking")
    {
    }

    [Token(Token = "0x600B78A")]
    [Address(RVA = "0x2130FF0", Offset = "0x2130FF0", VA = "0x2130FF0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B78B")]
    [Address(RVA = "0x2131080", Offset = "0x2131080", VA = "0x2131080")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B78C")]
    [Address(RVA = "0x213108C", Offset = "0x213108C", VA = "0x213108C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B78D")]
    [Address(RVA = "0x2131160", Offset = "0x2131160", VA = "0x2131160")]
    private void OnSuccess(string json)
    {
    }
  }
}
