// Decompiled with JetBrains decompiler
// Type: Story.Adv.LuaObjects.CommonFunctions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.LuaScript;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Story.Adv.LuaObjects
{
  [Token(Token = "0x2000757")]
  public static class CommonFunctions
  {
    [Token(Token = "0x600292C")]
    [Address(RVA = "0x367D5BC", Offset = "0x367D5BC", VA = "0x367D5BC")]
    public static LuaSequence.ParamControl.HumanParameter GetHumanParamCommon(
      int rewardID,
      Facility.BonusInfo bonus = null,
      BuffItem[] buffItems = null)
    {
      return (LuaSequence.ParamControl.HumanParameter) null;
    }

    [Token(Token = "0x600292D")]
    [Address(RVA = "0x367E75C", Offset = "0x367E75C", VA = "0x367E75C")]
    public static bool ContainsHumanParameterReward(int rewardID, Facility.BonusInfo bonus = null)
    {
      return new bool();
    }

    [Token(Token = "0x600292E")]
    [Address(RVA = "0x367ED24", Offset = "0x367ED24", VA = "0x367ED24")]
    public static Ability[] GetAbilities(int rewardID) => (Ability[]) null;

    [Token(Token = "0x600292F")]
    [Address(RVA = "0x367F0EC", Offset = "0x367F0EC", VA = "0x367F0EC")]
    public static LuaRewardItem[] GetItemRewards(int rewardID) => (LuaRewardItem[]) null;

    [Token(Token = "0x6002930")]
    [Address(RVA = "0x367C440", Offset = "0x367C440", VA = "0x367C440")]
    public static CommuCharacter[] GetCommuCharacters() => (CommuCharacter[]) null;

    [Token(Token = "0x6002931")]
    [Address(RVA = "0x367C93C", Offset = "0x367C93C", VA = "0x367C93C")]
    public static Book[] GetRentalBooks() => (Book[]) null;

    [Token(Token = "0x6002932")]
    [Address(RVA = "0x367AAF0", Offset = "0x367AAF0", VA = "0x367AAF0")]
    public static Book CreateLuaBookObject(BookInfo book) => (Book) null;

    [Token(Token = "0x6002933")]
    [Address(RVA = "0x367A550", Offset = "0x367A550", VA = "0x367A550")]
    public static Book[] GetUserBooks() => (Book[]) null;

    [Token(Token = "0x6002934")]
    [Address(RVA = "0x367C048", Offset = "0x367C048", VA = "0x367C048")]
    public static bool IsValidMenu(StoryFacilityMenuData menu) => new bool();

    [Token(Token = "0x6002935")]
    [Address(RVA = "0x367F618", Offset = "0x367F618", VA = "0x367F618")]
    public static bool IsValidSeason(int beginCalendarID, int endCalendarID) => new bool();

    [Token(Token = "0x6002936")]
    [Address(RVA = "0x367E6D8", Offset = "0x367E6D8", VA = "0x367E6D8")]
    public static bool CheckAbility(int storyAbilityID) => new bool();

    [Token(Token = "0x6002937")]
    [Address(RVA = "0x367F6BC", Offset = "0x367F6BC", VA = "0x367F6BC")]
    public static bool HasCost(int costLabel) => new bool();
  }
}
