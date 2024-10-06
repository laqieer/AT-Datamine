// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Main.ExpeditionTopScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.Expedition.ExpeditionBox;
using Scenes.Expedition.ExpeditionTank;
using Scenes.Expedition.Popup;
using Scenes.Expedition.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Main
{
  [Token(Token = "0x2002CCF")]
  public class ExpeditionTopScene : SubScene
  {
    [Token(Token = "0x400BF82")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject orthographicCanvas;
    [Token(Token = "0x400BF83")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonGesturePanel commonGesturePanel;
    [Token(Token = "0x400BF84")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Slider[] sliderSoulTanks;
    [Token(Token = "0x400BF85")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private SnapScrollRect snapScrollRect;
    [Token(Token = "0x400BF86")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private PlayableDirector safeAreaPD;
    [Token(Token = "0x400BF87")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private PlayableDirector expeditionBoxTimeLine;
    [Token(Token = "0x400BF88")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton buttonPrev;
    [Token(Token = "0x400BF89")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton buttonNext;
    [Token(Token = "0x400BF8A")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject prefabExpeditionTankPopup;
    [Token(Token = "0x400BF8B")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonButton expeditionOrganizationButton;
    [Token(Token = "0x400BF8C")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private CommonButton highSpeedExpeditionButton;
    [Token(Token = "0x400BF8D")]
    [FieldOffset(Offset = "0xB0")]
    private ExpeditionTankPopup expeditionTankPopup;
    [Token(Token = "0x400BF8E")]
    [FieldOffset(Offset = "0xB8")]
    private ShortcutExpeditionPopup popupShortcutExpedition;
    [Token(Token = "0x400BF8F")]
    [FieldOffset(Offset = "0xC0")]
    private ShortcutExpeditionCoinConfirmPopup popupExpeditionCoinConfirm;
    [Token(Token = "0x400BF90")]
    [FieldOffset(Offset = "0xC8")]
    private ShortcutExpeditionTicketConfirmPopup popupExpeditionTicketConfirm;
    [Token(Token = "0x400BF91")]
    [FieldOffset(Offset = "0xD0")]
    private ExpeditionSceneParameter sceneParameter;
    [Token(Token = "0x400BF92")]
    [FieldOffset(Offset = "0xD8")]
    private int partyCountMax;
    [Token(Token = "0x400BF93")]
    [FieldOffset(Offset = "0xDC")]
    private bool openBossListDirty;
    [Token(Token = "0x400BF94")]
    [FieldOffset(Offset = "0xDD")]
    private bool isEffectPlaying;
    [Token(Token = "0x400BF95")]
    [FieldOffset(Offset = "0xDE")]
    private bool isAutoOpenPopup;
    [Token(Token = "0x400BF96")]
    [FieldOffset(Offset = "0xE0")]
    private int partyIndex;
    [Token(Token = "0x400BF97")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private GameObject objDestination;
    [Token(Token = "0x400BF98")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private GameObject objDestinationInfoIcon;
    [Token(Token = "0x400BF99")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private TextMeshProUGUI textPartyNumber;
    [Token(Token = "0x400BF9A")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private TextMeshProUGUI textDestination;
    [Token(Token = "0x400BF9B")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private TextMeshProUGUI textName;
    [Token(Token = "0x400BF9C")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private Image imageDestination;
    [Token(Token = "0x400BF9D")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private TextMeshProUGUI textLevel;
    [Token(Token = "0x400BF9E")]
    [FieldOffset(Offset = "0x120")]
    private ExpeditionBoxPopup expeditionBoxPopup;
    [Token(Token = "0x400BF9F")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private GameObject prefabExpeditionBoxPopup;
    [Token(Token = "0x400BFA0")]
    [FieldOffset(Offset = "0x130")]
    private Action onCollectionBox;
    [Token(Token = "0x400BFA1")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private BattlePartyPlayerSlot[] prefabPlayerSlots;
    [Token(Token = "0x400BFA2")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private Transform blueSoulGauge;
    [Token(Token = "0x400BFA3")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private Transform redSoulGauge;
    [Token(Token = "0x400BFA4")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private Transform blueSoulGauge2;
    [Token(Token = "0x400BFA5")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private Transform redSoulGauge2;
    [Token(Token = "0x400BFA6")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    private TextMeshProUGUI blueSoulCurrText;
    [Token(Token = "0x400BFA7")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private TextMeshProUGUI blueSoulMaxText;
    [Token(Token = "0x400BFA8")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private TextMeshProUGUI redSoulCurrText;
    [Token(Token = "0x400BFA9")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    private TextMeshProUGUI redSoulMaxText;
    [Token(Token = "0x400BFAA")]
    [FieldOffset(Offset = "0x180")]
    [SerializeField]
    private TextMeshProUGUI expeditionPercentText;
    [Token(Token = "0x400BFAB")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    private GameObject expeditionPecentObj;
    [Token(Token = "0x400BFAC")]
    [FieldOffset(Offset = "0x190")]
    [SerializeField]
    private GameObject expeditionMaxObj;
    [Token(Token = "0x400BFAD")]
    [FieldOffset(Offset = "0x198")]
    [SerializeField]
    private TextMeshProUGUI bluePercentText;
    [Token(Token = "0x400BFAE")]
    [FieldOffset(Offset = "0x1A0")]
    [SerializeField]
    private TextMeshProUGUI redPercentText;
    [Token(Token = "0x400BFAF")]
    [FieldOffset(Offset = "0x1A8")]
    [SerializeField]
    private GameObject bluePecentObj;
    [Token(Token = "0x400BFB0")]
    [FieldOffset(Offset = "0x1B0")]
    [SerializeField]
    private GameObject blueMaxObj;
    [Token(Token = "0x400BFB1")]
    [FieldOffset(Offset = "0x1B8")]
    [SerializeField]
    private GameObject redPecentObj;
    [Token(Token = "0x400BFB2")]
    [FieldOffset(Offset = "0x1C0")]
    [SerializeField]
    private GameObject redMaxObj;
    [Token(Token = "0x400BFB3")]
    [FieldOffset(Offset = "0x1C8")]
    [SerializeField]
    private GameObject Particle_Back;
    [Token(Token = "0x400BFB4")]
    [FieldOffset(Offset = "0x1D0")]
    [SerializeField]
    private GameObject Particle_Front;
    [Token(Token = "0x400BFB5")]
    [FieldOffset(Offset = "0x1D8")]
    [SerializeField]
    private GameObject Particle_Back_Blue;
    [Token(Token = "0x400BFB6")]
    [FieldOffset(Offset = "0x1E0")]
    [SerializeField]
    private GameObject Particle_Front_Blue;
    [Token(Token = "0x400BFB7")]
    [FieldOffset(Offset = "0x1E8")]
    [SerializeField]
    private GameObject Particle_Back_Red;
    [Token(Token = "0x400BFB8")]
    [FieldOffset(Offset = "0x1F0")]
    [SerializeField]
    private GameObject Particle_Front_Red;
    [Token(Token = "0x400BFB9")]
    [FieldOffset(Offset = "0x1F8")]
    [SerializeField]
    private GameObject Particle_Back_Max;
    [Token(Token = "0x400BFBA")]
    [FieldOffset(Offset = "0x200")]
    [SerializeField]
    private TextMeshProUGUI lockText;
    [Token(Token = "0x400BFBB")]
    [FieldOffset(Offset = "0x208")]
    [SerializeField]
    private GameObject lockObj;
    [Token(Token = "0x400BFBC")]
    [FieldOffset(Offset = "0x210")]
    [SerializeField]
    private UITweenGroup lockTween;
    [Token(Token = "0x400BFBD")]
    [FieldOffset(Offset = "0x218")]
    [SerializeField]
    private UITimelineController timelineControllerInOut;
    [Token(Token = "0x400BFBE")]
    [FieldOffset(Offset = "0x220")]
    [SerializeField]
    private GameObject root;
    [Token(Token = "0x400BFBF")]
    [FieldOffset(Offset = "0x228")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400BFC0")]
    [FieldOffset(Offset = "0x230")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400BFC1")]
    [FieldOffset(Offset = "0x238")]
    [SerializeField]
    private TextMeshProUGUI textPartyNum;
    [Token(Token = "0x400BFC2")]
    [FieldOffset(Offset = "0x240")]
    [SerializeField]
    private GameObject[] selectPartyOnDots;
    [Token(Token = "0x400BFC3")]
    [FieldOffset(Offset = "0x248")]
    [SerializeField]
    private GameObject bossBadgeObj;
    [Token(Token = "0x400BFC5")]
    [FieldOffset(Offset = "0x251")]
    private bool IsOpened;
    [Token(Token = "0x400BFC6")]
    [FieldOffset(Offset = "0x258")]
    private SceneHandler.ProcessingSubSceneFlag processingFlag;
    [Token(Token = "0x400BFC7")]
    [FieldOffset(Offset = "0x260")]
    private bool isOpenExpeditionFullWarningPopup;

    [Token(Token = "0x17003C49")]
    public bool IsNeedBlackFadeInBackScene
    {
      [Token(Token = "0x601187A"), Address(RVA = "0x49491F0", Offset = "0x49491F0", VA = "0x49491F0")] get
      {
        return new bool();
      }
      [Token(Token = "0x601187B"), Address(RVA = "0x49491F8", Offset = "0x49491F8", VA = "0x49491F8")] set
      {
      }
    }

    [Token(Token = "0x601187C")]
    [Address(RVA = "0x4949204", Offset = "0x4949204", VA = "0x4949204", Slot = "6")]
    public override void Initialize(ChangeSceneParameter parameter)
    {
    }

    [Token(Token = "0x601187D")]
    [Address(RVA = "0x494B010", Offset = "0x494B010", VA = "0x494B010", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601187E")]
    [Address(RVA = "0x494B078", Offset = "0x494B078", VA = "0x494B078")]
    private void PlayInAnim()
    {
    }

    [Token(Token = "0x601187F")]
    [Address(RVA = "0x494B198", Offset = "0x494B198", VA = "0x494B198")]
    public void PlayOutAnim(Action callback = null)
    {
    }

    [Token(Token = "0x6011880")]
    [Address(RVA = "0x494B264", Offset = "0x494B264", VA = "0x494B264")]
    private IEnumerator Preload() => (IEnumerator) null;

    [Token(Token = "0x6011881")]
    [Address(RVA = "0x494B2CC", Offset = "0x494B2CC", VA = "0x494B2CC", Slot = "24")]
    public override void OnBeforeBackScene()
    {
    }

    [Token(Token = "0x6011882")]
    [Address(RVA = "0x494B364", Offset = "0x494B364", VA = "0x494B364", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6011883")]
    [Address(RVA = "0x494B460", Offset = "0x494B460", VA = "0x494B460", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6011884")]
    [Address(RVA = "0x494B4C8", Offset = "0x494B4C8", VA = "0x494B4C8", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6011885")]
    [Address(RVA = "0x494BCF4", Offset = "0x494BCF4", VA = "0x494BCF4", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6011886")]
    [Address(RVA = "0x494BDCC", Offset = "0x494BDCC", VA = "0x494BDCC")]
    private void SetInteractable(bool value)
    {
    }

    [Token(Token = "0x6011887")]
    [Address(RVA = "0x494BE64", Offset = "0x494BE64", VA = "0x494BE64")]
    public void DisableInteractable()
    {
    }

    [Token(Token = "0x6011888")]
    [Address(RVA = "0x494BE6C", Offset = "0x494BE6C", VA = "0x494BE6C")]
    public void EnableInteractable()
    {
    }

    [Token(Token = "0x6011889")]
    [Address(RVA = "0x494BE74", Offset = "0x494BE74", VA = "0x494BE74")]
    private void OnFlick(CommonGesturePanel.Direction direction, Vector2 speed)
    {
    }

    [Token(Token = "0x601188A")]
    [Address(RVA = "0x494BEBC", Offset = "0x494BEBC", VA = "0x494BEBC")]
    private void SetCellSize()
    {
    }

    [Token(Token = "0x601188B")]
    [Address(RVA = "0x494A6CC", Offset = "0x494A6CC", VA = "0x494A6CC")]
    private void SetGaugeSoulTank()
    {
    }

    [Token(Token = "0x601188C")]
    [Address(RVA = "0x49494E8", Offset = "0x49494E8", VA = "0x49494E8")]
    private void CreateBattleParty()
    {
    }

    [Token(Token = "0x601188D")]
    [Address(RVA = "0x4949F4C", Offset = "0x4949F4C", VA = "0x4949F4C")]
    private void SetPlayerSlot()
    {
    }

    [Token(Token = "0x601188E")]
    [Address(RVA = "0x494BF70", Offset = "0x494BF70", VA = "0x494BF70")]
    private void UpdatePlayerSlotExpData()
    {
    }

    [Token(Token = "0x601188F")]
    [Address(RVA = "0x4949538", Offset = "0x4949538", VA = "0x4949538")]
    private void UpdateBossBadge()
    {
    }

    [Token(Token = "0x6011890")]
    [Address(RVA = "0x4949570", Offset = "0x4949570", VA = "0x4949570")]
    private void SetDestination()
    {
    }

    [Token(Token = "0x6011891")]
    [Address(RVA = "0x494C0A4", Offset = "0x494C0A4", VA = "0x494C0A4")]
    private IEnumerator PlayPartyUnlockEffect(List<ExpeditionPartyReleaseData> data, int partys)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011892")]
    [Address(RVA = "0x494B434", Offset = "0x494B434", VA = "0x494B434")]
    private void UpdateBattleParty()
    {
    }

    [Token(Token = "0x6011893")]
    [Address(RVA = "0x4949518", Offset = "0x4949518", VA = "0x4949518")]
    private void PlayLevelUpAnimation()
    {
    }

    [Token(Token = "0x6011894")]
    [Address(RVA = "0x494C124", Offset = "0x494C124", VA = "0x494C124")]
    private IEnumerator PlayLevelUpAnimationCoroutine() => (IEnumerator) null;

    [Token(Token = "0x6011895")]
    [Address(RVA = "0x494AEE8", Offset = "0x494AEE8", VA = "0x494AEE8")]
    private void ShowPagingButtons(bool isShowPrev, bool isShowNext)
    {
    }

    [Token(Token = "0x6011896")]
    [Address(RVA = "0x494C18C", Offset = "0x494C18C", VA = "0x494C18C")]
    private void EnablePagingButtons(bool isEnablePrev, bool isEnableNext)
    {
    }

    [Token(Token = "0x6011897")]
    [Address(RVA = "0x494ACCC", Offset = "0x494ACCC", VA = "0x494ACCC")]
    private void UpdataHighSpeedExpedition()
    {
    }

    [Token(Token = "0x6011898")]
    [Address(RVA = "0x494C1D0", Offset = "0x494C1D0", VA = "0x494C1D0")]
    private void FinishedSrcollPage(int horizontalIndex, int verticalIndex)
    {
    }

    [Token(Token = "0x6011899")]
    [Address(RVA = "0x494AF48", Offset = "0x494AF48", VA = "0x494AF48")]
    private void SetAutoOpenChallengingBoss()
    {
    }

    [Token(Token = "0x601189A")]
    [Address(RVA = "0x494C2D8", Offset = "0x494C2D8", VA = "0x494C2D8")]
    private IEnumerator WaitOpenChallengingBoss(int selectStage) => (IEnumerator) null;

    [Token(Token = "0x601189B")]
    [Address(RVA = "0x494BAC8", Offset = "0x494BAC8", VA = "0x494BAC8")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x601189C")]
    [Address(RVA = "0x494C350", Offset = "0x494C350", VA = "0x494C350")]
    public void SetCallback(Action onCollectionBox)
    {
    }

    [Token(Token = "0x601189D")]
    [Address(RVA = "0x494C358", Offset = "0x494C358", VA = "0x494C358")]
    public void OnClickMenu()
    {
    }

    [Token(Token = "0x601189E")]
    [Address(RVA = "0x494C35C", Offset = "0x494C35C", VA = "0x494C35C")]
    public void OnClickStrengthenSoulTank(bool isOpenBlue)
    {
    }

    [Token(Token = "0x601189F")]
    [Address(RVA = "0x494C598", Offset = "0x494C598", VA = "0x494C598")]
    public void OnClickEditParty()
    {
    }

    [Token(Token = "0x60118A0")]
    [Address(RVA = "0x494C664", Offset = "0x494C664", VA = "0x494C664")]
    public void OnClickEditParty(bool isStageSelectOnly)
    {
    }

    [Token(Token = "0x60118A1")]
    [Address(RVA = "0x494C7A0", Offset = "0x494C7A0", VA = "0x494C7A0")]
    public void OnClickShortcutExpedition()
    {
    }

    [Token(Token = "0x60118A2")]
    [Address(RVA = "0x494CB20", Offset = "0x494CB20", VA = "0x494CB20")]
    private IEnumerator OpenShortcutExpeditionPopup() => (IEnumerator) null;

    [Token(Token = "0x60118A3")]
    [Address(RVA = "0x494CB88", Offset = "0x494CB88", VA = "0x494CB88")]
    private void CheckExpeditionFullWarning(Consume consume)
    {
    }

    [Token(Token = "0x60118A4")]
    [Address(RVA = "0x494DDC8", Offset = "0x494DDC8", VA = "0x494DDC8")]
    private ExpeditionStageDescriptionData GetStageDescriptionData(int stageId, int stageLevel)
    {
      return (ExpeditionStageDescriptionData) null;
    }

    [Token(Token = "0x60118A5")]
    [Address(RVA = "0x494D184", Offset = "0x494D184", VA = "0x494D184")]
    private bool CheckStyleExpOver() => new bool();

    [Token(Token = "0x60118A6")]
    [Address(RVA = "0x494D528", Offset = "0x494D528", VA = "0x494D528")]
    private bool CheckBoxOver(int shortcutTime) => new bool();

    [Token(Token = "0x60118A7")]
    [Address(RVA = "0x494D7BC", Offset = "0x494D7BC", VA = "0x494D7BC")]
    private bool CheckSoulSpotOver(int shortcutTime) => new bool();

    [Token(Token = "0x60118A8")]
    [Address(RVA = "0x494DBE4", Offset = "0x494DBE4", VA = "0x494DBE4")]
    private void OpenConfrimPopup(Consume consume)
    {
    }

    [Token(Token = "0x60118A9")]
    [Address(RVA = "0x494DF88", Offset = "0x494DF88", VA = "0x494DF88")]
    private void OpenShortcutExpeditionCoinConfirmPopup()
    {
    }

    [Token(Token = "0x60118AA")]
    [Address(RVA = "0x494E04C", Offset = "0x494E04C", VA = "0x494E04C")]
    private void OpenShortcutExpeditionTicketConfirmPopup()
    {
    }

    [Token(Token = "0x60118AB")]
    [Address(RVA = "0x494E110", Offset = "0x494E110", VA = "0x494E110")]
    private void CallShortcutExpeditionAPI(Consume consume)
    {
    }

    [Token(Token = "0x60118AC")]
    [Address(RVA = "0x494E1CC", Offset = "0x494E1CC", VA = "0x494E1CC")]
    private IEnumerator ConnectAPIExpeditionRapid(Consume consume) => (IEnumerator) null;

    [Token(Token = "0x60118AD")]
    [Address(RVA = "0x494B438", Offset = "0x494B438", VA = "0x494B438")]
    public void OnClickChallengingBoss()
    {
    }

    [Token(Token = "0x60118AE")]
    [Address(RVA = "0x494E244", Offset = "0x494E244", VA = "0x494E244")]
    private void OpenChallengingBoss(int? selectStage = null, Action<IEnumerator> startInitialize = null)
    {
    }

    [Token(Token = "0x60118AF")]
    [Address(RVA = "0x494E368", Offset = "0x494E368", VA = "0x494E368")]
    public IEnumerator GoBossBattleAsync() => (IEnumerator) null;

    [Token(Token = "0x60118B0")]
    [Address(RVA = "0x494E3D0", Offset = "0x494E3D0", VA = "0x494E3D0")]
    public void OnClickChangeCameraAngle()
    {
    }

    [Token(Token = "0x60118B1")]
    [Address(RVA = "0x494E3F4", Offset = "0x494E3F4", VA = "0x494E3F4")]
    public void OnClickSwitchGridVisible()
    {
    }

    [Token(Token = "0x60118B2")]
    [Address(RVA = "0x494E418", Offset = "0x494E418", VA = "0x494E418")]
    public void ChangeNextParty()
    {
    }

    [Token(Token = "0x60118B3")]
    [Address(RVA = "0x494E420", Offset = "0x494E420", VA = "0x494E420")]
    public void ChangeNextParty(int addCount)
    {
    }

    [Token(Token = "0x60118B4")]
    [Address(RVA = "0x494E4A8", Offset = "0x494E4A8", VA = "0x494E4A8")]
    public void ChangePreviousPage()
    {
    }

    [Token(Token = "0x60118B5")]
    [Address(RVA = "0x494E524", Offset = "0x494E524", VA = "0x494E524")]
    public void UpdatePartyData(int displayPartyIndex)
    {
    }

    [Token(Token = "0x60118B6")]
    [Address(RVA = "0x494E60C", Offset = "0x494E60C", VA = "0x494E60C")]
    public void OnClickExpeditionBox()
    {
    }

    [Token(Token = "0x60118B7")]
    [Address(RVA = "0x494E8AC", Offset = "0x494E8AC", VA = "0x494E8AC")]
    public void OnClickDestiantion()
    {
    }

    [Token(Token = "0x60118B8")]
    [Address(RVA = "0x494A4E4", Offset = "0x494A4E4", VA = "0x494A4E4")]
    private void SetGaugeSoulSpot(bool isPlayAnim)
    {
    }

    [Token(Token = "0x60118B9")]
    [Address(RVA = "0x494ED7C", Offset = "0x494ED7C", VA = "0x494ED7C")]
    private void SetBoxPercentText()
    {
    }

    [Token(Token = "0x60118BA")]
    [Address(RVA = "0x494EDCC", Offset = "0x494EDCC", VA = "0x494EDCC")]
    private void SetBoxPercentText(
      int max,
      int now,
      TextMeshProUGUI percentText,
      GameObject percentObj,
      GameObject maxObj)
    {
    }

    [Token(Token = "0x60118BB")]
    [Address(RVA = "0x494E8B4", Offset = "0x494E8B4", VA = "0x494E8B4")]
    private void PlaySoulSpotMaxAnimation()
    {
    }

    [Token(Token = "0x60118BC")]
    [Address(RVA = "0x494EF24", Offset = "0x494EF24", VA = "0x494EF24")]
    public void OnClickApplyingBonus()
    {
    }

    [Token(Token = "0x60118BD")]
    [Address(RVA = "0x494EF40", Offset = "0x494EF40", VA = "0x494EF40")]
    public void OnClickDebugLevelUp()
    {
    }

    [Token(Token = "0x60118BE")]
    [Address(RVA = "0x494F108", Offset = "0x494F108", VA = "0x494F108")]
    private void ChangeSubScene(string assetBundleName, string subSceneName)
    {
    }

    [Token(Token = "0x60118BF")]
    [Address(RVA = "0x494F19C", Offset = "0x494F19C", VA = "0x494F19C")]
    public void OnClickToHowToPlay()
    {
    }

    [Token(Token = "0x60118C0")]
    [Address(RVA = "0x494F238", Offset = "0x494F238", VA = "0x494F238")]
    public ExpeditionTopScene()
    {
    }
  }
}
