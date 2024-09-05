// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DD1")]
  public class APIScenarioEvent
  {
    [Token(Token = "0x4007F5C")]
    public const string DefaultAPIPath = "api/v1/scenario_event";
    [Token(Token = "0x4007F60")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007F61")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIScenarioEventResponse> onSuccess;
    [Token(Token = "0x4007F62")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002315")]
    public APIScenarioEventRequest Request
    {
      [Token(Token = "0x600B03F"), Address(RVA = "0x1A52D3C", Offset = "0x1A52D3C", VA = "0x1A52D3C")] private get
      {
        return (APIScenarioEventRequest) null;
      }
      [Token(Token = "0x600B040"), Address(RVA = "0x1A52D44", Offset = "0x1A52D44", VA = "0x1A52D44")] set
      {
      }
    }

    [Token(Token = "0x17002316")]
    public APIScenarioEventResponse Response
    {
      [Token(Token = "0x600B041"), Address(RVA = "0x1A52D4C", Offset = "0x1A52D4C", VA = "0x1A52D4C")] get
      {
        return (APIScenarioEventResponse) null;
      }
      [Token(Token = "0x600B042"), Address(RVA = "0x1A52D54", Offset = "0x1A52D54", VA = "0x1A52D54")] private set
      {
      }
    }

    [Token(Token = "0x17002317")]
    public int ResponseCode
    {
      [Token(Token = "0x600B043"), Address(RVA = "0x1A52D5C", Offset = "0x1A52D5C", VA = "0x1A52D5C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B044"), Address(RVA = "0x1A52D64", Offset = "0x1A52D64", VA = "0x1A52D64")] private set
      {
      }
    }

    [Token(Token = "0x17002318")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B045"), Address(RVA = "0x1A52D6C", Offset = "0x1A52D6C", VA = "0x1A52D6C")] set
      {
      }
      [Token(Token = "0x600B046"), Address(RVA = "0x1A52D88", Offset = "0x1A52D88", VA = "0x1A52D88")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B047")]
    [Address(RVA = "0x1A52DA4", Offset = "0x1A52DA4", VA = "0x1A52DA4")]
    public APIScenarioEvent(string apiPath = "api/v1/scenario_event")
    {
    }

    [Token(Token = "0x600B048")]
    [Address(RVA = "0x1A52E3C", Offset = "0x1A52E3C", VA = "0x1A52E3C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B049")]
    [Address(RVA = "0x1A52ECC", Offset = "0x1A52ECC", VA = "0x1A52ECC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B04A")]
    [Address(RVA = "0x1A52ED8", Offset = "0x1A52ED8", VA = "0x1A52ED8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B04B")]
    [Address(RVA = "0x1A52FAC", Offset = "0x1A52FAC", VA = "0x1A52FAC")]
    private void OnSuccess(string json)
    {
    }
  }
}
