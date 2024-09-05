// Decompiled with JetBrains decompiler
// Type: Network.API.APIAgeRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B63")]
  [Serializable]
  public class APIAgeRequest
  {
    [Token(Token = "0x4007563")]
    [FieldOffset(Offset = "0x10")]
    public int birth_year;
    [Token(Token = "0x4007564")]
    [FieldOffset(Offset = "0x14")]
    public int birth_month;
    [Token(Token = "0x4007565")]
    [FieldOffset(Offset = "0x18")]
    public int birth_day;

    [Token(Token = "0x600A0D1")]
    [Address(RVA = "0x46C5CA4", Offset = "0x46C5CA4", VA = "0x46C5CA4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A0D2")]
    [Address(RVA = "0x46C5CEC", Offset = "0x46C5CEC", VA = "0x46C5CEC")]
    public APIAgeRequest()
    {
    }
  }
}
