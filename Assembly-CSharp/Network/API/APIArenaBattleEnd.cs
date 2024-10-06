// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaBattleEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B85")]
  public class APIArenaBattleEnd
  {
    [Token(Token = "0x4007604")]
    public const string DefaultAPIPath = "api/v1/arena/battle/end";
    [Token(Token = "0x4007608")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007609")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIArenaBattleEndResponse> onSuccess;
    [Token(Token = "0x400760A")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001DAD")]
    public APIArenaBattleEndRequest Request
    {
      [Token(Token = "0x600A1A7"), Address(RVA = "0x46C8874", Offset = "0x46C8874", VA = "0x46C8874")] private get
      {
        return (APIArenaBattleEndRequest) null;
      }
      [Token(Token = "0x600A1A8"), Address(RVA = "0x46C887C", Offset = "0x46C887C", VA = "0x46C887C")] set
      {
      }
    }

    [Token(Token = "0x17001DAE")]
    public APIArenaBattleEndResponse Response
    {
      [Token(Token = "0x600A1A9"), Address(RVA = "0x46C8884", Offset = "0x46C8884", VA = "0x46C8884")] get
      {
        return (APIArenaBattleEndResponse) null;
      }
      [Token(Token = "0x600A1AA"), Address(RVA = "0x46C888C", Offset = "0x46C888C", VA = "0x46C888C")] private set
      {
      }
    }

    [Token(Token = "0x17001DAF")]
    public int ResponseCode
    {
      [Token(Token = "0x600A1AB"), Address(RVA = "0x46C8894", Offset = "0x46C8894", VA = "0x46C8894")] get
      {
        return new int();
      }
      [Token(Token = "0x600A1AC"), Address(RVA = "0x46C889C", Offset = "0x46C889C", VA = "0x46C889C")] private set
      {
      }
    }

    [Token(Token = "0x17001DB0")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A1AD"), Address(RVA = "0x46C88A4", Offset = "0x46C88A4", VA = "0x46C88A4")] set
      {
      }
      [Token(Token = "0x600A1AE"), Address(RVA = "0x46C88C0", Offset = "0x46C88C0", VA = "0x46C88C0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A1AF")]
    [Address(RVA = "0x46C88DC", Offset = "0x46C88DC", VA = "0x46C88DC")]
    public APIArenaBattleEnd(string apiPath = "api/v1/arena/battle/end")
    {
    }

    [Token(Token = "0x600A1B0")]
    [Address(RVA = "0x46C8974", Offset = "0x46C8974", VA = "0x46C8974")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A1B1")]
    [Address(RVA = "0x46C8A04", Offset = "0x46C8A04", VA = "0x46C8A04")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A1B2")]
    [Address(RVA = "0x46C8A10", Offset = "0x46C8A10", VA = "0x46C8A10")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A1B3")]
    [Address(RVA = "0x46C8AE4", Offset = "0x46C8AE4", VA = "0x46C8AE4")]
    private void OnSuccess(string json)
    {
    }
  }
}
