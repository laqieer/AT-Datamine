// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.PersonalEmblemCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CCA")]
  public struct PersonalEmblemCheck : IFlatbufferObject
  {
    [Token(Token = "0x4010C28")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F93")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018578"), Address(RVA = "0x26DD218", Offset = "0x26DD218", VA = "0x26DD218", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018579")]
    [Address(RVA = "0x26DD220", Offset = "0x26DD220", VA = "0x26DD220")]
    public static PersonalEmblemCheck GetRootAsPersonalEmblemCheck(ByteBuffer _bb)
    {
      return new PersonalEmblemCheck();
    }

    [Token(Token = "0x601857A")]
    [Address(RVA = "0x26DD22C", Offset = "0x26DD22C", VA = "0x26DD22C")]
    public static PersonalEmblemCheck GetRootAsPersonalEmblemCheck(
      ByteBuffer _bb,
      PersonalEmblemCheck obj)
    {
      return new PersonalEmblemCheck();
    }

    [Token(Token = "0x601857B")]
    [Address(RVA = "0x26DD288", Offset = "0x26DD288", VA = "0x26DD288")]
    public static bool PersonalEmblemCheckBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601857C")]
    [Address(RVA = "0x26DD2D4", Offset = "0x26DD2D4", VA = "0x26DD2D4", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601857D")]
    [Address(RVA = "0x26DD270", Offset = "0x26DD270", VA = "0x26DD270")]
    public PersonalEmblemCheck __assign(int _i, ByteBuffer _bb) => new PersonalEmblemCheck();

    [Token(Token = "0x601857E")]
    [Address(RVA = "0x26DD2E0", Offset = "0x26DD2E0", VA = "0x26DD2E0")]
    public int CheckedContent(int j) => new int();

    [Token(Token = "0x17004F94")]
    public int CheckedContentLength
    {
      [Token(Token = "0x601857F"), Address(RVA = "0x26DD340", Offset = "0x26DD340", VA = "0x26DD340")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018580")]
    [Address(RVA = "0x26DD374", Offset = "0x26DD374", VA = "0x26DD374")]
    public ArraySegment<byte>? GetCheckedContentBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018581")]
    [Address(RVA = "0x26DD3AC", Offset = "0x26DD3AC", VA = "0x26DD3AC")]
    public int[] GetCheckedContentArray() => (int[]) null;

    [Token(Token = "0x6018582")]
    [Address(RVA = "0x26DD3F8", Offset = "0x26DD3F8", VA = "0x26DD3F8")]
    public static Offset<PersonalEmblemCheck> CreatePersonalEmblemCheck(
      FlatBufferBuilder builder,
      VectorOffset checked_contentOffset = default (VectorOffset))
    {
      return new Offset<PersonalEmblemCheck>();
    }

    [Token(Token = "0x6018583")]
    [Address(RVA = "0x26DD4B0", Offset = "0x26DD4B0", VA = "0x26DD4B0")]
    public static void StartPersonalEmblemCheck(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018584")]
    [Address(RVA = "0x26DD440", Offset = "0x26DD440", VA = "0x26DD440")]
    public static void AddCheckedContent(
      FlatBufferBuilder builder,
      VectorOffset checkedContentOffset)
    {
    }

    [Token(Token = "0x6018585")]
    [Address(RVA = "0x26DD4C8", Offset = "0x26DD4C8", VA = "0x26DD4C8")]
    public static VectorOffset CreateCheckedContentVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018586")]
    [Address(RVA = "0x26DD570", Offset = "0x26DD570", VA = "0x26DD570")]
    public static VectorOffset CreateCheckedContentVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018587")]
    [Address(RVA = "0x26DD5F8", Offset = "0x26DD5F8", VA = "0x26DD5F8")]
    public static void StartCheckedContentVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018588")]
    [Address(RVA = "0x26DD460", Offset = "0x26DD460", VA = "0x26DD460")]
    public static Offset<PersonalEmblemCheck> EndPersonalEmblemCheck(FlatBufferBuilder builder)
    {
      return new Offset<PersonalEmblemCheck>();
    }

    [Token(Token = "0x6018589")]
    [Address(RVA = "0x26DD618", Offset = "0x26DD618", VA = "0x26DD618")]
    public static void FinishPersonalEmblemCheckBuffer(
      FlatBufferBuilder builder,
      Offset<PersonalEmblemCheck> offset)
    {
    }

    [Token(Token = "0x601858A")]
    [Address(RVA = "0x26DD674", Offset = "0x26DD674", VA = "0x26DD674")]
    public static void FinishSizePrefixedPersonalEmblemCheckBuffer(
      FlatBufferBuilder builder,
      Offset<PersonalEmblemCheck> offset)
    {
    }
  }
}
