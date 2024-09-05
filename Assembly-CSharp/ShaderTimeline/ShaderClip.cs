// Decompiled with JetBrains decompiler
// Type: ShaderTimeline.ShaderClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace ShaderTimeline
{
  [Token(Token = "0x200076C")]
  public class ShaderClip : PlayableAsset, ITimelineClipAsset
  {
    [Token(Token = "0x40021F3")]
    [FieldOffset(Offset = "0x18")]
    public ShaderBehaviour behaviour;
    [Token(Token = "0x40021F4")]
    [FieldOffset(Offset = "0x20")]
    public bool IsEnded;

    [Token(Token = "0x1700063A")]
    public ClipCaps clipCaps
    {
      [Token(Token = "0x6002979"), Address(RVA = "0x3680E0C", Offset = "0x3680E0C", VA = "0x3680E0C", Slot = "9")] get
      {
        return new ClipCaps();
      }
    }

    [Token(Token = "0x600297A")]
    [Address(RVA = "0x3680E14", Offset = "0x3680E14", VA = "0x3680E14", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
      return new Playable();
    }

    [Token(Token = "0x600297B")]
    [Address(RVA = "0x3680EB0", Offset = "0x3680EB0", VA = "0x3680EB0")]
    public ShaderClip()
    {
    }
  }
}
