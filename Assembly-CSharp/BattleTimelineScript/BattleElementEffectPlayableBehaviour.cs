// Decompiled with JetBrains decompiler
// Type: BattleTimelineScript.BattleElementEffectPlayableBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace BattleTimelineScript
{
  [Token(Token = "0x20021F8")]
  [Serializable]
  public class BattleElementEffectPlayableBehaviour : BattleEffectPlayableBehaviour
  {
    [Token(Token = "0x4008F9A")]
    [FieldOffset(Offset = "0x98")]
    private BattleElementEffectTrack elementEffectTrack;
    [Token(Token = "0x4008F9B")]
    [FieldOffset(Offset = "0xA0")]
    private DuelElementEffectSettingsAsset elementEffectList;

    [Token(Token = "0x600CEF4")]
    [Address(RVA = "0x4B68A58", Offset = "0x4B68A58", VA = "0x4B68A58")]
    public void Initialize(
      BattleElementEffectPlayableAsset asset,
      PlayableGraph graph,
      GameObject bindingTarget)
    {
    }

    [Token(Token = "0x600CEF5")]
    [Address(RVA = "0x4B68A8C", Offset = "0x4B68A8C", VA = "0x4B68A8C", Slot = "17")]
    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x600CEF6")]
    [Address(RVA = "0x4B68AC4", Offset = "0x4B68AC4", VA = "0x4B68AC4")]
    public BattleElementEffectPlayableBehaviour()
    {
    }
  }
}
