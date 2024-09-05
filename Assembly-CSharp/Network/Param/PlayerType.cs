// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AED")]
  [Serializable]
  public class PlayerType
  {
    [Token(Token = "0x4007372")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int common_coin;
    [Token(Token = "0x4007373")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int free_coin;
    [Token(Token = "0x4007374")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int paid_coin;
    [Token(Token = "0x4007375")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int last_modified_ap;
    [Token(Token = "0x4007376")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string ap_modified_at;
    [Token(Token = "0x4007377")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int ap_day_recovery_item_count;
    [Token(Token = "0x4007378")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int ap_day_recovery_coin_count;
    [Token(Token = "0x4007379")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string id;
    [Token(Token = "0x400737A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private long short_id;
    [Token(Token = "0x400737B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string name;
    [Token(Token = "0x400737C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private string comment;
    [Token(Token = "0x400737D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private string created_at;
    [Token(Token = "0x400737E")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private string updated_at;
    [Token(Token = "0x400737F")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private bool is_introduction_finished;
    [Token(Token = "0x4007380")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private int experience;
    [Token(Token = "0x4007381")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private int avatar_id;
    [Token(Token = "0x4007382")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private int symbol_unit_master_id;
    [Token(Token = "0x4007383")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private int emblem_id;
    [Token(Token = "0x4007384")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private int pre_title_id;
    [Token(Token = "0x4007385")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private int post_title_id;
    [Token(Token = "0x4007386")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private int title_frame_id;
    [Token(Token = "0x4007387")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private long total_battle_power;
    [Token(Token = "0x4007388")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private string last_signed_in_at;

    [Token(Token = "0x17001BD4")]
    public int CommonCoin
    {
      [Token(Token = "0x6009D00"), Address(RVA = "0x48F28A8", Offset = "0x48F28A8", VA = "0x48F28A8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D01"), Address(RVA = "0x48F28B0", Offset = "0x48F28B0", VA = "0x48F28B0")] set
      {
      }
    }

    [Token(Token = "0x17001BD5")]
    public int FreeCoin
    {
      [Token(Token = "0x6009D02"), Address(RVA = "0x48F28B8", Offset = "0x48F28B8", VA = "0x48F28B8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D03"), Address(RVA = "0x48F28C0", Offset = "0x48F28C0", VA = "0x48F28C0")] set
      {
      }
    }

    [Token(Token = "0x17001BD6")]
    public int PaidCoin
    {
      [Token(Token = "0x6009D04"), Address(RVA = "0x48F28C8", Offset = "0x48F28C8", VA = "0x48F28C8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D05"), Address(RVA = "0x48F28D0", Offset = "0x48F28D0", VA = "0x48F28D0")] set
      {
      }
    }

    [Token(Token = "0x17001BD7")]
    public int LastModifiedAp
    {
      [Token(Token = "0x6009D06"), Address(RVA = "0x48F28D8", Offset = "0x48F28D8", VA = "0x48F28D8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D07"), Address(RVA = "0x48F28E0", Offset = "0x48F28E0", VA = "0x48F28E0")] set
      {
      }
    }

    [Token(Token = "0x17001BD8")]
    public string ApModifiedAt
    {
      [Token(Token = "0x6009D08"), Address(RVA = "0x48F28E8", Offset = "0x48F28E8", VA = "0x48F28E8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D09"), Address(RVA = "0x48F28F0", Offset = "0x48F28F0", VA = "0x48F28F0")] set
      {
      }
    }

    [Token(Token = "0x17001BD9")]
    public int ApDayRecoveryItemCount
    {
      [Token(Token = "0x6009D0A"), Address(RVA = "0x48F28F8", Offset = "0x48F28F8", VA = "0x48F28F8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D0B"), Address(RVA = "0x48F2900", Offset = "0x48F2900", VA = "0x48F2900")] set
      {
      }
    }

    [Token(Token = "0x17001BDA")]
    public int ApDayRecoveryCoinCount
    {
      [Token(Token = "0x6009D0C"), Address(RVA = "0x48F2908", Offset = "0x48F2908", VA = "0x48F2908")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D0D"), Address(RVA = "0x48F2910", Offset = "0x48F2910", VA = "0x48F2910")] set
      {
      }
    }

    [Token(Token = "0x17001BDB")]
    public string Id
    {
      [Token(Token = "0x6009D0E"), Address(RVA = "0x48F2918", Offset = "0x48F2918", VA = "0x48F2918")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D0F"), Address(RVA = "0x48F2920", Offset = "0x48F2920", VA = "0x48F2920")] set
      {
      }
    }

    [Token(Token = "0x17001BDC")]
    public long ShortId
    {
      [Token(Token = "0x6009D10"), Address(RVA = "0x48F2928", Offset = "0x48F2928", VA = "0x48F2928")] get
      {
        return new long();
      }
      [Token(Token = "0x6009D11"), Address(RVA = "0x48F2930", Offset = "0x48F2930", VA = "0x48F2930")] set
      {
      }
    }

    [Token(Token = "0x17001BDD")]
    public string Name
    {
      [Token(Token = "0x6009D12"), Address(RVA = "0x48F2938", Offset = "0x48F2938", VA = "0x48F2938")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D13"), Address(RVA = "0x48F2940", Offset = "0x48F2940", VA = "0x48F2940")] set
      {
      }
    }

    [Token(Token = "0x17001BDE")]
    public string Comment
    {
      [Token(Token = "0x6009D14"), Address(RVA = "0x48F2948", Offset = "0x48F2948", VA = "0x48F2948")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D15"), Address(RVA = "0x48F2950", Offset = "0x48F2950", VA = "0x48F2950")] set
      {
      }
    }

    [Token(Token = "0x17001BDF")]
    public string CreatedAt
    {
      [Token(Token = "0x6009D16"), Address(RVA = "0x48F2958", Offset = "0x48F2958", VA = "0x48F2958")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D17"), Address(RVA = "0x48F2960", Offset = "0x48F2960", VA = "0x48F2960")] set
      {
      }
    }

    [Token(Token = "0x17001BE0")]
    public string UpdatedAt
    {
      [Token(Token = "0x6009D18"), Address(RVA = "0x48F2968", Offset = "0x48F2968", VA = "0x48F2968")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D19"), Address(RVA = "0x48F2970", Offset = "0x48F2970", VA = "0x48F2970")] set
      {
      }
    }

    [Token(Token = "0x17001BE1")]
    public bool IsIntroductionFinished
    {
      [Token(Token = "0x6009D1A"), Address(RVA = "0x48F2978", Offset = "0x48F2978", VA = "0x48F2978")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009D1B"), Address(RVA = "0x48F2980", Offset = "0x48F2980", VA = "0x48F2980")] set
      {
      }
    }

    [Token(Token = "0x17001BE2")]
    public int Experience
    {
      [Token(Token = "0x6009D1C"), Address(RVA = "0x48F298C", Offset = "0x48F298C", VA = "0x48F298C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D1D"), Address(RVA = "0x48F2994", Offset = "0x48F2994", VA = "0x48F2994")] set
      {
      }
    }

    [Token(Token = "0x17001BE3")]
    public int AvatarId
    {
      [Token(Token = "0x6009D1E"), Address(RVA = "0x48F299C", Offset = "0x48F299C", VA = "0x48F299C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D1F"), Address(RVA = "0x48F29A4", Offset = "0x48F29A4", VA = "0x48F29A4")] set
      {
      }
    }

    [Token(Token = "0x17001BE4")]
    public int SymbolUnitMasterId
    {
      [Token(Token = "0x6009D20"), Address(RVA = "0x48F29AC", Offset = "0x48F29AC", VA = "0x48F29AC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D21"), Address(RVA = "0x48F29B4", Offset = "0x48F29B4", VA = "0x48F29B4")] set
      {
      }
    }

    [Token(Token = "0x17001BE5")]
    public int EmblemId
    {
      [Token(Token = "0x6009D22"), Address(RVA = "0x48F29BC", Offset = "0x48F29BC", VA = "0x48F29BC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D23"), Address(RVA = "0x48F29C4", Offset = "0x48F29C4", VA = "0x48F29C4")] set
      {
      }
    }

    [Token(Token = "0x17001BE6")]
    public int PreTitleId
    {
      [Token(Token = "0x6009D24"), Address(RVA = "0x48F29CC", Offset = "0x48F29CC", VA = "0x48F29CC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D25"), Address(RVA = "0x48F29D4", Offset = "0x48F29D4", VA = "0x48F29D4")] set
      {
      }
    }

    [Token(Token = "0x17001BE7")]
    public int PostTitleId
    {
      [Token(Token = "0x6009D26"), Address(RVA = "0x48F29DC", Offset = "0x48F29DC", VA = "0x48F29DC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D27"), Address(RVA = "0x48F29E4", Offset = "0x48F29E4", VA = "0x48F29E4")] set
      {
      }
    }

    [Token(Token = "0x17001BE8")]
    public int TitleFrameId
    {
      [Token(Token = "0x6009D28"), Address(RVA = "0x48F29EC", Offset = "0x48F29EC", VA = "0x48F29EC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D29"), Address(RVA = "0x48F29F4", Offset = "0x48F29F4", VA = "0x48F29F4")] set
      {
      }
    }

    [Token(Token = "0x17001BE9")]
    public long TotalBattlePower
    {
      [Token(Token = "0x6009D2A"), Address(RVA = "0x48F29FC", Offset = "0x48F29FC", VA = "0x48F29FC")] get
      {
        return new long();
      }
      [Token(Token = "0x6009D2B"), Address(RVA = "0x48F2A04", Offset = "0x48F2A04", VA = "0x48F2A04")] set
      {
      }
    }

    [Token(Token = "0x17001BEA")]
    public string LastSignedInAt
    {
      [Token(Token = "0x6009D2C"), Address(RVA = "0x48F2A0C", Offset = "0x48F2A0C", VA = "0x48F2A0C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D2D"), Address(RVA = "0x48F2A14", Offset = "0x48F2A14", VA = "0x48F2A14")] set
      {
      }
    }

    [Token(Token = "0x6009D2E")]
    [Address(RVA = "0x48F2A1C", Offset = "0x48F2A1C", VA = "0x48F2A1C")]
    public PlayerType()
    {
    }
  }
}
