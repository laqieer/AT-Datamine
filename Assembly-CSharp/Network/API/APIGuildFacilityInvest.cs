// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildFacilityInvest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CC5")]
  public class APIGuildFacilityInvest
  {
    [Token(Token = "0x4007AFE")]
    public const string DefaultAPIPath = "api/v1/guild/facility/invest";
    [Token(Token = "0x4007B02")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007B03")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildFacilityInvestResponse> onSuccess;
    [Token(Token = "0x4007B04")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002087")]
    public APIGuildFacilityInvestRequest Request
    {
      [Token(Token = "0x600A981"), Address(RVA = "0x1915808", Offset = "0x1915808", VA = "0x1915808")] private get
      {
        return (APIGuildFacilityInvestRequest) null;
      }
      [Token(Token = "0x600A982"), Address(RVA = "0x1915810", Offset = "0x1915810", VA = "0x1915810")] set
      {
      }
    }

    [Token(Token = "0x17002088")]
    public APIGuildFacilityInvestResponse Response
    {
      [Token(Token = "0x600A983"), Address(RVA = "0x1915818", Offset = "0x1915818", VA = "0x1915818")] get
      {
        return (APIGuildFacilityInvestResponse) null;
      }
      [Token(Token = "0x600A984"), Address(RVA = "0x1915820", Offset = "0x1915820", VA = "0x1915820")] private set
      {
      }
    }

    [Token(Token = "0x17002089")]
    public int ResponseCode
    {
      [Token(Token = "0x600A985"), Address(RVA = "0x1915828", Offset = "0x1915828", VA = "0x1915828")] get
      {
        return new int();
      }
      [Token(Token = "0x600A986"), Address(RVA = "0x1915830", Offset = "0x1915830", VA = "0x1915830")] private set
      {
      }
    }

    [Token(Token = "0x1700208A")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A987"), Address(RVA = "0x1915838", Offset = "0x1915838", VA = "0x1915838")] set
      {
      }
      [Token(Token = "0x600A988"), Address(RVA = "0x1915854", Offset = "0x1915854", VA = "0x1915854")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A989")]
    [Address(RVA = "0x1915870", Offset = "0x1915870", VA = "0x1915870")]
    public APIGuildFacilityInvest(string apiPath = "api/v1/guild/facility/invest")
    {
    }

    [Token(Token = "0x600A98A")]
    [Address(RVA = "0x1915908", Offset = "0x1915908", VA = "0x1915908")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A98B")]
    [Address(RVA = "0x1915998", Offset = "0x1915998", VA = "0x1915998")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A98C")]
    [Address(RVA = "0x19159A4", Offset = "0x19159A4", VA = "0x19159A4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A98D")]
    [Address(RVA = "0x1915A78", Offset = "0x1915A78", VA = "0x1915A78")]
    private void OnSuccess(string json)
    {
    }
  }
}
