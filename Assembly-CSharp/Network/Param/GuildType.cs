// Decompiled with JetBrains decompiler
// Type: Network.Param.GuildType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A6E")]
  [Serializable]
  public class GuildType
  {
    [Token(Token = "0x400715F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string guild_id;
    [Token(Token = "0x4007160")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string guild_name;
    [Token(Token = "0x4007161")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int guild_experience;
    [Token(Token = "0x4007162")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int pre_title_id;
    [Token(Token = "0x4007163")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int post_title_id;
    [Token(Token = "0x4007164")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int title_frame_id;
    [Token(Token = "0x4007165")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int emblem_id;
    [Token(Token = "0x4007166")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private bool is_recruiting;
    [Token(Token = "0x4007167")]
    [FieldOffset(Offset = "0x35")]
    [SerializeField]
    private bool is_auto_approve;
    [Token(Token = "0x4007168")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int join_condition_type_id;
    [Token(Token = "0x4007169")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private bool is_auto_kick;
    [Token(Token = "0x400716A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private int policy;
    [Token(Token = "0x400716B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private string introduction;
    [Token(Token = "0x400716C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private string bulletin_board_id;
    [Token(Token = "0x400716D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private string bulletin_board;

    [Token(Token = "0x17001996")]
    public string GuildId
    {
      [Token(Token = "0x600982F"), Address(RVA = "0x48EFFE0", Offset = "0x48EFFE0", VA = "0x48EFFE0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009830"), Address(RVA = "0x48EFFE8", Offset = "0x48EFFE8", VA = "0x48EFFE8")] set
      {
      }
    }

    [Token(Token = "0x17001997")]
    public string GuildName
    {
      [Token(Token = "0x6009831"), Address(RVA = "0x48EFFF0", Offset = "0x48EFFF0", VA = "0x48EFFF0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009832"), Address(RVA = "0x48EFFF8", Offset = "0x48EFFF8", VA = "0x48EFFF8")] set
      {
      }
    }

    [Token(Token = "0x17001998")]
    public int GuildExperience
    {
      [Token(Token = "0x6009833"), Address(RVA = "0x48F0000", Offset = "0x48F0000", VA = "0x48F0000")] get
      {
        return new int();
      }
      [Token(Token = "0x6009834"), Address(RVA = "0x48F0008", Offset = "0x48F0008", VA = "0x48F0008")] set
      {
      }
    }

    [Token(Token = "0x17001999")]
    public int PreTitleId
    {
      [Token(Token = "0x6009835"), Address(RVA = "0x48F0010", Offset = "0x48F0010", VA = "0x48F0010")] get
      {
        return new int();
      }
      [Token(Token = "0x6009836"), Address(RVA = "0x48F0018", Offset = "0x48F0018", VA = "0x48F0018")] set
      {
      }
    }

    [Token(Token = "0x1700199A")]
    public int PostTitleId
    {
      [Token(Token = "0x6009837"), Address(RVA = "0x48F0020", Offset = "0x48F0020", VA = "0x48F0020")] get
      {
        return new int();
      }
      [Token(Token = "0x6009838"), Address(RVA = "0x48F0028", Offset = "0x48F0028", VA = "0x48F0028")] set
      {
      }
    }

    [Token(Token = "0x1700199B")]
    public int TitleFrameId
    {
      [Token(Token = "0x6009839"), Address(RVA = "0x48F0030", Offset = "0x48F0030", VA = "0x48F0030")] get
      {
        return new int();
      }
      [Token(Token = "0x600983A"), Address(RVA = "0x48F0038", Offset = "0x48F0038", VA = "0x48F0038")] set
      {
      }
    }

    [Token(Token = "0x1700199C")]
    public int EmblemId
    {
      [Token(Token = "0x600983B"), Address(RVA = "0x48F0040", Offset = "0x48F0040", VA = "0x48F0040")] get
      {
        return new int();
      }
      [Token(Token = "0x600983C"), Address(RVA = "0x48F0048", Offset = "0x48F0048", VA = "0x48F0048")] set
      {
      }
    }

    [Token(Token = "0x1700199D")]
    public bool IsRecruiting
    {
      [Token(Token = "0x600983D"), Address(RVA = "0x48F0050", Offset = "0x48F0050", VA = "0x48F0050")] get
      {
        return new bool();
      }
      [Token(Token = "0x600983E"), Address(RVA = "0x48F0058", Offset = "0x48F0058", VA = "0x48F0058")] set
      {
      }
    }

    [Token(Token = "0x1700199E")]
    public bool IsAutoApprove
    {
      [Token(Token = "0x600983F"), Address(RVA = "0x48F0064", Offset = "0x48F0064", VA = "0x48F0064")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009840"), Address(RVA = "0x48F006C", Offset = "0x48F006C", VA = "0x48F006C")] set
      {
      }
    }

    [Token(Token = "0x1700199F")]
    public int JoinConditionTypeId
    {
      [Token(Token = "0x6009841"), Address(RVA = "0x48F0078", Offset = "0x48F0078", VA = "0x48F0078")] get
      {
        return new int();
      }
      [Token(Token = "0x6009842"), Address(RVA = "0x48F0080", Offset = "0x48F0080", VA = "0x48F0080")] set
      {
      }
    }

    [Token(Token = "0x170019A0")]
    public bool IsAutoKick
    {
      [Token(Token = "0x6009843"), Address(RVA = "0x48F0088", Offset = "0x48F0088", VA = "0x48F0088")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009844"), Address(RVA = "0x48F0090", Offset = "0x48F0090", VA = "0x48F0090")] set
      {
      }
    }

    [Token(Token = "0x170019A1")]
    public int Policy
    {
      [Token(Token = "0x6009845"), Address(RVA = "0x48F009C", Offset = "0x48F009C", VA = "0x48F009C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009846"), Address(RVA = "0x48F00A4", Offset = "0x48F00A4", VA = "0x48F00A4")] set
      {
      }
    }

    [Token(Token = "0x170019A2")]
    public string Introduction
    {
      [Token(Token = "0x6009847"), Address(RVA = "0x48F00AC", Offset = "0x48F00AC", VA = "0x48F00AC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009848"), Address(RVA = "0x48F00B4", Offset = "0x48F00B4", VA = "0x48F00B4")] set
      {
      }
    }

    [Token(Token = "0x170019A3")]
    public string BulletinBoardId
    {
      [Token(Token = "0x6009849"), Address(RVA = "0x48F00BC", Offset = "0x48F00BC", VA = "0x48F00BC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600984A"), Address(RVA = "0x48F00C4", Offset = "0x48F00C4", VA = "0x48F00C4")] set
      {
      }
    }

    [Token(Token = "0x170019A4")]
    public string BulletinBoard
    {
      [Token(Token = "0x600984B"), Address(RVA = "0x48F00CC", Offset = "0x48F00CC", VA = "0x48F00CC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600984C"), Address(RVA = "0x48F00D4", Offset = "0x48F00D4", VA = "0x48F00D4")] set
      {
      }
    }

    [Token(Token = "0x600984D")]
    [Address(RVA = "0x48F00DC", Offset = "0x48F00DC", VA = "0x48F00DC")]
    public GuildType()
    {
    }
  }
}
