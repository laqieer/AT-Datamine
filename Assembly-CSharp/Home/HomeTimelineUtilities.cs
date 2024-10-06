// Decompiled with JetBrains decompiler
// Type: Home.HomeTimelineUtilities
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace Home
{
  [Token(Token = "0x2000B48")]
  public class HomeTimelineUtilities
  {
    [Token(Token = "0x600403C")]
    [Address(RVA = "0x2A24B58", Offset = "0x2A24B58", VA = "0x2A24B58")]
    public static PlayableDirector CreatePlayableDirector(int index, GameObject root)
    {
      return (PlayableDirector) null;
    }

    [Token(Token = "0x600403D")]
    [Address(RVA = "0x2A24D8C", Offset = "0x2A24D8C", VA = "0x2A24D8C")]
    public static PlayableDirector CreateTemporaryPlayableDirector(GameObject root)
    {
      return (PlayableDirector) null;
    }

    [Token(Token = "0x600403E")]
    [Address(RVA = "0x2A24FDC", Offset = "0x2A24FDC", VA = "0x2A24FDC")]
    public static void SetTimelineBinding(
      PlayableDirector director,
      string trackName,
      Object bindingTarget)
    {
    }

    [Token(Token = "0x600403F")]
    [Address(RVA = "0x2A251F0", Offset = "0x2A251F0", VA = "0x2A251F0")]
    public static void CopyAnimationTrack(
      TimelineAsset fromTimelineAsset,
      string fromTrackName,
      AnimationTrack toTrackAsset,
      double startTime,
      double? endBeforeTime = null)
    {
    }

    [Token(Token = "0x6004040")]
    [Address(RVA = "0x2A258B0", Offset = "0x2A258B0", VA = "0x2A258B0")]
    public HomeTimelineUtilities()
    {
    }
  }
}
