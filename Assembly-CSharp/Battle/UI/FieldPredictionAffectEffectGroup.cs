// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldPredictionAffectEffectGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Logic.Prediction;
using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023F0")]
  [RequireComponent(typeof (UITweenGroup))]
  public class FieldPredictionAffectEffectGroup : MonoBehaviour
  {
    [Token(Token = "0x4009978")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4009979")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<FieldPredictionAffectEffect> giveEffects;
    [Token(Token = "0x400997A")]
    [FieldOffset(Offset = "0x28")]
    private UnityAction tweenCallback;
    [Token(Token = "0x400997B")]
    [FieldOffset(Offset = "0x30")]
    private int displayMax;
    [Token(Token = "0x400997C")]
    [FieldOffset(Offset = "0x38")]
    private List<PredictionUnitResult.EffectIcon> effectIcons;
    [Token(Token = "0x400997D")]
    [FieldOffset(Offset = "0x40")]
    private Queue<PredictionUnitResult.EffectIcon> effectIconDisplayQueue;

    [Token(Token = "0x600DC2A")]
    [Address(RVA = "0x21541F8", Offset = "0x21541F8", VA = "0x21541F8")]
    public void Initialize(List<PredictionUnitResult.EffectIcon> effectIcons, int displayMax = -1)
    {
    }

    [Token(Token = "0x600DC2B")]
    [Address(RVA = "0x2154EF8", Offset = "0x2154EF8", VA = "0x2154EF8")]
    private void UpdateNextDisplayIcon()
    {
    }

    [Token(Token = "0x600DC2C")]
    [Address(RVA = "0x21550B8", Offset = "0x21550B8", VA = "0x21550B8")]
    private void PlayTweenAnimation(string groupID, bool stopPlayingAnim, UnityAction callback)
    {
    }

    [Token(Token = "0x600DC2D")]
    [Address(RVA = "0x2154EA8", Offset = "0x2154EA8", VA = "0x2154EA8")]
    public void StopTween()
    {
    }

    [Token(Token = "0x600DC2E")]
    [Address(RVA = "0x215518C", Offset = "0x215518C", VA = "0x215518C")]
    public FieldPredictionAffectEffectGroup()
    {
    }
  }
}
