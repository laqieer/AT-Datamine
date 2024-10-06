// Decompiled with JetBrains decompiler
// Type: GachaManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using Gacha;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using UnityEngine.Video;

#nullable disable
[Token(Token = "0x20001EE")]
public class GachaManager : MonoBehaviour
{
  [Token(Token = "0x4000B02")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private GachaSettingsAsset gachaSettings;
  [Token(Token = "0x4000B03")]
  [FieldOffset(Offset = "0x20")]
  private Animator mainCharacterAnimator;
  [Token(Token = "0x4000B04")]
  [FieldOffset(Offset = "0x28")]
  private Animator weaponAnimator;
  [Token(Token = "0x4000B05")]
  [FieldOffset(Offset = "0x30")]
  private bool isInitialized;
  [Token(Token = "0x4000B06")]
  [FieldOffset(Offset = "0x31")]
  private bool isPlaying;
  [Token(Token = "0x4000B07")]
  [FieldOffset(Offset = "0x32")]
  private bool isWaitingForScreenTouchAtPart02;
  [Token(Token = "0x4000B08")]
  [FieldOffset(Offset = "0x33")]
  private bool shouldShowNextStepAtPart04;
  [Token(Token = "0x4000B09")]
  [FieldOffset(Offset = "0x34")]
  private bool isWaitingToFinishGachaPlayback;
  [Token(Token = "0x4000B0A")]
  [FieldOffset(Offset = "0x35")]
  private bool isSkipping;
  [Token(Token = "0x4000B0B")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  [Header("3D_制御対象")]
  private GameObject mainCharacterContainer;
  [Token(Token = "0x4000B0C")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private PlayableDirector part01PlayableDirector;
  [Token(Token = "0x4000B0D")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  private PlayableDirector part03PlayableDirector;
  [Token(Token = "0x4000B0E")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private GameObject catContainer;
  [Token(Token = "0x4000B0F")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  private GameObject mapPrism;
  [Token(Token = "0x4000B10")]
  [FieldOffset(Offset = "0x60")]
  [SerializeField]
  private GameObject geoLineMain;
  [Token(Token = "0x4000B11")]
  [FieldOffset(Offset = "0x68")]
  [SerializeField]
  private GameObject geoLineSub;
  [Token(Token = "0x4000B12")]
  [FieldOffset(Offset = "0x70")]
  [SerializeField]
  private GameObject monoris;
  [Token(Token = "0x4000B13")]
  [FieldOffset(Offset = "0x78")]
  [SerializeField]
  private Camera part01Camera;
  [Token(Token = "0x4000B14")]
  [FieldOffset(Offset = "0x80")]
  [SerializeField]
  private Button part02CommonGesturePanel;
  [Token(Token = "0x4000B15")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private RawImage part03RawImage;
  [Token(Token = "0x4000B16")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private Camera part03CameraForCut03RawImageRT1;
  [Token(Token = "0x4000B17")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  private Camera part03CameraForCut03RawImageRT2;
  [Token(Token = "0x4000B18")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private Camera part03CameraForCut03RawImageEffectRT;
  [Token(Token = "0x4000B19")]
  [FieldOffset(Offset = "0xA8")]
  [SerializeField]
  private Button part04CommonGesturePanel;
  [Token(Token = "0x4000B1A")]
  [FieldOffset(Offset = "0xB0")]
  [SerializeField]
  private GameObject part04EffBGBlue;
  [Token(Token = "0x4000B1B")]
  [FieldOffset(Offset = "0xB8")]
  [SerializeField]
  private GameObject part04EffBGYellow;
  [Token(Token = "0x4000B1C")]
  [FieldOffset(Offset = "0xC0")]
  [SerializeField]
  private List<CinemachineVirtualCamera> part04CrystalVCList;
  [Token(Token = "0x4000B1D")]
  [FieldOffset(Offset = "0xC8")]
  [SerializeField]
  private List<Animator> part04CrystalAnimatorList;
  [Token(Token = "0x4000B1E")]
  [FieldOffset(Offset = "0xD0")]
  [SerializeField]
  private List<GameObject> part04CrystalObjectList;
  [Token(Token = "0x4000B1F")]
  [FieldOffset(Offset = "0xD8")]
  [SerializeField]
  private List<GameObject> part04CrystalMaskList;
  [Token(Token = "0x4000B20")]
  [FieldOffset(Offset = "0xE0")]
  [SerializeField]
  private List<GachaCrystalEmblemController> part04CrystalEmblemControllerList;
  [Token(Token = "0x4000B21")]
  [FieldOffset(Offset = "0xE8")]
  [SerializeField]
  private CinemachineBrain part04CinemachineBrain;
  [Token(Token = "0x4000B22")]
  [FieldOffset(Offset = "0xF0")]
  [SerializeField]
  [Header("UI_紋章と自己紹介")]
  private GameObject emblemAndSelfIntroductionPanel;
  [Token(Token = "0x4000B23")]
  [FieldOffset(Offset = "0xF8")]
  [SerializeField]
  private PlayableDirector emblemAndSelfIntroductionPlayableDirector;
  [Token(Token = "0x4000B24")]
  [FieldOffset(Offset = "0x100")]
  [SerializeField]
  private RawImage emblemImage;
  [Token(Token = "0x4000B25")]
  [FieldOffset(Offset = "0x108")]
  [SerializeField]
  private TextMeshProUGUI selfIntroductionText;
  [Token(Token = "0x4000B26")]
  [FieldOffset(Offset = "0x110")]
  [SerializeField]
  [Header("UI_紋章と自己紹介 - 念装")]
  private GameObject emblemAndSelfIntroductionPanel_Mnemnograph;
  [Token(Token = "0x4000B27")]
  [FieldOffset(Offset = "0x118")]
  [SerializeField]
  private PlayableDirector emblemAndSelfIntroductionPlayableDirector_Mnemnograph;
  [Token(Token = "0x4000B28")]
  [FieldOffset(Offset = "0x120")]
  [SerializeField]
  private TextMeshProUGUI selfIntroductionText_Mnemnograph;
  [Token(Token = "0x4000B29")]
  [FieldOffset(Offset = "0x128")]
  [SerializeField]
  [Header("UI_シングルスキル動画")]
  private GameObject videoPlayerPanel;
  [Token(Token = "0x4000B2A")]
  [FieldOffset(Offset = "0x130")]
  [SerializeField]
  private List<VideoPlayer> videoPlayers;
  [Token(Token = "0x4000B2B")]
  [FieldOffset(Offset = "0x138")]
  private RenderTexture videoTexture;
  [Token(Token = "0x4000B2C")]
  [FieldOffset(Offset = "0x140")]
  [SerializeField]
  private RawImage videoPlayerRawImage;
  [Token(Token = "0x4000B2D")]
  [FieldOffset(Offset = "0x148")]
  [SerializeField]
  [Header("UI_スタイル")]
  private GameObject stylePanel;
  [Token(Token = "0x4000B2E")]
  [FieldOffset(Offset = "0x150")]
  [SerializeField]
  private PlayableDirector stylePlayableDirector;
  [Token(Token = "0x4000B2F")]
  [FieldOffset(Offset = "0x158")]
  [SerializeField]
  private RawImage styleImage;
  [Token(Token = "0x4000B30")]
  [FieldOffset(Offset = "0x160")]
  [SerializeField]
  private RawImage styleImageLarge;
  [Token(Token = "0x4000B31")]
  [FieldOffset(Offset = "0x168")]
  private IllustLayoutComponent styleImageLargeLayoutComponent;
  [Token(Token = "0x4000B32")]
  [FieldOffset(Offset = "0x170")]
  [SerializeField]
  private RawImage resultEmblemImage;
  [Token(Token = "0x4000B33")]
  [FieldOffset(Offset = "0x178")]
  [SerializeField]
  private Text styleNameText;
  [Token(Token = "0x4000B34")]
  [FieldOffset(Offset = "0x180")]
  [SerializeField]
  private Text styleCharacterNameText;
  [Token(Token = "0x4000B35")]
  [FieldOffset(Offset = "0x188")]
  [SerializeField]
  private GameObject styleIsNew;
  [Token(Token = "0x4000B36")]
  [FieldOffset(Offset = "0x190")]
  [SerializeField]
  private GachaRarityStarController styleStarController;
  [Token(Token = "0x4000B37")]
  [FieldOffset(Offset = "0x198")]
  [SerializeField]
  private ElementIconView elementIconView;
  [Token(Token = "0x4000B38")]
  [FieldOffset(Offset = "0x1A0")]
  [SerializeField]
  private GachaCharacterGetPanel characterGetPanel;
  [Token(Token = "0x4000B39")]
  [FieldOffset(Offset = "0x1A8")]
  [SerializeField]
  private GameObject singleSkillCutinPrefab;
  [Token(Token = "0x4000B3A")]
  [FieldOffset(Offset = "0x1B0")]
  [SerializeField]
  private Transform cutinRoot;
  [Token(Token = "0x4000B3B")]
  [FieldOffset(Offset = "0x1B8")]
  [SerializeField]
  private Transform dotCharacterRoot;
  [Token(Token = "0x4000B3C")]
  [FieldOffset(Offset = "0x1C0")]
  [SerializeField]
  private TextMeshProUGUI dotCharacterNameText;
  [Token(Token = "0x4000B3D")]
  [FieldOffset(Offset = "0x1C8")]
  [SerializeField]
  private GameObject dotCharacterPanel;
  [Token(Token = "0x4000B3E")]
  [FieldOffset(Offset = "0x1D0")]
  [Header("UI_念装")]
  [SerializeField]
  private GameObject mnemnographEquipmentPanel;
  [Token(Token = "0x4000B3F")]
  [FieldOffset(Offset = "0x1D8")]
  [SerializeField]
  private PlayableDirector mnemnographPlayableDirector;
  [Token(Token = "0x4000B40")]
  [FieldOffset(Offset = "0x1E0")]
  [SerializeField]
  private RawImage mnemnographImage;
  [Token(Token = "0x4000B41")]
  [FieldOffset(Offset = "0x1E8")]
  [SerializeField]
  private RawImage mnemnographImageLarge;
  [Token(Token = "0x4000B42")]
  [FieldOffset(Offset = "0x1F0")]
  private IllustLayoutComponent mnemnographImageLargeLayoutComponent;
  [Token(Token = "0x4000B43")]
  [FieldOffset(Offset = "0x1F8")]
  [SerializeField]
  private Text mnemnographNameText;
  [Token(Token = "0x4000B44")]
  [FieldOffset(Offset = "0x200")]
  [SerializeField]
  private GachaRarityTextController mnemnographStarController;
  [Token(Token = "0x4000B45")]
  [FieldOffset(Offset = "0x208")]
  [SerializeField]
  private GameObject mnemnographIsNew;
  [Token(Token = "0x4000B46")]
  [FieldOffset(Offset = "0x210")]
  [Header("UI_アイテム")]
  [SerializeField]
  private GameObject itemPanel;
  [Token(Token = "0x4000B47")]
  [FieldOffset(Offset = "0x218")]
  [SerializeField]
  private PlayableDirector itemPlayableDirector;
  [Token(Token = "0x4000B48")]
  [FieldOffset(Offset = "0x220")]
  [SerializeField]
  private RawImage itemImage;
  [Token(Token = "0x4000B49")]
  [FieldOffset(Offset = "0x228")]
  [SerializeField]
  private Text itemNameText;
  [Token(Token = "0x4000B4A")]
  [FieldOffset(Offset = "0x230")]
  [SerializeField]
  private Button part05CommonGesturePanel;
  [Token(Token = "0x4000B4B")]
  [FieldOffset(Offset = "0x238")]
  [SerializeField]
  private GameObject debugUIContainer;
  [Token(Token = "0x4000B4C")]
  [FieldOffset(Offset = "0x240")]
  [SerializeField]
  private Camera resultMainCamera;
  [Token(Token = "0x4000B4D")]
  [FieldOffset(Offset = "0x248")]
  [SerializeField]
  [Header("3D_使う素材への参照")]
  private RuntimeAnimatorController mainCharacterAnimatorController_M;
  [Token(Token = "0x4000B4E")]
  [FieldOffset(Offset = "0x250")]
  [SerializeField]
  private RuntimeAnimatorController mainCharacterAnimatorController_F;
  [Token(Token = "0x4000B4F")]
  [FieldOffset(Offset = "0x258")]
  [SerializeField]
  private DuelCharacterEquipmentSettingsAsset mainCharacterEquipmentModelBlue;
  [Token(Token = "0x4000B50")]
  [FieldOffset(Offset = "0x260")]
  [SerializeField]
  private DuelCharacterEquipmentSettingsAsset mainCharacterEquipmentModelYellow;
  [Token(Token = "0x4000B51")]
  [FieldOffset(Offset = "0x268")]
  [SerializeField]
  [Header("3D_色設定")]
  private Color lineColorABlue;
  [Token(Token = "0x4000B52")]
  [FieldOffset(Offset = "0x278")]
  [SerializeField]
  private Color lineColorAYellow;
  [Token(Token = "0x4000B53")]
  [FieldOffset(Offset = "0x288")]
  [SerializeField]
  private Color monorisColorBlue;
  [Token(Token = "0x4000B54")]
  [FieldOffset(Offset = "0x298")]
  [SerializeField]
  private Color monorisColorYellow;
  [Token(Token = "0x4000B55")]
  [FieldOffset(Offset = "0x2A8")]
  [SerializeField]
  private Color rawImageColorBlue;
  [Token(Token = "0x4000B56")]
  [FieldOffset(Offset = "0x2B8")]
  [SerializeField]
  private Color rawImageColorYellow;
  [Token(Token = "0x4000B57")]
  [FieldOffset(Offset = "0x2C8")]
  [SerializeField]
  [Header("3D_事前昇格演出確率")]
  private float possibility_SR_TO_SSR;
  [Token(Token = "0x4000B58")]
  [FieldOffset(Offset = "0x2CC")]
  [SerializeField]
  private float possibility_SR_TO_UR;
  [Token(Token = "0x4000B59")]
  [FieldOffset(Offset = "0x2D0")]
  [SerializeField]
  private float possibility_SSR_TO_UR;
  [Token(Token = "0x4000B5A")]
  [FieldOffset(Offset = "0x2D8")]
  [Header("その他")]
  [SerializeField]
  private Button skipButton;
  [Token(Token = "0x4000B5B")]
  [FieldOffset(Offset = "0x2E0")]
  [SerializeField]
  private Button tapNextButton;
  [Token(Token = "0x4000B5C")]
  [FieldOffset(Offset = "0x2E8")]
  private GachaAwardData processingGachaAwardData;
  [Token(Token = "0x4000B5D")]
  private const string TRACK_NAME_PART01_CHARACTER_ANIMATION_M = "An_gacha_ch_m";
  [Token(Token = "0x4000B5E")]
  private const string TRACK_NAME_PART01_CHARACTER_ANIMATION_F = "An_gacha_ch_f";
  [Token(Token = "0x4000B5F")]
  private const string TRACK_NAME_PART01_CAT_VOICE = "Vo_gacha_cat";
  [Token(Token = "0x4000B60")]
  private const string TRACK_NAME_PART03_WEAPON_ANIMATION = "Animation_cut04_wpn";
  [Token(Token = "0x4000B61")]
  private const string TRACK_NAME_PART03_CAM_CUT05_M = "An_gacha_camera_Cut05_m";
  [Token(Token = "0x4000B62")]
  private const string TRACK_NAME_PART03_CAM_CUT05_F = "An_gacha_camera_Cut05_f";
  [Token(Token = "0x4000B63")]
  private const string TRACK_NAME_PART03_CAM_CUT06_M = "An_gacha_camera_Cut06_01_m";
  [Token(Token = "0x4000B64")]
  private const string TRACK_NAME_PART03_CAM_CUT06_F = "An_gacha_camera_Cut06_01_f";
  [Token(Token = "0x4000B65")]
  private const string TRACK_NAME_PART03_CHARACTER_ANIMATION_M = "An_gacha_ch_m";
  [Token(Token = "0x4000B66")]
  private const string TRACK_NAME_PART03_CHARACTER_ANIMATION_F = "An_gacha_ch_f";
  [Token(Token = "0x4000B67")]
  private const string TRACK_NAME_PART03_CHARACTER_HIDE_MODEL = "An_gacha_ch_HideModel";
  [Token(Token = "0x4000B68")]
  private const string TRACK_NAME_PART03_Effect01_BLUE = "Stg_Eff_Track01_SR";
  [Token(Token = "0x4000B69")]
  private const string TRACK_NAME_PART03_Effect01_YELLOW = "Stg_Eff_Track01_SSR";
  [Token(Token = "0x4000B6A")]
  private const string TRACK_NAME_PART03_Effect02_Wep_BLUE = "Eff_Wep_Track01_SR";
  [Token(Token = "0x4000B6B")]
  private const string TRACK_NAME_PART03_Effect02_Wep_YELLOW = "Eff_Wep_Track01_SSR";
  [Token(Token = "0x4000B6C")]
  private const string TRACK_NAME_PART03_Effect02_BG_BLUE = "Eff_BG_Track01_SR";
  [Token(Token = "0x4000B6D")]
  private const string TRACK_NAME_PART03_Effect02_BG_YELLOW = "Eff_BG_Track01_SSR";
  [Token(Token = "0x4000B6E")]
  private const string TRACK_NAME_STYLE_IMAGE_FOCUS = "StyleImageFocusTrack";
  [Token(Token = "0x4000B6F")]
  private const string TRACK_NAME_MNEMNOGRAPH_IMAGE_FOCUS = "StyleImageFocusTrack";
  [Token(Token = "0x4000B70")]
  private const string TRIGGER_NAME_SR_TO_SSR = "SR-SSR";
  [Token(Token = "0x4000B71")]
  private const string TRIGGER_NAME_SR_TO_UR = "SR-UR";
  [Token(Token = "0x4000B72")]
  private const string TRIGGER_NAME_GET_SR = "GetSR";
  [Token(Token = "0x4000B73")]
  private const string TRIGGER_NAME_GET_SSR = "GetSSR";
  [Token(Token = "0x4000B74")]
  private const string TRIGGER_NAME_GET_UR = "GetUR";
  [Token(Token = "0x4000B75")]
  private const float PRISM_EFFECT_PROBABILITY_SR_TO_UR = 30f;
  [Token(Token = "0x4000B76")]
  private const float PRISM_EFFECT_PROBABILITY_SSR_TO_UR = 30f;
  [Token(Token = "0x4000B77")]
  private const float PRISM_EFFECT_PROBABILITY_UR_TO_UR = 30f;

  [Token(Token = "0x6000C42")]
  [Address(RVA = "0x4C743B4", Offset = "0x4C743B4", VA = "0x4C743B4")]
  public IEnumerator Initialize(GachaSettingsAsset gachaSettings) => (IEnumerator) null;

  [Token(Token = "0x6000C43")]
  [Address(RVA = "0x4C74450", Offset = "0x4C74450", VA = "0x4C74450")]
  private void Initialize()
  {
  }

  [Token(Token = "0x6000C44")]
  [Address(RVA = "0x4C744D8", Offset = "0x4C744D8", VA = "0x4C744D8")]
  public void InitializeCamera()
  {
  }

  [Token(Token = "0x6000C45")]
  [Address(RVA = "0x4C74470", Offset = "0x4C74470", VA = "0x4C74470")]
  private IEnumerator InitializeAsync() => (IEnumerator) null;

  [Token(Token = "0x6000C46")]
  [Address(RVA = "0x4C7452C", Offset = "0x4C7452C", VA = "0x4C7452C")]
  public void InitializeForSkipGachaPlayback(GachaSettingsAsset gachaSettings)
  {
  }

  [Token(Token = "0x6000C47")]
  [Address(RVA = "0x4C7487C", Offset = "0x4C7487C", VA = "0x4C7487C")]
  public void InitializeCamerasForSkipGachaPlayback()
  {
  }

  [Token(Token = "0x6000C48")]
  [Address(RVA = "0x4C74B58", Offset = "0x4C74B58", VA = "0x4C74B58")]
  private DuelCharacterEquipmentSettingsAsset GetMainCharacterWeapon(
    GachaSettingsAsset.ColorPattern weaponColor)
  {
    return (DuelCharacterEquipmentSettingsAsset) null;
  }

  [Token(Token = "0x6000C49")]
  [Address(RVA = "0x4C74B80", Offset = "0x4C74B80", VA = "0x4C74B80")]
  private void SetLineColor(GachaSettingsAsset.ColorPattern colorPattern)
  {
  }

  [Token(Token = "0x6000C4A")]
  [Address(RVA = "0x4C74C98", Offset = "0x4C74C98", VA = "0x4C74C98")]
  private void SetMonorisColor(GachaSettingsAsset.ColorPattern colorPattern)
  {
  }

  [Token(Token = "0x6000C4B")]
  [Address(RVA = "0x4C74D74", Offset = "0x4C74D74", VA = "0x4C74D74")]
  private void SetRawImageColor(GachaSettingsAsset.ColorPattern colorPattern)
  {
  }

  [Token(Token = "0x6000C4C")]
  [Address(RVA = "0x4C74E38", Offset = "0x4C74E38", VA = "0x4C74E38")]
  public Animator SetMainCharacter(
    DuelCharacterModelSettingsAsset mainCharacterModelSettings,
    GachaSettingsAsset.ColorPattern weaponColor,
    SexTypeEnum mainCharacterGender)
  {
    return (Animator) null;
  }

  [Token(Token = "0x6000C4D")]
  [Address(RVA = "0x4C754AC", Offset = "0x4C754AC", VA = "0x4C754AC")]
  private void SetMainCharacterTimelineBindings(
    Animator mainCharacterAnimator,
    Animator weaponAnimator,
    GachaSettingsAsset gachaSettings)
  {
  }

  [Token(Token = "0x6000C4E")]
  [Address(RVA = "0x4C74F8C", Offset = "0x4C74F8C", VA = "0x4C74F8C")]
  private GameObject CreatePrefabInstance(GameObject prefab, GameObject parent)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000C4F")]
  [Address(RVA = "0x4C75190", Offset = "0x4C75190", VA = "0x4C75190")]
  private Animator SetCharacterEquipments(
    GameObject characterModel,
    DuelCharacterEquipmentSettingsAsset equipmentSettings,
    float weaponScale)
  {
    return (Animator) null;
  }

  [Token(Token = "0x6000C50")]
  [Address(RVA = "0x4C7634C", Offset = "0x4C7634C", VA = "0x4C7634C")]
  public void Play()
  {
  }

  [Token(Token = "0x6000C51")]
  [Address(RVA = "0x4C763F8", Offset = "0x4C763F8", VA = "0x4C763F8")]
  public bool IsPlaying() => new bool();

  [Token(Token = "0x6000C52")]
  [Address(RVA = "0x4C76390", Offset = "0x4C76390", VA = "0x4C76390")]
  private IEnumerator PlayCoroutine() => (IEnumerator) null;

  [Token(Token = "0x6000C53")]
  [Address(RVA = "0x4C76428", Offset = "0x4C76428", VA = "0x4C76428")]
  private IEnumerator ShowCrystalGetEffect(int index, GachaAwardData awardData)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000C54")]
  [Address(RVA = "0x4C764CC", Offset = "0x4C764CC", VA = "0x4C764CC")]
  private IEnumerator ShowUIEffect(GachaAwardData awardData, int index) => (IEnumerator) null;

  [Token(Token = "0x6000C55")]
  [Address(RVA = "0x4C76570", Offset = "0x4C76570", VA = "0x4C76570")]
  private void SetupStyleVoice(int styleId)
  {
  }

  [Token(Token = "0x6000C56")]
  [Address(RVA = "0x4C769C8", Offset = "0x4C769C8", VA = "0x4C769C8")]
  private IEnumerator ShowUIEffectForStyle(GachaAwardData awardData, int index)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000C57")]
  [Address(RVA = "0x4C76A6C", Offset = "0x4C76A6C", VA = "0x4C76A6C")]
  private IEnumerator ShowUIEffectForMnemnograph(GachaAwardData awardData) => (IEnumerator) null;

  [Token(Token = "0x6000C58")]
  [Address(RVA = "0x4C76B08", Offset = "0x4C76B08", VA = "0x4C76B08")]
  private IEnumerator ShowUIEffectForItem(GachaAwardData awardData) => (IEnumerator) null;

  [Token(Token = "0x6000C59")]
  [Address(RVA = "0x4C76BA4", Offset = "0x4C76BA4", VA = "0x4C76BA4")]
  private void DisableAllUIEffectPanels()
  {
  }

  [Token(Token = "0x6000C5A")]
  [Address(RVA = "0x4C741A0", Offset = "0x4C741A0", VA = "0x4C741A0")]
  public void CreateSingleSkillCutin()
  {
  }

  [Token(Token = "0x6000C5B")]
  [Address(RVA = "0x4C76C2C", Offset = "0x4C76C2C", VA = "0x4C76C2C")]
  public void Clear()
  {
  }

  [Token(Token = "0x6000C5C")]
  [Address(RVA = "0x4C76F04", Offset = "0x4C76F04", VA = "0x4C76F04")]
  public void RemoveMainCharacter()
  {
  }

  [Token(Token = "0x6000C5D")]
  [Address(RVA = "0x4C76FD0", Offset = "0x4C76FD0", VA = "0x4C76FD0")]
  public void RegisterResultOverlayCamera(Camera camera, string forwardInsertCameraName = null)
  {
  }

  [Token(Token = "0x6000C5E")]
  [Address(RVA = "0x4C77230", Offset = "0x4C77230", VA = "0x4C77230")]
  public void RegisterOverlayCameraToAllGachaCameras(Camera camera)
  {
  }

  [Token(Token = "0x6000C5F")]
  [Address(RVA = "0x4C77590", Offset = "0x4C77590", VA = "0x4C77590")]
  private void ChangeLayerRecursive(GameObject obj, int layer)
  {
  }

  [Token(Token = "0x6000C60")]
  [Address(RVA = "0x4C7789C", Offset = "0x4C7789C", VA = "0x4C7789C")]
  private void OnTouchPanelAtPart02()
  {
  }

  [Token(Token = "0x6000C61")]
  [Address(RVA = "0x4C778A4", Offset = "0x4C778A4", VA = "0x4C778A4")]
  private void OnTouchPanelAtPart04()
  {
  }

  [Token(Token = "0x6000C62")]
  [Address(RVA = "0x4C778B0", Offset = "0x4C778B0", VA = "0x4C778B0")]
  private void OnTouchPanelAtPart05()
  {
  }

  [Token(Token = "0x6000C63")]
  [Address(RVA = "0x4C778B8", Offset = "0x4C778B8", VA = "0x4C778B8")]
  private void OnTouchSkip()
  {
  }

  [Token(Token = "0x6000C64")]
  [Address(RVA = "0x4C778C4", Offset = "0x4C778C4", VA = "0x4C778C4")]
  public void OnInitialize()
  {
  }

  [Token(Token = "0x6000C65")]
  [Address(RVA = "0x4C778E4", Offset = "0x4C778E4", VA = "0x4C778E4")]
  public void OnPlay()
  {
  }

  [Token(Token = "0x6000C66")]
  [Address(RVA = "0x4C778E8", Offset = "0x4C778E8", VA = "0x4C778E8")]
  public void OnClear()
  {
  }

  [Token(Token = "0x6000C67")]
  [Address(RVA = "0x4C778EC", Offset = "0x4C778EC", VA = "0x4C778EC")]
  public GachaManager()
  {
  }
}
