// Decompiled with JetBrains decompiler
// Type: BattleTimelineScript.BattleElementEffectPlayableAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace BattleTimelineScript
{
  [Token(Token = "0x20021F7")]
  public class BattleElementEffectPlayableAsset : BattleEffectPlayableAsset
  {
    [Token(Token = "0x4008F98")]
    [FieldOffset(Offset = "0x90")]
    [HideInInspector]
    public BattleElementEffectTrack elementEffectTrack;
    [Token(Token = "0x4008F99")]
    [FieldOffset(Offset = "0x98")]
    public DuelElementEffectSettingsAsset elementEffectList;

    [Token(Token = "0x600CEF1")]
    [Address(RVA = "0x4B68954", Offset = "0x4B68954", VA = "0x4B68954")]
    public void Initialize(GameObject bindingTarget, BattleElementEffectTrack elementEffectTrack)
    {
    }

    [Token(Token = "0x600CEF2")]
    [Address(RVA = "0x4B68960", Offset = "0x4B68960", VA = "0x4B68960", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
      return new Playable();
    }

    [Token(Token = "0x600CEF3")]
    [Address(RVA = "0x4B68A88", Offset = "0x4B68A88", VA = "0x4B68A88")]
    public BattleElementEffectPlayableAsset()
    {
    }
  }
}
