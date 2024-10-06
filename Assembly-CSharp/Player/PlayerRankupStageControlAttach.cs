// Decompiled with JetBrains decompiler
// Type: Player.PlayerRankupStageControlAttach
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace Player
{
  [Token(Token = "0x20009CF")]
  public class PlayerRankupStageControlAttach : MonoBehaviour
  {
    [Token(Token = "0x4002D54")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerRankupStageMainPartAttach Mainparts;
    [Token(Token = "0x4002D55")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x4002D56")]
    [FieldOffset(Offset = "0x28")]
    private int preRank;
    [Token(Token = "0x4002D57")]
    [FieldOffset(Offset = "0x2C")]
    private int postRank;
    [Token(Token = "0x4002D58")]
    [FieldOffset(Offset = "0x30")]
    private bool isFrindup;
    [Token(Token = "0x4002D59")]
    [FieldOffset(Offset = "0x34")]
    private int preFrindnum;
    [Token(Token = "0x4002D5A")]
    [FieldOffset(Offset = "0x38")]
    private int postFrindnum;
    [Token(Token = "0x4002D5B")]
    [FieldOffset(Offset = "0x3C")]
    private bool isStyleup;
    [Token(Token = "0x4002D5C")]
    [FieldOffset(Offset = "0x40")]
    private int preStyle;
    [Token(Token = "0x4002D5D")]
    [FieldOffset(Offset = "0x44")]
    private int postStyle;
    [Token(Token = "0x4002D5E")]
    [FieldOffset(Offset = "0x48")]
    private bool isPartyup;
    [Token(Token = "0x4002D5F")]
    [FieldOffset(Offset = "0x4C")]
    private int prePartynum;
    [Token(Token = "0x4002D60")]
    [FieldOffset(Offset = "0x50")]
    private int postPartynum;
    [Token(Token = "0x4002D61")]
    [FieldOffset(Offset = "0x54")]
    private bool isBossup;
    [Token(Token = "0x4002D62")]
    [FieldOffset(Offset = "0x55")]
    private bool isGuild;
    [Token(Token = "0x4002D63")]
    [FieldOffset(Offset = "0x56")]
    private bool isEventquest;
    [Token(Token = "0x4002D64")]
    [FieldOffset(Offset = "0x57")]
    private bool isEventarea;
    [Token(Token = "0x4002D65")]
    [FieldOffset(Offset = "0x58")]
    private Action outEndCallback;

    [Token(Token = "0x60037E7")]
    [Address(RVA = "0x3104DAC", Offset = "0x3104DAC", VA = "0x3104DAC")]
    public void StartStage()
    {
    }

    [Token(Token = "0x60037E8")]
    [Address(RVA = "0x310494C", Offset = "0x310494C", VA = "0x310494C")]
    public void SetPram(
      int prerank,
      int postrank,
      bool isfrindup,
      int prefrindnum,
      int postfrindnum,
      bool isstyleup,
      int prestyle,
      int poststyle,
      bool ispartyup,
      int prepartynum,
      int postpartynum,
      bool isbossup,
      bool isguild,
      bool iseventquest,
      bool iseventarea)
    {
    }

    [Token(Token = "0x60037E9")]
    [Address(RVA = "0x3104CB8", Offset = "0x3104CB8", VA = "0x3104CB8")]
    public void AddEndedCallback(Action callback)
    {
    }

    [Token(Token = "0x60037EA")]
    [Address(RVA = "0x3104C38", Offset = "0x3104C38", VA = "0x3104C38")]
    public void RemoveEndedCallback(Action callback)
    {
    }

    [Token(Token = "0x60037EB")]
    [Address(RVA = "0x3104E78", Offset = "0x3104E78", VA = "0x3104E78")]
    private IEnumerator StageSequence() => (IEnumerator) null;

    [Token(Token = "0x60037EC")]
    [Address(RVA = "0x3104F08", Offset = "0x3104F08", VA = "0x3104F08")]
    private IEnumerator ListStageSequence(
      List<PlayableDirector> listStageElements,
      double rankupEndtime)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60037ED")]
    [Address(RVA = "0x3104FB8", Offset = "0x3104FB8", VA = "0x3104FB8")]
    private IEnumerator ListElementStage(PlayableDirector player, double startTimeInTime)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60037EE")]
    [Address(RVA = "0x3105058", Offset = "0x3105058", VA = "0x3105058")]
    private IEnumerator RankupLoopStageSequence(int prerank, int postrank) => (IEnumerator) null;

    [Token(Token = "0x60037EF")]
    [Address(RVA = "0x31050FC", Offset = "0x31050FC", VA = "0x31050FC")]
    private IEnumerator RankupOneLoopStageSequence(
      int prerank,
      int postrank,
      double stagespeed,
      double changeRanktime)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60037F0")]
    [Address(RVA = "0x31051B0", Offset = "0x31051B0", VA = "0x31051B0")]
    private static TrackAsset GetTrack(string trackname, TimelineAsset asset) => (TrackAsset) null;

    [Token(Token = "0x60037F1")]
    [Address(RVA = "0x31054EC", Offset = "0x31054EC", VA = "0x31054EC")]
    private static (double, double) GetTrackStartAndEndTime(TrackAsset track) => ();

    [Token(Token = "0x60037F2")]
    [Address(RVA = "0x310588C", Offset = "0x310588C", VA = "0x310588C")]
    private static void SetRootTrackGroupMuted(TimelineAsset asset, string trackName, bool isMuted)
    {
    }

    [Token(Token = "0x60037F3")]
    [Address(RVA = "0x31059DC", Offset = "0x31059DC", VA = "0x31059DC")]
    private static void SetRootChildTrackGroupMuted(
      TimelineAsset asset,
      string roottrackName,
      string trackName,
      bool isMuted)
    {
    }

    [Token(Token = "0x60037F4")]
    [Address(RVA = "0x3105BB8", Offset = "0x3105BB8", VA = "0x3105BB8")]
    private static void SetOutTrackMuted(TimelineAsset asset, string trackName, bool isMuted)
    {
    }

    [Token(Token = "0x60037F5")]
    [Address(RVA = "0x3104D38", Offset = "0x3104D38", VA = "0x3104D38")]
    public void SetAlpha(float alpha)
    {
    }

    [Token(Token = "0x60037F6")]
    [Address(RVA = "0x3105D08", Offset = "0x3105D08", VA = "0x3105D08")]
    public PlayerRankupStageControlAttach()
    {
    }

    [Token(Token = "0x20009D0")]
    private struct OneLoopStageData
    {
      [Token(Token = "0x170007E3")]
      public int PreRank
      {
        [Token(Token = "0x60037F7"), Address(RVA = "0x3105D10", Offset = "0x3105D10", VA = "0x3105D10")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x60037F8"), Address(RVA = "0x3105D18", Offset = "0x3105D18", VA = "0x3105D18")] set
        {
        }
      }

      [Token(Token = "0x170007E4")]
      public int PostRank
      {
        [Token(Token = "0x60037F9"), Address(RVA = "0x3105D20", Offset = "0x3105D20", VA = "0x3105D20")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x60037FA"), Address(RVA = "0x3105D28", Offset = "0x3105D28", VA = "0x3105D28")] set
        {
        }
      }

      [Token(Token = "0x170007E5")]
      public double StageSpeed
      {
        [Token(Token = "0x60037FB"), Address(RVA = "0x3105D30", Offset = "0x3105D30", VA = "0x3105D30")] readonly get
        {
          return new double();
        }
        [Token(Token = "0x60037FC"), Address(RVA = "0x3105D38", Offset = "0x3105D38", VA = "0x3105D38")] set
        {
        }
      }
    }
  }
}
