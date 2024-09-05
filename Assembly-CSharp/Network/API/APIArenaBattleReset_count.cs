// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaBattleReset_count
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B8D")]
  public class APIArenaBattleReset_count
  {
    [Token(Token = "0x4007621")]
    public const string DefaultAPIPath = "api/v1/arena/battle/reset_count";
    [Token(Token = "0x4007625")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007626")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIArenaBattleReset_countResponse> onSuccess;
    [Token(Token = "0x4007627")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001DBD")]
    public APIArenaBattleReset_countRequest Request
    {
      [Token(Token = "0x600A1D7"), Address(RVA = "0x46C932C", Offset = "0x46C932C", VA = "0x46C932C")] private get
      {
        return (APIArenaBattleReset_countRequest) null;
      }
      [Token(Token = "0x600A1D8"), Address(RVA = "0x46C9334", Offset = "0x46C9334", VA = "0x46C9334")] set
      {
      }
    }

    [Token(Token = "0x17001DBE")]
    public APIArenaBattleReset_countResponse Response
    {
      [Token(Token = "0x600A1D9"), Address(RVA = "0x46C933C", Offset = "0x46C933C", VA = "0x46C933C")] get
      {
        return (APIArenaBattleReset_countResponse) null;
      }
      [Token(Token = "0x600A1DA"), Address(RVA = "0x46C9344", Offset = "0x46C9344", VA = "0x46C9344")] private set
      {
      }
    }

    [Token(Token = "0x17001DBF")]
    public int ResponseCode
    {
      [Token(Token = "0x600A1DB"), Address(RVA = "0x46C934C", Offset = "0x46C934C", VA = "0x46C934C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A1DC"), Address(RVA = "0x46C9354", Offset = "0x46C9354", VA = "0x46C9354")] private set
      {
      }
    }

    [Token(Token = "0x17001DC0")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A1DD"), Address(RVA = "0x46C935C", Offset = "0x46C935C", VA = "0x46C935C")] set
      {
      }
      [Token(Token = "0x600A1DE"), Address(RVA = "0x46C9378", Offset = "0x46C9378", VA = "0x46C9378")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A1DF")]
    [Address(RVA = "0x46C9394", Offset = "0x46C9394", VA = "0x46C9394")]
    public APIArenaBattleReset_count(string apiPath = "api/v1/arena/battle/reset_count")
    {
    }

    [Token(Token = "0x600A1E0")]
    [Address(RVA = "0x46C942C", Offset = "0x46C942C", VA = "0x46C942C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A1E1")]
    [Address(RVA = "0x46C94BC", Offset = "0x46C94BC", VA = "0x46C94BC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A1E2")]
    [Address(RVA = "0x46C94C8", Offset = "0x46C94C8", VA = "0x46C94C8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A1E3")]
    [Address(RVA = "0x46C959C", Offset = "0x46C959C", VA = "0x46C959C")]
    private void OnSuccess(string json)
    {
    }
  }
}
