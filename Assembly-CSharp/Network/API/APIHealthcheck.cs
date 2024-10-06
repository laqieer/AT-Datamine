// Decompiled with JetBrains decompiler
// Type: Network.API.APIHealthcheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D29")]
  public class APIHealthcheck
  {
    [Token(Token = "0x4007C8B")]
    public const string DefaultAPIPath = "pass/healthcheck";
    [Token(Token = "0x4007C8F")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007C90")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIHealthcheckResponse> onSuccess;
    [Token(Token = "0x4007C91")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002157")]
    public APIHealthcheckRequest Request
    {
      [Token(Token = "0x600ABE1"), Address(RVA = "0x1A448EC", Offset = "0x1A448EC", VA = "0x1A448EC")] private get
      {
        return (APIHealthcheckRequest) null;
      }
      [Token(Token = "0x600ABE2"), Address(RVA = "0x1A448F4", Offset = "0x1A448F4", VA = "0x1A448F4")] set
      {
      }
    }

    [Token(Token = "0x17002158")]
    public APIHealthcheckResponse Response
    {
      [Token(Token = "0x600ABE3"), Address(RVA = "0x1A448FC", Offset = "0x1A448FC", VA = "0x1A448FC")] get
      {
        return (APIHealthcheckResponse) null;
      }
      [Token(Token = "0x600ABE4"), Address(RVA = "0x1A44904", Offset = "0x1A44904", VA = "0x1A44904")] private set
      {
      }
    }

    [Token(Token = "0x17002159")]
    public int ResponseCode
    {
      [Token(Token = "0x600ABE5"), Address(RVA = "0x1A4490C", Offset = "0x1A4490C", VA = "0x1A4490C")] get
      {
        return new int();
      }
      [Token(Token = "0x600ABE6"), Address(RVA = "0x1A44914", Offset = "0x1A44914", VA = "0x1A44914")] private set
      {
      }
    }

    [Token(Token = "0x1700215A")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600ABE7"), Address(RVA = "0x1A4491C", Offset = "0x1A4491C", VA = "0x1A4491C")] set
      {
      }
      [Token(Token = "0x600ABE8"), Address(RVA = "0x1A44938", Offset = "0x1A44938", VA = "0x1A44938")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600ABE9")]
    [Address(RVA = "0x1A44954", Offset = "0x1A44954", VA = "0x1A44954")]
    public APIHealthcheck(string apiPath = "pass/healthcheck")
    {
    }

    [Token(Token = "0x600ABEA")]
    [Address(RVA = "0x1A449EC", Offset = "0x1A449EC", VA = "0x1A449EC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600ABEB")]
    [Address(RVA = "0x1A44A7C", Offset = "0x1A44A7C", VA = "0x1A44A7C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600ABEC")]
    [Address(RVA = "0x1A44A88", Offset = "0x1A44A88", VA = "0x1A44A88")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600ABED")]
    [Address(RVA = "0x1A44B5C", Offset = "0x1A44B5C", VA = "0x1A44B5C")]
    private void OnSuccess(string json)
    {
    }
  }
}
