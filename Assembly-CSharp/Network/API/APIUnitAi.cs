// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EA5")]
  public class APIUnitAi
  {
    [Token(Token = "0x40083B1")]
    public const string DefaultAPIPath = "api/v1/unit/ai";
    [Token(Token = "0x40083B5")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40083B6")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitAiResponse> onSuccess;
    [Token(Token = "0x40083B7")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700257B")]
    public APIUnitAiRequest Request
    {
      [Token(Token = "0x600B5F5"), Address(RVA = "0x22EAD8C", Offset = "0x22EAD8C", VA = "0x22EAD8C")] private get
      {
        return (APIUnitAiRequest) null;
      }
      [Token(Token = "0x600B5F6"), Address(RVA = "0x22EAD94", Offset = "0x22EAD94", VA = "0x22EAD94")] set
      {
      }
    }

    [Token(Token = "0x1700257C")]
    public APIUnitAiResponse Response
    {
      [Token(Token = "0x600B5F7"), Address(RVA = "0x22EAD9C", Offset = "0x22EAD9C", VA = "0x22EAD9C")] get
      {
        return (APIUnitAiResponse) null;
      }
      [Token(Token = "0x600B5F8"), Address(RVA = "0x22EADA4", Offset = "0x22EADA4", VA = "0x22EADA4")] private set
      {
      }
    }

    [Token(Token = "0x1700257D")]
    public int ResponseCode
    {
      [Token(Token = "0x600B5F9"), Address(RVA = "0x22EADAC", Offset = "0x22EADAC", VA = "0x22EADAC")] get
      {
        return new int();
      }
      [Token(Token = "0x600B5FA"), Address(RVA = "0x22EADB4", Offset = "0x22EADB4", VA = "0x22EADB4")] private set
      {
      }
    }

    [Token(Token = "0x1700257E")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B5FB"), Address(RVA = "0x22EADBC", Offset = "0x22EADBC", VA = "0x22EADBC")] set
      {
      }
      [Token(Token = "0x600B5FC"), Address(RVA = "0x22EADD8", Offset = "0x22EADD8", VA = "0x22EADD8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B5FD")]
    [Address(RVA = "0x22EADF4", Offset = "0x22EADF4", VA = "0x22EADF4")]
    public APIUnitAi(string apiPath = "api/v1/unit/ai")
    {
    }

    [Token(Token = "0x600B5FE")]
    [Address(RVA = "0x22EAE8C", Offset = "0x22EAE8C", VA = "0x22EAE8C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B5FF")]
    [Address(RVA = "0x22EAF1C", Offset = "0x22EAF1C", VA = "0x22EAF1C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B600")]
    [Address(RVA = "0x22EAF28", Offset = "0x22EAF28", VA = "0x22EAF28")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B601")]
    [Address(RVA = "0x22EAFFC", Offset = "0x22EAFFC", VA = "0x22EAFFC")]
    private void OnSuccess(string json)
    {
    }
  }
}
