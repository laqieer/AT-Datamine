// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnit_rankingRanking_tops
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EE9")]
  public class APIUnit_rankingRanking_tops
  {
    [Token(Token = "0x40084BA")]
    public const string DefaultAPIPath = "api/v1/unit_ranking/ranking_tops";
    [Token(Token = "0x40084BE")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40084BF")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnit_rankingRanking_topsResponse> onSuccess;
    [Token(Token = "0x40084C0")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700260F")]
    public APIUnit_rankingRanking_topsRequest Request
    {
      [Token(Token = "0x600B799"), Address(RVA = "0x213144C", Offset = "0x213144C", VA = "0x213144C")] private get
      {
        return (APIUnit_rankingRanking_topsRequest) null;
      }
      [Token(Token = "0x600B79A"), Address(RVA = "0x2131454", Offset = "0x2131454", VA = "0x2131454")] set
      {
      }
    }

    [Token(Token = "0x17002610")]
    public APIUnit_rankingRanking_topsResponse Response
    {
      [Token(Token = "0x600B79B"), Address(RVA = "0x213145C", Offset = "0x213145C", VA = "0x213145C")] get
      {
        return (APIUnit_rankingRanking_topsResponse) null;
      }
      [Token(Token = "0x600B79C"), Address(RVA = "0x2131464", Offset = "0x2131464", VA = "0x2131464")] private set
      {
      }
    }

    [Token(Token = "0x17002611")]
    public int ResponseCode
    {
      [Token(Token = "0x600B79D"), Address(RVA = "0x213146C", Offset = "0x213146C", VA = "0x213146C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B79E"), Address(RVA = "0x2131474", Offset = "0x2131474", VA = "0x2131474")] private set
      {
      }
    }

    [Token(Token = "0x17002612")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B79F"), Address(RVA = "0x213147C", Offset = "0x213147C", VA = "0x213147C")] set
      {
      }
      [Token(Token = "0x600B7A0"), Address(RVA = "0x2131498", Offset = "0x2131498", VA = "0x2131498")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B7A1")]
    [Address(RVA = "0x21314B4", Offset = "0x21314B4", VA = "0x21314B4")]
    public APIUnit_rankingRanking_tops(string apiPath = "api/v1/unit_ranking/ranking_tops")
    {
    }

    [Token(Token = "0x600B7A2")]
    [Address(RVA = "0x213154C", Offset = "0x213154C", VA = "0x213154C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B7A3")]
    [Address(RVA = "0x21315DC", Offset = "0x21315DC", VA = "0x21315DC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B7A4")]
    [Address(RVA = "0x21315E8", Offset = "0x21315E8", VA = "0x21315E8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B7A5")]
    [Address(RVA = "0x21316BC", Offset = "0x21316BC", VA = "0x21316BC")]
    private void OnSuccess(string json)
    {
    }
  }
}
