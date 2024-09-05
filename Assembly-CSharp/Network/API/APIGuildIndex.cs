// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildIndex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CD9")]
  public class APIGuildIndex
  {
    [Token(Token = "0x4007B4C")]
    public const string DefaultAPIPath = "api/v1/guild/index";
    [Token(Token = "0x4007B50")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007B51")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildIndexResponse> onSuccess;
    [Token(Token = "0x4007B52")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170020B5")]
    public APIGuildIndexRequest Request
    {
      [Token(Token = "0x600A9FF"), Address(RVA = "0x1917304", Offset = "0x1917304", VA = "0x1917304")] private get
      {
        return (APIGuildIndexRequest) null;
      }
      [Token(Token = "0x600AA00"), Address(RVA = "0x191730C", Offset = "0x191730C", VA = "0x191730C")] set
      {
      }
    }

    [Token(Token = "0x170020B6")]
    public APIGuildIndexResponse Response
    {
      [Token(Token = "0x600AA01"), Address(RVA = "0x1917314", Offset = "0x1917314", VA = "0x1917314")] get
      {
        return (APIGuildIndexResponse) null;
      }
      [Token(Token = "0x600AA02"), Address(RVA = "0x191731C", Offset = "0x191731C", VA = "0x191731C")] private set
      {
      }
    }

    [Token(Token = "0x170020B7")]
    public int ResponseCode
    {
      [Token(Token = "0x600AA03"), Address(RVA = "0x1917324", Offset = "0x1917324", VA = "0x1917324")] get
      {
        return new int();
      }
      [Token(Token = "0x600AA04"), Address(RVA = "0x191732C", Offset = "0x191732C", VA = "0x191732C")] private set
      {
      }
    }

    [Token(Token = "0x170020B8")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AA05"), Address(RVA = "0x1917334", Offset = "0x1917334", VA = "0x1917334")] set
      {
      }
      [Token(Token = "0x600AA06"), Address(RVA = "0x1917350", Offset = "0x1917350", VA = "0x1917350")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AA07")]
    [Address(RVA = "0x191736C", Offset = "0x191736C", VA = "0x191736C")]
    public APIGuildIndex(string apiPath = "api/v1/guild/index")
    {
    }

    [Token(Token = "0x600AA08")]
    [Address(RVA = "0x1917404", Offset = "0x1917404", VA = "0x1917404")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AA09")]
    [Address(RVA = "0x1917494", Offset = "0x1917494", VA = "0x1917494")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AA0A")]
    [Address(RVA = "0x19174A0", Offset = "0x19174A0", VA = "0x19174A0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AA0B")]
    [Address(RVA = "0x1917574", Offset = "0x1917574", VA = "0x1917574")]
    private void OnSuccess(string json)
    {
    }
  }
}
