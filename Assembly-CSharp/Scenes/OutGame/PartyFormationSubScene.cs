// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PartyFormationSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using QuestPrepare;
using System;
using System.Collections;
using System.Collections.Generic;
using TeamOrganization;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20032AB")]
  public class PartyFormationSubScene : SubScene
  {
    [Token(Token = "0x400D954")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    protected PartyFomationView partyFomationView;
    [Token(Token = "0x400D955")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    protected GameObject loadingPanel;
    [Token(Token = "0x400D956")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    protected AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D957")]
    protected const string UnitNumberAssetBundleName = "ui_page_partylist";
    [Token(Token = "0x400D958")]
    [FieldOffset(Offset = "0x70")]
    protected readonly string[] InfoPopupAssetBundles;
    [Token(Token = "0x400D959")]
    [FieldOffset(Offset = "0x78")]
    private List<string> loadedAssetBundleNameList;
    [Token(Token = "0x400D95A")]
    [FieldOffset(Offset = "0x80")]
    protected int SelectId;
    [Token(Token = "0x400D95B")]
    [FieldOffset(Offset = "0x84")]
    protected DeckTypeEnum deckType;
    [Token(Token = "0x400D95C")]
    [FieldOffset(Offset = "0x88")]
    protected bool isTeamEdit;
    [Token(Token = "0x400D95D")]
    [FieldOffset(Offset = "0x89")]
    protected bool isFromNeedLpQuest;
    [Token(Token = "0x400D95E")]
    [FieldOffset(Offset = "0x90")]
    private Coroutine requestStoryInfoAsync;
    [Token(Token = "0x400D95F")]
    [FieldOffset(Offset = "0x98")]
    private bool isGuildRaid;
    [Token(Token = "0x400D960")]
    [FieldOffset(Offset = "0xA0")]
    private List<string> usedStyleIds;

    [Token(Token = "0x6013C67")]
    [Address(RVA = "0x1ADC2A8", Offset = "0x1ADC2A8", VA = "0x1ADC2A8", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6013C68")]
    [Address(RVA = "0x1ADC46C", Offset = "0x1ADC46C", VA = "0x1ADC46C", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6013C69")]
    [Address(RVA = "0x1ADC4FC", Offset = "0x1ADC4FC", VA = "0x1ADC4FC")]
    protected void BaseInitialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6013C6A")]
    [Address(RVA = "0x1ADC504", Offset = "0x1ADC504", VA = "0x1ADC504")]
    protected void OnLoadComplete(List<string> succeedList, Dictionary<string, string> failedDic)
    {
    }

    [Token(Token = "0x6013C6B")]
    [Address(RVA = "0x1ADC5D8", Offset = "0x1ADC5D8", VA = "0x1ADC5D8", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6013C6C")]
    [Address(RVA = "0x1ADC608", Offset = "0x1ADC608", VA = "0x1ADC608", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6013C6D")]
    [Address(RVA = "0x1ADC7FC", Offset = "0x1ADC7FC", VA = "0x1ADC7FC", Slot = "32")]
    public virtual void OnClickBack()
    {
    }

    [Token(Token = "0x6013C6E")]
    [Address(RVA = "0x1ADC8E8", Offset = "0x1ADC8E8", VA = "0x1ADC8E8")]
    private void OnClickBackToHome()
    {
    }

    [Token(Token = "0x6013C6F")]
    [Address(RVA = "0x1ADC9D4", Offset = "0x1ADC9D4", VA = "0x1ADC9D4")]
    protected void LoadAutoFormationLoadAsset(OrganizationTeam organizationTeam, Action action)
    {
    }

    [Token(Token = "0x6013C70")]
    [Address(RVA = "0x1ADC9F4", Offset = "0x1ADC9F4", VA = "0x1ADC9F4")]
    public IEnumerator LoadAutoFormationLoadAssetData(
      OrganizationTeam organizationTeam,
      Action action)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013C71")]
    [Address(RVA = "0x1ADCA98", Offset = "0x1ADCA98", VA = "0x1ADCA98")]
    protected void SetLoadDeckAssetData(OrganizationTeam organizationTeam)
    {
    }

    [Token(Token = "0x6013C72")]
    [Address(RVA = "0x1ADDA24", Offset = "0x1ADDA24", VA = "0x1ADDA24", Slot = "33")]
    protected virtual IEnumerator LoadDeckAssetData() => (IEnumerator) null;

    [Token(Token = "0x6013C73")]
    [Address(RVA = "0x1ADDA2C", Offset = "0x1ADDA2C", VA = "0x1ADDA2C", Slot = "34")]
    public virtual void ChangeTemplate(int templateId)
    {
    }

    [Token(Token = "0x6013C74")]
    [Address(RVA = "0x1ADDA30", Offset = "0x1ADDA30", VA = "0x1ADDA30")]
    public PartyFormationSubScene()
    {
    }

    [Token(Token = "0x20032AC")]
    public class PartyFormationSubSceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x400D96D")]
      [FieldOffset(Offset = "0x48")]
      public DeckTypeEnum deckType;

      [Token(Token = "0x17004191")]
      public int SelectTeamId
      {
        [Token(Token = "0x6013C75"), Address(RVA = "0x1ADDBD4", Offset = "0x1ADDBD4", VA = "0x1ADDBD4")] get
        {
          return new int();
        }
        [Token(Token = "0x6013C76"), Address(RVA = "0x1ADDBDC", Offset = "0x1ADDBDC", VA = "0x1ADDBDC")] private set
        {
        }
      }

      [Token(Token = "0x17004192")]
      public bool IsFromNeedLpQuest
      {
        [Token(Token = "0x6013C77"), Address(RVA = "0x1ADDBE4", Offset = "0x1ADDBE4", VA = "0x1ADDBE4")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17004193")]
      public bool IsOpenAutoFormation
      {
        [Token(Token = "0x6013C78"), Address(RVA = "0x1ADDBEC", Offset = "0x1ADDBEC", VA = "0x1ADDBEC")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17004194")]
      public bool IsQuest
      {
        [Token(Token = "0x6013C79"), Address(RVA = "0x1ADDBF4", Offset = "0x1ADDBF4", VA = "0x1ADDBF4")] get
        {
          return new bool();
        }
        [Token(Token = "0x6013C7A"), Address(RVA = "0x1ADDBFC", Offset = "0x1ADDBFC", VA = "0x1ADDBFC")] private set
        {
        }
      }

      [Token(Token = "0x17004195")]
      public bool IsArena
      {
        [Token(Token = "0x6013C7B"), Address(RVA = "0x1ADDC08", Offset = "0x1ADDC08", VA = "0x1ADDC08")] get
        {
          return new bool();
        }
        [Token(Token = "0x6013C7C"), Address(RVA = "0x1ADDC10", Offset = "0x1ADDC10", VA = "0x1ADDC10")] private set
        {
        }
      }

      [Token(Token = "0x17004196")]
      public int MenberNum
      {
        [Token(Token = "0x6013C7D"), Address(RVA = "0x1ADDC1C", Offset = "0x1ADDC1C", VA = "0x1ADDC1C")] get
        {
          return new int();
        }
        [Token(Token = "0x6013C7E"), Address(RVA = "0x1ADDC24", Offset = "0x1ADDC24", VA = "0x1ADDC24")] private set
        {
        }
      }

      [Token(Token = "0x17004197")]
      public ElementTypeEnum EnemyElement
      {
        [Token(Token = "0x6013C7F"), Address(RVA = "0x1ADDC2C", Offset = "0x1ADDC2C", VA = "0x1ADDC2C")] get
        {
          return new ElementTypeEnum();
        }
        [Token(Token = "0x6013C80"), Address(RVA = "0x1ADDC34", Offset = "0x1ADDC34", VA = "0x1ADDC34")] private set
        {
        }
      }

      [Token(Token = "0x17004198")]
      public BattleSortieRestrictionsCheck BattleSortieRestrictionsCheck
      {
        [Token(Token = "0x6013C81"), Address(RVA = "0x1ADDC3C", Offset = "0x1ADDC3C", VA = "0x1ADDC3C")] get
        {
          return (BattleSortieRestrictionsCheck) null;
        }
        [Token(Token = "0x6013C82"), Address(RVA = "0x1ADDC44", Offset = "0x1ADDC44", VA = "0x1ADDC44")] private set
        {
        }
      }

      [Token(Token = "0x17004199")]
      public BattleForcedSortieCheck BattleForcedSortieCheck
      {
        [Token(Token = "0x6013C83"), Address(RVA = "0x1ADDC4C", Offset = "0x1ADDC4C", VA = "0x1ADDC4C")] get
        {
          return (BattleForcedSortieCheck) null;
        }
        [Token(Token = "0x6013C84"), Address(RVA = "0x1ADDC54", Offset = "0x1ADDC54", VA = "0x1ADDC54")] private set
        {
        }
      }

      [Token(Token = "0x1700419A")]
      public bool IsGuildRaid
      {
        [Token(Token = "0x6013C85"), Address(RVA = "0x1ADDC5C", Offset = "0x1ADDC5C", VA = "0x1ADDC5C")] get
        {
          return new bool();
        }
        [Token(Token = "0x6013C86"), Address(RVA = "0x1ADDC64", Offset = "0x1ADDC64", VA = "0x1ADDC64")] set
        {
        }
      }

      [Token(Token = "0x1700419B")]
      public bool CanUseItem
      {
        [Token(Token = "0x6013C87"), Address(RVA = "0x1ADDC70", Offset = "0x1ADDC70", VA = "0x1ADDC70")] get
        {
          return new bool();
        }
        [Token(Token = "0x6013C88"), Address(RVA = "0x1ADDC78", Offset = "0x1ADDC78", VA = "0x1ADDC78")] set
        {
        }
      }

      [Token(Token = "0x1700419C")]
      public List<string> UsedStyleIds
      {
        [Token(Token = "0x6013C89"), Address(RVA = "0x1ADDC84", Offset = "0x1ADDC84", VA = "0x1ADDC84")] get
        {
          return (List<string>) null;
        }
        [Token(Token = "0x6013C8A"), Address(RVA = "0x1ADDC8C", Offset = "0x1ADDC8C", VA = "0x1ADDC8C")] set
        {
        }
      }

      [Token(Token = "0x6013C8B")]
      [Address(RVA = "0x1ADDC94", Offset = "0x1ADDC94", VA = "0x1ADDC94")]
      public PartyFormationSubSceneParam(
        int selectId,
        bool isFromNeedLpQuest = false,
        bool isOpenAutoFormation = false)
      {
      }

      [Token(Token = "0x6013C8C")]
      [Address(RVA = "0x1ADDDB0", Offset = "0x1ADDDB0", VA = "0x1ADDDB0")]
      public PartyFormationSubSceneParam(
        int deckIndex,
        DeckTypeEnum deckType,
        int memberNum,
        bool autoFormation = false)
      {
      }

      [Token(Token = "0x6013C8D")]
      [Address(RVA = "0x1ADDEDC", Offset = "0x1ADDEDC", VA = "0x1ADDEDC")]
      public void SetQuestData(
        int menberNum,
        ElementTypeEnum enemyElement,
        BattleSortieRestrictionsCheck battleSortieRestrictionsCheck,
        BattleForcedSortieCheck battleForcedSortieCheck)
      {
      }
    }
  }
}
