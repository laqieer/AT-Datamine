// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaResultDefense
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B99")]
  public class APIArenaResultDefense
  {
    [Token(Token = "0x4007657")]
    public const string DefaultAPIPath = "api/v1/arena/result/defense";
    [Token(Token = "0x400765B")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400765C")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIArenaResultDefenseResponse> onSuccess;
    [Token(Token = "0x400765D")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001DE0")]
    public APIArenaResultDefenseRequest Request
    {
      [Token(Token = "0x600A22A"), Address(RVA = "0x46CA398", Offset = "0x46CA398", VA = "0x46CA398")] private get
      {
        return (APIArenaResultDefenseRequest) null;
      }
      [Token(Token = "0x600A22B"), Address(RVA = "0x46CA3A0", Offset = "0x46CA3A0", VA = "0x46CA3A0")] set
      {
      }
    }

    [Token(Token = "0x17001DE1")]
    public APIArenaResultDefenseResponse Response
    {
      [Token(Token = "0x600A22C"), Address(RVA = "0x46CA3A8", Offset = "0x46CA3A8", VA = "0x46CA3A8")] get
      {
        return (APIArenaResultDefenseResponse) null;
      }
      [Token(Token = "0x600A22D"), Address(RVA = "0x46CA3B0", Offset = "0x46CA3B0", VA = "0x46CA3B0")] private set
      {
      }
    }

    [Token(Token = "0x17001DE2")]
    public int ResponseCode
    {
      [Token(Token = "0x600A22E"), Address(RVA = "0x46CA3B8", Offset = "0x46CA3B8", VA = "0x46CA3B8")] get
      {
        return new int();
      }
      [Token(Token = "0x600A22F"), Address(RVA = "0x46CA3C0", Offset = "0x46CA3C0", VA = "0x46CA3C0")] private set
      {
      }
    }

    [Token(Token = "0x17001DE3")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A230"), Address(RVA = "0x46CA3C8", Offset = "0x46CA3C8", VA = "0x46CA3C8")] set
      {
      }
      [Token(Token = "0x600A231"), Address(RVA = "0x46CA3E4", Offset = "0x46CA3E4", VA = "0x46CA3E4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A232")]
    [Address(RVA = "0x46CA400", Offset = "0x46CA400", VA = "0x46CA400")]
    public APIArenaResultDefense(string apiPath = "api/v1/arena/result/defense")
    {
    }

    [Token(Token = "0x600A233")]
    [Address(RVA = "0x46CA498", Offset = "0x46CA498", VA = "0x46CA498")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A234")]
    [Address(RVA = "0x46CA528", Offset = "0x46CA528", VA = "0x46CA528")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A235")]
    [Address(RVA = "0x46CA534", Offset = "0x46CA534", VA = "0x46CA534")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A236")]
    [Address(RVA = "0x46CA608", Offset = "0x46CA608", VA = "0x46CA608")]
    private void OnSuccess(string json)
    {
    }
  }
}
