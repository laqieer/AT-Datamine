// Decompiled with JetBrains decompiler
// Type: ShaderTimeline.ShaderMixerBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace ShaderTimeline
{
  [Token(Token = "0x200076D")]
  public class ShaderMixerBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x40021F5")]
    [FieldOffset(Offset = "0x10")]
    private bool resetParameter;
    [Token(Token = "0x40021F6")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, ShaderMixerBehaviourData> propertyDatas;

    [Token(Token = "0x1700063B")]
    public TimelineClip[] Clips
    {
      [Token(Token = "0x600297C"), Address(RVA = "0x3680F14", Offset = "0x3680F14", VA = "0x3680F14")] get
      {
        return (TimelineClip[]) null;
      }
      [Token(Token = "0x600297D"), Address(RVA = "0x3680F1C", Offset = "0x3680F1C", VA = "0x3680F1C")] set
      {
      }
    }

    [Token(Token = "0x1700063C")]
    public PlayableDirector Director
    {
      [Token(Token = "0x600297E"), Address(RVA = "0x3680F24", Offset = "0x3680F24", VA = "0x3680F24")] get
      {
        return (PlayableDirector) null;
      }
      [Token(Token = "0x600297F"), Address(RVA = "0x3680F2C", Offset = "0x3680F2C", VA = "0x3680F2C")] set
      {
      }
    }

    [Token(Token = "0x6002980")]
    [Address(RVA = "0x3680F34", Offset = "0x3680F34", VA = "0x3680F34", Slot = "21")]
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
    }

    [Token(Token = "0x6002981")]
    [Address(RVA = "0x3681908", Offset = "0x3681908", VA = "0x3681908")]
    private void CloneMaterials(ShaderBehaviour behaviour, ShaderPlayableValue playableValue)
    {
    }

    [Token(Token = "0x6002982")]
    [Address(RVA = "0x3681E58", Offset = "0x3681E58", VA = "0x3681E58", Slot = "14")]
    public override void OnGraphStop(Playable playable)
    {
    }

    [Token(Token = "0x6002983")]
    [Address(RVA = "0x3681EB4", Offset = "0x3681EB4", VA = "0x3681EB4")]
    public void ResetParameter(bool force = false)
    {
    }

    [Token(Token = "0x6002984")]
    [Address(RVA = "0x3682128", Offset = "0x3682128", VA = "0x3682128")]
    public ShaderMixerBehaviour()
    {
    }
  }
}
