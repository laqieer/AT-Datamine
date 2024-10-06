// Decompiled with JetBrains decompiler
// Type: Network.API.APIStory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E25")]
  public class APIStory
  {
    [Token(Token = "0x4008119")]
    public const string DefaultAPIPath = "api/v1/story";
    [Token(Token = "0x400811D")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400811E")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryResponse> onSuccess;
    [Token(Token = "0x400811F")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170023F8")]
    public APIStoryRequest Request
    {
      [Token(Token = "0x600B272"), Address(RVA = "0x22DFDF4", Offset = "0x22DFDF4", VA = "0x22DFDF4")] private get
      {
        return (APIStoryRequest) null;
      }
      [Token(Token = "0x600B273"), Address(RVA = "0x22DFDFC", Offset = "0x22DFDFC", VA = "0x22DFDFC")] set
      {
      }
    }

    [Token(Token = "0x170023F9")]
    public APIStoryResponse Response
    {
      [Token(Token = "0x600B274"), Address(RVA = "0x22DFE04", Offset = "0x22DFE04", VA = "0x22DFE04")] get
      {
        return (APIStoryResponse) null;
      }
      [Token(Token = "0x600B275"), Address(RVA = "0x22DFE0C", Offset = "0x22DFE0C", VA = "0x22DFE0C")] private set
      {
      }
    }

    [Token(Token = "0x170023FA")]
    public int ResponseCode
    {
      [Token(Token = "0x600B276"), Address(RVA = "0x22DFE14", Offset = "0x22DFE14", VA = "0x22DFE14")] get
      {
        return new int();
      }
      [Token(Token = "0x600B277"), Address(RVA = "0x22DFE1C", Offset = "0x22DFE1C", VA = "0x22DFE1C")] private set
      {
      }
    }

    [Token(Token = "0x170023FB")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B278"), Address(RVA = "0x22DFE24", Offset = "0x22DFE24", VA = "0x22DFE24")] set
      {
      }
      [Token(Token = "0x600B279"), Address(RVA = "0x22DFE40", Offset = "0x22DFE40", VA = "0x22DFE40")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B27A")]
    [Address(RVA = "0x22DFE5C", Offset = "0x22DFE5C", VA = "0x22DFE5C")]
    public APIStory(string apiPath = "api/v1/story")
    {
    }

    [Token(Token = "0x600B27B")]
    [Address(RVA = "0x22DFEF4", Offset = "0x22DFEF4", VA = "0x22DFEF4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B27C")]
    [Address(RVA = "0x22DFF84", Offset = "0x22DFF84", VA = "0x22DFF84")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B27D")]
    [Address(RVA = "0x22DFF90", Offset = "0x22DFF90", VA = "0x22DFF90")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B27E")]
    [Address(RVA = "0x22E0064", Offset = "0x22E0064", VA = "0x22E0064")]
    private void OnSuccess(string json)
    {
    }
  }
}
