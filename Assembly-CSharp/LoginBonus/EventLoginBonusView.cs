// Decompiled with JetBrains decompiler
// Type: LoginBonus.EventLoginBonusView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AD4")]
  public class EventLoginBonusView : MonoBehaviour
  {
    [Token(Token = "0x40031BC")]
    private const int MAX_ONE_LINE_REWARD = 7;
    [Token(Token = "0x40031BD")]
    private const int ROW_HEIGHT = 145;
    [Token(Token = "0x40031BE")]
    [FieldOffset(Offset = "0x18")]
    private List<EventLoginBonusRewardItem> eventLoginBonusRewardItems;
    [Token(Token = "0x40031BF")]
    [FieldOffset(Offset = "0x20")]
    private UITimelineController timelineController;
    [Token(Token = "0x40031C0")]
    [FieldOffset(Offset = "0x28")]
    private EventLoginBonusResource resource;
    [Token(Token = "0x40031C1")]
    [FieldOffset(Offset = "0x30")]
    private GameObject reward1Line;
    [Token(Token = "0x40031C2")]
    [FieldOffset(Offset = "0x38")]
    private Transform reward1LineContainerIconList;
    [Token(Token = "0x40031C3")]
    [FieldOffset(Offset = "0x40")]
    private GameObject reward2Line;
    [Token(Token = "0x40031C4")]
    [FieldOffset(Offset = "0x48")]
    private RectTransform reward2LineContent;
    [Token(Token = "0x40031C5")]
    [FieldOffset(Offset = "0x50")]
    private GameObject date1Line;
    [Token(Token = "0x40031C6")]
    [FieldOffset(Offset = "0x58")]
    private Text date1LineTxt;
    [Token(Token = "0x40031C7")]
    [FieldOffset(Offset = "0x60")]
    private GameObject date2Line;
    [Token(Token = "0x40031C8")]
    [FieldOffset(Offset = "0x68")]
    private Text date2LineTxt;
    [Token(Token = "0x40031C9")]
    [FieldOffset(Offset = "0x70")]
    private Scrollbar scrollbar;
    [Token(Token = "0x40031CA")]
    [FieldOffset(Offset = "0x78")]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40031CB")]
    [FieldOffset(Offset = "0x80")]
    private GameObject containerButtonTapNext;
    [Token(Token = "0x40031CC")]
    [FieldOffset(Offset = "0x88")]
    private GameObject containerButtonSkip;
    [Token(Token = "0x40031CD")]
    [FieldOffset(Offset = "0x90")]
    private CommonButton nextButton;
    [Token(Token = "0x40031CE")]
    [FieldOffset(Offset = "0x98")]
    private CommonButton skipButton;
    [Token(Token = "0x40031CF")]
    [FieldOffset(Offset = "0xA0")]
    private RawImage imgBgPanel;
    [Token(Token = "0x40031D0")]
    [FieldOffset(Offset = "0xA8")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x40031D3")]
    [FieldOffset(Offset = "0xB8")]
    private Action<ILoginBonusRewardUIParam> onRewardItemClicked;

    [Token(Token = "0x170008E0")]
    public bool IsEnabledNextButton
    {
      [Token(Token = "0x6003DA9"), Address(RVA = "0x2C11380", Offset = "0x2C11380", VA = "0x2C11380")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003DAA"), Address(RVA = "0x2C11388", Offset = "0x2C11388", VA = "0x2C11388")] private set
      {
      }
    }

    [Token(Token = "0x170008E1")]
    public bool IsEnabledSkipButton
    {
      [Token(Token = "0x6003DAB"), Address(RVA = "0x2C11394", Offset = "0x2C11394", VA = "0x2C11394")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003DAC"), Address(RVA = "0x2C1139C", Offset = "0x2C1139C", VA = "0x2C1139C")] private set
      {
      }
    }

    [Token(Token = "0x6003DAD")]
    [Address(RVA = "0x2C113A8", Offset = "0x2C113A8", VA = "0x2C113A8")]
    private void Start()
    {
    }

    [Token(Token = "0x6003DAE")]
    [Address(RVA = "0x2C113AC", Offset = "0x2C113AC", VA = "0x2C113AC")]
    private void Update()
    {
    }

    [Token(Token = "0x6003DAF")]
    [Address(RVA = "0x2C109F8", Offset = "0x2C109F8", VA = "0x2C109F8")]
    public static EventLoginBonusView Create(
      GameObject Container_LoginBonus_Beginner_Event,
      Transform parent)
    {
      return (EventLoginBonusView) null;
    }

    [Token(Token = "0x6003DB0")]
    [Address(RVA = "0x2C0EBC4", Offset = "0x2C0EBC4", VA = "0x2C0EBC4")]
    public void Initialize(
      AssetCachedSpawner assetCachedSpawner,
      LoginBonusRewardHolder loginBonusRewardHolder,
      int row,
      EventLoginBonusResource resource,
      Action<ILoginBonusRewardUIParam> onRewardItemClicked)
    {
    }

    [Token(Token = "0x6003DB1")]
    [Address(RVA = "0x2C11718", Offset = "0x2C11718", VA = "0x2C11718")]
    private void FocusRow(int row)
    {
    }

    [Token(Token = "0x6003DB2")]
    [Address(RVA = "0x2C113B0", Offset = "0x2C113B0", VA = "0x2C113B0")]
    private void DeleteChild(Transform trans)
    {
    }

    [Token(Token = "0x6003DB3")]
    [Address(RVA = "0x2C1175C", Offset = "0x2C1175C", VA = "0x2C1175C")]
    private void AddRewardLine(
      Transform parent,
      LoginBonusRewardHolder loginBonusRewardHolder,
      int index,
      int count,
      int startDay)
    {
    }

    [Token(Token = "0x6003DB4")]
    [Address(RVA = "0x2C11460", Offset = "0x2C11460", VA = "0x2C11460")]
    private void AddReward1Line(LoginBonusRewardHolder loginBonusRewardHolder)
    {
    }

    [Token(Token = "0x6003DB5")]
    [Address(RVA = "0x2C11530", Offset = "0x2C11530", VA = "0x2C11530")]
    private void AddReward2Line(LoginBonusRewardHolder loginBonusRewardHolder)
    {
    }

    [Token(Token = "0x6003DB6")]
    [Address(RVA = "0x2C0F4B8", Offset = "0x2C0F4B8", VA = "0x2C0F4B8")]
    public IEnumerator InitializeImgBgPanelAsync(string uri) => (IEnumerator) null;

    [Token(Token = "0x6003DB7")]
    [Address(RVA = "0x2C0F52C", Offset = "0x2C0F52C", VA = "0x2C0F52C")]
    public IEnumerator InitializeTimelineAsync() => (IEnumerator) null;

    [Token(Token = "0x6003DB8")]
    [Address(RVA = "0x2C10BF8", Offset = "0x2C10BF8", VA = "0x2C10BF8")]
    public void PlayInAnim(Action onFinish)
    {
    }

    [Token(Token = "0x6003DB9")]
    [Address(RVA = "0x2C11010", Offset = "0x2C11010", VA = "0x2C11010")]
    public void PlayOutAnim(Action onFinish)
    {
    }

    [Token(Token = "0x6003DBA")]
    [Address(RVA = "0x2C10CE0", Offset = "0x2C10CE0", VA = "0x2C10CE0")]
    public void PlayStampAnim(int index)
    {
    }

    [Token(Token = "0x6003DBB")]
    [Address(RVA = "0x2C10E40", Offset = "0x2C10E40", VA = "0x2C10E40")]
    public void PlayNextAnim(int index)
    {
    }

    [Token(Token = "0x6003DBC")]
    [Address(RVA = "0x2C119EC", Offset = "0x2C119EC", VA = "0x2C119EC")]
    public void EnableSkipButton(Action onClieck)
    {
    }

    [Token(Token = "0x6003DBD")]
    [Address(RVA = "0x2C10D40", Offset = "0x2C10D40", VA = "0x2C10D40")]
    public void DisableSkipButton()
    {
    }

    [Token(Token = "0x6003DBE")]
    [Address(RVA = "0x2C10EA0", Offset = "0x2C10EA0", VA = "0x2C10EA0")]
    public void EnableNextButton(Action onClieck)
    {
    }

    [Token(Token = "0x6003DBF")]
    [Address(RVA = "0x2C0E420", Offset = "0x2C0E420", VA = "0x2C0E420")]
    public void DisableNextButton()
    {
    }

    [Token(Token = "0x6003DC0")]
    [Address(RVA = "0x2C11B6C", Offset = "0x2C11B6C", VA = "0x2C11B6C")]
    public EventLoginBonusView()
    {
    }
  }
}
