// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerEmblemEditRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D93")]
  [Serializable]
  public class APIPlayerEmblemEditRequest
  {
    [Token(Token = "0x4007E46")]
    [FieldOffset(Offset = "0x10")]
    public int emblem_id;

    [Token(Token = "0x600AE96")]
    [Address(RVA = "0x1A4DAA0", Offset = "0x1A4DAA0", VA = "0x1A4DAA0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AE97")]
    [Address(RVA = "0x1A4DAE8", Offset = "0x1A4DAE8", VA = "0x1A4DAE8")]
    public APIPlayerEmblemEditRequest()
    {
    }
  }
}
