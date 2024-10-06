// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Date.TimeElapsedTimelineController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace Scenes.Story.Date
{
  [Token(Token = "0x2002EAA")]
  public class TimeElapsedTimelineController
  {
    [Token(Token = "0x400C816")]
    private const string PREV_TIMEZONE_TRACK_NAME = "TimezoneRotationPrev";
    [Token(Token = "0x400C817")]
    private const string NEXT_TIMEZONE_TRACK_NAME = "TimezoneRotationNext";
    [Token(Token = "0x400C818")]
    private const string ROTATION_TRACK_NAME = "Time Elapsed Custom Track";
    [Token(Token = "0x400C819")]
    private const float ANGLE_MODIFY_FRAME_NUM = 3f;
    [Token(Token = "0x400C81A")]
    [FieldOffset(Offset = "0x10")]
    private PlayableDirector playableDirector;
    [Token(Token = "0x400C81B")]
    [FieldOffset(Offset = "0x18")]
    private TimeElapsedTimelineController.TimelineReference reference;
    [Token(Token = "0x400C81C")]
    [FieldOffset(Offset = "0x20")]
    private TimeElapsedContainer.Setting setting;
    [Token(Token = "0x400C81E")]
    [FieldOffset(Offset = "0x30")]
    public Action<PlayableDirector> StoppedCallback;

    [Token(Token = "0x17003DDC")]
    public Transform PrevRotation
    {
      [Token(Token = "0x601237B"), Address(RVA = "0x4596FAC", Offset = "0x4596FAC", VA = "0x4596FAC")] private get
      {
        return (Transform) null;
      }
      [Token(Token = "0x601237C"), Address(RVA = "0x4596FB4", Offset = "0x4596FB4", VA = "0x4596FB4")] set
      {
      }
    }

    [Token(Token = "0x601237D")]
    [Address(RVA = "0x4595F2C", Offset = "0x4595F2C", VA = "0x4595F2C")]
    public TimeElapsedTimelineController(
      PlayableDirector playableDirector,
      TimeElapsedContainer.Setting setting)
    {
    }

    [Token(Token = "0x601237E")]
    [Address(RVA = "0x45963F8", Offset = "0x45963F8", VA = "0x45963F8")]
    public void Setup(int prevIndex, Animator prev, int nextIndex, Animator next)
    {
    }

    [Token(Token = "0x601237F")]
    [Address(RVA = "0x4596AA4", Offset = "0x4596AA4", VA = "0x4596AA4")]
    public void Clear()
    {
    }

    [Token(Token = "0x6012380")]
    [Address(RVA = "0x4597324", Offset = "0x4597324", VA = "0x4597324")]
    private void Rebuild()
    {
    }

    [Token(Token = "0x6012381")]
    [Address(RVA = "0x45974F8", Offset = "0x45974F8", VA = "0x45974F8")]
    private void OnStoppedCallback(PlayableDirector director)
    {
    }

    [Token(Token = "0x6012382")]
    private T GetTrackTarget<T>(TrackAsset track) where T : UnityEngine.Object => (T) null;

    [Token(Token = "0x6012383")]
    private T GetTrackTarget<T>(string track) where T : UnityEngine.Object => (T) null;

    [Token(Token = "0x6012384")]
    [Address(RVA = "0x4597104", Offset = "0x4597104", VA = "0x4597104")]
    private void SetBind(string trackName, UnityEngine.Object bindObject)
    {
    }

    [Token(Token = "0x6012385")]
    [Address(RVA = "0x4597368", Offset = "0x4597368", VA = "0x4597368")]
    private void ClearBind(string trackName)
    {
    }

    [Token(Token = "0x6012386")]
    [Address(RVA = "0x4597524", Offset = "0x4597524", VA = "0x4597524")]
    private TrackAsset GetTrack(string track) => (TrackAsset) null;

    [Token(Token = "0x6012387")]
    [Address(RVA = "0x4597940", Offset = "0x4597940", VA = "0x4597940")]
    private static TrackAsset Recursive(IEnumerable<TrackAsset> tracks, string trackName)
    {
      return (TrackAsset) null;
    }

    [Token(Token = "0x6012388")]
    [Address(RVA = "0x4596FC4", Offset = "0x4596FC4", VA = "0x4596FC4")]
    private TimelineClip GetClip(string trackName, string clipName) => (TimelineClip) null;

    [Token(Token = "0x2002EAB")]
    public class TimelineReference
    {
      [Token(Token = "0x17003DDD")]
      public TimelineClip RotationClip
      {
        [Token(Token = "0x6012389"), Address(RVA = "0x4597D10", Offset = "0x4597D10", VA = "0x4597D10")] get
        {
          return (TimelineClip) null;
        }
        [Token(Token = "0x601238A"), Address(RVA = "0x4597D18", Offset = "0x4597D18", VA = "0x4597D18")] set
        {
        }
      }

      [Token(Token = "0x17003DDE")]
      public TimeElapsedCustomClip TimeElapsedCustomClip
      {
        [Token(Token = "0x601238B"), Address(RVA = "0x459729C", Offset = "0x459729C", VA = "0x459729C")] get
        {
          return (TimeElapsedCustomClip) null;
        }
      }

      [Token(Token = "0x17003DDF")]
      public TimelineClip NextTimezoneClip
      {
        [Token(Token = "0x601238C"), Address(RVA = "0x4597D20", Offset = "0x4597D20", VA = "0x4597D20")] get
        {
          return (TimelineClip) null;
        }
        [Token(Token = "0x601238D"), Address(RVA = "0x4597D28", Offset = "0x4597D28", VA = "0x4597D28")] set
        {
        }
      }

      [Token(Token = "0x17003DE0")]
      public GameObject Rotation
      {
        [Token(Token = "0x601238E"), Address(RVA = "0x4597D30", Offset = "0x4597D30", VA = "0x4597D30")] get
        {
          return (GameObject) null;
        }
        [Token(Token = "0x601238F"), Address(RVA = "0x4597D38", Offset = "0x4597D38", VA = "0x4597D38")] set
        {
        }
      }

      [Token(Token = "0x6012390")]
      [Address(RVA = "0x4596FBC", Offset = "0x4596FBC", VA = "0x4596FBC")]
      public TimelineReference()
      {
      }
    }
  }
}
