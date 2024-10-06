// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaBattleHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B89")]
  public class APIArenaBattleHistory
  {
    [Token(Token = "0x4007611")]
    public const string DefaultAPIPath = "api/v1/arena/battle/history";
    [Token(Token = "0x4007615")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007616")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIArenaBattleHistoryResponse> onSuccess;
    [Token(Token = "0x4007617")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001DB4")]
    public APIArenaBattleHistoryRequest Request
    {
      [Token(Token = "0x600A1BE"), Address(RVA = "0x46C8DC8", Offset = "0x46C8DC8", VA = "0x46C8DC8")] private get
      {
        return (APIArenaBattleHistoryRequest) null;
      }
      [Token(Token = "0x600A1BF"), Address(RVA = "0x46C8DD0", Offset = "0x46C8DD0", VA = "0x46C8DD0")] set
      {
      }
    }

    [Token(Token = "0x17001DB5")]
    public APIArenaBattleHistoryResponse Response
    {
      [Token(Token = "0x600A1C0"), Address(RVA = "0x46C8DD8", Offset = "0x46C8DD8", VA = "0x46C8DD8")] get
      {
        return (APIArenaBattleHistoryResponse) null;
      }
      [Token(Token = "0x600A1C1"), Address(RVA = "0x46C8DE0", Offset = "0x46C8DE0", VA = "0x46C8DE0")] private set
      {
      }
    }

    [Token(Token = "0x17001DB6")]
    public int ResponseCode
    {
      [Token(Token = "0x600A1C2"), Address(RVA = "0x46C8DE8", Offset = "0x46C8DE8", VA = "0x46C8DE8")] get
      {
        return new int();
      }
      [Token(Token = "0x600A1C3"), Address(RVA = "0x46C8DF0", Offset = "0x46C8DF0", VA = "0x46C8DF0")] private set
      {
      }
    }

    [Token(Token = "0x17001DB7")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A1C4"), Address(RVA = "0x46C8DF8", Offset = "0x46C8DF8", VA = "0x46C8DF8")] set
      {
      }
      [Token(Token = "0x600A1C5"), Address(RVA = "0x46C8E14", Offset = "0x46C8E14", VA = "0x46C8E14")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A1C6")]
    [Address(RVA = "0x46C8E30", Offset = "0x46C8E30", VA = "0x46C8E30")]
    public APIArenaBattleHistory(string apiPath = "api/v1/arena/battle/history")
    {
    }

    [Token(Token = "0x600A1C7")]
    [Address(RVA = "0x46C8EC8", Offset = "0x46C8EC8", VA = "0x46C8EC8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A1C8")]
    [Address(RVA = "0x46C8F58", Offset = "0x46C8F58", VA = "0x46C8F58")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A1C9")]
    [Address(RVA = "0x46C8F64", Offset = "0x46C8F64", VA = "0x46C8F64")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A1CA")]
    [Address(RVA = "0x46C9038", Offset = "0x46C9038", VA = "0x46C9038")]
    private void OnSuccess(string json)
    {
    }
  }
}
