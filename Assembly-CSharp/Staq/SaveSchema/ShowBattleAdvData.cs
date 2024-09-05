// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ShowBattleAdvData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CDB")]
  public struct ShowBattleAdvData : IFlatbufferObject
  {
    [Token(Token = "0x4010C3C")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FC5")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601868E"), Address(RVA = "0x26E11A8", Offset = "0x26E11A8", VA = "0x26E11A8", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601868F")]
    [Address(RVA = "0x26E11B0", Offset = "0x26E11B0", VA = "0x26E11B0")]
    public static ShowBattleAdvData GetRootAsShowBattleAdvData(ByteBuffer _bb)
    {
      return new ShowBattleAdvData();
    }

    [Token(Token = "0x6018690")]
    [Address(RVA = "0x26E11BC", Offset = "0x26E11BC", VA = "0x26E11BC")]
    public static ShowBattleAdvData GetRootAsShowBattleAdvData(
      ByteBuffer _bb,
      ShowBattleAdvData obj)
    {
      return new ShowBattleAdvData();
    }

    [Token(Token = "0x6018691")]
    [Address(RVA = "0x26E1218", Offset = "0x26E1218", VA = "0x26E1218")]
    public static bool ShowBattleAdvDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018692")]
    [Address(RVA = "0x26E1264", Offset = "0x26E1264", VA = "0x26E1264", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018693")]
    [Address(RVA = "0x26E1200", Offset = "0x26E1200", VA = "0x26E1200")]
    public ShowBattleAdvData __assign(int _i, ByteBuffer _bb) => new ShowBattleAdvData();

    [Token(Token = "0x6018694")]
    [Address(RVA = "0x26E1270", Offset = "0x26E1270", VA = "0x26E1270")]
    public int ShowBattleAdvId(int j) => new int();

    [Token(Token = "0x17004FC6")]
    public int ShowBattleAdvIdLength
    {
      [Token(Token = "0x6018695"), Address(RVA = "0x26E12D0", Offset = "0x26E12D0", VA = "0x26E12D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018696")]
    [Address(RVA = "0x26E1304", Offset = "0x26E1304", VA = "0x26E1304")]
    public ArraySegment<byte>? GetShowBattleAdvIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018697")]
    [Address(RVA = "0x26E133C", Offset = "0x26E133C", VA = "0x26E133C")]
    public int[] GetShowBattleAdvIdArray() => (int[]) null;

    [Token(Token = "0x6018698")]
    [Address(RVA = "0x26E1388", Offset = "0x26E1388", VA = "0x26E1388")]
    public static Offset<ShowBattleAdvData> CreateShowBattleAdvData(
      FlatBufferBuilder builder,
      VectorOffset show_battle_adv_idOffset = default (VectorOffset))
    {
      return new Offset<ShowBattleAdvData>();
    }

    [Token(Token = "0x6018699")]
    [Address(RVA = "0x26E1440", Offset = "0x26E1440", VA = "0x26E1440")]
    public static void StartShowBattleAdvData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601869A")]
    [Address(RVA = "0x26E13D0", Offset = "0x26E13D0", VA = "0x26E13D0")]
    public static void AddShowBattleAdvId(
      FlatBufferBuilder builder,
      VectorOffset showBattleAdvIdOffset)
    {
    }

    [Token(Token = "0x601869B")]
    [Address(RVA = "0x26E1458", Offset = "0x26E1458", VA = "0x26E1458")]
    public static VectorOffset CreateShowBattleAdvIdVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601869C")]
    [Address(RVA = "0x26E1500", Offset = "0x26E1500", VA = "0x26E1500")]
    public static VectorOffset CreateShowBattleAdvIdVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601869D")]
    [Address(RVA = "0x26E1588", Offset = "0x26E1588", VA = "0x26E1588")]
    public static void StartShowBattleAdvIdVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601869E")]
    [Address(RVA = "0x26E13F0", Offset = "0x26E13F0", VA = "0x26E13F0")]
    public static Offset<ShowBattleAdvData> EndShowBattleAdvData(FlatBufferBuilder builder)
    {
      return new Offset<ShowBattleAdvData>();
    }

    [Token(Token = "0x601869F")]
    [Address(RVA = "0x26E15A8", Offset = "0x26E15A8", VA = "0x26E15A8")]
    public static void FinishShowBattleAdvDataBuffer(
      FlatBufferBuilder builder,
      Offset<ShowBattleAdvData> offset)
    {
    }

    [Token(Token = "0x60186A0")]
    [Address(RVA = "0x26E1604", Offset = "0x26E1604", VA = "0x26E1604")]
    public static void FinishSizePrefixedShowBattleAdvDataBuffer(
      FlatBufferBuilder builder,
      Offset<ShowBattleAdvData> offset)
    {
    }
  }
}
