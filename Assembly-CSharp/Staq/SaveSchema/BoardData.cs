// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.BoardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C83")]
  public struct BoardData : IFlatbufferObject
  {
    [Token(Token = "0x4010BE2")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E30")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017F60"), Address(RVA = "0x3B17890", Offset = "0x3B17890", VA = "0x3B17890", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017F61")]
    [Address(RVA = "0x3B17898", Offset = "0x3B17898", VA = "0x3B17898")]
    public static BoardData GetRootAsBoardData(ByteBuffer _bb) => new BoardData();

    [Token(Token = "0x6017F62")]
    [Address(RVA = "0x3B178A4", Offset = "0x3B178A4", VA = "0x3B178A4")]
    public static BoardData GetRootAsBoardData(ByteBuffer _bb, BoardData obj) => new BoardData();

    [Token(Token = "0x6017F63")]
    [Address(RVA = "0x3B17900", Offset = "0x3B17900", VA = "0x3B17900")]
    public static bool BoardDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6017F64")]
    [Address(RVA = "0x3B1794C", Offset = "0x3B1794C", VA = "0x3B1794C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017F65")]
    [Address(RVA = "0x3B178E8", Offset = "0x3B178E8", VA = "0x3B178E8")]
    public BoardData __assign(int _i, ByteBuffer _bb) => new BoardData();

    [Token(Token = "0x6017F66")]
    [Address(RVA = "0x3B17958", Offset = "0x3B17958", VA = "0x3B17958")]
    public byte SceneParam(int j) => new byte();

    [Token(Token = "0x17004E31")]
    public int SceneParamLength
    {
      [Token(Token = "0x6017F67"), Address(RVA = "0x3B179B8", Offset = "0x3B179B8", VA = "0x3B179B8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017F68")]
    [Address(RVA = "0x3B179EC", Offset = "0x3B179EC", VA = "0x3B179EC")]
    public ArraySegment<byte>? GetSceneParamBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017F69")]
    [Address(RVA = "0x3B17A24", Offset = "0x3B17A24", VA = "0x3B17A24")]
    public byte[] GetSceneParamArray() => (byte[]) null;

    [Token(Token = "0x6017F6A")]
    [Address(RVA = "0x3B17A70", Offset = "0x3B17A70", VA = "0x3B17A70")]
    public byte Battle(int j) => new byte();

    [Token(Token = "0x17004E32")]
    public int BattleLength
    {
      [Token(Token = "0x6017F6B"), Address(RVA = "0x3B17AD0", Offset = "0x3B17AD0", VA = "0x3B17AD0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017F6C")]
    [Address(RVA = "0x3B17B04", Offset = "0x3B17B04", VA = "0x3B17B04")]
    public ArraySegment<byte>? GetBattleBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017F6D")]
    [Address(RVA = "0x3B17B3C", Offset = "0x3B17B3C", VA = "0x3B17B3C")]
    public byte[] GetBattleArray() => (byte[]) null;

    [Token(Token = "0x17004E33")]
    public string Description
    {
      [Token(Token = "0x6017F6E"), Address(RVA = "0x3B17B88", Offset = "0x3B17B88", VA = "0x3B17B88")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017F6F")]
    [Address(RVA = "0x3B17BC4", Offset = "0x3B17BC4", VA = "0x3B17BC4")]
    public ArraySegment<byte>? GetDescriptionBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017F70")]
    [Address(RVA = "0x3B17BFC", Offset = "0x3B17BFC", VA = "0x3B17BFC")]
    public byte[] GetDescriptionArray() => (byte[]) null;

    [Token(Token = "0x17004E34")]
    public int Turn
    {
      [Token(Token = "0x6017F71"), Address(RVA = "0x3B17C48", Offset = "0x3B17C48", VA = "0x3B17C48")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E35")]
    public int ActivePlayerIndex
    {
      [Token(Token = "0x6017F72"), Address(RVA = "0x3B17C8C", Offset = "0x3B17C8C", VA = "0x3B17C8C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E36")]
    public uint RandomGenerateCount
    {
      [Token(Token = "0x6017F73"), Address(RVA = "0x3B17CD0", Offset = "0x3B17CD0", VA = "0x3B17CD0")] get
      {
        return new uint();
      }
    }

    [Token(Token = "0x6017F74")]
    [Address(RVA = "0x3B17D14", Offset = "0x3B17D14", VA = "0x3B17D14")]
    public SkillParameterData? SkillParams(int j) => new SkillParameterData?();

    [Token(Token = "0x17004E37")]
    public int SkillParamsLength
    {
      [Token(Token = "0x6017F75"), Address(RVA = "0x3B17DE0", Offset = "0x3B17DE0", VA = "0x3B17DE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017F76")]
    [Address(RVA = "0x3B17E14", Offset = "0x3B17E14", VA = "0x3B17E14")]
    public FacilityData? Facility(int j) => new FacilityData?();

    [Token(Token = "0x17004E38")]
    public int FacilityLength
    {
      [Token(Token = "0x6017F77"), Address(RVA = "0x3B17EE0", Offset = "0x3B17EE0", VA = "0x3B17EE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017F78")]
    [Address(RVA = "0x3B17F14", Offset = "0x3B17F14", VA = "0x3B17F14")]
    public UnitParameterData? UnitParams(int j) => new UnitParameterData?();

    [Token(Token = "0x17004E39")]
    public int UnitParamsLength
    {
      [Token(Token = "0x6017F79"), Address(RVA = "0x3B17FE0", Offset = "0x3B17FE0", VA = "0x3B17FE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017F7A")]
    [Address(RVA = "0x3B18014", Offset = "0x3B18014", VA = "0x3B18014")]
    public BattlePlayerData? Players(int j) => new BattlePlayerData?();

    [Token(Token = "0x17004E3A")]
    public int PlayersLength
    {
      [Token(Token = "0x6017F7B"), Address(RVA = "0x3B180E0", Offset = "0x3B180E0", VA = "0x3B180E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E3B")]
    public staq.SaveSchema.BattleMissionProgress? BattleMissionProgress
    {
      [Token(Token = "0x6017F7C"), Address(RVA = "0x3B18114", Offset = "0x3B18114", VA = "0x3B18114")] get
      {
        return new staq.SaveSchema.BattleMissionProgress?();
      }
    }

    [Token(Token = "0x17004E3C")]
    public staq.SaveSchema.BattleAdvProgress? BattleAdvProgress
    {
      [Token(Token = "0x6017F7D"), Address(RVA = "0x3B181D4", Offset = "0x3B181D4", VA = "0x3B181D4")] get
      {
        return new staq.SaveSchema.BattleAdvProgress?();
      }
    }

    [Token(Token = "0x6017F7E")]
    [Address(RVA = "0x3B18294", Offset = "0x3B18294", VA = "0x3B18294")]
    public BattlePlayedVoice? BattlePlayedVoiceList(int j) => new BattlePlayedVoice?();

    [Token(Token = "0x17004E3D")]
    public int BattlePlayedVoiceListLength
    {
      [Token(Token = "0x6017F7F"), Address(RVA = "0x3B1836C", Offset = "0x3B1836C", VA = "0x3B1836C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017F80")]
    [Address(RVA = "0x3B183A0", Offset = "0x3B183A0", VA = "0x3B183A0")]
    public staq.SaveSchema.UnitLevelReached? UnitLevelReached(int j) => new staq.SaveSchema.UnitLevelReached?();

    [Token(Token = "0x17004E3E")]
    public int UnitLevelReachedLength
    {
      [Token(Token = "0x6017F81"), Address(RVA = "0x3B1846C", Offset = "0x3B1846C", VA = "0x3B1846C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017F82")]
    [Address(RVA = "0x3B184A0", Offset = "0x3B184A0", VA = "0x3B184A0")]
    public CommandLog? ReservedCommand(int j) => new CommandLog?();

    [Token(Token = "0x17004E3F")]
    public int ReservedCommandLength
    {
      [Token(Token = "0x6017F83"), Address(RVA = "0x3B1856C", Offset = "0x3B1856C", VA = "0x3B1856C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E40")]
    public CommandLog? ResumeCommand
    {
      [Token(Token = "0x6017F84"), Address(RVA = "0x3B185A0", Offset = "0x3B185A0", VA = "0x3B185A0")] get
      {
        return new CommandLog?();
      }
    }

    [Token(Token = "0x17004E41")]
    public int ResumePhase
    {
      [Token(Token = "0x6017F85"), Address(RVA = "0x3B18638", Offset = "0x3B18638", VA = "0x3B18638")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017F86")]
    [Address(RVA = "0x3B1867C", Offset = "0x3B1867C", VA = "0x3B1867C")]
    public byte SecurityLog(int j) => new byte();

    [Token(Token = "0x17004E42")]
    public int SecurityLogLength
    {
      [Token(Token = "0x6017F87"), Address(RVA = "0x3B186DC", Offset = "0x3B186DC", VA = "0x3B186DC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017F88")]
    [Address(RVA = "0x3B18710", Offset = "0x3B18710", VA = "0x3B18710")]
    public ArraySegment<byte>? GetSecurityLogBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017F89")]
    [Address(RVA = "0x3B18748", Offset = "0x3B18748", VA = "0x3B18748")]
    public byte[] GetSecurityLogArray() => (byte[]) null;

    [Token(Token = "0x6017F8A")]
    [Address(RVA = "0x3B18794", Offset = "0x3B18794", VA = "0x3B18794")]
    public static Offset<BoardData> CreateBoardData(
      FlatBufferBuilder builder,
      VectorOffset sceneParamOffset = default (VectorOffset),
      VectorOffset battleOffset = default (VectorOffset),
      StringOffset descriptionOffset = default (StringOffset),
      int turn = 0,
      int activePlayerIndex = 0,
      uint randomGenerateCount = 0,
      VectorOffset skillParamsOffset = default (VectorOffset),
      VectorOffset facilityOffset = default (VectorOffset),
      VectorOffset unitParamsOffset = default (VectorOffset),
      VectorOffset playersOffset = default (VectorOffset),
      Offset<staq.SaveSchema.BattleMissionProgress> battleMissionProgressOffset = default (Offset<staq.SaveSchema.BattleMissionProgress>),
      Offset<staq.SaveSchema.BattleAdvProgress> battleAdvProgressOffset = default (Offset<staq.SaveSchema.BattleAdvProgress>),
      VectorOffset battlePlayedVoiceListOffset = default (VectorOffset),
      VectorOffset unitLevelReachedOffset = default (VectorOffset),
      VectorOffset reservedCommandOffset = default (VectorOffset),
      Offset<CommandLog> resumeCommandOffset = default (Offset<CommandLog>),
      int resumePhase = 0,
      VectorOffset securityLogOffset = default (VectorOffset))
    {
      return new Offset<BoardData>();
    }

    [Token(Token = "0x6017F8B")]
    [Address(RVA = "0x3B18BA4", Offset = "0x3B18BA4", VA = "0x3B18BA4")]
    public static void StartBoardData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017F8C")]
    [Address(RVA = "0x3B18B34", Offset = "0x3B18B34", VA = "0x3B18B34")]
    public static void AddSceneParam(FlatBufferBuilder builder, VectorOffset sceneParamOffset)
    {
    }

    [Token(Token = "0x6017F8D")]
    [Address(RVA = "0x3B18BBC", Offset = "0x3B18BBC", VA = "0x3B18BBC")]
    public static VectorOffset CreateSceneParamVector(FlatBufferBuilder builder, byte[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F8E")]
    [Address(RVA = "0x3B18C64", Offset = "0x3B18C64", VA = "0x3B18C64")]
    public static VectorOffset CreateSceneParamVectorBlock(FlatBufferBuilder builder, byte[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F8F")]
    [Address(RVA = "0x3B18CEC", Offset = "0x3B18CEC", VA = "0x3B18CEC")]
    public static void StartSceneParamVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017F90")]
    [Address(RVA = "0x3B18B14", Offset = "0x3B18B14", VA = "0x3B18B14")]
    public static void AddBattle(FlatBufferBuilder builder, VectorOffset battleOffset)
    {
    }

    [Token(Token = "0x6017F91")]
    [Address(RVA = "0x3B18D0C", Offset = "0x3B18D0C", VA = "0x3B18D0C")]
    public static VectorOffset CreateBattleVector(FlatBufferBuilder builder, byte[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F92")]
    [Address(RVA = "0x3B18DB4", Offset = "0x3B18DB4", VA = "0x3B18DB4")]
    public static VectorOffset CreateBattleVectorBlock(FlatBufferBuilder builder, byte[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F93")]
    [Address(RVA = "0x3B18E3C", Offset = "0x3B18E3C", VA = "0x3B18E3C")]
    public static void StartBattleVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017F94")]
    [Address(RVA = "0x3B18AF4", Offset = "0x3B18AF4", VA = "0x3B18AF4")]
    public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset)
    {
    }

    [Token(Token = "0x6017F95")]
    [Address(RVA = "0x3B18AD4", Offset = "0x3B18AD4", VA = "0x3B18AD4")]
    public static void AddTurn(FlatBufferBuilder builder, int turn)
    {
    }

    [Token(Token = "0x6017F96")]
    [Address(RVA = "0x3B18AB4", Offset = "0x3B18AB4", VA = "0x3B18AB4")]
    public static void AddActivePlayerIndex(FlatBufferBuilder builder, int activePlayerIndex)
    {
    }

    [Token(Token = "0x6017F97")]
    [Address(RVA = "0x3B18A94", Offset = "0x3B18A94", VA = "0x3B18A94")]
    public static void AddRandomGenerateCount(FlatBufferBuilder builder, uint randomGenerateCount)
    {
    }

    [Token(Token = "0x6017F98")]
    [Address(RVA = "0x3B18A74", Offset = "0x3B18A74", VA = "0x3B18A74")]
    public static void AddSkillParams(FlatBufferBuilder builder, VectorOffset skillParamsOffset)
    {
    }

    [Token(Token = "0x6017F99")]
    [Address(RVA = "0x3B18E5C", Offset = "0x3B18E5C", VA = "0x3B18E5C")]
    public static VectorOffset CreateSkillParamsVector(
      FlatBufferBuilder builder,
      Offset<SkillParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F9A")]
    [Address(RVA = "0x3B18F04", Offset = "0x3B18F04", VA = "0x3B18F04")]
    public static VectorOffset CreateSkillParamsVectorBlock(
      FlatBufferBuilder builder,
      Offset<SkillParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F9B")]
    [Address(RVA = "0x3B18F8C", Offset = "0x3B18F8C", VA = "0x3B18F8C")]
    public static void StartSkillParamsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017F9C")]
    [Address(RVA = "0x3B18A54", Offset = "0x3B18A54", VA = "0x3B18A54")]
    public static void AddFacility(FlatBufferBuilder builder, VectorOffset facilityOffset)
    {
    }

    [Token(Token = "0x6017F9D")]
    [Address(RVA = "0x3B18FAC", Offset = "0x3B18FAC", VA = "0x3B18FAC")]
    public static VectorOffset CreateFacilityVector(
      FlatBufferBuilder builder,
      Offset<FacilityData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F9E")]
    [Address(RVA = "0x3B19054", Offset = "0x3B19054", VA = "0x3B19054")]
    public static VectorOffset CreateFacilityVectorBlock(
      FlatBufferBuilder builder,
      Offset<FacilityData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F9F")]
    [Address(RVA = "0x3B190DC", Offset = "0x3B190DC", VA = "0x3B190DC")]
    public static void StartFacilityVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017FA0")]
    [Address(RVA = "0x3B18A34", Offset = "0x3B18A34", VA = "0x3B18A34")]
    public static void AddUnitParams(FlatBufferBuilder builder, VectorOffset unitParamsOffset)
    {
    }

    [Token(Token = "0x6017FA1")]
    [Address(RVA = "0x3B190FC", Offset = "0x3B190FC", VA = "0x3B190FC")]
    public static VectorOffset CreateUnitParamsVector(
      FlatBufferBuilder builder,
      Offset<UnitParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017FA2")]
    [Address(RVA = "0x3B191A4", Offset = "0x3B191A4", VA = "0x3B191A4")]
    public static VectorOffset CreateUnitParamsVectorBlock(
      FlatBufferBuilder builder,
      Offset<UnitParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017FA3")]
    [Address(RVA = "0x3B1922C", Offset = "0x3B1922C", VA = "0x3B1922C")]
    public static void StartUnitParamsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017FA4")]
    [Address(RVA = "0x3B18A14", Offset = "0x3B18A14", VA = "0x3B18A14")]
    public static void AddPlayers(FlatBufferBuilder builder, VectorOffset playersOffset)
    {
    }

    [Token(Token = "0x6017FA5")]
    [Address(RVA = "0x3B1924C", Offset = "0x3B1924C", VA = "0x3B1924C")]
    public static VectorOffset CreatePlayersVector(
      FlatBufferBuilder builder,
      Offset<BattlePlayerData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017FA6")]
    [Address(RVA = "0x3B192F4", Offset = "0x3B192F4", VA = "0x3B192F4")]
    public static VectorOffset CreatePlayersVectorBlock(
      FlatBufferBuilder builder,
      Offset<BattlePlayerData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017FA7")]
    [Address(RVA = "0x3B1937C", Offset = "0x3B1937C", VA = "0x3B1937C")]
    public static void StartPlayersVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017FA8")]
    [Address(RVA = "0x3B189F4", Offset = "0x3B189F4", VA = "0x3B189F4")]
    public static void AddBattleMissionProgress(
      FlatBufferBuilder builder,
      Offset<staq.SaveSchema.BattleMissionProgress> battleMissionProgressOffset)
    {
    }

    [Token(Token = "0x6017FA9")]
    [Address(RVA = "0x3B189D4", Offset = "0x3B189D4", VA = "0x3B189D4")]
    public static void AddBattleAdvProgress(
      FlatBufferBuilder builder,
      Offset<staq.SaveSchema.BattleAdvProgress> battleAdvProgressOffset)
    {
    }

    [Token(Token = "0x6017FAA")]
    [Address(RVA = "0x3B189B4", Offset = "0x3B189B4", VA = "0x3B189B4")]
    public static void AddBattlePlayedVoiceList(
      FlatBufferBuilder builder,
      VectorOffset battlePlayedVoiceListOffset)
    {
    }

    [Token(Token = "0x6017FAB")]
    [Address(RVA = "0x3B1939C", Offset = "0x3B1939C", VA = "0x3B1939C")]
    public static VectorOffset CreateBattlePlayedVoiceListVector(
      FlatBufferBuilder builder,
      Offset<BattlePlayedVoice>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017FAC")]
    [Address(RVA = "0x3B19444", Offset = "0x3B19444", VA = "0x3B19444")]
    public static VectorOffset CreateBattlePlayedVoiceListVectorBlock(
      FlatBufferBuilder builder,
      Offset<BattlePlayedVoice>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017FAD")]
    [Address(RVA = "0x3B194CC", Offset = "0x3B194CC", VA = "0x3B194CC")]
    public static void StartBattlePlayedVoiceListVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017FAE")]
    [Address(RVA = "0x3B18994", Offset = "0x3B18994", VA = "0x3B18994")]
    public static void AddUnitLevelReached(
      FlatBufferBuilder builder,
      VectorOffset unitLevelReachedOffset)
    {
    }

    [Token(Token = "0x6017FAF")]
    [Address(RVA = "0x3B194EC", Offset = "0x3B194EC", VA = "0x3B194EC")]
    public static VectorOffset CreateUnitLevelReachedVector(
      FlatBufferBuilder builder,
      Offset<staq.SaveSchema.UnitLevelReached>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017FB0")]
    [Address(RVA = "0x3B19594", Offset = "0x3B19594", VA = "0x3B19594")]
    public static VectorOffset CreateUnitLevelReachedVectorBlock(
      FlatBufferBuilder builder,
      Offset<staq.SaveSchema.UnitLevelReached>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017FB1")]
    [Address(RVA = "0x3B1961C", Offset = "0x3B1961C", VA = "0x3B1961C")]
    public static void StartUnitLevelReachedVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017FB2")]
    [Address(RVA = "0x3B18974", Offset = "0x3B18974", VA = "0x3B18974")]
    public static void AddReservedCommand(
      FlatBufferBuilder builder,
      VectorOffset reservedCommandOffset)
    {
    }

    [Token(Token = "0x6017FB3")]
    [Address(RVA = "0x3B1963C", Offset = "0x3B1963C", VA = "0x3B1963C")]
    public static VectorOffset CreateReservedCommandVector(
      FlatBufferBuilder builder,
      Offset<CommandLog>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017FB4")]
    [Address(RVA = "0x3B196E4", Offset = "0x3B196E4", VA = "0x3B196E4")]
    public static VectorOffset CreateReservedCommandVectorBlock(
      FlatBufferBuilder builder,
      Offset<CommandLog>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017FB5")]
    [Address(RVA = "0x3B1976C", Offset = "0x3B1976C", VA = "0x3B1976C")]
    public static void StartReservedCommandVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017FB6")]
    [Address(RVA = "0x3B18954", Offset = "0x3B18954", VA = "0x3B18954")]
    public static void AddResumeCommand(
      FlatBufferBuilder builder,
      Offset<CommandLog> resumeCommandOffset)
    {
    }

    [Token(Token = "0x6017FB7")]
    [Address(RVA = "0x3B18934", Offset = "0x3B18934", VA = "0x3B18934")]
    public static void AddResumePhase(FlatBufferBuilder builder, int resumePhase)
    {
    }

    [Token(Token = "0x6017FB8")]
    [Address(RVA = "0x3B18914", Offset = "0x3B18914", VA = "0x3B18914")]
    public static void AddSecurityLog(FlatBufferBuilder builder, VectorOffset securityLogOffset)
    {
    }

    [Token(Token = "0x6017FB9")]
    [Address(RVA = "0x3B1978C", Offset = "0x3B1978C", VA = "0x3B1978C")]
    public static VectorOffset CreateSecurityLogVector(FlatBufferBuilder builder, byte[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017FBA")]
    [Address(RVA = "0x3B19834", Offset = "0x3B19834", VA = "0x3B19834")]
    public static VectorOffset CreateSecurityLogVectorBlock(FlatBufferBuilder builder, byte[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017FBB")]
    [Address(RVA = "0x3B198BC", Offset = "0x3B198BC", VA = "0x3B198BC")]
    public static void StartSecurityLogVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017FBC")]
    [Address(RVA = "0x3B18B54", Offset = "0x3B18B54", VA = "0x3B18B54")]
    public static Offset<BoardData> EndBoardData(FlatBufferBuilder builder)
    {
      return new Offset<BoardData>();
    }

    [Token(Token = "0x6017FBD")]
    [Address(RVA = "0x3B198DC", Offset = "0x3B198DC", VA = "0x3B198DC")]
    public static void FinishBoardDataBuffer(FlatBufferBuilder builder, Offset<BoardData> offset)
    {
    }

    [Token(Token = "0x6017FBE")]
    [Address(RVA = "0x3B19938", Offset = "0x3B19938", VA = "0x3B19938")]
    public static void FinishSizePrefixedBoardDataBuffer(
      FlatBufferBuilder builder,
      Offset<BoardData> offset)
    {
    }
  }
}
