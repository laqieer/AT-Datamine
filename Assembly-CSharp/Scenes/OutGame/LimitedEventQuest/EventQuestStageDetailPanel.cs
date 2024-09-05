// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.LimitedEventQuest.EventQuestStageDetailPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.APRecovery;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UI.ItemDetail;
using UI.Utilities.SerializeUI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Pool;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.LimitedEventQuest
{
  [Token(Token = "0x2003631")]
  public class EventQuestStageDetailPanel : MonoBehaviour
  {
    [Token(Token = "0x400EBAF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tween;
    [Token(Token = "0x400EBB0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITimelineController panelFade;
    [Token(Token = "0x400EBB1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400EBB2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<CommonButton> startButtons;
    [Token(Token = "0x400EBB3")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image questStageThumbnail;
    [Token(Token = "0x400EBB4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ActiveObjectContainers apIconViewContainer;
    [Token(Token = "0x400EBB5")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton battleDetailButton;
    [Token(Token = "0x400EBB6")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextContainer stageNameText;
    [Token(Token = "0x400EBB7")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ScrollRect rewardCScrollRect;
    [Token(Token = "0x400EBB8")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<RectTransform> rewardHeaderTransform;
    [Token(Token = "0x400EBB9")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private List<RectTransform> rewardRootTransform;
    [Token(Token = "0x400EBBA")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject itemPrefabRootObject;
    [Token(Token = "0x400EBBB")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Image staminaItem;
    [Token(Token = "0x400EBBC")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text staminaInfoText;
    [Token(Token = "0x400EBBD")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject missionRootObject;
    [Token(Token = "0x400EBBE")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ActiveObjectContainers missionActiveContainers;
    [Token(Token = "0x400EBBF")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400EBC0")]
    [FieldOffset(Offset = "0xA0")]
    private QuestInfo questInfo;
    [Token(Token = "0x400EBC1")]
    [FieldOffset(Offset = "0xA8")]
    private int consumeCostItemId;
    [Token(Token = "0x400EBC2")]
    [FieldOffset(Offset = "0xAC")]
    private BattleComsumeCostTypeEnum consumeCostType;
    [Token(Token = "0x400EBC3")]
    [FieldOffset(Offset = "0xB0")]
    private int consumeCost;
    [Token(Token = "0x400EBC4")]
    [FieldOffset(Offset = "0xB8")]
    private UnityAction battleDetailEvnet;
    [Token(Token = "0x400EBC5")]
    [FieldOffset(Offset = "0xC0")]
    private EventQuestStageThumbnail stageThumbnail;
    [Token(Token = "0x400EBC6")]
    [FieldOffset(Offset = "0xC8")]
    private UnityAction<EventQuestStageThumbnail> battleStartEvnet;
    [Token(Token = "0x400EBC7")]
    [FieldOffset(Offset = "0xD0")]
    private UnityAction backButtonEvent;
    [Token(Token = "0x400EBC8")]
    [FieldOffset(Offset = "0xD8")]
    private List<string> tweenPlayList;
    [Token(Token = "0x400EBC9")]
    [FieldOffset(Offset = "0xE0")]
    private List<ItemIcon> activeitemIcons;
    [Token(Token = "0x400EBCA")]
    [FieldOffset(Offset = "0xE8")]
    private IObjectPool<ItemIcon> itemIconPool;
    [Token(Token = "0x400EBCB")]
    [FieldOffset(Offset = "0xF0")]
    private (int categoryType, RewardTypeEnum rewardType, int rewardId) createReward;
    [Token(Token = "0x400EBCC")]
    [FieldOffset(Offset = "0x100")]
    private ApRecoveryHeader apHeader;
    [Token(Token = "0x400EBCD")]
    [FieldOffset(Offset = "0x108")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400EBCE")]
    [FieldOffset(Offset = "0x110")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;

    [Token(Token = "0x170046F5")]
    public bool IsInitialized
    {
      [Token(Token = "0x6015572"), Address(RVA = "0x4D9CD94", Offset = "0x4D9CD94", VA = "0x4D9CD94")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170046F6")]
    public bool IsEnableButton
    {
      [Token(Token = "0x6015573"), Address(RVA = "0x4D9CDB0", Offset = "0x4D9CDB0", VA = "0x4D9CDB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6015574")]
    [Address(RVA = "0x4D9CDF4", Offset = "0x4D9CDF4", VA = "0x4D9CDF4")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6015575")]
    [Address(RVA = "0x4D9CF18", Offset = "0x4D9CF18", VA = "0x4D9CF18")]
    public IEnumerator Initialize(
      AssetCachedSpawner assetCachedSpawner,
      UnityAction topSceneReturnEvent)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015576")]
    [Address(RVA = "0x4D9CF94", Offset = "0x4D9CF94", VA = "0x4D9CF94")]
    public void SetUp(
      EventQuestStageThumbnail thumbnail,
      QuestInfo questInfo,
      int eventQuestStageId,
      int consumeCostItemId,
      BattleComsumeCostTypeEnum consumeCostType,
      int consumeCost,
      string stageName,
      Sprite thumbnailSprite,
      Sprite staminaItemSprite,
      List<bool> missionClears,
      HashSet<(int rewardType, List<(RewardTypeEnum type, int Id)> rewards)> rewardInformations,
      bool stageLock,
      bool bossIcon,
      ApRecoveryHeader apHeader,
      UnityAction<EventQuestStageThumbnail> battleStartEvnet,
      UnityAction battleDetailEvnet)
    {
    }

    [Token(Token = "0x6015577")]
    [Address(RVA = "0x4D9DC74", Offset = "0x4D9DC74", VA = "0x4D9DC74")]
    public void Show(Action callback = null)
    {
    }

    [Token(Token = "0x6015578")]
    [Address(RVA = "0x4D9DCDC", Offset = "0x4D9DCDC", VA = "0x4D9DCDC")]
    public void Hide(Action callback = null)
    {
    }

    [Token(Token = "0x6015579")]
    [Address(RVA = "0x4D9DDCC", Offset = "0x4D9DDCC", VA = "0x4D9DDCC")]
    private void BackButtonEvent()
    {
    }

    [Token(Token = "0x601557A")]
    [Address(RVA = "0x4D9DE78", Offset = "0x4D9DE78", VA = "0x4D9DE78")]
    private void BattleStartButtonEvent()
    {
    }

    [Token(Token = "0x601557B")]
    [Address(RVA = "0x4D9DF48", Offset = "0x4D9DF48", VA = "0x4D9DF48")]
    private void BattleDetailButtonEvent()
    {
    }

    [Token(Token = "0x601557C")]
    [Address(RVA = "0x4D9DB38", Offset = "0x4D9DB38", VA = "0x4D9DB38")]
    public void AddTweenPlayList(string groupId)
    {
    }

    [Token(Token = "0x601557D")]
    [Address(RVA = "0x4D9DBE8", Offset = "0x4D9DBE8", VA = "0x4D9DBE8")]
    public void PlayTweenPlayList()
    {
    }

    [Token(Token = "0x601557E")]
    [Address(RVA = "0x4D9DF8C", Offset = "0x4D9DF8C", VA = "0x4D9DF8C")]
    public void ResetTweenPlayList(bool isRollback)
    {
    }

    [Token(Token = "0x601557F")]
    [Address(RVA = "0x4D9E11C", Offset = "0x4D9E11C", VA = "0x4D9E11C")]
    public void SetButtonEnable(bool enable)
    {
    }

    [Token(Token = "0x6015580")]
    [Address(RVA = "0x4D9E224", Offset = "0x4D9E224", VA = "0x4D9E224")]
    public EventQuestStageDetailPanel()
    {
    }
  }
}
