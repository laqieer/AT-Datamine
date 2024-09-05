// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.QuestSelectedData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CD0")]
  public struct QuestSelectedData : IFlatbufferObject
  {
    [Token(Token = "0x4010C2E")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FA9")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60185ED"), Address(RVA = "0x26DEC54", Offset = "0x26DEC54", VA = "0x26DEC54", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60185EE")]
    [Address(RVA = "0x26DEC5C", Offset = "0x26DEC5C", VA = "0x26DEC5C")]
    public static QuestSelectedData GetRootAsQuestSelectedData(ByteBuffer _bb)
    {
      return new QuestSelectedData();
    }

    [Token(Token = "0x60185EF")]
    [Address(RVA = "0x26DEC68", Offset = "0x26DEC68", VA = "0x26DEC68")]
    public static QuestSelectedData GetRootAsQuestSelectedData(
      ByteBuffer _bb,
      QuestSelectedData obj)
    {
      return new QuestSelectedData();
    }

    [Token(Token = "0x60185F0")]
    [Address(RVA = "0x26DECC4", Offset = "0x26DECC4", VA = "0x26DECC4")]
    public static bool QuestSelectedDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60185F1")]
    [Address(RVA = "0x26DED10", Offset = "0x26DED10", VA = "0x26DED10", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60185F2")]
    [Address(RVA = "0x26DECAC", Offset = "0x26DECAC", VA = "0x26DECAC")]
    public QuestSelectedData __assign(int _i, ByteBuffer _bb) => new QuestSelectedData();

    [Token(Token = "0x60185F3")]
    [Address(RVA = "0x26DED1C", Offset = "0x26DED1C", VA = "0x26DED1C")]
    public int QuestSelectedId(int j) => new int();

    [Token(Token = "0x17004FAA")]
    public int QuestSelectedIdLength
    {
      [Token(Token = "0x60185F4"), Address(RVA = "0x26DED7C", Offset = "0x26DED7C", VA = "0x26DED7C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60185F5")]
    [Address(RVA = "0x26DEDB0", Offset = "0x26DEDB0", VA = "0x26DEDB0")]
    public ArraySegment<byte>? GetQuestSelectedIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60185F6")]
    [Address(RVA = "0x26DEDE8", Offset = "0x26DEDE8", VA = "0x26DEDE8")]
    public int[] GetQuestSelectedIdArray() => (int[]) null;

    [Token(Token = "0x60185F7")]
    [Address(RVA = "0x26DEE34", Offset = "0x26DEE34", VA = "0x26DEE34")]
    public static Offset<QuestSelectedData> CreateQuestSelectedData(
      FlatBufferBuilder builder,
      VectorOffset quest_selected_idOffset = default (VectorOffset))
    {
      return new Offset<QuestSelectedData>();
    }

    [Token(Token = "0x60185F8")]
    [Address(RVA = "0x26DEEEC", Offset = "0x26DEEEC", VA = "0x26DEEEC")]
    public static void StartQuestSelectedData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60185F9")]
    [Address(RVA = "0x26DEE7C", Offset = "0x26DEE7C", VA = "0x26DEE7C")]
    public static void AddQuestSelectedId(
      FlatBufferBuilder builder,
      VectorOffset questSelectedIdOffset)
    {
    }

    [Token(Token = "0x60185FA")]
    [Address(RVA = "0x26DEF04", Offset = "0x26DEF04", VA = "0x26DEF04")]
    public static VectorOffset CreateQuestSelectedIdVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60185FB")]
    [Address(RVA = "0x26DEFAC", Offset = "0x26DEFAC", VA = "0x26DEFAC")]
    public static VectorOffset CreateQuestSelectedIdVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60185FC")]
    [Address(RVA = "0x26DF034", Offset = "0x26DF034", VA = "0x26DF034")]
    public static void StartQuestSelectedIdVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60185FD")]
    [Address(RVA = "0x26DEE9C", Offset = "0x26DEE9C", VA = "0x26DEE9C")]
    public static Offset<QuestSelectedData> EndQuestSelectedData(FlatBufferBuilder builder)
    {
      return new Offset<QuestSelectedData>();
    }

    [Token(Token = "0x60185FE")]
    [Address(RVA = "0x26DF054", Offset = "0x26DF054", VA = "0x26DF054")]
    public static void FinishQuestSelectedDataBuffer(
      FlatBufferBuilder builder,
      Offset<QuestSelectedData> offset)
    {
    }

    [Token(Token = "0x60185FF")]
    [Address(RVA = "0x26DF0B0", Offset = "0x26DF0B0", VA = "0x26DF0B0")]
    public static void FinishSizePrefixedQuestSelectedDataBuffer(
      FlatBufferBuilder builder,
      Offset<QuestSelectedData> offset)
    {
    }
  }
}
