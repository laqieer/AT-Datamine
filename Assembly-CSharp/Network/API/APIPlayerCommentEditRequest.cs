// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerCommentEditRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D8B")]
  [Serializable]
  public class APIPlayerCommentEditRequest
  {
    [Token(Token = "0x4007E29")]
    [FieldOffset(Offset = "0x10")]
    public string comment;

    [Token(Token = "0x600AE65")]
    [Address(RVA = "0x1A4CFE0", Offset = "0x1A4CFE0", VA = "0x1A4CFE0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AE66")]
    [Address(RVA = "0x1A4D028", Offset = "0x1A4D028", VA = "0x1A4D028")]
    public APIPlayerCommentEditRequest()
    {
    }
  }
}
