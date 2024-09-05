// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitRental_setting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001ED5")]
  public class APIUnitRental_setting
  {
    [Token(Token = "0x400846C")]
    public const string DefaultAPIPath = "api/v1/unit/rental_setting";
    [Token(Token = "0x4008470")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008471")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitRental_settingResponse> onSuccess;
    [Token(Token = "0x4008472")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170025E1")]
    public APIUnitRental_settingRequest Request
    {
      [Token(Token = "0x600B71B"), Address(RVA = "0x212F950", Offset = "0x212F950", VA = "0x212F950")] private get
      {
        return (APIUnitRental_settingRequest) null;
      }
      [Token(Token = "0x600B71C"), Address(RVA = "0x212F958", Offset = "0x212F958", VA = "0x212F958")] set
      {
      }
    }

    [Token(Token = "0x170025E2")]
    public APIUnitRental_settingResponse Response
    {
      [Token(Token = "0x600B71D"), Address(RVA = "0x212F960", Offset = "0x212F960", VA = "0x212F960")] get
      {
        return (APIUnitRental_settingResponse) null;
      }
      [Token(Token = "0x600B71E"), Address(RVA = "0x212F968", Offset = "0x212F968", VA = "0x212F968")] private set
      {
      }
    }

    [Token(Token = "0x170025E3")]
    public int ResponseCode
    {
      [Token(Token = "0x600B71F"), Address(RVA = "0x212F970", Offset = "0x212F970", VA = "0x212F970")] get
      {
        return new int();
      }
      [Token(Token = "0x600B720"), Address(RVA = "0x212F978", Offset = "0x212F978", VA = "0x212F978")] private set
      {
      }
    }

    [Token(Token = "0x170025E4")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B721"), Address(RVA = "0x212F980", Offset = "0x212F980", VA = "0x212F980")] set
      {
      }
      [Token(Token = "0x600B722"), Address(RVA = "0x212F99C", Offset = "0x212F99C", VA = "0x212F99C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B723")]
    [Address(RVA = "0x212F9B8", Offset = "0x212F9B8", VA = "0x212F9B8")]
    public APIUnitRental_setting(string apiPath = "api/v1/unit/rental_setting")
    {
    }

    [Token(Token = "0x600B724")]
    [Address(RVA = "0x212FA50", Offset = "0x212FA50", VA = "0x212FA50")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B725")]
    [Address(RVA = "0x212FAE0", Offset = "0x212FAE0", VA = "0x212FAE0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B726")]
    [Address(RVA = "0x212FAEC", Offset = "0x212FAEC", VA = "0x212FAEC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B727")]
    [Address(RVA = "0x212FBC0", Offset = "0x212FBC0", VA = "0x212FBC0")]
    private void OnSuccess(string json)
    {
    }
  }
}
