// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildAttend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CA5")]
  public class APIGuildAttend
  {
    [Token(Token = "0x4007A78")]
    public const string DefaultAPIPath = "api/v1/guild/attend";
    [Token(Token = "0x4007A7C")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007A7D")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildAttendResponse> onSuccess;
    [Token(Token = "0x4007A7E")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700203F")]
    public APIGuildAttendRequest Request
    {
      [Token(Token = "0x600A8B9"), Address(RVA = "0x1912CF8", Offset = "0x1912CF8", VA = "0x1912CF8")] private get
      {
        return (APIGuildAttendRequest) null;
      }
      [Token(Token = "0x600A8BA"), Address(RVA = "0x1912D00", Offset = "0x1912D00", VA = "0x1912D00")] set
      {
      }
    }

    [Token(Token = "0x17002040")]
    public APIGuildAttendResponse Response
    {
      [Token(Token = "0x600A8BB"), Address(RVA = "0x1912D08", Offset = "0x1912D08", VA = "0x1912D08")] get
      {
        return (APIGuildAttendResponse) null;
      }
      [Token(Token = "0x600A8BC"), Address(RVA = "0x1912D10", Offset = "0x1912D10", VA = "0x1912D10")] private set
      {
      }
    }

    [Token(Token = "0x17002041")]
    public int ResponseCode
    {
      [Token(Token = "0x600A8BD"), Address(RVA = "0x1912D18", Offset = "0x1912D18", VA = "0x1912D18")] get
      {
        return new int();
      }
      [Token(Token = "0x600A8BE"), Address(RVA = "0x1912D20", Offset = "0x1912D20", VA = "0x1912D20")] private set
      {
      }
    }

    [Token(Token = "0x17002042")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A8BF"), Address(RVA = "0x1912D28", Offset = "0x1912D28", VA = "0x1912D28")] set
      {
      }
      [Token(Token = "0x600A8C0"), Address(RVA = "0x1912D44", Offset = "0x1912D44", VA = "0x1912D44")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A8C1")]
    [Address(RVA = "0x1912D60", Offset = "0x1912D60", VA = "0x1912D60")]
    public APIGuildAttend(string apiPath = "api/v1/guild/attend")
    {
    }

    [Token(Token = "0x600A8C2")]
    [Address(RVA = "0x1912DF8", Offset = "0x1912DF8", VA = "0x1912DF8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A8C3")]
    [Address(RVA = "0x1912E88", Offset = "0x1912E88", VA = "0x1912E88")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A8C4")]
    [Address(RVA = "0x1912E94", Offset = "0x1912E94", VA = "0x1912E94")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A8C5")]
    [Address(RVA = "0x1912F68", Offset = "0x1912F68", VA = "0x1912F68")]
    private void OnSuccess(string json)
    {
    }
  }
}
