// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryObliviaeExit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E65")]
  public class APIStoryObliviaeExit
  {
    [Token(Token = "0x4008286")]
    public const string DefaultAPIPath = "api/v1/story/obliviae/exit";
    [Token(Token = "0x400828A")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400828B")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryObliviaeExitResponse> onSuccess;
    [Token(Token = "0x400828C")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170024CC")]
    public APIStoryObliviaeExitRequest Request
    {
      [Token(Token = "0x600B446"), Address(RVA = "0x22E5654", Offset = "0x22E5654", VA = "0x22E5654")] private get
      {
        return (APIStoryObliviaeExitRequest) null;
      }
      [Token(Token = "0x600B447"), Address(RVA = "0x22E565C", Offset = "0x22E565C", VA = "0x22E565C")] set
      {
      }
    }

    [Token(Token = "0x170024CD")]
    public APIStoryObliviaeExitResponse Response
    {
      [Token(Token = "0x600B448"), Address(RVA = "0x22E5664", Offset = "0x22E5664", VA = "0x22E5664")] get
      {
        return (APIStoryObliviaeExitResponse) null;
      }
      [Token(Token = "0x600B449"), Address(RVA = "0x22E566C", Offset = "0x22E566C", VA = "0x22E566C")] private set
      {
      }
    }

    [Token(Token = "0x170024CE")]
    public int ResponseCode
    {
      [Token(Token = "0x600B44A"), Address(RVA = "0x22E5674", Offset = "0x22E5674", VA = "0x22E5674")] get
      {
        return new int();
      }
      [Token(Token = "0x600B44B"), Address(RVA = "0x22E567C", Offset = "0x22E567C", VA = "0x22E567C")] private set
      {
      }
    }

    [Token(Token = "0x170024CF")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B44C"), Address(RVA = "0x22E5684", Offset = "0x22E5684", VA = "0x22E5684")] set
      {
      }
      [Token(Token = "0x600B44D"), Address(RVA = "0x22E56A0", Offset = "0x22E56A0", VA = "0x22E56A0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B44E")]
    [Address(RVA = "0x22E56BC", Offset = "0x22E56BC", VA = "0x22E56BC")]
    public APIStoryObliviaeExit(string apiPath = "api/v1/story/obliviae/exit")
    {
    }

    [Token(Token = "0x600B44F")]
    [Address(RVA = "0x22E5754", Offset = "0x22E5754", VA = "0x22E5754")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B450")]
    [Address(RVA = "0x22E57E4", Offset = "0x22E57E4", VA = "0x22E57E4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B451")]
    [Address(RVA = "0x22E57F0", Offset = "0x22E57F0", VA = "0x22E57F0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B452")]
    [Address(RVA = "0x22E58C4", Offset = "0x22E58C4", VA = "0x22E58C4")]
    private void OnSuccess(string json)
    {
    }
  }
}
