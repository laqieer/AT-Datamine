// Decompiled with JetBrains decompiler
// Type: UnityEngine.Timeline.UrlVideoScriptPlayableAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.Playables;
using UnityEngine.UI;
using UnityEngine.Video;

#nullable disable
namespace UnityEngine.Timeline
{
  [Token(Token = "0x2003F3F")]
  [Serializable]
  public class UrlVideoScriptPlayableAsset : PlayableAsset
  {
    [Token(Token = "0x40114F7")]
    [FieldOffset(Offset = "0x18")]
    public ExposedReference<VideoPlayer> videoPlayer;
    [Token(Token = "0x40114F8")]
    [FieldOffset(Offset = "0x28")]
    public ExposedReference<RawImage> rawImage;
    [Token(Token = "0x40114F9")]
    [FieldOffset(Offset = "0x38")]
    [NotKeyable]
    [SerializeField]
    public string movieFileName;
    [Token(Token = "0x40114FA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [NotKeyable]
    public int movieWidth;
    [Token(Token = "0x40114FB")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    [NotKeyable]
    public int movieHeight;
    [Token(Token = "0x40114FC")]
    [FieldOffset(Offset = "0x48")]
    [NotKeyable]
    [SerializeField]
    public bool mute;
    [Token(Token = "0x40114FD")]
    [FieldOffset(Offset = "0x49")]
    [NotKeyable]
    [SerializeField]
    public bool loop;
    [Token(Token = "0x40114FE")]
    [FieldOffset(Offset = "0x50")]
    [NotKeyable]
    [SerializeField]
    public double preloadTime;
    [Token(Token = "0x40114FF")]
    [FieldOffset(Offset = "0x58")]
    [NotKeyable]
    [SerializeField]
    public double clipInTime;

    [Token(Token = "0x601989B")]
    [Address(RVA = "0x37478B0", Offset = "0x37478B0", VA = "0x37478B0", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => new Playable();

    [Token(Token = "0x601989C")]
    [Address(RVA = "0x3747A44", Offset = "0x3747A44", VA = "0x3747A44")]
    public UrlVideoScriptPlayableAsset()
    {
    }
  }
}
