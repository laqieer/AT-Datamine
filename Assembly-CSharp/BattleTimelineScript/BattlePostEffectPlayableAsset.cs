// Decompiled with JetBrains decompiler
// Type: BattleTimelineScript.BattlePostEffectPlayableAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;

#nullable disable
namespace BattleTimelineScript
{
  [Token(Token = "0x20021FB")]
  public class BattlePostEffectPlayableAsset : PlayableAsset
  {
    [Token(Token = "0x4008F9D")]
    [FieldOffset(Offset = "0x18")]
    public VolumeProfile postProcessProfile;

    [Token(Token = "0x600CEFA")]
    [Address(RVA = "0x4B68EAC", Offset = "0x4B68EAC", VA = "0x4B68EAC", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
      return new Playable();
    }

    [Token(Token = "0x600CEFB")]
    [Address(RVA = "0x4B68FB8", Offset = "0x4B68FB8", VA = "0x4B68FB8")]
    public BattlePostEffectPlayableAsset()
    {
    }
  }
}
