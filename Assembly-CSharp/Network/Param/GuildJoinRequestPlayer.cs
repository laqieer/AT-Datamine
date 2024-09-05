// Decompiled with JetBrains decompiler
// Type: Network.Param.GuildJoinRequestPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A66")]
  [Serializable]
  public class GuildJoinRequestPlayer
  {
    [Token(Token = "0x4007123")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string player_id;
    [Token(Token = "0x4007124")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string guild_id;
    [Token(Token = "0x4007125")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string requested_at;
    [Token(Token = "0x4007126")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string player_name;
    [Token(Token = "0x4007127")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int experience;
    [Token(Token = "0x4007128")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private int symbol_unit_master_id;
    [Token(Token = "0x4007129")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int emblem_id;
    [Token(Token = "0x400712A")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private int pre_title_id;
    [Token(Token = "0x400712B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private int post_title_id;
    [Token(Token = "0x400712C")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private int title_frame_id;
    [Token(Token = "0x400712D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private string last_signed_in_at;

    [Token(Token = "0x17001959")]
    public string PlayerId
    {
      [Token(Token = "0x60097AE"), Address(RVA = "0x48EFBD0", Offset = "0x48EFBD0", VA = "0x48EFBD0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60097AF"), Address(RVA = "0x48EFBD8", Offset = "0x48EFBD8", VA = "0x48EFBD8")] set
      {
      }
    }

    [Token(Token = "0x1700195A")]
    public string GuildId
    {
      [Token(Token = "0x60097B0"), Address(RVA = "0x48EFBE0", Offset = "0x48EFBE0", VA = "0x48EFBE0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60097B1"), Address(RVA = "0x48EFBE8", Offset = "0x48EFBE8", VA = "0x48EFBE8")] set
      {
      }
    }

    [Token(Token = "0x1700195B")]
    public string RequestedAt
    {
      [Token(Token = "0x60097B2"), Address(RVA = "0x48EFBF0", Offset = "0x48EFBF0", VA = "0x48EFBF0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60097B3"), Address(RVA = "0x48EFBF8", Offset = "0x48EFBF8", VA = "0x48EFBF8")] set
      {
      }
    }

    [Token(Token = "0x1700195C")]
    public string PlayerName
    {
      [Token(Token = "0x60097B4"), Address(RVA = "0x48EFC00", Offset = "0x48EFC00", VA = "0x48EFC00")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60097B5"), Address(RVA = "0x48EFC08", Offset = "0x48EFC08", VA = "0x48EFC08")] set
      {
      }
    }

    [Token(Token = "0x1700195D")]
    public int Experience
    {
      [Token(Token = "0x60097B6"), Address(RVA = "0x48EFC10", Offset = "0x48EFC10", VA = "0x48EFC10")] get
      {
        return new int();
      }
      [Token(Token = "0x60097B7"), Address(RVA = "0x48EFC18", Offset = "0x48EFC18", VA = "0x48EFC18")] set
      {
      }
    }

    [Token(Token = "0x1700195E")]
    public int SymbolUnitMasterId
    {
      [Token(Token = "0x60097B8"), Address(RVA = "0x48EFC20", Offset = "0x48EFC20", VA = "0x48EFC20")] get
      {
        return new int();
      }
      [Token(Token = "0x60097B9"), Address(RVA = "0x48EFC28", Offset = "0x48EFC28", VA = "0x48EFC28")] set
      {
      }
    }

    [Token(Token = "0x1700195F")]
    public int EmblemId
    {
      [Token(Token = "0x60097BA"), Address(RVA = "0x48EFC30", Offset = "0x48EFC30", VA = "0x48EFC30")] get
      {
        return new int();
      }
      [Token(Token = "0x60097BB"), Address(RVA = "0x48EFC38", Offset = "0x48EFC38", VA = "0x48EFC38")] set
      {
      }
    }

    [Token(Token = "0x17001960")]
    public int PreTitleId
    {
      [Token(Token = "0x60097BC"), Address(RVA = "0x48EFC40", Offset = "0x48EFC40", VA = "0x48EFC40")] get
      {
        return new int();
      }
      [Token(Token = "0x60097BD"), Address(RVA = "0x48EFC48", Offset = "0x48EFC48", VA = "0x48EFC48")] set
      {
      }
    }

    [Token(Token = "0x17001961")]
    public int PostTitleId
    {
      [Token(Token = "0x60097BE"), Address(RVA = "0x48EFC50", Offset = "0x48EFC50", VA = "0x48EFC50")] get
      {
        return new int();
      }
      [Token(Token = "0x60097BF"), Address(RVA = "0x48EFC58", Offset = "0x48EFC58", VA = "0x48EFC58")] set
      {
      }
    }

    [Token(Token = "0x17001962")]
    public int TitleFrameId
    {
      [Token(Token = "0x60097C0"), Address(RVA = "0x48EFC60", Offset = "0x48EFC60", VA = "0x48EFC60")] get
      {
        return new int();
      }
      [Token(Token = "0x60097C1"), Address(RVA = "0x48EFC68", Offset = "0x48EFC68", VA = "0x48EFC68")] set
      {
      }
    }

    [Token(Token = "0x17001963")]
    public string LastSignedInAt
    {
      [Token(Token = "0x60097C2"), Address(RVA = "0x48EFC70", Offset = "0x48EFC70", VA = "0x48EFC70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60097C3"), Address(RVA = "0x48EFC78", Offset = "0x48EFC78", VA = "0x48EFC78")] set
      {
      }
    }

    [Token(Token = "0x60097C4")]
    [Address(RVA = "0x48EFC80", Offset = "0x48EFC80", VA = "0x48EFC80")]
    public GuildJoinRequestPlayer()
    {
    }
  }
}
