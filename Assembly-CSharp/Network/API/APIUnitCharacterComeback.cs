// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitCharacterComeback
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EAD")]
  public class APIUnitCharacterComeback
  {
    [Token(Token = "0x40083CE")]
    public const string DefaultAPIPath = "api/v1/unit/character/comeback";
    [Token(Token = "0x40083D2")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40083D3")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitCharacterComebackResponse> onSuccess;
    [Token(Token = "0x40083D4")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700258B")]
    public APIUnitCharacterComebackRequest Request
    {
      [Token(Token = "0x600B625"), Address(RVA = "0x22EB844", Offset = "0x22EB844", VA = "0x22EB844")] private get
      {
        return (APIUnitCharacterComebackRequest) null;
      }
      [Token(Token = "0x600B626"), Address(RVA = "0x22EB84C", Offset = "0x22EB84C", VA = "0x22EB84C")] set
      {
      }
    }

    [Token(Token = "0x1700258C")]
    public APIUnitCharacterComebackResponse Response
    {
      [Token(Token = "0x600B627"), Address(RVA = "0x22EB854", Offset = "0x22EB854", VA = "0x22EB854")] get
      {
        return (APIUnitCharacterComebackResponse) null;
      }
      [Token(Token = "0x600B628"), Address(RVA = "0x22EB85C", Offset = "0x22EB85C", VA = "0x22EB85C")] private set
      {
      }
    }

    [Token(Token = "0x1700258D")]
    public int ResponseCode
    {
      [Token(Token = "0x600B629"), Address(RVA = "0x22EB864", Offset = "0x22EB864", VA = "0x22EB864")] get
      {
        return new int();
      }
      [Token(Token = "0x600B62A"), Address(RVA = "0x22EB86C", Offset = "0x22EB86C", VA = "0x22EB86C")] private set
      {
      }
    }

    [Token(Token = "0x1700258E")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B62B"), Address(RVA = "0x22EB874", Offset = "0x22EB874", VA = "0x22EB874")] set
      {
      }
      [Token(Token = "0x600B62C"), Address(RVA = "0x22EB890", Offset = "0x22EB890", VA = "0x22EB890")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B62D")]
    [Address(RVA = "0x22EB8AC", Offset = "0x22EB8AC", VA = "0x22EB8AC")]
    public APIUnitCharacterComeback(string apiPath = "api/v1/unit/character/comeback")
    {
    }

    [Token(Token = "0x600B62E")]
    [Address(RVA = "0x22EB944", Offset = "0x22EB944", VA = "0x22EB944")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B62F")]
    [Address(RVA = "0x22EB9D4", Offset = "0x22EB9D4", VA = "0x22EB9D4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B630")]
    [Address(RVA = "0x22EB9E0", Offset = "0x22EB9E0", VA = "0x22EB9E0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B631")]
    [Address(RVA = "0x22EBAB4", Offset = "0x22EBAB4", VA = "0x22EBAB4")]
    private void OnSuccess(string json)
    {
    }
  }
}
