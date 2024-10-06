// Decompiled with JetBrains decompiler
// Type: Network.Param.GuildRaidScoreType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A6B")]
  [Serializable]
  public class GuildRaidScoreType
  {
    [Token(Token = "0x4007149")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int rank;
    [Token(Token = "0x400714A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string player_id;
    [Token(Token = "0x400714B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private long score;

    [Token(Token = "0x17001980")]
    public int Rank
    {
      [Token(Token = "0x6009800"), Address(RVA = "0x48EFE5C", Offset = "0x48EFE5C", VA = "0x48EFE5C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009801"), Address(RVA = "0x48EFE64", Offset = "0x48EFE64", VA = "0x48EFE64")] set
      {
      }
    }

    [Token(Token = "0x17001981")]
    public string PlayerId
    {
      [Token(Token = "0x6009802"), Address(RVA = "0x48EFE6C", Offset = "0x48EFE6C", VA = "0x48EFE6C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009803"), Address(RVA = "0x48EFE74", Offset = "0x48EFE74", VA = "0x48EFE74")] set
      {
      }
    }

    [Token(Token = "0x17001982")]
    public long Score
    {
      [Token(Token = "0x6009804"), Address(RVA = "0x48EFE7C", Offset = "0x48EFE7C", VA = "0x48EFE7C")] get
      {
        return new long();
      }
      [Token(Token = "0x6009805"), Address(RVA = "0x48EFE84", Offset = "0x48EFE84", VA = "0x48EFE84")] set
      {
      }
    }

    [Token(Token = "0x6009806")]
    [Address(RVA = "0x48EFE8C", Offset = "0x48EFE8C", VA = "0x48EFE8C")]
    public GuildRaidScoreType()
    {
    }
  }
}
