// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryObliviaeBattleEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E5D")]
  public class APIStoryObliviaeBattleEnd
  {
    [Token(Token = "0x4008258")]
    public const string DefaultAPIPath = "api/v1/story/obliviae/battle/end";
    [Token(Token = "0x400825C")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400825D")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryObliviaeBattleEndResponse> onSuccess;
    [Token(Token = "0x400825E")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170024B1")]
    public APIStoryObliviaeBattleEndRequest Request
    {
      [Token(Token = "0x600B40B"), Address(RVA = "0x22E4B44", Offset = "0x22E4B44", VA = "0x22E4B44")] private get
      {
        return (APIStoryObliviaeBattleEndRequest) null;
      }
      [Token(Token = "0x600B40C"), Address(RVA = "0x22E4B4C", Offset = "0x22E4B4C", VA = "0x22E4B4C")] set
      {
      }
    }

    [Token(Token = "0x170024B2")]
    public APIStoryObliviaeBattleEndResponse Response
    {
      [Token(Token = "0x600B40D"), Address(RVA = "0x22E4B54", Offset = "0x22E4B54", VA = "0x22E4B54")] get
      {
        return (APIStoryObliviaeBattleEndResponse) null;
      }
      [Token(Token = "0x600B40E"), Address(RVA = "0x22E4B5C", Offset = "0x22E4B5C", VA = "0x22E4B5C")] private set
      {
      }
    }

    [Token(Token = "0x170024B3")]
    public int ResponseCode
    {
      [Token(Token = "0x600B40F"), Address(RVA = "0x22E4B64", Offset = "0x22E4B64", VA = "0x22E4B64")] get
      {
        return new int();
      }
      [Token(Token = "0x600B410"), Address(RVA = "0x22E4B6C", Offset = "0x22E4B6C", VA = "0x22E4B6C")] private set
      {
      }
    }

    [Token(Token = "0x170024B4")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B411"), Address(RVA = "0x22E4B74", Offset = "0x22E4B74", VA = "0x22E4B74")] set
      {
      }
      [Token(Token = "0x600B412"), Address(RVA = "0x22E4B90", Offset = "0x22E4B90", VA = "0x22E4B90")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B413")]
    [Address(RVA = "0x22E4BAC", Offset = "0x22E4BAC", VA = "0x22E4BAC")]
    public APIStoryObliviaeBattleEnd(string apiPath = "api/v1/story/obliviae/battle/end")
    {
    }

    [Token(Token = "0x600B414")]
    [Address(RVA = "0x22E4C44", Offset = "0x22E4C44", VA = "0x22E4C44")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B415")]
    [Address(RVA = "0x22E4CD4", Offset = "0x22E4CD4", VA = "0x22E4CD4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B416")]
    [Address(RVA = "0x22E4CE0", Offset = "0x22E4CE0", VA = "0x22E4CE0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B417")]
    [Address(RVA = "0x22E4DB4", Offset = "0x22E4DB4", VA = "0x22E4DB4")]
    private void OnSuccess(string json)
    {
    }
  }
}
