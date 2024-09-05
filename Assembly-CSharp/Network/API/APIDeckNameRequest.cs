// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeckNameRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C03")]
  [Serializable]
  public class APIDeckNameRequest
  {
    [Token(Token = "0x40077EB")]
    [FieldOffset(Offset = "0x10")]
    public int deck_type_id;
    [Token(Token = "0x40077EC")]
    [FieldOffset(Offset = "0x14")]
    public int deck_number;
    [Token(Token = "0x40077ED")]
    [FieldOffset(Offset = "0x18")]
    public string name;

    [Token(Token = "0x600A4B2")]
    [Address(RVA = "0x46D340C", Offset = "0x46D340C", VA = "0x46D340C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A4B3")]
    [Address(RVA = "0x46D3454", Offset = "0x46D3454", VA = "0x46D3454")]
    public APIDeckNameRequest()
    {
    }
  }
}
