// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.CharacterSupportData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C87")]
  public struct CharacterSupportData : IFlatbufferObject
  {
    [Token(Token = "0x4010BE6")]
    [FieldOffset(Offset = "0x0")]
    private Struct __p;

    [Token(Token = "0x17004E5F")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018024"), Address(RVA = "0x3B1B370", Offset = "0x3B1B370", VA = "0x3B1B370", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018025")]
    [Address(RVA = "0x3B1B378", Offset = "0x3B1B378", VA = "0x3B1B378", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018026")]
    [Address(RVA = "0x3B1A6FC", Offset = "0x3B1A6FC", VA = "0x3B1A6FC")]
    public CharacterSupportData __assign(int _i, ByteBuffer _bb) => new CharacterSupportData();

    [Token(Token = "0x17004E60")]
    public int Chara1
    {
      [Token(Token = "0x6018027"), Address(RVA = "0x3B1B384", Offset = "0x3B1B384", VA = "0x3B1B384")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E61")]
    public int Chara2
    {
      [Token(Token = "0x6018028"), Address(RVA = "0x3B1B3A8", Offset = "0x3B1B3A8", VA = "0x3B1B3A8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E62")]
    public int Rank
    {
      [Token(Token = "0x6018029"), Address(RVA = "0x3B1B3D0", Offset = "0x3B1B3D0", VA = "0x3B1B3D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E63")]
    public int Current
    {
      [Token(Token = "0x601802A"), Address(RVA = "0x3B1B3F8", Offset = "0x3B1B3F8", VA = "0x3B1B3F8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E64")]
    public int Achieved
    {
      [Token(Token = "0x601802B"), Address(RVA = "0x3B1B420", Offset = "0x3B1B420", VA = "0x3B1B420")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601802C")]
    [Address(RVA = "0x3B1B448", Offset = "0x3B1B448", VA = "0x3B1B448")]
    public static Offset<CharacterSupportData> CreateCharacterSupportData(
      FlatBufferBuilder builder,
      int Chara1,
      int Chara2,
      int Rank,
      int Current,
      int Achieved)
    {
      return new Offset<CharacterSupportData>();
    }
  }
}
