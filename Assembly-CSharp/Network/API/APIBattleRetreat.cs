// Decompiled with JetBrains decompiler
// Type: Network.API.APIBattleRetreat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BAD")]
  public class APIBattleRetreat
  {
    [Token(Token = "0x40076AA")]
    public const string DefaultAPIPath = "api/v1/battle/retreat";
    [Token(Token = "0x40076AE")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40076AF")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIBattleRetreatResponse> onSuccess;
    [Token(Token = "0x40076B0")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E0B")]
    public APIBattleRetreatRequest Request
    {
      [Token(Token = "0x600A2A5"), Address(RVA = "0x46CBE7C", Offset = "0x46CBE7C", VA = "0x46CBE7C")] private get
      {
        return (APIBattleRetreatRequest) null;
      }
      [Token(Token = "0x600A2A6"), Address(RVA = "0x46CBE84", Offset = "0x46CBE84", VA = "0x46CBE84")] set
      {
      }
    }

    [Token(Token = "0x17001E0C")]
    public APIBattleRetreatResponse Response
    {
      [Token(Token = "0x600A2A7"), Address(RVA = "0x46CBE8C", Offset = "0x46CBE8C", VA = "0x46CBE8C")] get
      {
        return (APIBattleRetreatResponse) null;
      }
      [Token(Token = "0x600A2A8"), Address(RVA = "0x46CBE94", Offset = "0x46CBE94", VA = "0x46CBE94")] private set
      {
      }
    }

    [Token(Token = "0x17001E0D")]
    public int ResponseCode
    {
      [Token(Token = "0x600A2A9"), Address(RVA = "0x46CBE9C", Offset = "0x46CBE9C", VA = "0x46CBE9C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A2AA"), Address(RVA = "0x46CBEA4", Offset = "0x46CBEA4", VA = "0x46CBEA4")] private set
      {
      }
    }

    [Token(Token = "0x17001E0E")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A2AB"), Address(RVA = "0x46CBEAC", Offset = "0x46CBEAC", VA = "0x46CBEAC")] set
      {
      }
      [Token(Token = "0x600A2AC"), Address(RVA = "0x46CBEC8", Offset = "0x46CBEC8", VA = "0x46CBEC8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A2AD")]
    [Address(RVA = "0x46CBEE4", Offset = "0x46CBEE4", VA = "0x46CBEE4")]
    public APIBattleRetreat(string apiPath = "api/v1/battle/retreat")
    {
    }

    [Token(Token = "0x600A2AE")]
    [Address(RVA = "0x46CBF7C", Offset = "0x46CBF7C", VA = "0x46CBF7C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A2AF")]
    [Address(RVA = "0x46CC00C", Offset = "0x46CC00C", VA = "0x46CC00C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A2B0")]
    [Address(RVA = "0x46CC018", Offset = "0x46CC018", VA = "0x46CC018")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A2B1")]
    [Address(RVA = "0x46CC0EC", Offset = "0x46CC0EC", VA = "0x46CC0EC")]
    private void OnSuccess(string json)
    {
    }
  }
}
