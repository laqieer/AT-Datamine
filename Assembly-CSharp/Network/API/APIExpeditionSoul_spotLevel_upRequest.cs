// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionSoul_spotLevel_upRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C2F")]
  [Serializable]
  public class APIExpeditionSoul_spotLevel_upRequest
  {
    [Token(Token = "0x40078B0")]
    [FieldOffset(Offset = "0x10")]
    public int soul_type_id;

    [Token(Token = "0x600A5DF")]
    [Address(RVA = "0x190903C", Offset = "0x190903C", VA = "0x190903C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A5E0")]
    [Address(RVA = "0x1909084", Offset = "0x1909084", VA = "0x1909084")]
    public APIExpeditionSoul_spotLevel_upRequest()
    {
    }
  }
}
