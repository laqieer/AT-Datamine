// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.BattleAdvProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C77")]
  public struct BattleAdvProgress : IFlatbufferObject
  {
    [Token(Token = "0x4010BD6")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DE4")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017E32"), Address(RVA = "0x37BF8E0", Offset = "0x37BF8E0", VA = "0x37BF8E0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017E33")]
    [Address(RVA = "0x37BF8E8", Offset = "0x37BF8E8", VA = "0x37BF8E8")]
    public static BattleAdvProgress GetRootAsBattleAdvProgress(ByteBuffer _bb)
    {
      return new BattleAdvProgress();
    }

    [Token(Token = "0x6017E34")]
    [Address(RVA = "0x37BF8F4", Offset = "0x37BF8F4", VA = "0x37BF8F4")]
    public static BattleAdvProgress GetRootAsBattleAdvProgress(
      ByteBuffer _bb,
      BattleAdvProgress obj)
    {
      return new BattleAdvProgress();
    }

    [Token(Token = "0x6017E35")]
    [Address(RVA = "0x37BF950", Offset = "0x37BF950", VA = "0x37BF950", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017E36")]
    [Address(RVA = "0x37BF938", Offset = "0x37BF938", VA = "0x37BF938")]
    public BattleAdvProgress __assign(int _i, ByteBuffer _bb) => new BattleAdvProgress();

    [Token(Token = "0x17004DE5")]
    public int StageId
    {
      [Token(Token = "0x6017E37"), Address(RVA = "0x37BF95C", Offset = "0x37BF95C", VA = "0x37BF95C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017E38")]
    [Address(RVA = "0x37BF9A0", Offset = "0x37BF9A0", VA = "0x37BF9A0")]
    public int PlayList(int j) => new int();

    [Token(Token = "0x17004DE6")]
    public int PlayListLength
    {
      [Token(Token = "0x6017E39"), Address(RVA = "0x37BFA00", Offset = "0x37BFA00", VA = "0x37BFA00")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017E3A")]
    [Address(RVA = "0x37BFA34", Offset = "0x37BFA34", VA = "0x37BFA34")]
    public ArraySegment<byte>? GetPlayListBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017E3B")]
    [Address(RVA = "0x37BFA6C", Offset = "0x37BFA6C", VA = "0x37BFA6C")]
    public int[] GetPlayListArray() => (int[]) null;

    [Token(Token = "0x6017E3C")]
    [Address(RVA = "0x37BFAB8", Offset = "0x37BFAB8", VA = "0x37BFAB8")]
    public MatchCountData? AdvMatchCountDic(int j) => new MatchCountData?();

    [Token(Token = "0x17004DE7")]
    public int AdvMatchCountDicLength
    {
      [Token(Token = "0x6017E3D"), Address(RVA = "0x37BFB84", Offset = "0x37BFB84", VA = "0x37BFB84")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017E3E")]
    [Address(RVA = "0x37BFBB8", Offset = "0x37BFBB8", VA = "0x37BFBB8")]
    public WatchedBattleAdvData? ActivatedAdvs(int j) => new WatchedBattleAdvData?();

    [Token(Token = "0x17004DE8")]
    public int ActivatedAdvsLength
    {
      [Token(Token = "0x6017E3F"), Address(RVA = "0x37BFC84", Offset = "0x37BFC84", VA = "0x37BFC84")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017E40")]
    [Address(RVA = "0x37BFCB8", Offset = "0x37BFCB8", VA = "0x37BFCB8")]
    public static Offset<BattleAdvProgress> CreateBattleAdvProgress(
      FlatBufferBuilder builder,
      int stageId = 0,
      VectorOffset playListOffset = default (VectorOffset),
      VectorOffset advMatchCountDicOffset = default (VectorOffset),
      VectorOffset activatedAdvsOffset = default (VectorOffset))
    {
      return new Offset<BattleAdvProgress>();
    }

    [Token(Token = "0x6017E41")]
    [Address(RVA = "0x37BFE08", Offset = "0x37BFE08", VA = "0x37BFE08")]
    public static void StartBattleAdvProgress(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017E42")]
    [Address(RVA = "0x37BFD98", Offset = "0x37BFD98", VA = "0x37BFD98")]
    public static void AddStageId(FlatBufferBuilder builder, int stageId)
    {
    }

    [Token(Token = "0x6017E43")]
    [Address(RVA = "0x37BFD78", Offset = "0x37BFD78", VA = "0x37BFD78")]
    public static void AddPlayList(FlatBufferBuilder builder, VectorOffset playListOffset)
    {
    }

    [Token(Token = "0x6017E44")]
    [Address(RVA = "0x37BFE20", Offset = "0x37BFE20", VA = "0x37BFE20")]
    public static VectorOffset CreatePlayListVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E45")]
    [Address(RVA = "0x37BFEC8", Offset = "0x37BFEC8", VA = "0x37BFEC8")]
    public static VectorOffset CreatePlayListVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E46")]
    [Address(RVA = "0x37BFF50", Offset = "0x37BFF50", VA = "0x37BFF50")]
    public static void StartPlayListVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017E47")]
    [Address(RVA = "0x37BFD58", Offset = "0x37BFD58", VA = "0x37BFD58")]
    public static void AddAdvMatchCountDic(
      FlatBufferBuilder builder,
      VectorOffset advMatchCountDicOffset)
    {
    }

    [Token(Token = "0x6017E48")]
    [Address(RVA = "0x37BFF70", Offset = "0x37BFF70", VA = "0x37BFF70")]
    public static VectorOffset CreateAdvMatchCountDicVector(
      FlatBufferBuilder builder,
      Offset<MatchCountData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E49")]
    [Address(RVA = "0x37C0018", Offset = "0x37C0018", VA = "0x37C0018")]
    public static VectorOffset CreateAdvMatchCountDicVectorBlock(
      FlatBufferBuilder builder,
      Offset<MatchCountData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E4A")]
    [Address(RVA = "0x37C00A0", Offset = "0x37C00A0", VA = "0x37C00A0")]
    public static void StartAdvMatchCountDicVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017E4B")]
    [Address(RVA = "0x37BFD38", Offset = "0x37BFD38", VA = "0x37BFD38")]
    public static void AddActivatedAdvs(FlatBufferBuilder builder, VectorOffset activatedAdvsOffset)
    {
    }

    [Token(Token = "0x6017E4C")]
    [Address(RVA = "0x37C00C0", Offset = "0x37C00C0", VA = "0x37C00C0")]
    public static VectorOffset CreateActivatedAdvsVector(
      FlatBufferBuilder builder,
      Offset<WatchedBattleAdvData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E4D")]
    [Address(RVA = "0x37C0168", Offset = "0x37C0168", VA = "0x37C0168")]
    public static VectorOffset CreateActivatedAdvsVectorBlock(
      FlatBufferBuilder builder,
      Offset<WatchedBattleAdvData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E4E")]
    [Address(RVA = "0x37C01F0", Offset = "0x37C01F0", VA = "0x37C01F0")]
    public static void StartActivatedAdvsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017E4F")]
    [Address(RVA = "0x37BFDB8", Offset = "0x37BFDB8", VA = "0x37BFDB8")]
    public static Offset<BattleAdvProgress> EndBattleAdvProgress(FlatBufferBuilder builder)
    {
      return new Offset<BattleAdvProgress>();
    }
  }
}
