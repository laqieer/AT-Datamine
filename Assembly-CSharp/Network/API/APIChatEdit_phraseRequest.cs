// Decompiled with JetBrains decompiler
// Type: Network.API.APIChatEdit_phraseRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BC7")]
  [Serializable]
  public class APIChatEdit_phraseRequest
  {
    [Token(Token = "0x400770A")]
    [FieldOffset(Offset = "0x10")]
    public List<ChatPhraseRequestType> requests;

    [Token(Token = "0x600A347")]
    [Address(RVA = "0x46CE390", Offset = "0x46CE390", VA = "0x46CE390")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A348")]
    [Address(RVA = "0x46CE3D8", Offset = "0x46CE3D8", VA = "0x46CE3D8")]
    public APIChatEdit_phraseRequest()
    {
    }
  }
}
