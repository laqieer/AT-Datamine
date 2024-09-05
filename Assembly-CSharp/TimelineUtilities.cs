// Decompiled with JetBrains decompiler
// Type: TimelineUtilities
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using BattleTimelineScript;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x20001A0")]
public class TimelineUtilities
{
  [Token(Token = "0x6000AFF")]
  [Address(RVA = "0x4BBD1D8", Offset = "0x4BBD1D8", VA = "0x4BBD1D8")]
  public static void CopyBattleEffectTrack(
    TimelineAsset fromTimelineAsset,
    string fromTrackName,
    BattleEffectTrack toTrackAsset,
    double startTime,
    double? endBeforeTime = null)
  {
  }

  [Token(Token = "0x6000B00")]
  [Address(RVA = "0x4BBD758", Offset = "0x4BBD758", VA = "0x4BBD758")]
  public static void CopyAnimationTrack(
    TimelineAsset fromTimelineAsset,
    string fromTrackName,
    AnimationTrack toTrackAsset,
    double startTime,
    double? endBeforeTime = null)
  {
  }

  [Token(Token = "0x6000B01")]
  [Address(RVA = "0x4BBDE10", Offset = "0x4BBDE10", VA = "0x4BBDE10")]
  public static void CopyCustomObjectAnimationTracks(
    TimelineAsset fromTimelineAsset,
    string fromTrackNamePrefix,
    TrackAsset parentTrack,
    PlayableDirector toDirector,
    TimelineAsset toTimelineAsset,
    string toTrackNamePrefix,
    List<GameObject> bindingTargets,
    double startTime,
    double? endBeforeTime = null)
  {
  }

  [Token(Token = "0x6000B02")]
  [Address(RVA = "0x4BBE53C", Offset = "0x4BBE53C", VA = "0x4BBE53C")]
  public static void CopySignalTrack(
    TimelineAsset fromTimelineAsset,
    string fromTrackName,
    SignalTrack toTrackAsset,
    double startTime,
    List<SignalAsset> signalAssets)
  {
  }

  [Token(Token = "0x6000B03")]
  [Address(RVA = "0x4BBED9C", Offset = "0x4BBED9C", VA = "0x4BBED9C")]
  public static void CopySignalTrack(
    TimelineAsset fromTimelineAsset,
    string fromTrackName,
    SignalTrack toTrackAsset,
    double startTime,
    List<SignalAsset> signalAssets,
    List<string> signalNamesWithoutApplyingStartTime)
  {
  }

  [Token(Token = "0x6000B04")]
  [Address(RVA = "0x4BBF548", Offset = "0x4BBF548", VA = "0x4BBF548")]
  public static void AddSignalEmitterToSignalTrack(
    SignalTrack signalTrack,
    SignalAsset signalAsset,
    double time)
  {
  }

  [Token(Token = "0x6000B05")]
  [Address(RVA = "0x4BBF994", Offset = "0x4BBF994", VA = "0x4BBF994")]
  public static void CopyBattleEffectTrack(
    TimelineAsset fromTimelineAsset,
    PlayableDirector toDirector,
    TimelineAsset toTimelineAsset,
    string trackNameSuffix,
    TrackAsset parentTrack,
    GameObject bindingTarget,
    string fromTrackNamePrefix,
    double startTime,
    double? endBeforeTime = null,
    ElementEffectItem.ElementType elementType = ElementEffectItem.ElementType.None)
  {
  }

  [Token(Token = "0x6000B06")]
  [Address(RVA = "0x4BC06E0", Offset = "0x4BC06E0", VA = "0x4BC06E0")]
  public static void CopyBattleEffectTrack(
    TimelineAsset fromTimelineAsset,
    PlayableDirector toDirector,
    TimelineAsset toTimelineAsset,
    string trackNameSuffix,
    TrackAsset parentTrack,
    GameObject bindingTarget,
    string fromTrackNamePrefix,
    double startTime,
    float defaultFlyingDistance,
    float realFlyingDistance,
    double? endBeforeTime = null,
    ElementEffectItem.ElementType elementType = ElementEffectItem.ElementType.None)
  {
  }

  [Token(Token = "0x6000B07")]
  [Address(RVA = "0x4BC1DCC", Offset = "0x4BC1DCC", VA = "0x4BC1DCC")]
  public static void CopyBattlePostEffectTrack(
    TimelineAsset fromTimelineAsset,
    TimelineAsset toTimelineAsset,
    string trackNameSuffix,
    TrackAsset parentTrack,
    string fromTrackNamePrefix,
    double startTime,
    double? endBeforeTime = null)
  {
  }

  [Token(Token = "0x6000B08")]
  [Address(RVA = "0x4BC25C4", Offset = "0x4BC25C4", VA = "0x4BC25C4")]
  public static void CopyBattleSoundTrack(
    TimelineAsset fromTimelineAsset,
    TimelineAsset toTimelineAsset,
    TrackAsset parentTrack,
    string fromTrackNamePrefix,
    double startTime,
    double? endBeforeTime = null)
  {
  }

  [Token(Token = "0x6000B09")]
  [Address(RVA = "0x4BC2CBC", Offset = "0x4BC2CBC", VA = "0x4BC2CBC")]
  public static void CopyBattleVoiceTrack(
    TimelineAsset fromTimelineAsset,
    TimelineAsset toTimelineAsset,
    TrackAsset parentTrack,
    string fromTrackNamePrefix,
    double startTime,
    double? endBeforeTime = null)
  {
  }

  [Token(Token = "0x6000B0A")]
  [Address(RVA = "0x4BC33B4", Offset = "0x4BC33B4", VA = "0x4BC33B4")]
  public static void CopyTimeDilationTrack(
    TimelineAsset fromTimelineAsset,
    TimelineAsset toTimelineAsset,
    TrackAsset parentTrack,
    string fromTrackNamePrefix,
    double startTime,
    double? endBeforeTime = null)
  {
  }

  [Token(Token = "0x6000B0B")]
  [Address(RVA = "0x4BBE330", Offset = "0x4BBE330", VA = "0x4BBE330")]
  public static void SetTimelineBinding(
    PlayableDirector director,
    string trackName,
    UnityEngine.Object bindingTarget)
  {
  }

  [Token(Token = "0x6000B0C")]
  [Address(RVA = "0x4BC3B24", Offset = "0x4BC3B24", VA = "0x4BC3B24")]
  public static void SetRootTimelineBinding(
    PlayableDirector director,
    string rootName,
    string trackName,
    UnityEngine.Object bindingTarget)
  {
  }

  [Token(Token = "0x6000B0D")]
  [Address(RVA = "0x4BC40FC", Offset = "0x4BC40FC", VA = "0x4BC40FC")]
  public static void SetTrackMuted(PlayableDirector director, string trackName, bool isMuted)
  {
  }

  [Token(Token = "0x6000B0E")]
  [Address(RVA = "0x4BC429C", Offset = "0x4BC429C", VA = "0x4BC429C")]
  public static void SetRootTrackMuted(PlayableDirector director, string trackName, bool isMuted)
  {
  }

  [Token(Token = "0x6000B0F")]
  [Address(RVA = "0x4BC443C", Offset = "0x4BC443C", VA = "0x4BC443C")]
  public static void SetSubTrackMuted(
    PlayableDirector director,
    string trackName,
    string subTrackName,
    bool isMuted)
  {
  }

  [Token(Token = "0x6000B10")]
  [Address(RVA = "0x4BC1718", Offset = "0x4BC1718", VA = "0x4BC1718")]
  public static List<Tuple<double, Marker>> GetDamageAndShotMarkerTimes(
    TimelineAsset timelineAsset,
    bool includeContinuousEndMarker)
  {
    return (List<Tuple<double, Marker>>) null;
  }

  [Token(Token = "0x6000B11")]
  [Address(RVA = "0x4BC4668", Offset = "0x4BC4668", VA = "0x4BC4668")]
  public static List<Tuple<double, Marker>> GetPauseScreenMarkerTimes(TimelineAsset timelineAsset)
  {
    return (List<Tuple<double, Marker>>) null;
  }

  [Token(Token = "0x6000B12")]
  [Address(RVA = "0x4BC4BF4", Offset = "0x4BC4BF4", VA = "0x4BC4BF4")]
  public static Tuple<double, Marker> GetFastModeEntryPoint(TimelineAsset timelineAsset)
  {
    return (Tuple<double, Marker>) null;
  }

  [Token(Token = "0x6000B13")]
  [Address(RVA = "0x4BC5004", Offset = "0x4BC5004", VA = "0x4BC5004")]
  public static double? GetMarkerTime(TimelineAsset timelineAsset, string markerName)
  {
    return new double?();
  }

  [Token(Token = "0x6000B14")]
  [Address(RVA = "0x4BC53C8", Offset = "0x4BC53C8", VA = "0x4BC53C8")]
  public static void AddControlTrack(
    PlayableDirector mainDirector,
    PlayableDirector subDirector,
    double timeOffset,
    TrackAsset parentTrack,
    string trackName,
    double durationAdjustment = 0.0)
  {
  }

  [Token(Token = "0x6000B15")]
  [Address(RVA = "0x4BC55EC", Offset = "0x4BC55EC", VA = "0x4BC55EC")]
  public static PlayableDirector CreatePlayableDirector(int turnIndex, GameObject root)
  {
    return (PlayableDirector) null;
  }

  [Token(Token = "0x6000B16")]
  [Address(RVA = "0x4BC5820", Offset = "0x4BC5820", VA = "0x4BC5820")]
  public static PlayableDirector CreatePlayableDirector(
    DuelCharacterController.DuelCharacterRole role,
    GameObject root)
  {
    return (PlayableDirector) null;
  }

  [Token(Token = "0x6000B17")]
  [Address(RVA = "0x4BC5A68", Offset = "0x4BC5A68", VA = "0x4BC5A68")]
  public static Tuple<double, double> GetTimelineStartEndTimes(
    TimelineAsset timelineAsset,
    string trackName,
    bool ignoreBlendTime)
  {
    return (Tuple<double, double>) null;
  }

  [Token(Token = "0x6000B18")]
  [Address(RVA = "0x4BC61B8", Offset = "0x4BC61B8", VA = "0x4BC61B8")]
  public static Tuple<double, double> GetTimelineBlendDuration(
    TimelineAsset timelineAsset,
    string trackName)
  {
    return (Tuple<double, double>) null;
  }

  [Token(Token = "0x6000B19")]
  [Address(RVA = "0x4BC68E4", Offset = "0x4BC68E4", VA = "0x4BC68E4")]
  public static double GetMainTimelineStartTimeOffset(
    double firstMainMarkerTime,
    TimelineAsset firstPassiveTimelineAsset,
    string markerName)
  {
    return new double();
  }

  [Token(Token = "0x6000B1A")]
  [Address(RVA = "0x4BC6980", Offset = "0x4BC6980", VA = "0x4BC6980")]
  public static GroupTrack CreateGroupTrack(
    TimelineAsset timelineAsset,
    string trackName,
    TrackAsset parent = null)
  {
    return (GroupTrack) null;
  }

  [Token(Token = "0x6000B1B")]
  [Address(RVA = "0x4BC69E8", Offset = "0x4BC69E8", VA = "0x4BC69E8")]
  public static void CopyFlyingObjectMarkers(
    TimelineAsset resourceTimeline,
    TimelineAsset targetTimeline,
    string markerName,
    DuelManager.DuelHitStatus hitType,
    ElementEffectItem.ElementType elementType,
    double startTime)
  {
  }

  [Token(Token = "0x6000B1C")]
  [Address(RVA = "0x4BC6F74", Offset = "0x4BC6F74", VA = "0x4BC6F74")]
  public static void CopyVCControlMarkers(
    TimelineAsset resourceTimeline,
    TimelineAsset targetTimeline,
    string markerName,
    double startTime)
  {
  }

  [Token(Token = "0x6000B1D")]
  [Address(RVA = "0x4BC749C", Offset = "0x4BC749C", VA = "0x4BC749C")]
  public static bool HasShotMarker(TimelineAsset timelineAsset) => new bool();

  [Token(Token = "0x6000B1E")]
  [Address(RVA = "0x4BC7864", Offset = "0x4BC7864", VA = "0x4BC7864")]
  public static void AddCustomMotionAnimation(
    AnimationTrack targetTrack,
    Vector3 moveVector,
    double startTime,
    double duration,
    float startTangent = 0.0f,
    float endTangent = 0.0f)
  {
  }

  [Token(Token = "0x6000B1F")]
  [Address(RVA = "0x4BC7D60", Offset = "0x4BC7D60", VA = "0x4BC7D60")]
  public TimelineUtilities()
  {
  }
}
