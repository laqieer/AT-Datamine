// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionSoul_tankLevel_up
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C35")]
  public class APIExpeditionSoul_tankLevel_up
  {
    [Token(Token = "0x40078C5")]
    public const string DefaultAPIPath = "api/v1/expedition/soul_tank/level_up";
    [Token(Token = "0x40078C9")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40078CA")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIExpeditionSoul_tankLevel_upResponse> onSuccess;
    [Token(Token = "0x40078CB")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001F46")]
    public APIExpeditionSoul_tankLevel_upRequest Request
    {
      [Token(Token = "0x600A600"), Address(RVA = "0x1909620", Offset = "0x1909620", VA = "0x1909620")] private get
      {
        return (APIExpeditionSoul_tankLevel_upRequest) null;
      }
      [Token(Token = "0x600A601"), Address(RVA = "0x1909628", Offset = "0x1909628", VA = "0x1909628")] set
      {
      }
    }

    [Token(Token = "0x17001F47")]
    public APIExpeditionSoul_tankLevel_upResponse Response
    {
      [Token(Token = "0x600A602"), Address(RVA = "0x1909630", Offset = "0x1909630", VA = "0x1909630")] get
      {
        return (APIExpeditionSoul_tankLevel_upResponse) null;
      }
      [Token(Token = "0x600A603"), Address(RVA = "0x1909638", Offset = "0x1909638", VA = "0x1909638")] private set
      {
      }
    }

    [Token(Token = "0x17001F48")]
    public int ResponseCode
    {
      [Token(Token = "0x600A604"), Address(RVA = "0x1909640", Offset = "0x1909640", VA = "0x1909640")] get
      {
        return new int();
      }
      [Token(Token = "0x600A605"), Address(RVA = "0x1909648", Offset = "0x1909648", VA = "0x1909648")] private set
      {
      }
    }

    [Token(Token = "0x17001F49")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A606"), Address(RVA = "0x1909650", Offset = "0x1909650", VA = "0x1909650")] set
      {
      }
      [Token(Token = "0x600A607"), Address(RVA = "0x190966C", Offset = "0x190966C", VA = "0x190966C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A608")]
    [Address(RVA = "0x1909688", Offset = "0x1909688", VA = "0x1909688")]
    public APIExpeditionSoul_tankLevel_up(string apiPath = "api/v1/expedition/soul_tank/level_up")
    {
    }

    [Token(Token = "0x600A609")]
    [Address(RVA = "0x1909720", Offset = "0x1909720", VA = "0x1909720")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A60A")]
    [Address(RVA = "0x19097B0", Offset = "0x19097B0", VA = "0x19097B0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A60B")]
    [Address(RVA = "0x19097BC", Offset = "0x19097BC", VA = "0x19097BC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A60C")]
    [Address(RVA = "0x1909890", Offset = "0x1909890", VA = "0x1909890")]
    private void OnSuccess(string json)
    {
    }
  }
}
