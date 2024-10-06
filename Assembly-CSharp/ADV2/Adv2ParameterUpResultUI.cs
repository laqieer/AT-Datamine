// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2ParameterUpResultUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.LuaScript;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.Story;
using System.Collections;
using System.Collections.Generic;
using Tween.Tweeners;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E2B")]
  public class Adv2ParameterUpResultUI : MonoBehaviour
  {
    [Token(Token = "0x40110F0")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string[] Tags_Status;
    [Token(Token = "0x40110F1")]
    private const int PARAM_UP_COLOR = 1;
    [Token(Token = "0x40110F2")]
    private const int PARAM_MAX_COLOR = 2;
    [Token(Token = "0x40110F3")]
    [FieldOffset(Offset = "0x18")]
    private readonly string[,] VolueColorTbl;
    [Token(Token = "0x40110F4")]
    private const string Tags_RadarChart = "RadarChart";
    [Token(Token = "0x40110F5")]
    private const string Tags_Button = "TapButton";
    [Token(Token = "0x40110F6")]
    private const string Tags_ImgUnit = "Img_Unit";
    [Token(Token = "0x40110F7")]
    private const string Tags_PlayerName = "PlayerName";
    [Token(Token = "0x40110F8")]
    private const string Tags_Graph = "Graph";
    [Token(Token = "0x40110F9")]
    private const string TweenGroupId_GaugeUp = "Gauge_Up";
    [Token(Token = "0x40110FA")]
    private const string TweenGroupId_SlideChart = "SlideChart";
    [Token(Token = "0x40110FB")]
    private const string TweenGroupId_TapIn = "Tap_In";
    [Token(Token = "0x40110FC")]
    private const string MessageTag_DialogTextBase = "HUMAN_PARAM_UP_MESSAGE";
    [Token(Token = "0x40110FD")]
    private const string ReplaceTag_ParamTitle = "【PARAM_TITLE】";
    [Token(Token = "0x40110FE")]
    private const string ReplaceTag_BeforeRankName = "【BEFORE_RANK_NAME】";
    [Token(Token = "0x40110FF")]
    private const string ReplaceTag_AfterRankName = "【AFTER_RANK_NAME】";
    [Token(Token = "0x4011100")]
    private const int FlooredDecimalPlace = 100;
    [Token(Token = "0x4011101")]
    private const float EffectWaitTime = 1f;
    [Token(Token = "0x4011102")]
    [FieldOffset(Offset = "0x20")]
    private Transform parent;
    [Token(Token = "0x4011103")]
    [FieldOffset(Offset = "0x28")]
    private Adv2UiLinker linker;
    [Token(Token = "0x4011104")]
    [FieldOffset(Offset = "0x30")]
    private UITweenGroup tweenRoot;
    [Token(Token = "0x4011105")]
    [FieldOffset(Offset = "0x38")]
    private GameObject prefab;
    [Token(Token = "0x4011106")]
    [FieldOffset(Offset = "0x40")]
    private Button tapButton;
    [Token(Token = "0x4011107")]
    [FieldOffset(Offset = "0x48")]
    private Adv2ParameterUpResultUI.StatusObject[] statusObjects;
    [Token(Token = "0x4011108")]
    [FieldOffset(Offset = "0x50")]
    private Adv2ParameterUpResultDialogUI dialogObject;
    [Token(Token = "0x4011109")]
    [FieldOffset(Offset = "0x58")]
    private Adv2Manager.OnProccessSignal directionSignal;
    [Token(Token = "0x401110A")]
    [FieldOffset(Offset = "0x60")]
    private LuaSequence.ParamControl.HumanParameter param;
    [Token(Token = "0x401110B")]
    [FieldOffset(Offset = "0x68")]
    private UITimelineController timelineControllor;
    [Token(Token = "0x401110C")]
    [FieldOffset(Offset = "0x70")]
    private TweenRadarChart tweenChart;
    [Token(Token = "0x401110D")]
    [FieldOffset(Offset = "0x78")]
    private RadarChartMesh chartMesh;
    [Token(Token = "0x401110E")]
    [FieldOffset(Offset = "0x80")]
    private int updateGaugeCount;
    [Token(Token = "0x401110F")]
    [FieldOffset(Offset = "0x88")]
    private List<Adv2ParameterUpResultUI.StatusGaugeValue[]> updateGaugeValueList;
    [Token(Token = "0x4011110")]
    [FieldOffset(Offset = "0x90")]
    private List<Adv2ParameterUpResultUI.RadarChartValue[]> updateChartValueList;
    [Token(Token = "0x4011111")]
    [FieldOffset(Offset = "0x98")]
    private List<Adv2ParameterUpResultUI.NextExpValue[]> updateExpValueList;
    [Token(Token = "0x4011112")]
    [FieldOffset(Offset = "0xA0")]
    private List<string> dialogTextList;
    [Token(Token = "0x4011113")]
    [FieldOffset(Offset = "0xA8")]
    private float tweenGaugeDurationOrigin;
    [Token(Token = "0x4011114")]
    [FieldOffset(Offset = "0xB0")]
    private string dialogTextBase;
    [Token(Token = "0x4011115")]
    [FieldOffset(Offset = "0xB8")]
    private bool isTapped;
    [Token(Token = "0x4011116")]
    [FieldOffset(Offset = "0xBC")]
    private Color lvMaxColor;

    [Token(Token = "0x60190C2")]
    [Address(RVA = "0x29696FC", Offset = "0x29696FC", VA = "0x29696FC")]
    public static Adv2ParameterUpResultUI Create(GameObject addComponent, Transform parent)
    {
      return (Adv2ParameterUpResultUI) null;
    }

    [Token(Token = "0x60190C3")]
    [Address(RVA = "0x296975C", Offset = "0x296975C", VA = "0x296975C")]
    public void SetBindObject(GameObject prefab)
    {
    }

    [Token(Token = "0x60190C4")]
    [Address(RVA = "0x29697EC", Offset = "0x29697EC", VA = "0x29697EC")]
    private void Init(GameObject prefab)
    {
    }

    [Token(Token = "0x60190C5")]
    [Address(RVA = "0x2969F64", Offset = "0x2969F64", VA = "0x2969F64")]
    private void OnTap()
    {
    }

    [Token(Token = "0x60190C6")]
    [Address(RVA = "0x2969C24", Offset = "0x2969C24", VA = "0x2969C24")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x60190C7")]
    [Address(RVA = "0x2969F70", Offset = "0x2969F70", VA = "0x2969F70")]
    public void SetDialog(Adv2ParameterUpResultDialogUI dialogInstance)
    {
    }

    [Token(Token = "0x60190C8")]
    [Address(RVA = "0x2969F78", Offset = "0x2969F78", VA = "0x2969F78")]
    public void Prepare(LuaSequence.ParamControl.HumanParameter humanParam, string fullImageTag)
    {
    }

    [Token(Token = "0x60190C9")]
    [Address(RVA = "0x296A2EC", Offset = "0x296A2EC", VA = "0x296A2EC")]
    private void SetInitialState()
    {
    }

    [Token(Token = "0x60190CA")]
    [Address(RVA = "0x296A4F0", Offset = "0x296A4F0", VA = "0x296A4F0")]
    private void PrepareValues()
    {
    }

    [Token(Token = "0x60190CB")]
    [Address(RVA = "0x296BF18", Offset = "0x296BF18", VA = "0x296BF18")]
    private string GetDialogText(string title, string fromRankName, string toRankName)
    {
      return (string) null;
    }

    [Token(Token = "0x60190CC")]
    [Address(RVA = "0x296BBE0", Offset = "0x296BBE0", VA = "0x296BBE0")]
    private int ConvertRankNumToValueIndex(int rankNum) => new int();

    [Token(Token = "0x60190CD")]
    [Address(RVA = "0x296C06C", Offset = "0x296C06C", VA = "0x296C06C")]
    public Adv2Manager.OnProccessSignal Play() => (Adv2Manager.OnProccessSignal) null;

    [Token(Token = "0x60190CE")]
    [Address(RVA = "0x296C118", Offset = "0x296C118", VA = "0x296C118")]
    private IEnumerator PlayDirection() => (IEnumerator) null;

    [Token(Token = "0x60190CF")]
    [Address(RVA = "0x296C1A8", Offset = "0x296C1A8", VA = "0x296C1A8")]
    private IEnumerator UpdateChart() => (IEnumerator) null;

    [Token(Token = "0x60190D0")]
    [Address(RVA = "0x296BD8C", Offset = "0x296BD8C", VA = "0x296BD8C")]
    private void SetRadarChartLevel(int[] fromLevels, int[] toLevels)
    {
    }

    [Token(Token = "0x60190D1")]
    [Address(RVA = "0x296C238", Offset = "0x296C238", VA = "0x296C238")]
    private IEnumerator PlayAndWaitTweenGroup(string tweenGroupId) => (IEnumerator) null;

    [Token(Token = "0x60190D2")]
    [Address(RVA = "0x296C2D4", Offset = "0x296C2D4", VA = "0x296C2D4")]
    private void PlayTweenGroup(string tweenGroupId)
    {
    }

    [Token(Token = "0x60190D3")]
    [Address(RVA = "0x296C370", Offset = "0x296C370", VA = "0x296C370")]
    public Adv2ParameterUpResultUI()
    {
    }

    [Token(Token = "0x60190D4")]
    [Address(RVA = "0x296C70C", Offset = "0x296C70C", VA = "0x296C70C")]
    static Adv2ParameterUpResultUI()
    {
    }

    [Token(Token = "0x2003E2C")]
    private class StatusObject
    {
      [Token(Token = "0x4011117")]
      [FieldOffset(Offset = "0x10")]
      private Adv2UiLinker linker;
      [Token(Token = "0x4011118")]
      [FieldOffset(Offset = "0x18")]
      private TweenScale tweenScale;
      [Token(Token = "0x4011119")]
      private const string Tags_TitleText = "Txt_Title";
      [Token(Token = "0x401111A")]
      private const string Tags_NextTitleText = "Txt_Next_Title";
      [Token(Token = "0x401111B")]
      private const string Tags_ValueText = "Txt_Value";
      [Token(Token = "0x401111C")]
      private const string Tags_NextValueText = "Txt_Next_Value";
      [Token(Token = "0x401111D")]
      private const string Tags_TweenScale = "Unmask";
      [Token(Token = "0x401111E")]
      private const string Tags_StatusRankUp = "StatusRankUp";
      [Token(Token = "0x401111F")]
      [FieldOffset(Offset = "0x20")]
      private PlayableDirector effectStatusRankUpPlayable;
      [Token(Token = "0x4011121")]
      [FieldOffset(Offset = "0x28")]
      private bool playing;

      [Token(Token = "0x1700516C")]
      public static float TweenDurationOrigin
      {
        [Token(Token = "0x60190D5"), Address(RVA = "0x296C8CC", Offset = "0x296C8CC", VA = "0x296C8CC")] get
        {
          return new float();
        }
        [Token(Token = "0x60190D6"), Address(RVA = "0x296C914", Offset = "0x296C914", VA = "0x296C914")] private set
        {
        }
      }

      [Token(Token = "0x60190D7")]
      [Address(RVA = "0x2969DD8", Offset = "0x2969DD8", VA = "0x2969DD8")]
      public StatusObject(GameObject instance)
      {
      }

      [Token(Token = "0x60190D8")]
      [Address(RVA = "0x296C968", Offset = "0x296C968", VA = "0x296C968")]
      public void Initialize()
      {
      }

      [Token(Token = "0x60190D9")]
      [Address(RVA = "0x296BB88", Offset = "0x296BB88", VA = "0x296BB88")]
      public void SetParameterTitle(string title)
      {
      }

      [Token(Token = "0x60190DA")]
      [Address(RVA = "0x296BBE8", Offset = "0x296BBE8", VA = "0x296BBE8")]
      public void SetParameterRank(int rankNum)
      {
      }

      [Token(Token = "0x60190DB")]
      [Address(RVA = "0x296BC54", Offset = "0x296BC54", VA = "0x296BC54")]
      public void SetParameterRankColor(Color clr)
      {
      }

      [Token(Token = "0x60190DC")]
      [Address(RVA = "0x296BCD4", Offset = "0x296BCD4", VA = "0x296BCD4")]
      public void SetSliderValue(float from, float to, float duration)
      {
      }

      [Token(Token = "0x60190DD")]
      [Address(RVA = "0x296BD20", Offset = "0x296BD20", VA = "0x296BD20")]
      public void SetNextValue(int value)
      {
      }

      [Token(Token = "0x60190DE")]
      [Address(RVA = "0x296CBB4", Offset = "0x296CBB4", VA = "0x296CBB4")]
      public void PlayRankUpEffect()
      {
      }

      [Token(Token = "0x60190DF")]
      [Address(RVA = "0x296CBF8", Offset = "0x296CBF8", VA = "0x296CBF8")]
      public void StopEffect()
      {
      }

      [Token(Token = "0x1700516D")]
      public bool IsPlaying
      {
        [Token(Token = "0x60190E0"), Address(RVA = "0x296CC00", Offset = "0x296CC00", VA = "0x296CC00")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x60190E1")]
      [Address(RVA = "0x296C9A0", Offset = "0x296C9A0", VA = "0x296C9A0")]
      public void SetActiveRankUpEffect(bool active)
      {
      }

      [Token(Token = "0x60190E2")]
      [Address(RVA = "0x296CC08", Offset = "0x296CC08", VA = "0x296CC08")]
      private void rankUpEffectStopped(PlayableDirector playableDirector)
      {
      }
    }

    [Token(Token = "0x2003E2D")]
    private struct StatusGaugeValue
    {
      [Token(Token = "0x1700516E")]
      public readonly float FromValue
      {
        [Token(Token = "0x60190E3"), Address(RVA = "0x296CC10", Offset = "0x296CC10", VA = "0x296CC10")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x1700516F")]
      public readonly float ToValue
      {
        [Token(Token = "0x60190E4"), Address(RVA = "0x296CC18", Offset = "0x296CC18", VA = "0x296CC18")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x17005170")]
      public readonly float Duration
      {
        [Token(Token = "0x60190E5"), Address(RVA = "0x296CC20", Offset = "0x296CC20", VA = "0x296CC20")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x60190E6")]
      [Address(RVA = "0x296BEF8", Offset = "0x296BEF8", VA = "0x296BEF8")]
      public StatusGaugeValue(float from, float to, float duration)
      {
      }
    }

    [Token(Token = "0x2003E2E")]
    private struct RadarChartValue
    {
      [Token(Token = "0x4011125")]
      [FieldOffset(Offset = "0x0")]
      public int FromLevel;
      [Token(Token = "0x4011126")]
      [FieldOffset(Offset = "0x4")]
      public int ToLevel;

      [Token(Token = "0x60190E7")]
      [Address(RVA = "0x296BF04", Offset = "0x296BF04", VA = "0x296BF04")]
      public RadarChartValue(int from, int to)
      {
      }
    }

    [Token(Token = "0x2003E2F")]
    private struct NextExpValue
    {
      [Token(Token = "0x4011127")]
      [FieldOffset(Offset = "0x0")]
      public int FromValue;
      [Token(Token = "0x4011128")]
      [FieldOffset(Offset = "0x4")]
      public int ToValue;
      [Token(Token = "0x4011129")]
      [FieldOffset(Offset = "0x8")]
      public float Duration;

      [Token(Token = "0x60190E8")]
      [Address(RVA = "0x296BF0C", Offset = "0x296BF0C", VA = "0x296BF0C")]
      public NextExpValue(int from, int to, float duration)
      {
      }

      [Token(Token = "0x60190E9")]
      [Address(RVA = "0x296CC28", Offset = "0x296CC28", VA = "0x296CC28")]
      public int Get(float time) => new int();
    }

    [Token(Token = "0x2003E30")]
    private struct UpdateGaugeParam
    {
      [Token(Token = "0x401112A")]
      [FieldOffset(Offset = "0x0")]
      public int id;
      [Token(Token = "0x401112B")]
      [FieldOffset(Offset = "0x4")]
      public bool isRrankUp;

      [Token(Token = "0x60190EA")]
      [Address(RVA = "0x296BEE0", Offset = "0x296BEE0", VA = "0x296BEE0")]
      public UpdateGaugeParam(int id, bool rankUp)
      {
      }
    }
  }
}
