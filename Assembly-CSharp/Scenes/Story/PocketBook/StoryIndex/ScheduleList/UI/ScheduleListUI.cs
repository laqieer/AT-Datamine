// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.ScheduleList.UI.ScheduleListUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Tween.Tweeners;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.ScheduleList.UI
{
  [Token(Token = "0x2002E0C")]
  public class ScheduleListUI : MonoBehaviour
  {
    [Token(Token = "0x400C59D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TweenAnchorPosition[] tweenAnchorPositions;
    [Token(Token = "0x400C59E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Header header;
    [Token(Token = "0x400C59F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ScrollRect scroll;
    [Token(Token = "0x400C5A0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("時間帯単位で複製する縦軸オブジェクト")]
    private RectTransform onetimeSlot;
    [Token(Token = "0x400C5A1")]
    [FieldOffset(Offset = "0x38")]
    [Header("施設用")]
    [SerializeField]
    private ScheduleListCategory facility;
    [Token(Token = "0x400C5A2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Header("コミュ用")]
    private ScheduleListCategory communication;
    [Token(Token = "0x400C5A3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [Header("サブクエ用")]
    private ScheduleListCategory subquest;
    [Token(Token = "0x400C5A4")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    [Header("オブリヴィエ用")]
    private ScheduleListCategory obliviae;
    [Token(Token = "0x400C5A5")]
    [FieldOffset(Offset = "0x58")]
    private readonly InstanceHandler<ScheduleListUI.TimezoneUI> timezoneInstanceHandler;
    [Token(Token = "0x400C5A6")]
    [FieldOffset(Offset = "0x60")]
    private UIAnimationController animationController;
    [Token(Token = "0x400C5A7")]
    [FieldOffset(Offset = "0x68")]
    private float width;

    [Token(Token = "0x6011FD8")]
    [Address(RVA = "0x43719C8", Offset = "0x43719C8", VA = "0x43719C8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6011FD9")]
    [Address(RVA = "0x4378178", Offset = "0x4378178", VA = "0x4378178")]
    public void AnchorFix()
    {
    }

    [Token(Token = "0x6011FDA")]
    [Address(RVA = "0x4375F6C", Offset = "0x4375F6C", VA = "0x4375F6C")]
    public void ReleaseAll()
    {
    }

    [Token(Token = "0x6011FDB")]
    [Address(RVA = "0x4375B08", Offset = "0x4375B08", VA = "0x4375B08")]
    public ScheduleListUI.TimezoneUI GetTimezonUIInstance() => (ScheduleListUI.TimezoneUI) null;

    [Token(Token = "0x17003D4C")]
    public ScrollRect Scroll
    {
      [Token(Token = "0x6011FDC"), Address(RVA = "0x437843C", Offset = "0x437843C", VA = "0x437843C")] get
      {
        return (ScrollRect) null;
      }
    }

    [Token(Token = "0x6011FDD")]
    [Address(RVA = "0x4378444", Offset = "0x4378444", VA = "0x4378444")]
    public ScheduleListUI()
    {
    }

    [Token(Token = "0x2002E0D")]
    public class TimezoneUI : InstanceHandler<ScheduleListUI.TimezoneUI>.IManaged
    {
      [Token(Token = "0x400C5AD")]
      [FieldOffset(Offset = "0x38")]
      private RectTransform timezoneObj;

      [Token(Token = "0x17003D4D")]
      public Header Header
      {
        [Token(Token = "0x6011FDE"), Address(RVA = "0x43784F0", Offset = "0x43784F0", VA = "0x43784F0")] get
        {
          return (Header) null;
        }
        [Token(Token = "0x6011FDF"), Address(RVA = "0x43784F8", Offset = "0x43784F8", VA = "0x43784F8")] private set
        {
        }
      }

      [Token(Token = "0x17003D4E")]
      public ScheduleListCategory.InstanceHandler Facility
      {
        [Token(Token = "0x6011FE0"), Address(RVA = "0x4378500", Offset = "0x4378500", VA = "0x4378500")] get
        {
          return (ScheduleListCategory.InstanceHandler) null;
        }
        [Token(Token = "0x6011FE1"), Address(RVA = "0x4378508", Offset = "0x4378508", VA = "0x4378508")] private set
        {
        }
      }

      [Token(Token = "0x17003D4F")]
      public ScheduleListCategory.InstanceHandler Communication
      {
        [Token(Token = "0x6011FE2"), Address(RVA = "0x4378510", Offset = "0x4378510", VA = "0x4378510")] get
        {
          return (ScheduleListCategory.InstanceHandler) null;
        }
        [Token(Token = "0x6011FE3"), Address(RVA = "0x4378518", Offset = "0x4378518", VA = "0x4378518")] private set
        {
        }
      }

      [Token(Token = "0x17003D50")]
      public ScheduleListCategory.InstanceHandler SubQuest
      {
        [Token(Token = "0x6011FE4"), Address(RVA = "0x4378520", Offset = "0x4378520", VA = "0x4378520")] get
        {
          return (ScheduleListCategory.InstanceHandler) null;
        }
        [Token(Token = "0x6011FE5"), Address(RVA = "0x4378528", Offset = "0x4378528", VA = "0x4378528")] private set
        {
        }
      }

      [Token(Token = "0x17003D51")]
      public ScheduleListCategory.InstanceHandler Obliviae
      {
        [Token(Token = "0x6011FE6"), Address(RVA = "0x4378530", Offset = "0x4378530", VA = "0x4378530")] get
        {
          return (ScheduleListCategory.InstanceHandler) null;
        }
        [Token(Token = "0x6011FE7"), Address(RVA = "0x4378538", Offset = "0x4378538", VA = "0x4378538")] private set
        {
        }
      }

      [Token(Token = "0x6011FE8")]
      [Address(RVA = "0x4378270", Offset = "0x4378270", VA = "0x4378270")]
      public TimezoneUI(ScheduleListUI ui)
      {
      }

      [Token(Token = "0x6011FE9")]
      [Address(RVA = "0x4378540", Offset = "0x4378540", VA = "0x4378540", Slot = "4")]
      private void Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EInstanceHandler\u003CScenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EScheduleList\u002EUI\u002EScheduleListUI\u002ETimezoneUI\u003E\u002EIManaged\u002EOnInitialize()
      {
      }

      [Token(Token = "0x6011FEA")]
      [Address(RVA = "0x437857C", Offset = "0x437857C", VA = "0x437857C", Slot = "5")]
      private void Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EInstanceHandler\u003CScenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EScheduleList\u002EUI\u002EScheduleListUI\u002ETimezoneUI\u003E\u002EIManaged\u002EOnRelease()
      {
      }
    }
  }
}
