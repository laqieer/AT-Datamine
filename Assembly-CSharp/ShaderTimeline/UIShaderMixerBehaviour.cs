// Decompiled with JetBrains decompiler
// Type: ShaderTimeline.UIShaderMixerBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

#nullable disable
namespace ShaderTimeline
{
  [Token(Token = "0x2000774")]
  public class UIShaderMixerBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x4002208")]
    [FieldOffset(Offset = "0x10")]
    private Graphic graphic;
    [Token(Token = "0x4002209")]
    [FieldOffset(Offset = "0x18")]
    private bool resetParameter;
    [Token(Token = "0x400220A")]
    [FieldOffset(Offset = "0x20")]
    private Material prevMaterial;

    [Token(Token = "0x1700063F")]
    public TimelineClip[] Clips
    {
      [Token(Token = "0x6002990"), Address(RVA = "0x3682A60", Offset = "0x3682A60", VA = "0x3682A60")] get
      {
        return (TimelineClip[]) null;
      }
      [Token(Token = "0x6002991"), Address(RVA = "0x3682A68", Offset = "0x3682A68", VA = "0x3682A68")] set
      {
      }
    }

    [Token(Token = "0x17000640")]
    public PlayableDirector Director
    {
      [Token(Token = "0x6002992"), Address(RVA = "0x3682A70", Offset = "0x3682A70", VA = "0x3682A70")] get
      {
        return (PlayableDirector) null;
      }
      [Token(Token = "0x6002993"), Address(RVA = "0x3682A78", Offset = "0x3682A78", VA = "0x3682A78")] set
      {
      }
    }

    [Token(Token = "0x6002994")]
    [Address(RVA = "0x3682A80", Offset = "0x3682A80", VA = "0x3682A80", Slot = "21")]
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
    }

    [Token(Token = "0x6002995")]
    [Address(RVA = "0x3683074", Offset = "0x3683074", VA = "0x3683074", Slot = "14")]
    public override void OnGraphStop(Playable playable)
    {
    }

    [Token(Token = "0x6002996")]
    [Address(RVA = "0x368310C", Offset = "0x368310C", VA = "0x368310C")]
    public UIShaderMixerBehaviour()
    {
    }
  }
}
