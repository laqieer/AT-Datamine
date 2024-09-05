// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.IntroChapter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CBE")]
  public struct IntroChapter : IFlatbufferObject
  {
    [Token(Token = "0x4010C1C")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F61")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018462"), Address(RVA = "0x26D8C50", Offset = "0x26D8C50", VA = "0x26D8C50", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018463")]
    [Address(RVA = "0x26D8C58", Offset = "0x26D8C58", VA = "0x26D8C58")]
    public static IntroChapter GetRootAsIntroChapter(ByteBuffer _bb) => new IntroChapter();

    [Token(Token = "0x6018464")]
    [Address(RVA = "0x26D8C64", Offset = "0x26D8C64", VA = "0x26D8C64")]
    public static IntroChapter GetRootAsIntroChapter(ByteBuffer _bb, IntroChapter obj)
    {
      return new IntroChapter();
    }

    [Token(Token = "0x6018465")]
    [Address(RVA = "0x26D8CC0", Offset = "0x26D8CC0", VA = "0x26D8CC0")]
    public static bool IntroChapterBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018466")]
    [Address(RVA = "0x26D8D0C", Offset = "0x26D8D0C", VA = "0x26D8D0C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018467")]
    [Address(RVA = "0x26D8CA8", Offset = "0x26D8CA8", VA = "0x26D8CA8")]
    public IntroChapter __assign(int _i, ByteBuffer _bb) => new IntroChapter();

    [Token(Token = "0x17004F62")]
    public bool IsAgreedTermsOfService
    {
      [Token(Token = "0x6018468"), Address(RVA = "0x26D8D18", Offset = "0x26D8D18", VA = "0x26D8D18")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F63")]
    public int ProgressValue
    {
      [Token(Token = "0x6018469"), Address(RVA = "0x26D8D60", Offset = "0x26D8D60", VA = "0x26D8D60")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601846A")]
    [Address(RVA = "0x26D8DA4", Offset = "0x26D8DA4", VA = "0x26D8DA4")]
    public static Offset<IntroChapter> CreateIntroChapter(
      FlatBufferBuilder builder,
      bool is_agreed_terms_of_service = false,
      int progress_value = 0)
    {
      return new Offset<IntroChapter>();
    }

    [Token(Token = "0x601846B")]
    [Address(RVA = "0x26D8E8C", Offset = "0x26D8E8C", VA = "0x26D8E8C")]
    public static void StartIntroChapter(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601846C")]
    [Address(RVA = "0x26D8E1C", Offset = "0x26D8E1C", VA = "0x26D8E1C")]
    public static void AddIsAgreedTermsOfService(
      FlatBufferBuilder builder,
      bool isAgreedTermsOfService)
    {
    }

    [Token(Token = "0x601846D")]
    [Address(RVA = "0x26D8DFC", Offset = "0x26D8DFC", VA = "0x26D8DFC")]
    public static void AddProgressValue(FlatBufferBuilder builder, int progressValue)
    {
    }

    [Token(Token = "0x601846E")]
    [Address(RVA = "0x26D8E3C", Offset = "0x26D8E3C", VA = "0x26D8E3C")]
    public static Offset<IntroChapter> EndIntroChapter(FlatBufferBuilder builder)
    {
      return new Offset<IntroChapter>();
    }

    [Token(Token = "0x601846F")]
    [Address(RVA = "0x26D8EA4", Offset = "0x26D8EA4", VA = "0x26D8EA4")]
    public static void FinishIntroChapterBuffer(
      FlatBufferBuilder builder,
      Offset<IntroChapter> offset)
    {
    }

    [Token(Token = "0x6018470")]
    [Address(RVA = "0x26D8F00", Offset = "0x26D8F00", VA = "0x26D8F00")]
    public static void FinishSizePrefixedIntroChapterBuffer(
      FlatBufferBuilder builder,
      Offset<IntroChapter> offset)
    {
    }
  }
}
