// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitSell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001ED9")]
  public class APIUnitSell
  {
    [Token(Token = "0x400847A")]
    public const string DefaultAPIPath = "api/v1/unit/sell";
    [Token(Token = "0x400847E")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400847F")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitSellResponse> onSuccess;
    [Token(Token = "0x4008480")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170025E9")]
    public APIUnitSellRequest Request
    {
      [Token(Token = "0x600B733"), Address(RVA = "0x212FEAC", Offset = "0x212FEAC", VA = "0x212FEAC")] private get
      {
        return (APIUnitSellRequest) null;
      }
      [Token(Token = "0x600B734"), Address(RVA = "0x212FEB4", Offset = "0x212FEB4", VA = "0x212FEB4")] set
      {
      }
    }

    [Token(Token = "0x170025EA")]
    public APIUnitSellResponse Response
    {
      [Token(Token = "0x600B735"), Address(RVA = "0x212FEBC", Offset = "0x212FEBC", VA = "0x212FEBC")] get
      {
        return (APIUnitSellResponse) null;
      }
      [Token(Token = "0x600B736"), Address(RVA = "0x212FEC4", Offset = "0x212FEC4", VA = "0x212FEC4")] private set
      {
      }
    }

    [Token(Token = "0x170025EB")]
    public int ResponseCode
    {
      [Token(Token = "0x600B737"), Address(RVA = "0x212FECC", Offset = "0x212FECC", VA = "0x212FECC")] get
      {
        return new int();
      }
      [Token(Token = "0x600B738"), Address(RVA = "0x212FED4", Offset = "0x212FED4", VA = "0x212FED4")] private set
      {
      }
    }

    [Token(Token = "0x170025EC")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B739"), Address(RVA = "0x212FEDC", Offset = "0x212FEDC", VA = "0x212FEDC")] set
      {
      }
      [Token(Token = "0x600B73A"), Address(RVA = "0x212FEF8", Offset = "0x212FEF8", VA = "0x212FEF8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B73B")]
    [Address(RVA = "0x212FF14", Offset = "0x212FF14", VA = "0x212FF14")]
    public APIUnitSell(string apiPath = "api/v1/unit/sell")
    {
    }

    [Token(Token = "0x600B73C")]
    [Address(RVA = "0x212FFAC", Offset = "0x212FFAC", VA = "0x212FFAC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B73D")]
    [Address(RVA = "0x213003C", Offset = "0x213003C", VA = "0x213003C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B73E")]
    [Address(RVA = "0x2130048", Offset = "0x2130048", VA = "0x2130048")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B73F")]
    [Address(RVA = "0x213011C", Offset = "0x213011C", VA = "0x213011C")]
    private void OnSuccess(string json)
    {
    }
  }
}
