// Decompiled with JetBrains decompiler
// Type: Network.Param.GuildMemberType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A68")]
  [Serializable]
  public class GuildMemberType : IPlayerTitleInfo
  {
    [Token(Token = "0x4007131")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string player_id;
    [Token(Token = "0x4007132")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string player_name;
    [Token(Token = "0x4007133")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int experience;
    [Token(Token = "0x4007134")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int emblem_id;
    [Token(Token = "0x4007135")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int pre_title_id;
    [Token(Token = "0x4007136")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int post_title_id;
    [Token(Token = "0x4007137")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int title_frame_id;
    [Token(Token = "0x4007138")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private int leader_unit_id;
    [Token(Token = "0x4007139")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string last_signed_in_at;
    [Token(Token = "0x400713A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private int role;
    [Token(Token = "0x400713B")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private int contribution_point;
    [Token(Token = "0x400713C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private string comment;
    [Token(Token = "0x400713D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private string joined_at;

    [Token(Token = "0x17001967")]
    public string PlayerId
    {
      [Token(Token = "0x60097CC"), Address(RVA = "0x48EFCC0", Offset = "0x48EFCC0", VA = "0x48EFCC0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60097CD"), Address(RVA = "0x48EFCC8", Offset = "0x48EFCC8", VA = "0x48EFCC8")] set
      {
      }
    }

    [Token(Token = "0x17001968")]
    public string PlayerName
    {
      [Token(Token = "0x60097CE"), Address(RVA = "0x48EFCD0", Offset = "0x48EFCD0", VA = "0x48EFCD0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60097CF"), Address(RVA = "0x48EFCD8", Offset = "0x48EFCD8", VA = "0x48EFCD8")] set
      {
      }
    }

    [Token(Token = "0x17001969")]
    public int Experience
    {
      [Token(Token = "0x60097D0"), Address(RVA = "0x48EFCE0", Offset = "0x48EFCE0", VA = "0x48EFCE0")] get
      {
        return new int();
      }
      [Token(Token = "0x60097D1"), Address(RVA = "0x48EFCE8", Offset = "0x48EFCE8", VA = "0x48EFCE8")] set
      {
      }
    }

    [Token(Token = "0x1700196A")]
    public int EmblemId
    {
      [Token(Token = "0x60097D2"), Address(RVA = "0x48EFCF0", Offset = "0x48EFCF0", VA = "0x48EFCF0")] get
      {
        return new int();
      }
      [Token(Token = "0x60097D3"), Address(RVA = "0x48EFCF8", Offset = "0x48EFCF8", VA = "0x48EFCF8")] set
      {
      }
    }

    [Token(Token = "0x1700196B")]
    public int PreTitleId
    {
      [Token(Token = "0x60097D4"), Address(RVA = "0x48EFD00", Offset = "0x48EFD00", VA = "0x48EFD00", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x60097D5"), Address(RVA = "0x48EFD08", Offset = "0x48EFD08", VA = "0x48EFD08")] set
      {
      }
    }

    [Token(Token = "0x1700196C")]
    public int PostTitleId
    {
      [Token(Token = "0x60097D6"), Address(RVA = "0x48EFD10", Offset = "0x48EFD10", VA = "0x48EFD10", Slot = "5")] get
      {
        return new int();
      }
      [Token(Token = "0x60097D7"), Address(RVA = "0x48EFD18", Offset = "0x48EFD18", VA = "0x48EFD18")] set
      {
      }
    }

    [Token(Token = "0x1700196D")]
    public int TitleFrameId
    {
      [Token(Token = "0x60097D8"), Address(RVA = "0x48EFD20", Offset = "0x48EFD20", VA = "0x48EFD20", Slot = "6")] get
      {
        return new int();
      }
      [Token(Token = "0x60097D9"), Address(RVA = "0x48EFD28", Offset = "0x48EFD28", VA = "0x48EFD28")] set
      {
      }
    }

    [Token(Token = "0x1700196E")]
    public int LeaderUnitId
    {
      [Token(Token = "0x60097DA"), Address(RVA = "0x48EFD30", Offset = "0x48EFD30", VA = "0x48EFD30")] get
      {
        return new int();
      }
      [Token(Token = "0x60097DB"), Address(RVA = "0x48EFD38", Offset = "0x48EFD38", VA = "0x48EFD38")] set
      {
      }
    }

    [Token(Token = "0x1700196F")]
    public string LastSignedInAt
    {
      [Token(Token = "0x60097DC"), Address(RVA = "0x48EFD40", Offset = "0x48EFD40", VA = "0x48EFD40")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60097DD"), Address(RVA = "0x48EFD48", Offset = "0x48EFD48", VA = "0x48EFD48")] set
      {
      }
    }

    [Token(Token = "0x17001970")]
    public int Role
    {
      [Token(Token = "0x60097DE"), Address(RVA = "0x48EFD50", Offset = "0x48EFD50", VA = "0x48EFD50")] get
      {
        return new int();
      }
      [Token(Token = "0x60097DF"), Address(RVA = "0x48EFD58", Offset = "0x48EFD58", VA = "0x48EFD58")] set
      {
      }
    }

    [Token(Token = "0x17001971")]
    public int ContributionPoint
    {
      [Token(Token = "0x60097E0"), Address(RVA = "0x48EFD60", Offset = "0x48EFD60", VA = "0x48EFD60")] get
      {
        return new int();
      }
      [Token(Token = "0x60097E1"), Address(RVA = "0x48EFD68", Offset = "0x48EFD68", VA = "0x48EFD68")] set
      {
      }
    }

    [Token(Token = "0x17001972")]
    public string Comment
    {
      [Token(Token = "0x60097E2"), Address(RVA = "0x48EFD70", Offset = "0x48EFD70", VA = "0x48EFD70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60097E3"), Address(RVA = "0x48EFD78", Offset = "0x48EFD78", VA = "0x48EFD78")] set
      {
      }
    }

    [Token(Token = "0x17001973")]
    public string JoinedAt
    {
      [Token(Token = "0x60097E4"), Address(RVA = "0x48EFD80", Offset = "0x48EFD80", VA = "0x48EFD80")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60097E5"), Address(RVA = "0x48EFD88", Offset = "0x48EFD88", VA = "0x48EFD88")] set
      {
      }
    }

    [Token(Token = "0x17001974")]
    public IPlayerTitleInfo PlayerTitleInfo
    {
      [Token(Token = "0x60097E6"), Address(RVA = "0x48EFD90", Offset = "0x48EFD90", VA = "0x48EFD90")] get
      {
        return (IPlayerTitleInfo) null;
      }
    }

    [Token(Token = "0x60097E7")]
    [Address(RVA = "0x48EFD94", Offset = "0x48EFD94", VA = "0x48EFD94")]
    public GuildMemberType()
    {
    }
  }
}
