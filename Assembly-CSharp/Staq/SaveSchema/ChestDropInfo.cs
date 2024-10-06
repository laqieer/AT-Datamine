// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ChestDropInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C7E")]
  public struct ChestDropInfo : IFlatbufferObject
  {
    [Token(Token = "0x4010BDD")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E00")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017EBC"), Address(RVA = "0x37C1A00", Offset = "0x37C1A00", VA = "0x37C1A00", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017EBD")]
    [Address(RVA = "0x37C1A08", Offset = "0x37C1A08", VA = "0x37C1A08")]
    public static ChestDropInfo GetRootAsChestDropInfo(ByteBuffer _bb) => new ChestDropInfo();

    [Token(Token = "0x6017EBE")]
    [Address(RVA = "0x37C1A14", Offset = "0x37C1A14", VA = "0x37C1A14")]
    public static ChestDropInfo GetRootAsChestDropInfo(ByteBuffer _bb, ChestDropInfo obj)
    {
      return new ChestDropInfo();
    }

    [Token(Token = "0x6017EBF")]
    [Address(RVA = "0x37C1A70", Offset = "0x37C1A70", VA = "0x37C1A70", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017EC0")]
    [Address(RVA = "0x37C1A58", Offset = "0x37C1A58", VA = "0x37C1A58")]
    public ChestDropInfo __assign(int _i, ByteBuffer _bb) => new ChestDropInfo();

    [Token(Token = "0x17004E01")]
    public int PlacementId
    {
      [Token(Token = "0x6017EC1"), Address(RVA = "0x37C1A7C", Offset = "0x37C1A7C", VA = "0x37C1A7C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E02")]
    public int RewordTypeId
    {
      [Token(Token = "0x6017EC2"), Address(RVA = "0x37C1AC0", Offset = "0x37C1AC0", VA = "0x37C1AC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017EC3")]
    [Address(RVA = "0x37C1B04", Offset = "0x37C1B04", VA = "0x37C1B04")]
    public static Offset<ChestDropInfo> CreateChestDropInfo(
      FlatBufferBuilder builder,
      int placementId = 0,
      int rewordTypeId = 0)
    {
      return new Offset<ChestDropInfo>();
    }

    [Token(Token = "0x6017EC4")]
    [Address(RVA = "0x37C1BEC", Offset = "0x37C1BEC", VA = "0x37C1BEC")]
    public static void StartChestDropInfo(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017EC5")]
    [Address(RVA = "0x37C1B7C", Offset = "0x37C1B7C", VA = "0x37C1B7C")]
    public static void AddPlacementId(FlatBufferBuilder builder, int placementId)
    {
    }

    [Token(Token = "0x6017EC6")]
    [Address(RVA = "0x37C1B5C", Offset = "0x37C1B5C", VA = "0x37C1B5C")]
    public static void AddRewordTypeId(FlatBufferBuilder builder, int rewordTypeId)
    {
    }

    [Token(Token = "0x6017EC7")]
    [Address(RVA = "0x37C1B9C", Offset = "0x37C1B9C", VA = "0x37C1B9C")]
    public static Offset<ChestDropInfo> EndChestDropInfo(FlatBufferBuilder builder)
    {
      return new Offset<ChestDropInfo>();
    }
  }
}
