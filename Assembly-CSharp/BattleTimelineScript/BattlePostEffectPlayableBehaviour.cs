// Decompiled with JetBrains decompiler
// Type: BattleTimelineScript.BattlePostEffectPlayableBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.Playables;
using UnityEngine.Rendering;

#nullable disable
namespace BattleTimelineScript
{
  [Token(Token = "0x20021FC")]
  [Serializable]
  public class BattlePostEffectPlayableBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x4008F9E")]
    [FieldOffset(Offset = "0x10")]
    private VolumeProfile postProcessProfile;
    [Token(Token = "0x4008F9F")]
    [FieldOffset(Offset = "0x18")]
    private Volume postProcessVolume;

    [Token(Token = "0x600CEFC")]
    [Address(RVA = "0x4B68F9C", Offset = "0x4B68F9C", VA = "0x4B68F9C")]
    public void Initialize(BattlePostEffectPlayableAsset asset, PlayableGraph graph)
    {
    }

    [Token(Token = "0x600CEFD")]
    [Address(RVA = "0x4B68FC0", Offset = "0x4B68FC0", VA = "0x4B68FC0")]
    private void CreatePostProcessVolume()
    {
    }

    [Token(Token = "0x600CEFE")]
    [Address(RVA = "0x4B69238", Offset = "0x4B69238", VA = "0x4B69238")]
    private void UpdatePostProcessVolume(FrameData info)
    {
    }

    [Token(Token = "0x600CEFF")]
    [Address(RVA = "0x4B69260", Offset = "0x4B69260", VA = "0x4B69260")]
    private void DestroyPostProcessVolume()
    {
    }

    [Token(Token = "0x600CF00")]
    [Address(RVA = "0x4B692D4", Offset = "0x4B692D4", VA = "0x4B692D4", Slot = "15")]
    public override void OnPlayableCreate(Playable playable)
    {
    }

    [Token(Token = "0x600CF01")]
    [Address(RVA = "0x4B692DC", Offset = "0x4B692DC", VA = "0x4B692DC", Slot = "16")]
    public override void OnPlayableDestroy(Playable playable)
    {
    }

    [Token(Token = "0x600CF02")]
    [Address(RVA = "0x4B6937C", Offset = "0x4B6937C", VA = "0x4B6937C", Slot = "19")]
    public override void PrepareData(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x600CF03")]
    [Address(RVA = "0x4B693AC", Offset = "0x4B693AC", VA = "0x4B693AC", Slot = "20")]
    public override void PrepareFrame(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x600CF04")]
    [Address(RVA = "0x4B693DC", Offset = "0x4B693DC", VA = "0x4B693DC", Slot = "21")]
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
    }

    [Token(Token = "0x600CF05")]
    [Address(RVA = "0x4B694C4", Offset = "0x4B694C4", VA = "0x4B694C4", Slot = "13")]
    public override void OnGraphStart(Playable playable)
    {
    }

    [Token(Token = "0x600CF06")]
    [Address(RVA = "0x4B694CC", Offset = "0x4B694CC", VA = "0x4B694CC", Slot = "14")]
    public override void OnGraphStop(Playable playable)
    {
    }

    [Token(Token = "0x600CF07")]
    [Address(RVA = "0x4B694D4", Offset = "0x4B694D4", VA = "0x4B694D4", Slot = "18")]
    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x600CF08")]
    [Address(RVA = "0x4B695CC", Offset = "0x4B695CC", VA = "0x4B695CC", Slot = "17")]
    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x600CF09")]
    [Address(RVA = "0x4B696F4", Offset = "0x4B696F4", VA = "0x4B696F4")]
    public BattlePostEffectPlayableBehaviour()
    {
    }
  }
}
