// Decompiled with JetBrains decompiler
// Type: StaqData.RuntimeDataManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using GameCore.DLC;
using GameCore.MasterData;
using GameCore.URLScheme;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using Scenes.Chat.Data;
using Scenes.Guild.Data;
using Scenes.Mission.Data;
using staq;
using StaqData.AreaQuest;
using StaqData.Badge;
using Story.StoryArchive;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200207F")]
  public class RuntimeDataManager : Singleton<RuntimeDataManager>
  {
    [Token(Token = "0x4008A46")]
    [FieldOffset(Offset = "0x28")]
    private PlayingStoryInfo storyPlaying;
    [Token(Token = "0x4008A48")]
    [FieldOffset(Offset = "0x38")]
    public SpriteAtlasUtility SpriteAtlas;
    [Token(Token = "0x4008A4D")]
    [FieldOffset(Offset = "0x60")]
    public MenuBadgeDatas MenuBadges;
    [Token(Token = "0x4008A4F")]
    [FieldOffset(Offset = "0x70")]
    public string APIServerOverride;
    [Token(Token = "0x4008A50")]
    [FieldOffset(Offset = "0x78")]
    public string RawDataServerOverride;
    [Token(Token = "0x4008A51")]
    [FieldOffset(Offset = "0x80")]
    public StoryArchivePlayer.StoryArchivePlayingInfo StoryArchivePlayingInfo;
    [Token(Token = "0x4008A52")]
    [FieldOffset(Offset = "0x88")]
    private string serviceClosedTime;
    [Token(Token = "0x4008A53")]
    [FieldOffset(Offset = "0x90")]
    private Dictionary<string, Dictionary<string, string>> TextDictionary;
    [Token(Token = "0x4008A54")]
    [FieldOffset(Offset = "0x98")]
    private Dictionary<string, Dictionary<string, TextVoice>> TextVoiceDictionary;
    [Token(Token = "0x4008A55")]
    [FieldOffset(Offset = "0xA0")]
    private bool isUpdateHomeParameter;
    [Token(Token = "0x4008A56")]
    [FieldOffset(Offset = "0xA1")]
    public bool IsOpeningAnyPurchaseShop;
    [Token(Token = "0x4008A57")]
    [FieldOffset(Offset = "0xA8")]
    public UniversalLinkEventListener UniversalLinkEventListener;
    [Token(Token = "0x4008A58")]
    [FieldOffset(Offset = "0xB0")]
    public readonly string SYSTEM_COMMON_TEXT_AB;

    [Token(Token = "0x170029EC")]
    public PlayerProfile PlayerProfile
    {
      [Token(Token = "0x600C476"), Address(RVA = "0x19F8310", Offset = "0x19F8310", VA = "0x19F8310")] get
      {
        return (PlayerProfile) null;
      }
    }

    [Token(Token = "0x170029ED")]
    public StoryInfo StoriesSetter
    {
      [Token(Token = "0x600C477"), Address(RVA = "0x19F8318", Offset = "0x19F8318", VA = "0x19F8318")] set
      {
      }
    }

    [Token(Token = "0x170029EE")]
    public StoryInfo Stories
    {
      [Token(Token = "0x600C478"), Address(RVA = "0x19F8324", Offset = "0x19F8324", VA = "0x19F8324")] get
      {
        return (StoryInfo) null;
      }
      [Token(Token = "0x600C479"), Address(RVA = "0x19F832C", Offset = "0x19F832C", VA = "0x19F832C")] private set
      {
      }
    }

    [Token(Token = "0x170029EF")]
    public SpecifiedStory MainStory
    {
      [Token(Token = "0x600C47A"), Address(RVA = "0x19F8334", Offset = "0x19F8334", VA = "0x19F8334")] get
      {
        return (SpecifiedStory) null;
      }
    }

    [Token(Token = "0x170029F0")]
    public PlayingStoryInfo Story
    {
      [Token(Token = "0x600C47B"), Address(RVA = "0x19F5E24", Offset = "0x19F5E24", VA = "0x19F5E24")] get
      {
        return (PlayingStoryInfo) null;
      }
    }

    [Token(Token = "0x170029F1")]
    public RuntimeDataValueGetter ValueGetter
    {
      [Token(Token = "0x600C47C"), Address(RVA = "0x19F833C", Offset = "0x19F833C", VA = "0x19F833C")] get
      {
        return (RuntimeDataValueGetter) null;
      }
    }

    [Token(Token = "0x170029F2")]
    public GuildDataManager GuildDataManager
    {
      [Token(Token = "0x600C47D"), Address(RVA = "0x19F8344", Offset = "0x19F8344", VA = "0x19F8344")] get
      {
        return (GuildDataManager) null;
      }
      [Token(Token = "0x600C47E"), Address(RVA = "0x19F834C", Offset = "0x19F834C", VA = "0x19F834C")] private set
      {
      }
    }

    [Token(Token = "0x170029F3")]
    public ChatDataManager ChatDataManager
    {
      [Token(Token = "0x600C47F"), Address(RVA = "0x19F8354", Offset = "0x19F8354", VA = "0x19F8354")] get
      {
        return (ChatDataManager) null;
      }
      [Token(Token = "0x600C480"), Address(RVA = "0x19F835C", Offset = "0x19F835C", VA = "0x19F835C")] private set
      {
      }
    }

    [Token(Token = "0x170029F4")]
    public MissionDataManager MissionDataManager
    {
      [Token(Token = "0x600C481"), Address(RVA = "0x19F8364", Offset = "0x19F8364", VA = "0x19F8364")] get
      {
        return (MissionDataManager) null;
      }
      [Token(Token = "0x600C482"), Address(RVA = "0x19F836C", Offset = "0x19F836C", VA = "0x19F836C")] private set
      {
      }
    }

    [Token(Token = "0x170029F5")]
    public FriendInfoManager FriendInfoManager
    {
      [Token(Token = "0x600C483"), Address(RVA = "0x19F8374", Offset = "0x19F8374", VA = "0x19F8374")] get
      {
        return (FriendInfoManager) null;
      }
      [Token(Token = "0x600C484"), Address(RVA = "0x19F837C", Offset = "0x19F837C", VA = "0x19F837C")] private set
      {
      }
    }

    [Token(Token = "0x170029F6")]
    public AreaQuestData AreaQuest
    {
      [Token(Token = "0x600C485"), Address(RVA = "0x19F8384", Offset = "0x19F8384", VA = "0x19F8384")] get
      {
        return (AreaQuestData) null;
      }
    }

    [Token(Token = "0x170029F7")]
    public bool InService
    {
      [Token(Token = "0x600C486"), Address(RVA = "0x19F838C", Offset = "0x19F838C", VA = "0x19F838C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170029F8")]
    public string ServiceClosedTime
    {
      [Token(Token = "0x600C487"), Address(RVA = "0x19F8398", Offset = "0x19F8398", VA = "0x19F8398")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600C488")]
    [Address(RVA = "0x19F83A0", Offset = "0x19F83A0", VA = "0x19F83A0")]
    public void SetInServiceClosedTime(string serviceClosedTime)
    {
    }

    [Token(Token = "0x600C489")]
    [Address(RVA = "0x19F83A8", Offset = "0x19F83A8", VA = "0x19F83A8")]
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    private static void Initialize()
    {
    }

    [Token(Token = "0x600C48A")]
    [Address(RVA = "0x19F8444", Offset = "0x19F8444", VA = "0x19F8444")]
    public void ResetAll()
    {
    }

    [Token(Token = "0x600C48B")]
    [Address(RVA = "0x19F8500", Offset = "0x19F8500", VA = "0x19F8500")]
    public RuntimeDataManager()
    {
    }

    [Token(Token = "0x600C48C")]
    [Address(RVA = "0x19F84DC", Offset = "0x19F84DC", VA = "0x19F84DC")]
    private void Release()
    {
    }

    [Token(Token = "0x600C48D")]
    [Address(RVA = "0x19F89E4", Offset = "0x19F89E4", VA = "0x19F89E4")]
    public void Update(ICommonApiResult result)
    {
    }

    [Token(Token = "0x600C48E")]
    [Address(RVA = "0x19F8AE8", Offset = "0x19F8AE8", VA = "0x19F8AE8")]
    public void UpdatePostAPIResult(IPostApiResult result)
    {
    }

    [Token(Token = "0x600C48F")]
    [Address(RVA = "0x19F8C2C", Offset = "0x19F8C2C", VA = "0x19F8C2C")]
    public void UpdateDateSets(UpdatedPlayerDataSet updatedPlayerDataSet)
    {
    }

    [Token(Token = "0x600C490")]
    [Address(RVA = "0x19F8DAC", Offset = "0x19F8DAC", VA = "0x19F8DAC")]
    public void UpdateItems(UpdatedPlayerItems updatedPlayerItems)
    {
    }

    [Token(Token = "0x600C491")]
    [Address(RVA = "0x19F8D30", Offset = "0x19F8D30", VA = "0x19F8D30")]
    public void UpdatePlayerUnits(UpdatedPlayerUnits updatedPlayerUnits)
    {
    }

    [Token(Token = "0x600C492")]
    [Address(RVA = "0x19F8C8C", Offset = "0x19F8C8C", VA = "0x19F8C8C")]
    public void UpdateEquipments(UpdatedPlayerEquipments updatedPlayerEquipments)
    {
    }

    [Token(Token = "0x600C493")]
    [Address(RVA = "0x19F21F0", Offset = "0x19F21F0", VA = "0x19F21F0")]
    public string GetText(string abName, string key) => (string) null;

    [Token(Token = "0x600C494")]
    [Address(RVA = "0x19F941C", Offset = "0x19F941C", VA = "0x19F941C")]
    public string GetTextFormat(string abName, string key, params object[] args) => (string) null;

    [Token(Token = "0x600C495")]
    [Address(RVA = "0x19F9464", Offset = "0x19F9464", VA = "0x19F9464")]
    public TextVoice GetTextVoice(string abName, string key) => (TextVoice) null;

    [Token(Token = "0x600C496")]
    [Address(RVA = "0x19F9574", Offset = "0x19F9574", VA = "0x19F9574")]
    private void LoadTextAssetSub(
      LoadedAssetBundle loadedAssetBundle,
      string assetname,
      string[] assets,
      bool isVoice)
    {
    }

    [Token(Token = "0x600C497")]
    [Address(RVA = "0x19F9E3C", Offset = "0x19F9E3C", VA = "0x19F9E3C")]
    public IEnumerator LoadTextAsset(
      (string, string[])[] loadTextAssetInfo,
      Action completeAction = null,
      bool isVoice = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600C498")]
    [Address(RVA = "0x19F9EF4", Offset = "0x19F9EF4", VA = "0x19F9EF4")]
    public void LoadTextAssetResources()
    {
    }

    [Token(Token = "0x600C499")]
    [Address(RVA = "0x19FA6BC", Offset = "0x19FA6BC", VA = "0x19FA6BC")]
    public IEnumerator LoadTextAssetAtOnce(
      string[] textAssets,
      Action completeAction = null,
      bool isVoice = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600C49A")]
    [Address(RVA = "0x19FA774", Offset = "0x19FA774", VA = "0x19FA774")]
    public void UnUseTextAsset(string assetbundleName)
    {
    }

    [Token(Token = "0x600C49B")]
    [Address(RVA = "0x19FA858", Offset = "0x19FA858", VA = "0x19FA858")]
    public void ApplyPlayerSignin(APIPlayerSigninResponse signinResponse)
    {
    }

    [Token(Token = "0x600C49C")]
    [Address(RVA = "0x19FA9A0", Offset = "0x19FA9A0", VA = "0x19FA9A0")]
    public bool IsUpdateHomeParameter() => new bool();

    [Token(Token = "0x600C49D")]
    [Address(RVA = "0x19FA9D4", Offset = "0x19FA9D4", VA = "0x19FA9D4")]
    public void ApplyHome(APIHomeResponse response)
    {
    }

    [Token(Token = "0x600C49E")]
    [Address(RVA = "0x19FAB48", Offset = "0x19FAB48", VA = "0x19FAB48")]
    public void ApplyBattleSkip(PlayerBattleSkipResult result)
    {
    }

    [Token(Token = "0x600C49F")]
    [Address(RVA = "0x19F5BF8", Offset = "0x19F5BF8", VA = "0x19F5BF8")]
    public bool CanSelectStoryMainQuestDifficulty(QuestDifficultyTypeEnum type) => new bool();
  }
}
