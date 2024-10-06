// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildSearchRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D1F")]
  [Serializable]
  public class APIGuildSearchRequest
  {
    [Token(Token = "0x4007C65")]
    [FieldOffset(Offset = "0x10")]
    public string guild_name;
    [Token(Token = "0x4007C66")]
    [FieldOffset(Offset = "0x18")]
    public bool enable_recruiting;
    [Token(Token = "0x4007C67")]
    [FieldOffset(Offset = "0x19")]
    public bool is_recruiting;
    [Token(Token = "0x4007C68")]
    [FieldOffset(Offset = "0x1A")]
    public bool enable_auto_approve;
    [Token(Token = "0x4007C69")]
    [FieldOffset(Offset = "0x1B")]
    public bool is_auto_approve;
    [Token(Token = "0x4007C6A")]
    [FieldOffset(Offset = "0x1C")]
    public bool enable_join_condition_type_id;
    [Token(Token = "0x4007C6B")]
    [FieldOffset(Offset = "0x20")]
    public int join_condition_type_id;
    [Token(Token = "0x4007C6C")]
    [FieldOffset(Offset = "0x24")]
    public bool enable_auto_kick;
    [Token(Token = "0x4007C6D")]
    [FieldOffset(Offset = "0x25")]
    public bool is_auto_kick;
    [Token(Token = "0x4007C6E")]
    [FieldOffset(Offset = "0x26")]
    public bool enable_policy;
    [Token(Token = "0x4007C6F")]
    [FieldOffset(Offset = "0x28")]
    public int policy;

    [Token(Token = "0x600ABAF")]
    [Address(RVA = "0x1A43DEC", Offset = "0x1A43DEC", VA = "0x1A43DEC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600ABB0")]
    [Address(RVA = "0x1A43E34", Offset = "0x1A43E34", VA = "0x1A43E34")]
    public APIGuildSearchRequest()
    {
    }
  }
}
