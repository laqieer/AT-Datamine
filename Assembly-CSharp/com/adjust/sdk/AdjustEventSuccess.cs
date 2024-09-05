// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustEventSuccess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FF1")]
  public class AdjustEventSuccess
  {
    [Token(Token = "0x170052F1")]
    public string Adid
    {
      [Token(Token = "0x6019C12"), Address(RVA = "0x379C5A8", Offset = "0x379C5A8", VA = "0x379C5A8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C13"), Address(RVA = "0x379C5B0", Offset = "0x379C5B0", VA = "0x379C5B0")] set
      {
      }
    }

    [Token(Token = "0x170052F2")]
    public string Message
    {
      [Token(Token = "0x6019C14"), Address(RVA = "0x379C5B8", Offset = "0x379C5B8", VA = "0x379C5B8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C15"), Address(RVA = "0x379C5C0", Offset = "0x379C5C0", VA = "0x379C5C0")] set
      {
      }
    }

    [Token(Token = "0x170052F3")]
    public string Timestamp
    {
      [Token(Token = "0x6019C16"), Address(RVA = "0x379C5C8", Offset = "0x379C5C8", VA = "0x379C5C8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C17"), Address(RVA = "0x379C5D0", Offset = "0x379C5D0", VA = "0x379C5D0")] set
      {
      }
    }

    [Token(Token = "0x170052F4")]
    public string EventToken
    {
      [Token(Token = "0x6019C18"), Address(RVA = "0x379C5D8", Offset = "0x379C5D8", VA = "0x379C5D8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C19"), Address(RVA = "0x379C5E0", Offset = "0x379C5E0", VA = "0x379C5E0")] set
      {
      }
    }

    [Token(Token = "0x170052F5")]
    public string CallbackId
    {
      [Token(Token = "0x6019C1A"), Address(RVA = "0x379C5E8", Offset = "0x379C5E8", VA = "0x379C5E8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C1B"), Address(RVA = "0x379C5F0", Offset = "0x379C5F0", VA = "0x379C5F0")] set
      {
      }
    }

    [Token(Token = "0x170052F6")]
    public Dictionary<string, object> JsonResponse
    {
      [Token(Token = "0x6019C1C"), Address(RVA = "0x379C5F8", Offset = "0x379C5F8", VA = "0x379C5F8")] get
      {
        return (Dictionary<string, object>) null;
      }
      [Token(Token = "0x6019C1D"), Address(RVA = "0x379C600", Offset = "0x379C600", VA = "0x379C600")] set
      {
      }
    }

    [Token(Token = "0x6019C1E")]
    [Address(RVA = "0x3798188", Offset = "0x3798188", VA = "0x3798188")]
    public AdjustEventSuccess()
    {
    }

    [Token(Token = "0x6019C1F")]
    [Address(RVA = "0x379C608", Offset = "0x379C608", VA = "0x379C608")]
    public AdjustEventSuccess(Dictionary<string, string> eventSuccessDataMap)
    {
    }

    [Token(Token = "0x6019C20")]
    [Address(RVA = "0x379C7E4", Offset = "0x379C7E4", VA = "0x379C7E4")]
    public AdjustEventSuccess(string jsonString)
    {
    }

    [Token(Token = "0x6019C21")]
    [Address(RVA = "0x3798190", Offset = "0x3798190", VA = "0x3798190")]
    public void BuildJsonResponseFromString(string jsonResponseString)
    {
    }

    [Token(Token = "0x6019C22")]
    [Address(RVA = "0x379C9D8", Offset = "0x379C9D8", VA = "0x379C9D8")]
    public string GetJsonResponse() => (string) null;
  }
}
