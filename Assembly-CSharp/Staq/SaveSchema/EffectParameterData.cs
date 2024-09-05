// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.EffectParameterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C93")]
  public struct EffectParameterData : IFlatbufferObject
  {
    [Token(Token = "0x4010BF2")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004EBB")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018156"), Address(RVA = "0x3B1FCFC", Offset = "0x3B1FCFC", VA = "0x3B1FCFC", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018157")]
    [Address(RVA = "0x3B1FD04", Offset = "0x3B1FD04", VA = "0x3B1FD04")]
    public static EffectParameterData GetRootAsEffectParameterData(ByteBuffer _bb)
    {
      return new EffectParameterData();
    }

    [Token(Token = "0x6018158")]
    [Address(RVA = "0x3B1FD10", Offset = "0x3B1FD10", VA = "0x3B1FD10")]
    public static EffectParameterData GetRootAsEffectParameterData(
      ByteBuffer _bb,
      EffectParameterData obj)
    {
      return new EffectParameterData();
    }

    [Token(Token = "0x6018159")]
    [Address(RVA = "0x3B1FD54", Offset = "0x3B1FD54", VA = "0x3B1FD54", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601815A")]
    [Address(RVA = "0x3B1DAD0", Offset = "0x3B1DAD0", VA = "0x3B1DAD0")]
    public EffectParameterData __assign(int _i, ByteBuffer _bb) => new EffectParameterData();

    [Token(Token = "0x17004EBC")]
    public int Effect
    {
      [Token(Token = "0x601815B"), Address(RVA = "0x3B1FD60", Offset = "0x3B1FD60", VA = "0x3B1FD60")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EBD")]
    public int AffectUnitId
    {
      [Token(Token = "0x601815C"), Address(RVA = "0x3B1FDA4", Offset = "0x3B1FDA4", VA = "0x3B1FDA4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EBE")]
    public int AffectSkillId
    {
      [Token(Token = "0x601815D"), Address(RVA = "0x3B1FDE8", Offset = "0x3B1FDE8", VA = "0x3B1FDE8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EBF")]
    public int EffectedTurnNumber
    {
      [Token(Token = "0x601815E"), Address(RVA = "0x3B1FE2C", Offset = "0x3B1FE2C", VA = "0x3B1FE2C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EC0")]
    public int EffectedPhaseIndex
    {
      [Token(Token = "0x601815F"), Address(RVA = "0x3B1FE70", Offset = "0x3B1FE70", VA = "0x3B1FE70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EC1")]
    public int ElapsedTurn
    {
      [Token(Token = "0x6018160"), Address(RVA = "0x3B1FEB4", Offset = "0x3B1FEB4", VA = "0x3B1FEB4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EC2")]
    public int Context
    {
      [Token(Token = "0x6018161"), Address(RVA = "0x3B1FEF8", Offset = "0x3B1FEF8", VA = "0x3B1FEF8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018162")]
    [Address(RVA = "0x3B1FF3C", Offset = "0x3B1FF3C", VA = "0x3B1FF3C")]
    public int DurationContexts(int j) => new int();

    [Token(Token = "0x17004EC3")]
    public int DurationContextsLength
    {
      [Token(Token = "0x6018163"), Address(RVA = "0x3B1FF9C", Offset = "0x3B1FF9C", VA = "0x3B1FF9C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018164")]
    [Address(RVA = "0x3B1FFD0", Offset = "0x3B1FFD0", VA = "0x3B1FFD0")]
    public ArraySegment<byte>? GetDurationContextsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018165")]
    [Address(RVA = "0x3B20008", Offset = "0x3B20008", VA = "0x3B20008")]
    public int[] GetDurationContextsArray() => (int[]) null;

    [Token(Token = "0x17004EC4")]
    public int PutOperationCount
    {
      [Token(Token = "0x6018166"), Address(RVA = "0x3B20054", Offset = "0x3B20054", VA = "0x3B20054")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018167")]
    [Address(RVA = "0x3B20098", Offset = "0x3B20098", VA = "0x3B20098")]
    public static Offset<EffectParameterData> CreateEffectParameterData(
      FlatBufferBuilder builder,
      int effect = 0,
      int affectUnitId = 0,
      int affectSkillId = 0,
      int effectedTurnNumber = 0,
      int effectedPhaseIndex = 0,
      int elapsedTurn = 0,
      int context = 0,
      VectorOffset durationContextsOffset = default (VectorOffset),
      int putOperationCount = 0)
    {
      return new Offset<EffectParameterData>();
    }

    [Token(Token = "0x6018168")]
    [Address(RVA = "0x3B202F0", Offset = "0x3B202F0", VA = "0x3B202F0")]
    public static void StartEffectParameterData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018169")]
    [Address(RVA = "0x3B20280", Offset = "0x3B20280", VA = "0x3B20280")]
    public static void AddEffect(FlatBufferBuilder builder, int effect)
    {
    }

    [Token(Token = "0x601816A")]
    [Address(RVA = "0x3B20260", Offset = "0x3B20260", VA = "0x3B20260")]
    public static void AddAffectUnitId(FlatBufferBuilder builder, int affectUnitId)
    {
    }

    [Token(Token = "0x601816B")]
    [Address(RVA = "0x3B20240", Offset = "0x3B20240", VA = "0x3B20240")]
    public static void AddAffectSkillId(FlatBufferBuilder builder, int affectSkillId)
    {
    }

    [Token(Token = "0x601816C")]
    [Address(RVA = "0x3B20220", Offset = "0x3B20220", VA = "0x3B20220")]
    public static void AddEffectedTurnNumber(FlatBufferBuilder builder, int effectedTurnNumber)
    {
    }

    [Token(Token = "0x601816D")]
    [Address(RVA = "0x3B20200", Offset = "0x3B20200", VA = "0x3B20200")]
    public static void AddEffectedPhaseIndex(FlatBufferBuilder builder, int effectedPhaseIndex)
    {
    }

    [Token(Token = "0x601816E")]
    [Address(RVA = "0x3B201E0", Offset = "0x3B201E0", VA = "0x3B201E0")]
    public static void AddElapsedTurn(FlatBufferBuilder builder, int elapsedTurn)
    {
    }

    [Token(Token = "0x601816F")]
    [Address(RVA = "0x3B201C0", Offset = "0x3B201C0", VA = "0x3B201C0")]
    public static void AddContext(FlatBufferBuilder builder, int context)
    {
    }

    [Token(Token = "0x6018170")]
    [Address(RVA = "0x3B201A0", Offset = "0x3B201A0", VA = "0x3B201A0")]
    public static void AddDurationContexts(
      FlatBufferBuilder builder,
      VectorOffset durationContextsOffset)
    {
    }

    [Token(Token = "0x6018171")]
    [Address(RVA = "0x3B20308", Offset = "0x3B20308", VA = "0x3B20308")]
    public static VectorOffset CreateDurationContextsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018172")]
    [Address(RVA = "0x3B203B0", Offset = "0x3B203B0", VA = "0x3B203B0")]
    public static VectorOffset CreateDurationContextsVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018173")]
    [Address(RVA = "0x3B20438", Offset = "0x3B20438", VA = "0x3B20438")]
    public static void StartDurationContextsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018174")]
    [Address(RVA = "0x3B20180", Offset = "0x3B20180", VA = "0x3B20180")]
    public static void AddPutOperationCount(FlatBufferBuilder builder, int putOperationCount)
    {
    }

    [Token(Token = "0x6018175")]
    [Address(RVA = "0x3B202A0", Offset = "0x3B202A0", VA = "0x3B202A0")]
    public static Offset<EffectParameterData> EndEffectParameterData(FlatBufferBuilder builder)
    {
      return new Offset<EffectParameterData>();
    }
  }
}
