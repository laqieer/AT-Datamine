// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestAdv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E45")]
  public class APIStoryMainquestAdv
  {
    [Token(Token = "0x40081B6")]
    public const string DefaultAPIPath = "api/v1/story/mainquest/adv";
    [Token(Token = "0x40081BA")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40081BB")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryMainquestAdvResponse> onSuccess;
    [Token(Token = "0x40081BC")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700245A")]
    public APIStoryMainquestAdvRequest Request
    {
      [Token(Token = "0x600B354"), Address(RVA = "0x22E29E4", Offset = "0x22E29E4", VA = "0x22E29E4")] private get
      {
        return (APIStoryMainquestAdvRequest) null;
      }
      [Token(Token = "0x600B355"), Address(RVA = "0x22E29EC", Offset = "0x22E29EC", VA = "0x22E29EC")] set
      {
      }
    }

    [Token(Token = "0x1700245B")]
    public APIStoryMainquestAdvResponse Response
    {
      [Token(Token = "0x600B356"), Address(RVA = "0x22E29F4", Offset = "0x22E29F4", VA = "0x22E29F4")] get
      {
        return (APIStoryMainquestAdvResponse) null;
      }
      [Token(Token = "0x600B357"), Address(RVA = "0x22E29FC", Offset = "0x22E29FC", VA = "0x22E29FC")] private set
      {
      }
    }

    [Token(Token = "0x1700245C")]
    public int ResponseCode
    {
      [Token(Token = "0x600B358"), Address(RVA = "0x22E2A04", Offset = "0x22E2A04", VA = "0x22E2A04")] get
      {
        return new int();
      }
      [Token(Token = "0x600B359"), Address(RVA = "0x22E2A0C", Offset = "0x22E2A0C", VA = "0x22E2A0C")] private set
      {
      }
    }

    [Token(Token = "0x1700245D")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B35A"), Address(RVA = "0x22E2A14", Offset = "0x22E2A14", VA = "0x22E2A14")] set
      {
      }
      [Token(Token = "0x600B35B"), Address(RVA = "0x22E2A30", Offset = "0x22E2A30", VA = "0x22E2A30")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B35C")]
    [Address(RVA = "0x22E2A4C", Offset = "0x22E2A4C", VA = "0x22E2A4C")]
    public APIStoryMainquestAdv(string apiPath = "api/v1/story/mainquest/adv")
    {
    }

    [Token(Token = "0x600B35D")]
    [Address(RVA = "0x22E2AE4", Offset = "0x22E2AE4", VA = "0x22E2AE4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B35E")]
    [Address(RVA = "0x22E2B74", Offset = "0x22E2B74", VA = "0x22E2B74")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B35F")]
    [Address(RVA = "0x22E2B80", Offset = "0x22E2B80", VA = "0x22E2B80")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B360")]
    [Address(RVA = "0x22E2C54", Offset = "0x22E2C54", VA = "0x22E2C54")]
    private void OnSuccess(string json)
    {
    }
  }
}
