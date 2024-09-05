// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestTutorial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E59")]
  public class APIStoryMainquestTutorial
  {
    [Token(Token = "0x4008236")]
    public const string DefaultAPIPath = "api/v1/story/mainquest/tutorial";
    [Token(Token = "0x400823A")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400823B")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryMainquestTutorialResponse> onSuccess;
    [Token(Token = "0x400823C")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170024A2")]
    public APIStoryMainquestTutorialRequest Request
    {
      [Token(Token = "0x600B3EC"), Address(RVA = "0x22E45B0", Offset = "0x22E45B0", VA = "0x22E45B0")] private get
      {
        return (APIStoryMainquestTutorialRequest) null;
      }
      [Token(Token = "0x600B3ED"), Address(RVA = "0x22E45B8", Offset = "0x22E45B8", VA = "0x22E45B8")] set
      {
      }
    }

    [Token(Token = "0x170024A3")]
    public APIStoryMainquestTutorialResponse Response
    {
      [Token(Token = "0x600B3EE"), Address(RVA = "0x22E45C0", Offset = "0x22E45C0", VA = "0x22E45C0")] get
      {
        return (APIStoryMainquestTutorialResponse) null;
      }
      [Token(Token = "0x600B3EF"), Address(RVA = "0x22E45C8", Offset = "0x22E45C8", VA = "0x22E45C8")] private set
      {
      }
    }

    [Token(Token = "0x170024A4")]
    public int ResponseCode
    {
      [Token(Token = "0x600B3F0"), Address(RVA = "0x22E45D0", Offset = "0x22E45D0", VA = "0x22E45D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600B3F1"), Address(RVA = "0x22E45D8", Offset = "0x22E45D8", VA = "0x22E45D8")] private set
      {
      }
    }

    [Token(Token = "0x170024A5")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B3F2"), Address(RVA = "0x22E45E0", Offset = "0x22E45E0", VA = "0x22E45E0")] set
      {
      }
      [Token(Token = "0x600B3F3"), Address(RVA = "0x22E45FC", Offset = "0x22E45FC", VA = "0x22E45FC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B3F4")]
    [Address(RVA = "0x22E4618", Offset = "0x22E4618", VA = "0x22E4618")]
    public APIStoryMainquestTutorial(string apiPath = "api/v1/story/mainquest/tutorial")
    {
    }

    [Token(Token = "0x600B3F5")]
    [Address(RVA = "0x22E46B0", Offset = "0x22E46B0", VA = "0x22E46B0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B3F6")]
    [Address(RVA = "0x22E4740", Offset = "0x22E4740", VA = "0x22E4740")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B3F7")]
    [Address(RVA = "0x22E474C", Offset = "0x22E474C", VA = "0x22E474C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B3F8")]
    [Address(RVA = "0x22E4820", Offset = "0x22E4820", VA = "0x22E4820")]
    private void OnSuccess(string json)
    {
    }
  }
}
