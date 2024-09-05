// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryFreeactionChestOpenRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E3B")]
  [Serializable]
  public class APIStoryFreeactionChestOpenRequest
  {
    [Token(Token = "0x4008186")]
    [FieldOffset(Offset = "0x10")]
    public int chapter_id;
    [Token(Token = "0x4008187")]
    [FieldOffset(Offset = "0x14")]
    public int chest_id;

    [Token(Token = "0x600B310")]
    [Address(RVA = "0x22E1E4C", Offset = "0x22E1E4C", VA = "0x22E1E4C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B311")]
    [Address(RVA = "0x22E1E94", Offset = "0x22E1E94", VA = "0x22E1E94")]
    public APIStoryFreeactionChestOpenRequest()
    {
    }
  }
}
