// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildInfoSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CE1")]
  public class APIGuildInfoSet
  {
    [Token(Token = "0x4007B73")]
    public const string DefaultAPIPath = "api/v1/guild/info/set";
    [Token(Token = "0x4007B77")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007B78")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildInfoSetResponse> onSuccess;
    [Token(Token = "0x4007B79")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170020C5")]
    public APIGuildInfoSetRequest Request
    {
      [Token(Token = "0x600AA2F"), Address(RVA = "0x1917DBC", Offset = "0x1917DBC", VA = "0x1917DBC")] private get
      {
        return (APIGuildInfoSetRequest) null;
      }
      [Token(Token = "0x600AA30"), Address(RVA = "0x1917DC4", Offset = "0x1917DC4", VA = "0x1917DC4")] set
      {
      }
    }

    [Token(Token = "0x170020C6")]
    public APIGuildInfoSetResponse Response
    {
      [Token(Token = "0x600AA31"), Address(RVA = "0x1917DCC", Offset = "0x1917DCC", VA = "0x1917DCC")] get
      {
        return (APIGuildInfoSetResponse) null;
      }
      [Token(Token = "0x600AA32"), Address(RVA = "0x1917DD4", Offset = "0x1917DD4", VA = "0x1917DD4")] private set
      {
      }
    }

    [Token(Token = "0x170020C7")]
    public int ResponseCode
    {
      [Token(Token = "0x600AA33"), Address(RVA = "0x1917DDC", Offset = "0x1917DDC", VA = "0x1917DDC")] get
      {
        return new int();
      }
      [Token(Token = "0x600AA34"), Address(RVA = "0x1917DE4", Offset = "0x1917DE4", VA = "0x1917DE4")] private set
      {
      }
    }

    [Token(Token = "0x170020C8")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AA35"), Address(RVA = "0x1917DEC", Offset = "0x1917DEC", VA = "0x1917DEC")] set
      {
      }
      [Token(Token = "0x600AA36"), Address(RVA = "0x1917E08", Offset = "0x1917E08", VA = "0x1917E08")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AA37")]
    [Address(RVA = "0x1917E24", Offset = "0x1917E24", VA = "0x1917E24")]
    public APIGuildInfoSet(string apiPath = "api/v1/guild/info/set")
    {
    }

    [Token(Token = "0x600AA38")]
    [Address(RVA = "0x1917EBC", Offset = "0x1917EBC", VA = "0x1917EBC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AA39")]
    [Address(RVA = "0x1917F4C", Offset = "0x1917F4C", VA = "0x1917F4C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AA3A")]
    [Address(RVA = "0x1917F58", Offset = "0x1917F58", VA = "0x1917F58")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AA3B")]
    [Address(RVA = "0x191802C", Offset = "0x191802C", VA = "0x191802C")]
    private void OnSuccess(string json)
    {
    }
  }
}
