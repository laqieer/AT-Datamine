// Decompiled with JetBrains decompiler
// Type: Story.StoryTextUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005CD")]
  public static class StoryTextUtility
  {
    [Token(Token = "0x4001CC1")]
    [FieldOffset(Offset = "0x0")]
    private static bool isLoadRef;

    [Token(Token = "0x600215C")]
    [Address(RVA = "0x2D97BBC", Offset = "0x2D97BBC", VA = "0x2D97BBC")]
    public static string Close() => (string) null;

    [Token(Token = "0x600215D")]
    [Address(RVA = "0x2D97C3C", Offset = "0x2D97C3C", VA = "0x2D97C3C")]
    public static string Back() => (string) null;

    [Token(Token = "0x600215E")]
    [Address(RVA = "0x2D97CBC", Offset = "0x2D97CBC", VA = "0x2D97CBC")]
    public static string Day() => (string) null;

    [Token(Token = "0x600215F")]
    [Address(RVA = "0x2D97D3C", Offset = "0x2D97D3C", VA = "0x2D97D3C")]
    public static string DayofWeek(DayofweekEnum dayofweek) => (string) null;

    [Token(Token = "0x6002160")]
    [Address(RVA = "0x2D97F64", Offset = "0x2D97F64", VA = "0x2D97F64")]
    public static string DayofWeek02(DayofweekEnum dayofweek) => (string) null;

    [Token(Token = "0x6002161")]
    [Address(RVA = "0x2D9818C", Offset = "0x2D9818C", VA = "0x2D9818C")]
    public static string Month(int month) => (string) null;

    [Token(Token = "0x6002162")]
    [Address(RVA = "0x2D96F58", Offset = "0x2D96F58", VA = "0x2D96F58")]
    public static string Timezone(StoryTimeSlotTypeEnum timezoneType, bool weekday)
    {
      return (string) null;
    }

    [Token(Token = "0x6002163")]
    [Address(RVA = "0x2D96DEC", Offset = "0x2D96DEC", VA = "0x2D96DEC")]
    public static string Timezone02(StoryTimeSlotTypeEnum timezoneType, bool weekday)
    {
      return (string) null;
    }

    [Token(Token = "0x6002164")]
    [Address(RVA = "0x2D98264", Offset = "0x2D98264", VA = "0x2D98264")]
    private static void InitializeTimezoneKeys(
      out string[] holidayTimezoneKeys,
      out string[] weekdayTimezoneKeys)
    {
    }

    [Token(Token = "0x6002165")]
    [Address(RVA = "0x2D98598", Offset = "0x2D98598", VA = "0x2D98598")]
    public static string Shortage(string name) => (string) null;

    [Token(Token = "0x6002166")]
    [Address(RVA = "0x2D98628", Offset = "0x2D98628", VA = "0x2D98628")]
    public static string Start() => (string) null;

    [Token(Token = "0x6002167")]
    [Address(RVA = "0x2D986A8", Offset = "0x2D986A8", VA = "0x2D986A8")]
    public static string Revocation() => (string) null;

    [Token(Token = "0x6002168")]
    [Address(RVA = "0x2D98728", Offset = "0x2D98728", VA = "0x2D98728")]
    public static string AutoMove() => (string) null;

    [Token(Token = "0x6002169")]
    [Address(RVA = "0x2D987A8", Offset = "0x2D987A8", VA = "0x2D987A8")]
    public static string Complete() => (string) null;

    [Token(Token = "0x600216A")]
    [Address(RVA = "0x2D98828", Offset = "0x2D98828", VA = "0x2D98828")]
    public static string Map() => (string) null;

    [Token(Token = "0x600216B")]
    [Address(RVA = "0x2D988A8", Offset = "0x2D988A8", VA = "0x2D988A8")]
    public static string RewardPopupItem(string name, int amount) => (string) null;

    [Token(Token = "0x600216C")]
    [Address(RVA = "0x2D98978", Offset = "0x2D98978", VA = "0x2D98978")]
    public static string RewardPopupItem() => (string) null;

    [Token(Token = "0x600216D")]
    [Address(RVA = "0x2D989F8", Offset = "0x2D989F8", VA = "0x2D989F8")]
    public static string TrackerFix() => (string) null;

    [Token(Token = "0x600216E")]
    [Address(RVA = "0x2D98A78", Offset = "0x2D98A78", VA = "0x2D98A78")]
    public static string CommunicationRankupDescription() => (string) null;

    [Token(Token = "0x600216F")]
    [Address(RVA = "0x2D98AF8", Offset = "0x2D98AF8", VA = "0x2D98AF8")]
    public static string ShopProductLineupHasBeenUpdated() => (string) null;

    [Token(Token = "0x6002170")]
    [Address(RVA = "0x2D98B78", Offset = "0x2D98B78", VA = "0x2D98B78")]
    public static string ShopCanBuyProductsLowerPrice() => (string) null;

    [Token(Token = "0x6002171")]
    [Address(RVA = "0x2D98BF8", Offset = "0x2D98BF8", VA = "0x2D98BF8")]
    public static string ShopLineupUpdateShort() => (string) null;

    [Token(Token = "0x6002172")]
    [Address(RVA = "0x2D98C78", Offset = "0x2D98C78", VA = "0x2D98C78")]
    public static string NotHaveKeyText() => (string) null;

    [Token(Token = "0x6002173")]
    [Address(RVA = "0x2D98CF8", Offset = "0x2D98CF8", VA = "0x2D98CF8")]
    public static string ConfirmOpenChest(string name, int amount) => (string) null;

    [Token(Token = "0x6002174")]
    [Address(RVA = "0x2D98DC8", Offset = "0x2D98DC8", VA = "0x2D98DC8")]
    public static string StoryGachaConditionSequence(string title) => (string) null;

    [Token(Token = "0x6002175")]
    [Address(RVA = "0x2D98E58", Offset = "0x2D98E58", VA = "0x2D98E58")]
    public static string ShopDescription() => (string) null;

    [Token(Token = "0x6002176")]
    [Address(RVA = "0x2D98ED8", Offset = "0x2D98ED8", VA = "0x2D98ED8")]
    public static string BattleEnter() => (string) null;

    [Token(Token = "0x6002177")]
    [Address(RVA = "0x2D98F58", Offset = "0x2D98F58", VA = "0x2D98F58")]
    public static string ConfirmTimeSkip() => (string) null;

    [Token(Token = "0x6002178")]
    [Address(RVA = "0x2D98FD8", Offset = "0x2D98FD8", VA = "0x2D98FD8")]
    public static string SkipButton() => (string) null;

    [Token(Token = "0x6002179")]
    [Address(RVA = "0x2D99058", Offset = "0x2D99058", VA = "0x2D99058")]
    public static string ConfirmAutoMove(string title) => (string) null;

    [Token(Token = "0x600217A")]
    [Address(RVA = "0x2D990E8", Offset = "0x2D990E8", VA = "0x2D990E8")]
    public static string ConfirmStoryShop(string chara) => (string) null;

    [Token(Token = "0x600217B")]
    [Address(RVA = "0x2D99178", Offset = "0x2D99178", VA = "0x2D99178")]
    public static string ConfirmFacilityRental() => (string) null;

    [Token(Token = "0x600217C")]
    [Address(RVA = "0x2D991F8", Offset = "0x2D991F8", VA = "0x2D991F8")]
    public static string ConfirmFacilityLottery() => (string) null;

    [Token(Token = "0x600217D")]
    [Address(RVA = "0x2D99278", Offset = "0x2D99278", VA = "0x2D99278")]
    public static string ConfirmFacilityReading() => (string) null;

    [Token(Token = "0x600217E")]
    [Address(RVA = "0x2D992F8", Offset = "0x2D992F8", VA = "0x2D992F8")]
    public static string FacilityBonusDayofWeek() => (string) null;

    [Token(Token = "0x600217F")]
    [Address(RVA = "0x2D99378", Offset = "0x2D99378", VA = "0x2D99378")]
    public static string FacilityBonusTimezone() => (string) null;

    [Token(Token = "0x6002180")]
    [Address(RVA = "0x2D993F8", Offset = "0x2D993F8", VA = "0x2D993F8")]
    public static string FacilityBonusWeather() => (string) null;

    [Token(Token = "0x6002181")]
    [Address(RVA = "0x2D99478", Offset = "0x2D99478", VA = "0x2D99478")]
    public static string FacilityBonusNone() => (string) null;

    [Token(Token = "0x6002182")]
    [Address(RVA = "0x2D994F8", Offset = "0x2D994F8", VA = "0x2D994F8")]
    public static string ReleaseConditionChapter(string chapter) => (string) null;

    [Token(Token = "0x6002183")]
    [Address(RVA = "0x2D99588", Offset = "0x2D99588", VA = "0x2D99588")]
    public static string ReleaseConditionSequence(string chapter, string sequence) => (string) null;

    [Token(Token = "0x6002184")]
    [Address(RVA = "0x2D99628", Offset = "0x2D99628", VA = "0x2D99628")]
    public static string RewardCaptionFirst() => (string) null;

    [Token(Token = "0x6002185")]
    [Address(RVA = "0x2D996A8", Offset = "0x2D996A8", VA = "0x2D996A8")]
    public static string RewardCaptionCount(int count) => (string) null;

    [Token(Token = "0x6002186")]
    [Address(RVA = "0x2D99770", Offset = "0x2D99770", VA = "0x2D99770")]
    public static string CannotExecute() => (string) null;

    [Token(Token = "0x6002187")]
    [Address(RVA = "0x2D997F0", Offset = "0x2D997F0", VA = "0x2D997F0")]
    public static string CannotExecuteReasonIsNotFound() => (string) null;

    [Token(Token = "0x6002188")]
    [Address(RVA = "0x2D99870", Offset = "0x2D99870", VA = "0x2D99870")]
    public static string CannotExecuteReasonIsExpired() => (string) null;

    [Token(Token = "0x6002189")]
    [Address(RVA = "0x2D998F0", Offset = "0x2D998F0", VA = "0x2D998F0")]
    public static string CannotExecuteReasonIsInvalidTimezone() => (string) null;

    [Token(Token = "0x600218A")]
    [Address(RVA = "0x2D99970", Offset = "0x2D99970", VA = "0x2D99970")]
    public static string CannotExecuteReasonIsFullness() => (string) null;

    [Token(Token = "0x600218B")]
    [Address(RVA = "0x2D999F0", Offset = "0x2D999F0", VA = "0x2D999F0")]
    public static string GetCommunicationRankUpParamText(int status, int rank) => (string) null;

    [Token(Token = "0x600218C")]
    [Address(RVA = "0x2D99B40", Offset = "0x2D99B40", VA = "0x2D99B40")]
    public static string GetCommunicationRankUpParamDescriptionText(string str) => (string) null;

    [Token(Token = "0x600218D")]
    [Address(RVA = "0x2D99BD0", Offset = "0x2D99BD0", VA = "0x2D99BD0")]
    public static string GetCommunicationRankUpCompleateText() => (string) null;

    [Token(Token = "0x600218E")]
    [Address(RVA = "0x2D99C50", Offset = "0x2D99C50", VA = "0x2D99C50")]
    public static string SubQuestConditionHintCommu() => (string) null;

    [Token(Token = "0x600218F")]
    [Address(RVA = "0x2D99CD0", Offset = "0x2D99CD0", VA = "0x2D99CD0")]
    public static string SubQuestConditionHintHuman() => (string) null;

    [Token(Token = "0x6002190")]
    [Address(RVA = "0x2D99D50", Offset = "0x2D99D50", VA = "0x2D99D50")]
    public static string HumanStatusText(int humanStatus) => (string) null;

    [Token(Token = "0x6002191")]
    [Address(RVA = "0x2D99E28", Offset = "0x2D99E28", VA = "0x2D99E28")]
    public static string PopupObliviaeReleaseConditionHead() => (string) null;

    [Token(Token = "0x6002192")]
    [Address(RVA = "0x2D99EA8", Offset = "0x2D99EA8", VA = "0x2D99EA8")]
    public static string PopupObliviaeReleaseConditionReleaseKizuna(string charcterName)
    {
      return (string) null;
    }

    [Token(Token = "0x6002193")]
    [Address(RVA = "0x2D99F38", Offset = "0x2D99F38", VA = "0x2D99F38")]
    public static string PopupObliviaeReleaseCondition(
      string questName,
      string charcterName,
      int maxRankNum)
    {
      return (string) null;
    }

    [Token(Token = "0x6002194")]
    [Address(RVA = "0x2D9A100", Offset = "0x2D9A100", VA = "0x2D9A100")]
    public static string CommunicationSkillLevel(int level) => (string) null;

    [Token(Token = "0x6002195")]
    [Address(RVA = "0x2D9A1C8", Offset = "0x2D9A1C8", VA = "0x2D9A1C8")]
    public static IEnumerator Load() => (IEnumerator) null;

    [Token(Token = "0x6002196")]
    [Address(RVA = "0x2D9A250", Offset = "0x2D9A250", VA = "0x2D9A250")]
    public static void UnLoad()
    {
    }

    [Token(Token = "0x20005CE")]
    public static class AssetBundles
    {
      [Token(Token = "0x4001CC2")]
      public const string RESOURCES = "resources";
      [Token(Token = "0x4001CC3")]
      public const string SYSTEM = "text_system";
      [Token(Token = "0x4001CC4")]
      public const string STORY = "text_system_story";
    }

    [Token(Token = "0x20005CF")]
    public static class TextKeys
    {
      [Token(Token = "0x4001CC5")]
      public const string POPUP_BUTTON_CLOSE = "CLOSE";
      [Token(Token = "0x4001CC6")]
      public const string ITEM_LACKING_02 = "ITEM_LACKING_02";
      [Token(Token = "0x4001CC7")]
      public const string CHAPTER_SHOP_LINEUP_UPDATE = "CHAPTER_SHOP_LINEUP_UPDATE";
      [Token(Token = "0x4001CC8")]
      public const string PRODUCT_LINEUP_HAS_BEEN_UPDATED = "PRODUCT_LINEUP_HAS_BEEN_UPDATED";
      [Token(Token = "0x4001CC9")]
      public const string CAN_BUY_PRODUCTS_LOWER_PRICE = "CAN_BUY_PRODUCTS_LOWER_PRICE";
      [Token(Token = "0x4001CCA")]
      public const string STORY_GACHA_CONDITION_SEQUENCE = "STORY_GACHA_CONDITION_SEQUENCE";
      [Token(Token = "0x4001CCB")]
      public const string MONTH = "MONTH_{0}";
      [Token(Token = "0x4001CCC")]
      public const string MONTH_FORMAT = "MONTH_FORMAT";
      [Token(Token = "0x4001CCD")]
      public const string MONTH_FORMAT_02 = "MONTH_FORMAT_02";
      [Token(Token = "0x4001CCE")]
      public const string DAY = "DAY";
      [Token(Token = "0x4001CCF")]
      public const string WEEK_SUN = "WEEK_SUN";
      [Token(Token = "0x4001CD0")]
      public const string WEEK_MON = "WEEK_MON";
      [Token(Token = "0x4001CD1")]
      public const string WEEK_TUE = "WEEK_TUE";
      [Token(Token = "0x4001CD2")]
      public const string WEEK_WED = "WEEK_WED";
      [Token(Token = "0x4001CD3")]
      public const string WEEK_THU = "WEEK_THU";
      [Token(Token = "0x4001CD4")]
      public const string WEEK_FRI = "WEEK_FRI";
      [Token(Token = "0x4001CD5")]
      public const string WEEK_SAT = "WEEK_SAT";
      [Token(Token = "0x4001CD6")]
      public const string WEEK_SUN_02 = "WEEK_SUN_02";
      [Token(Token = "0x4001CD7")]
      public const string WEEK_MON_02 = "WEEK_MON_02";
      [Token(Token = "0x4001CD8")]
      public const string WEEK_TUE_02 = "WEEK_TUE_02";
      [Token(Token = "0x4001CD9")]
      public const string WEEK_WED_02 = "WEEK_WED_02";
      [Token(Token = "0x4001CDA")]
      public const string WEEK_THU_02 = "WEEK_THU_02";
      [Token(Token = "0x4001CDB")]
      public const string WEEK_FRI_02 = "WEEK_FRI_02";
      [Token(Token = "0x4001CDC")]
      public const string WEEK_SAT_02 = "WEEK_SAT_02";
      [Token(Token = "0x4001CDD")]
      public const string REWARD_POPUP_ITEM = "REWARD_POPUP_ITEM_FORMAT";
      [Token(Token = "0x4001CDE")]
      public const string REWARD_POPUP_ITEM_02 = "REWARD_POPUP_ITEM_FORMAT_02";
      [Token(Token = "0x4001CDF")]
      public const string TRACKER_FIX = "TRACKER_FIX";
      [Token(Token = "0x4001CE0")]
      public const string COMMUNICATION_RANKUP_DESCRIPTION = "COMMUNICATION_RANKUP_DESCRIPTION";
      [Token(Token = "0x4001CE1")]
      public const string QUEST_UNLIMIT = "QUEST_UNLIMIT";
      [Token(Token = "0x4001CE2")]
      public const string NOT_HAVE_KEY = "NOT_HAVE_KEY";
      [Token(Token = "0x4001CE3")]
      public const string CONFIRM_OPEN_CHEST = "CONFIRM_OPEN_CHEST";
      [Token(Token = "0x4001CE4")]
      public const string SHOP_DESCRIPTION = "SHOP_DESCRIPTION";
      [Token(Token = "0x4001CE5")]
      public const string POCKETBOOK_CONFIRM_TIMESKIP = "POCKETBOOK_CONFIRM_TIMESKIP";
      [Token(Token = "0x4001CE6")]
      public const string POCKETBOOK_CONFIRM_AUTOMOVE = "POCKETBOOK_CONFIRM_AUTOMOVE";
      [Token(Token = "0x4001CE7")]
      public const string POCKETBOOK_CONFIRM_STORYSHOP = "POCKETBOOK_CONFIRM_STORYSHOP";
      [Token(Token = "0x4001CE8")]
      public const string POCKETBOOK_CONFIRM_FACILITY_RENTAL = "POCKETBOOK_CONFIRM_FACILITY_RENTAL";
      [Token(Token = "0x4001CE9")]
      public const string POCKETBOOK_CONFIRM_FACILITY_LOTTERY = "POCKETBOOK_CONFIRM_FACILITY_LOTTERY";
      [Token(Token = "0x4001CEA")]
      public const string POCKETBOOK_CONFIRM_FACILITY_READING = "POCKETBOOK_CONFIRM_FACILITY_READING";
      [Token(Token = "0x4001CEB")]
      public const string POCKETBOOK_BUTTON_TIMESKIP = "POCKETBOOK_BUTTON_TIMESKIP";
      [Token(Token = "0x4001CEC")]
      public const string BATTLE_ENTER = "BATTLE_ENTER";
      [Token(Token = "0x4001CED")]
      public const string FACILITY_BONUS_DAYOFWEEK = "FACILITY_BONUS_DAYOFWEEK";
      [Token(Token = "0x4001CEE")]
      public const string FACILITY_BONUS_TIMEZONE = "FACILITY_BONUS_TIMEZONE";
      [Token(Token = "0x4001CEF")]
      public const string FACILITY_BONUS_WEATHER = "FACILITY_BONUS_WEATHER";
      [Token(Token = "0x4001CF0")]
      public const string FACILITY_BONUS_NONE = "FACILITY_BONUS_NONE";
      [Token(Token = "0x4001CF1")]
      public const string RELEASE_CONDITION_CHAPTER = "RELEASE_CONDITION_CHAPTER";
      [Token(Token = "0x4001CF2")]
      public const string RELEASE_CONDITION_SEQUENCE = "RELEASE_CONDITION_SEQUENCE";
      [Token(Token = "0x4001CF3")]
      public const string REWARD_CAPTION_FIRST = "REWARD_CAPTION_FIRST";
      [Token(Token = "0x4001CF4")]
      public const string REWARD_CAPTION_COUNT = "REWARD_CAPTION_COUNT";
      [Token(Token = "0x4001CF5")]
      public const string CANNOT_EXECUTE = "CANNOT_EXECUTE";
      [Token(Token = "0x4001CF6")]
      public const string CANNOT_EXECUTE_REASON_IS_NOT_FOUND = "CANNOT_EXECUTE_REASON_IS_NOT_FOUND";
      [Token(Token = "0x4001CF7")]
      public const string CANNOT_EXECUTE_REASON_IS_EXPIRED = "CANNOT_EXECUTE_REASON_IS_EXPIRED";
      [Token(Token = "0x4001CF8")]
      public const string CANNOT_EXECUTE_REASON_IS_INVALID_TIMEZONE = "CANNOT_EXECUTE_REASON_IS_INVALID_TIMEZONE";
      [Token(Token = "0x4001CF9")]
      public const string CANNOT_EXECUTE_REASON_IS_FULLNESS = "CANNOT_EXECUTE_REASON_IS_FULLNESS";
      [Token(Token = "0x4001CFA")]
      public const string POPUP_BUTTON_BACK = "BACK_02";
      [Token(Token = "0x4001CFB")]
      public const string POPUP_BUTTON_START = "START";
      [Token(Token = "0x4001CFC")]
      public const string POPUP_BUTTON_AUTOMOVE = "MOVE_RIGHT_AWAY";
      [Token(Token = "0x4001CFD")]
      public const string POPUP_BUTTON_COMPLETE = "DONE";
      [Token(Token = "0x4001CFE")]
      public const string POPUP_BUTTON_REVOCATION = "DISPOSE";
      [Token(Token = "0x4001CFF")]
      public const string POPUP_BUTTON_MAP = "POPUP_BUTTON_MAP";
      [Token(Token = "0x4001D00")]
      public const string POPUP_BUTTON_TIMESKIP = "POPUP_BUTTON_TIMESKIP";
      [Token(Token = "0x4001D01")]
      public const string POPUP_CONFIRM_TIMESKIP = "Contents_Txt_Confirm";
      [Token(Token = "0x4001D02")]
      public const string POPUP_CONFIRM_AUTOMOVE = "POPUP_CONFIRM_AUTOMOVE";
      [Token(Token = "0x4001D03")]
      public const string POPUP_CONFIRM_STORYSHOP = "POPUP_CONFIRM_STORYSHOP";
      [Token(Token = "0x4001D04")]
      public const string POPUP_CONFIRM_BATTLE_ENTER = "POPUP_CONFIRM_BATTLE_ENTER";
      [Token(Token = "0x4001D05")]
      public const string POPUP_CONFIRM_FACILITY_RENTAL = "POPUP_CONFIRM_FACILITY_RENTAL";
      [Token(Token = "0x4001D06")]
      public const string POPUP_CONFIRM_FACILITY_LOTTERY = "POPUP_CONFIRM_FACILITY_LOTTERY";
      [Token(Token = "0x4001D07")]
      public const string POPUP_CONFIRM_FACILITY_READING = "POPUP_CONFIRM_FACILITY_READING";
      [Token(Token = "0x4001D08")]
      public const string COMMUNICATION_RANKUP_PARAM = "COMMUNICATION_RANKUP_PARAM";
      [Token(Token = "0x4001D09")]
      public const string COMMUNICATION_RANKUP_PARAM_DESCRIPTION = "COMMUNICATION_RANKUP_PARAM_DESCRIPTION";
      [Token(Token = "0x4001D0A")]
      public const string COMMUNICATION_RANKUP_COMPLEATE = "COMMUNICATION_RANKUP_COMPLEATE";
      [Token(Token = "0x4001D0B")]
      public const string SUBQUEST_CONDITION_HINT_COMMU = "SUBQUEST_CONDITION_HINT_COMMU";
      [Token(Token = "0x4001D0C")]
      public const string SUBQUEST_CONDITION_HINT_HUMAN = "SUBQUEST_CONDITION_HINT_HUMAN";
      [Token(Token = "0x4001D0D")]
      public const string POPUP_OBLIVIAE_RELEASE_CONDITION = "Popup_Obliviae_ReleaseCondition";
      [Token(Token = "0x4001D0E")]
      public const string POPUP_OBLIVIAE_RELEASE_CONDITION_RELEASE_KIZUNA = "Popup_Obliviae_ReleaseCondition_ReleaseKizuna";
      [Token(Token = "0x4001D0F")]
      public const string POPUP_OBLIVIAE_RELEASE_CONDITION_QUEST = "Popup_Obliviae_ReleaseCondition_Quest";
      [Token(Token = "0x4001D10")]
      public const string POPUP_OBLIVIAE_RELEASE_CONDITION_RANK = "Popup_Obliviae_ReleaseCondition_Rank";
      [Token(Token = "0x4001D11")]
      public const string COMMUNICATION_SKILL_LEVEL = "Text_Lv_LvSpaceNum";
    }
  }
}
