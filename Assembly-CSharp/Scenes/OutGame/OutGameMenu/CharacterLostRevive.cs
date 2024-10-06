// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.CharacterLostRevive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x20039A7")]
  public class CharacterLostRevive : MonoBehaviour
  {
    [Token(Token = "0x400FBF3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton skipButton;
    [Token(Token = "0x400FBF4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton commercialLawButton;
    [Token(Token = "0x400FBF5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton decisionButton;
    [Token(Token = "0x400FBF6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400FBF7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text reviveMessageText;
    [Token(Token = "0x400FBF8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image charImage;
    [Token(Token = "0x400FBF9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image charImageLoop;
    [Token(Token = "0x400FBFA")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI lostRecoveryTimeText;
    [Token(Token = "0x400FBFB")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text recoveryCoinText;
    [Token(Token = "0x400FBFC")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text paidCoinText;
    [Token(Token = "0x400FBFD")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text freeCoinText;
    [Token(Token = "0x400FBFE")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CanvasGroup topCanvasGroup;
    [Token(Token = "0x400FBFF")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject[] reviveModeEreaseObj;
    [Token(Token = "0x400FC00")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CanvasGroup Container_Lost;
    [Token(Token = "0x400FC01")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400FC02")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private PlayableDirector timeLinePlayableDirector;
    [Token(Token = "0x400FC03")]
    private const string inoutTimeLineAssetbundleName = "ui_page_characterlist_timeline";
    [Token(Token = "0x400FC04")]
    [FieldOffset(Offset = "0x98")]
    private bool isTimelineDirection;
    [Token(Token = "0x400FC05")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    private Color shortageColor;
    [Token(Token = "0x400FC06")]
    [FieldOffset(Offset = "0xB0")]
    private string[] timeLineSettingNameList;
    [Token(Token = "0x400FC07")]
    [FieldOffset(Offset = "0xB8")]
    private CharacterLostRevive.eLostReviveMode execMode;
    [Token(Token = "0x400FC08")]
    [FieldOffset(Offset = "0xBC")]
    private CharacterLostRevive.eLostReviveState state;
    [Token(Token = "0x400FC09")]
    [FieldOffset(Offset = "0xC0")]
    private List<Character> charaList;
    [Token(Token = "0x400FC0A")]
    [FieldOffset(Offset = "0xC8")]
    private int charaListIndex;
    [Token(Token = "0x400FC0B")]
    [FieldOffset(Offset = "0xCC")]
    private bool isNext;
    [Token(Token = "0x400FC0C")]
    [FieldOffset(Offset = "0xCD")]
    private bool isClose;
    [Token(Token = "0x400FC0D")]
    [FieldOffset(Offset = "0xCE")]
    private bool isSkip;
    [Token(Token = "0x400FC0E")]
    [FieldOffset(Offset = "0xCF")]
    private bool isCameback;
    [Token(Token = "0x400FC0F")]
    [FieldOffset(Offset = "0xD0")]
    private bool isReOpen;
    [Token(Token = "0x400FC10")]
    [FieldOffset(Offset = "0xD8")]
    private Coroutine CalcLostRecoveryTimeCoroutine;
    [Token(Token = "0x400FC11")]
    [FieldOffset(Offset = "0xE0")]
    private TimeSpan lostRecoveryTime;
    [Token(Token = "0x400FC12")]
    [FieldOffset(Offset = "0xE8")]
    public Action<CharacterLostRevive.eLostReviveState> finish;
    [Token(Token = "0x400FC13")]
    [FieldOffset(Offset = "0xF0")]
    private int lostRecoveryCount;
    [Token(Token = "0x400FC14")]
    [FieldOffset(Offset = "0xF8")]
    private TimeSpan lostRecoveryTimeDispLimit;
    [Token(Token = "0x400FC15")]
    [FieldOffset(Offset = "0x100")]
    private float ReviveWaitTime;
    [Token(Token = "0x400FC16")]
    [FieldOffset(Offset = "0x104")]
    private bool isTimeLineSkip;
    [Token(Token = "0x400FC17")]
    [FieldOffset(Offset = "0x105")]
    private bool isTimeLineSkipped;
    [Token(Token = "0x400FC18")]
    [FieldOffset(Offset = "0x108")]
    private DateTime ReviveStartTime;

    [Token(Token = "0x17004A87")]
    public PlayableDirector TimeLinePlayableDirector
    {
      [Token(Token = "0x6016A57"), Address(RVA = "0x3F61200", Offset = "0x3F61200", VA = "0x3F61200")] get
      {
        return (PlayableDirector) null;
      }
    }

    [Token(Token = "0x6016A58")]
    [Address(RVA = "0x3F61208", Offset = "0x3F61208", VA = "0x3F61208")]
    private void Awake()
    {
    }

    [Token(Token = "0x6016A59")]
    [Address(RVA = "0x3F6076C", Offset = "0x3F6076C", VA = "0x3F6076C")]
    public void Initialized(
      CharacterLostRevive.eLostReviveMode mode,
      List<Character> characterDataList,
      int num = 0,
      Action<CharacterLostRevive.eLostReviveState> _finish = null)
    {
    }

    [Token(Token = "0x6016A5A")]
    [Address(RVA = "0x3F61304", Offset = "0x3F61304", VA = "0x3F61304")]
    public void NextButton()
    {
    }

    [Token(Token = "0x6016A5B")]
    [Address(RVA = "0x3F61334", Offset = "0x3F61334", VA = "0x3F61334")]
    private void SetTexts(Character characterData)
    {
    }

    [Token(Token = "0x6016A5C")]
    [Address(RVA = "0x3F6195C", Offset = "0x3F6195C", VA = "0x3F6195C")]
    private void SkipTimeline()
    {
    }

    [Token(Token = "0x6016A5D")]
    [Address(RVA = "0x3F6129C", Offset = "0x3F6129C", VA = "0x3F6129C")]
    private IEnumerator Management() => (IEnumerator) null;

    [Token(Token = "0x6016A5E")]
    [Address(RVA = "0x3F61AFC", Offset = "0x3F61AFC", VA = "0x3F61AFC")]
    private IEnumerator SetReopen() => (IEnumerator) null;

    [Token(Token = "0x6016A5F")]
    [Address(RVA = "0x3F6188C", Offset = "0x3F6188C", VA = "0x3F6188C")]
    private IEnumerator LoadCharacterImage() => (IEnumerator) null;

    [Token(Token = "0x6016A60")]
    [Address(RVA = "0x3F61228", Offset = "0x3F61228", VA = "0x3F61228")]
    private IEnumerator ConnectApi(Action finish = null) => (IEnumerator) null;

    [Token(Token = "0x6016A61")]
    [Address(RVA = "0x3F61BDC", Offset = "0x3F61BDC", VA = "0x3F61BDC")]
    private IEnumerator LostRecoveryConnectApi(int id, int num, Action finish)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016A62")]
    [Address(RVA = "0x3F61C80", Offset = "0x3F61C80", VA = "0x3F61C80")]
    public void Open()
    {
    }

    [Token(Token = "0x6016A63")]
    [Address(RVA = "0x3F61D94", Offset = "0x3F61D94", VA = "0x3F61D94")]
    public void Close()
    {
    }

    [Token(Token = "0x6016A64")]
    [Address(RVA = "0x3F61E28", Offset = "0x3F61E28", VA = "0x3F61E28")]
    public void Revive()
    {
    }

    [Token(Token = "0x6016A65")]
    [Address(RVA = "0x3F61EBC", Offset = "0x3F61EBC", VA = "0x3F61EBC")]
    public void Loop()
    {
    }

    [Token(Token = "0x6016A66")]
    [Address(RVA = "0x3F61D14", Offset = "0x3F61D14", VA = "0x3F61D14")]
    private IEnumerator playTimeline(UITimelineController.DirectionType inout, Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016A67")]
    [Address(RVA = "0x3F618F4", Offset = "0x3F618F4", VA = "0x3F618F4")]
    private IEnumerator CalcLostRecoveryTime() => (IEnumerator) null;

    [Token(Token = "0x6016A68")]
    [Address(RVA = "0x3F61F34", Offset = "0x3F61F34", VA = "0x3F61F34")]
    public IEnumerator ShowToasterAndWait(string key) => (IEnumerator) null;

    [Token(Token = "0x6016A69")]
    [Address(RVA = "0x3F61FC4", Offset = "0x3F61FC4", VA = "0x3F61FC4")]
    public CharacterLostRevive()
    {
    }

    [Token(Token = "0x20039A8")]
    public enum eTimelineMode
    {
      [Token(Token = "0x400FC1A")] PopInOut,
      [Token(Token = "0x400FC1B")] ToRevive_Loop,
    }

    [Token(Token = "0x20039A9")]
    public enum eLostReviveMode
    {
      [Token(Token = "0x400FC1D")] Revive,
      [Token(Token = "0x400FC1E")] LostRevive,
    }

    [Token(Token = "0x20039AA")]
    public enum eLostReviveState
    {
      [Token(Token = "0x400FC20")] Init,
      [Token(Token = "0x400FC21")] WaitImageLoad,
      [Token(Token = "0x400FC22")] ImageLoaded,
      [Token(Token = "0x400FC23")] Open,
      [Token(Token = "0x400FC24")] ReviveOpen,
      [Token(Token = "0x400FC25")] NotRevive,
      [Token(Token = "0x400FC26")] Loop,
      [Token(Token = "0x400FC27")] ToRevive,
      [Token(Token = "0x400FC28")] ReviveLoop,
      [Token(Token = "0x400FC29")] Close,
      [Token(Token = "0x400FC2A")] ReviveClose,
      [Token(Token = "0x400FC2B")] TimeRevive,
      [Token(Token = "0x400FC2C")] ReOpenClose,
      [Token(Token = "0x400FC2D")] ReOpenCloseEnd,
      [Token(Token = "0x400FC2E")] End,
    }
  }
}
