// Decompiled with JetBrains decompiler
// Type: Network.API.APIPresentReceiveRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DC7")]
  [Serializable]
  public class APIPresentReceiveRequest
  {
    [Token(Token = "0x4007F37")]
    [FieldOffset(Offset = "0x10")]
    public List<string> present_ids;
    [Token(Token = "0x4007F38")]
    [FieldOffset(Offset = "0x18")]
    public bool limited_present_flag;
    [Token(Token = "0x4007F39")]
    [FieldOffset(Offset = "0x1C")]
    public int page_number;

    [Token(Token = "0x600B005")]
    [Address(RVA = "0x1A521F4", Offset = "0x1A521F4", VA = "0x1A521F4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B006")]
    [Address(RVA = "0x1A5223C", Offset = "0x1A5223C", VA = "0x1A5223C")]
    public APIPresentReceiveRequest()
    {
    }
  }
}
