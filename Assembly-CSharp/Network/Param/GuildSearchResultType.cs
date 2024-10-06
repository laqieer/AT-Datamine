// Decompiled with JetBrains decompiler
// Type: Network.Param.GuildSearchResultType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A6C")]
  [Serializable]
  public class GuildSearchResultType
  {
    [Token(Token = "0x400714C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string guild_id;
    [Token(Token = "0x400714D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string guild_name;
    [Token(Token = "0x400714E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int guild_experience;
    [Token(Token = "0x400714F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int pre_title_id;
    [Token(Token = "0x4007150")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int post_title_id;
    [Token(Token = "0x4007151")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int title_frame_id;
    [Token(Token = "0x4007152")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int emblem_id;
    [Token(Token = "0x4007153")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private bool is_recruiting;
    [Token(Token = "0x4007154")]
    [FieldOffset(Offset = "0x35")]
    [SerializeField]
    private bool is_auto_approve;
    [Token(Token = "0x4007155")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int join_condition_type_id;
    [Token(Token = "0x4007156")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private bool is_auto_kick;
    [Token(Token = "0x4007157")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private int policy;
    [Token(Token = "0x4007158")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private string introduction;
    [Token(Token = "0x4007159")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private string master_player_name;
    [Token(Token = "0x400715A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private int master_emblem_id;
    [Token(Token = "0x400715B")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private int member_count;
    [Token(Token = "0x400715C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private int max_member_count;

    [Token(Token = "0x17001983")]
    public string GuildId
    {
      [Token(Token = "0x6009807"), Address(RVA = "0x48EFE94", Offset = "0x48EFE94", VA = "0x48EFE94")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009808"), Address(RVA = "0x48EFE9C", Offset = "0x48EFE9C", VA = "0x48EFE9C")] set
      {
      }
    }

    [Token(Token = "0x17001984")]
    public string GuildName
    {
      [Token(Token = "0x6009809"), Address(RVA = "0x48EFEA4", Offset = "0x48EFEA4", VA = "0x48EFEA4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600980A"), Address(RVA = "0x48EFEAC", Offset = "0x48EFEAC", VA = "0x48EFEAC")] set
      {
      }
    }

    [Token(Token = "0x17001985")]
    public int GuildExperience
    {
      [Token(Token = "0x600980B"), Address(RVA = "0x48EFEB4", Offset = "0x48EFEB4", VA = "0x48EFEB4")] get
      {
        return new int();
      }
      [Token(Token = "0x600980C"), Address(RVA = "0x48EFEBC", Offset = "0x48EFEBC", VA = "0x48EFEBC")] set
      {
      }
    }

    [Token(Token = "0x17001986")]
    public int PreTitleId
    {
      [Token(Token = "0x600980D"), Address(RVA = "0x48EFEC4", Offset = "0x48EFEC4", VA = "0x48EFEC4")] get
      {
        return new int();
      }
      [Token(Token = "0x600980E"), Address(RVA = "0x48EFECC", Offset = "0x48EFECC", VA = "0x48EFECC")] set
      {
      }
    }

    [Token(Token = "0x17001987")]
    public int PostTitleId
    {
      [Token(Token = "0x600980F"), Address(RVA = "0x48EFED4", Offset = "0x48EFED4", VA = "0x48EFED4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009810"), Address(RVA = "0x48EFEDC", Offset = "0x48EFEDC", VA = "0x48EFEDC")] set
      {
      }
    }

    [Token(Token = "0x17001988")]
    public int TitleFrameId
    {
      [Token(Token = "0x6009811"), Address(RVA = "0x48EFEE4", Offset = "0x48EFEE4", VA = "0x48EFEE4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009812"), Address(RVA = "0x48EFEEC", Offset = "0x48EFEEC", VA = "0x48EFEEC")] set
      {
      }
    }

    [Token(Token = "0x17001989")]
    public int EmblemId
    {
      [Token(Token = "0x6009813"), Address(RVA = "0x48EFEF4", Offset = "0x48EFEF4", VA = "0x48EFEF4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009814"), Address(RVA = "0x48EFEFC", Offset = "0x48EFEFC", VA = "0x48EFEFC")] set
      {
      }
    }

    [Token(Token = "0x1700198A")]
    public bool IsRecruiting
    {
      [Token(Token = "0x6009815"), Address(RVA = "0x48EFF04", Offset = "0x48EFF04", VA = "0x48EFF04")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009816"), Address(RVA = "0x48EFF0C", Offset = "0x48EFF0C", VA = "0x48EFF0C")] set
      {
      }
    }

    [Token(Token = "0x1700198B")]
    public bool IsAutoApprove
    {
      [Token(Token = "0x6009817"), Address(RVA = "0x48EFF18", Offset = "0x48EFF18", VA = "0x48EFF18")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009818"), Address(RVA = "0x48EFF20", Offset = "0x48EFF20", VA = "0x48EFF20")] set
      {
      }
    }

    [Token(Token = "0x1700198C")]
    public int JoinConditionTypeId
    {
      [Token(Token = "0x6009819"), Address(RVA = "0x48EFF2C", Offset = "0x48EFF2C", VA = "0x48EFF2C")] get
      {
        return new int();
      }
      [Token(Token = "0x600981A"), Address(RVA = "0x48EFF34", Offset = "0x48EFF34", VA = "0x48EFF34")] set
      {
      }
    }

    [Token(Token = "0x1700198D")]
    public bool IsAutoKick
    {
      [Token(Token = "0x600981B"), Address(RVA = "0x48EFF3C", Offset = "0x48EFF3C", VA = "0x48EFF3C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600981C"), Address(RVA = "0x48EFF44", Offset = "0x48EFF44", VA = "0x48EFF44")] set
      {
      }
    }

    [Token(Token = "0x1700198E")]
    public int Policy
    {
      [Token(Token = "0x600981D"), Address(RVA = "0x48EFF50", Offset = "0x48EFF50", VA = "0x48EFF50")] get
      {
        return new int();
      }
      [Token(Token = "0x600981E"), Address(RVA = "0x48EFF58", Offset = "0x48EFF58", VA = "0x48EFF58")] set
      {
      }
    }

    [Token(Token = "0x1700198F")]
    public string Introduction
    {
      [Token(Token = "0x600981F"), Address(RVA = "0x48EFF60", Offset = "0x48EFF60", VA = "0x48EFF60")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009820"), Address(RVA = "0x48EFF68", Offset = "0x48EFF68", VA = "0x48EFF68")] set
      {
      }
    }

    [Token(Token = "0x17001990")]
    public string MasterPlayerName
    {
      [Token(Token = "0x6009821"), Address(RVA = "0x48EFF70", Offset = "0x48EFF70", VA = "0x48EFF70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009822"), Address(RVA = "0x48EFF78", Offset = "0x48EFF78", VA = "0x48EFF78")] set
      {
      }
    }

    [Token(Token = "0x17001991")]
    public int MasterEmblemId
    {
      [Token(Token = "0x6009823"), Address(RVA = "0x48EFF80", Offset = "0x48EFF80", VA = "0x48EFF80")] get
      {
        return new int();
      }
      [Token(Token = "0x6009824"), Address(RVA = "0x48EFF88", Offset = "0x48EFF88", VA = "0x48EFF88")] set
      {
      }
    }

    [Token(Token = "0x17001992")]
    public int MemberCount
    {
      [Token(Token = "0x6009825"), Address(RVA = "0x48EFF90", Offset = "0x48EFF90", VA = "0x48EFF90")] get
      {
        return new int();
      }
      [Token(Token = "0x6009826"), Address(RVA = "0x48EFF98", Offset = "0x48EFF98", VA = "0x48EFF98")] set
      {
      }
    }

    [Token(Token = "0x17001993")]
    public int MaxMemberCount
    {
      [Token(Token = "0x6009827"), Address(RVA = "0x48EFFA0", Offset = "0x48EFFA0", VA = "0x48EFFA0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009828"), Address(RVA = "0x48EFFA8", Offset = "0x48EFFA8", VA = "0x48EFFA8")] set
      {
      }
    }

    [Token(Token = "0x6009829")]
    [Address(RVA = "0x48EFFB0", Offset = "0x48EFFB0", VA = "0x48EFFB0")]
    public GuildSearchResultType()
    {
    }
  }
}
