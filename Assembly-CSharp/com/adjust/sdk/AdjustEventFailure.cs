// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustEventFailure
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FF0")]
  public class AdjustEventFailure
  {
    [Token(Token = "0x170052EA")]
    public string Adid
    {
      [Token(Token = "0x6019BFF"), Address(RVA = "0x379C048", Offset = "0x379C048", VA = "0x379C048")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C00"), Address(RVA = "0x379C050", Offset = "0x379C050", VA = "0x379C050")] set
      {
      }
    }

    [Token(Token = "0x170052EB")]
    public string Message
    {
      [Token(Token = "0x6019C01"), Address(RVA = "0x379C058", Offset = "0x379C058", VA = "0x379C058")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C02"), Address(RVA = "0x379C060", Offset = "0x379C060", VA = "0x379C060")] set
      {
      }
    }

    [Token(Token = "0x170052EC")]
    public string Timestamp
    {
      [Token(Token = "0x6019C03"), Address(RVA = "0x379C068", Offset = "0x379C068", VA = "0x379C068")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C04"), Address(RVA = "0x379C070", Offset = "0x379C070", VA = "0x379C070")] set
      {
      }
    }

    [Token(Token = "0x170052ED")]
    public string EventToken
    {
      [Token(Token = "0x6019C05"), Address(RVA = "0x379C078", Offset = "0x379C078", VA = "0x379C078")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C06"), Address(RVA = "0x379C080", Offset = "0x379C080", VA = "0x379C080")] set
      {
      }
    }

    [Token(Token = "0x170052EE")]
    public string CallbackId
    {
      [Token(Token = "0x6019C07"), Address(RVA = "0x379C088", Offset = "0x379C088", VA = "0x379C088")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C08"), Address(RVA = "0x379C090", Offset = "0x379C090", VA = "0x379C090")] set
      {
      }
    }

    [Token(Token = "0x170052EF")]
    public bool WillRetry
    {
      [Token(Token = "0x6019C09"), Address(RVA = "0x379C098", Offset = "0x379C098", VA = "0x379C098")] get
      {
        return new bool();
      }
      [Token(Token = "0x6019C0A"), Address(RVA = "0x379C0A0", Offset = "0x379C0A0", VA = "0x379C0A0")] set
      {
      }
    }

    [Token(Token = "0x170052F0")]
    public Dictionary<string, object> JsonResponse
    {
      [Token(Token = "0x6019C0B"), Address(RVA = "0x379C0AC", Offset = "0x379C0AC", VA = "0x379C0AC")] get
      {
        return (Dictionary<string, object>) null;
      }
      [Token(Token = "0x6019C0C"), Address(RVA = "0x379C0B4", Offset = "0x379C0B4", VA = "0x379C0B4")] set
      {
      }
    }

    [Token(Token = "0x6019C0D")]
    [Address(RVA = "0x3798714", Offset = "0x3798714", VA = "0x3798714")]
    public AdjustEventFailure()
    {
    }

    [Token(Token = "0x6019C0E")]
    [Address(RVA = "0x379C0BC", Offset = "0x379C0BC", VA = "0x379C0BC")]
    public AdjustEventFailure(Dictionary<string, string> eventFailureDataMap)
    {
    }

    [Token(Token = "0x6019C0F")]
    [Address(RVA = "0x379C300", Offset = "0x379C300", VA = "0x379C300")]
    public AdjustEventFailure(string jsonString)
    {
    }

    [Token(Token = "0x6019C10")]
    [Address(RVA = "0x379871C", Offset = "0x379871C", VA = "0x379871C")]
    public void BuildJsonResponseFromString(string jsonResponseString)
    {
    }

    [Token(Token = "0x6019C11")]
    [Address(RVA = "0x379C54C", Offset = "0x379C54C", VA = "0x379C54C")]
    public string GetJsonResponse() => (string) null;
  }
}
