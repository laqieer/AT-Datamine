// Decompiled with JetBrains decompiler
// Type: KPI.StandardKPI.StandardKPIHeaderParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace KPI.StandardKPI
{
  [Token(Token = "0x2000A6E")]
  [Serializable]
  public class StandardKPIHeaderParam
  {
    [Token(Token = "0x4003059")]
    [FieldOffset(Offset = "0x10")]
    public string game_id;
    [Token(Token = "0x400305A")]
    [FieldOffset(Offset = "0x18")]
    public string game_env;
    [Token(Token = "0x400305B")]
    [FieldOffset(Offset = "0x20")]
    public string player_id;
    [Token(Token = "0x400305C")]
    [FieldOffset(Offset = "0x28")]
    public string device_id;
    [Token(Token = "0x400305D")]
    [FieldOffset(Offset = "0x30")]
    public string world_id;
    [Token(Token = "0x400305E")]
    [FieldOffset(Offset = "0x38")]
    public string avatar_id;
    [Token(Token = "0x400305F")]
    [FieldOffset(Offset = "0x40")]
    public string store_platform;
    [Token(Token = "0x4003060")]
    [FieldOffset(Offset = "0x48")]
    public string device_os;

    [Token(Token = "0x6003B42")]
    [Address(RVA = "0x331C7FC", Offset = "0x331C7FC", VA = "0x331C7FC")]
    public StandardKPIHeaderParam()
    {
    }
  }
}
