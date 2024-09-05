// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryAreaEventQuestReceiptRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E2B")]
  [Serializable]
  public class APIStoryAreaEventQuestReceiptRequest
  {
    [Token(Token = "0x400813A")]
    [FieldOffset(Offset = "0x10")]
    public int chapter_id;
    [Token(Token = "0x400813B")]
    [FieldOffset(Offset = "0x18")]
    public AdvRequest adv_request;

    [Token(Token = "0x600B2A4")]
    [Address(RVA = "0x22E087C", Offset = "0x22E087C", VA = "0x22E087C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B2A5")]
    [Address(RVA = "0x22E08C4", Offset = "0x22E08C4", VA = "0x22E08C4")]
    public APIStoryAreaEventQuestReceiptRequest()
    {
    }
  }
}
