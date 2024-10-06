// Decompiled with JetBrains decompiler
// Type: UnityEngine.Timeline.VideoPlayableBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Playables;
using UnityEngine.Video;

#nullable disable
namespace UnityEngine.Timeline
{
  [Token(Token = "0x2003F41")]
  public class VideoPlayableBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x4011500")]
    [FieldOffset(Offset = "0x10")]
    public VideoPlayer videoPlayer;
    [Token(Token = "0x4011501")]
    [FieldOffset(Offset = "0x18")]
    public VideoClip videoClip;
    [Token(Token = "0x4011502")]
    [FieldOffset(Offset = "0x20")]
    public bool mute;
    [Token(Token = "0x4011503")]
    [FieldOffset(Offset = "0x21")]
    public bool loop;
    [Token(Token = "0x4011504")]
    [FieldOffset(Offset = "0x28")]
    public double preloadTime;
    [Token(Token = "0x4011505")]
    [FieldOffset(Offset = "0x30")]
    public double clipInTime;
    [Token(Token = "0x4011506")]
    [FieldOffset(Offset = "0x38")]
    private bool playedOnce;
    [Token(Token = "0x4011507")]
    [FieldOffset(Offset = "0x39")]
    private bool preparing;

    [Token(Token = "0x601989F")]
    [Address(RVA = "0x3747C10", Offset = "0x3747C10", VA = "0x3747C10")]
    public void PrepareVideo()
    {
    }

    [Token(Token = "0x60198A0")]
    [Address(RVA = "0x3747FB4", Offset = "0x3747FB4", VA = "0x3747FB4")]
    private void LoopPointReached(VideoPlayer vp)
    {
    }

    [Token(Token = "0x60198A1")]
    [Address(RVA = "0x3747FC4", Offset = "0x3747FC4", VA = "0x3747FC4", Slot = "20")]
    public override void PrepareFrame(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x60198A2")]
    [Address(RVA = "0x374827C", Offset = "0x374827C", VA = "0x374827C", Slot = "17")]
    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x60198A3")]
    [Address(RVA = "0x37483BC", Offset = "0x37483BC", VA = "0x37483BC", Slot = "18")]
    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x60198A4")]
    [Address(RVA = "0x37484D0", Offset = "0x37484D0", VA = "0x37484D0", Slot = "21")]
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
    }

    [Token(Token = "0x60198A5")]
    [Address(RVA = "0x374869C", Offset = "0x374869C", VA = "0x374869C", Slot = "13")]
    public override void OnGraphStart(Playable playable)
    {
    }

    [Token(Token = "0x60198A6")]
    [Address(RVA = "0x37486A4", Offset = "0x37486A4", VA = "0x37486A4", Slot = "14")]
    public override void OnGraphStop(Playable playable)
    {
    }

    [Token(Token = "0x60198A7")]
    [Address(RVA = "0x37486CC", Offset = "0x37486CC", VA = "0x37486CC", Slot = "16")]
    public override void OnPlayableDestroy(Playable playable)
    {
    }

    [Token(Token = "0x60198A8")]
    [Address(RVA = "0x3748320", Offset = "0x3748320", VA = "0x3748320")]
    public void PlayVideo()
    {
    }

    [Token(Token = "0x60198A9")]
    [Address(RVA = "0x3748450", Offset = "0x3748450", VA = "0x3748450")]
    public void PauseVideo()
    {
    }

    [Token(Token = "0x60198AA")]
    [Address(RVA = "0x3747F30", Offset = "0x3747F30", VA = "0x3747F30")]
    public void StopVideo()
    {
    }

    [Token(Token = "0x60198AB")]
    [Address(RVA = "0x374811C", Offset = "0x374811C", VA = "0x374811C")]
    private void SyncVideoToPlayable(Playable playable)
    {
    }

    [Token(Token = "0x60198AC")]
    [Address(RVA = "0x37486D0", Offset = "0x37486D0", VA = "0x37486D0")]
    public VideoPlayableBehaviour()
    {
    }
  }
}
