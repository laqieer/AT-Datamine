// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerDetailRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D8F")]
  [Serializable]
  public class APIPlayerDetailRequest
  {
    [Token(Token = "0x4007E36")]
    [FieldOffset(Offset = "0x10")]
    public string target_player_id;

    [Token(Token = "0x600AE7C")]
    [Address(RVA = "0x1A4D534", Offset = "0x1A4D534", VA = "0x1A4D534")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AE7D")]
    [Address(RVA = "0x1A4D57C", Offset = "0x1A4D57C", VA = "0x1A4D57C")]
    public APIPlayerDetailRequest()
    {
    }
  }
}
