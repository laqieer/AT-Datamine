// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardUnlockRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E9F")]
  [Serializable]
  public class APIUnitAbilityboardUnlockRequest
  {
    [Token(Token = "0x4008399")]
    [FieldOffset(Offset = "0x10")]
    public string player_unit_id;
    [Token(Token = "0x400839A")]
    [FieldOffset(Offset = "0x18")]
    public List<int> board_setting_ids;

    [Token(Token = "0x600B5D3")]
    [Address(RVA = "0x22EA7A0", Offset = "0x22EA7A0", VA = "0x22EA7A0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B5D4")]
    [Address(RVA = "0x22EA7E8", Offset = "0x22EA7E8", VA = "0x22EA7E8")]
    public APIUnitAbilityboardUnlockRequest()
    {
    }
  }
}
