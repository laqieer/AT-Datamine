// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackBattleEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DF5")]
  public class APIScoreAttackBattleEnd
  {
    [Token(Token = "0x4008048")]
    public const string DefaultAPIPath = "api/v1/score_attack/battle/end";
    [Token(Token = "0x400804C")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400804D")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIScoreAttackBattleEndResponse> onSuccess;
    [Token(Token = "0x400804E")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002385")]
    public APIScoreAttackBattleEndRequest Request
    {
      [Token(Token = "0x600B13F"), Address(RVA = "0x22DBD0C", Offset = "0x22DBD0C", VA = "0x22DBD0C")] private get
      {
        return (APIScoreAttackBattleEndRequest) null;
      }
      [Token(Token = "0x600B140"), Address(RVA = "0x22DBD14", Offset = "0x22DBD14", VA = "0x22DBD14")] set
      {
      }
    }

    [Token(Token = "0x17002386")]
    public APIScoreAttackBattleEndResponse Response
    {
      [Token(Token = "0x600B141"), Address(RVA = "0x22DBD1C", Offset = "0x22DBD1C", VA = "0x22DBD1C")] get
      {
        return (APIScoreAttackBattleEndResponse) null;
      }
      [Token(Token = "0x600B142"), Address(RVA = "0x22DBD24", Offset = "0x22DBD24", VA = "0x22DBD24")] private set
      {
      }
    }

    [Token(Token = "0x17002387")]
    public int ResponseCode
    {
      [Token(Token = "0x600B143"), Address(RVA = "0x22DBD2C", Offset = "0x22DBD2C", VA = "0x22DBD2C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B144"), Address(RVA = "0x22DBD34", Offset = "0x22DBD34", VA = "0x22DBD34")] private set
      {
      }
    }

    [Token(Token = "0x17002388")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B145"), Address(RVA = "0x22DBD3C", Offset = "0x22DBD3C", VA = "0x22DBD3C")] set
      {
      }
      [Token(Token = "0x600B146"), Address(RVA = "0x22DBD58", Offset = "0x22DBD58", VA = "0x22DBD58")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B147")]
    [Address(RVA = "0x22DBD74", Offset = "0x22DBD74", VA = "0x22DBD74")]
    public APIScoreAttackBattleEnd(string apiPath = "api/v1/score_attack/battle/end")
    {
    }

    [Token(Token = "0x600B148")]
    [Address(RVA = "0x22DBE0C", Offset = "0x22DBE0C", VA = "0x22DBE0C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B149")]
    [Address(RVA = "0x22DBE9C", Offset = "0x22DBE9C", VA = "0x22DBE9C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B14A")]
    [Address(RVA = "0x22DBEA8", Offset = "0x22DBEA8", VA = "0x22DBEA8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B14B")]
    [Address(RVA = "0x22DBF7C", Offset = "0x22DBF7C", VA = "0x22DBF7C")]
    private void OnSuccess(string json)
    {
    }
  }
}
