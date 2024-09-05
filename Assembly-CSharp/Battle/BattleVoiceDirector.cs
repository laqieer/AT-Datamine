// Decompiled with JetBrains decompiler
// Type: Battle.BattleVoiceDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002266")]
  public class BattleVoiceDirector
  {
    [Token(Token = "0x40090C6")]
    [FieldOffset(Offset = "0x10")]
    private Battle.Data.Board.BoardData Board;
    [Token(Token = "0x40090C7")]
    [FieldOffset(Offset = "0x18")]
    private ISystemFlags SystemFlags;
    [Token(Token = "0x40090C8")]
    [FieldOffset(Offset = "0x20")]
    private List<uint> playingIdList;
    [Token(Token = "0x40090C9")]
    [FieldOffset(Offset = "0x28")]
    private List<VoicePlayData> playedList;
    [Token(Token = "0x40090CA")]
    [FieldOffset(Offset = "0x30")]
    private List<string> loadedVoicePackNameList;

    [Token(Token = "0x17002D68")]
    public List<string> LoadedVoicePackNameList
    {
      [Token(Token = "0x600D123"), Address(RVA = "0x1953274", Offset = "0x1953274", VA = "0x1953274")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x600D124")]
    [Address(RVA = "0x195327C", Offset = "0x195327C", VA = "0x195327C")]
    public BattleVoiceDirector(Battle.Data.Board.BoardData board, ISystemFlags system)
    {
    }

    [Token(Token = "0x600D125")]
    [Address(RVA = "0x19533A4", Offset = "0x19533A4", VA = "0x19533A4")]
    public void ApplyBoard(Battle.Data.Board.BoardData board)
    {
    }

    [Token(Token = "0x600D126")]
    [Address(RVA = "0x19533C4", Offset = "0x19533C4", VA = "0x19533C4")]
    public void PlayVoice(
      BattleVoiceTimingEnum timing,
      Battle.Data.Board.UnitParameterData unit,
      Battle.Data.Board.UnitParameterData target = null)
    {
    }

    [Token(Token = "0x600D127")]
    [Address(RVA = "0x19539E8", Offset = "0x19539E8", VA = "0x19539E8")]
    private bool IsCheckSystemFlag(BattleVoiceData voiceMaster) => new bool();

    [Token(Token = "0x600D128")]
    [Address(RVA = "0x1954008", Offset = "0x1954008", VA = "0x1954008")]
    private bool IsCheckVoiceType(BattleVoiceData master, VoicePlayData data) => new bool();

    [Token(Token = "0x600D129")]
    [Address(RVA = "0x1954344", Offset = "0x1954344", VA = "0x1954344")]
    private bool IsVoiceOverLapp(BattleVoiceData master) => new bool();

    [Token(Token = "0x600D12A")]
    [Address(RVA = "0x1953E38", Offset = "0x1953E38", VA = "0x1953E38")]
    private (BattleVoiceCombiData, BattleVoiceCombiData) IsCombiVoice(
      ref BattleVoiceTimingEnum timing,
      string voicePackId,
      ref BattleVoiceTimingEnum targetTiming,
      string targetVoicePackId)
    {
      return ();
    }

    [Token(Token = "0x600D12B")]
    [Address(RVA = "0x1954C90", Offset = "0x1954C90", VA = "0x1954C90")]
    private BattleVoiceTimingEnum GetCombiTiming(
      BattleVoiceCombiData combi,
      BattleVoiceTimingEnum timing,
      BattleVoiceTimingEnum combiTiming)
    {
      return new BattleVoiceTimingEnum();
    }

    [Token(Token = "0x600D12C")]
    [Address(RVA = "0x1953B28", Offset = "0x1953B28", VA = "0x1953B28")]
    private BattleVoiceCombiData IsDueledSpecific(
      string voicePackId,
      string targetVoicePackId,
      BattleVoiceTimingEnum timing)
    {
      return (BattleVoiceCombiData) null;
    }

    [Token(Token = "0x600D12D")]
    [Address(RVA = "0x1954874", Offset = "0x1954874", VA = "0x1954874")]
    private BattleVoiceCombiData GetCombiMaster(
      string voicePackId,
      BattleVoiceTimingEnum timing,
      string targetVoicePackId)
    {
      return (BattleVoiceCombiData) null;
    }

    [Token(Token = "0x600D12E")]
    [Address(RVA = "0x1953B90", Offset = "0x1953B90", VA = "0x1953B90")]
    private (string, BattleVoiceTimingEnum) GetDoubleCharacter(
      BattleVoiceTimingEnum timing,
      Battle.Data.Board.UnitParameterData unit,
      Battle.Data.Board.UnitParameterData target = null)
    {
      return ();
    }

    [Token(Token = "0x600D12F")]
    [Address(RVA = "0x1954640", Offset = "0x1954640", VA = "0x1954640")]
    public void LoadVoicePackName(string id)
    {
    }

    [Token(Token = "0x600D130")]
    [Address(RVA = "0x19547A8", Offset = "0x19547A8", VA = "0x19547A8")]
    private void AddPlayVoiceList(VoicePlayData data, BattleVoiceTypeEnum type)
    {
    }

    [Token(Token = "0x600D131")]
    [Address(RVA = "0x1954C9C", Offset = "0x1954C9C", VA = "0x1954C9C")]
    public static List<VoicePlayData> CreateFromSchema(staq.SaveSchema.BoardData schema)
    {
      return (List<VoicePlayData>) null;
    }

    [Token(Token = "0x2002267")]
    private class BattleVoiceConst
    {
      [Token(Token = "0x40090CB")]
      [FieldOffset(Offset = "0x0")]
      public static readonly string CATEGORY;
      [Token(Token = "0x40090CC")]
      [FieldOffset(Offset = "0x8")]
      public static readonly string COMBI_CATEGORY;
      [Token(Token = "0x40090CD")]
      [FieldOffset(Offset = "0x10")]
      public static readonly string SELECT_UNIT_VOICE_NO;
      [Token(Token = "0x40090CE")]
      [FieldOffset(Offset = "0x18")]
      public static readonly string SELECT_DOUBLE_UNIT_VOICE_NO;
      [Token(Token = "0x40090CF")]
      [FieldOffset(Offset = "0x20")]
      public static readonly string SELECT_DOUBLE_UNIT_BACK_VOICE_NO;
      [Token(Token = "0x40090D0")]
      [FieldOffset(Offset = "0x28")]
      public static readonly string QUEST_START_VOICE_NO;
      [Token(Token = "0x40090D1")]
      [FieldOffset(Offset = "0x30")]
      public static readonly string QUEST_WIN_VOICE_NO;
      [Token(Token = "0x40090D2")]
      [FieldOffset(Offset = "0x38")]
      public static readonly string QUEST_MVP_VOICE_NO;
      [Token(Token = "0x40090D3")]
      [FieldOffset(Offset = "0x40")]
      public static readonly string QUEST_LOSE_VOICE_NO;
      [Token(Token = "0x40090D4")]
      [FieldOffset(Offset = "0x48")]
      public static readonly string BUFF_VOICE_NO;
      [Token(Token = "0x40090D5")]
      [FieldOffset(Offset = "0x50")]
      public static readonly string DEBUFF_VOICE_NO;
      [Token(Token = "0x40090D6")]
      [FieldOffset(Offset = "0x58")]
      public static readonly string STRATAGEM_VOICE_NO;
      [Token(Token = "0x40090D7")]
      [FieldOffset(Offset = "0x60")]
      private static readonly string DUEL_VOICE_NO;
      [Token(Token = "0x40090D8")]
      [FieldOffset(Offset = "0x68")]
      private static readonly string DUEL_BACK_VOICE_NO;
      [Token(Token = "0x40090D9")]
      [FieldOffset(Offset = "0x70")]
      private static readonly string DUELED_VOICE_NO;
      [Token(Token = "0x40090DA")]
      [FieldOffset(Offset = "0x78")]
      private static readonly string DUELED_BACK_VOICE_NO;
      [Token(Token = "0x40090DB")]
      [FieldOffset(Offset = "0x80")]
      private static readonly string CRITICAL_VOICE_NO;
      [Token(Token = "0x40090DC")]
      [FieldOffset(Offset = "0x88")]
      private static readonly string CHASE_VOICE_NO;
      [Token(Token = "0x40090DD")]
      [FieldOffset(Offset = "0x90")]
      private static readonly string DEATH_VOICE_NO;
      [Token(Token = "0x40090DE")]
      [FieldOffset(Offset = "0x98")]
      private static readonly string BEAT_VOICE_NO;
      [Token(Token = "0x40090DF")]
      [FieldOffset(Offset = "0xA0")]
      private static readonly string SUPPORT_ATTACK_VOICE_NO;
      [Token(Token = "0x40090E0")]
      [FieldOffset(Offset = "0xA8")]
      private static readonly string SUPPORT_GUARD_VOICE_NO;
      [Token(Token = "0x40090E1")]
      [FieldOffset(Offset = "0xB0")]
      private static readonly string SUPPORT_HEAL_VOICE_NO;
      [Token(Token = "0x40090E2")]
      [FieldOffset(Offset = "0xB8")]
      private static readonly string DOUBLE_VOICE_NO;
      [Token(Token = "0x40090E3")]
      [FieldOffset(Offset = "0xC0")]
      private static readonly string DOUBLE_BACK_VOICE_NO;
      [Token(Token = "0x40090E4")]
      [FieldOffset(Offset = "0xC8")]
      private static readonly string DOUBLE_RELEASE_VOICE_NO;
      [Token(Token = "0x40090E5")]
      [FieldOffset(Offset = "0xD0")]
      private static readonly string DOUBLE_RELEASE_BACK_VOICE_NO;
      [Token(Token = "0x40090E6")]
      [FieldOffset(Offset = "0xD8")]
      private static readonly string DOUBLE_SWAP_VOICE_NO;
      [Token(Token = "0x40090E7")]
      [FieldOffset(Offset = "0xE0")]
      private static readonly string DOUBLE_SWAP_BACK_VOICE_NO;
      [Token(Token = "0x40090E8")]
      [FieldOffset(Offset = "0xE8")]
      private static readonly string THANK_VOICE_NO;
      [Token(Token = "0x40090E9")]
      [FieldOffset(Offset = "0xF0")]
      private static readonly string STAND_VOICE_NO;
      [Token(Token = "0x40090EA")]
      [FieldOffset(Offset = "0xF8")]
      private static readonly string MANUAL_TARRET_VOICE_NO;
      [Token(Token = "0x40090EB")]
      [FieldOffset(Offset = "0x100")]
      private static readonly string SWITCH_VOICE_NO;
      [Token(Token = "0x40090EC")]
      [FieldOffset(Offset = "0x108")]
      private static readonly string DOOR_VOICE_NO;
      [Token(Token = "0x40090ED")]
      [FieldOffset(Offset = "0x110")]
      private static readonly string CHEST_VOICE_NO;
      [Token(Token = "0x40090EE")]
      [FieldOffset(Offset = "0x118")]
      private static readonly string TRAP_VOICE_NO;
      [Token(Token = "0x40090EF")]
      [FieldOffset(Offset = "0x120")]
      private static readonly string SELECT_DOUBLE_COMBI_IDENTIFIER;
      [Token(Token = "0x40090F0")]
      [FieldOffset(Offset = "0x128")]
      private static readonly string SELECT_DOUBLE_BACK_COMBI_IDENTIFIER;
      [Token(Token = "0x40090F1")]
      [FieldOffset(Offset = "0x130")]
      private static readonly string DUEL_COMBI_IDENTIFIER;
      [Token(Token = "0x40090F2")]
      [FieldOffset(Offset = "0x138")]
      private static readonly string DUEL_COMBI_BACK_IDENTIFIER;
      [Token(Token = "0x40090F3")]
      [FieldOffset(Offset = "0x140")]
      private static readonly string DUELED_COMBI_IDENTIFIER;
      [Token(Token = "0x40090F4")]
      [FieldOffset(Offset = "0x148")]
      private static readonly string DUELED_COMBI_BACK_IDENTIFIER;
      [Token(Token = "0x40090F5")]
      [FieldOffset(Offset = "0x150")]
      private static readonly string DUEL_SPECIFIC;
      [Token(Token = "0x40090F6")]
      [FieldOffset(Offset = "0x158")]
      private static readonly string DUELED_SPECIFIC;
      [Token(Token = "0x40090F7")]
      [FieldOffset(Offset = "0x160")]
      private static readonly string DOUBLE_COMBI_IDENTIFIER;
      [Token(Token = "0x40090F8")]
      [FieldOffset(Offset = "0x168")]
      private static readonly string DOUBLE_COMBI_BACK_IDENTIFIER;
      [Token(Token = "0x40090F9")]
      [FieldOffset(Offset = "0x170")]
      private static readonly string DOUBLE_RELEASE_COMBI_IDENTIFIER;
      [Token(Token = "0x40090FA")]
      [FieldOffset(Offset = "0x178")]
      private static readonly string DOUBLE_RELEASE_COMBI_BACK_IDENTIFIER;
      [Token(Token = "0x40090FB")]
      [FieldOffset(Offset = "0x180")]
      private static readonly string DOUBLE_SWAP_COMBI_IDENTIFIER;
      [Token(Token = "0x40090FC")]
      [FieldOffset(Offset = "0x188")]
      private static readonly string DOUBLE_SWAP_COMBI_BACK_IDENTIFIER;
      [Token(Token = "0x40090FD")]
      [FieldOffset(Offset = "0x190")]
      private static readonly string CHANGE_ATTACK_ORDER_IDENTIFIER;
      [Token(Token = "0x40090FE")]
      [FieldOffset(Offset = "0x198")]
      private static readonly string DEATH_COMBI_IDENTIFIER;

      [Token(Token = "0x600D132")]
      [Address(RVA = "0x19543C8", Offset = "0x19543C8", VA = "0x19543C8")]
      public static string GetVoiceName(
        BattleVoiceTimingEnum timing,
        string voicePackId,
        BattleVoiceCombiData combiMaster)
      {
        return (string) null;
      }

      [Token(Token = "0x600D133")]
      [Address(RVA = "0x1955170", Offset = "0x1955170", VA = "0x1955170")]
      public static string GetVoiceName(
        BattleVoiceTimingEnum timing,
        string voicePackId,
        string identifier,
        string voiceNo)
      {
        return (string) null;
      }

      [Token(Token = "0x600D134")]
      [Address(RVA = "0x19553FC", Offset = "0x19553FC", VA = "0x19553FC")]
      private static string GetVoiceNo(BattleVoiceTimingEnum timing) => (string) null;

      [Token(Token = "0x600D135")]
      [Address(RVA = "0x1954ED4", Offset = "0x1954ED4", VA = "0x1954ED4")]
      private static string GetIdentifier(BattleVoiceTimingEnum timing) => (string) null;

      [Token(Token = "0x600D136")]
      [Address(RVA = "0x19557FC", Offset = "0x19557FC", VA = "0x19557FC")]
      public BattleVoiceConst()
      {
      }

      [Token(Token = "0x600D137")]
      [Address(RVA = "0x1955804", Offset = "0x1955804", VA = "0x1955804")]
      static BattleVoiceConst()
      {
      }
    }
  }
}
