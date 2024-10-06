// Decompiled with JetBrains decompiler
// Type: Network.API.APIBlockRemove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BB9")]
  public class APIBlockRemove
  {
    [Token(Token = "0x40076D1")]
    public const string DefaultAPIPath = "api/v1/block/remove";
    [Token(Token = "0x40076D5")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40076D6")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIBlockRemoveResponse> onSuccess;
    [Token(Token = "0x40076D7")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E20")]
    public APIBlockRemoveRequest Request
    {
      [Token(Token = "0x600A2EA"), Address(RVA = "0x46CCE78", Offset = "0x46CCE78", VA = "0x46CCE78")] private get
      {
        return (APIBlockRemoveRequest) null;
      }
      [Token(Token = "0x600A2EB"), Address(RVA = "0x46CCE80", Offset = "0x46CCE80", VA = "0x46CCE80")] set
      {
      }
    }

    [Token(Token = "0x17001E21")]
    public APIBlockRemoveResponse Response
    {
      [Token(Token = "0x600A2EC"), Address(RVA = "0x46CCE88", Offset = "0x46CCE88", VA = "0x46CCE88")] get
      {
        return (APIBlockRemoveResponse) null;
      }
      [Token(Token = "0x600A2ED"), Address(RVA = "0x46CCE90", Offset = "0x46CCE90", VA = "0x46CCE90")] private set
      {
      }
    }

    [Token(Token = "0x17001E22")]
    public int ResponseCode
    {
      [Token(Token = "0x600A2EE"), Address(RVA = "0x46CCE98", Offset = "0x46CCE98", VA = "0x46CCE98")] get
      {
        return new int();
      }
      [Token(Token = "0x600A2EF"), Address(RVA = "0x46CCEA0", Offset = "0x46CCEA0", VA = "0x46CCEA0")] private set
      {
      }
    }

    [Token(Token = "0x17001E23")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A2F0"), Address(RVA = "0x46CCEA8", Offset = "0x46CCEA8", VA = "0x46CCEA8")] set
      {
      }
      [Token(Token = "0x600A2F1"), Address(RVA = "0x46CCEC4", Offset = "0x46CCEC4", VA = "0x46CCEC4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A2F2")]
    [Address(RVA = "0x46CCEE0", Offset = "0x46CCEE0", VA = "0x46CCEE0")]
    public APIBlockRemove(string apiPath = "api/v1/block/remove")
    {
    }

    [Token(Token = "0x600A2F3")]
    [Address(RVA = "0x46CCF78", Offset = "0x46CCF78", VA = "0x46CCF78")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A2F4")]
    [Address(RVA = "0x46CD008", Offset = "0x46CD008", VA = "0x46CD008")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A2F5")]
    [Address(RVA = "0x46CD014", Offset = "0x46CD014", VA = "0x46CD014")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A2F6")]
    [Address(RVA = "0x46CD0E8", Offset = "0x46CD0E8", VA = "0x46CD0E8")]
    private void OnSuccess(string json)
    {
    }
  }
}
