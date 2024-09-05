// Decompiled with JetBrains decompiler
// Type: Scenes.Story.DateItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story
{
  [Token(Token = "0x2002D70")]
  public class DateItem : MonoBehaviour
  {
    [Token(Token = "0x400C2ED")]
    private const string BACKGROUND_NAME = "Img_Base_HeaderCalendar";
    [Token(Token = "0x400C2EE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400C2EF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image backgroudImage;
    [Token(Token = "0x400C2F0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400C2F1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image slashImage;
    [Token(Token = "0x400C2F2")]
    [FieldOffset(Offset = "0x38")]
    [Header("「月/日」表示")]
    [SerializeField]
    private DateDisplayMonthDay monthDay;
    [Token(Token = "0x400C2F3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Header("「何日目」表示")]
    private DateDisplayOnceDay onceDay;
    [Token(Token = "0x400C2F4")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text timeSlot;
    [Token(Token = "0x400C2F5")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject weatherGroupObject;
    [Token(Token = "0x400C2F6")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject[] weatherImages;
    [Token(Token = "0x400C2F7")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private RectTransform mainParts;
    [Token(Token = "0x400C2F8")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    [Header("トラッカー配置先")]
    private RectTransform tracker;
    [Token(Token = "0x400C2F9")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Button homeButton;
    [Token(Token = "0x400C2FA")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject poketbookButtonRoot;
    [Token(Token = "0x400C2FB")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Button poketbookButton;
    [Token(Token = "0x400C2FC")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Button globalMenuButton;
    [Token(Token = "0x400C2FD")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject kizunaListButtonRoot;
    [Token(Token = "0x400C2FE")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Button kizunaListButton;
    [Token(Token = "0x400C304")]
    [FieldOffset(Offset = "0xC8")]
    private bool isSubButtonActive;
    [Token(Token = "0x400C305")]
    [FieldOffset(Offset = "0xC9")]
    private bool activatableSubButton;
    [Token(Token = "0x400C306")]
    [FieldOffset(Offset = "0xCA")]
    private bool showGlobalMenuButton;
    [Token(Token = "0x400C307")]
    [FieldOffset(Offset = "0xCB")]
    private bool showPocketBookButton;
    [Token(Token = "0x400C308")]
    [FieldOffset(Offset = "0xCC")]
    private bool showHomeButton;
    [Token(Token = "0x400C309")]
    [FieldOffset(Offset = "0xCD")]
    private bool showKizunaListButton;

    [Token(Token = "0x17003CA8")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6011C0A"), Address(RVA = "0x42BCF94", Offset = "0x42BCF94", VA = "0x42BCF94")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003CA9")]
    public RectTransform MainParts
    {
      [Token(Token = "0x6011C0B"), Address(RVA = "0x42BCF9C", Offset = "0x42BCF9C", VA = "0x42BCF9C")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003CAA")]
    public RectTransform TrackerParent
    {
      [Token(Token = "0x6011C0C"), Address(RVA = "0x42BCFA4", Offset = "0x42BCFA4", VA = "0x42BCFA4")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003CAB")]
    public SpriteAtlas CalendarAtlas
    {
      [Token(Token = "0x6011C0D"), Address(RVA = "0x42BCFAC", Offset = "0x42BCFAC", VA = "0x42BCFAC")] private get
      {
        return (SpriteAtlas) null;
      }
      [Token(Token = "0x6011C0E"), Address(RVA = "0x42BCFB4", Offset = "0x42BCFB4", VA = "0x42BCFB4")] set
      {
      }
    }

    [Token(Token = "0x17003CAC")]
    private Action minimapAction
    {
      [Token(Token = "0x6011C0F"), Address(RVA = "0x42BCFBC", Offset = "0x42BCFBC", VA = "0x42BCFBC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6011C10"), Address(RVA = "0x42BCFC4", Offset = "0x42BCFC4", VA = "0x42BCFC4")] set
      {
      }
    }

    [Token(Token = "0x17003CAD")]
    private Action pocketbookOpenAction
    {
      [Token(Token = "0x6011C11"), Address(RVA = "0x42BCFCC", Offset = "0x42BCFCC", VA = "0x42BCFCC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6011C12"), Address(RVA = "0x42BCFD4", Offset = "0x42BCFD4", VA = "0x42BCFD4")] set
      {
      }
    }

    [Token(Token = "0x17003CAE")]
    private Action globalMenuOpenAction
    {
      [Token(Token = "0x6011C13"), Address(RVA = "0x42BCFDC", Offset = "0x42BCFDC", VA = "0x42BCFDC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6011C14"), Address(RVA = "0x42BCFE4", Offset = "0x42BCFE4", VA = "0x42BCFE4")] set
      {
      }
    }

    [Token(Token = "0x17003CAF")]
    private Action kizunaListOpenAction
    {
      [Token(Token = "0x6011C15"), Address(RVA = "0x42BCFEC", Offset = "0x42BCFEC", VA = "0x42BCFEC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6011C16"), Address(RVA = "0x42BCFF4", Offset = "0x42BCFF4", VA = "0x42BCFF4")] set
      {
      }
    }

    [Token(Token = "0x6011C17")]
    [Address(RVA = "0x42BCFFC", Offset = "0x42BCFFC", VA = "0x42BCFFC")]
    public void OnBeginPlayTimeElapsed(Action callback)
    {
    }

    [Token(Token = "0x6011C18")]
    [Address(RVA = "0x42BD05C", Offset = "0x42BD05C", VA = "0x42BD05C")]
    public void OnEndPlayTimeElapsed(Action callback)
    {
    }

    [Token(Token = "0x6011C19")]
    [Address(RVA = "0x42BD0BC", Offset = "0x42BD0BC", VA = "0x42BD0BC")]
    public void SetupDate(int sequenceId = 0)
    {
    }

    [Token(Token = "0x6011C1A")]
    [Address(RVA = "0x42BD3F8", Offset = "0x42BD3F8", VA = "0x42BD3F8")]
    private void SetWeeklyData(
      IDateDisplayElementCommon dateElement,
      StoryMainQuestCalendarData calendarData,
      SpriteAtlas calendarAtlas)
    {
    }

    [Token(Token = "0x6011C1B")]
    [Address(RVA = "0x42BD844", Offset = "0x42BD844", VA = "0x42BD844")]
    private void SetTimeSlotData(
      StoryTimeSlotTypeEnum timeSlotType,
      bool weekday,
      SpriteAtlas calendarAtlas)
    {
    }

    [Token(Token = "0x6011C1C")]
    [Address(RVA = "0x42BD734", Offset = "0x42BD734", VA = "0x42BD734")]
    public void SetTimeSlotData(StoryTimeSlotTypeEnum timeSlotType, bool weekday)
    {
    }

    [Token(Token = "0x6011C1D")]
    [Address(RVA = "0x42BD880", Offset = "0x42BD880", VA = "0x42BD880")]
    public void SetWeatherData(int weather)
    {
    }

    [Token(Token = "0x6011C1E")]
    [Address(RVA = "0x42BD7C8", Offset = "0x42BD7C8", VA = "0x42BD7C8")]
    private void SetWeatherData(int weather, SpriteAtlas calendarAtlas)
    {
    }

    [Token(Token = "0x6011C1F")]
    [Address(RVA = "0x42BD90C", Offset = "0x42BD90C", VA = "0x42BD90C")]
    public void PlayToTween(string tweenKey, bool stopCurrent = true)
    {
    }

    [Token(Token = "0x6011C20")]
    [Address(RVA = "0x42BD92C", Offset = "0x42BD92C", VA = "0x42BD92C")]
    public void AddAnimationFinishCallback(UnityAction finishAction)
    {
    }

    [Token(Token = "0x6011C21")]
    [Address(RVA = "0x42BD948", Offset = "0x42BD948", VA = "0x42BD948")]
    public void RemoveAnimationFinishCallback(UnityAction finishAction)
    {
    }

    [Token(Token = "0x6011C22")]
    [Address(RVA = "0x42BD964", Offset = "0x42BD964", VA = "0x42BD964")]
    public bool GetSubButtonActive() => new bool();

    [Token(Token = "0x6011C23")]
    [Address(RVA = "0x42BD96C", Offset = "0x42BD96C", VA = "0x42BD96C")]
    public void SetActivatableSubButton(bool isActive)
    {
    }

    [Token(Token = "0x6011C24")]
    [Address(RVA = "0x42BD978", Offset = "0x42BD978", VA = "0x42BD978")]
    public void SetActiveSubButtons(
      bool homeButton,
      bool pocketBookButton,
      bool globalMenu,
      bool kizunaListButton)
    {
    }

    [Token(Token = "0x6011C25")]
    [Address(RVA = "0x42BD99C", Offset = "0x42BD99C", VA = "0x42BD99C")]
    public void ShowSubButtons()
    {
    }

    [Token(Token = "0x6011C26")]
    [Address(RVA = "0x42BDA2C", Offset = "0x42BDA2C", VA = "0x42BDA2C")]
    public void HideSubButtons()
    {
    }

    [Token(Token = "0x6011C27")]
    [Address(RVA = "0x42BDABC", Offset = "0x42BDABC", VA = "0x42BDABC")]
    public void InteractEnableSubButtons()
    {
    }

    [Token(Token = "0x6011C28")]
    [Address(RVA = "0x42BDB1C", Offset = "0x42BDB1C", VA = "0x42BDB1C")]
    public void InteractDisableSubButtons()
    {
    }

    [Token(Token = "0x6011C29")]
    [Address(RVA = "0x42BDB7C", Offset = "0x42BDB7C", VA = "0x42BDB7C")]
    public void SetMinimapAction(Action minimapAction)
    {
    }

    [Token(Token = "0x6011C2A")]
    [Address(RVA = "0x42BDB84", Offset = "0x42BDB84", VA = "0x42BDB84")]
    public void SetPocketBookOpenButton(Action action)
    {
    }

    [Token(Token = "0x6011C2B")]
    [Address(RVA = "0x42BDB8C", Offset = "0x42BDB8C", VA = "0x42BDB8C")]
    public void SetGlobalMenuOpenButton(Action action)
    {
    }

    [Token(Token = "0x6011C2C")]
    [Address(RVA = "0x42BDB94", Offset = "0x42BDB94", VA = "0x42BDB94")]
    public void SetKizunaListOpenButton(Action action)
    {
    }

    [Token(Token = "0x6011C2D")]
    [Address(RVA = "0x42BDB9C", Offset = "0x42BDB9C", VA = "0x42BDB9C")]
    public void OnClickMapButton()
    {
    }

    [Token(Token = "0x6011C2E")]
    [Address(RVA = "0x42BDBB8", Offset = "0x42BDBB8", VA = "0x42BDBB8")]
    public void OnClickPocketbookButton()
    {
    }

    [Token(Token = "0x6011C2F")]
    [Address(RVA = "0x42BDBD4", Offset = "0x42BDBD4", VA = "0x42BDBD4")]
    public void OnClickToGlobalMenu()
    {
    }

    [Token(Token = "0x6011C30")]
    [Address(RVA = "0x42BDBF0", Offset = "0x42BDBF0", VA = "0x42BDBF0")]
    public void OnClickKizunaList()
    {
    }

    [Token(Token = "0x6011C31")]
    [Address(RVA = "0x42BDC0C", Offset = "0x42BDC0C", VA = "0x42BDC0C")]
    public DateItem()
    {
    }
  }
}
