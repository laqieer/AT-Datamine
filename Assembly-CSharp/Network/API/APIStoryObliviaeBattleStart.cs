// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryObliviaeBattleStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E61")]
  public class APIStoryObliviaeBattleStart
  {
    [Token(Token = "0x4008272")]
    public const string DefaultAPIPath = "api/v1/story/obliviae/battle/start";
    [Token(Token = "0x4008276")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008277")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryObliviaeBattleStartResponse> onSuccess;
    [Token(Token = "0x4008278")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170024BE")]
    public APIStoryObliviaeBattleStartRequest Request
    {
      [Token(Token = "0x600B428"), Address(RVA = "0x22E50C8", Offset = "0x22E50C8", VA = "0x22E50C8")] private get
      {
        return (APIStoryObliviaeBattleStartRequest) null;
      }
      [Token(Token = "0x600B429"), Address(RVA = "0x22E50D0", Offset = "0x22E50D0", VA = "0x22E50D0")] set
      {
      }
    }

    [Token(Token = "0x170024BF")]
    public APIStoryObliviaeBattleStartResponse Response
    {
      [Token(Token = "0x600B42A"), Address(RVA = "0x22E50D8", Offset = "0x22E50D8", VA = "0x22E50D8")] get
      {
        return (APIStoryObliviaeBattleStartResponse) null;
      }
      [Token(Token = "0x600B42B"), Address(RVA = "0x22E50E0", Offset = "0x22E50E0", VA = "0x22E50E0")] private set
      {
      }
    }

    [Token(Token = "0x170024C0")]
    public int ResponseCode
    {
      [Token(Token = "0x600B42C"), Address(RVA = "0x22E50E8", Offset = "0x22E50E8", VA = "0x22E50E8")] get
      {
        return new int();
      }
      [Token(Token = "0x600B42D"), Address(RVA = "0x22E50F0", Offset = "0x22E50F0", VA = "0x22E50F0")] private set
      {
      }
    }

    [Token(Token = "0x170024C1")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B42E"), Address(RVA = "0x22E50F8", Offset = "0x22E50F8", VA = "0x22E50F8")] set
      {
      }
      [Token(Token = "0x600B42F"), Address(RVA = "0x22E5114", Offset = "0x22E5114", VA = "0x22E5114")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B430")]
    [Address(RVA = "0x22E5130", Offset = "0x22E5130", VA = "0x22E5130")]
    public APIStoryObliviaeBattleStart(string apiPath = "api/v1/story/obliviae/battle/start")
    {
    }

    [Token(Token = "0x600B431")]
    [Address(RVA = "0x22E51C8", Offset = "0x22E51C8", VA = "0x22E51C8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B432")]
    [Address(RVA = "0x22E5258", Offset = "0x22E5258", VA = "0x22E5258")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B433")]
    [Address(RVA = "0x22E5264", Offset = "0x22E5264", VA = "0x22E5264")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B434")]
    [Address(RVA = "0x22E5338", Offset = "0x22E5338", VA = "0x22E5338")]
    private void OnSuccess(string json)
    {
    }
  }
}
