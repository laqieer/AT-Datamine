// Decompiled with JetBrains decompiler
// Type: Network.API.APIStorySubquestReceipt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E81")]
  public class APIStorySubquestReceipt
  {
    [Token(Token = "0x4008317")]
    public const string DefaultAPIPath = "api/v1/story/subquest/receipt";
    [Token(Token = "0x400831B")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400831C")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStorySubquestReceiptResponse> onSuccess;
    [Token(Token = "0x400831D")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700251E")]
    public APIStorySubquestReceiptRequest Request
    {
      [Token(Token = "0x600B508"), Address(RVA = "0x22E7CA8", Offset = "0x22E7CA8", VA = "0x22E7CA8")] private get
      {
        return (APIStorySubquestReceiptRequest) null;
      }
      [Token(Token = "0x600B509"), Address(RVA = "0x22E7CB0", Offset = "0x22E7CB0", VA = "0x22E7CB0")] set
      {
      }
    }

    [Token(Token = "0x1700251F")]
    public APIStorySubquestReceiptResponse Response
    {
      [Token(Token = "0x600B50A"), Address(RVA = "0x22E7CB8", Offset = "0x22E7CB8", VA = "0x22E7CB8")] get
      {
        return (APIStorySubquestReceiptResponse) null;
      }
      [Token(Token = "0x600B50B"), Address(RVA = "0x22E7CC0", Offset = "0x22E7CC0", VA = "0x22E7CC0")] private set
      {
      }
    }

    [Token(Token = "0x17002520")]
    public int ResponseCode
    {
      [Token(Token = "0x600B50C"), Address(RVA = "0x22E7CC8", Offset = "0x22E7CC8", VA = "0x22E7CC8")] get
      {
        return new int();
      }
      [Token(Token = "0x600B50D"), Address(RVA = "0x22E7CD0", Offset = "0x22E7CD0", VA = "0x22E7CD0")] private set
      {
      }
    }

    [Token(Token = "0x17002521")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B50E"), Address(RVA = "0x22E7CD8", Offset = "0x22E7CD8", VA = "0x22E7CD8")] set
      {
      }
      [Token(Token = "0x600B50F"), Address(RVA = "0x22E7CF4", Offset = "0x22E7CF4", VA = "0x22E7CF4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B510")]
    [Address(RVA = "0x22E7D10", Offset = "0x22E7D10", VA = "0x22E7D10")]
    public APIStorySubquestReceipt(string apiPath = "api/v1/story/subquest/receipt")
    {
    }

    [Token(Token = "0x600B511")]
    [Address(RVA = "0x22E7DA8", Offset = "0x22E7DA8", VA = "0x22E7DA8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B512")]
    [Address(RVA = "0x22E7E38", Offset = "0x22E7E38", VA = "0x22E7E38")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B513")]
    [Address(RVA = "0x22E7E44", Offset = "0x22E7E44", VA = "0x22E7E44")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B514")]
    [Address(RVA = "0x22E7F18", Offset = "0x22E7F18", VA = "0x22E7F18")]
    private void OnSuccess(string json)
    {
    }
  }
}
