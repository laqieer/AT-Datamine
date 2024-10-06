// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestCommunication
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E51")]
  public class APIStoryMainquestCommunication
  {
    [Token(Token = "0x400820D")]
    public const string DefaultAPIPath = "api/v1/story/mainquest/communication";
    [Token(Token = "0x4008211")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008212")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryMainquestCommunicationResponse> onSuccess;
    [Token(Token = "0x4008213")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002486")]
    public APIStoryMainquestCommunicationRequest Request
    {
      [Token(Token = "0x600B3B0"), Address(RVA = "0x22E3A98", Offset = "0x22E3A98", VA = "0x22E3A98")] private get
      {
        return (APIStoryMainquestCommunicationRequest) null;
      }
      [Token(Token = "0x600B3B1"), Address(RVA = "0x22E3AA0", Offset = "0x22E3AA0", VA = "0x22E3AA0")] set
      {
      }
    }

    [Token(Token = "0x17002487")]
    public APIStoryMainquestCommunicationResponse Response
    {
      [Token(Token = "0x600B3B2"), Address(RVA = "0x22E3AA8", Offset = "0x22E3AA8", VA = "0x22E3AA8")] get
      {
        return (APIStoryMainquestCommunicationResponse) null;
      }
      [Token(Token = "0x600B3B3"), Address(RVA = "0x22E3AB0", Offset = "0x22E3AB0", VA = "0x22E3AB0")] private set
      {
      }
    }

    [Token(Token = "0x17002488")]
    public int ResponseCode
    {
      [Token(Token = "0x600B3B4"), Address(RVA = "0x22E3AB8", Offset = "0x22E3AB8", VA = "0x22E3AB8")] get
      {
        return new int();
      }
      [Token(Token = "0x600B3B5"), Address(RVA = "0x22E3AC0", Offset = "0x22E3AC0", VA = "0x22E3AC0")] private set
      {
      }
    }

    [Token(Token = "0x17002489")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B3B6"), Address(RVA = "0x22E3AC8", Offset = "0x22E3AC8", VA = "0x22E3AC8")] set
      {
      }
      [Token(Token = "0x600B3B7"), Address(RVA = "0x22E3AE4", Offset = "0x22E3AE4", VA = "0x22E3AE4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B3B8")]
    [Address(RVA = "0x22E3B00", Offset = "0x22E3B00", VA = "0x22E3B00")]
    public APIStoryMainquestCommunication(string apiPath = "api/v1/story/mainquest/communication")
    {
    }

    [Token(Token = "0x600B3B9")]
    [Address(RVA = "0x22E3B98", Offset = "0x22E3B98", VA = "0x22E3B98")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B3BA")]
    [Address(RVA = "0x22E3C28", Offset = "0x22E3C28", VA = "0x22E3C28")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B3BB")]
    [Address(RVA = "0x22E3C34", Offset = "0x22E3C34", VA = "0x22E3C34")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B3BC")]
    [Address(RVA = "0x22E3D08", Offset = "0x22E3D08", VA = "0x22E3D08")]
    private void OnSuccess(string json)
    {
    }
  }
}
