// Decompiled with JetBrains decompiler
// Type: Gacha.StoryGachaTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001571")]
  internal class StoryGachaTop : MonoBehaviour
  {
    [Token(Token = "0x400625E")]
    private const string AssetBundleName = "ui_page_gacha_prefab";
    [Token(Token = "0x400625F")]
    private const string Container_StoryGachaTop = "Container_StoryGachaTop";
    [Token(Token = "0x4006260")]
    private const string Container_SelectUnit = "Container_SelectUnit";
    [Token(Token = "0x4006261")]
    private const int UNIT_DEFAULT_STYLE_ID = 101001001;
    [Token(Token = "0x4006262")]
    [FieldOffset(Offset = "0x18")]
    private readonly string[] tweenAnim;
    [Token(Token = "0x4006263")]
    [FieldOffset(Offset = "0x20")]
    [Header("入力制御用")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x4006264")]
    [FieldOffset(Offset = "0x28")]
    [Header("アニメーション制御用")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4006265")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x4006266")]
    [FieldOffset(Offset = "0x38")]
    [Header("開催期間")]
    [SerializeField]
    private GachaScheduleView gachaScheduleView;
    [Token(Token = "0x4006267")]
    [FieldOffset(Offset = "0x40")]
    [Header("画像類")]
    [Tooltip("ロゴ")]
    [SerializeField]
    private RawImage logoImage;
    [Token(Token = "0x4006268")]
    [FieldOffset(Offset = "0x48")]
    [Tooltip("背景画像")]
    [SerializeField]
    private RawImage backgroundImage;
    [Token(Token = "0x4006269")]
    [FieldOffset(Offset = "0x50")]
    [Tooltip("スタイル画像")]
    [SerializeField]
    private Image unitImage;
    [Token(Token = "0x400626A")]
    [FieldOffset(Offset = "0x58")]
    [Header("ガチャボタン制御用")]
    [SerializeField]
    private GameObject buttonArea;
    [Token(Token = "0x400626B")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GachaPayButtonGroup gachaPayButtonGroup;
    [Token(Token = "0x400626C")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    [Header("ガチャ切り替え")]
    private RectTransform contentTrans;
    [Token(Token = "0x400626D")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GridLayoutGroup contentGridLayoutGroup;
    [Token(Token = "0x400626E")]
    [FieldOffset(Offset = "0x78")]
    [Header("ガチャ切り替えボタン")]
    [SerializeField]
    private CommonButton leftButton;
    [Token(Token = "0x400626F")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CommonButton rightButton;
    [Token(Token = "0x4006270")]
    [FieldOffset(Offset = "0x88")]
    [Header("解放条件")]
    [SerializeField]
    private Text releaseConditionText;
    [Token(Token = "0x4006271")]
    [FieldOffset(Offset = "0x90")]
    [Header("ストーリーガチャの選択UI")]
    [SerializeField]
    private StoryGachaUnitSelectList storyGachaSelector;
    [Token(Token = "0x4006272")]
    [FieldOffset(Offset = "0x98")]
    private GameObject storyGachaUnitSelectPrefab;
    [Token(Token = "0x4006273")]
    [FieldOffset(Offset = "0xA0")]
    private int storyGachaUnitSelectIndex;
    [Token(Token = "0x4006274")]
    [FieldOffset(Offset = "0xA8")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x4006275")]
    [FieldOffset(Offset = "0xB0")]
    private GachaInfoHolder gachaInfoHolder;
    [Token(Token = "0x4006276")]
    [FieldOffset(Offset = "0xB8")]
    private string gachaName;
    [Token(Token = "0x4006277")]
    [FieldOffset(Offset = "0xC0")]
    private IGachaResourceProvider resourceProvider;
    [Token(Token = "0x4006278")]
    [FieldOffset(Offset = "0xC8")]
    private GachaDetailGroupInfo gachaDetailGroupInfo;
    [Token(Token = "0x4006279")]
    [FieldOffset(Offset = "0xD0")]
    private GachaPayButtonTab gachaPayButtonTab;
    [Token(Token = "0x400627A")]
    [FieldOffset(Offset = "0xD8")]
    private List<StoryGachaNotificationData> releaseNotifyDatas;
    [Token(Token = "0x400627B")]
    [FieldOffset(Offset = "0xE0")]
    private List<StoryGachaInfo> sortedStoryGachaInfos;
    [Token(Token = "0x400627D")]
    [FieldOffset(Offset = "0xF0")]
    public StoryGachaTop.ProvidePopupOpen ProvidePopupOpenCallback;
    [Token(Token = "0x400627E")]
    [FieldOffset(Offset = "0xF8")]
    public StoryGachaTop.PickupPopupOpen PickupPopupOpenCallback;
    [Token(Token = "0x400627F")]
    [FieldOffset(Offset = "0x100")]
    public Action<bool> SetGachaListInteractable;

    [Token(Token = "0x170012A2")]
    public Action<GachaPaymentModel> PayButtonClicked
    {
      [Token(Token = "0x6007970"), Address(RVA = "0x2295C58", Offset = "0x2295C58", VA = "0x2295C58")] get
      {
        return (Action<GachaPaymentModel>) null;
      }
      [Token(Token = "0x6007971"), Address(RVA = "0x2295C60", Offset = "0x2295C60", VA = "0x2295C60")] set
      {
      }
    }

    [Token(Token = "0x6007972")]
    [Address(RVA = "0x2295C68", Offset = "0x2295C68", VA = "0x2295C68")]
    public static void Preload(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6007973")]
    [Address(RVA = "0x2295D18", Offset = "0x2295D18", VA = "0x2295D18")]
    public static IEnumerator Create(
      AssetCachedSpawner spawner,
      Transform parent,
      Action<StoryGachaTop> onCreate)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007974")]
    [Address(RVA = "0x2295DBC", Offset = "0x2295DBC", VA = "0x2295DBC")]
    public IEnumerator Initialize(
      AssetCachedSpawner spawner,
      GachaPayButtonTab gachaPayButtonTab,
      IGachaResourceProvider resourceProvider)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007975")]
    [Address(RVA = "0x2295E6C", Offset = "0x2295E6C", VA = "0x2295E6C")]
    private void InitializePayButtonGroup(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6007976")]
    [Address(RVA = "0x2295EF8", Offset = "0x2295EF8", VA = "0x2295EF8")]
    private IEnumerator InitStoryGachaUnitSelect(AssetCachedSpawner spawner) => (IEnumerator) null;

    [Token(Token = "0x6007977")]
    [Address(RVA = "0x2295F94", Offset = "0x2295F94", VA = "0x2295F94")]
    private IEnumerator InitStoryGachaUnitSelectScroll() => (IEnumerator) null;

    [Token(Token = "0x6007978")]
    [Address(RVA = "0x2296024", Offset = "0x2296024", VA = "0x2296024")]
    private void SetupStoryGachaUnitSelect(StoryGachaUnitSelect storyGachaUnitSelect, int index)
    {
    }

    [Token(Token = "0x6007979")]
    [Address(RVA = "0x2296444", Offset = "0x2296444", VA = "0x2296444")]
    private static List<GachaPickupInfo> GetPickupInfoByGroupId(
      GachaDetailGroupInfo gachaDetailGroupInfo,
      int groupId)
    {
      return (List<GachaPickupInfo>) null;
    }

    [Token(Token = "0x600797A")]
    [Address(RVA = "0x2296544", Offset = "0x2296544", VA = "0x2296544")]
    private static int GetPickupInfoRewardIdByGroupId(
      GachaDetailGroupInfo gachaDetailGroupInfo,
      int groupId)
    {
      return new int();
    }

    [Token(Token = "0x600797B")]
    [Address(RVA = "0x2296248", Offset = "0x2296248", VA = "0x2296248")]
    private int GetRewardId(int index) => new int();

    [Token(Token = "0x600797C")]
    [Address(RVA = "0x2296638", Offset = "0x2296638", VA = "0x2296638")]
    private IEnumerator GetGachaLogoTexture(int gachaId, Action<Texture2D> onFinished)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600797D")]
    [Address(RVA = "0x22966DC", Offset = "0x22966DC", VA = "0x22966DC")]
    private IEnumerator GetGachaBGTexture(int gachaId, Action<Texture2D> onFinished)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600797E")]
    [Address(RVA = "0x2296780", Offset = "0x2296780", VA = "0x2296780")]
    private IEnumerator GetStyleImage(int styleId, Action<Sprite> onFinished) => (IEnumerator) null;

    [Token(Token = "0x600797F")]
    [Address(RVA = "0x2296824", Offset = "0x2296824", VA = "0x2296824")]
    private IEnumerator ChangeGacha(int startIndex, int endIndex) => (IEnumerator) null;

    [Token(Token = "0x6007980")]
    [Address(RVA = "0x22968C8", Offset = "0x22968C8", VA = "0x22968C8")]
    private IEnumerator GetImageResources(
      int index,
      Action<(Texture2D bgTexture, Texture2D logoTexture, Sprite styleImage)> onResourceLoad)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007981")]
    [Address(RVA = "0x2296970", Offset = "0x2296970", VA = "0x2296970")]
    private IEnumerator UpdateImages(int index) => (IEnumerator) null;

    [Token(Token = "0x6007982")]
    [Address(RVA = "0x2296A10", Offset = "0x2296A10", VA = "0x2296A10")]
    private void PlayInAnimation(StoryGachaTop.AnimationDirectionType directionType)
    {
    }

    [Token(Token = "0x6007983")]
    [Address(RVA = "0x2296B0C", Offset = "0x2296B0C", VA = "0x2296B0C")]
    private IEnumerator MoveStoryGachaUnitSelect(int startIndex, int endIndex)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007984")]
    [Address(RVA = "0x2296BAC", Offset = "0x2296BAC", VA = "0x2296BAC")]
    private void UpdateStoryGachaUnitSelect(int disabledIndex, int enabledIndex)
    {
    }

    [Token(Token = "0x6007985")]
    [Address(RVA = "0x2296E18", Offset = "0x2296E18", VA = "0x2296E18")]
    public void OnGachaDetailChanged(GachaInfoHolder gachaInfoHolder, string gachaName)
    {
    }

    [Token(Token = "0x6007986")]
    [Address(RVA = "0x2297164", Offset = "0x2297164", VA = "0x2297164")]
    private int GetCurrentGroupId() => new int();

    [Token(Token = "0x6007987")]
    [Address(RVA = "0x2296E7C", Offset = "0x2296E7C", VA = "0x2296E7C")]
    public void SetupGachaTop(GachaInfoHolder gachaInfoHolder, string gachaName)
    {
    }

    [Token(Token = "0x6007988")]
    [Address(RVA = "0x229716C", Offset = "0x229716C", VA = "0x229716C")]
    private List<StoryGachaInfo> SortStoryGachaInfos(IEnumerable<StoryGachaInfo> storyGachaInfos)
    {
      return (List<StoryGachaInfo>) null;
    }

    [Token(Token = "0x6007989")]
    [Address(RVA = "0x229733C", Offset = "0x229733C", VA = "0x229733C")]
    private void SetupSelectList(int count)
    {
    }

    [Token(Token = "0x600798A")]
    [Address(RVA = "0x2297354", Offset = "0x2297354", VA = "0x2297354")]
    private void UpdateGachaView(int index)
    {
    }

    [Token(Token = "0x600798B")]
    [Address(RVA = "0x2297AE8", Offset = "0x2297AE8", VA = "0x2297AE8")]
    public void UpdateGachaButtons()
    {
    }

    [Token(Token = "0x600798C")]
    [Address(RVA = "0x22974B4", Offset = "0x22974B4", VA = "0x22974B4")]
    private void UpdateGachaButtons(int index, bool forceFirstView)
    {
    }

    [Token(Token = "0x600798D")]
    [Address(RVA = "0x2297AF4", Offset = "0x2297AF4", VA = "0x2297AF4")]
    private bool HasPaymentTicket(int groupId) => new bool();

    [Token(Token = "0x600798E")]
    [Address(RVA = "0x2296294", Offset = "0x2296294", VA = "0x2296294")]
    private bool IsReleased(int index) => new bool();

    [Token(Token = "0x600798F")]
    [Address(RVA = "0x22965D4", Offset = "0x22965D4", VA = "0x22965D4")]
    private int GetGroupId(int index) => new int();

    [Token(Token = "0x6007990")]
    [Address(RVA = "0x2297DCC", Offset = "0x2297DCC", VA = "0x2297DCC")]
    public IEnumerator Open() => (IEnumerator) null;

    [Token(Token = "0x6007991")]
    [Address(RVA = "0x2297E5C", Offset = "0x2297E5C", VA = "0x2297E5C")]
    private void PlayTweenAnim(StoryGachaTop.TweenAnim anim, Action onFinished = null)
    {
    }

    [Token(Token = "0x6007992")]
    [Address(RVA = "0x2297E9C", Offset = "0x2297E9C", VA = "0x2297E9C")]
    public void Close()
    {
    }

    [Token(Token = "0x6007993")]
    [Address(RVA = "0x2297EE8", Offset = "0x2297EE8", VA = "0x2297EE8")]
    private IEnumerator UnlockStoryGacha() => (IEnumerator) null;

    [Token(Token = "0x6007994")]
    [Address(RVA = "0x2297F78", Offset = "0x2297F78", VA = "0x2297F78")]
    private IEnumerator UnlockAnim(int index) => (IEnumerator) null;

    [Token(Token = "0x6007995")]
    [Address(RVA = "0x2298018", Offset = "0x2298018", VA = "0x2298018")]
    private void PlayListItemTweenAnim(
      StoryGachaUnitSelect.TweenAnim tweenAnim,
      int index,
      Action onFinished)
    {
    }

    [Token(Token = "0x6007996")]
    [Address(RVA = "0x22981EC", Offset = "0x22981EC", VA = "0x22981EC")]
    public void SetInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6007997")]
    [Address(RVA = "0x2298284", Offset = "0x2298284", VA = "0x2298284")]
    private void PrepareSetTextures()
    {
    }

    [Token(Token = "0x6007998")]
    [Address(RVA = "0x22983C0", Offset = "0x22983C0", VA = "0x22983C0")]
    public void SetLogoTexture(Texture2D texture)
    {
    }

    [Token(Token = "0x6007999")]
    [Address(RVA = "0x2298400", Offset = "0x2298400", VA = "0x2298400")]
    public void SetBGTexture(Texture2D texture)
    {
    }

    [Token(Token = "0x600799A")]
    [Address(RVA = "0x2298440", Offset = "0x2298440", VA = "0x2298440")]
    public void SetStyleImage(Sprite sprite)
    {
    }

    [Token(Token = "0x600799B")]
    [Address(RVA = "0x2298480", Offset = "0x2298480", VA = "0x2298480")]
    public void OpenProvidePopup(bool isOpenRatio)
    {
    }

    [Token(Token = "0x600799C")]
    [Address(RVA = "0x22984D4", Offset = "0x22984D4", VA = "0x22984D4")]
    public void OpenPickupPopup()
    {
    }

    [Token(Token = "0x600799D")]
    [Address(RVA = "0x2298520", Offset = "0x2298520", VA = "0x2298520")]
    private void OnUpdateListItem(int index, InfiniteCellBase view)
    {
    }

    [Token(Token = "0x600799E")]
    [Address(RVA = "0x22985FC", Offset = "0x22985FC", VA = "0x22985FC")]
    public StoryGachaTop()
    {
    }

    [Token(Token = "0x2001572")]
    private enum AnimationDirectionType
    {
      [Token(Token = "0x4006281")] Left,
      [Token(Token = "0x4006282")] Right,
    }

    [Token(Token = "0x2001573")]
    public enum TweenAnim
    {
      [Token(Token = "0x4006284")] Lock,
      [Token(Token = "0x4006285")] Enabled,
      [Token(Token = "0x4006286")] Unlock,
    }

    [Token(Token = "0x2001574")]
    public delegate void ProvidePopupOpen(string gachaName, int groupId, bool isOpenRatio);

    [Token(Token = "0x2001575")]
    public delegate void PickupPopupOpen(string gachaName, int groupId);
  }
}
