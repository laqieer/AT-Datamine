// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionPartyStageChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C29")]
  public class APIExpeditionPartyStageChange
  {
    [Token(Token = "0x400788E")]
    public const string DefaultAPIPath = "api/v1/expedition/party/stage/change";
    [Token(Token = "0x4007892")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007893")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIExpeditionPartyStageChangeResponse> onSuccess;
    [Token(Token = "0x4007894")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001F23")]
    public APIExpeditionPartyStageChangeRequest Request
    {
      [Token(Token = "0x600A5AD"), Address(RVA = "0x19085B4", Offset = "0x19085B4", VA = "0x19085B4")] private get
      {
        return (APIExpeditionPartyStageChangeRequest) null;
      }
      [Token(Token = "0x600A5AE"), Address(RVA = "0x19085BC", Offset = "0x19085BC", VA = "0x19085BC")] set
      {
      }
    }

    [Token(Token = "0x17001F24")]
    public APIExpeditionPartyStageChangeResponse Response
    {
      [Token(Token = "0x600A5AF"), Address(RVA = "0x19085C4", Offset = "0x19085C4", VA = "0x19085C4")] get
      {
        return (APIExpeditionPartyStageChangeResponse) null;
      }
      [Token(Token = "0x600A5B0"), Address(RVA = "0x19085CC", Offset = "0x19085CC", VA = "0x19085CC")] private set
      {
      }
    }

    [Token(Token = "0x17001F25")]
    public int ResponseCode
    {
      [Token(Token = "0x600A5B1"), Address(RVA = "0x19085D4", Offset = "0x19085D4", VA = "0x19085D4")] get
      {
        return new int();
      }
      [Token(Token = "0x600A5B2"), Address(RVA = "0x19085DC", Offset = "0x19085DC", VA = "0x19085DC")] private set
      {
      }
    }

    [Token(Token = "0x17001F26")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A5B3"), Address(RVA = "0x19085E4", Offset = "0x19085E4", VA = "0x19085E4")] set
      {
      }
      [Token(Token = "0x600A5B4"), Address(RVA = "0x1908600", Offset = "0x1908600", VA = "0x1908600")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A5B5")]
    [Address(RVA = "0x190861C", Offset = "0x190861C", VA = "0x190861C")]
    public APIExpeditionPartyStageChange(string apiPath = "api/v1/expedition/party/stage/change")
    {
    }

    [Token(Token = "0x600A5B6")]
    [Address(RVA = "0x19086B4", Offset = "0x19086B4", VA = "0x19086B4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A5B7")]
    [Address(RVA = "0x1908744", Offset = "0x1908744", VA = "0x1908744")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A5B8")]
    [Address(RVA = "0x1908750", Offset = "0x1908750", VA = "0x1908750")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A5B9")]
    [Address(RVA = "0x1908824", Offset = "0x1908824", VA = "0x1908824")]
    private void OnSuccess(string json)
    {
    }
  }
}
