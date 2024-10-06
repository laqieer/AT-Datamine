// Decompiled with JetBrains decompiler
// Type: UnityEngine.Timeline.VideoScriptPlayableAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.Playables;
using UnityEngine.Video;

#nullable disable
namespace UnityEngine.Timeline
{
  [Token(Token = "0x2003F43")]
  [Serializable]
  public class VideoScriptPlayableAsset : PlayableAsset
  {
    [Token(Token = "0x401150A")]
    [FieldOffset(Offset = "0x18")]
    public ExposedReference<VideoPlayer> videoPlayer;
    [Token(Token = "0x401150B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [NotKeyable]
    public VideoClip videoClip;
    [Token(Token = "0x401150C")]
    [FieldOffset(Offset = "0x30")]
    [NotKeyable]
    [SerializeField]
    public bool mute;
    [Token(Token = "0x401150D")]
    [FieldOffset(Offset = "0x31")]
    [SerializeField]
    [NotKeyable]
    public bool loop;
    [Token(Token = "0x401150E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [NotKeyable]
    public double preloadTime;
    [Token(Token = "0x401150F")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [NotKeyable]
    public double clipInTime;

    [Token(Token = "0x60198B3")]
    [Address(RVA = "0x3748BC8", Offset = "0x3748BC8", VA = "0x3748BC8", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => new Playable();

    [Token(Token = "0x60198B4")]
    [Address(RVA = "0x3748D14", Offset = "0x3748D14", VA = "0x3748D14")]
    public VideoScriptPlayableAsset()
    {
    }
  }
}
