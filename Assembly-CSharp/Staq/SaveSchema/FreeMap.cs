// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.FreeMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CB1")]
  public struct FreeMap : IFlatbufferObject
  {
    [Token(Token = "0x4010C0F")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F3C")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018383"), Address(RVA = "0x26D55B8", Offset = "0x26D55B8", VA = "0x26D55B8", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018384")]
    [Address(RVA = "0x26D55C0", Offset = "0x26D55C0", VA = "0x26D55C0")]
    public static FreeMap GetRootAsFreeMap(ByteBuffer _bb) => new FreeMap();

    [Token(Token = "0x6018385")]
    [Address(RVA = "0x26D55CC", Offset = "0x26D55CC", VA = "0x26D55CC")]
    public static FreeMap GetRootAsFreeMap(ByteBuffer _bb, FreeMap obj) => new FreeMap();

    [Token(Token = "0x6018386")]
    [Address(RVA = "0x26D5628", Offset = "0x26D5628", VA = "0x26D5628")]
    public static bool FreeMapBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018387")]
    [Address(RVA = "0x26D5674", Offset = "0x26D5674", VA = "0x26D5674", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018388")]
    [Address(RVA = "0x26D5610", Offset = "0x26D5610", VA = "0x26D5610")]
    public FreeMap __assign(int _i, ByteBuffer _bb) => new FreeMap();

    [Token(Token = "0x17004F3D")]
    public string AppVersion
    {
      [Token(Token = "0x6018389"), Address(RVA = "0x26D5680", Offset = "0x26D5680", VA = "0x26D5680")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601838A")]
    [Address(RVA = "0x26D56BC", Offset = "0x26D56BC", VA = "0x26D56BC")]
    public ArraySegment<byte>? GetAppVersionBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x601838B")]
    [Address(RVA = "0x26D56F4", Offset = "0x26D56F4", VA = "0x26D56F4")]
    public byte[] GetAppVersionArray() => (byte[]) null;

    [Token(Token = "0x601838C")]
    [Address(RVA = "0x26D5740", Offset = "0x26D5740", VA = "0x26D5740")]
    public StartPosition? Positions(int j) => new StartPosition?();

    [Token(Token = "0x17004F3E")]
    public int PositionsLength
    {
      [Token(Token = "0x601838D"), Address(RVA = "0x26D57F4", Offset = "0x26D57F4", VA = "0x26D57F4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601838E")]
    [Address(RVA = "0x26D5828", Offset = "0x26D5828", VA = "0x26D5828")]
    public AreaIntroduction? Introductions(int j) => new AreaIntroduction?();

    [Token(Token = "0x17004F3F")]
    public int IntroductionsLength
    {
      [Token(Token = "0x601838F"), Address(RVA = "0x26D58DC", Offset = "0x26D58DC", VA = "0x26D58DC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018390")]
    [Address(RVA = "0x26D5910", Offset = "0x26D5910", VA = "0x26D5910")]
    public AlreadyRead? ReadTalkadv(int j) => new AlreadyRead?();

    [Token(Token = "0x17004F40")]
    public int ReadTalkadvLength
    {
      [Token(Token = "0x6018391"), Address(RVA = "0x26D59C4", Offset = "0x26D59C4", VA = "0x26D59C4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018392")]
    [Address(RVA = "0x26D59F8", Offset = "0x26D59F8", VA = "0x26D59F8")]
    public AlreadyRead? ReadFlavor(int j) => new AlreadyRead?();

    [Token(Token = "0x17004F41")]
    public int ReadFlavorLength
    {
      [Token(Token = "0x6018393"), Address(RVA = "0x26D5AAC", Offset = "0x26D5AAC", VA = "0x26D5AAC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018394")]
    [Address(RVA = "0x26D5AE0", Offset = "0x26D5AE0", VA = "0x26D5AE0")]
    public TemporaryEnteredArea? TemporaryEnteredAreaStocks(int j) => new TemporaryEnteredArea?();

    [Token(Token = "0x17004F42")]
    public int TemporaryEnteredAreaStocksLength
    {
      [Token(Token = "0x6018395"), Address(RVA = "0x26D5B94", Offset = "0x26D5B94", VA = "0x26D5B94")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018396")]
    [Address(RVA = "0x26D5BC8", Offset = "0x26D5BC8", VA = "0x26D5BC8")]
    public static Offset<FreeMap> CreateFreeMap(
      FlatBufferBuilder builder,
      StringOffset app_versionOffset = default (StringOffset),
      VectorOffset positionsOffset = default (VectorOffset),
      VectorOffset introductionsOffset = default (VectorOffset),
      VectorOffset read_talkadvOffset = default (VectorOffset),
      VectorOffset read_flavorOffset = default (VectorOffset),
      VectorOffset temporary_entered_area_stocksOffset = default (VectorOffset))
    {
      return new Offset<FreeMap>();
    }

    [Token(Token = "0x6018397")]
    [Address(RVA = "0x26D5D80", Offset = "0x26D5D80", VA = "0x26D5D80")]
    public static void StartFreeMap(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018398")]
    [Address(RVA = "0x26D5D10", Offset = "0x26D5D10", VA = "0x26D5D10")]
    public static void AddAppVersion(FlatBufferBuilder builder, StringOffset appVersionOffset)
    {
    }

    [Token(Token = "0x6018399")]
    [Address(RVA = "0x26D5CF0", Offset = "0x26D5CF0", VA = "0x26D5CF0")]
    public static void AddPositions(FlatBufferBuilder builder, VectorOffset positionsOffset)
    {
    }

    [Token(Token = "0x601839A")]
    [Address(RVA = "0x26D5D98", Offset = "0x26D5D98", VA = "0x26D5D98")]
    public static VectorOffset CreatePositionsVector(
      FlatBufferBuilder builder,
      Offset<StartPosition>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601839B")]
    [Address(RVA = "0x26D5E40", Offset = "0x26D5E40", VA = "0x26D5E40")]
    public static VectorOffset CreatePositionsVectorBlock(
      FlatBufferBuilder builder,
      Offset<StartPosition>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601839C")]
    [Address(RVA = "0x26D5EC8", Offset = "0x26D5EC8", VA = "0x26D5EC8")]
    public static void StartPositionsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601839D")]
    [Address(RVA = "0x26D5CD0", Offset = "0x26D5CD0", VA = "0x26D5CD0")]
    public static void AddIntroductions(FlatBufferBuilder builder, VectorOffset introductionsOffset)
    {
    }

    [Token(Token = "0x601839E")]
    [Address(RVA = "0x26D5EE8", Offset = "0x26D5EE8", VA = "0x26D5EE8")]
    public static VectorOffset CreateIntroductionsVector(
      FlatBufferBuilder builder,
      Offset<AreaIntroduction>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601839F")]
    [Address(RVA = "0x26D5F90", Offset = "0x26D5F90", VA = "0x26D5F90")]
    public static VectorOffset CreateIntroductionsVectorBlock(
      FlatBufferBuilder builder,
      Offset<AreaIntroduction>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60183A0")]
    [Address(RVA = "0x26D6018", Offset = "0x26D6018", VA = "0x26D6018")]
    public static void StartIntroductionsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60183A1")]
    [Address(RVA = "0x26D5CB0", Offset = "0x26D5CB0", VA = "0x26D5CB0")]
    public static void AddReadTalkadv(FlatBufferBuilder builder, VectorOffset readTalkadvOffset)
    {
    }

    [Token(Token = "0x60183A2")]
    [Address(RVA = "0x26D6038", Offset = "0x26D6038", VA = "0x26D6038")]
    public static VectorOffset CreateReadTalkadvVector(
      FlatBufferBuilder builder,
      Offset<AlreadyRead>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60183A3")]
    [Address(RVA = "0x26D60E0", Offset = "0x26D60E0", VA = "0x26D60E0")]
    public static VectorOffset CreateReadTalkadvVectorBlock(
      FlatBufferBuilder builder,
      Offset<AlreadyRead>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60183A4")]
    [Address(RVA = "0x26D6168", Offset = "0x26D6168", VA = "0x26D6168")]
    public static void StartReadTalkadvVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60183A5")]
    [Address(RVA = "0x26D5C90", Offset = "0x26D5C90", VA = "0x26D5C90")]
    public static void AddReadFlavor(FlatBufferBuilder builder, VectorOffset readFlavorOffset)
    {
    }

    [Token(Token = "0x60183A6")]
    [Address(RVA = "0x26D6188", Offset = "0x26D6188", VA = "0x26D6188")]
    public static VectorOffset CreateReadFlavorVector(
      FlatBufferBuilder builder,
      Offset<AlreadyRead>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60183A7")]
    [Address(RVA = "0x26D6230", Offset = "0x26D6230", VA = "0x26D6230")]
    public static VectorOffset CreateReadFlavorVectorBlock(
      FlatBufferBuilder builder,
      Offset<AlreadyRead>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60183A8")]
    [Address(RVA = "0x26D62B8", Offset = "0x26D62B8", VA = "0x26D62B8")]
    public static void StartReadFlavorVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60183A9")]
    [Address(RVA = "0x26D5C70", Offset = "0x26D5C70", VA = "0x26D5C70")]
    public static void AddTemporaryEnteredAreaStocks(
      FlatBufferBuilder builder,
      VectorOffset temporaryEnteredAreaStocksOffset)
    {
    }

    [Token(Token = "0x60183AA")]
    [Address(RVA = "0x26D62D8", Offset = "0x26D62D8", VA = "0x26D62D8")]
    public static VectorOffset CreateTemporaryEnteredAreaStocksVector(
      FlatBufferBuilder builder,
      Offset<TemporaryEnteredArea>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60183AB")]
    [Address(RVA = "0x26D6380", Offset = "0x26D6380", VA = "0x26D6380")]
    public static VectorOffset CreateTemporaryEnteredAreaStocksVectorBlock(
      FlatBufferBuilder builder,
      Offset<TemporaryEnteredArea>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60183AC")]
    [Address(RVA = "0x26D6408", Offset = "0x26D6408", VA = "0x26D6408")]
    public static void StartTemporaryEnteredAreaStocksVector(
      FlatBufferBuilder builder,
      int numElems)
    {
    }

    [Token(Token = "0x60183AD")]
    [Address(RVA = "0x26D5D30", Offset = "0x26D5D30", VA = "0x26D5D30")]
    public static Offset<FreeMap> EndFreeMap(FlatBufferBuilder builder) => new Offset<FreeMap>();

    [Token(Token = "0x60183AE")]
    [Address(RVA = "0x26D6428", Offset = "0x26D6428", VA = "0x26D6428")]
    public static void FinishFreeMapBuffer(FlatBufferBuilder builder, Offset<FreeMap> offset)
    {
    }

    [Token(Token = "0x60183AF")]
    [Address(RVA = "0x26D6484", Offset = "0x26D6484", VA = "0x26D6484")]
    public static void FinishSizePrefixedFreeMapBuffer(
      FlatBufferBuilder builder,
      Offset<FreeMap> offset)
    {
    }
  }
}
