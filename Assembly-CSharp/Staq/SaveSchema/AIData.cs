// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.AIData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C8B")]
  public struct AIData : IFlatbufferObject
  {
    [Token(Token = "0x4010BEA")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E6F")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018053"), Address(RVA = "0x3B1BBCC", Offset = "0x3B1BBCC", VA = "0x3B1BBCC", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018054")]
    [Address(RVA = "0x3B1BBD4", Offset = "0x3B1BBD4", VA = "0x3B1BBD4")]
    public static AIData GetRootAsAIData(ByteBuffer _bb) => new AIData();

    [Token(Token = "0x6018055")]
    [Address(RVA = "0x3B1BBE0", Offset = "0x3B1BBE0", VA = "0x3B1BBE0")]
    public static AIData GetRootAsAIData(ByteBuffer _bb, AIData obj) => new AIData();

    [Token(Token = "0x6018056")]
    [Address(RVA = "0x3B1BC3C", Offset = "0x3B1BC3C", VA = "0x3B1BC3C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018057")]
    [Address(RVA = "0x3B1BC24", Offset = "0x3B1BC24", VA = "0x3B1BC24")]
    public AIData __assign(int _i, ByteBuffer _bb) => new AIData();

    [Token(Token = "0x17004E70")]
    public int CurrentIndex
    {
      [Token(Token = "0x6018058"), Address(RVA = "0x3B1BC48", Offset = "0x3B1BC48", VA = "0x3B1BC48")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018059")]
    [Address(RVA = "0x3B1BC8C", Offset = "0x3B1BC8C", VA = "0x3B1BC8C")]
    public AIVariableData? Variables(int j) => new AIVariableData?();

    [Token(Token = "0x17004E71")]
    public int VariablesLength
    {
      [Token(Token = "0x601805A"), Address(RVA = "0x3B1BD58", Offset = "0x3B1BD58", VA = "0x3B1BD58")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601805B")]
    [Address(RVA = "0x3B1BD8C", Offset = "0x3B1BD8C", VA = "0x3B1BD8C")]
    public Hate? Hates(int j) => new Hate?();

    [Token(Token = "0x17004E72")]
    public int HatesLength
    {
      [Token(Token = "0x601805C"), Address(RVA = "0x3B1BE58", Offset = "0x3B1BE58", VA = "0x3B1BE58")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E73")]
    public bool WithoutArts
    {
      [Token(Token = "0x601805D"), Address(RVA = "0x3B1BE8C", Offset = "0x3B1BE8C", VA = "0x3B1BE8C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E74")]
    public bool WithoutStratagem
    {
      [Token(Token = "0x601805E"), Address(RVA = "0x3B1BED4", Offset = "0x3B1BED4", VA = "0x3B1BED4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E75")]
    public int TargetChestId
    {
      [Token(Token = "0x601805F"), Address(RVA = "0x3B1BF1C", Offset = "0x3B1BF1C", VA = "0x3B1BF1C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018060")]
    [Address(RVA = "0x3B1BF60", Offset = "0x3B1BF60", VA = "0x3B1BF60")]
    public static Offset<AIData> CreateAIData(
      FlatBufferBuilder builder,
      int currentIndex = 0,
      VectorOffset variablesOffset = default (VectorOffset),
      VectorOffset hatesOffset = default (VectorOffset),
      bool withoutArts = false,
      bool withoutStratagem = false,
      int targetChestId = 0)
    {
      return new Offset<AIData>();
    }

    [Token(Token = "0x6018061")]
    [Address(RVA = "0x3B1C118", Offset = "0x3B1C118", VA = "0x3B1C118")]
    public static void StartAIData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018062")]
    [Address(RVA = "0x3B1C068", Offset = "0x3B1C068", VA = "0x3B1C068")]
    public static void AddCurrentIndex(FlatBufferBuilder builder, int currentIndex)
    {
    }

    [Token(Token = "0x6018063")]
    [Address(RVA = "0x3B1C048", Offset = "0x3B1C048", VA = "0x3B1C048")]
    public static void AddVariables(FlatBufferBuilder builder, VectorOffset variablesOffset)
    {
    }

    [Token(Token = "0x6018064")]
    [Address(RVA = "0x3B1C130", Offset = "0x3B1C130", VA = "0x3B1C130")]
    public static VectorOffset CreateVariablesVector(
      FlatBufferBuilder builder,
      Offset<AIVariableData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018065")]
    [Address(RVA = "0x3B1C1D8", Offset = "0x3B1C1D8", VA = "0x3B1C1D8")]
    public static VectorOffset CreateVariablesVectorBlock(
      FlatBufferBuilder builder,
      Offset<AIVariableData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018066")]
    [Address(RVA = "0x3B1C260", Offset = "0x3B1C260", VA = "0x3B1C260")]
    public static void StartVariablesVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018067")]
    [Address(RVA = "0x3B1C028", Offset = "0x3B1C028", VA = "0x3B1C028")]
    public static void AddHates(FlatBufferBuilder builder, VectorOffset hatesOffset)
    {
    }

    [Token(Token = "0x6018068")]
    [Address(RVA = "0x3B1C280", Offset = "0x3B1C280", VA = "0x3B1C280")]
    public static VectorOffset CreateHatesVector(FlatBufferBuilder builder, Offset<Hate>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018069")]
    [Address(RVA = "0x3B1C328", Offset = "0x3B1C328", VA = "0x3B1C328")]
    public static VectorOffset CreateHatesVectorBlock(
      FlatBufferBuilder builder,
      Offset<Hate>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601806A")]
    [Address(RVA = "0x3B1C3B0", Offset = "0x3B1C3B0", VA = "0x3B1C3B0")]
    public static void StartHatesVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601806B")]
    [Address(RVA = "0x3B1C0A8", Offset = "0x3B1C0A8", VA = "0x3B1C0A8")]
    public static void AddWithoutArts(FlatBufferBuilder builder, bool withoutArts)
    {
    }

    [Token(Token = "0x601806C")]
    [Address(RVA = "0x3B1C088", Offset = "0x3B1C088", VA = "0x3B1C088")]
    public static void AddWithoutStratagem(FlatBufferBuilder builder, bool withoutStratagem)
    {
    }

    [Token(Token = "0x601806D")]
    [Address(RVA = "0x3B1C008", Offset = "0x3B1C008", VA = "0x3B1C008")]
    public static void AddTargetChestId(FlatBufferBuilder builder, int targetChestId)
    {
    }

    [Token(Token = "0x601806E")]
    [Address(RVA = "0x3B1C0C8", Offset = "0x3B1C0C8", VA = "0x3B1C0C8")]
    public static Offset<AIData> EndAIData(FlatBufferBuilder builder) => new Offset<AIData>();
  }
}
