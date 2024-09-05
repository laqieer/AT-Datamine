// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitReincarnationResetRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001ECB")]
  [Serializable]
  public class APIUnitReincarnationResetRequest
  {
    [Token(Token = "0x4008440")]
    [FieldOffset(Offset = "0x10")]
    public string player_unit_id;
    [Token(Token = "0x4008441")]
    [FieldOffset(Offset = "0x18")]
    public int warranty_parameter;
    [Token(Token = "0x4008442")]
    [FieldOffset(Offset = "0x1C")]
    public bool special_reincarnation_flag;

    [Token(Token = "0x600B6E1")]
    [Address(RVA = "0x22EE2C4", Offset = "0x22EE2C4", VA = "0x22EE2C4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B6E2")]
    [Address(RVA = "0x22EE30C", Offset = "0x22EE30C", VA = "0x22EE30C")]
    public APIUnitReincarnationResetRequest()
    {
    }
  }
}
