// Decompiled with JetBrains decompiler
// Type: Network.API.APIMind_equipmentLimit_breakRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D5F")]
  [Serializable]
  public class APIMind_equipmentLimit_breakRequest
  {
    [Token(Token = "0x4007D77")]
    [FieldOffset(Offset = "0x10")]
    public string player_mind_equipment_id;
    [Token(Token = "0x4007D78")]
    [FieldOffset(Offset = "0x18")]
    public int break_limit_count;

    [Token(Token = "0x600AD48")]
    [Address(RVA = "0x1A49454", Offset = "0x1A49454", VA = "0x1A49454")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AD49")]
    [Address(RVA = "0x1A4949C", Offset = "0x1A4949C", VA = "0x1A4949C")]
    public APIMind_equipmentLimit_breakRequest()
    {
    }
  }
}
