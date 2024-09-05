// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0001Provide_detail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C89")]
  public class APIG0001Provide_detail
  {
    [Token(Token = "0x4007A13")]
    public const string DefaultAPIPath = "api/gacha/G0001/provide_detail";
    [Token(Token = "0x4007A17")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007A18")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIG0001Provide_detailResponse> onSuccess;
    [Token(Token = "0x4007A19")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002005")]
    public APIG0001Provide_detailRequest Request
    {
      [Token(Token = "0x600A80F"), Address(RVA = "0x1910764", Offset = "0x1910764", VA = "0x1910764")] private get
      {
        return (APIG0001Provide_detailRequest) null;
      }
      [Token(Token = "0x600A810"), Address(RVA = "0x191076C", Offset = "0x191076C", VA = "0x191076C")] set
      {
      }
    }

    [Token(Token = "0x17002006")]
    public APIG0001Provide_detailResponse Response
    {
      [Token(Token = "0x600A811"), Address(RVA = "0x1910774", Offset = "0x1910774", VA = "0x1910774")] get
      {
        return (APIG0001Provide_detailResponse) null;
      }
      [Token(Token = "0x600A812"), Address(RVA = "0x191077C", Offset = "0x191077C", VA = "0x191077C")] private set
      {
      }
    }

    [Token(Token = "0x17002007")]
    public int ResponseCode
    {
      [Token(Token = "0x600A813"), Address(RVA = "0x1910784", Offset = "0x1910784", VA = "0x1910784")] get
      {
        return new int();
      }
      [Token(Token = "0x600A814"), Address(RVA = "0x191078C", Offset = "0x191078C", VA = "0x191078C")] private set
      {
      }
    }

    [Token(Token = "0x17002008")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A815"), Address(RVA = "0x1910794", Offset = "0x1910794", VA = "0x1910794")] set
      {
      }
      [Token(Token = "0x600A816"), Address(RVA = "0x19107B0", Offset = "0x19107B0", VA = "0x19107B0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A817")]
    [Address(RVA = "0x19107CC", Offset = "0x19107CC", VA = "0x19107CC")]
    public APIG0001Provide_detail(string apiPath = "api/gacha/G0001/provide_detail")
    {
    }

    [Token(Token = "0x600A818")]
    [Address(RVA = "0x1910864", Offset = "0x1910864", VA = "0x1910864")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A819")]
    [Address(RVA = "0x19108F4", Offset = "0x19108F4", VA = "0x19108F4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A81A")]
    [Address(RVA = "0x1910900", Offset = "0x1910900", VA = "0x1910900")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A81B")]
    [Address(RVA = "0x19109D4", Offset = "0x19109D4", VA = "0x19109D4")]
    private void OnSuccess(string json)
    {
    }
  }
}
