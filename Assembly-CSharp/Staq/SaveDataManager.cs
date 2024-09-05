// Decompiled with JetBrains decompiler
// Type: staq.SaveDataManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using staq.SaveData;
using System.Collections;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C3A")]
  public class SaveDataManager : SingletonMonoBehaviour<SaveDataManager>
  {
    [Token(Token = "0x4010B5C")]
    [FieldOffset(Offset = "0x20")]
    public SaveDataContainer saveDataContainer;

    [Token(Token = "0x17004CE6")]
    protected override bool IsDontDestroy
    {
      [Token(Token = "0x6017AB0"), Address(RVA = "0x238A120", Offset = "0x238A120", VA = "0x238A120", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004CE7")]
    public PlayerSaveData Player
    {
      [Token(Token = "0x6017AB1"), Address(RVA = "0x23802CC", Offset = "0x23802CC", VA = "0x23802CC")] get
      {
        return (PlayerSaveData) null;
      }
    }

    [Token(Token = "0x17004CE8")]
    public DebugSaveData Debug
    {
      [Token(Token = "0x6017AB2"), Address(RVA = "0x23870D8", Offset = "0x23870D8", VA = "0x23870D8")] get
      {
        return (DebugSaveData) null;
      }
    }

    [Token(Token = "0x17004CE9")]
    public BattleSettingsSaveData BattleSettings
    {
      [Token(Token = "0x6017AB3"), Address(RVA = "0x238A128", Offset = "0x238A128", VA = "0x238A128")] get
      {
        return (BattleSettingsSaveData) null;
      }
    }

    [Token(Token = "0x17004CEA")]
    public ArenaSaveData Arena
    {
      [Token(Token = "0x6017AB4"), Address(RVA = "0x238A144", Offset = "0x238A144", VA = "0x238A144")] get
      {
        return (ArenaSaveData) null;
      }
    }

    [Token(Token = "0x17004CEB")]
    public ExpeditionSaveData Expedition
    {
      [Token(Token = "0x6017AB5"), Address(RVA = "0x238A160", Offset = "0x238A160", VA = "0x238A160")] get
      {
        return (ExpeditionSaveData) null;
      }
    }

    [Token(Token = "0x17004CEC")]
    public FreeMapSaveData FreeMap
    {
      [Token(Token = "0x6017AB6"), Address(RVA = "0x238A17C", Offset = "0x238A17C", VA = "0x238A17C")] get
      {
        return (FreeMapSaveData) null;
      }
    }

    [Token(Token = "0x17004CED")]
    public BoardSaveData Board
    {
      [Token(Token = "0x6017AB7"), Address(RVA = "0x238A198", Offset = "0x238A198", VA = "0x238A198")] get
      {
        return (BoardSaveData) null;
      }
    }

    [Token(Token = "0x17004CEE")]
    public LobbySaveData Lobby
    {
      [Token(Token = "0x6017AB8"), Address(RVA = "0x238A1B4", Offset = "0x238A1B4", VA = "0x238A1B4")] get
      {
        return (LobbySaveData) null;
      }
    }

    [Token(Token = "0x17004CEF")]
    public ChatSaveData Chat
    {
      [Token(Token = "0x6017AB9"), Address(RVA = "0x238A1D0", Offset = "0x238A1D0", VA = "0x238A1D0")] get
      {
        return (ChatSaveData) null;
      }
    }

    [Token(Token = "0x17004CF0")]
    public ChatChannelSaveData ChatChannel
    {
      [Token(Token = "0x6017ABA"), Address(RVA = "0x238A1EC", Offset = "0x238A1EC", VA = "0x238A1EC")] get
      {
        return (ChatChannelSaveData) null;
      }
    }

    [Token(Token = "0x17004CF1")]
    public ChatGuidelineSaveData ChatGuideline
    {
      [Token(Token = "0x6017ABB"), Address(RVA = "0x238A208", Offset = "0x238A208", VA = "0x238A208")] get
      {
        return (ChatGuidelineSaveData) null;
      }
    }

    [Token(Token = "0x17004CF2")]
    public ChatSettingSaveData ChatSetting
    {
      [Token(Token = "0x6017ABC"), Address(RVA = "0x238A224", Offset = "0x238A224", VA = "0x238A224")] get
      {
        return (ChatSettingSaveData) null;
      }
    }

    [Token(Token = "0x17004CF3")]
    public ShopSaveData Shop
    {
      [Token(Token = "0x6017ABD"), Address(RVA = "0x238A240", Offset = "0x238A240", VA = "0x238A240")] get
      {
        return (ShopSaveData) null;
      }
    }

    [Token(Token = "0x17004CF4")]
    public CalendarSaveData calenderDirecting
    {
      [Token(Token = "0x6017ABE"), Address(RVA = "0x238A25C", Offset = "0x238A25C", VA = "0x238A25C")] get
      {
        return (CalendarSaveData) null;
      }
    }

    [Token(Token = "0x17004CF5")]
    public DisplaySaveData Display
    {
      [Token(Token = "0x6017ABF"), Address(RVA = "0x238A278", Offset = "0x238A278", VA = "0x238A278")] get
      {
        return (DisplaySaveData) null;
      }
    }

    [Token(Token = "0x17004CF6")]
    public SortFilterSaveData SortFilter
    {
      [Token(Token = "0x6017AC0"), Address(RVA = "0x238A294", Offset = "0x238A294", VA = "0x238A294")] get
      {
        return (SortFilterSaveData) null;
      }
    }

    [Token(Token = "0x17004CF7")]
    public SoundVolumeSaveData SoundVolume
    {
      [Token(Token = "0x6017AC1"), Address(RVA = "0x238A2B0", Offset = "0x238A2B0", VA = "0x238A2B0")] get
      {
        return (SoundVolumeSaveData) null;
      }
    }

    [Token(Token = "0x17004CF8")]
    public PartyTemplateSaveData PartyTemplate
    {
      [Token(Token = "0x6017AC2"), Address(RVA = "0x238A2CC", Offset = "0x238A2CC", VA = "0x238A2CC")] get
      {
        return (PartyTemplateSaveData) null;
      }
    }

    [Token(Token = "0x17004CF9")]
    public ChapterShopReleaseSaveData ChapterShopRelease
    {
      [Token(Token = "0x6017AC3"), Address(RVA = "0x238A2E8", Offset = "0x238A2E8", VA = "0x238A2E8")] get
      {
        return (ChapterShopReleaseSaveData) null;
      }
    }

    [Token(Token = "0x17004CFA")]
    public NoticeSettingSaveData NoticeSetting
    {
      [Token(Token = "0x6017AC4"), Address(RVA = "0x238A304", Offset = "0x238A304", VA = "0x238A304")] get
      {
        return (NoticeSettingSaveData) null;
      }
    }

    [Token(Token = "0x17004CFB")]
    public DownloadSettingSaveData DownloadSetting
    {
      [Token(Token = "0x6017AC5"), Address(RVA = "0x238A320", Offset = "0x238A320", VA = "0x238A320")] get
      {
        return (DownloadSettingSaveData) null;
      }
    }

    [Token(Token = "0x17004CFC")]
    public IntroChapterSaveData IntroChapter
    {
      [Token(Token = "0x6017AC6"), Address(RVA = "0x238A33C", Offset = "0x238A33C", VA = "0x238A33C")] get
      {
        return (IntroChapterSaveData) null;
      }
    }

    [Token(Token = "0x17004CFD")]
    public DataLinkageSaveData DataLinkage
    {
      [Token(Token = "0x6017AC7"), Address(RVA = "0x238A358", Offset = "0x238A358", VA = "0x238A358")] get
      {
        return (DataLinkageSaveData) null;
      }
    }

    [Token(Token = "0x17004CFE")]
    public HomeAdvSaveData HomeAdvSaveData
    {
      [Token(Token = "0x6017AC8"), Address(RVA = "0x238A374", Offset = "0x238A374", VA = "0x238A374")] get
      {
        return (HomeAdvSaveData) null;
      }
    }

    [Token(Token = "0x17004CFF")]
    public NewFlagRentalBookSaveData NewFlagRentalBook
    {
      [Token(Token = "0x6017AC9"), Address(RVA = "0x238A390", Offset = "0x238A390", VA = "0x238A390")] get
      {
        return (NewFlagRentalBookSaveData) null;
      }
    }

    [Token(Token = "0x17004D00")]
    public NewBadgeSaveData NewBadge
    {
      [Token(Token = "0x6017ACA"), Address(RVA = "0x238A3AC", Offset = "0x238A3AC", VA = "0x238A3AC")] get
      {
        return (NewBadgeSaveData) null;
      }
    }

    [Token(Token = "0x17004D01")]
    public TodayInformationSaveData TodayInformation
    {
      [Token(Token = "0x6017ACB"), Address(RVA = "0x238A3C8", Offset = "0x238A3C8", VA = "0x238A3C8")] get
      {
        return (TodayInformationSaveData) null;
      }
    }

    [Token(Token = "0x17004D02")]
    public MenuLockSaveData MenuLock
    {
      [Token(Token = "0x6017ACC"), Address(RVA = "0x238A3E4", Offset = "0x238A3E4", VA = "0x238A3E4")] get
      {
        return (MenuLockSaveData) null;
      }
    }

    [Token(Token = "0x17004D03")]
    public QuestSeletedSaveData QuestSelected
    {
      [Token(Token = "0x6017ACD"), Address(RVA = "0x238A400", Offset = "0x238A400", VA = "0x238A400")] get
      {
        return (QuestSeletedSaveData) null;
      }
    }

    [Token(Token = "0x17004D04")]
    public PassShopSaveData PassShopSaveData
    {
      [Token(Token = "0x6017ACE"), Address(RVA = "0x238A41C", Offset = "0x238A41C", VA = "0x238A41C")] get
      {
        return (PassShopSaveData) null;
      }
    }

    [Token(Token = "0x17004D05")]
    public ReadInformationSaveData ReadInformation
    {
      [Token(Token = "0x6017ACF"), Address(RVA = "0x238A438", Offset = "0x238A438", VA = "0x238A438")] get
      {
        return (ReadInformationSaveData) null;
      }
    }

    [Token(Token = "0x17004D06")]
    public StoryGachaSaveData StoryGacha
    {
      [Token(Token = "0x6017AD0"), Address(RVA = "0x238A454", Offset = "0x238A454", VA = "0x238A454")] get
      {
        return (StoryGachaSaveData) null;
      }
    }

    [Token(Token = "0x17004D07")]
    public FreeMapNotifySaveData notify
    {
      [Token(Token = "0x6017AD1"), Address(RVA = "0x238A470", Offset = "0x238A470", VA = "0x238A470")] get
      {
        return (FreeMapNotifySaveData) null;
      }
    }

    [Token(Token = "0x17004D08")]
    public EventTopSaveData EventTopSaveData
    {
      [Token(Token = "0x6017AD2"), Address(RVA = "0x238A48C", Offset = "0x238A48C", VA = "0x238A48C")] get
      {
        return (EventTopSaveData) null;
      }
    }

    [Token(Token = "0x17004D09")]
    public ExpeditionPartyLockSaveData ExpeditionPartyLock
    {
      [Token(Token = "0x6017AD3"), Address(RVA = "0x238A4A8", Offset = "0x238A4A8", VA = "0x238A4A8")] get
      {
        return (ExpeditionPartyLockSaveData) null;
      }
    }

    [Token(Token = "0x17004D0A")]
    public PlayerCharacterSaveData PlayerCharacter
    {
      [Token(Token = "0x6017AD4"), Address(RVA = "0x238A4C4", Offset = "0x238A4C4", VA = "0x238A4C4")] get
      {
        return (PlayerCharacterSaveData) null;
      }
    }

    [Token(Token = "0x17004D0B")]
    public AbilityBoardReleaseSaveData AbilityBoardReleaseSaveData
    {
      [Token(Token = "0x6017AD5"), Address(RVA = "0x238A4E0", Offset = "0x238A4E0", VA = "0x238A4E0")] get
      {
        return (AbilityBoardReleaseSaveData) null;
      }
    }

    [Token(Token = "0x17004D0C")]
    public ServerSaveData AddServer
    {
      [Token(Token = "0x6017AD6"), Address(RVA = "0x238A4FC", Offset = "0x238A4FC", VA = "0x238A4FC")] get
      {
        return (ServerSaveData) null;
      }
    }

    [Token(Token = "0x17004D0D")]
    public LimitedEventSaveData LimitedEvent
    {
      [Token(Token = "0x6017AD7"), Address(RVA = "0x238A518", Offset = "0x238A518", VA = "0x238A518")] get
      {
        return (LimitedEventSaveData) null;
      }
    }

    [Token(Token = "0x17004D0E")]
    public LocationSaveData Location
    {
      [Token(Token = "0x6017AD8"), Address(RVA = "0x2386A6C", Offset = "0x2386A6C", VA = "0x2386A6C")] get
      {
        return (LocationSaveData) null;
      }
    }

    [Token(Token = "0x17004D0F")]
    public HotDealSaveData HotDeal
    {
      [Token(Token = "0x6017AD9"), Address(RVA = "0x238A534", Offset = "0x238A534", VA = "0x238A534")] get
      {
        return (HotDealSaveData) null;
      }
    }

    [Token(Token = "0x17004D10")]
    public GuildRoleSaveData GuildRole
    {
      [Token(Token = "0x6017ADA"), Address(RVA = "0x238A550", Offset = "0x238A550", VA = "0x238A550")] get
      {
        return (GuildRoleSaveData) null;
      }
    }

    [Token(Token = "0x17004D11")]
    public GuildFacilityConfirmLevelupEffectSaveData GuildFacilityConfirmLevelupEffect
    {
      [Token(Token = "0x6017ADB"), Address(RVA = "0x238A56C", Offset = "0x238A56C", VA = "0x238A56C")] get
      {
        return (GuildFacilityConfirmLevelupEffectSaveData) null;
      }
    }

    [Token(Token = "0x17004D12")]
    public AdvTutorialReadedSaveData AdvTutorialReaded
    {
      [Token(Token = "0x6017ADC"), Address(RVA = "0x238A588", Offset = "0x238A588", VA = "0x238A588")] get
      {
        return (AdvTutorialReadedSaveData) null;
      }
    }

    [Token(Token = "0x17004D13")]
    public PrologueOnlyAssetDeleteCheckSaveData PrologueOnlyAssetDeleteCheck
    {
      [Token(Token = "0x6017ADD"), Address(RVA = "0x238A5A4", Offset = "0x238A5A4", VA = "0x238A5A4")] get
      {
        return (PrologueOnlyAssetDeleteCheckSaveData) null;
      }
    }

    [Token(Token = "0x17004D14")]
    public PreHomeEvStageSaveData PreHomeEvStage
    {
      [Token(Token = "0x6017ADE"), Address(RVA = "0x238A5C0", Offset = "0x238A5C0", VA = "0x238A5C0")] get
      {
        return (PreHomeEvStageSaveData) null;
      }
    }

    [Token(Token = "0x17004D15")]
    public FirstPlayerSaveData FirstPlayer
    {
      [Token(Token = "0x6017ADF"), Address(RVA = "0x238A5DC", Offset = "0x238A5DC", VA = "0x238A5DC")] get
      {
        return (FirstPlayerSaveData) null;
      }
    }

    [Token(Token = "0x17004D16")]
    public BadgeFilterSaveData BadgeFilter
    {
      [Token(Token = "0x6017AE0"), Address(RVA = "0x238A5F8", Offset = "0x238A5F8", VA = "0x238A5F8")] get
      {
        return (BadgeFilterSaveData) null;
      }
    }

    [Token(Token = "0x17004D17")]
    public GuildSaveData GuildData
    {
      [Token(Token = "0x6017AE1"), Address(RVA = "0x238A614", Offset = "0x238A614", VA = "0x238A614")] get
      {
        return (GuildSaveData) null;
      }
    }

    [Token(Token = "0x17004D18")]
    public URLSchemeParameterSaveData URLSchemeParameter
    {
      [Token(Token = "0x6017AE2"), Address(RVA = "0x238A630", Offset = "0x238A630", VA = "0x238A630")] get
      {
        return (URLSchemeParameterSaveData) null;
      }
    }

    [Token(Token = "0x17004D19")]
    public StoryArchiveMemorySaveData StoryArchiveMemory
    {
      [Token(Token = "0x6017AE3"), Address(RVA = "0x238A64C", Offset = "0x238A64C", VA = "0x238A64C")] get
      {
        return (StoryArchiveMemorySaveData) null;
      }
    }

    [Token(Token = "0x17004D1A")]
    public PersonalEmblemSaveData PersonalEmblem
    {
      [Token(Token = "0x6017AE4"), Address(RVA = "0x238A668", Offset = "0x238A668", VA = "0x238A668")] get
      {
        return (PersonalEmblemSaveData) null;
      }
    }

    [Token(Token = "0x17004D1B")]
    public ShowFullDuelSaveData ShowFullDuelSaveData
    {
      [Token(Token = "0x6017AE5"), Address(RVA = "0x238A684", Offset = "0x238A684", VA = "0x238A684")] get
      {
        return (ShowFullDuelSaveData) null;
      }
    }

    [Token(Token = "0x17004D1C")]
    public ShowBattleAdvSaveData ShowBattleAdvSaveData
    {
      [Token(Token = "0x6017AE6"), Address(RVA = "0x238A6A0", Offset = "0x238A6A0", VA = "0x238A6A0")] get
      {
        return (ShowBattleAdvSaveData) null;
      }
    }

    [Token(Token = "0x17004D1D")]
    public AreaQuestSaveData AreaQuestSaveData
    {
      [Token(Token = "0x6017AE7"), Address(RVA = "0x238A6BC", Offset = "0x238A6BC", VA = "0x238A6BC")] get
      {
        return (AreaQuestSaveData) null;
      }
    }

    [Token(Token = "0x17004D1E")]
    public ChallengeGuildRaidSaveData ChallengeGuildRaid
    {
      [Token(Token = "0x6017AE8"), Address(RVA = "0x238A6D8", Offset = "0x238A6D8", VA = "0x238A6D8")] get
      {
        return (ChallengeGuildRaidSaveData) null;
      }
    }

    [Token(Token = "0x17004D1F")]
    public GuildRaidSaveData GuildRaidSaveData
    {
      [Token(Token = "0x6017AE9"), Address(RVA = "0x238A6F4", Offset = "0x238A6F4", VA = "0x238A6F4")] get
      {
        return (GuildRaidSaveData) null;
      }
    }

    [Token(Token = "0x17004D20")]
    public GuildRaidNewBadgeSaveData GuildRaidNewBadgeSaveData
    {
      [Token(Token = "0x6017AEA"), Address(RVA = "0x238A710", Offset = "0x238A710", VA = "0x238A710")] get
      {
        return (GuildRaidNewBadgeSaveData) null;
      }
    }

    [Token(Token = "0x17004D21")]
    public ArmouryGridSaveData ArmouryGridSaveData
    {
      [Token(Token = "0x6017AEB"), Address(RVA = "0x238A72C", Offset = "0x238A72C", VA = "0x238A72C")] get
      {
        return (ArmouryGridSaveData) null;
      }
    }

    [Token(Token = "0x17004D22")]
    public GachaSettingSaveData GachaSettingSaveData
    {
      [Token(Token = "0x6017AEC"), Address(RVA = "0x238A748", Offset = "0x238A748", VA = "0x238A748")] get
      {
        return (GachaSettingSaveData) null;
      }
    }

    [Token(Token = "0x6017AED")]
    [Address(RVA = "0x238A764", Offset = "0x238A764", VA = "0x238A764")]
    private SaveDataManager()
    {
    }

    [Token(Token = "0x6017AEE")]
    [Address(RVA = "0x238A7F4", Offset = "0x238A7F4", VA = "0x238A7F4", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6017AEF")]
    [Address(RVA = "0x238A8F0", Offset = "0x238A8F0", VA = "0x238A8F0")]
    public void LoadSaveData()
    {
    }

    [Token(Token = "0x6017AF0")]
    [Address(RVA = "0x238AD88", Offset = "0x238AD88", VA = "0x238AD88")]
    private IEnumerator DeleteSaveData(bool isAccountRecreate, bool isCreateNewSecretKey = true)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017AF1")]
    [Address(RVA = "0x238AE2C", Offset = "0x238AE2C", VA = "0x238AE2C")]
    public IEnumerator AccountRecreate() => (IEnumerator) null;

    [Token(Token = "0x6017AF2")]
    [Address(RVA = "0x238AEBC", Offset = "0x238AEBC", VA = "0x238AEBC")]
    public IEnumerator AccountDelete() => (IEnumerator) null;

    [Token(Token = "0x6017AF3")]
    [Address(RVA = "0x238AF4C", Offset = "0x238AF4C", VA = "0x238AF4C")]
    public void OnCreateAccount()
    {
    }

    [Token(Token = "0x6017AF4")]
    [Address(RVA = "0x238AF70", Offset = "0x238AF70", VA = "0x238AF70")]
    public IEnumerator InheritedPlayerData() => (IEnumerator) null;

    [Token(Token = "0x6017AF5")]
    [Address(RVA = "0x238B000", Offset = "0x238B000", VA = "0x238B000")]
    public static string GetPlayerPersistentDataPath() => (string) null;
  }
}
