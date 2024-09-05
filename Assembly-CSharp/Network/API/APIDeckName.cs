// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeckName
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C05")]
  public class APIDeckName
  {
    [Token(Token = "0x40077EF")]
    public const string DefaultAPIPath = "api/v1/deck/name";
    [Token(Token = "0x40077F3")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40077F4")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIDeckNameResponse> onSuccess;
    [Token(Token = "0x40077F5")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001EBC")]
    public APIDeckNameRequest Request
    {
      [Token(Token = "0x600A4B6"), Address(RVA = "0x46D346C", Offset = "0x46D346C", VA = "0x46D346C")] private get
      {
        return (APIDeckNameRequest) null;
      }
      [Token(Token = "0x600A4B7"), Address(RVA = "0x46D3474", Offset = "0x46D3474", VA = "0x46D3474")] set
      {
      }
    }

    [Token(Token = "0x17001EBD")]
    public APIDeckNameResponse Response
    {
      [Token(Token = "0x600A4B8"), Address(RVA = "0x46D347C", Offset = "0x46D347C", VA = "0x46D347C")] get
      {
        return (APIDeckNameResponse) null;
      }
      [Token(Token = "0x600A4B9"), Address(RVA = "0x46D3484", Offset = "0x46D3484", VA = "0x46D3484")] private set
      {
      }
    }

    [Token(Token = "0x17001EBE")]
    public int ResponseCode
    {
      [Token(Token = "0x600A4BA"), Address(RVA = "0x46D348C", Offset = "0x46D348C", VA = "0x46D348C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A4BB"), Address(RVA = "0x46D3494", Offset = "0x46D3494", VA = "0x46D3494")] private set
      {
      }
    }

    [Token(Token = "0x17001EBF")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A4BC"), Address(RVA = "0x46D349C", Offset = "0x46D349C", VA = "0x46D349C")] set
      {
      }
      [Token(Token = "0x600A4BD"), Address(RVA = "0x46D34B8", Offset = "0x46D34B8", VA = "0x46D34B8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A4BE")]
    [Address(RVA = "0x46D34D4", Offset = "0x46D34D4", VA = "0x46D34D4")]
    public APIDeckName(string apiPath = "api/v1/deck/name")
    {
    }

    [Token(Token = "0x600A4BF")]
    [Address(RVA = "0x46D356C", Offset = "0x46D356C", VA = "0x46D356C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A4C0")]
    [Address(RVA = "0x46D35FC", Offset = "0x46D35FC", VA = "0x46D35FC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A4C1")]
    [Address(RVA = "0x46D3608", Offset = "0x46D3608", VA = "0x46D3608")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A4C2")]
    [Address(RVA = "0x46D36DC", Offset = "0x46D36DC", VA = "0x46D36DC")]
    private void OnSuccess(string json)
    {
    }
  }
}
