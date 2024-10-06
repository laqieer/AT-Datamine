// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaDetailRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B93")]
  [Serializable]
  public class APIArenaDetailRequest
  {
    [Token(Token = "0x400763E")]
    [FieldOffset(Offset = "0x10")]
    public long arena_id;

    [Token(Token = "0x600A205")]
    [Address(RVA = "0x46C9D94", Offset = "0x46C9D94", VA = "0x46C9D94")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A206")]
    [Address(RVA = "0x46C9DDC", Offset = "0x46C9DDC", VA = "0x46C9DDC")]
    public APIArenaDetailRequest()
    {
    }
  }
}
