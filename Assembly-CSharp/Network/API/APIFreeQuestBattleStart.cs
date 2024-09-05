// Decompiled with JetBrains decompiler
// Type: Network.API.APIFreeQuestBattleStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C4D")]
  public class APIFreeQuestBattleStart
  {
    [Token(Token = "0x4007943")]
    public const string DefaultAPIPath = "api/v1/battle/freequest/start";
    [Token(Token = "0x4007947")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007948")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIFreeQuestBattleStartResponse> onSuccess;
    [Token(Token = "0x4007949")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001F8D")]
    public APIFreeQuestBattleStartRequest Request
    {
      [Token(Token = "0x600A6A7"), Address(RVA = "0x190B700", Offset = "0x190B700", VA = "0x190B700")] private get
      {
        return (APIFreeQuestBattleStartRequest) null;
      }
      [Token(Token = "0x600A6A8"), Address(RVA = "0x190B708", Offset = "0x190B708", VA = "0x190B708")] set
      {
      }
    }

    [Token(Token = "0x17001F8E")]
    public APIFreeQuestBattleStartResponse Response
    {
      [Token(Token = "0x600A6A9"), Address(RVA = "0x190B710", Offset = "0x190B710", VA = "0x190B710")] get
      {
        return (APIFreeQuestBattleStartResponse) null;
      }
      [Token(Token = "0x600A6AA"), Address(RVA = "0x190B718", Offset = "0x190B718", VA = "0x190B718")] private set
      {
      }
    }

    [Token(Token = "0x17001F8F")]
    public int ResponseCode
    {
      [Token(Token = "0x600A6AB"), Address(RVA = "0x190B720", Offset = "0x190B720", VA = "0x190B720")] get
      {
        return new int();
      }
      [Token(Token = "0x600A6AC"), Address(RVA = "0x190B728", Offset = "0x190B728", VA = "0x190B728")] private set
      {
      }
    }

    [Token(Token = "0x17001F90")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A6AD"), Address(RVA = "0x190B730", Offset = "0x190B730", VA = "0x190B730")] set
      {
      }
      [Token(Token = "0x600A6AE"), Address(RVA = "0x190B74C", Offset = "0x190B74C", VA = "0x190B74C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A6AF")]
    [Address(RVA = "0x190B768", Offset = "0x190B768", VA = "0x190B768")]
    public APIFreeQuestBattleStart(string apiPath = "api/v1/battle/freequest/start")
    {
    }

    [Token(Token = "0x600A6B0")]
    [Address(RVA = "0x190B800", Offset = "0x190B800", VA = "0x190B800")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A6B1")]
    [Address(RVA = "0x190B890", Offset = "0x190B890", VA = "0x190B890")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A6B2")]
    [Address(RVA = "0x190B89C", Offset = "0x190B89C", VA = "0x190B89C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A6B3")]
    [Address(RVA = "0x190B970", Offset = "0x190B970", VA = "0x190B970")]
    private void OnSuccess(string json)
    {
    }
  }
}
