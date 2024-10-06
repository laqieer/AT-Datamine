// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.PocketBookHeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using FreeMap.State;
using GameCore.Input;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.API;
using Scenes.Story.Common;
using Scenes.Story.PocketBook.CalenderData;
using Scenes.Story.PocketBook.ProfileData;
using Scenes.Story.PocketBook.StoryIndex;
using Story.APIResult;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook
{
  [Token(Token = "0x2002D96")]
  public class PocketBookHeader : MonoBehaviour
  {
    [Token(Token = "0x400C3D8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400C3D9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x400C3DA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400C3DB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("---日付の標準色")]
    private Color defaultDateColor;
    [Token(Token = "0x400C3DC")]
    [FieldOffset(Offset = "0x40")]
    [Header("---土曜日の色")]
    [SerializeField]
    private Color satdayColor;
    [Token(Token = "0x400C3DD")]
    [FieldOffset(Offset = "0x50")]
    [Header("---日曜及び祝祭日の色")]
    [SerializeField]
    private Color sunDayColor;
    [Token(Token = "0x400C3DE")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    [Header("---日月管理")]
    private GameObject monthlyObject;
    [Token(Token = "0x400C3DF")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text monthText;
    [Token(Token = "0x400C3E0")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Image img_line;
    [Token(Token = "0x400C3E1")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text dayText;
    [Token(Token = "0x400C3E2")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text weekText;
    [Token(Token = "0x400C3E3")]
    [FieldOffset(Offset = "0x88")]
    [Header("---日数管理")]
    [SerializeField]
    private GameObject daysObject;
    [Token(Token = "0x400C3E4")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text daysUnitText;
    [Token(Token = "0x400C3E5")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text daysText;
    [Token(Token = "0x400C3E6")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    [Space(10f)]
    private WeatherIcon weatherIcon;
    [Token(Token = "0x400C3E7")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject imgBgDeco;
    [Token(Token = "0x400C3E8")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private PocketBookAnimation pocketBookAnimation;
    [Token(Token = "0x400C3E9")]
    [FieldOffset(Offset = "0xB8")]
    [Header("タブ：インデックス")]
    [SerializeField]
    private Toggle tabIndex;
    [Token(Token = "0x400C3EA")]
    [FieldOffset(Offset = "0xC0")]
    [Header("タブ：時間経過")]
    [SerializeField]
    private Toggle tabTimeSkip;
    [Token(Token = "0x400C3EB")]
    [FieldOffset(Offset = "0xC8")]
    [Header("タブ：プロファイル")]
    [SerializeField]
    private Toggle tabProfile;
    [Token(Token = "0x400C3EC")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    [Header("タブ：閉じる")]
    private Toggle tabClose;
    [Token(Token = "0x400C3ED")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400C3EE")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    [Header("トップのCanvasGroup")]
    private CanvasGroup topTabCanvasGroup;
    [Token(Token = "0x400C3EF")]
    [FieldOffset(Offset = "0xE8")]
    private PocketBookLoader loader;
    [Token(Token = "0x400C3F0")]
    [FieldOffset(Offset = "0xF0")]
    private PocketBookCommonPopup popup;
    [Token(Token = "0x400C3F1")]
    [FieldOffset(Offset = "0xF8")]
    private CalendarPopupHandler calendarPopupHandler;
    [Token(Token = "0x400C3F2")]
    [FieldOffset(Offset = "0x100")]
    private Transform popupParent;
    [Token(Token = "0x400C3F3")]
    [FieldOffset(Offset = "0x108")]
    private SpriteAtlas spriteAtlas;
    [Token(Token = "0x400C3F4")]
    [FieldOffset(Offset = "0x110")]
    private Action onFinishInAnim;
    [Token(Token = "0x400C3F5")]
    [FieldOffset(Offset = "0x118")]
    private PocketBookTimeSkip timeSkip;
    [Token(Token = "0x400C3F6")]
    [FieldOffset(Offset = "0x120")]
    private PocketBookProfileDataContainer profileDataContainer;
    [Token(Token = "0x400C3F7")]
    [FieldOffset(Offset = "0x128")]
    private CanvasGroup storyIndexCanvasGroup;
    [Token(Token = "0x400C3F8")]
    [FieldOffset(Offset = "0x130")]
    private PocketBookStoryIndex pocketBookStoryIndex;
    [Token(Token = "0x400C3FA")]
    [FieldOffset(Offset = "0x140")]
    private bool interactable;
    [Token(Token = "0x400C3FB")]
    [FieldOffset(Offset = "0x144")]
    private PocketBookHeader.ViewType prevViewType;
    [Token(Token = "0x400C3FC")]
    [FieldOffset(Offset = "0x148")]
    private PocketBookHeader.ViewType nowViewType;
    [Token(Token = "0x400C3FD")]
    [FieldOffset(Offset = "0x150")]
    private APIStoryFreeactionSkip skipAPI;
    [Token(Token = "0x400C3FE")]
    [FieldOffset(Offset = "0x158")]
    private FreeActionSkip skipAPIresultCommon;
    [Token(Token = "0x400C400")]
    [FieldOffset(Offset = "0x161")]
    private bool isButtonClick;
    [Token(Token = "0x400C401")]
    [FieldOffset(Offset = "0x162")]
    private bool isConnect;

    [Token(Token = "0x17003CE6")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6011D31"), Address(RVA = "0x3FA1548", Offset = "0x3FA1548", VA = "0x3FA1548")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003CE7")]
    public RectTransform Content
    {
      [Token(Token = "0x6011D32"), Address(RVA = "0x3FA1550", Offset = "0x3FA1550", VA = "0x3FA1550")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003CE8")]
    private PocketBookTimeSkip TimeSkip
    {
      [Token(Token = "0x6011D33"), Address(RVA = "0x3FA1558", Offset = "0x3FA1558", VA = "0x3FA1558")] get
      {
        return (PocketBookTimeSkip) null;
      }
    }

    [Token(Token = "0x17003CE9")]
    private PocketBookProfileDataContainer ProfileDataContainer
    {
      [Token(Token = "0x6011D34"), Address(RVA = "0x3FA1688", Offset = "0x3FA1688", VA = "0x3FA1688")] get
      {
        return (PocketBookProfileDataContainer) null;
      }
    }

    [Token(Token = "0x17003CEA")]
    public PocketBookStoryIndex PocketBookStoryIndex
    {
      [Token(Token = "0x6011D35"), Address(RVA = "0x3FA17B8", Offset = "0x3FA17B8", VA = "0x3FA17B8")] get
      {
        return (PocketBookStoryIndex) null;
      }
    }

    [Token(Token = "0x17003CEB")]
    public IPocketBookEventHandler PocketBookEventHandler
    {
      [Token(Token = "0x6011D36"), Address(RVA = "0x3FA1888", Offset = "0x3FA1888", VA = "0x3FA1888")] get
      {
        return (IPocketBookEventHandler) null;
      }
      [Token(Token = "0x6011D37"), Address(RVA = "0x3FA1890", Offset = "0x3FA1890", VA = "0x3FA1890")] set
      {
      }
    }

    [Token(Token = "0x6011D38")]
    [Address(RVA = "0x3FA1898", Offset = "0x3FA1898", VA = "0x3FA1898")]
    public void Interactable(bool interactable)
    {
    }

    [Token(Token = "0x6011D39")]
    [Address(RVA = "0x3FA18C0", Offset = "0x3FA18C0", VA = "0x3FA18C0")]
    public void SetInteractableTop(bool interactable)
    {
    }

    [Token(Token = "0x17003CEC")]
    public bool IsTimeSkipped
    {
      [Token(Token = "0x6011D3A"), Address(RVA = "0x3FA18E0", Offset = "0x3FA18E0", VA = "0x3FA18E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6011D3B"), Address(RVA = "0x3FA18E8", Offset = "0x3FA18E8", VA = "0x3FA18E8")] private set
      {
      }
    }

    [Token(Token = "0x6011D3C")]
    [Address(RVA = "0x3FA18F4", Offset = "0x3FA18F4", VA = "0x3FA18F4")]
    public IEnumerator SetDate() => (IEnumerator) null;

    [Token(Token = "0x6011D3D")]
    [Address(RVA = "0x3FA1984", Offset = "0x3FA1984", VA = "0x3FA1984")]
    public IEnumerator InitializeIndex(
      CurrentFreeActionParam currentFreeactionParam,
      FreeMapStateManager entity)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011D3E")]
    [Address(RVA = "0x3FA1A28", Offset = "0x3FA1A28", VA = "0x3FA1A28")]
    public IEnumerator In() => (IEnumerator) null;

    [Token(Token = "0x6011D3F")]
    [Address(RVA = "0x3FA1AB8", Offset = "0x3FA1AB8", VA = "0x3FA1AB8")]
    private static void Show(CanvasGroup canvasGroup)
    {
    }

    [Token(Token = "0x6011D40")]
    [Address(RVA = "0x3FA1B3C", Offset = "0x3FA1B3C", VA = "0x3FA1B3C")]
    private static void Hide(CanvasGroup canvasGroup)
    {
    }

    [Token(Token = "0x6011D41")]
    [Address(RVA = "0x3FA1BC0", Offset = "0x3FA1BC0", VA = "0x3FA1BC0")]
    private void UpdateViewType(PocketBookHeader.ViewType viewType)
    {
    }

    [Token(Token = "0x6011D42")]
    [Address(RVA = "0x3FA1CB4", Offset = "0x3FA1CB4", VA = "0x3FA1CB4")]
    private void PlayToInAnim()
    {
    }

    [Token(Token = "0x6011D43")]
    [Address(RVA = "0x3FA1C78", Offset = "0x3FA1C78", VA = "0x3FA1C78")]
    private void PlayToOutAnim(Action finishAction)
    {
    }

    [Token(Token = "0x6011D44")]
    [Address(RVA = "0x3FA246C", Offset = "0x3FA246C", VA = "0x3FA246C")]
    public void ShowCalendarPopup()
    {
    }

    [Token(Token = "0x6011D45")]
    [Address(RVA = "0x3FA1CE4", Offset = "0x3FA1CE4", VA = "0x3FA1CE4")]
    private void PlayInToStoryIndexAnim(Action finishCallback)
    {
    }

    [Token(Token = "0x6011D46")]
    [Address(RVA = "0x3FA1CFC", Offset = "0x3FA1CFC", VA = "0x3FA1CFC")]
    private void PlayInToTimeSkipAnim(Action finishCallback)
    {
    }

    [Token(Token = "0x6011D47")]
    [Address(RVA = "0x3FA1E98", Offset = "0x3FA1E98", VA = "0x3FA1E98")]
    private void PlayInToProfileAnim(Action finishCallback)
    {
    }

    [Token(Token = "0x6011D48")]
    [Address(RVA = "0x3FA209C", Offset = "0x3FA209C", VA = "0x3FA209C")]
    private void PlayOutToStoryIndexAnim(Action finishCallback)
    {
    }

    [Token(Token = "0x6011D49")]
    [Address(RVA = "0x3FA20CC", Offset = "0x3FA20CC", VA = "0x3FA20CC")]
    private void PlayOutToTimeSkip(Action finishAction)
    {
    }

    [Token(Token = "0x6011D4A")]
    [Address(RVA = "0x3FA2268", Offset = "0x3FA2268", VA = "0x3FA2268")]
    private void PlayOutToProfileAnim(Action finishAction)
    {
    }

    [Token(Token = "0x6011D4B")]
    [Address(RVA = "0x3FA2A08", Offset = "0x3FA2A08", VA = "0x3FA2A08")]
    public void SetLoader(PocketBookLoader loader)
    {
    }

    [Token(Token = "0x6011D4C")]
    [Address(RVA = "0x3FA2B44", Offset = "0x3FA2B44", VA = "0x3FA2B44")]
    private void ResetTabBGState()
    {
    }

    [Token(Token = "0x6011D4D")]
    [Address(RVA = "0x3FA2C7C", Offset = "0x3FA2C7C", VA = "0x3FA2C7C")]
    public void OnClickToToday()
    {
    }

    [Token(Token = "0x6011D4E")]
    [Address(RVA = "0x3FA2D04", Offset = "0x3FA2D04", VA = "0x3FA2D04")]
    public void OnClickYesterday()
    {
    }

    [Token(Token = "0x6011D4F")]
    [Address(RVA = "0x3FA2D08", Offset = "0x3FA2D08", VA = "0x3FA2D08")]
    public void OnClickTomorrow()
    {
    }

    [Token(Token = "0x6011D50")]
    [Address(RVA = "0x3FA2D0C", Offset = "0x3FA2D0C", VA = "0x3FA2D0C")]
    public void OnClickToChart()
    {
    }

    [Token(Token = "0x6011D51")]
    [Address(RVA = "0x3FA2D2C", Offset = "0x3FA2D2C", VA = "0x3FA2D2C")]
    public void OnClickToChoice()
    {
    }

    [Token(Token = "0x6011D52")]
    [Address(RVA = "0x3FA2D30", Offset = "0x3FA2D30", VA = "0x3FA2D30")]
    public void OnClickToTimeSkip()
    {
    }

    [Token(Token = "0x6011D53")]
    [Address(RVA = "0x3FA3384", Offset = "0x3FA3384", VA = "0x3FA3384")]
    public void OnClickToProfile()
    {
    }

    [Token(Token = "0x6011D54")]
    [Address(RVA = "0x3FA3478", Offset = "0x3FA3478", VA = "0x3FA3478")]
    public void OnClickToClose()
    {
    }

    [Token(Token = "0x6011D55")]
    [Address(RVA = "0x3FA3590", Offset = "0x3FA3590", VA = "0x3FA3590")]
    private IEnumerator SkipAPICoroutine() => (IEnumerator) null;

    [Token(Token = "0x6011D56")]
    [Address(RVA = "0x3FA3620", Offset = "0x3FA3620", VA = "0x3FA3620")]
    private void OnSucceededSkipAPI(APIStoryFreeactionSkipResponse response)
    {
    }

    [Token(Token = "0x6011D57")]
    [Address(RVA = "0x3FA37B4", Offset = "0x3FA37B4", VA = "0x3FA37B4")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6011D58")]
    [Address(RVA = "0x3FA330C", Offset = "0x3FA330C", VA = "0x3FA330C")]
    public PocketBookCommonPopupHandler GetCommonPopupHandler()
    {
      return (PocketBookCommonPopupHandler) null;
    }

    [Token(Token = "0x6011D59")]
    [Address(RVA = "0x3FA39B8", Offset = "0x3FA39B8", VA = "0x3FA39B8")]
    public PocketBookHeader()
    {
    }

    [Token(Token = "0x2002D97")]
    public enum ViewType
    {
      [Token(Token = "0x400C403")] Today,
      [Token(Token = "0x400C404")] Map,
      [Token(Token = "0x400C405")] Chart,
      [Token(Token = "0x400C406")] TimeSkip,
      [Token(Token = "0x400C407")] Profile,
      [Token(Token = "0x400C408")] Close,
    }
  }
}
