// Decompiled with JetBrains decompiler
// Type: ShaderTimeline.RendererShaderMixerBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace ShaderTimeline
{
  [Token(Token = "0x2000768")]
  public class RendererShaderMixerBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x40021DB")]
    [FieldOffset(Offset = "0x10")]
    private Renderer renderer;
    [Token(Token = "0x40021DC")]
    [FieldOffset(Offset = "0x18")]
    private bool resetParameter;
    [Token(Token = "0x40021DD")]
    [FieldOffset(Offset = "0x20")]
    private readonly List<Material> prevMaterials;
    [Token(Token = "0x40021DE")]
    [FieldOffset(Offset = "0x28")]
    private List<Material> materials;

    [Token(Token = "0x17000638")]
    public TimelineClip[] Clips
    {
      [Token(Token = "0x600296E"), Address(RVA = "0x367FFBC", Offset = "0x367FFBC", VA = "0x367FFBC")] get
      {
        return (TimelineClip[]) null;
      }
      [Token(Token = "0x600296F"), Address(RVA = "0x367FFC4", Offset = "0x367FFC4", VA = "0x367FFC4")] set
      {
      }
    }

    [Token(Token = "0x17000639")]
    public PlayableDirector Director
    {
      [Token(Token = "0x6002970"), Address(RVA = "0x367FFCC", Offset = "0x367FFCC", VA = "0x367FFCC")] get
      {
        return (PlayableDirector) null;
      }
      [Token(Token = "0x6002971"), Address(RVA = "0x367FFD4", Offset = "0x367FFD4", VA = "0x367FFD4")] set
      {
      }
    }

    [Token(Token = "0x6002972")]
    [Address(RVA = "0x367FFDC", Offset = "0x367FFDC", VA = "0x367FFDC", Slot = "21")]
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
    }

    [Token(Token = "0x6002973")]
    [Address(RVA = "0x36809B4", Offset = "0x36809B4", VA = "0x36809B4", Slot = "14")]
    public override void OnGraphStop(Playable playable)
    {
    }

    [Token(Token = "0x6002974")]
    [Address(RVA = "0x3680A5C", Offset = "0x3680A5C", VA = "0x3680A5C")]
    public void ResetParameter(bool force = false)
    {
    }

    [Token(Token = "0x6002975")]
    [Address(RVA = "0x3680B1C", Offset = "0x3680B1C", VA = "0x3680B1C")]
    public RendererShaderMixerBehaviour()
    {
    }
  }
}
