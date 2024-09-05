// Decompiled with JetBrains decompiler
// Type: Scenes.Title.TitleMenuView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Tween;
using GlobalMenu;
using Il2CppDummyDll;
using Scenes.Option;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x200292B")]
  public class TitleMenuView : MonoBehaviour
  {
    [Token(Token = "0x400AF8C")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string TitleMenuCacheClearPopupPath;
    [Token(Token = "0x400AF8D")]
    [FieldOffset(Offset = "0x18")]
    [Header("入力制御用")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400AF8E")]
    [FieldOffset(Offset = "0x20")]
    [Header("タイムライン")]
    [SerializeField]
    [Space]
    private UITimelineController timelineController;
    [Token(Token = "0x400AF8F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Header("サイドメニュー")]
    [Space]
    private MenuButtonList menuButtonList;
    [Token(Token = "0x400AF90")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Space]
    [Header("ウィンドウ内に表示するもの")]
    private Text textTitle;
    [Token(Token = "0x400AF91")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Tooltip("設定")]
    private GameObject objectConfig;
    [Token(Token = "0x400AF92")]
    [FieldOffset(Offset = "0x40")]
    [Tooltip("各種表記")]
    [SerializeField]
    private GameObject objectRules;
    [Token(Token = "0x400AF93")]
    [FieldOffset(Offset = "0x48")]
    [Tooltip("所持伝晶石")]
    [SerializeField]
    private GameObject objectCurrency;
    [Token(Token = "0x400AF94")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    [Tooltip("サポート")]
    private GameObject objectSupports;
    [Token(Token = "0x400AF95")]
    [FieldOffset(Offset = "0x58")]
    [Space]
    [Header("設定")]
    [SerializeField]
    private GlobalMenuOption option;
    [Token(Token = "0x400AF96")]
    [FieldOffset(Offset = "0x60")]
    [Header("Tween制御用")]
    [SerializeField]
    [Space]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400AF97")]
    [FieldOffset(Offset = "0x68")]
    [Space]
    [Header("各種表記")]
    [SerializeField]
    private ContainerLegalsMenu containerLegalsMenu;
    [Token(Token = "0x400AF98")]
    [FieldOffset(Offset = "0x70")]
    [Space]
    [Header("サポート")]
    [SerializeField]
    private ContainerSupportMenu containerSupportMenu;
    [Token(Token = "0x400AF99")]
    [FieldOffset(Offset = "0x78")]
    [Header("所持伝晶石")]
    [SerializeField]
    [Space]
    private ContainerCoinBalanceDetails containerCoinBalanceDetails;
    [Token(Token = "0x400AF9A")]
    [FieldOffset(Offset = "0x80")]
    [Header("ボタン")]
    [SerializeField]
    [Space]
    private Button buttonClose;
    [Token(Token = "0x400AF9B")]
    [FieldOffset(Offset = "0x88")]
    [Space]
    [Header("ビデオプレイヤー")]
    [SerializeField]
    private TitleMoviePlayer moviePlayer;
    [Token(Token = "0x400AF9C")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton stopButton;
    [Token(Token = "0x400AF9D")]
    [FieldOffset(Offset = "0x98")]
    [Header("BackKeyハンドラー")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400AF9E")]
    [FieldOffset(Offset = "0xA0")]
    private Action onClickClose;
    [Token(Token = "0x400AF9F")]
    [FieldOffset(Offset = "0xA8")]
    private Action onMovieStart;
    [Token(Token = "0x400AFA0")]
    [FieldOffset(Offset = "0xB0")]
    private Action onMovieEnd;
    [Token(Token = "0x400AFA1")]
    [FieldOffset(Offset = "0xB8")]
    private GameObject[] rootContents;
    [Token(Token = "0x400AFA2")]
    [FieldOffset(Offset = "0xC0")]
    private TitleMenuCacheClearPopup cacheClearPopup;
    [Token(Token = "0x400AFA3")]
    [FieldOffset(Offset = "0xC8")]
    private GlobalMenuOptionSetting.OptionMenu currentContents;
    [Token(Token = "0x400AFA4")]
    private const string inAnimeTitleText = "TitleTxt_In";
    [Token(Token = "0x400AFA5")]
    private const string outAnimeTitleText = "TitleTxt_Ont";
    [Token(Token = "0x400AFA6")]
    [FieldOffset(Offset = "0xD0")]
    private Dictionary<GlobalMenuOptionSetting.OptionMenu, string> inAnimeDatas;
    [Token(Token = "0x400AFA7")]
    [FieldOffset(Offset = "0xD8")]
    private Dictionary<GlobalMenuOptionSetting.OptionMenu, string> outAnimeDatas;

    [Token(Token = "0x601031C")]
    [Address(RVA = "0x474D450", Offset = "0x474D450", VA = "0x474D450")]
    private void Awake()
    {
    }

    [Token(Token = "0x601031D")]
    [Address(RVA = "0x474D6DC", Offset = "0x474D6DC", VA = "0x474D6DC")]
    public IEnumerator Initialize(Action onClickClose) => (IEnumerator) null;

    [Token(Token = "0x601031E")]
    [Address(RVA = "0x474D778", Offset = "0x474D778", VA = "0x474D778")]
    private IEnumerator PlayInOutAnim(MenuButtonInfo menuButtonInfo) => (IEnumerator) null;

    [Token(Token = "0x601031F")]
    [Address(RVA = "0x474D814", Offset = "0x474D814", VA = "0x474D814")]
    private void OnClickSideMenuButton(MenuButtonInfo menuButtonInfo)
    {
    }

    [Token(Token = "0x6010320")]
    [Address(RVA = "0x474D960", Offset = "0x474D960", VA = "0x474D960")]
    private void SetTitleText(string text)
    {
    }

    [Token(Token = "0x6010321")]
    [Address(RVA = "0x474D984", Offset = "0x474D984", VA = "0x474D984")]
    public void Open(Action onFinished)
    {
    }

    [Token(Token = "0x6010322")]
    [Address(RVA = "0x474D9F8", Offset = "0x474D9F8", VA = "0x474D9F8")]
    public void Close(Action onFinished)
    {
    }

    [Token(Token = "0x6010323")]
    [Address(RVA = "0x474DA5C", Offset = "0x474DA5C", VA = "0x474DA5C")]
    public void SetMovieAction(Action onMovieStart, Action onMovieEnd)
    {
    }

    [Token(Token = "0x6010324")]
    [Address(RVA = "0x474D8EC", Offset = "0x474D8EC", VA = "0x474D8EC")]
    private IEnumerator RequestCoinBalance(Action<(int paidCoin, int freeCoin)> onSuccess)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010325")]
    [Address(RVA = "0x474DA8C", Offset = "0x474DA8C", VA = "0x474DA8C")]
    public void OnClickCacheClear()
    {
    }

    [Token(Token = "0x6010326")]
    [Address(RVA = "0x474DAAC", Offset = "0x474DAAC", VA = "0x474DAAC")]
    private IEnumerator OpenCacheClearPopup() => (IEnumerator) null;

    [Token(Token = "0x6010327")]
    [Address(RVA = "0x474DB3C", Offset = "0x474DB3C", VA = "0x474DB3C")]
    public void OnClickVideo()
    {
    }

    [Token(Token = "0x6010328")]
    [Address(RVA = "0x474DBC4", Offset = "0x474DBC4", VA = "0x474DBC4")]
    public void OnClickStopVideo()
    {
    }

    [Token(Token = "0x6010329")]
    [Address(RVA = "0x474DB5C", Offset = "0x474DB5C", VA = "0x474DB5C")]
    private IEnumerator PlayVideo() => (IEnumerator) null;

    [Token(Token = "0x601032A")]
    [Address(RVA = "0x474DBC8", Offset = "0x474DBC8", VA = "0x474DBC8")]
    private void StopVideo()
    {
    }

    [Token(Token = "0x601032B")]
    [Address(RVA = "0x474DCEC", Offset = "0x474DCEC", VA = "0x474DCEC")]
    public void OnClickBatchDownload()
    {
    }

    [Token(Token = "0x601032C")]
    [Address(RVA = "0x474DD0C", Offset = "0x474DD0C", VA = "0x474DD0C")]
    private IEnumerator BatchDownload() => (IEnumerator) null;

    [Token(Token = "0x601032D")]
    [Address(RVA = "0x474DD94", Offset = "0x474DD94", VA = "0x474DD94")]
    public TitleMenuView()
    {
    }

    [Token(Token = "0x601032E")]
    [Address(RVA = "0x474DF98", Offset = "0x474DF98", VA = "0x474DF98")]
    static TitleMenuView()
    {
    }
  }
}
