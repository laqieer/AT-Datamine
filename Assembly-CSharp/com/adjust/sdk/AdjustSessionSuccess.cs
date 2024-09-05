// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustSessionSuccess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FF8")]
  public class AdjustSessionSuccess
  {
    [Token(Token = "0x170052FF")]
    public string Adid
    {
      [Token(Token = "0x6019C41"), Address(RVA = "0x3B3BBAC", Offset = "0x3B3BBAC", VA = "0x3B3BBAC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C42"), Address(RVA = "0x3B3BBB4", Offset = "0x3B3BBB4", VA = "0x3B3BBB4")] set
      {
      }
    }

    [Token(Token = "0x17005300")]
    public string Message
    {
      [Token(Token = "0x6019C43"), Address(RVA = "0x3B3BBBC", Offset = "0x3B3BBBC", VA = "0x3B3BBBC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C44"), Address(RVA = "0x3B3BBC4", Offset = "0x3B3BBC4", VA = "0x3B3BBC4")] set
      {
      }
    }

    [Token(Token = "0x17005301")]
    public string Timestamp
    {
      [Token(Token = "0x6019C45"), Address(RVA = "0x3B3BBCC", Offset = "0x3B3BBCC", VA = "0x3B3BBCC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019C46"), Address(RVA = "0x3B3BBD4", Offset = "0x3B3BBD4", VA = "0x3B3BBD4")] set
      {
      }
    }

    [Token(Token = "0x17005302")]
    public Dictionary<string, object> JsonResponse
    {
      [Token(Token = "0x6019C47"), Address(RVA = "0x3B3BBDC", Offset = "0x3B3BBDC", VA = "0x3B3BBDC")] get
      {
        return (Dictionary<string, object>) null;
      }
      [Token(Token = "0x6019C48"), Address(RVA = "0x3B3BBE4", Offset = "0x3B3BBE4", VA = "0x3B3BBE4")] set
      {
      }
    }

    [Token(Token = "0x6019C49")]
    [Address(RVA = "0x3B3BBEC", Offset = "0x3B3BBEC", VA = "0x3B3BBEC")]
    public AdjustSessionSuccess()
    {
    }

    [Token(Token = "0x6019C4A")]
    [Address(RVA = "0x3B3BBF4", Offset = "0x3B3BBF4", VA = "0x3B3BBF4")]
    public AdjustSessionSuccess(Dictionary<string, string> sessionSuccessDataMap)
    {
    }

    [Token(Token = "0x6019C4B")]
    [Address(RVA = "0x3B3BD90", Offset = "0x3B3BD90", VA = "0x3B3BD90")]
    public AdjustSessionSuccess(string jsonString)
    {
    }

    [Token(Token = "0x6019C4C")]
    [Address(RVA = "0x3B3BF4C", Offset = "0x3B3BF4C", VA = "0x3B3BF4C")]
    public void BuildJsonResponseFromString(string jsonResponseString)
    {
    }

    [Token(Token = "0x6019C4D")]
    [Address(RVA = "0x3B3C040", Offset = "0x3B3C040", VA = "0x3B3C040")]
    public string GetJsonResponse() => (string) null;
  }
}
