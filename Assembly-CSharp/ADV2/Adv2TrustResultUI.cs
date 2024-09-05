// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2TrustResultUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.LuaScript;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E3A")]
  public class Adv2TrustResultUI : Adv2UI
  {
    [Token(Token = "0x4011149")]
    private const string Tag_TweenGroup = "Root";
    [Token(Token = "0x401114A")]
    private const string Tag_UnitThumb = "Thumb";
    [Token(Token = "0x401114B")]
    private const string Tag_RankValue = "RankValue";
    [Token(Token = "0x401114C")]
    private const string Tag_NextRankNum = "RankValueEffect";
    [Token(Token = "0x401114D")]
    private const string Tag_TweenSlider = "GaugeSlider";
    [Token(Token = "0x401114E")]
    private const string Tag_SkipButton = "SkipButton";
    [Token(Token = "0x401114F")]
    private const float WaitSeconds = 0.4f;
    [Token(Token = "0x4011150")]
    [FieldOffset(Offset = "0x68")]
    private string TweenGaugeMax;
    [Token(Token = "0x4011151")]
    [FieldOffset(Offset = "0x70")]
    private string TweenSlideGauge;
    [Token(Token = "0x4011152")]
    [FieldOffset(Offset = "0x78")]
    private Transform parent;
    [Token(Token = "0x4011153")]
    [FieldOffset(Offset = "0x80")]
    private Button skipButton;
    [Token(Token = "0x4011154")]
    [FieldOffset(Offset = "0x88")]
    private Adv2Manager.OnProccessSignal directionSignal;
    [Token(Token = "0x4011155")]
    [FieldOffset(Offset = "0x90")]
    private Adv2Manager.OnProccessSignal timelineContorllerSignal;
    [Token(Token = "0x4011156")]
    [FieldOffset(Offset = "0x98")]
    private bool skipDirection;
    [Token(Token = "0x4011157")]
    [FieldOffset(Offset = "0xA0")]
    private LuaSequence.ParamControl.ComuParam param;

    [Token(Token = "0x6019111")]
    [Address(RVA = "0x296E41C", Offset = "0x296E41C", VA = "0x296E41C")]
    public static Adv2TrustResultUI Create(GameObject addComponent, Transform parent)
    {
      return (Adv2TrustResultUI) null;
    }

    [Token(Token = "0x6019112")]
    [Address(RVA = "0x296E47C", Offset = "0x296E47C", VA = "0x296E47C")]
    public void SetBindObject(GameObject prefab)
    {
    }

    [Token(Token = "0x6019113")]
    [Address(RVA = "0x296E640", Offset = "0x296E640", VA = "0x296E640")]
    private void Init(GameObject prefab)
    {
    }

    [Token(Token = "0x6019114")]
    [Address(RVA = "0x296E824", Offset = "0x296E824", VA = "0x296E824")]
    public void SetGauge(LuaHuman character, LuaSequence.ParamControl.ComuParam param)
    {
    }

    [Token(Token = "0x6019115")]
    [Address(RVA = "0x296EA44", Offset = "0x296EA44", VA = "0x296EA44")]
    private void SetSliderValue(float fromValue, float toValue)
    {
    }

    [Token(Token = "0x6019116")]
    [Address(RVA = "0x296E780", Offset = "0x296E780", VA = "0x296E780")]
    private void SetActiveSkipButton(bool isActive)
    {
    }

    [Token(Token = "0x6019117")]
    [Address(RVA = "0x296EB60", Offset = "0x296EB60", VA = "0x296EB60")]
    private void OnSkipGauge()
    {
    }

    [Token(Token = "0x6019118")]
    [Address(RVA = "0x296EB6C", Offset = "0x296EB6C", VA = "0x296EB6C")]
    public Adv2Manager.OnProccessSignal Play() => (Adv2Manager.OnProccessSignal) null;

    [Token(Token = "0x6019119")]
    [Address(RVA = "0x296EC24", Offset = "0x296EC24", VA = "0x296EC24")]
    private IEnumerator PlayDirection() => (IEnumerator) null;

    [Token(Token = "0x601911A")]
    [Address(RVA = "0x296ECB4", Offset = "0x296ECB4", VA = "0x296ECB4")]
    private IEnumerator PlayTweenGroup(string tweenGroupId, bool enableSkip = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601911B")]
    [Address(RVA = "0x296ED5C", Offset = "0x296ED5C", VA = "0x296ED5C")]
    public Adv2TrustResultUI()
    {
    }
  }
}
