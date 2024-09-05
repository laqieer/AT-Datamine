// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.LimitedEventQuest.LimitedEventQuestStageSelectPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.APRecovery;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UI.Utilities.SerializeUI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.LimitedEventQuest
{
  [Token(Token = "0x200363D")]
  public class LimitedEventQuestStageSelectPanel : MonoBehaviour
  {
    [Token(Token = "0x400EBFC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private EventQuestStageDetailPanel detailPanel;
    [Token(Token = "0x400EBFD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITimelineController panelFade;
    [Token(Token = "0x400EBFE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400EBFF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton exchangeButton;
    [Token(Token = "0x400EC00")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton shopButton;
    [Token(Token = "0x400EC01")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton missionButton;
    [Token(Token = "0x400EC02")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextContainer eventEndAt;
    [Token(Token = "0x400EC03")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private EventQuestStageContainer stageCloneBase;
    [Token(Token = "0x400EC04")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ScrollRect selectStageScroll;
    [Token(Token = "0x400EC05")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private RawImage titleRawImage;
    [Token(Token = "0x400EC06")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private ActiveObjectContainers consumeCostTypeViewObjects;
    [Token(Token = "0x400EC07")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private ApRecoveryHeader apHeader;
    [Token(Token = "0x400EC08")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private StaminaItemPopUpButton staminaPopUpButton;
    [Token(Token = "0x400EC09")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400EC0A")]
    [FieldOffset(Offset = "0x88")]
    private UnityAction backButtonEvent;
    [Token(Token = "0x400EC0B")]
    [FieldOffset(Offset = "0x90")]
    private List<EventQuestStageContainer> stageContainers;
    [Token(Token = "0x400EC0C")]
    [FieldOffset(Offset = "0x98")]
    private List<EventQuestStageThumbnail> stageThumbnails;
    [Token(Token = "0x400EC0D")]
    [FieldOffset(Offset = "0xA0")]
    private int shopId;
    [Token(Token = "0x400EC0E")]
    [FieldOffset(Offset = "0xA4")]
    private int exchangeId;
    [Token(Token = "0x400EC0F")]
    [FieldOffset(Offset = "0xA8")]
    private int missionId;
    [Token(Token = "0x400EC10")]
    [FieldOffset(Offset = "0xB0")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x170046FA")]
    public bool IsInitialized
    {
      [Token(Token = "0x60155B1"), Address(RVA = "0x18D4208", Offset = "0x18D4208", VA = "0x18D4208")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170046FB")]
    public bool IsEnableButton
    {
      [Token(Token = "0x60155B2"), Address(RVA = "0x18D4248", Offset = "0x18D4248", VA = "0x18D4248")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60155B3")]
    [Address(RVA = "0x18D428C", Offset = "0x18D428C", VA = "0x18D428C")]
    public IEnumerator Initialize(
      AssetCachedSpawner assetCachedSpawner,
      UnityAction backButtonEvent)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60155B4")]
    [Address(RVA = "0x18D4330", Offset = "0x18D4330", VA = "0x18D4330")]
    public void Show(Texture2D titleTexture, Action callback = null)
    {
    }

    [Token(Token = "0x60155B5")]
    [Address(RVA = "0x18D443C", Offset = "0x18D443C", VA = "0x18D443C")]
    public void Hide(Action callback = null)
    {
    }

    [Token(Token = "0x60155B6")]
    [Address(RVA = "0x18D452C", Offset = "0x18D452C", VA = "0x18D452C")]
    public void SetUp(
      ILimitedEventQuest limitedEventQuest,
      int eventId,
      BattleComsumeCostTypeEnum comsumeCostType,
      DateTime? eventEndAt,
      Sprite staminaItemSprite,
      int staminaItemHolds,
      int staminaItemReplenishmentCount,
      int shopId,
      int exchangeId,
      int missionId)
    {
    }

    [Token(Token = "0x60155B7")]
    [Address(RVA = "0x18D4E78", Offset = "0x18D4E78", VA = "0x18D4E78")]
    private IEnumerator OpenQuestDetailPopup(int questId, int consumeCostItemId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60155B8")]
    [Address(RVA = "0x18D4F1C", Offset = "0x18D4F1C", VA = "0x18D4F1C")]
    public void SetNextScene()
    {
    }

    [Token(Token = "0x60155B9")]
    [Address(RVA = "0x18D4F3C", Offset = "0x18D4F3C", VA = "0x18D4F3C")]
    public void SetBackScene()
    {
    }

    [Token(Token = "0x60155BA")]
    [Address(RVA = "0x18D4F5C", Offset = "0x18D4F5C", VA = "0x18D4F5C")]
    private void BackButtonEvent()
    {
    }

    [Token(Token = "0x60155BB")]
    [Address(RVA = "0x18D4FF4", Offset = "0x18D4FF4", VA = "0x18D4FF4")]
    private void ExchangeButtonEvent()
    {
    }

    [Token(Token = "0x60155BC")]
    [Address(RVA = "0x18D5174", Offset = "0x18D5174", VA = "0x18D5174")]
    private void ShopButtonEvent()
    {
    }

    [Token(Token = "0x60155BD")]
    [Address(RVA = "0x18D5250", Offset = "0x18D5250", VA = "0x18D5250")]
    private IEnumerator MoveShopSceneSetUp() => (IEnumerator) null;

    [Token(Token = "0x60155BE")]
    [Address(RVA = "0x18D52E0", Offset = "0x18D52E0", VA = "0x18D52E0")]
    private void MissionButtonEvent()
    {
    }

    [Token(Token = "0x60155BF")]
    [Address(RVA = "0x18D5458", Offset = "0x18D5458", VA = "0x18D5458")]
    public LimitedEventQuestStageSelectPanel()
    {
    }
  }
}
