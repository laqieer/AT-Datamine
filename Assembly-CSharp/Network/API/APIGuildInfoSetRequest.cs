// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildInfoSetRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CDF")]
  [Serializable]
  public class APIGuildInfoSetRequest
  {
    [Token(Token = "0x4007B65")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;
    [Token(Token = "0x4007B66")]
    [FieldOffset(Offset = "0x18")]
    public string guild_name;
    [Token(Token = "0x4007B67")]
    [FieldOffset(Offset = "0x20")]
    public int emblem_id;
    [Token(Token = "0x4007B68")]
    [FieldOffset(Offset = "0x24")]
    public int pre_title_id;
    [Token(Token = "0x4007B69")]
    [FieldOffset(Offset = "0x28")]
    public int post_title_id;
    [Token(Token = "0x4007B6A")]
    [FieldOffset(Offset = "0x2C")]
    public int title_frame_id;
    [Token(Token = "0x4007B6B")]
    [FieldOffset(Offset = "0x30")]
    public bool is_recruiting;
    [Token(Token = "0x4007B6C")]
    [FieldOffset(Offset = "0x31")]
    public bool is_auto_approve;
    [Token(Token = "0x4007B6D")]
    [FieldOffset(Offset = "0x34")]
    public int join_condition_type_id;
    [Token(Token = "0x4007B6E")]
    [FieldOffset(Offset = "0x38")]
    public bool is_auto_kick;
    [Token(Token = "0x4007B6F")]
    [FieldOffset(Offset = "0x3C")]
    public int policy;
    [Token(Token = "0x4007B70")]
    [FieldOffset(Offset = "0x40")]
    public string introduction;

    [Token(Token = "0x600AA2A")]
    [Address(RVA = "0x1917D54", Offset = "0x1917D54", VA = "0x1917D54")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AA2B")]
    [Address(RVA = "0x1917D9C", Offset = "0x1917D9C", VA = "0x1917D9C")]
    public APIGuildInfoSetRequest()
    {
    }
  }
}
