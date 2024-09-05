// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryFreeactionSkip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E41")]
  public class APIStoryFreeactionSkip
  {
    [Token(Token = "0x40081A0")]
    public const string DefaultAPIPath = "api/v1/story/freeaction/skip";
    [Token(Token = "0x40081A4")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40081A5")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryFreeactionSkipResponse> onSuccess;
    [Token(Token = "0x40081A6")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700244B")]
    public APIStoryFreeactionSkipRequest Request
    {
      [Token(Token = "0x600B335"), Address(RVA = "0x22E2450", Offset = "0x22E2450", VA = "0x22E2450")] private get
      {
        return (APIStoryFreeactionSkipRequest) null;
      }
      [Token(Token = "0x600B336"), Address(RVA = "0x22E2458", Offset = "0x22E2458", VA = "0x22E2458")] set
      {
      }
    }

    [Token(Token = "0x1700244C")]
    public APIStoryFreeactionSkipResponse Response
    {
      [Token(Token = "0x600B337"), Address(RVA = "0x22E2460", Offset = "0x22E2460", VA = "0x22E2460")] get
      {
        return (APIStoryFreeactionSkipResponse) null;
      }
      [Token(Token = "0x600B338"), Address(RVA = "0x22E2468", Offset = "0x22E2468", VA = "0x22E2468")] private set
      {
      }
    }

    [Token(Token = "0x1700244D")]
    public int ResponseCode
    {
      [Token(Token = "0x600B339"), Address(RVA = "0x22E2470", Offset = "0x22E2470", VA = "0x22E2470")] get
      {
        return new int();
      }
      [Token(Token = "0x600B33A"), Address(RVA = "0x22E2478", Offset = "0x22E2478", VA = "0x22E2478")] private set
      {
      }
    }

    [Token(Token = "0x1700244E")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B33B"), Address(RVA = "0x22E2480", Offset = "0x22E2480", VA = "0x22E2480")] set
      {
      }
      [Token(Token = "0x600B33C"), Address(RVA = "0x22E249C", Offset = "0x22E249C", VA = "0x22E249C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B33D")]
    [Address(RVA = "0x22E24B8", Offset = "0x22E24B8", VA = "0x22E24B8")]
    public APIStoryFreeactionSkip(string apiPath = "api/v1/story/freeaction/skip")
    {
    }

    [Token(Token = "0x600B33E")]
    [Address(RVA = "0x22E2550", Offset = "0x22E2550", VA = "0x22E2550")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B33F")]
    [Address(RVA = "0x22E25E0", Offset = "0x22E25E0", VA = "0x22E25E0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B340")]
    [Address(RVA = "0x22E25EC", Offset = "0x22E25EC", VA = "0x22E25EC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B341")]
    [Address(RVA = "0x22E26C0", Offset = "0x22E26C0", VA = "0x22E26C0")]
    private void OnSuccess(string json)
    {
    }
  }
}
