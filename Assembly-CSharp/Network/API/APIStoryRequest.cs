// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E23")]
  [Serializable]
  public class APIStoryRequest
  {
    [Token(Token = "0x400810F")]
    [FieldOffset(Offset = "0x10")]
    public int chapter_id;

    [Token(Token = "0x600B266")]
    [Address(RVA = "0x22DFD54", Offset = "0x22DFD54", VA = "0x22DFD54")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B267")]
    [Address(RVA = "0x22DFD9C", Offset = "0x22DFD9C", VA = "0x22DFD9C")]
    public APIStoryRequest()
    {
    }
  }
}
