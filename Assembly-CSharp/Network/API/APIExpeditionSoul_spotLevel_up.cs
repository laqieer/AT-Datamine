// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionSoul_spotLevel_up
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C31")]
  public class APIExpeditionSoul_spotLevel_up
  {
    [Token(Token = "0x40078B7")]
    public const string DefaultAPIPath = "api/v1/expedition/soul_spot/level_up";
    [Token(Token = "0x40078BB")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40078BC")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIExpeditionSoul_spotLevel_upResponse> onSuccess;
    [Token(Token = "0x40078BD")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001F3E")]
    public APIExpeditionSoul_spotLevel_upRequest Request
    {
      [Token(Token = "0x600A5E8"), Address(RVA = "0x19090C4", Offset = "0x19090C4", VA = "0x19090C4")] private get
      {
        return (APIExpeditionSoul_spotLevel_upRequest) null;
      }
      [Token(Token = "0x600A5E9"), Address(RVA = "0x19090CC", Offset = "0x19090CC", VA = "0x19090CC")] set
      {
      }
    }

    [Token(Token = "0x17001F3F")]
    public APIExpeditionSoul_spotLevel_upResponse Response
    {
      [Token(Token = "0x600A5EA"), Address(RVA = "0x19090D4", Offset = "0x19090D4", VA = "0x19090D4")] get
      {
        return (APIExpeditionSoul_spotLevel_upResponse) null;
      }
      [Token(Token = "0x600A5EB"), Address(RVA = "0x19090DC", Offset = "0x19090DC", VA = "0x19090DC")] private set
      {
      }
    }

    [Token(Token = "0x17001F40")]
    public int ResponseCode
    {
      [Token(Token = "0x600A5EC"), Address(RVA = "0x19090E4", Offset = "0x19090E4", VA = "0x19090E4")] get
      {
        return new int();
      }
      [Token(Token = "0x600A5ED"), Address(RVA = "0x19090EC", Offset = "0x19090EC", VA = "0x19090EC")] private set
      {
      }
    }

    [Token(Token = "0x17001F41")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A5EE"), Address(RVA = "0x19090F4", Offset = "0x19090F4", VA = "0x19090F4")] set
      {
      }
      [Token(Token = "0x600A5EF"), Address(RVA = "0x1909110", Offset = "0x1909110", VA = "0x1909110")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A5F0")]
    [Address(RVA = "0x190912C", Offset = "0x190912C", VA = "0x190912C")]
    public APIExpeditionSoul_spotLevel_up(string apiPath = "api/v1/expedition/soul_spot/level_up")
    {
    }

    [Token(Token = "0x600A5F1")]
    [Address(RVA = "0x19091C4", Offset = "0x19091C4", VA = "0x19091C4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A5F2")]
    [Address(RVA = "0x1909254", Offset = "0x1909254", VA = "0x1909254")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A5F3")]
    [Address(RVA = "0x1909260", Offset = "0x1909260", VA = "0x1909260")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A5F4")]
    [Address(RVA = "0x1909334", Offset = "0x1909334", VA = "0x1909334")]
    private void OnSuccess(string json)
    {
    }
  }
}
