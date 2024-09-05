// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerSignupRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DAF")]
  [Serializable]
  public class APIPlayerSignupRequest
  {
    [Token(Token = "0x4007EDD")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4007EDE")]
    [FieldOffset(Offset = "0x18")]
    public int avatar_id;
    [Token(Token = "0x4007EDF")]
    [FieldOffset(Offset = "0x1C")]
    public int language_type;
    [Token(Token = "0x4007EE0")]
    [FieldOffset(Offset = "0x20")]
    public bool is_recreate;
    [Token(Token = "0x4007EE1")]
    [FieldOffset(Offset = "0x28")]
    public string ex_player_id;

    [Token(Token = "0x600AF76")]
    [Address(RVA = "0x1A501E4", Offset = "0x1A501E4", VA = "0x1A501E4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AF77")]
    [Address(RVA = "0x1A5022C", Offset = "0x1A5022C", VA = "0x1A5022C")]
    public APIPlayerSignupRequest()
    {
    }
  }
}
