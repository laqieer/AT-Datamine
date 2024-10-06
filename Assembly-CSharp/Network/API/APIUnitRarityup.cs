// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitRarityup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EC5")]
  public class APIUnitRarityup
  {
    [Token(Token = "0x4008428")]
    public const string DefaultAPIPath = "api/v1/unit/rarityup";
    [Token(Token = "0x400842C")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400842D")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitRarityupResponse> onSuccess;
    [Token(Token = "0x400842E")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170025BD")]
    public APIUnitRarityupRequest Request
    {
      [Token(Token = "0x600B6B7"), Address(RVA = "0x22ED87C", Offset = "0x22ED87C", VA = "0x22ED87C")] private get
      {
        return (APIUnitRarityupRequest) null;
      }
      [Token(Token = "0x600B6B8"), Address(RVA = "0x22ED884", Offset = "0x22ED884", VA = "0x22ED884")] set
      {
      }
    }

    [Token(Token = "0x170025BE")]
    public APIUnitRarityupResponse Response
    {
      [Token(Token = "0x600B6B9"), Address(RVA = "0x22ED88C", Offset = "0x22ED88C", VA = "0x22ED88C")] get
      {
        return (APIUnitRarityupResponse) null;
      }
      [Token(Token = "0x600B6BA"), Address(RVA = "0x22ED894", Offset = "0x22ED894", VA = "0x22ED894")] private set
      {
      }
    }

    [Token(Token = "0x170025BF")]
    public int ResponseCode
    {
      [Token(Token = "0x600B6BB"), Address(RVA = "0x22ED89C", Offset = "0x22ED89C", VA = "0x22ED89C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B6BC"), Address(RVA = "0x22ED8A4", Offset = "0x22ED8A4", VA = "0x22ED8A4")] private set
      {
      }
    }

    [Token(Token = "0x170025C0")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B6BD"), Address(RVA = "0x22ED8AC", Offset = "0x22ED8AC", VA = "0x22ED8AC")] set
      {
      }
      [Token(Token = "0x600B6BE"), Address(RVA = "0x22ED8C8", Offset = "0x22ED8C8", VA = "0x22ED8C8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B6BF")]
    [Address(RVA = "0x22ED8E4", Offset = "0x22ED8E4", VA = "0x22ED8E4")]
    public APIUnitRarityup(string apiPath = "api/v1/unit/rarityup")
    {
    }

    [Token(Token = "0x600B6C0")]
    [Address(RVA = "0x22ED97C", Offset = "0x22ED97C", VA = "0x22ED97C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B6C1")]
    [Address(RVA = "0x22EDA0C", Offset = "0x22EDA0C", VA = "0x22EDA0C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B6C2")]
    [Address(RVA = "0x22EDA18", Offset = "0x22EDA18", VA = "0x22EDA18")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B6C3")]
    [Address(RVA = "0x22EDAEC", Offset = "0x22EDAEC", VA = "0x22EDAEC")]
    private void OnSuccess(string json)
    {
    }
  }
}
