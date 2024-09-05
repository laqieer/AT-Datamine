// Decompiled with JetBrains decompiler
// Type: Network.API.APIStorySubquestReceiptRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E7F")]
  [Serializable]
  public class APIStorySubquestReceiptRequest
  {
    [Token(Token = "0x4008312")]
    [FieldOffset(Offset = "0x10")]
    public int subquest_id;

    [Token(Token = "0x600B501")]
    [Address(RVA = "0x22E7C30", Offset = "0x22E7C30", VA = "0x22E7C30")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B502")]
    [Address(RVA = "0x22E7C78", Offset = "0x22E7C78", VA = "0x22E7C78")]
    public APIStorySubquestReceiptRequest()
    {
    }
  }
}
