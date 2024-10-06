// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.PreHomeEvStage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CCE")]
  public struct PreHomeEvStage : IFlatbufferObject
  {
    [Token(Token = "0x4010C2C")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FA4")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60185D1"), Address(RVA = "0x26DE65C", Offset = "0x26DE65C", VA = "0x26DE65C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60185D2")]
    [Address(RVA = "0x26DE664", Offset = "0x26DE664", VA = "0x26DE664")]
    public static PreHomeEvStage GetRootAsPreHomeEvStage(ByteBuffer _bb) => new PreHomeEvStage();

    [Token(Token = "0x60185D3")]
    [Address(RVA = "0x26DE670", Offset = "0x26DE670", VA = "0x26DE670")]
    public static PreHomeEvStage GetRootAsPreHomeEvStage(ByteBuffer _bb, PreHomeEvStage obj)
    {
      return new PreHomeEvStage();
    }

    [Token(Token = "0x60185D4")]
    [Address(RVA = "0x26DE6CC", Offset = "0x26DE6CC", VA = "0x26DE6CC")]
    public static bool PreHomeEvStageBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60185D5")]
    [Address(RVA = "0x26DE718", Offset = "0x26DE718", VA = "0x26DE718", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60185D6")]
    [Address(RVA = "0x26DE6B4", Offset = "0x26DE6B4", VA = "0x26DE6B4")]
    public PreHomeEvStage __assign(int _i, ByteBuffer _bb) => new PreHomeEvStage();

    [Token(Token = "0x17004FA5")]
    public PreHomeEvStageRecordData? Record
    {
      [Token(Token = "0x60185D7"), Address(RVA = "0x26DE724", Offset = "0x26DE724", VA = "0x26DE724")] get
      {
        return new PreHomeEvStageRecordData?();
      }
    }

    [Token(Token = "0x60185D8")]
    [Address(RVA = "0x26DE7BC", Offset = "0x26DE7BC", VA = "0x26DE7BC")]
    public static Offset<PreHomeEvStage> CreatePreHomeEvStage(
      FlatBufferBuilder builder,
      Offset<PreHomeEvStageRecordData> recordOffset = default (Offset<PreHomeEvStageRecordData>))
    {
      return new Offset<PreHomeEvStage>();
    }

    [Token(Token = "0x60185D9")]
    [Address(RVA = "0x26DE874", Offset = "0x26DE874", VA = "0x26DE874")]
    public static void StartPreHomeEvStage(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60185DA")]
    [Address(RVA = "0x26DE804", Offset = "0x26DE804", VA = "0x26DE804")]
    public static void AddRecord(
      FlatBufferBuilder builder,
      Offset<PreHomeEvStageRecordData> recordOffset)
    {
    }

    [Token(Token = "0x60185DB")]
    [Address(RVA = "0x26DE824", Offset = "0x26DE824", VA = "0x26DE824")]
    public static Offset<PreHomeEvStage> EndPreHomeEvStage(FlatBufferBuilder builder)
    {
      return new Offset<PreHomeEvStage>();
    }

    [Token(Token = "0x60185DC")]
    [Address(RVA = "0x26DE88C", Offset = "0x26DE88C", VA = "0x26DE88C")]
    public static void FinishPreHomeEvStageBuffer(
      FlatBufferBuilder builder,
      Offset<PreHomeEvStage> offset)
    {
    }

    [Token(Token = "0x60185DD")]
    [Address(RVA = "0x26DE8E8", Offset = "0x26DE8E8", VA = "0x26DE8E8")]
    public static void FinishSizePrefixedPreHomeEvStageBuffer(
      FlatBufferBuilder builder,
      Offset<PreHomeEvStage> offset)
    {
    }
  }
}
