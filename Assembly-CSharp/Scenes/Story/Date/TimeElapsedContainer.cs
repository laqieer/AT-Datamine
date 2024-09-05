// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Date.TimeElapsedContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.Story.Common;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.Date
{
  [Token(Token = "0x2002EA7")]
  public class TimeElapsedContainer : MonoBehaviour
  {
    [Token(Token = "0x400C801")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400C802")]
    [FieldOffset(Offset = "0x20")]
    [Header("タイムライン再生Director")]
    [SerializeField]
    private PlayableDirector playableDirector;
    [Token(Token = "0x400C803")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Header("回転オブジェクト：開始用")]
    private RectTransform prevRotation;
    [Token(Token = "0x400C804")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("回転オブジェクト：変化用")]
    private RectTransform rotation;
    [Token(Token = "0x400C805")]
    [FieldOffset(Offset = "0x38")]
    [Header("設定")]
    [SerializeField]
    private TimeElapsedContainer.Setting setting;
    [Token(Token = "0x400C806")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Header("各時間帯UI")]
    private TimeElapsedTimezoneItem[] timezones;
    [Token(Token = "0x400C807")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [Header("天候アイコン")]
    private Sprite[] weatherIcons;
    [Token(Token = "0x400C808")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image eyecatch;
    [Token(Token = "0x400C80A")]
    [FieldOffset(Offset = "0x60")]
    private TimeElapsedTimelineController timelineController;
    [Token(Token = "0x400C80B")]
    [FieldOffset(Offset = "0x68")]
    private bool stageStarted;
    [Token(Token = "0x400C80C")]
    [FieldOffset(Offset = "0x69")]
    private bool stageSkipRequest;

    [Token(Token = "0x17003DD8")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6012363"), Address(RVA = "0x4595E48", Offset = "0x4595E48", VA = "0x4595E48")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003DD9")]
    public SpriteAtlas CalendarSpriteAtlas
    {
      [Token(Token = "0x6012364"), Address(RVA = "0x4595E50", Offset = "0x4595E50", VA = "0x4595E50")] private get
      {
        return (SpriteAtlas) null;
      }
      [Token(Token = "0x6012365"), Address(RVA = "0x4595E58", Offset = "0x4595E58", VA = "0x4595E58")] set
      {
      }
    }

    [Token(Token = "0x6012366")]
    [Address(RVA = "0x4595E60", Offset = "0x4595E60", VA = "0x4595E60")]
    public void SetStopCallback(Action<PlayableDirector> stoppedCallback)
    {
    }

    [Token(Token = "0x6012367")]
    [Address(RVA = "0x4595E7C", Offset = "0x4595E7C", VA = "0x4595E7C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6012368")]
    [Address(RVA = "0x459610C", Offset = "0x459610C", VA = "0x459610C")]
    public void Initialized()
    {
    }

    [Token(Token = "0x6012369")]
    [Address(RVA = "0x4596168", Offset = "0x4596168", VA = "0x4596168")]
    public void Setup(
      int prevWeather,
      int nextWeather,
      StoryTimeSlotTypeEnum prevTimeSlot,
      StoryTimeSlotTypeEnum nextTimeSlot,
      bool weekday)
    {
    }

    [Token(Token = "0x601236A")]
    [Address(RVA = "0x4596744", Offset = "0x4596744", VA = "0x4596744")]
    public IEnumerator LoadEyeCatchImage(int id) => (IEnumerator) null;

    [Token(Token = "0x601236B")]
    [Address(RVA = "0x45967E4", Offset = "0x45967E4", VA = "0x45967E4")]
    public void Play()
    {
    }

    [Token(Token = "0x601236C")]
    [Address(RVA = "0x4596830", Offset = "0x4596830", VA = "0x4596830")]
    public void Update()
    {
    }

    [Token(Token = "0x601236D")]
    [Address(RVA = "0x4596870", Offset = "0x4596870", VA = "0x4596870")]
    private void AlphaPerFocusAngle()
    {
    }

    [Token(Token = "0x601236E")]
    [Address(RVA = "0x4596610", Offset = "0x4596610", VA = "0x4596610")]
    private void SetWeatherData(WeatherIcon weatherIcon, StoryWeatherTypeEnum weather)
    {
    }

    [Token(Token = "0x601236F")]
    [Address(RVA = "0x459662C", Offset = "0x459662C", VA = "0x459662C")]
    private void SetTimezoneText(
      TimeElapsedTimezoneItem timezone,
      TimezoneItemWeekOrHolyday weekOrHolyday,
      bool weekday)
    {
    }

    [Token(Token = "0x6012370")]
    [Address(RVA = "0x4596A8C", Offset = "0x4596A8C", VA = "0x4596A8C")]
    public void Clear()
    {
    }

    [Token(Token = "0x6012371")]
    [Address(RVA = "0x4596BFC", Offset = "0x4596BFC", VA = "0x4596BFC")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6012372")]
    [Address(RVA = "0x4596C04", Offset = "0x4596C04", VA = "0x4596C04")]
    public void OnFullScreenBtnTapInUIBtn()
    {
    }

    [Token(Token = "0x6012373")]
    [Address(RVA = "0x4596C10", Offset = "0x4596C10", VA = "0x4596C10")]
    public TimeElapsedContainer()
    {
    }

    [Token(Token = "0x2002EA8")]
    [Serializable]
    public class Setting
    {
      [Token(Token = "0x400C80D")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      [Header("時間帯が何度間隔で配置されているか")]
      public float angleInterval;
      [Token(Token = "0x400C80E")]
      [FieldOffset(Offset = "0x14")]
      [Header("自動アルファの下限を適用する角度閾値")]
      [SerializeField]
      public float angleThreshold;
      [Token(Token = "0x400C80F")]
      [FieldOffset(Offset = "0x18")]
      [Header("自動アルファの下限")]
      [SerializeField]
      public float alphaMin;
      [Token(Token = "0x400C810")]
      [FieldOffset(Offset = "0x1C")]
      [SerializeField]
      [Header("自動アルファの上限")]
      public float alphaMax;

      [Token(Token = "0x6012374")]
      [Address(RVA = "0x4596C84", Offset = "0x4596C84", VA = "0x4596C84")]
      public Setting()
      {
      }
    }
  }
}
