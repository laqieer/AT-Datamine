// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildFacilityIndex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CC1")]
  public class APIGuildFacilityIndex
  {
    [Token(Token = "0x4007AEA")]
    public const string DefaultAPIPath = "api/v1/guild/facility/index";
    [Token(Token = "0x4007AEE")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007AEF")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildFacilityIndexResponse> onSuccess;
    [Token(Token = "0x4007AF0")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700207C")]
    public APIGuildFacilityIndexRequest Request
    {
      [Token(Token = "0x600A966"), Address(RVA = "0x1915294", Offset = "0x1915294", VA = "0x1915294")] private get
      {
        return (APIGuildFacilityIndexRequest) null;
      }
      [Token(Token = "0x600A967"), Address(RVA = "0x191529C", Offset = "0x191529C", VA = "0x191529C")] set
      {
      }
    }

    [Token(Token = "0x1700207D")]
    public APIGuildFacilityIndexResponse Response
    {
      [Token(Token = "0x600A968"), Address(RVA = "0x19152A4", Offset = "0x19152A4", VA = "0x19152A4")] get
      {
        return (APIGuildFacilityIndexResponse) null;
      }
      [Token(Token = "0x600A969"), Address(RVA = "0x19152AC", Offset = "0x19152AC", VA = "0x19152AC")] private set
      {
      }
    }

    [Token(Token = "0x1700207E")]
    public int ResponseCode
    {
      [Token(Token = "0x600A96A"), Address(RVA = "0x19152B4", Offset = "0x19152B4", VA = "0x19152B4")] get
      {
        return new int();
      }
      [Token(Token = "0x600A96B"), Address(RVA = "0x19152BC", Offset = "0x19152BC", VA = "0x19152BC")] private set
      {
      }
    }

    [Token(Token = "0x1700207F")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A96C"), Address(RVA = "0x19152C4", Offset = "0x19152C4", VA = "0x19152C4")] set
      {
      }
      [Token(Token = "0x600A96D"), Address(RVA = "0x19152E0", Offset = "0x19152E0", VA = "0x19152E0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A96E")]
    [Address(RVA = "0x19152FC", Offset = "0x19152FC", VA = "0x19152FC")]
    public APIGuildFacilityIndex(string apiPath = "api/v1/guild/facility/index")
    {
    }

    [Token(Token = "0x600A96F")]
    [Address(RVA = "0x1915394", Offset = "0x1915394", VA = "0x1915394")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A970")]
    [Address(RVA = "0x1915424", Offset = "0x1915424", VA = "0x1915424")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A971")]
    [Address(RVA = "0x1915430", Offset = "0x1915430", VA = "0x1915430")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A972")]
    [Address(RVA = "0x1915504", Offset = "0x1915504", VA = "0x1915504")]
    private void OnSuccess(string json)
    {
    }
  }
}
