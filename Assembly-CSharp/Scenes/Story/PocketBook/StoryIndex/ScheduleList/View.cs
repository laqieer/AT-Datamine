// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.ScheduleList.View
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using FreeMap.Parameter.UIParam.SubQuest;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.Story.PocketBook.StoryIndex.ScheduleList.UI;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.ScheduleList
{
  [Token(Token = "0x2002DEE")]
  public class View
  {
    [Token(Token = "0x400C566")]
    [FieldOffset(Offset = "0x30")]
    private View.TimezoneView currentTimezone;

    [Token(Token = "0x14000162")]
    public event Action<FreeMapUIParamBase> OnClickSchedule
    {
      [Token(Token = "0x6011F52"), Address(RVA = "0x4372EC4", Offset = "0x4372EC4", VA = "0x4372EC4")] add
      {
      }
      [Token(Token = "0x6011F53"), Address(RVA = "0x4374F14", Offset = "0x4374F14", VA = "0x4374F14")] remove
      {
      }
    }

    [Token(Token = "0x17003D42")]
    public ScheduleListUI ScheduleListUI
    {
      [Token(Token = "0x6011F54"), Address(RVA = "0x4374FC4", Offset = "0x4374FC4", VA = "0x4374FC4")] private get
      {
        return (ScheduleListUI) null;
      }
      [Token(Token = "0x6011F55"), Address(RVA = "0x4374FCC", Offset = "0x4374FCC", VA = "0x4374FCC")] set
      {
      }
    }

    [Token(Token = "0x17003D43")]
    public Dictionary<int, Sprite> CharaThumbnails
    {
      [Token(Token = "0x6011F56"), Address(RVA = "0x4374FD4", Offset = "0x4374FD4", VA = "0x4374FD4")] get
      {
        return (Dictionary<int, Sprite>) null;
      }
    }

    [Token(Token = "0x17003D44")]
    public List<View.TimezoneView> TimezoneViews
    {
      [Token(Token = "0x6011F57"), Address(RVA = "0x4374FDC", Offset = "0x4374FDC", VA = "0x4374FDC")] get
      {
        return (List<View.TimezoneView>) null;
      }
    }

    [Token(Token = "0x6011F58")]
    [Address(RVA = "0x4373068", Offset = "0x4373068", VA = "0x4373068")]
    public void Release()
    {
    }

    [Token(Token = "0x6011F59")]
    [Address(RVA = "0x437507C", Offset = "0x437507C", VA = "0x437507C")]
    public void Show(Presenter.IsShow isShow)
    {
    }

    [Token(Token = "0x6011F5A")]
    [Address(RVA = "0x4375130", Offset = "0x4375130", VA = "0x4375130")]
    public void Highlight(FreeMapUIParamBase target)
    {
    }

    [Token(Token = "0x6011F5B")]
    [Address(RVA = "0x4375428", Offset = "0x4375428", VA = "0x4375428")]
    public void HighlightClear()
    {
    }

    [Token(Token = "0x6011F5C")]
    [Address(RVA = "0x43756E8", Offset = "0x43756E8", VA = "0x43756E8")]
    public void Focus(FreeMapUIParamBase target)
    {
    }

    [Token(Token = "0x6011F5D")]
    [Address(RVA = "0x43757FC", Offset = "0x43757FC", VA = "0x43757FC")]
    public void SetTimezone(View.TimezoneView currentTimezone)
    {
    }

    [Token(Token = "0x6011F5E")]
    [Address(RVA = "0x43731E8", Offset = "0x43731E8", VA = "0x43731E8")]
    public View.TimezoneView CreateTimezoneView() => (View.TimezoneView) null;

    [Token(Token = "0x6011F5F")]
    [Address(RVA = "0x4371A24", Offset = "0x4371A24", VA = "0x4371A24")]
    public View()
    {
    }

    [Token(Token = "0x2002DEF")]
    public class TimezoneView
    {
      [Token(Token = "0x400C569")]
      [FieldOffset(Offset = "0x20")]
      public Func<int, Sprite> GetCharaThumbnail;
      [Token(Token = "0x400C56A")]
      [FieldOffset(Offset = "0x28")]
      private Dictionary<FreeMapUIParamBase, Action<bool>> grayoutCallbacks;
      [Token(Token = "0x400C56B")]
      [FieldOffset(Offset = "0x30")]
      private Dictionary<FreeMapUIParamBase, Action<bool>> showHideCallbacks;
      [Token(Token = "0x400C56C")]
      [FieldOffset(Offset = "0x38")]
      private Dictionary<FreeMapUIParamBase, RectTransform> rectTransforms;
      [Token(Token = "0x400C56D")]
      [FieldOffset(Offset = "0x40")]
      private (StoryTimeSlotTypeEnum timeslot, StoryWeatherTypeEnum weather, bool isweekday) info;
      [Token(Token = "0x400C56E")]
      [FieldOffset(Offset = "0x50")]
      private ScheduleListUI.TimezoneUI timezoneUI;

      [Token(Token = "0x14000163")]
      public event Action<FreeMapUIParamBase> OnClickSchedule
      {
        [Token(Token = "0x6011F62"), Address(RVA = "0x437590C", Offset = "0x437590C", VA = "0x437590C")] add
        {
        }
        [Token(Token = "0x6011F63"), Address(RVA = "0x4375A48", Offset = "0x4375A48", VA = "0x4375A48")] remove
        {
        }
      }

      [Token(Token = "0x17003D45")]
      public ScheduleListUI ScheduleListUI
      {
        [Token(Token = "0x6011F64"), Address(RVA = "0x4375AF8", Offset = "0x4375AF8", VA = "0x4375AF8")] private get
        {
          return (ScheduleListUI) null;
        }
        [Token(Token = "0x6011F65"), Address(RVA = "0x4375B00", Offset = "0x4375B00", VA = "0x4375B00")] set
        {
        }
      }

      [Token(Token = "0x6011F66")]
      [Address(RVA = "0x43758E8", Offset = "0x43758E8", VA = "0x43758E8")]
      public void Initialize()
      {
      }

      [Token(Token = "0x6011F67")]
      [Address(RVA = "0x437336C", Offset = "0x437336C", VA = "0x437336C")]
      public void SetHeader(
        StoryTimeSlotTypeEnum timeslot,
        StoryWeatherTypeEnum weather,
        bool weekday)
      {
      }

      [Token(Token = "0x6011F68")]
      public void Show<TParamFilter>(Presenter.IsShow isShow) where TParamFilter : FreeMapUIParamBase
      {
      }

      [Token(Token = "0x6011F69")]
      [Address(RVA = "0x43750E0", Offset = "0x43750E0", VA = "0x43750E0")]
      public void ShowHeader()
      {
      }

      [Token(Token = "0x6011F6A")]
      [Address(RVA = "0x4373400", Offset = "0x4373400", VA = "0x4373400")]
      public void AddSchedule(IEnumerable<FreeMapFacilityEventUIParam> paramList)
      {
      }

      [Token(Token = "0x6011F6B")]
      [Address(RVA = "0x4373808", Offset = "0x4373808", VA = "0x4373808")]
      public void AddSchedule(
        IEnumerable<FreeMapCommunicationEventUIParam> paramList)
      {
      }

      [Token(Token = "0x6011F6C")]
      [Address(RVA = "0x4373C10", Offset = "0x4373C10", VA = "0x4373C10")]
      public void AddSchedule(IEnumerable<FreeMapSubQuestEventUIParam> paramList)
      {
      }

      [Token(Token = "0x6011F6D")]
      [Address(RVA = "0x4374040", Offset = "0x4374040", VA = "0x4374040")]
      public void AddSchedule(IEnumerable<FreeMapObliviaeEnterUIParam> paramList)
      {
      }

      [Token(Token = "0x6011F6E")]
      [Address(RVA = "0x4375D4C", Offset = "0x4375D4C", VA = "0x4375D4C")]
      private void SetupCommon(
        ScheduleListCategory instance,
        ScheduleListElement element,
        FreeMapUIParamBase param)
      {
      }

      [Token(Token = "0x6011F6F")]
      [Address(RVA = "0x4374FE4", Offset = "0x4374FE4", VA = "0x4374FE4")]
      public void Release()
      {
      }

      [Token(Token = "0x6011F70")]
      [Address(RVA = "0x4375280", Offset = "0x4375280", VA = "0x4375280")]
      public void Activate(FreeMapUIParamBase target)
      {
      }

      [Token(Token = "0x6011F71")]
      [Address(RVA = "0x4375570", Offset = "0x4375570", VA = "0x4375570")]
      public void Deactivate()
      {
      }

      [Token(Token = "0x6011F72")]
      [Address(RVA = "0x4375700", Offset = "0x4375700", VA = "0x4375700")]
      public void Focus(FreeMapUIParamBase target)
      {
      }

      [Token(Token = "0x6011F73")]
      [Address(RVA = "0x4375804", Offset = "0x4375804", VA = "0x4375804")]
      public TimezoneView()
      {
      }

      [Token(Token = "0x2002DF0")]
      private sealed class Handler<TParam> where TParam : FreeMapUIParamBase
      {
        [Token(Token = "0x400C56F")]
        [FieldOffset(Offset = "0x0")]
        private ScheduleListCategory instance;
        [Token(Token = "0x400C570")]
        [FieldOffset(Offset = "0x0")]
        private View.TimezoneView view;
        [Token(Token = "0x400C571")]
        [FieldOffset(Offset = "0x0")]
        private TParam param;
        [Token(Token = "0x400C572")]
        [FieldOffset(Offset = "0x0")]
        private View.TimezoneView.Handler<TParam>.IBuilder builder;

        [Token(Token = "0x6011F74")]
        public Handler(
          View.TimezoneView view,
          TParam param,
          View.TimezoneView.Handler<TParam>.IBuilder builder)
        {
        }

        [Token(Token = "0x6011F75")]
        public void Show(bool show)
        {
        }

        [Token(Token = "0x2002DF1")]
        public interface IBuilder
        {
          [Token(Token = "0x6011F76")]
          ScheduleListCategory CreateInstance(View.TimezoneView view, TParam param);
        }
      }

      [Token(Token = "0x2002DF2")]
      private class FacilityBuilder : View.TimezoneView.Handler<FreeMapFacilityEventUIParam>.IBuilder
      {
        [Token(Token = "0x6011F77")]
        [Address(RVA = "0x4375FBC", Offset = "0x4375FBC", VA = "0x4375FBC", Slot = "4")]
        private ScheduleListCategory Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EScheduleList\u002EView\u002ETimezoneView\u002EHandler\u003CFreeMap\u002EParameter\u002EUIParam\u002EFreeMapFacilityEventUIParam\u003E\u002EIBuilder\u002ECreateInstance(
          View.TimezoneView view,
          FreeMapFacilityEventUIParam param)
        {
          return (ScheduleListCategory) null;
        }

        [Token(Token = "0x6011F78")]
        [Address(RVA = "0x4375D2C", Offset = "0x4375D2C", VA = "0x4375D2C")]
        public FacilityBuilder()
        {
        }
      }

      [Token(Token = "0x2002DF3")]
      private class CommunicationBuilder : 
        View.TimezoneView.Handler<FreeMapCommunicationEventUIParam>.IBuilder
      {
        [Token(Token = "0x6011F79")]
        [Address(RVA = "0x4376250", Offset = "0x4376250", VA = "0x4376250", Slot = "4")]
        private ScheduleListCategory Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EScheduleList\u002EView\u002ETimezoneView\u002EHandler\u003CFreeMap\u002EParameter\u002EUIParam\u002EFreeMapCommunicationEventUIParam\u003E\u002EIBuilder\u002ECreateInstance(
          View.TimezoneView view,
          FreeMapCommunicationEventUIParam param)
        {
          return (ScheduleListCategory) null;
        }

        [Token(Token = "0x6011F7A")]
        [Address(RVA = "0x4375D34", Offset = "0x4375D34", VA = "0x4375D34")]
        public CommunicationBuilder()
        {
        }
      }

      [Token(Token = "0x2002DF4")]
      private class SubQuestBuilder : View.TimezoneView.Handler<FreeMapSubQuestEventUIParam>.IBuilder
      {
        [Token(Token = "0x6011F7B")]
        [Address(RVA = "0x4376584", Offset = "0x4376584", VA = "0x4376584", Slot = "4")]
        private ScheduleListCategory Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EScheduleList\u002EView\u002ETimezoneView\u002EHandler\u003CFreeMap\u002EParameter\u002EUIParam\u002ESubQuest\u002EFreeMapSubQuestEventUIParam\u003E\u002EIBuilder\u002ECreateInstance(
          View.TimezoneView view,
          FreeMapSubQuestEventUIParam param)
        {
          return (ScheduleListCategory) null;
        }

        [Token(Token = "0x6011F7C")]
        [Address(RVA = "0x4375D3C", Offset = "0x4375D3C", VA = "0x4375D3C")]
        public SubQuestBuilder()
        {
        }
      }

      [Token(Token = "0x2002DF5")]
      private class ObliviaeBuilder : View.TimezoneView.Handler<FreeMapObliviaeEnterUIParam>.IBuilder
      {
        [Token(Token = "0x6011F7D")]
        [Address(RVA = "0x437686C", Offset = "0x437686C", VA = "0x437686C", Slot = "4")]
        private ScheduleListCategory Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EScheduleList\u002EView\u002ETimezoneView\u002EHandler\u003CFreeMap\u002EParameter\u002EUIParam\u002EFreeMapObliviaeEnterUIParam\u003E\u002EIBuilder\u002ECreateInstance(
          View.TimezoneView view,
          FreeMapObliviaeEnterUIParam param)
        {
          return (ScheduleListCategory) null;
        }

        [Token(Token = "0x6011F7E")]
        [Address(RVA = "0x4375D44", Offset = "0x4375D44", VA = "0x4375D44")]
        public ObliviaeBuilder()
        {
        }
      }
    }
  }
}
