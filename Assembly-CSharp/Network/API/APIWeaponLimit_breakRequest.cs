// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponLimit_breakRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EF7")]
  [Serializable]
  public class APIWeaponLimit_breakRequest
  {
    [Token(Token = "0x40084F4")]
    [FieldOffset(Offset = "0x10")]
    public string player_weapon_id;
    [Token(Token = "0x40084F5")]
    [FieldOffset(Offset = "0x18")]
    public int break_limit_count;

    [Token(Token = "0x600B7F6")]
    [Address(RVA = "0x2132964", Offset = "0x2132964", VA = "0x2132964")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B7F7")]
    [Address(RVA = "0x21329AC", Offset = "0x21329AC", VA = "0x21329AC")]
    public APIWeaponLimit_breakRequest()
    {
    }
  }
}
