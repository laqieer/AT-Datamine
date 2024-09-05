// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ArmouryGrid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C66")]
  public struct ArmouryGrid : IFlatbufferObject
  {
    [Token(Token = "0x4010BC5")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004D5F")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017C16"), Address(RVA = "0x37B6BEC", Offset = "0x37B6BEC", VA = "0x37B6BEC", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017C17")]
    [Address(RVA = "0x37B6BF4", Offset = "0x37B6BF4", VA = "0x37B6BF4")]
    public static ArmouryGrid GetRootAsArmouryGrid(ByteBuffer _bb) => new ArmouryGrid();

    [Token(Token = "0x6017C18")]
    [Address(RVA = "0x37B6C00", Offset = "0x37B6C00", VA = "0x37B6C00")]
    public static ArmouryGrid GetRootAsArmouryGrid(ByteBuffer _bb, ArmouryGrid obj)
    {
      return new ArmouryGrid();
    }

    [Token(Token = "0x6017C19")]
    [Address(RVA = "0x37B6C5C", Offset = "0x37B6C5C", VA = "0x37B6C5C")]
    public static bool ArmouryGridBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6017C1A")]
    [Address(RVA = "0x37B6CA8", Offset = "0x37B6CA8", VA = "0x37B6CA8", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017C1B")]
    [Address(RVA = "0x37B6C44", Offset = "0x37B6C44", VA = "0x37B6C44")]
    public ArmouryGrid __assign(int _i, ByteBuffer _bb) => new ArmouryGrid();

    [Token(Token = "0x17004D60")]
    public bool IsStyle
    {
      [Token(Token = "0x6017C1C"), Address(RVA = "0x37B6CB4", Offset = "0x37B6CB4", VA = "0x37B6CB4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004D61")]
    public bool IsMindEquipment
    {
      [Token(Token = "0x6017C1D"), Address(RVA = "0x37B6CFC", Offset = "0x37B6CFC", VA = "0x37B6CFC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6017C1E")]
    [Address(RVA = "0x37B6D44", Offset = "0x37B6D44", VA = "0x37B6D44")]
    public static Offset<ArmouryGrid> CreateArmouryGrid(
      FlatBufferBuilder builder,
      bool is_style = false,
      bool is_mind_equipment = false)
    {
      return new Offset<ArmouryGrid>();
    }

    [Token(Token = "0x6017C1F")]
    [Address(RVA = "0x37B6E2C", Offset = "0x37B6E2C", VA = "0x37B6E2C")]
    public static void StartArmouryGrid(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017C20")]
    [Address(RVA = "0x37B6DBC", Offset = "0x37B6DBC", VA = "0x37B6DBC")]
    public static void AddIsStyle(FlatBufferBuilder builder, bool isStyle)
    {
    }

    [Token(Token = "0x6017C21")]
    [Address(RVA = "0x37B6D9C", Offset = "0x37B6D9C", VA = "0x37B6D9C")]
    public static void AddIsMindEquipment(FlatBufferBuilder builder, bool isMindEquipment)
    {
    }

    [Token(Token = "0x6017C22")]
    [Address(RVA = "0x37B6DDC", Offset = "0x37B6DDC", VA = "0x37B6DDC")]
    public static Offset<ArmouryGrid> EndArmouryGrid(FlatBufferBuilder builder)
    {
      return new Offset<ArmouryGrid>();
    }

    [Token(Token = "0x6017C23")]
    [Address(RVA = "0x37B6E44", Offset = "0x37B6E44", VA = "0x37B6E44")]
    public static void FinishArmouryGridBuffer(
      FlatBufferBuilder builder,
      Offset<ArmouryGrid> offset)
    {
    }

    [Token(Token = "0x6017C24")]
    [Address(RVA = "0x37B6EA0", Offset = "0x37B6EA0", VA = "0x37B6EA0")]
    public static void FinishSizePrefixedArmouryGridBuffer(
      FlatBufferBuilder builder,
      Offset<ArmouryGrid> offset)
    {
    }
  }
}
