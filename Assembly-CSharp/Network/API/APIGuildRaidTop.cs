// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRaidTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D15")]
  public class APIGuildRaidTop
  {
    [Token(Token = "0x4007C40")]
    public const string DefaultAPIPath = "api/v1/guild/raid/top";
    [Token(Token = "0x4007C44")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007C45")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildRaidTopResponse> onSuccess;
    [Token(Token = "0x4007C46")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002133")]
    public APIGuildRaidTopRequest Request
    {
      [Token(Token = "0x600AB6D"), Address(RVA = "0x1A42E48", Offset = "0x1A42E48", VA = "0x1A42E48")] private get
      {
        return (APIGuildRaidTopRequest) null;
      }
      [Token(Token = "0x600AB6E"), Address(RVA = "0x1A42E50", Offset = "0x1A42E50", VA = "0x1A42E50")] set
      {
      }
    }

    [Token(Token = "0x17002134")]
    public APIGuildRaidTopResponse Response
    {
      [Token(Token = "0x600AB6F"), Address(RVA = "0x1A42E58", Offset = "0x1A42E58", VA = "0x1A42E58")] get
      {
        return (APIGuildRaidTopResponse) null;
      }
      [Token(Token = "0x600AB70"), Address(RVA = "0x1A42E60", Offset = "0x1A42E60", VA = "0x1A42E60")] private set
      {
      }
    }

    [Token(Token = "0x17002135")]
    public int ResponseCode
    {
      [Token(Token = "0x600AB71"), Address(RVA = "0x1A42E68", Offset = "0x1A42E68", VA = "0x1A42E68")] get
      {
        return new int();
      }
      [Token(Token = "0x600AB72"), Address(RVA = "0x1A42E70", Offset = "0x1A42E70", VA = "0x1A42E70")] private set
      {
      }
    }

    [Token(Token = "0x17002136")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AB73"), Address(RVA = "0x1A42E78", Offset = "0x1A42E78", VA = "0x1A42E78")] set
      {
      }
      [Token(Token = "0x600AB74"), Address(RVA = "0x1A42E94", Offset = "0x1A42E94", VA = "0x1A42E94")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AB75")]
    [Address(RVA = "0x1A42EB0", Offset = "0x1A42EB0", VA = "0x1A42EB0")]
    public APIGuildRaidTop(string apiPath = "api/v1/guild/raid/top")
    {
    }

    [Token(Token = "0x600AB76")]
    [Address(RVA = "0x1A42F48", Offset = "0x1A42F48", VA = "0x1A42F48")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AB77")]
    [Address(RVA = "0x1A42FD8", Offset = "0x1A42FD8", VA = "0x1A42FD8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AB78")]
    [Address(RVA = "0x1A42FE4", Offset = "0x1A42FE4", VA = "0x1A42FE4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AB79")]
    [Address(RVA = "0x1A430B8", Offset = "0x1A430B8", VA = "0x1A430B8")]
    private void OnSuccess(string json)
    {
    }
  }
}
