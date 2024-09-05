// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildBuildRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CA7")]
  [Serializable]
  public class APIGuildBuildRequest
  {
    [Token(Token = "0x4007A83")]
    [FieldOffset(Offset = "0x10")]
    public string guild_name;
    [Token(Token = "0x4007A84")]
    [FieldOffset(Offset = "0x18")]
    public int emblem_id;
    [Token(Token = "0x4007A85")]
    [FieldOffset(Offset = "0x1C")]
    public bool is_recruiting;
    [Token(Token = "0x4007A86")]
    [FieldOffset(Offset = "0x1D")]
    public bool is_auto_approve;
    [Token(Token = "0x4007A87")]
    [FieldOffset(Offset = "0x20")]
    public int join_condition_type_id;
    [Token(Token = "0x4007A88")]
    [FieldOffset(Offset = "0x24")]
    public bool is_auto_kick;
    [Token(Token = "0x4007A89")]
    [FieldOffset(Offset = "0x28")]
    public int policy;
    [Token(Token = "0x4007A8A")]
    [FieldOffset(Offset = "0x30")]
    public string introduction;

    [Token(Token = "0x600A8CC")]
    [Address(RVA = "0x19131EC", Offset = "0x19131EC", VA = "0x19131EC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A8CD")]
    [Address(RVA = "0x1913234", Offset = "0x1913234", VA = "0x1913234")]
    public APIGuildBuildRequest()
    {
    }
  }
}
