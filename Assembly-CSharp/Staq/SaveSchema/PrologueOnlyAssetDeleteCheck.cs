// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.PrologueOnlyAssetDeleteCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CCF")]
  public struct PrologueOnlyAssetDeleteCheck : IFlatbufferObject
  {
    [Token(Token = "0x4010C2D")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FA6")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60185DE"), Address(RVA = "0x26DE944", Offset = "0x26DE944", VA = "0x26DE944", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60185DF")]
    [Address(RVA = "0x26DE94C", Offset = "0x26DE94C", VA = "0x26DE94C")]
    public static PrologueOnlyAssetDeleteCheck GetRootAsPrologueOnlyAssetDeleteCheck(ByteBuffer _bb)
    {
      return new PrologueOnlyAssetDeleteCheck();
    }

    [Token(Token = "0x60185E0")]
    [Address(RVA = "0x26DE958", Offset = "0x26DE958", VA = "0x26DE958")]
    public static PrologueOnlyAssetDeleteCheck GetRootAsPrologueOnlyAssetDeleteCheck(
      ByteBuffer _bb,
      PrologueOnlyAssetDeleteCheck obj)
    {
      return new PrologueOnlyAssetDeleteCheck();
    }

    [Token(Token = "0x60185E1")]
    [Address(RVA = "0x26DE9B4", Offset = "0x26DE9B4", VA = "0x26DE9B4")]
    public static bool PrologueOnlyAssetDeleteCheckBufferHasIdentifier(ByteBuffer _bb)
    {
      return new bool();
    }

    [Token(Token = "0x60185E2")]
    [Address(RVA = "0x26DEA00", Offset = "0x26DEA00", VA = "0x26DEA00", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60185E3")]
    [Address(RVA = "0x26DE99C", Offset = "0x26DE99C", VA = "0x26DE99C")]
    public PrologueOnlyAssetDeleteCheck __assign(int _i, ByteBuffer _bb)
    {
      return new PrologueOnlyAssetDeleteCheck();
    }

    [Token(Token = "0x17004FA7")]
    public bool DeleteChecked
    {
      [Token(Token = "0x60185E4"), Address(RVA = "0x26DEA0C", Offset = "0x26DEA0C", VA = "0x26DEA0C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004FA8")]
    public bool Deleted
    {
      [Token(Token = "0x60185E5"), Address(RVA = "0x26DEA54", Offset = "0x26DEA54", VA = "0x26DEA54")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60185E6")]
    [Address(RVA = "0x26DEA9C", Offset = "0x26DEA9C", VA = "0x26DEA9C")]
    public static Offset<PrologueOnlyAssetDeleteCheck> CreatePrologueOnlyAssetDeleteCheck(
      FlatBufferBuilder builder,
      bool delete_checked = false,
      bool deleted = false)
    {
      return new Offset<PrologueOnlyAssetDeleteCheck>();
    }

    [Token(Token = "0x60185E7")]
    [Address(RVA = "0x26DEB84", Offset = "0x26DEB84", VA = "0x26DEB84")]
    public static void StartPrologueOnlyAssetDeleteCheck(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60185E8")]
    [Address(RVA = "0x26DEB14", Offset = "0x26DEB14", VA = "0x26DEB14")]
    public static void AddDeleteChecked(FlatBufferBuilder builder, bool deleteChecked)
    {
    }

    [Token(Token = "0x60185E9")]
    [Address(RVA = "0x26DEAF4", Offset = "0x26DEAF4", VA = "0x26DEAF4")]
    public static void AddDeleted(FlatBufferBuilder builder, bool deleted)
    {
    }

    [Token(Token = "0x60185EA")]
    [Address(RVA = "0x26DEB34", Offset = "0x26DEB34", VA = "0x26DEB34")]
    public static Offset<PrologueOnlyAssetDeleteCheck> EndPrologueOnlyAssetDeleteCheck(
      FlatBufferBuilder builder)
    {
      return new Offset<PrologueOnlyAssetDeleteCheck>();
    }

    [Token(Token = "0x60185EB")]
    [Address(RVA = "0x26DEB9C", Offset = "0x26DEB9C", VA = "0x26DEB9C")]
    public static void FinishPrologueOnlyAssetDeleteCheckBuffer(
      FlatBufferBuilder builder,
      Offset<PrologueOnlyAssetDeleteCheck> offset)
    {
    }

    [Token(Token = "0x60185EC")]
    [Address(RVA = "0x26DEBF8", Offset = "0x26DEBF8", VA = "0x26DEBF8")]
    public static void FinishSizePrefixedPrologueOnlyAssetDeleteCheckBuffer(
      FlatBufferBuilder builder,
      Offset<PrologueOnlyAssetDeleteCheck> offset)
    {
    }
  }
}
