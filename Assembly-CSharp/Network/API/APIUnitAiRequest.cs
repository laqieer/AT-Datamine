// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAiRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EA3")]
  [Serializable]
  public class APIUnitAiRequest
  {
    [Token(Token = "0x40083AE")]
    [FieldOffset(Offset = "0x10")]
    public string player_unit_id;
    [Token(Token = "0x40083AF")]
    [FieldOffset(Offset = "0x18")]
    public int ai_type;

    [Token(Token = "0x600B5F1")]
    [Address(RVA = "0x22EAD2C", Offset = "0x22EAD2C", VA = "0x22EAD2C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B5F2")]
    [Address(RVA = "0x22EAD74", Offset = "0x22EAD74", VA = "0x22EAD74")]
    public APIUnitAiRequest()
    {
    }
  }
}
