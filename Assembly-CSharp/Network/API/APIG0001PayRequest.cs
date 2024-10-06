// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0001PayRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C83")]
  [Serializable]
  public class APIG0001PayRequest
  {
    [Token(Token = "0x40079FE")]
    [FieldOffset(Offset = "0x10")]
    public int gacha_id;
    [Token(Token = "0x40079FF")]
    [FieldOffset(Offset = "0x14")]
    public int execute_count;

    [Token(Token = "0x600A7EF")]
    [Address(RVA = "0x1910188", Offset = "0x1910188", VA = "0x1910188")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A7F0")]
    [Address(RVA = "0x19101D0", Offset = "0x19101D0", VA = "0x19101D0")]
    public APIG0001PayRequest()
    {
    }
  }
}
