// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0000PayRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C73")]
  [Serializable]
  public class APIG0000PayRequest
  {
    [Token(Token = "0x40079C5")]
    [FieldOffset(Offset = "0x10")]
    public int gacha_id;
    [Token(Token = "0x40079C6")]
    [FieldOffset(Offset = "0x14")]
    public int execute_count;

    [Token(Token = "0x600A78E")]
    [Address(RVA = "0x190EC10", Offset = "0x190EC10", VA = "0x190EC10")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A78F")]
    [Address(RVA = "0x190EC58", Offset = "0x190EC58", VA = "0x190EC58")]
    public APIG0000PayRequest()
    {
    }
  }
}
