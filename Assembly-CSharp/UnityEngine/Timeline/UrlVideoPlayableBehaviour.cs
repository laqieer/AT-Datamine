// Decompiled with JetBrains decompiler
// Type: UnityEngine.Timeline.UrlVideoPlayableBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using UnityEngine.Playables;
using UnityEngine.UI;
using UnityEngine.Video;

#nullable disable
namespace UnityEngine.Timeline
{
  [Token(Token = "0x2003F3C")]
  public class UrlVideoPlayableBehaviour : PlayableBehaviour, IAppLifeCycleListener
  {
    [Token(Token = "0x40114E5")]
    [FieldOffset(Offset = "0x10")]
    public VideoPlayer videoPlayer;
    [Token(Token = "0x40114E6")]
    [FieldOffset(Offset = "0x18")]
    public RawImage rawImage;
    [Token(Token = "0x40114E7")]
    [FieldOffset(Offset = "0x20")]
    public string url;
    [Token(Token = "0x40114E8")]
    [FieldOffset(Offset = "0x28")]
    public int movieWidth;
    [Token(Token = "0x40114E9")]
    [FieldOffset(Offset = "0x2C")]
    public int movieHeight;
    [Token(Token = "0x40114EA")]
    [FieldOffset(Offset = "0x30")]
    public bool mute;
    [Token(Token = "0x40114EB")]
    [FieldOffset(Offset = "0x31")]
    public bool loop;
    [Token(Token = "0x40114EC")]
    [FieldOffset(Offset = "0x38")]
    public double preloadTime;
    [Token(Token = "0x40114ED")]
    [FieldOffset(Offset = "0x40")]
    public double clipInTime;
    [Token(Token = "0x40114EE")]
    [FieldOffset(Offset = "0x48")]
    private bool playedOnce;
    [Token(Token = "0x40114EF")]
    [FieldOffset(Offset = "0x49")]
    private bool preparing;
    [Token(Token = "0x40114F0")]
    [FieldOffset(Offset = "0x4A")]
    private bool settingFrame;
    [Token(Token = "0x40114F1")]
    [FieldOffset(Offset = "0x4B")]
    private bool isAppSuspend;
    [Token(Token = "0x40114F2")]
    [FieldOffset(Offset = "0x4C")]
    private bool isAppResume;

    [Token(Token = "0x6019880")]
    [Address(RVA = "0x3746318", Offset = "0x3746318", VA = "0x3746318", Slot = "23")]
    public void OnAppPause(bool pause)
    {
    }

    [Token(Token = "0x6019881")]
    [Address(RVA = "0x37463DC", Offset = "0x37463DC", VA = "0x37463DC")]
    public void PrepareVideo()
    {
    }

    [Token(Token = "0x6019882")]
    [Address(RVA = "0x37466D0", Offset = "0x37466D0", VA = "0x37466D0")]
    private void UpdateSettingVolume()
    {
    }

    [Token(Token = "0x6019883")]
    [Address(RVA = "0x3746864", Offset = "0x3746864", VA = "0x3746864")]
    private void LoopPointReached(VideoPlayer vp)
    {
    }

    [Token(Token = "0x6019884")]
    [Address(RVA = "0x3746874", Offset = "0x3746874", VA = "0x3746874", Slot = "20")]
    public override void PrepareFrame(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x6019885")]
    [Address(RVA = "0x3746974", Offset = "0x3746974", VA = "0x3746974", Slot = "17")]
    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x6019886")]
    [Address(RVA = "0x3746C10", Offset = "0x3746C10", VA = "0x3746C10", Slot = "18")]
    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x6019887")]
    [Address(RVA = "0x3746D60", Offset = "0x3746D60", VA = "0x3746D60", Slot = "21")]
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
    }

    [Token(Token = "0x6019888")]
    [Address(RVA = "0x3746F68", Offset = "0x3746F68", VA = "0x3746F68", Slot = "13")]
    public override void OnGraphStart(Playable playable)
    {
    }

    [Token(Token = "0x6019889")]
    [Address(RVA = "0x3746F70", Offset = "0x3746F70", VA = "0x3746F70", Slot = "14")]
    public override void OnGraphStop(Playable playable)
    {
    }

    [Token(Token = "0x601988A")]
    [Address(RVA = "0x3746FE8", Offset = "0x3746FE8", VA = "0x3746FE8", Slot = "16")]
    public override void OnPlayableDestroy(Playable playable)
    {
    }

    [Token(Token = "0x601988B")]
    [Address(RVA = "0x3746A68", Offset = "0x3746A68", VA = "0x3746A68")]
    public void PlayVideo(Playable playable)
    {
    }

    [Token(Token = "0x601988C")]
    [Address(RVA = "0x37472A8", Offset = "0x37472A8", VA = "0x37472A8")]
    private void AutoPlay(VideoPlayer source, Playable playable)
    {
    }

    [Token(Token = "0x601988D")]
    [Address(RVA = "0x3746CE0", Offset = "0x3746CE0", VA = "0x3746CE0")]
    public void PauseVideo()
    {
    }

    [Token(Token = "0x601988E")]
    [Address(RVA = "0x374664C", Offset = "0x374664C", VA = "0x374664C")]
    public void StopVideo()
    {
    }

    [Token(Token = "0x601988F")]
    [Address(RVA = "0x3746E98", Offset = "0x3746E98", VA = "0x3746E98")]
    private void SyncSpeedUp(Playable playable)
    {
    }

    [Token(Token = "0x6019890")]
    [Address(RVA = "0x374717C", Offset = "0x374717C", VA = "0x374717C")]
    private void SyncVideoToPlayable(Playable playable)
    {
    }

    [Token(Token = "0x6019891")]
    [Address(RVA = "0x3747390", Offset = "0x3747390", VA = "0x3747390")]
    private void FrameReadyEventHandler(VideoPlayer source, long frameIdx)
    {
    }

    [Token(Token = "0x6019892")]
    [Address(RVA = "0x3747398", Offset = "0x3747398", VA = "0x3747398")]
    public UrlVideoPlayableBehaviour()
    {
    }
  }
}
