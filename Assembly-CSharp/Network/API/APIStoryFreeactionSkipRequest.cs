// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryFreeactionSkipRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E3F")]
  [Serializable]
  public class APIStoryFreeactionSkipRequest
  {
    [Token(Token = "0x4008197")]
    [FieldOffset(Offset = "0x10")]
    public int chapter_id;

    [Token(Token = "0x600B32A")]
    [Address(RVA = "0x22E23B8", Offset = "0x22E23B8", VA = "0x22E23B8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B32B")]
    [Address(RVA = "0x22E2400", Offset = "0x22E2400", VA = "0x22E2400")]
    public APIStoryFreeactionSkipRequest()
    {
    }
  }
}
