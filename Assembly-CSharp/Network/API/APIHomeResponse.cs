// Decompiled with JetBrains decompiler
// Type: Network.API.APIHomeResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D2C")]
  [Serializable]
  public class APIHomeResponse : ICommonApiResult
  {
    [Token(Token = "0x4007C96")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007C97")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool show_mission_badge;
    [Token(Token = "0x4007C98")]
    [FieldOffset(Offset = "0x19")]
    [SerializeField]
    private bool show_panel_mission_badge;
    [Token(Token = "0x4007C99")]
    [FieldOffset(Offset = "0x1A")]
    [SerializeField]
    private bool show_present_badge;
    [Token(Token = "0x4007C9A")]
    [FieldOffset(Offset = "0x1B")]
    [SerializeField]
    private bool show_chat_badge;
    [Token(Token = "0x4007C9B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool show_expedition_badge;
    [Token(Token = "0x4007C9C")]
    [FieldOffset(Offset = "0x1D")]
    [SerializeField]
    private bool show_shop_badge;
    [Token(Token = "0x4007C9D")]
    [FieldOffset(Offset = "0x1E")]
    [SerializeField]
    private bool show_arena_badge;
    [Token(Token = "0x4007C9E")]
    [FieldOffset(Offset = "0x1F")]
    [SerializeField]
    private bool show_gacha_badge;
    [Token(Token = "0x4007C9F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<GlobalMenuGachaButtonType> global_menu_gacha_buttons;
    [Token(Token = "0x4007CA0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerGuildRelationSync guild_relation_sync;
    [Token(Token = "0x4007CA1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<HotDealInfoType> hot_deal_info_array;
    [Token(Token = "0x4007CA2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private bool request_review;
    [Token(Token = "0x4007CA3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<HomeBannerType> banner_list;
    [Token(Token = "0x4007CA4")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<OfficialInformationArticleType> officialinfo_articles;
    [Token(Token = "0x4007CA5")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private string last_guild_chat_message_id;
    [Token(Token = "0x4007CA6")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private string last_guild_bulletin_board_id;
    [Token(Token = "0x4007CA7")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<PlayerAdvertisementType> player_advertisements;

    [Token(Token = "0x1700215D")]
    public NoticeData Notice
    {
      [Token(Token = "0x600ABF6"), Address(RVA = "0x1A44E28", Offset = "0x1A44E28", VA = "0x1A44E28", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700215E")]
    public bool ShowMissionBadge
    {
      [Token(Token = "0x600ABF7"), Address(RVA = "0x1A44E30", Offset = "0x1A44E30", VA = "0x1A44E30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700215F")]
    public bool ShowPanelMissionBadge
    {
      [Token(Token = "0x600ABF8"), Address(RVA = "0x1A44E38", Offset = "0x1A44E38", VA = "0x1A44E38")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002160")]
    public bool ShowPresentBadge
    {
      [Token(Token = "0x600ABF9"), Address(RVA = "0x1A44E40", Offset = "0x1A44E40", VA = "0x1A44E40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002161")]
    public bool ShowChatBadge
    {
      [Token(Token = "0x600ABFA"), Address(RVA = "0x1A44E48", Offset = "0x1A44E48", VA = "0x1A44E48")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002162")]
    public bool ShowExpeditionBadge
    {
      [Token(Token = "0x600ABFB"), Address(RVA = "0x1A44E50", Offset = "0x1A44E50", VA = "0x1A44E50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002163")]
    public bool ShowShopBadge
    {
      [Token(Token = "0x600ABFC"), Address(RVA = "0x1A44E58", Offset = "0x1A44E58", VA = "0x1A44E58")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002164")]
    public bool ShowArenaBadge
    {
      [Token(Token = "0x600ABFD"), Address(RVA = "0x1A44E60", Offset = "0x1A44E60", VA = "0x1A44E60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002165")]
    public bool ShowGachaBadge
    {
      [Token(Token = "0x600ABFE"), Address(RVA = "0x1A44E68", Offset = "0x1A44E68", VA = "0x1A44E68")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002166")]
    public List<GlobalMenuGachaButtonType> GlobalMenuGachaButtons
    {
      [Token(Token = "0x600ABFF"), Address(RVA = "0x1A44E70", Offset = "0x1A44E70", VA = "0x1A44E70")] get
      {
        return (List<GlobalMenuGachaButtonType>) null;
      }
    }

    [Token(Token = "0x17002167")]
    public PlayerGuildRelationSync GuildRelationSync
    {
      [Token(Token = "0x600AC00"), Address(RVA = "0x1A44E78", Offset = "0x1A44E78", VA = "0x1A44E78")] get
      {
        return (PlayerGuildRelationSync) null;
      }
    }

    [Token(Token = "0x17002168")]
    public List<HotDealInfoType> HotDealInfoArray
    {
      [Token(Token = "0x600AC01"), Address(RVA = "0x1A44E80", Offset = "0x1A44E80", VA = "0x1A44E80")] get
      {
        return (List<HotDealInfoType>) null;
      }
    }

    [Token(Token = "0x17002169")]
    public bool RequestReview
    {
      [Token(Token = "0x600AC02"), Address(RVA = "0x1A44E88", Offset = "0x1A44E88", VA = "0x1A44E88")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700216A")]
    public List<HomeBannerType> BannerList
    {
      [Token(Token = "0x600AC03"), Address(RVA = "0x1A44E90", Offset = "0x1A44E90", VA = "0x1A44E90")] get
      {
        return (List<HomeBannerType>) null;
      }
    }

    [Token(Token = "0x1700216B")]
    public List<OfficialInformationArticleType> OfficialinfoArticles
    {
      [Token(Token = "0x600AC04"), Address(RVA = "0x1A44E98", Offset = "0x1A44E98", VA = "0x1A44E98")] get
      {
        return (List<OfficialInformationArticleType>) null;
      }
    }

    [Token(Token = "0x1700216C")]
    public string LastGuildChatMessageId
    {
      [Token(Token = "0x600AC05"), Address(RVA = "0x1A44EA0", Offset = "0x1A44EA0", VA = "0x1A44EA0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700216D")]
    public string LastGuildBulletinBoardId
    {
      [Token(Token = "0x600AC06"), Address(RVA = "0x1A44EA8", Offset = "0x1A44EA8", VA = "0x1A44EA8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700216E")]
    public List<PlayerAdvertisementType> PlayerAdvertisements
    {
      [Token(Token = "0x600AC07"), Address(RVA = "0x1A44EB0", Offset = "0x1A44EB0", VA = "0x1A44EB0")] get
      {
        return (List<PlayerAdvertisementType>) null;
      }
    }

    [Token(Token = "0x600AC08")]
    [Address(RVA = "0x1A44EB8", Offset = "0x1A44EB8", VA = "0x1A44EB8")]
    public APIHomeResponse()
    {
    }
  }
}
