// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.BattlePlayerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C86")]
  public struct BattlePlayerData : IFlatbufferObject
  {
    [Token(Token = "0x4010BE5")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E53")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017FEA"), Address(RVA = "0x3B1A1F4", Offset = "0x3B1A1F4", VA = "0x3B1A1F4", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017FEB")]
    [Address(RVA = "0x3B1A1FC", Offset = "0x3B1A1FC", VA = "0x3B1A1FC")]
    public static BattlePlayerData GetRootAsBattlePlayerData(ByteBuffer _bb)
    {
      return new BattlePlayerData();
    }

    [Token(Token = "0x6017FEC")]
    [Address(RVA = "0x3B1A208", Offset = "0x3B1A208", VA = "0x3B1A208")]
    public static BattlePlayerData GetRootAsBattlePlayerData(ByteBuffer _bb, BattlePlayerData obj)
    {
      return new BattlePlayerData();
    }

    [Token(Token = "0x6017FED")]
    [Address(RVA = "0x3B1A24C", Offset = "0x3B1A24C", VA = "0x3B1A24C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017FEE")]
    [Address(RVA = "0x3B180C8", Offset = "0x3B180C8", VA = "0x3B180C8")]
    public BattlePlayerData __assign(int _i, ByteBuffer _bb) => new BattlePlayerData();

    [Token(Token = "0x17004E54")]
    public int Id
    {
      [Token(Token = "0x6017FEF"), Address(RVA = "0x3B1A258", Offset = "0x3B1A258", VA = "0x3B1A258")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E55")]
    public int ClearCondition
    {
      [Token(Token = "0x6017FF0"), Address(RVA = "0x3B1A29C", Offset = "0x3B1A29C", VA = "0x3B1A29C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E56")]
    public int FailedCondition
    {
      [Token(Token = "0x6017FF1"), Address(RVA = "0x3B1A2E0", Offset = "0x3B1A2E0", VA = "0x3B1A2E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017FF2")]
    [Address(RVA = "0x3B1A324", Offset = "0x3B1A324", VA = "0x3B1A324")]
    public int OwnedUnitParams(int j) => new int();

    [Token(Token = "0x17004E57")]
    public int OwnedUnitParamsLength
    {
      [Token(Token = "0x6017FF3"), Address(RVA = "0x3B1A384", Offset = "0x3B1A384", VA = "0x3B1A384")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017FF4")]
    [Address(RVA = "0x3B1A3B8", Offset = "0x3B1A3B8", VA = "0x3B1A3B8")]
    public ArraySegment<byte>? GetOwnedUnitParamsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017FF5")]
    [Address(RVA = "0x3B1A3F0", Offset = "0x3B1A3F0", VA = "0x3B1A3F0")]
    public int[] GetOwnedUnitParamsArray() => (int[]) null;

    [Token(Token = "0x6017FF6")]
    [Address(RVA = "0x3B1A43C", Offset = "0x3B1A43C", VA = "0x3B1A43C")]
    public int ControledUnitParams(int j) => new int();

    [Token(Token = "0x17004E58")]
    public int ControledUnitParamsLength
    {
      [Token(Token = "0x6017FF7"), Address(RVA = "0x3B1A49C", Offset = "0x3B1A49C", VA = "0x3B1A49C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017FF8")]
    [Address(RVA = "0x3B1A4D0", Offset = "0x3B1A4D0", VA = "0x3B1A4D0")]
    public ArraySegment<byte>? GetControledUnitParamsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017FF9")]
    [Address(RVA = "0x3B1A508", Offset = "0x3B1A508", VA = "0x3B1A508")]
    public int[] GetControledUnitParamsArray() => (int[]) null;

    [Token(Token = "0x6017FFA")]
    [Address(RVA = "0x3B1A554", Offset = "0x3B1A554", VA = "0x3B1A554")]
    public ItemParameterData? ItemParams(int j) => new ItemParameterData?();

    [Token(Token = "0x17004E59")]
    public int ItemParamsLength
    {
      [Token(Token = "0x6017FFB"), Address(RVA = "0x3B1A620", Offset = "0x3B1A620", VA = "0x3B1A620")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017FFC")]
    [Address(RVA = "0x3B1A654", Offset = "0x3B1A654", VA = "0x3B1A654")]
    public CharacterSupportData? Supports(int j) => new CharacterSupportData?();

    [Token(Token = "0x17004E5A")]
    public int SupportsLength
    {
      [Token(Token = "0x6017FFD"), Address(RVA = "0x3B1A714", Offset = "0x3B1A714", VA = "0x3B1A714")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017FFE")]
    [Address(RVA = "0x3B1A748", Offset = "0x3B1A748", VA = "0x3B1A748")]
    public DropItem? GottenItemList(int j) => new DropItem?();

    [Token(Token = "0x17004E5B")]
    public int GottenItemListLength
    {
      [Token(Token = "0x6017FFF"), Address(RVA = "0x3B1A814", Offset = "0x3B1A814", VA = "0x3B1A814")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018000")]
    [Address(RVA = "0x3B1A848", Offset = "0x3B1A848", VA = "0x3B1A848")]
    public int OpenedChestIds(int j) => new int();

    [Token(Token = "0x17004E5C")]
    public int OpenedChestIdsLength
    {
      [Token(Token = "0x6018001"), Address(RVA = "0x3B1A8A8", Offset = "0x3B1A8A8", VA = "0x3B1A8A8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018002")]
    [Address(RVA = "0x3B1A8DC", Offset = "0x3B1A8DC", VA = "0x3B1A8DC")]
    public ArraySegment<byte>? GetOpenedChestIdsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018003")]
    [Address(RVA = "0x3B1A914", Offset = "0x3B1A914", VA = "0x3B1A914")]
    public int[] GetOpenedChestIdsArray() => (int[]) null;

    [Token(Token = "0x17004E5D")]
    public int ControllerType
    {
      [Token(Token = "0x6018004"), Address(RVA = "0x3B1A960", Offset = "0x3B1A960", VA = "0x3B1A960")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E5E")]
    public bool IsUser
    {
      [Token(Token = "0x6018005"), Address(RVA = "0x3B1A9A4", Offset = "0x3B1A9A4", VA = "0x3B1A9A4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6018006")]
    [Address(RVA = "0x3B1A9EC", Offset = "0x3B1A9EC", VA = "0x3B1A9EC")]
    public static Offset<BattlePlayerData> CreateBattlePlayerData(
      FlatBufferBuilder builder,
      int id = 0,
      int clearCondition = 0,
      int failedCondition = 0,
      VectorOffset ownedUnitParamsOffset = default (VectorOffset),
      VectorOffset controledUnitParamsOffset = default (VectorOffset),
      VectorOffset itemParamsOffset = default (VectorOffset),
      VectorOffset supportsOffset = default (VectorOffset),
      VectorOffset gottenItemListOffset = default (VectorOffset),
      VectorOffset openedChestIdsOffset = default (VectorOffset),
      int controllerType = 0,
      bool isUser = false)
    {
      return new Offset<BattlePlayerData>();
    }

    [Token(Token = "0x6018007")]
    [Address(RVA = "0x3B1ACA8", Offset = "0x3B1ACA8", VA = "0x3B1ACA8")]
    public static void StartBattlePlayerData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018008")]
    [Address(RVA = "0x3B1AC18", Offset = "0x3B1AC18", VA = "0x3B1AC18")]
    public static void AddId(FlatBufferBuilder builder, int id)
    {
    }

    [Token(Token = "0x6018009")]
    [Address(RVA = "0x3B1ABF8", Offset = "0x3B1ABF8", VA = "0x3B1ABF8")]
    public static void AddClearCondition(FlatBufferBuilder builder, int clearCondition)
    {
    }

    [Token(Token = "0x601800A")]
    [Address(RVA = "0x3B1ABD8", Offset = "0x3B1ABD8", VA = "0x3B1ABD8")]
    public static void AddFailedCondition(FlatBufferBuilder builder, int failedCondition)
    {
    }

    [Token(Token = "0x601800B")]
    [Address(RVA = "0x3B1ABB8", Offset = "0x3B1ABB8", VA = "0x3B1ABB8")]
    public static void AddOwnedUnitParams(
      FlatBufferBuilder builder,
      VectorOffset ownedUnitParamsOffset)
    {
    }

    [Token(Token = "0x601800C")]
    [Address(RVA = "0x3B1ACC0", Offset = "0x3B1ACC0", VA = "0x3B1ACC0")]
    public static VectorOffset CreateOwnedUnitParamsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601800D")]
    [Address(RVA = "0x3B1AD68", Offset = "0x3B1AD68", VA = "0x3B1AD68")]
    public static VectorOffset CreateOwnedUnitParamsVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601800E")]
    [Address(RVA = "0x3B1ADF0", Offset = "0x3B1ADF0", VA = "0x3B1ADF0")]
    public static void StartOwnedUnitParamsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601800F")]
    [Address(RVA = "0x3B1AB98", Offset = "0x3B1AB98", VA = "0x3B1AB98")]
    public static void AddControledUnitParams(
      FlatBufferBuilder builder,
      VectorOffset controledUnitParamsOffset)
    {
    }

    [Token(Token = "0x6018010")]
    [Address(RVA = "0x3B1AE10", Offset = "0x3B1AE10", VA = "0x3B1AE10")]
    public static VectorOffset CreateControledUnitParamsVector(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018011")]
    [Address(RVA = "0x3B1AEB8", Offset = "0x3B1AEB8", VA = "0x3B1AEB8")]
    public static VectorOffset CreateControledUnitParamsVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018012")]
    [Address(RVA = "0x3B1AF40", Offset = "0x3B1AF40", VA = "0x3B1AF40")]
    public static void StartControledUnitParamsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018013")]
    [Address(RVA = "0x3B1AB78", Offset = "0x3B1AB78", VA = "0x3B1AB78")]
    public static void AddItemParams(FlatBufferBuilder builder, VectorOffset itemParamsOffset)
    {
    }

    [Token(Token = "0x6018014")]
    [Address(RVA = "0x3B1AF60", Offset = "0x3B1AF60", VA = "0x3B1AF60")]
    public static VectorOffset CreateItemParamsVector(
      FlatBufferBuilder builder,
      Offset<ItemParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018015")]
    [Address(RVA = "0x3B1B008", Offset = "0x3B1B008", VA = "0x3B1B008")]
    public static VectorOffset CreateItemParamsVectorBlock(
      FlatBufferBuilder builder,
      Offset<ItemParameterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018016")]
    [Address(RVA = "0x3B1B090", Offset = "0x3B1B090", VA = "0x3B1B090")]
    public static void StartItemParamsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018017")]
    [Address(RVA = "0x3B1AB58", Offset = "0x3B1AB58", VA = "0x3B1AB58")]
    public static void AddSupports(FlatBufferBuilder builder, VectorOffset supportsOffset)
    {
    }

    [Token(Token = "0x6018018")]
    [Address(RVA = "0x3B1B0B0", Offset = "0x3B1B0B0", VA = "0x3B1B0B0")]
    public static void StartSupportsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018019")]
    [Address(RVA = "0x3B1AB38", Offset = "0x3B1AB38", VA = "0x3B1AB38")]
    public static void AddGottenItemList(
      FlatBufferBuilder builder,
      VectorOffset gottenItemListOffset)
    {
    }

    [Token(Token = "0x601801A")]
    [Address(RVA = "0x3B1B0D0", Offset = "0x3B1B0D0", VA = "0x3B1B0D0")]
    public static VectorOffset CreateGottenItemListVector(
      FlatBufferBuilder builder,
      Offset<DropItem>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601801B")]
    [Address(RVA = "0x3B1B178", Offset = "0x3B1B178", VA = "0x3B1B178")]
    public static VectorOffset CreateGottenItemListVectorBlock(
      FlatBufferBuilder builder,
      Offset<DropItem>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601801C")]
    [Address(RVA = "0x3B1B200", Offset = "0x3B1B200", VA = "0x3B1B200")]
    public static void StartGottenItemListVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601801D")]
    [Address(RVA = "0x3B1AB18", Offset = "0x3B1AB18", VA = "0x3B1AB18")]
    public static void AddOpenedChestIds(
      FlatBufferBuilder builder,
      VectorOffset openedChestIdsOffset)
    {
    }

    [Token(Token = "0x601801E")]
    [Address(RVA = "0x3B1B220", Offset = "0x3B1B220", VA = "0x3B1B220")]
    public static VectorOffset CreateOpenedChestIdsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601801F")]
    [Address(RVA = "0x3B1B2C8", Offset = "0x3B1B2C8", VA = "0x3B1B2C8")]
    public static VectorOffset CreateOpenedChestIdsVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018020")]
    [Address(RVA = "0x3B1B350", Offset = "0x3B1B350", VA = "0x3B1B350")]
    public static void StartOpenedChestIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018021")]
    [Address(RVA = "0x3B1AAF8", Offset = "0x3B1AAF8", VA = "0x3B1AAF8")]
    public static void AddControllerType(FlatBufferBuilder builder, int controllerType)
    {
    }

    [Token(Token = "0x6018022")]
    [Address(RVA = "0x3B1AC38", Offset = "0x3B1AC38", VA = "0x3B1AC38")]
    public static void AddIsUser(FlatBufferBuilder builder, bool isUser)
    {
    }

    [Token(Token = "0x6018023")]
    [Address(RVA = "0x3B1AC58", Offset = "0x3B1AC58", VA = "0x3B1AC58")]
    public static Offset<BattlePlayerData> EndBattlePlayerData(FlatBufferBuilder builder)
    {
      return new Offset<BattlePlayerData>();
    }
  }
}
