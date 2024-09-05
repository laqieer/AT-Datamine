// Decompiled with JetBrains decompiler
// Type: Network.API.APIConfirmExpirationRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BE3")]
  [Serializable]
  public class APIConfirmExpirationRequest
  {
    [Token(Token = "0x400776C")]
    [FieldOffset(Offset = "0x10")]
    public List<string> present_ids;
    [Token(Token = "0x400776D")]
    [FieldOffset(Offset = "0x18")]
    public bool limited_present_flag;
    [Token(Token = "0x400776E")]
    [FieldOffset(Offset = "0x1C")]
    public int page_number;

    [Token(Token = "0x600A3EB")]
    [Address(RVA = "0x46D08F4", Offset = "0x46D08F4", VA = "0x46D08F4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A3EC")]
    [Address(RVA = "0x46D093C", Offset = "0x46D093C", VA = "0x46D093C")]
    public APIConfirmExpirationRequest()
    {
    }
  }
}
