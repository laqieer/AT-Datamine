// Decompiled with JetBrains decompiler
// Type: Player.PlayerRankupStageMainPartAttach
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

#nullable disable
namespace Player
{
  [Token(Token = "0x20009DA")]
  public class PlayerRankupStageMainPartAttach : MonoBehaviour
  {
    [Token(Token = "0x4002D93")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public List<TimelineAsset> TimelineAssetSerialization;
    [Token(Token = "0x4002D94")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public TimelineAsset InTimelineAsset;
    [Token(Token = "0x4002D95")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public TimelineAsset OutTimelineAsset;
    [Token(Token = "0x4002D96")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public PlayableDirector MainDirector;
    [Token(Token = "0x4002D97")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public Image ImgCharaFullObj;
    [Token(Token = "0x4002D98")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public TextMeshProUGUI PrePlayerRankLvTxt;
    [Token(Token = "0x4002D99")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public TextMeshProUGUI PostPlayerRankTxt;
    [Token(Token = "0x4002D9A")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public TextMeshProUGUI LoopPostPlayerRankTxt;
    [Token(Token = "0x4002D9B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public PlayableDirector LoopDirector;
    [Token(Token = "0x4002D9C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public GameObject RankupListFriendObj;
    [Token(Token = "0x4002D9D")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public PlayableDirector RankupListFriendDirector;
    [Token(Token = "0x4002D9E")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public TextMeshProUGUI RankupListFriendValueBeforeTxt;
    [Token(Token = "0x4002D9F")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    public TextMeshProUGUI RankupListFriendValueAfterTxt;
    [Token(Token = "0x4002DA0")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    public GameObject RankupListStyleObj;
    [Token(Token = "0x4002DA1")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    public PlayableDirector RankupListStyleDirector;
    [Token(Token = "0x4002DA2")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    public TextMeshProUGUI RankupListStyleValueBeforeTxt;
    [Token(Token = "0x4002DA3")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    public TextMeshProUGUI RankupListStyleValueAfterTxt;
    [Token(Token = "0x4002DA4")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    public GameObject RankupListExpeditionPartyObj;
    [Token(Token = "0x4002DA5")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    public PlayableDirector RankupListExpeditionPartyDirector;
    [Token(Token = "0x4002DA6")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    public TextMeshProUGUI RankupListExpeditionPartyValueBeforeTxt;
    [Token(Token = "0x4002DA7")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    public TextMeshProUGUI RankupListExpeditionPartyValueAfterTxt;
    [Token(Token = "0x4002DA8")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    public GameObject RankupListReleaseBossLvObj;
    [Token(Token = "0x4002DA9")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    public PlayableDirector RankupListReleaseBossLvDirector;
    [Token(Token = "0x4002DAA")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    public GameObject RankupListReleaseGuildObj;
    [Token(Token = "0x4002DAB")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    public PlayableDirector RankupListReleaseGuildDirector;
    [Token(Token = "0x4002DAC")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    public GameObject RankupListReleaseEventQuestObj;
    [Token(Token = "0x4002DAD")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    public PlayableDirector RankupListReleaseEventQuestDirector;
    [Token(Token = "0x4002DAE")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    public GameObject RankupListReleaseArenaObj;
    [Token(Token = "0x4002DAF")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    public PlayableDirector RankupListReleaseArenaDirector;
    [Token(Token = "0x4002DB0")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    public PlayableDirector TapNextDirector;
    [Token(Token = "0x4002DB1")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    public Button TapNextButton;
    [Token(Token = "0x4002DB2")]
    [FieldOffset(Offset = "0x110")]
    public readonly string TrackName_LoopTrack;
    [Token(Token = "0x4002DB3")]
    [FieldOffset(Offset = "0x118")]
    public readonly string TrackName_LoopTrack_LvChangeTrack;
    [Token(Token = "0x4002DB4")]
    [FieldOffset(Offset = "0x120")]
    public readonly string TrackGroupName_List;
    [Token(Token = "0x4002DB5")]
    [FieldOffset(Offset = "0x128")]
    public readonly string TrackName_closebutton;
    [Token(Token = "0x4002DB6")]
    [FieldOffset(Offset = "0x130")]
    public readonly string TrackGroupName_Pos;
    [Token(Token = "0x4002DB7")]
    private const string TrackGroupName_Pos_1 = "LvPos_List_1";
    [Token(Token = "0x4002DB8")]
    private const string TrackGroupName_Pos_2 = "LvPos_List_2";
    [Token(Token = "0x4002DB9")]
    private const string TrackGroupName_Pos_3 = "LvPos_List_3";
    [Token(Token = "0x4002DBA")]
    private const string TrackGroupName_Pos_4 = "LvPos_List_4";
    [Token(Token = "0x4002DBB")]
    private const string TrackGroupName_Pos_5 = "LvPos_List_5";
    [Token(Token = "0x4002DBC")]
    private const string TrackGroupName_Pos_6 = "LvPos_List_6";
    [Token(Token = "0x4002DBD")]
    private const string TrackGroupName_Pos_7 = "LvPos_List_7";
    [Token(Token = "0x4002DBE")]
    [FieldOffset(Offset = "0x138")]
    public readonly string[] TrackGroupNames_PosChild;
    [Token(Token = "0x4002DBF")]
    [FieldOffset(Offset = "0x140")]
    public readonly int RankupStageMaxNum;
    [Token(Token = "0x4002DC0")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private List<PlayerRankupStageMainPartAttach.LoopRankupSpeed> LoopRankupStageSpeedForEachTotalRankupCount;
    [Token(Token = "0x4002DC1")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    public double ListStartTimingOffsetFromRankEnded;
    [Token(Token = "0x4002DC2")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    public List<PlayerRankupStageMainPartAttach.ListStageParm> ListStageParmForEachTotalListNum;

    [Token(Token = "0x6003827")]
    [Address(RVA = "0x3107EC4", Offset = "0x3107EC4", VA = "0x3107EC4")]
    public string GetRankPosTrackGroupName(int listCount) => (string) null;

    [Token(Token = "0x6003828")]
    [Address(RVA = "0x3106A30", Offset = "0x3106A30", VA = "0x3106A30")]
    public double GetLoopRankupStageSpeed(int totalRankupNum, int rankStageIndex) => new double();

    [Token(Token = "0x6003829")]
    [Address(RVA = "0x31063A8", Offset = "0x31063A8", VA = "0x31063A8")]
    public double GetListElementStageStartOffset(int totalListNum, int listElementIndex)
    {
      return new double();
    }

    [Token(Token = "0x600382A")]
    [Address(RVA = "0x3107F48", Offset = "0x3107F48", VA = "0x3107F48")]
    public PlayerRankupStageMainPartAttach()
    {
    }

    [Token(Token = "0x20009DB")]
    [Serializable]
    private class LoopRankupSpeed
    {
      [Token(Token = "0x4002DC3")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      public List<double> RankupSpeed;

      [Token(Token = "0x600382B")]
      [Address(RVA = "0x310A024", Offset = "0x310A024", VA = "0x310A024")]
      public LoopRankupSpeed(List<double> rankupSpeed)
      {
      }
    }

    [Token(Token = "0x20009DC")]
    [Serializable]
    public class ListStageParm
    {
      [Token(Token = "0x4002DC4")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      public List<PlayerRankupStageMainPartAttach.ListElementStageParm> ElementParams;

      [Token(Token = "0x600382C")]
      [Address(RVA = "0x310A074", Offset = "0x310A074", VA = "0x310A074")]
      public ListStageParm(
        List<PlayerRankupStageMainPartAttach.ListElementStageParm> elementParams)
      {
      }
    }

    [Token(Token = "0x20009DD")]
    [Serializable]
    public class ListElementStageParm
    {
      [Token(Token = "0x4002DC5")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      public double StartTimigOffset;

      [Token(Token = "0x600382D")]
      [Address(RVA = "0x310A04C", Offset = "0x310A04C", VA = "0x310A04C")]
      public ListElementStageParm(double StartTimigOffset)
      {
      }
    }
  }
}
