// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestReadRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E53")]
  [Serializable]
  public class APIStoryMainquestReadRequest
  {
    [Token(Token = "0x4008218")]
    [FieldOffset(Offset = "0x10")]
    public int chapter_id;
    [Token(Token = "0x4008219")]
    [FieldOffset(Offset = "0x14")]
    public int item_id;

    [Token(Token = "0x600B3C3")]
    [Address(RVA = "0x22E3F8C", Offset = "0x22E3F8C", VA = "0x22E3F8C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B3C4")]
    [Address(RVA = "0x22E3FD4", Offset = "0x22E3FD4", VA = "0x22E3FD4")]
    public APIStoryMainquestReadRequest()
    {
    }
  }
}
