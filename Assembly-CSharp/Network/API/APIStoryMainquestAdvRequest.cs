// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestAdvRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E43")]
  [Serializable]
  public class APIStoryMainquestAdvRequest
  {
    [Token(Token = "0x40081AB")]
    [FieldOffset(Offset = "0x10")]
    public int chapter_id;
    [Token(Token = "0x40081AC")]
    [FieldOffset(Offset = "0x18")]
    public AdvRequest adv_request;

    [Token(Token = "0x600B348")]
    [Address(RVA = "0x22E2944", Offset = "0x22E2944", VA = "0x22E2944")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B349")]
    [Address(RVA = "0x22E298C", Offset = "0x22E298C", VA = "0x22E298C")]
    public APIStoryMainquestAdvRequest()
    {
    }
  }
}
