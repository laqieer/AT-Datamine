// Decompiled with JetBrains decompiler
// Type: Network.API.APIStorySubquestAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E71")]
  public class APIStorySubquestAction
  {
    [Token(Token = "0x40082BA")]
    public const string DefaultAPIPath = "api/v1/story/subquest/action";
    [Token(Token = "0x40082BE")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40082BF")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStorySubquestActionResponse> onSuccess;
    [Token(Token = "0x40082C0")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170024ED")]
    public APIStorySubquestActionRequest Request
    {
      [Token(Token = "0x600B497"), Address(RVA = "0x22E66B0", Offset = "0x22E66B0", VA = "0x22E66B0")] private get
      {
        return (APIStorySubquestActionRequest) null;
      }
      [Token(Token = "0x600B498"), Address(RVA = "0x22E66B8", Offset = "0x22E66B8", VA = "0x22E66B8")] set
      {
      }
    }

    [Token(Token = "0x170024EE")]
    public APIStorySubquestActionResponse Response
    {
      [Token(Token = "0x600B499"), Address(RVA = "0x22E66C0", Offset = "0x22E66C0", VA = "0x22E66C0")] get
      {
        return (APIStorySubquestActionResponse) null;
      }
      [Token(Token = "0x600B49A"), Address(RVA = "0x22E66C8", Offset = "0x22E66C8", VA = "0x22E66C8")] private set
      {
      }
    }

    [Token(Token = "0x170024EF")]
    public int ResponseCode
    {
      [Token(Token = "0x600B49B"), Address(RVA = "0x22E66D0", Offset = "0x22E66D0", VA = "0x22E66D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600B49C"), Address(RVA = "0x22E66D8", Offset = "0x22E66D8", VA = "0x22E66D8")] private set
      {
      }
    }

    [Token(Token = "0x170024F0")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B49D"), Address(RVA = "0x22E66E0", Offset = "0x22E66E0", VA = "0x22E66E0")] set
      {
      }
      [Token(Token = "0x600B49E"), Address(RVA = "0x22E66FC", Offset = "0x22E66FC", VA = "0x22E66FC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B49F")]
    [Address(RVA = "0x22E6718", Offset = "0x22E6718", VA = "0x22E6718")]
    public APIStorySubquestAction(string apiPath = "api/v1/story/subquest/action")
    {
    }

    [Token(Token = "0x600B4A0")]
    [Address(RVA = "0x22E67B0", Offset = "0x22E67B0", VA = "0x22E67B0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B4A1")]
    [Address(RVA = "0x22E6840", Offset = "0x22E6840", VA = "0x22E6840")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B4A2")]
    [Address(RVA = "0x22E684C", Offset = "0x22E684C", VA = "0x22E684C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B4A3")]
    [Address(RVA = "0x22E6920", Offset = "0x22E6920", VA = "0x22E6920")]
    private void OnSuccess(string json)
    {
    }
  }
}
