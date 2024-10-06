// Decompiled with JetBrains decompiler
// Type: ADV2.Playables.TimelineAssetBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine.Timeline;

#nullable disable
namespace ADV2.Playables
{
  [Token(Token = "0x2003E8E")]
  public class TimelineAssetBehaviour : PlayableAssetBehaviour<TimelineAsset>
  {
    [Token(Token = "0x4011282")]
    [FieldOffset(Offset = "0x28")]
    private IEnumerable<TrackAsset> allTrackEntities;

    [Token(Token = "0x170051B5")]
    protected IEnumerable<TrackAsset> allTracks
    {
      [Token(Token = "0x60192E6"), Address(RVA = "0x2D01A20", Offset = "0x2D01A20", VA = "0x2D01A20")] get
      {
        return (IEnumerable<TrackAsset>) null;
      }
    }

    [Token(Token = "0x60192E7")]
    [Address(RVA = "0x2D01DF0", Offset = "0x2D01DF0", VA = "0x2D01DF0")]
    private void GetAllChildrenTracks(ref List<TrackAsset> list, TrackAsset track)
    {
    }

    [Token(Token = "0x60192E8")]
    [Address(RVA = "0x2D0215C", Offset = "0x2D0215C", VA = "0x2D0215C")]
    public void SetMuteTrack(bool isMuted, params string[] patterns)
    {
    }

    [Token(Token = "0x60192E9")]
    [Address(RVA = "0x2D02508", Offset = "0x2D02508", VA = "0x2D02508")]
    public TimelineAssetBehaviour()
    {
    }
  }
}
