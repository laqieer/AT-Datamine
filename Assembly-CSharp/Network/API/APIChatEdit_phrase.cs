// Decompiled with JetBrains decompiler
// Type: Network.API.APIChatEdit_phrase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BC9")]
  public class APIChatEdit_phrase
  {
    [Token(Token = "0x400770C")]
    public const string DefaultAPIPath = "api/v1/chat/edit_phrase";
    [Token(Token = "0x4007710")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007711")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIChatEdit_phraseResponse> onSuccess;
    [Token(Token = "0x4007712")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E41")]
    public APIChatEdit_phraseRequest Request
    {
      [Token(Token = "0x600A34B"), Address(RVA = "0x46CE3F0", Offset = "0x46CE3F0", VA = "0x46CE3F0")] private get
      {
        return (APIChatEdit_phraseRequest) null;
      }
      [Token(Token = "0x600A34C"), Address(RVA = "0x46CE3F8", Offset = "0x46CE3F8", VA = "0x46CE3F8")] set
      {
      }
    }

    [Token(Token = "0x17001E42")]
    public APIChatEdit_phraseResponse Response
    {
      [Token(Token = "0x600A34D"), Address(RVA = "0x46CE400", Offset = "0x46CE400", VA = "0x46CE400")] get
      {
        return (APIChatEdit_phraseResponse) null;
      }
      [Token(Token = "0x600A34E"), Address(RVA = "0x46CE408", Offset = "0x46CE408", VA = "0x46CE408")] private set
      {
      }
    }

    [Token(Token = "0x17001E43")]
    public int ResponseCode
    {
      [Token(Token = "0x600A34F"), Address(RVA = "0x46CE410", Offset = "0x46CE410", VA = "0x46CE410")] get
      {
        return new int();
      }
      [Token(Token = "0x600A350"), Address(RVA = "0x46CE418", Offset = "0x46CE418", VA = "0x46CE418")] private set
      {
      }
    }

    [Token(Token = "0x17001E44")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A351"), Address(RVA = "0x46CE420", Offset = "0x46CE420", VA = "0x46CE420")] set
      {
      }
      [Token(Token = "0x600A352"), Address(RVA = "0x46CE43C", Offset = "0x46CE43C", VA = "0x46CE43C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A353")]
    [Address(RVA = "0x46CE458", Offset = "0x46CE458", VA = "0x46CE458")]
    public APIChatEdit_phrase(string apiPath = "api/v1/chat/edit_phrase")
    {
    }

    [Token(Token = "0x600A354")]
    [Address(RVA = "0x46CE4F0", Offset = "0x46CE4F0", VA = "0x46CE4F0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A355")]
    [Address(RVA = "0x46CE580", Offset = "0x46CE580", VA = "0x46CE580")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A356")]
    [Address(RVA = "0x46CE58C", Offset = "0x46CE58C", VA = "0x46CE58C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A357")]
    [Address(RVA = "0x46CE660", Offset = "0x46CE660", VA = "0x46CE660")]
    private void OnSuccess(string json)
    {
    }
  }
}
