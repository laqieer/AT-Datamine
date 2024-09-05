// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.NotifyDatas
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CAC")]
  public struct NotifyDatas : IFlatbufferObject
  {
    [Token(Token = "0x4010C0A")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F2C")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601833D"), Address(RVA = "0x26D47E8", Offset = "0x26D47E8", VA = "0x26D47E8", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601833E")]
    [Address(RVA = "0x26D47F0", Offset = "0x26D47F0", VA = "0x26D47F0")]
    public static NotifyDatas GetRootAsNotifyDatas(ByteBuffer _bb) => new NotifyDatas();

    [Token(Token = "0x601833F")]
    [Address(RVA = "0x26D47FC", Offset = "0x26D47FC", VA = "0x26D47FC")]
    public static NotifyDatas GetRootAsNotifyDatas(ByteBuffer _bb, NotifyDatas obj)
    {
      return new NotifyDatas();
    }

    [Token(Token = "0x6018340")]
    [Address(RVA = "0x26D4858", Offset = "0x26D4858", VA = "0x26D4858")]
    public static bool NotifyDatasBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018341")]
    [Address(RVA = "0x26D48A4", Offset = "0x26D48A4", VA = "0x26D48A4", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018342")]
    [Address(RVA = "0x26D4840", Offset = "0x26D4840", VA = "0x26D4840")]
    public NotifyDatas __assign(int _i, ByteBuffer _bb) => new NotifyDatas();

    [Token(Token = "0x6018343")]
    [Address(RVA = "0x26D48B0", Offset = "0x26D48B0", VA = "0x26D48B0")]
    public staq.SaveSchema.NotifyData? NotifyData(int j) => new staq.SaveSchema.NotifyData?();

    [Token(Token = "0x17004F2D")]
    public int NotifyDataLength
    {
      [Token(Token = "0x6018344"), Address(RVA = "0x26D4964", Offset = "0x26D4964", VA = "0x26D4964")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018345")]
    [Address(RVA = "0x26D4998", Offset = "0x26D4998", VA = "0x26D4998")]
    public static Offset<NotifyDatas> CreateNotifyDatas(
      FlatBufferBuilder builder,
      VectorOffset NotifyDataOffset = default (VectorOffset))
    {
      return new Offset<NotifyDatas>();
    }

    [Token(Token = "0x6018346")]
    [Address(RVA = "0x26D4A50", Offset = "0x26D4A50", VA = "0x26D4A50")]
    public static void StartNotifyDatas(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018347")]
    [Address(RVA = "0x26D49E0", Offset = "0x26D49E0", VA = "0x26D49E0")]
    public static void AddNotifyData(FlatBufferBuilder builder, VectorOffset NotifyDataOffset)
    {
    }

    [Token(Token = "0x6018348")]
    [Address(RVA = "0x26D4A68", Offset = "0x26D4A68", VA = "0x26D4A68")]
    public static VectorOffset CreateNotifyDataVector(
      FlatBufferBuilder builder,
      Offset<staq.SaveSchema.NotifyData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018349")]
    [Address(RVA = "0x26D4B10", Offset = "0x26D4B10", VA = "0x26D4B10")]
    public static VectorOffset CreateNotifyDataVectorBlock(
      FlatBufferBuilder builder,
      Offset<staq.SaveSchema.NotifyData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601834A")]
    [Address(RVA = "0x26D4B98", Offset = "0x26D4B98", VA = "0x26D4B98")]
    public static void StartNotifyDataVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601834B")]
    [Address(RVA = "0x26D4A00", Offset = "0x26D4A00", VA = "0x26D4A00")]
    public static Offset<NotifyDatas> EndNotifyDatas(FlatBufferBuilder builder)
    {
      return new Offset<NotifyDatas>();
    }

    [Token(Token = "0x601834C")]
    [Address(RVA = "0x26D4BB8", Offset = "0x26D4BB8", VA = "0x26D4BB8")]
    public static void FinishNotifyDatasBuffer(
      FlatBufferBuilder builder,
      Offset<NotifyDatas> offset)
    {
    }

    [Token(Token = "0x601834D")]
    [Address(RVA = "0x26D4C14", Offset = "0x26D4C14", VA = "0x26D4C14")]
    public static void FinishSizePrefixedNotifyDatasBuffer(
      FlatBufferBuilder builder,
      Offset<NotifyDatas> offset)
    {
    }
  }
}
