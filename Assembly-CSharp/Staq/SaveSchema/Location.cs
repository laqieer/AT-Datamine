// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.Location
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CC2")]
  public struct Location : IFlatbufferObject
  {
    [Token(Token = "0x4010C20")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F6C")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60184A9"), Address(RVA = "0x26D9D3C", Offset = "0x26D9D3C", VA = "0x26D9D3C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60184AA")]
    [Address(RVA = "0x26D9D44", Offset = "0x26D9D44", VA = "0x26D9D44")]
    public static Location GetRootAsLocation(ByteBuffer _bb) => new Location();

    [Token(Token = "0x60184AB")]
    [Address(RVA = "0x26D9D50", Offset = "0x26D9D50", VA = "0x26D9D50")]
    public static Location GetRootAsLocation(ByteBuffer _bb, Location obj) => new Location();

    [Token(Token = "0x60184AC")]
    [Address(RVA = "0x26D9DAC", Offset = "0x26D9DAC", VA = "0x26D9DAC")]
    public static bool LocationBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60184AD")]
    [Address(RVA = "0x26D9DF8", Offset = "0x26D9DF8", VA = "0x26D9DF8", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60184AE")]
    [Address(RVA = "0x26D9D94", Offset = "0x26D9D94", VA = "0x26D9D94")]
    public Location __assign(int _i, ByteBuffer _bb) => new Location();

    [Token(Token = "0x17004F6D")]
    public string Region
    {
      [Token(Token = "0x60184AF"), Address(RVA = "0x26D9E04", Offset = "0x26D9E04", VA = "0x26D9E04")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60184B0")]
    [Address(RVA = "0x26D9E40", Offset = "0x26D9E40", VA = "0x26D9E40")]
    public ArraySegment<byte>? GetRegionBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60184B1")]
    [Address(RVA = "0x26D9E78", Offset = "0x26D9E78", VA = "0x26D9E78")]
    public byte[] GetRegionArray() => (byte[]) null;

    [Token(Token = "0x17004F6E")]
    public string Language
    {
      [Token(Token = "0x60184B2"), Address(RVA = "0x26D9EC4", Offset = "0x26D9EC4", VA = "0x26D9EC4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60184B3")]
    [Address(RVA = "0x26D9F00", Offset = "0x26D9F00", VA = "0x26D9F00")]
    public ArraySegment<byte>? GetLanguageBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60184B4")]
    [Address(RVA = "0x26D9F38", Offset = "0x26D9F38", VA = "0x26D9F38")]
    public byte[] GetLanguageArray() => (byte[]) null;

    [Token(Token = "0x60184B5")]
    [Address(RVA = "0x26D9F84", Offset = "0x26D9F84", VA = "0x26D9F84")]
    public static Offset<Location> CreateLocation(
      FlatBufferBuilder builder,
      StringOffset regionOffset = default (StringOffset),
      StringOffset languageOffset = default (StringOffset))
    {
      return new Offset<Location>();
    }

    [Token(Token = "0x60184B6")]
    [Address(RVA = "0x26DA06C", Offset = "0x26DA06C", VA = "0x26DA06C")]
    public static void StartLocation(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60184B7")]
    [Address(RVA = "0x26D9FFC", Offset = "0x26D9FFC", VA = "0x26D9FFC")]
    public static void AddRegion(FlatBufferBuilder builder, StringOffset regionOffset)
    {
    }

    [Token(Token = "0x60184B8")]
    [Address(RVA = "0x26D9FDC", Offset = "0x26D9FDC", VA = "0x26D9FDC")]
    public static void AddLanguage(FlatBufferBuilder builder, StringOffset languageOffset)
    {
    }

    [Token(Token = "0x60184B9")]
    [Address(RVA = "0x26DA01C", Offset = "0x26DA01C", VA = "0x26DA01C")]
    public static Offset<Location> EndLocation(FlatBufferBuilder builder) => new Offset<Location>();

    [Token(Token = "0x60184BA")]
    [Address(RVA = "0x26DA084", Offset = "0x26DA084", VA = "0x26DA084")]
    public static void FinishLocationBuffer(FlatBufferBuilder builder, Offset<Location> offset)
    {
    }

    [Token(Token = "0x60184BB")]
    [Address(RVA = "0x26DA0E0", Offset = "0x26DA0E0", VA = "0x26DA0E0")]
    public static void FinishSizePrefixedLocationBuffer(
      FlatBufferBuilder builder,
      Offset<Location> offset)
    {
    }
  }
}
