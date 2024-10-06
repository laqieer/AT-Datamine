// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.ScheduleList.UI.Header
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.Story.Common;
using System;
using UI;
using UnityEngine;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.ScheduleList.UI
{
  [Token(Token = "0x2002DF8")]
  [Serializable]
  public class Header : MonoBehaviour
  {
    [Token(Token = "0x400C577")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400C578")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor title;
    [Token(Token = "0x400C579")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private WeatherIcon weatherIcon;
    [Token(Token = "0x400C57A")]
    [FieldOffset(Offset = "0x30")]
    private UIAnimationController timeController;
    [Token(Token = "0x400C57B")]
    [FieldOffset(Offset = "0x38")]
    private UIAnimationController weatherController;
    [Token(Token = "0x400C57C")]
    [FieldOffset(Offset = "0x40")]
    private readonly Header.Time time;

    [Token(Token = "0x6011F81")]
    [Address(RVA = "0x4376B28", Offset = "0x4376B28", VA = "0x4376B28")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6011F82")]
    [Address(RVA = "0x4375BC0", Offset = "0x4375BC0", VA = "0x4375BC0")]
    public void Set(StoryTimeSlotTypeEnum type, bool weekday)
    {
    }

    [Token(Token = "0x6011F83")]
    [Address(RVA = "0x4375D10", Offset = "0x4375D10", VA = "0x4375D10")]
    public void Set(StoryWeatherTypeEnum type)
    {
    }

    [Token(Token = "0x6011F84")]
    [Address(RVA = "0x4376F34", Offset = "0x4376F34", VA = "0x4376F34")]
    public Header()
    {
    }

    [Token(Token = "0x2002DF9")]
    private class Time
    {
      [Token(Token = "0x6011F85")]
      [Address(RVA = "0x4376E00", Offset = "0x4376E00", VA = "0x4376E00")]
      public void Clock3(UIAnimationController animationController)
      {
      }

      [Token(Token = "0x6011F86")]
      [Address(RVA = "0x4376CCC", Offset = "0x4376CCC", VA = "0x4376CCC")]
      public void Clock9(UIAnimationController animationController)
      {
      }

      [Token(Token = "0x6011F87")]
      [Address(RVA = "0x4376BD8", Offset = "0x4376BD8", VA = "0x4376BD8")]
      public void Clock12(UIAnimationController animationController)
      {
      }

      [Token(Token = "0x6011F88")]
      [Address(RVA = "0x4376F9C", Offset = "0x4376F9C", VA = "0x4376F9C")]
      public Time()
      {
      }
    }
  }
}
