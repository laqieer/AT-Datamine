// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaResultDefenseRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B97")]
  [Serializable]
  public class APIArenaResultDefenseRequest
  {
    [Token(Token = "0x4007654")]
    [FieldOffset(Offset = "0x10")]
    public long arena_id;

    [Token(Token = "0x600A225")]
    [Address(RVA = "0x46CA330", Offset = "0x46CA330", VA = "0x46CA330")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A226")]
    [Address(RVA = "0x46CA378", Offset = "0x46CA378", VA = "0x46CA378")]
    public APIArenaResultDefenseRequest()
    {
    }
  }
}
