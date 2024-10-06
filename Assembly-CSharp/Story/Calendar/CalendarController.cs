// Decompiled with JetBrains decompiler
// Type: Story.Calendar.CalendarController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using staq.Camera;
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Story.Calendar
{
  [Token(Token = "0x2000720")]
  public class CalendarController : MonoBehaviour
  {
    [Token(Token = "0x400210E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CalendarAnimation calendarAnimation;
    [Token(Token = "0x400210F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform beforeBgRectTransform;
    [Token(Token = "0x4002110")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RectTransform afterBgRectTransform;
    [Token(Token = "0x4002111")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private DayContainer dayContainer;
    [Token(Token = "0x4002112")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Transform transChangeCharaRoot;
    [Token(Token = "0x4002113")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private PlayableDirector effChangeDayDirector;
    [Token(Token = "0x4002114")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private SignalReceiver reciverObject;
    [Token(Token = "0x4002115")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private MaskableGraphic[] updateMaterialList;
    [Token(Token = "0x4002116")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CanvasCameraSetter beforeBgCameraSetter;
    [Token(Token = "0x4002117")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CalendarCapture capturedTexture;
    [Token(Token = "0x4002118")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002119")]
    [FieldOffset(Offset = "0x70")]
    private SpriteAtlas calendarAtlas;
    [Token(Token = "0x400211A")]
    [FieldOffset(Offset = "0x78")]
    private bool IsHomeMoveToMainQuest;
    [Token(Token = "0x400211C")]
    [FieldOffset(Offset = "0x88")]
    private GameObject beforeBgObj;
    [Token(Token = "0x400211D")]
    [FieldOffset(Offset = "0x90")]
    private GameObject afterBgObj;
    [Token(Token = "0x400211E")]
    [FieldOffset(Offset = "0x98")]
    private Vector2 backgroundSize;
    [Token(Token = "0x400211F")]
    [FieldOffset(Offset = "0xA0")]
    private UITweenGroup backgroundTween;
    [Token(Token = "0x4002120")]
    [FieldOffset(Offset = "0xA8")]
    private bool isToday;
    [Token(Token = "0x4002121")]
    [FieldOffset(Offset = "0xB0")]
    private IEnumerator playEnumerator;
    [Token(Token = "0x4002122")]
    [FieldOffset(Offset = "0xB8")]
    private bool isEnableSkip;
    [Token(Token = "0x4002123")]
    [FieldOffset(Offset = "0xBC")]
    private int charaPrefabID;
    [Token(Token = "0x4002124")]
    [FieldOffset(Offset = "0xC0")]
    private PlayableDirector charaPlayableDirector;

    [Token(Token = "0x170005EF")]
    public CalendarController.AnimationEvent FinishedCallback
    {
      [Token(Token = "0x6002816"), Address(RVA = "0x367241C", Offset = "0x367241C", VA = "0x367241C")] private get
      {
        return (CalendarController.AnimationEvent) null;
      }
      [Token(Token = "0x6002817"), Address(RVA = "0x3672424", Offset = "0x3672424", VA = "0x3672424")] set
      {
      }
    }

    [Token(Token = "0x6002818")]
    [Address(RVA = "0x367242C", Offset = "0x367242C", VA = "0x367242C")]
    public void SetHomeMoveToMainQuestFlg(bool isHomeMoveToMainQuest)
    {
    }

    [Token(Token = "0x6002819")]
    [Address(RVA = "0x3672438", Offset = "0x3672438", VA = "0x3672438")]
    public static CalendarController CreateCalendarController() => (CalendarController) null;

    [Token(Token = "0x600281A")]
    [Address(RVA = "0x36724CC", Offset = "0x36724CC", VA = "0x36724CC")]
    public IEnumerator Initialize(
      (StoryMainQuestSequenceData sequence, StoryMainQuestCalendarData calendar)? prev,
      (StoryMainQuestSequenceData sequence, StoryMainQuestCalendarData calendar) next)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600281B")]
    [Address(RVA = "0x367258C", Offset = "0x367258C", VA = "0x367258C")]
    private IEnumerator InitializeChageDay(StoryMainQuestSequenceData sequenceData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600281C")]
    [Address(RVA = "0x3672628", Offset = "0x3672628", VA = "0x3672628")]
    private int GetCalenderCharacter(StoryMainQuestSequenceData sequenceData) => new int();

    [Token(Token = "0x600281D")]
    [Address(RVA = "0x3672A54", Offset = "0x3672A54", VA = "0x3672A54")]
    private static bool isCalendarElapsedParam(
      int sequenceID,
      StoryMainQuestCalendarElapsedGroupData groupData)
    {
      return new bool();
    }

    [Token(Token = "0x600281E")]
    [Address(RVA = "0x3672CA8", Offset = "0x3672CA8", VA = "0x3672CA8")]
    private void SetBackground()
    {
    }

    [Token(Token = "0x600281F")]
    [Address(RVA = "0x3672E68", Offset = "0x3672E68", VA = "0x3672E68")]
    public void ResourceUnload()
    {
    }

    [Token(Token = "0x6002820")]
    [Address(RVA = "0x367312C", Offset = "0x367312C", VA = "0x367312C")]
    private void Capture()
    {
    }

    [Token(Token = "0x6002821")]
    [Address(RVA = "0x3673224", Offset = "0x3673224", VA = "0x3673224")]
    public void Activate(bool active)
    {
    }

    [Token(Token = "0x6002822")]
    [Address(RVA = "0x367324C", Offset = "0x367324C", VA = "0x367324C")]
    public void Set(CalendarController.AnimationEvent finishedCallback)
    {
    }

    [Token(Token = "0x6002823")]
    [Address(RVA = "0x36732BC", Offset = "0x36732BC", VA = "0x36732BC")]
    public void Play()
    {
    }

    [Token(Token = "0x6002824")]
    [Address(RVA = "0x36732E8", Offset = "0x36732E8", VA = "0x36732E8")]
    private IEnumerator PlayInternal() => (IEnumerator) null;

    [Token(Token = "0x6002825")]
    [Address(RVA = "0x3673378", Offset = "0x3673378", VA = "0x3673378")]
    private IEnumerator SkipFinish() => (IEnumerator) null;

    [Token(Token = "0x6002826")]
    [Address(RVA = "0x3673408", Offset = "0x3673408", VA = "0x3673408")]
    private void OnFinish()
    {
    }

    [Token(Token = "0x6002827")]
    [Address(RVA = "0x36734C4", Offset = "0x36734C4", VA = "0x36734C4")]
    private void OnBtnSkip()
    {
    }

    [Token(Token = "0x6002828")]
    [Address(RVA = "0x3673504", Offset = "0x3673504", VA = "0x3673504")]
    public CalendarController()
    {
    }

    [Token(Token = "0x2000721")]
    public delegate void AnimationEvent();
  }
}
