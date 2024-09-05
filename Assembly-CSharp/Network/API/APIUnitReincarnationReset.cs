// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitReincarnationReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001ECD")]
  public class APIUnitReincarnationReset
  {
    [Token(Token = "0x400844B")]
    public const string DefaultAPIPath = "api/v1/unit/reincarnation/reset";
    [Token(Token = "0x400844F")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008450")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitReincarnationResetResponse> onSuccess;
    [Token(Token = "0x4008451")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170025D2")]
    public APIUnitReincarnationResetRequest Request
    {
      [Token(Token = "0x600B6EC"), Address(RVA = "0x22EE35C", Offset = "0x22EE35C", VA = "0x22EE35C")] private get
      {
        return (APIUnitReincarnationResetRequest) null;
      }
      [Token(Token = "0x600B6ED"), Address(RVA = "0x22EE364", Offset = "0x22EE364", VA = "0x22EE364")] set
      {
      }
    }

    [Token(Token = "0x170025D3")]
    public APIUnitReincarnationResetResponse Response
    {
      [Token(Token = "0x600B6EE"), Address(RVA = "0x22EE36C", Offset = "0x22EE36C", VA = "0x22EE36C")] get
      {
        return (APIUnitReincarnationResetResponse) null;
      }
      [Token(Token = "0x600B6EF"), Address(RVA = "0x22EE374", Offset = "0x22EE374", VA = "0x22EE374")] private set
      {
      }
    }

    [Token(Token = "0x170025D4")]
    public int ResponseCode
    {
      [Token(Token = "0x600B6F0"), Address(RVA = "0x22EE37C", Offset = "0x22EE37C", VA = "0x22EE37C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B6F1"), Address(RVA = "0x22EE384", Offset = "0x22EE384", VA = "0x22EE384")] private set
      {
      }
    }

    [Token(Token = "0x170025D5")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B6F2"), Address(RVA = "0x22EE38C", Offset = "0x22EE38C", VA = "0x22EE38C")] set
      {
      }
      [Token(Token = "0x600B6F3"), Address(RVA = "0x22EE3A8", Offset = "0x22EE3A8", VA = "0x22EE3A8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B6F4")]
    [Address(RVA = "0x22EE3C4", Offset = "0x22EE3C4", VA = "0x22EE3C4")]
    public APIUnitReincarnationReset(string apiPath = "api/v1/unit/reincarnation/reset")
    {
    }

    [Token(Token = "0x600B6F5")]
    [Address(RVA = "0x22EE45C", Offset = "0x22EE45C", VA = "0x22EE45C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B6F6")]
    [Address(RVA = "0x22EE4EC", Offset = "0x22EE4EC", VA = "0x22EE4EC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B6F7")]
    [Address(RVA = "0x22EE4F8", Offset = "0x22EE4F8", VA = "0x22EE4F8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B6F8")]
    [Address(RVA = "0x22EE5CC", Offset = "0x22EE5CC", VA = "0x22EE5CC")]
    private void OnSuccess(string json)
    {
    }
  }
}
