// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerOpenProfileType
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
  [Token(Token = "0x2001ACC")]
  [Serializable]
  public class PlayerOpenProfileType : 
    IPlayerBasicProfileInfo,
    IPlayerTitleInfo,
    IPlayerPublicDetailProfileInfo
  {
    [Token(Token = "0x40072CF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x40072D0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int avatar_id;
    [Token(Token = "0x40072D1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int symbol_unit_master_id;
    [Token(Token = "0x40072D2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int emblem_id;
    [Token(Token = "0x40072D3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int pre_title_id;
    [Token(Token = "0x40072D4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int post_title_id;
    [Token(Token = "0x40072D5")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int title_frame_id;
    [Token(Token = "0x40072D6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string name;
    [Token(Token = "0x40072D7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int experience;
    [Token(Token = "0x40072D8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private long short_id;
    [Token(Token = "0x40072D9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private string comment;
    [Token(Token = "0x40072DA")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private long total_battle_power;
    [Token(Token = "0x40072DB")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private string last_signed_in_at;

    [Token(Token = "0x17001B25")]
    public string Id
    {
      [Token(Token = "0x6009B8D"), Address(RVA = "0x48F1C80", Offset = "0x48F1C80", VA = "0x48F1C80")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009B8E"), Address(RVA = "0x48F1C88", Offset = "0x48F1C88", VA = "0x48F1C88")] set
      {
      }
    }

    [Token(Token = "0x17001B26")]
    public int AvatarId
    {
      [Token(Token = "0x6009B8F"), Address(RVA = "0x48F1C90", Offset = "0x48F1C90", VA = "0x48F1C90")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B90"), Address(RVA = "0x48F1C98", Offset = "0x48F1C98", VA = "0x48F1C98")] set
      {
      }
    }

    [Token(Token = "0x17001B27")]
    public int SymbolUnitMasterId
    {
      [Token(Token = "0x6009B91"), Address(RVA = "0x48F1CA0", Offset = "0x48F1CA0", VA = "0x48F1CA0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B92"), Address(RVA = "0x48F1CA8", Offset = "0x48F1CA8", VA = "0x48F1CA8")] set
      {
      }
    }

    [Token(Token = "0x17001B28")]
    public int EmblemId
    {
      [Token(Token = "0x6009B93"), Address(RVA = "0x48F1CB0", Offset = "0x48F1CB0", VA = "0x48F1CB0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B94"), Address(RVA = "0x48F1CB8", Offset = "0x48F1CB8", VA = "0x48F1CB8")] set
      {
      }
    }

    [Token(Token = "0x17001B29")]
    public int PreTitleId
    {
      [Token(Token = "0x6009B95"), Address(RVA = "0x48F1CC0", Offset = "0x48F1CC0", VA = "0x48F1CC0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B96"), Address(RVA = "0x48F1CC8", Offset = "0x48F1CC8", VA = "0x48F1CC8")] set
      {
      }
    }

    [Token(Token = "0x17001B2A")]
    public int PostTitleId
    {
      [Token(Token = "0x6009B97"), Address(RVA = "0x48F1CD0", Offset = "0x48F1CD0", VA = "0x48F1CD0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B98"), Address(RVA = "0x48F1CD8", Offset = "0x48F1CD8", VA = "0x48F1CD8")] set
      {
      }
    }

    [Token(Token = "0x17001B2B")]
    public int TitleFrameId
    {
      [Token(Token = "0x6009B99"), Address(RVA = "0x48F1CE0", Offset = "0x48F1CE0", VA = "0x48F1CE0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B9A"), Address(RVA = "0x48F1CE8", Offset = "0x48F1CE8", VA = "0x48F1CE8")] set
      {
      }
    }

    [Token(Token = "0x17001B2C")]
    public string Name
    {
      [Token(Token = "0x6009B9B"), Address(RVA = "0x48F1CF0", Offset = "0x48F1CF0", VA = "0x48F1CF0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009B9C"), Address(RVA = "0x48F1CF8", Offset = "0x48F1CF8", VA = "0x48F1CF8")] set
      {
      }
    }

    [Token(Token = "0x17001B2D")]
    public int Experience
    {
      [Token(Token = "0x6009B9D"), Address(RVA = "0x48F1D00", Offset = "0x48F1D00", VA = "0x48F1D00")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B9E"), Address(RVA = "0x48F1D08", Offset = "0x48F1D08", VA = "0x48F1D08")] set
      {
      }
    }

    [Token(Token = "0x17001B2E")]
    public long ShortId
    {
      [Token(Token = "0x6009B9F"), Address(RVA = "0x48F1D10", Offset = "0x48F1D10", VA = "0x48F1D10")] get
      {
        return new long();
      }
      [Token(Token = "0x6009BA0"), Address(RVA = "0x48F1D18", Offset = "0x48F1D18", VA = "0x48F1D18")] set
      {
      }
    }

    [Token(Token = "0x17001B2F")]
    public string Comment
    {
      [Token(Token = "0x6009BA1"), Address(RVA = "0x48F1D20", Offset = "0x48F1D20", VA = "0x48F1D20")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009BA2"), Address(RVA = "0x48F1D28", Offset = "0x48F1D28", VA = "0x48F1D28")] set
      {
      }
    }

    [Token(Token = "0x17001B30")]
    public long TotalBattlePower
    {
      [Token(Token = "0x6009BA3"), Address(RVA = "0x48F1D30", Offset = "0x48F1D30", VA = "0x48F1D30")] get
      {
        return new long();
      }
      [Token(Token = "0x6009BA4"), Address(RVA = "0x48F1D38", Offset = "0x48F1D38", VA = "0x48F1D38")] set
      {
      }
    }

    [Token(Token = "0x17001B31")]
    public string LastSignedInAt
    {
      [Token(Token = "0x6009BA5"), Address(RVA = "0x48F1D40", Offset = "0x48F1D40", VA = "0x48F1D40")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009BA6"), Address(RVA = "0x48F1D48", Offset = "0x48F1D48", VA = "0x48F1D48")] set
      {
      }
    }

    [Token(Token = "0x17001B32")]
    private string StaqData\u002EIPlayerBasicProfileInfo\u002EName
    {
      [Token(Token = "0x6009BA7"), Address(RVA = "0x48F1D50", Offset = "0x48F1D50", VA = "0x48F1D50", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001B33")]
    private string StaqData\u002EIPlayerBasicProfileInfo\u002EId
    {
      [Token(Token = "0x6009BA8"), Address(RVA = "0x48F1D58", Offset = "0x48F1D58", VA = "0x48F1D58", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001B34")]
    private int StaqData\u002EIPlayerBasicProfileInfo\u002EExperience
    {
      [Token(Token = "0x6009BA9"), Address(RVA = "0x48F1D60", Offset = "0x48F1D60", VA = "0x48F1D60", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001B35")]
    private int StaqData\u002EIPlayerBasicProfileInfo\u002ESymbolUnitMasterId
    {
      [Token(Token = "0x6009BAA"), Address(RVA = "0x48F1D68", Offset = "0x48F1D68", VA = "0x48F1D68", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001B36")]
    private DateTime StaqData\u002EIPlayerBasicProfileInfo\u002ELastSignedInAt
    {
      [Token(Token = "0x6009BAB"), Address(RVA = "0x48F1D70", Offset = "0x48F1D70", VA = "0x48F1D70", Slot = "8")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17001B37")]
    private int StaqData\u002EIPlayerTitleInfo\u002EPreTitleId
    {
      [Token(Token = "0x6009BAC"), Address(RVA = "0x48F1DF0", Offset = "0x48F1DF0", VA = "0x48F1DF0", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001B38")]
    private int StaqData\u002EIPlayerTitleInfo\u002EPostTitleId
    {
      [Token(Token = "0x6009BAD"), Address(RVA = "0x48F1DF8", Offset = "0x48F1DF8", VA = "0x48F1DF8", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001B39")]
    private int StaqData\u002EIPlayerTitleInfo\u002ETitleFrameId
    {
      [Token(Token = "0x6009BAE"), Address(RVA = "0x48F1E00", Offset = "0x48F1E00", VA = "0x48F1E00", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001B3A")]
    private long StaqData\u002EIPlayerPublicDetailProfileInfo\u002EShortId
    {
      [Token(Token = "0x6009BAF"), Address(RVA = "0x48F1E08", Offset = "0x48F1E08", VA = "0x48F1E08", Slot = "13")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001B3B")]
    private string StaqData\u002EIPlayerPublicDetailProfileInfo\u002EComment
    {
      [Token(Token = "0x6009BB0"), Address(RVA = "0x48F1E10", Offset = "0x48F1E10", VA = "0x48F1E10", Slot = "12")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001B3C")]
    public IPlayerBasicProfileInfo PlayerBasicProfile
    {
      [Token(Token = "0x6009BB1"), Address(RVA = "0x48F1E18", Offset = "0x48F1E18", VA = "0x48F1E18")] get
      {
        return (IPlayerBasicProfileInfo) null;
      }
    }

    [Token(Token = "0x17001B3D")]
    public IPlayerPublicDetailProfileInfo PlayerPublicDetailProfile
    {
      [Token(Token = "0x6009BB2"), Address(RVA = "0x48F1E1C", Offset = "0x48F1E1C", VA = "0x48F1E1C")] get
      {
        return (IPlayerPublicDetailProfileInfo) null;
      }
    }

    [Token(Token = "0x6009BB3")]
    [Address(RVA = "0x48F1E20", Offset = "0x48F1E20", VA = "0x48F1E20")]
    public PlayerOpenProfileType()
    {
    }
  }
}
