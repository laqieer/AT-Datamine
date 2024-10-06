// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaBattleStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B91")]
  public class APIArenaBattleStart
  {
    [Token(Token = "0x4007633")]
    public const string DefaultAPIPath = "api/v1/arena/battle/start";
    [Token(Token = "0x4007637")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007638")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIArenaBattleStartResponse> onSuccess;
    [Token(Token = "0x4007639")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001DC8")]
    public APIArenaBattleStartRequest Request
    {
      [Token(Token = "0x600A1F2"), Address(RVA = "0x46C98A0", Offset = "0x46C98A0", VA = "0x46C98A0")] private get
      {
        return (APIArenaBattleStartRequest) null;
      }
      [Token(Token = "0x600A1F3"), Address(RVA = "0x46C98A8", Offset = "0x46C98A8", VA = "0x46C98A8")] set
      {
      }
    }

    [Token(Token = "0x17001DC9")]
    public APIArenaBattleStartResponse Response
    {
      [Token(Token = "0x600A1F4"), Address(RVA = "0x46C98B0", Offset = "0x46C98B0", VA = "0x46C98B0")] get
      {
        return (APIArenaBattleStartResponse) null;
      }
      [Token(Token = "0x600A1F5"), Address(RVA = "0x46C98B8", Offset = "0x46C98B8", VA = "0x46C98B8")] private set
      {
      }
    }

    [Token(Token = "0x17001DCA")]
    public int ResponseCode
    {
      [Token(Token = "0x600A1F6"), Address(RVA = "0x46C98C0", Offset = "0x46C98C0", VA = "0x46C98C0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A1F7"), Address(RVA = "0x46C98C8", Offset = "0x46C98C8", VA = "0x46C98C8")] private set
      {
      }
    }

    [Token(Token = "0x17001DCB")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A1F8"), Address(RVA = "0x46C98D0", Offset = "0x46C98D0", VA = "0x46C98D0")] set
      {
      }
      [Token(Token = "0x600A1F9"), Address(RVA = "0x46C98EC", Offset = "0x46C98EC", VA = "0x46C98EC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A1FA")]
    [Address(RVA = "0x46C9908", Offset = "0x46C9908", VA = "0x46C9908")]
    public APIArenaBattleStart(string apiPath = "api/v1/arena/battle/start")
    {
    }

    [Token(Token = "0x600A1FB")]
    [Address(RVA = "0x46C99A0", Offset = "0x46C99A0", VA = "0x46C99A0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A1FC")]
    [Address(RVA = "0x46C9A30", Offset = "0x46C9A30", VA = "0x46C9A30")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A1FD")]
    [Address(RVA = "0x46C9A3C", Offset = "0x46C9A3C", VA = "0x46C9A3C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A1FE")]
    [Address(RVA = "0x46C9B10", Offset = "0x46C9B10", VA = "0x46C9B10")]
    private void OnSuccess(string json)
    {
    }
  }
}
