// Decompiled with JetBrains decompiler
// Type: Network.API.APIChatPost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BD5")]
  public class APIChatPost
  {
    [Token(Token = "0x4007737")]
    public const string DefaultAPIPath = "api/v1/chat/post";
    [Token(Token = "0x400773B")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400773C")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIChatPostResponse> onSuccess;
    [Token(Token = "0x400773D")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E56")]
    public APIChatPostRequest Request
    {
      [Token(Token = "0x600A390"), Address(RVA = "0x46CF3EC", Offset = "0x46CF3EC", VA = "0x46CF3EC")] private get
      {
        return (APIChatPostRequest) null;
      }
      [Token(Token = "0x600A391"), Address(RVA = "0x46CF3F4", Offset = "0x46CF3F4", VA = "0x46CF3F4")] set
      {
      }
    }

    [Token(Token = "0x17001E57")]
    public APIChatPostResponse Response
    {
      [Token(Token = "0x600A392"), Address(RVA = "0x46CF3FC", Offset = "0x46CF3FC", VA = "0x46CF3FC")] get
      {
        return (APIChatPostResponse) null;
      }
      [Token(Token = "0x600A393"), Address(RVA = "0x46CF404", Offset = "0x46CF404", VA = "0x46CF404")] private set
      {
      }
    }

    [Token(Token = "0x17001E58")]
    public int ResponseCode
    {
      [Token(Token = "0x600A394"), Address(RVA = "0x46CF40C", Offset = "0x46CF40C", VA = "0x46CF40C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A395"), Address(RVA = "0x46CF414", Offset = "0x46CF414", VA = "0x46CF414")] private set
      {
      }
    }

    [Token(Token = "0x17001E59")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A396"), Address(RVA = "0x46CF41C", Offset = "0x46CF41C", VA = "0x46CF41C")] set
      {
      }
      [Token(Token = "0x600A397"), Address(RVA = "0x46CF438", Offset = "0x46CF438", VA = "0x46CF438")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A398")]
    [Address(RVA = "0x46CF454", Offset = "0x46CF454", VA = "0x46CF454")]
    public APIChatPost(string apiPath = "api/v1/chat/post")
    {
    }

    [Token(Token = "0x600A399")]
    [Address(RVA = "0x46CF4EC", Offset = "0x46CF4EC", VA = "0x46CF4EC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A39A")]
    [Address(RVA = "0x46CF57C", Offset = "0x46CF57C", VA = "0x46CF57C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A39B")]
    [Address(RVA = "0x46CF588", Offset = "0x46CF588", VA = "0x46CF588")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A39C")]
    [Address(RVA = "0x46CF65C", Offset = "0x46CF65C", VA = "0x46CF65C")]
    private void OnSuccess(string json)
    {
    }
  }
}
