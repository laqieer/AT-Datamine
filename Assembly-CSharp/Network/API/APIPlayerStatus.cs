// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DB5")]
  public class APIPlayerStatus
  {
    [Token(Token = "0x4007EEF")]
    public const string DefaultAPIPath = "api/v1/player/status";
    [Token(Token = "0x4007EF3")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007EF4")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerStatusResponse> onSuccess;
    [Token(Token = "0x4007EF5")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170022D7")]
    public APIPlayerStatusRequest Request
    {
      [Token(Token = "0x600AF91"), Address(RVA = "0x1A50790", Offset = "0x1A50790", VA = "0x1A50790")] private get
      {
        return (APIPlayerStatusRequest) null;
      }
      [Token(Token = "0x600AF92"), Address(RVA = "0x1A50798", Offset = "0x1A50798", VA = "0x1A50798")] set
      {
      }
    }

    [Token(Token = "0x170022D8")]
    public APIPlayerStatusResponse Response
    {
      [Token(Token = "0x600AF93"), Address(RVA = "0x1A507A0", Offset = "0x1A507A0", VA = "0x1A507A0")] get
      {
        return (APIPlayerStatusResponse) null;
      }
      [Token(Token = "0x600AF94"), Address(RVA = "0x1A507A8", Offset = "0x1A507A8", VA = "0x1A507A8")] private set
      {
      }
    }

    [Token(Token = "0x170022D9")]
    public int ResponseCode
    {
      [Token(Token = "0x600AF95"), Address(RVA = "0x1A507B0", Offset = "0x1A507B0", VA = "0x1A507B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600AF96"), Address(RVA = "0x1A507B8", Offset = "0x1A507B8", VA = "0x1A507B8")] private set
      {
      }
    }

    [Token(Token = "0x170022DA")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AF97"), Address(RVA = "0x1A507C0", Offset = "0x1A507C0", VA = "0x1A507C0")] set
      {
      }
      [Token(Token = "0x600AF98"), Address(RVA = "0x1A507DC", Offset = "0x1A507DC", VA = "0x1A507DC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AF99")]
    [Address(RVA = "0x1A507F8", Offset = "0x1A507F8", VA = "0x1A507F8")]
    public APIPlayerStatus(string apiPath = "api/v1/player/status")
    {
    }

    [Token(Token = "0x600AF9A")]
    [Address(RVA = "0x1A50890", Offset = "0x1A50890", VA = "0x1A50890")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AF9B")]
    [Address(RVA = "0x1A50920", Offset = "0x1A50920", VA = "0x1A50920")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AF9C")]
    [Address(RVA = "0x1A5092C", Offset = "0x1A5092C", VA = "0x1A5092C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AF9D")]
    [Address(RVA = "0x1A50A00", Offset = "0x1A50A00", VA = "0x1A50A00")]
    private void OnSuccess(string json)
    {
    }
  }
}
