// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryFreeactionBreakableCrushRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E37")]
  [Serializable]
  public class APIStoryFreeactionBreakableCrushRequest
  {
    [Token(Token = "0x4008175")]
    [FieldOffset(Offset = "0x10")]
    public int chapter_id;
    [Token(Token = "0x4008176")]
    [FieldOffset(Offset = "0x14")]
    public int breakable_object_id;

    [Token(Token = "0x600B2F6")]
    [Address(RVA = "0x22E18E0", Offset = "0x22E18E0", VA = "0x22E18E0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B2F7")]
    [Address(RVA = "0x22E1928", Offset = "0x22E1928", VA = "0x22E1928")]
    public APIStoryFreeactionBreakableCrushRequest()
    {
    }
  }
}
