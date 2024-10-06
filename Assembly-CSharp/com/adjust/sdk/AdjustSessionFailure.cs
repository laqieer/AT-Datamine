// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustSessionFailure
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FF7")]
  public class AdjustSessionFailure
  {
    [Token(Token = "0x170052FA")]
    public string Adid
    {
      [Token(Token = "0x6019C32"), Address(RVA = "0x3B3AA30", Offset = "0x3B3AA30", VA = "0x3B3AA30")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C33"), Address(RVA = "0x3B3AA38", Offset = "0x3B3AA38", VA = "0x3B3AA38")] set
      {
      }
    }

    [Token(Token = "0x170052FB")]
    public string Message
    {
      [Token(Token = "0x6019C34"), Address(RVA = "0x3B3AA40", Offset = "0x3B3AA40", VA = "0x3B3AA40")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C35"), Address(RVA = "0x3B3AA48", Offset = "0x3B3AA48", VA = "0x3B3AA48")] set
      {
      }
    }

    [Token(Token = "0x170052FC")]
    public string Timestamp
    {
      [Token(Token = "0x6019C36"), Address(RVA = "0x3B3AA50", Offset = "0x3B3AA50", VA = "0x3B3AA50")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C37"), Address(RVA = "0x3B3AA58", Offset = "0x3B3AA58", VA = "0x3B3AA58")] set
      {
      }
    }

    [Token(Token = "0x170052FD")]
    public bool WillRetry
    {
      [Token(Token = "0x6019C38"), Address(RVA = "0x3B3AA60", Offset = "0x3B3AA60", VA = "0x3B3AA60")] get
      {
        return new bool();
      }
      [Token(Token = "0x6019C39"), Address(RVA = "0x3B3AA68", Offset = "0x3B3AA68", VA = "0x3B3AA68")] set
      {
      }
    }

    [Token(Token = "0x170052FE")]
    public Dictionary<string, object> JsonResponse
    {
      [Token(Token = "0x6019C3A"), Address(RVA = "0x3B3AA74", Offset = "0x3B3AA74", VA = "0x3B3AA74")] get
      {
        return (Dictionary<string, object>) null;
      }
      [Token(Token = "0x6019C3B"), Address(RVA = "0x3B3AA7C", Offset = "0x3B3AA7C", VA = "0x3B3AA7C")] set
      {
      }
    }

    [Token(Token = "0x6019C3C")]
    [Address(RVA = "0x3B3AA84", Offset = "0x3B3AA84", VA = "0x3B3AA84")]
    public AdjustSessionFailure()
    {
    }

    [Token(Token = "0x6019C3D")]
    [Address(RVA = "0x3B3AA8C", Offset = "0x3B3AA8C", VA = "0x3B3AA8C")]
    public AdjustSessionFailure(Dictionary<string, string> sessionFailureDataMap)
    {
    }

    [Token(Token = "0x6019C3E")]
    [Address(RVA = "0x3B3B158", Offset = "0x3B3B158", VA = "0x3B3B158")]
    public AdjustSessionFailure(string jsonString)
    {
    }

    [Token(Token = "0x6019C3F")]
    [Address(RVA = "0x3B3B368", Offset = "0x3B3B368", VA = "0x3B3B368")]
    public void BuildJsonResponseFromString(string jsonResponseString)
    {
    }

    [Token(Token = "0x6019C40")]
    [Address(RVA = "0x3B3B45C", Offset = "0x3B3B45C", VA = "0x3B3B45C")]
    public string GetJsonResponse() => (string) null;
  }
}
