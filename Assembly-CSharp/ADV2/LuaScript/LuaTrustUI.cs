// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaTrustUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine.Timeline;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EE5")]
  [MoonSharpUserData]
  public class LuaTrustUI : LuaUI
  {
    [Token(Token = "0x40113B2")]
    private const string s_trustTopTag = "TrustTop";
    [Token(Token = "0x40113B3")]
    private const string s_characterNameTag = "CharacterName";
    [Token(Token = "0x40113B4")]
    private const string s_characterNameJTag = "CharacterName_J";
    [Token(Token = "0x40113B5")]
    private const string s_rankTag = "Rank";
    [Token(Token = "0x40113B6")]
    private const string s_unlockRankTag = "UnlockRank";
    [Token(Token = "0x40113B7")]
    private const string s_characterImageTag = "CharacterImage";
    [Token(Token = "0x40113B8")]
    private const string s_abilityNameTag = "AbilityName";
    [Token(Token = "0x40113B9")]
    private const string s_abilityInfoTag = "AbilityInfo";
    [Token(Token = "0x40113BA")]
    private const string s_itemInfoTag = "ItemInfo";
    [Token(Token = "0x40113BB")]
    private const string s_itemIconTag = "ItemIcon";
    [Token(Token = "0x40113BC")]
    private const string s_skillNameTag = "SkillName";
    [Token(Token = "0x40113BD")]
    private const string s_skillInfoTag = "SkillInfo";
    [Token(Token = "0x40113BE")]
    private const string s_skillIconTag = "SkillIcon";
    [Token(Token = "0x40113BF")]
    private const string s_skillLevelTag = "SkillLevel";
    [Token(Token = "0x40113C0")]
    private const string s_styleInfoTag = "StyleInfo";
    [Token(Token = "0x40113C1")]
    private const string s_styleIconTag = "StyleIcon";
    [Token(Token = "0x40113C2")]
    private const string s_tlTrackAbility = "Get_Ability";
    [Token(Token = "0x40113C3")]
    private const string s_tlTrackSkill = "Get_Skill";
    [Token(Token = "0x40113C4")]
    private const string s_tlTrackItem = "Get_Item";
    [Token(Token = "0x40113C5")]
    private const string s_tlTrackStyle = "Get_Style";
    [Token(Token = "0x40113C6")]
    private const string s_tlTrackRankUP = "RANKUP";
    [Token(Token = "0x40113C7")]
    private const string s_tlTrackUnlocked = "UNLOCKED";
    [Token(Token = "0x40113C8")]
    private const string s_abilityTopTag = "AbilityTop";
    [Token(Token = "0x40113C9")]
    private const string s_itemTopTag = "ItemTop";
    [Token(Token = "0x40113CA")]
    private const string s_skillTopTag = "SkillTop";
    [Token(Token = "0x40113CB")]
    private const string s_styleTopTag = "StyleTop";
    [Token(Token = "0x40113CC")]
    private const string s_rewardIconTag = "RewardIcon";
    [Token(Token = "0x40113CD")]
    [FieldOffset(Offset = "0x40")]
    private TimelineAsset timelineAsset;
    [Token(Token = "0x40113CE")]
    [FieldOffset(Offset = "0x48")]
    private IEnumerable<TrackAsset> trackAssets;
    [Token(Token = "0x40113CF")]
    [FieldOffset(Offset = "0x50")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;

    [Token(Token = "0x6019672")]
    [Address(RVA = "0x37345DC", Offset = "0x37345DC", VA = "0x37345DC")]
    public LuaTrustUI(Adv2Trust instance)
    {
    }

    [Token(Token = "0x6019673")]
    [Address(RVA = "0x3734624", Offset = "0x3734624", VA = "0x3734624")]
    public LuaSignalMini Init(LuaHuman human, LuaSequence.ParamControl.ComuParam param)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019674")]
    [Address(RVA = "0x3735550", Offset = "0x3735550", VA = "0x3735550")]
    private IEnumerator LoadAsync(Adv2Manager.OnProccessSignal initSignal) => (IEnumerator) null;

    [Token(Token = "0x6019675")]
    [Address(RVA = "0x3735210", Offset = "0x3735210", VA = "0x3735210")]
    private void SetTimelineTrackMule(string name, bool sw)
    {
    }

    [Token(Token = "0x6019676")]
    [Address(RVA = "0x37355EC", Offset = "0x37355EC", VA = "0x37355EC")]
    private void SetTimelineTrackMutelChild(TrackAsset parentTrack, bool sw)
    {
    }

    [Token(Token = "0x6019677")]
    [Address(RVA = "0x37358F8", Offset = "0x37358F8", VA = "0x37358F8")]
    private void OnClickItemDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6019678")]
    [Address(RVA = "0x3735998", Offset = "0x3735998", VA = "0x3735998")]
    private void CloseItemDetailPopup()
    {
    }

    [Token(Token = "0x6019679")]
    [Address(RVA = "0x37359AC", Offset = "0x37359AC", VA = "0x37359AC")]
    public void SetRewardPanel(int index)
    {
    }

    [Token(Token = "0x601967A")]
    [Address(RVA = "0x3735F3C", Offset = "0x3735F3C", VA = "0x3735F3C")]
    private void SetOnClickAction(RewardTypeEnum type, int rewardId)
    {
    }

    [Token(Token = "0x601967B")]
    [Address(RVA = "0x373607C", Offset = "0x373607C", VA = "0x373607C")]
    public void PlayRewardIn(int index, bool isFarst)
    {
    }

    [Token(Token = "0x601967C")]
    [Address(RVA = "0x3736370", Offset = "0x3736370", VA = "0x3736370")]
    public void PlayRewardOut(int index)
    {
    }

    [Token(Token = "0x601967D")]
    [Address(RVA = "0x373649C", Offset = "0x373649C", VA = "0x373649C")]
    public void SetActiveRewardPanel(int index, bool sw)
    {
    }
  }
}
