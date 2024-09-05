// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.NewFlagRentalBook
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CC5")]
  public struct NewFlagRentalBook : IFlatbufferObject
  {
    [Token(Token = "0x4010C23")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F82")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601851E"), Address(RVA = "0x26DBDA4", Offset = "0x26DBDA4", VA = "0x26DBDA4", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601851F")]
    [Address(RVA = "0x26DBDAC", Offset = "0x26DBDAC", VA = "0x26DBDAC")]
    public static NewFlagRentalBook GetRootAsNewFlagRentalBook(ByteBuffer _bb)
    {
      return new NewFlagRentalBook();
    }

    [Token(Token = "0x6018520")]
    [Address(RVA = "0x26DBDB8", Offset = "0x26DBDB8", VA = "0x26DBDB8")]
    public static NewFlagRentalBook GetRootAsNewFlagRentalBook(
      ByteBuffer _bb,
      NewFlagRentalBook obj)
    {
      return new NewFlagRentalBook();
    }

    [Token(Token = "0x6018521")]
    [Address(RVA = "0x26DBE14", Offset = "0x26DBE14", VA = "0x26DBE14")]
    public static bool NewFlagRentalBookBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018522")]
    [Address(RVA = "0x26DBE60", Offset = "0x26DBE60", VA = "0x26DBE60", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018523")]
    [Address(RVA = "0x26DBDFC", Offset = "0x26DBDFC", VA = "0x26DBDFC")]
    public NewFlagRentalBook __assign(int _i, ByteBuffer _bb) => new NewFlagRentalBook();

    [Token(Token = "0x6018524")]
    [Address(RVA = "0x26DBE6C", Offset = "0x26DBE6C", VA = "0x26DBE6C")]
    public int ChapterItemIds(int j) => new int();

    [Token(Token = "0x17004F83")]
    public int ChapterItemIdsLength
    {
      [Token(Token = "0x6018525"), Address(RVA = "0x26DBECC", Offset = "0x26DBECC", VA = "0x26DBECC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018526")]
    [Address(RVA = "0x26DBF00", Offset = "0x26DBF00", VA = "0x26DBF00")]
    public ArraySegment<byte>? GetChapterItemIdsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018527")]
    [Address(RVA = "0x26DBF38", Offset = "0x26DBF38", VA = "0x26DBF38")]
    public int[] GetChapterItemIdsArray() => (int[]) null;

    [Token(Token = "0x6018528")]
    [Address(RVA = "0x26DBF84", Offset = "0x26DBF84", VA = "0x26DBF84")]
    public static Offset<NewFlagRentalBook> CreateNewFlagRentalBook(
      FlatBufferBuilder builder,
      VectorOffset chapter_item_idsOffset = default (VectorOffset))
    {
      return new Offset<NewFlagRentalBook>();
    }

    [Token(Token = "0x6018529")]
    [Address(RVA = "0x26DC03C", Offset = "0x26DC03C", VA = "0x26DC03C")]
    public static void StartNewFlagRentalBook(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601852A")]
    [Address(RVA = "0x26DBFCC", Offset = "0x26DBFCC", VA = "0x26DBFCC")]
    public static void AddChapterItemIds(
      FlatBufferBuilder builder,
      VectorOffset chapterItemIdsOffset)
    {
    }

    [Token(Token = "0x601852B")]
    [Address(RVA = "0x26DC054", Offset = "0x26DC054", VA = "0x26DC054")]
    public static VectorOffset CreateChapterItemIdsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601852C")]
    [Address(RVA = "0x26DC0FC", Offset = "0x26DC0FC", VA = "0x26DC0FC")]
    public static VectorOffset CreateChapterItemIdsVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601852D")]
    [Address(RVA = "0x26DC184", Offset = "0x26DC184", VA = "0x26DC184")]
    public static void StartChapterItemIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601852E")]
    [Address(RVA = "0x26DBFEC", Offset = "0x26DBFEC", VA = "0x26DBFEC")]
    public static Offset<NewFlagRentalBook> EndNewFlagRentalBook(FlatBufferBuilder builder)
    {
      return new Offset<NewFlagRentalBook>();
    }

    [Token(Token = "0x601852F")]
    [Address(RVA = "0x26DC1A4", Offset = "0x26DC1A4", VA = "0x26DC1A4")]
    public static void FinishNewFlagRentalBookBuffer(
      FlatBufferBuilder builder,
      Offset<NewFlagRentalBook> offset)
    {
    }

    [Token(Token = "0x6018530")]
    [Address(RVA = "0x26DC200", Offset = "0x26DC200", VA = "0x26DC200")]
    public static void FinishSizePrefixedNewFlagRentalBookBuffer(
      FlatBufferBuilder builder,
      Offset<NewFlagRentalBook> offset)
    {
    }
  }
}
