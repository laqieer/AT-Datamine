// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitReincarnationMemorize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EC9")]
  public class APIUnitReincarnationMemorize
  {
    [Token(Token = "0x4008435")]
    public const string DefaultAPIPath = "api/v1/unit/reincarnation/memorize";
    [Token(Token = "0x4008439")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400843A")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitReincarnationMemorizeResponse> onSuccess;
    [Token(Token = "0x400843B")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170025C4")]
    public APIUnitReincarnationMemorizeRequest Request
    {
      [Token(Token = "0x600B6CE"), Address(RVA = "0x22EDDD0", Offset = "0x22EDDD0", VA = "0x22EDDD0")] private get
      {
        return (APIUnitReincarnationMemorizeRequest) null;
      }
      [Token(Token = "0x600B6CF"), Address(RVA = "0x22EDDD8", Offset = "0x22EDDD8", VA = "0x22EDDD8")] set
      {
      }
    }

    [Token(Token = "0x170025C5")]
    public APIUnitReincarnationMemorizeResponse Response
    {
      [Token(Token = "0x600B6D0"), Address(RVA = "0x22EDDE0", Offset = "0x22EDDE0", VA = "0x22EDDE0")] get
      {
        return (APIUnitReincarnationMemorizeResponse) null;
      }
      [Token(Token = "0x600B6D1"), Address(RVA = "0x22EDDE8", Offset = "0x22EDDE8", VA = "0x22EDDE8")] private set
      {
      }
    }

    [Token(Token = "0x170025C6")]
    public int ResponseCode
    {
      [Token(Token = "0x600B6D2"), Address(RVA = "0x22EDDF0", Offset = "0x22EDDF0", VA = "0x22EDDF0")] get
      {
        return new int();
      }
      [Token(Token = "0x600B6D3"), Address(RVA = "0x22EDDF8", Offset = "0x22EDDF8", VA = "0x22EDDF8")] private set
      {
      }
    }

    [Token(Token = "0x170025C7")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B6D4"), Address(RVA = "0x22EDE00", Offset = "0x22EDE00", VA = "0x22EDE00")] set
      {
      }
      [Token(Token = "0x600B6D5"), Address(RVA = "0x22EDE1C", Offset = "0x22EDE1C", VA = "0x22EDE1C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B6D6")]
    [Address(RVA = "0x22EDE38", Offset = "0x22EDE38", VA = "0x22EDE38")]
    public APIUnitReincarnationMemorize(string apiPath = "api/v1/unit/reincarnation/memorize")
    {
    }

    [Token(Token = "0x600B6D7")]
    [Address(RVA = "0x22EDED0", Offset = "0x22EDED0", VA = "0x22EDED0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B6D8")]
    [Address(RVA = "0x22EDF60", Offset = "0x22EDF60", VA = "0x22EDF60")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B6D9")]
    [Address(RVA = "0x22EDF6C", Offset = "0x22EDF6C", VA = "0x22EDF6C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B6DA")]
    [Address(RVA = "0x22EE040", Offset = "0x22EE040", VA = "0x22EE040")]
    private void OnSuccess(string json)
    {
    }
  }
}
