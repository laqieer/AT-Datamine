// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.PreHomeEvStageRecordData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CCD")]
  public struct PreHomeEvStageRecordData : IFlatbufferObject
  {
    [Token(Token = "0x4010C2B")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FA2")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60185C1"), Address(RVA = "0x26DE2A8", Offset = "0x26DE2A8", VA = "0x26DE2A8", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60185C2")]
    [Address(RVA = "0x26DE2B0", Offset = "0x26DE2B0", VA = "0x26DE2B0")]
    public static PreHomeEvStageRecordData GetRootAsPreHomeEvStageRecordData(ByteBuffer _bb)
    {
      return new PreHomeEvStageRecordData();
    }

    [Token(Token = "0x60185C3")]
    [Address(RVA = "0x26DE2BC", Offset = "0x26DE2BC", VA = "0x26DE2BC")]
    public static PreHomeEvStageRecordData GetRootAsPreHomeEvStageRecordData(
      ByteBuffer _bb,
      PreHomeEvStageRecordData obj)
    {
      return new PreHomeEvStageRecordData();
    }

    [Token(Token = "0x60185C4")]
    [Address(RVA = "0x26DE318", Offset = "0x26DE318", VA = "0x26DE318", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60185C5")]
    [Address(RVA = "0x26DE300", Offset = "0x26DE300", VA = "0x26DE300")]
    public PreHomeEvStageRecordData __assign(int _i, ByteBuffer _bb)
    {
      return new PreHomeEvStageRecordData();
    }

    [Token(Token = "0x60185C6")]
    [Address(RVA = "0x26DE324", Offset = "0x26DE324", VA = "0x26DE324")]
    public int RecordId(int j) => new int();

    [Token(Token = "0x17004FA3")]
    public int RecordIdLength
    {
      [Token(Token = "0x60185C7"), Address(RVA = "0x26DE384", Offset = "0x26DE384", VA = "0x26DE384")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60185C8")]
    [Address(RVA = "0x26DE3B8", Offset = "0x26DE3B8", VA = "0x26DE3B8")]
    public ArraySegment<byte>? GetRecordIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60185C9")]
    [Address(RVA = "0x26DE3F0", Offset = "0x26DE3F0", VA = "0x26DE3F0")]
    public int[] GetRecordIdArray() => (int[]) null;

    [Token(Token = "0x60185CA")]
    [Address(RVA = "0x26DE43C", Offset = "0x26DE43C", VA = "0x26DE43C")]
    public static Offset<PreHomeEvStageRecordData> CreatePreHomeEvStageRecordData(
      FlatBufferBuilder builder,
      VectorOffset record_idOffset = default (VectorOffset))
    {
      return new Offset<PreHomeEvStageRecordData>();
    }

    [Token(Token = "0x60185CB")]
    [Address(RVA = "0x26DE4F4", Offset = "0x26DE4F4", VA = "0x26DE4F4")]
    public static void StartPreHomeEvStageRecordData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60185CC")]
    [Address(RVA = "0x26DE484", Offset = "0x26DE484", VA = "0x26DE484")]
    public static void AddRecordId(FlatBufferBuilder builder, VectorOffset recordIdOffset)
    {
    }

    [Token(Token = "0x60185CD")]
    [Address(RVA = "0x26DE50C", Offset = "0x26DE50C", VA = "0x26DE50C")]
    public static VectorOffset CreateRecordIdVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60185CE")]
    [Address(RVA = "0x26DE5B4", Offset = "0x26DE5B4", VA = "0x26DE5B4")]
    public static VectorOffset CreateRecordIdVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60185CF")]
    [Address(RVA = "0x26DE63C", Offset = "0x26DE63C", VA = "0x26DE63C")]
    public static void StartRecordIdVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60185D0")]
    [Address(RVA = "0x26DE4A4", Offset = "0x26DE4A4", VA = "0x26DE4A4")]
    public static Offset<PreHomeEvStageRecordData> EndPreHomeEvStageRecordData(
      FlatBufferBuilder builder)
    {
      return new Offset<PreHomeEvStageRecordData>();
    }
  }
}
