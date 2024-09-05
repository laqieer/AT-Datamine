// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestRead
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E55")]
  public class APIStoryMainquestRead
  {
    [Token(Token = "0x4008222")]
    public const string DefaultAPIPath = "api/v1/story/mainquest/read";
    [Token(Token = "0x4008226")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008227")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryMainquestReadResponse> onSuccess;
    [Token(Token = "0x4008228")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002494")]
    public APIStoryMainquestReadRequest Request
    {
      [Token(Token = "0x600B3CE"), Address(RVA = "0x22E4024", Offset = "0x22E4024", VA = "0x22E4024")] private get
      {
        return (APIStoryMainquestReadRequest) null;
      }
      [Token(Token = "0x600B3CF"), Address(RVA = "0x22E402C", Offset = "0x22E402C", VA = "0x22E402C")] set
      {
      }
    }

    [Token(Token = "0x17002495")]
    public APIStoryMainquestReadResponse Response
    {
      [Token(Token = "0x600B3D0"), Address(RVA = "0x22E4034", Offset = "0x22E4034", VA = "0x22E4034")] get
      {
        return (APIStoryMainquestReadResponse) null;
      }
      [Token(Token = "0x600B3D1"), Address(RVA = "0x22E403C", Offset = "0x22E403C", VA = "0x22E403C")] private set
      {
      }
    }

    [Token(Token = "0x17002496")]
    public int ResponseCode
    {
      [Token(Token = "0x600B3D2"), Address(RVA = "0x22E4044", Offset = "0x22E4044", VA = "0x22E4044")] get
      {
        return new int();
      }
      [Token(Token = "0x600B3D3"), Address(RVA = "0x22E404C", Offset = "0x22E404C", VA = "0x22E404C")] private set
      {
      }
    }

    [Token(Token = "0x17002497")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B3D4"), Address(RVA = "0x22E4054", Offset = "0x22E4054", VA = "0x22E4054")] set
      {
      }
      [Token(Token = "0x600B3D5"), Address(RVA = "0x22E4070", Offset = "0x22E4070", VA = "0x22E4070")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B3D6")]
    [Address(RVA = "0x22E408C", Offset = "0x22E408C", VA = "0x22E408C")]
    public APIStoryMainquestRead(string apiPath = "api/v1/story/mainquest/read")
    {
    }

    [Token(Token = "0x600B3D7")]
    [Address(RVA = "0x22E4124", Offset = "0x22E4124", VA = "0x22E4124")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B3D8")]
    [Address(RVA = "0x22E41B4", Offset = "0x22E41B4", VA = "0x22E41B4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B3D9")]
    [Address(RVA = "0x22E41C0", Offset = "0x22E41C0", VA = "0x22E41C0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B3DA")]
    [Address(RVA = "0x22E4294", Offset = "0x22E4294", VA = "0x22E4294")]
    private void OnSuccess(string json)
    {
    }
  }
}
