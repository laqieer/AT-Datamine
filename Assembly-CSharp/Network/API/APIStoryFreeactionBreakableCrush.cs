// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryFreeactionBreakableCrush
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E39")]
  public class APIStoryFreeactionBreakableCrush
  {
    [Token(Token = "0x400817B")]
    public const string DefaultAPIPath = "api/v1/story/freeaction/breakable/crush";
    [Token(Token = "0x400817F")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008180")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryFreeactionBreakableCrushResponse> onSuccess;
    [Token(Token = "0x4008181")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002433")]
    public APIStoryFreeactionBreakableCrushRequest Request
    {
      [Token(Token = "0x600B2FD"), Address(RVA = "0x22E1958", Offset = "0x22E1958", VA = "0x22E1958")] private get
      {
        return (APIStoryFreeactionBreakableCrushRequest) null;
      }
      [Token(Token = "0x600B2FE"), Address(RVA = "0x22E1960", Offset = "0x22E1960", VA = "0x22E1960")] set
      {
      }
    }

    [Token(Token = "0x17002434")]
    public APIStoryFreeactionBreakableCrushResponse Response
    {
      [Token(Token = "0x600B2FF"), Address(RVA = "0x22E1968", Offset = "0x22E1968", VA = "0x22E1968")] get
      {
        return (APIStoryFreeactionBreakableCrushResponse) null;
      }
      [Token(Token = "0x600B300"), Address(RVA = "0x22E1970", Offset = "0x22E1970", VA = "0x22E1970")] private set
      {
      }
    }

    [Token(Token = "0x17002435")]
    public int ResponseCode
    {
      [Token(Token = "0x600B301"), Address(RVA = "0x22E1978", Offset = "0x22E1978", VA = "0x22E1978")] get
      {
        return new int();
      }
      [Token(Token = "0x600B302"), Address(RVA = "0x22E1980", Offset = "0x22E1980", VA = "0x22E1980")] private set
      {
      }
    }

    [Token(Token = "0x17002436")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B303"), Address(RVA = "0x22E1988", Offset = "0x22E1988", VA = "0x22E1988")] set
      {
      }
      [Token(Token = "0x600B304"), Address(RVA = "0x22E19A4", Offset = "0x22E19A4", VA = "0x22E19A4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B305")]
    [Address(RVA = "0x22E19C0", Offset = "0x22E19C0", VA = "0x22E19C0")]
    public APIStoryFreeactionBreakableCrush(string apiPath = "api/v1/story/freeaction/breakable/crush")
    {
    }

    [Token(Token = "0x600B306")]
    [Address(RVA = "0x22E1A58", Offset = "0x22E1A58", VA = "0x22E1A58")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B307")]
    [Address(RVA = "0x22E1AE8", Offset = "0x22E1AE8", VA = "0x22E1AE8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B308")]
    [Address(RVA = "0x22E1AF4", Offset = "0x22E1AF4", VA = "0x22E1AF4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B309")]
    [Address(RVA = "0x22E1BC8", Offset = "0x22E1BC8", VA = "0x22E1BC8")]
    private void OnSuccess(string json)
    {
    }
  }
}
