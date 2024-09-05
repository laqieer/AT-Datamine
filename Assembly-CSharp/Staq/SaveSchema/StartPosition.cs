// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.StartPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CAD")]
  public struct StartPosition : IFlatbufferObject
  {
    [Token(Token = "0x4010C0B")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F2E")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601834E"), Address(RVA = "0x26D4C70", Offset = "0x26D4C70", VA = "0x26D4C70", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601834F")]
    [Address(RVA = "0x26D4C78", Offset = "0x26D4C78", VA = "0x26D4C78")]
    public static StartPosition GetRootAsStartPosition(ByteBuffer _bb) => new StartPosition();

    [Token(Token = "0x6018350")]
    [Address(RVA = "0x26D4C84", Offset = "0x26D4C84", VA = "0x26D4C84")]
    public static StartPosition GetRootAsStartPosition(ByteBuffer _bb, StartPosition obj)
    {
      return new StartPosition();
    }

    [Token(Token = "0x6018351")]
    [Address(RVA = "0x26D4CE0", Offset = "0x26D4CE0", VA = "0x26D4CE0", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018352")]
    [Address(RVA = "0x26D4CC8", Offset = "0x26D4CC8", VA = "0x26D4CC8")]
    public StartPosition __assign(int _i, ByteBuffer _bb) => new StartPosition();

    [Token(Token = "0x17004F2F")]
    public int ChapterId
    {
      [Token(Token = "0x6018353"), Address(RVA = "0x26D4CEC", Offset = "0x26D4CEC", VA = "0x26D4CEC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F30")]
    public int SequenceId
    {
      [Token(Token = "0x6018354"), Address(RVA = "0x26D4D30", Offset = "0x26D4D30", VA = "0x26D4D30")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F31")]
    public int AreaId
    {
      [Token(Token = "0x6018355"), Address(RVA = "0x26D4D74", Offset = "0x26D4D74", VA = "0x26D4D74")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F32")]
    public string AnchorName
    {
      [Token(Token = "0x6018356"), Address(RVA = "0x26D4DB8", Offset = "0x26D4DB8", VA = "0x26D4DB8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018357")]
    [Address(RVA = "0x26D4DF4", Offset = "0x26D4DF4", VA = "0x26D4DF4")]
    public ArraySegment<byte>? GetAnchorNameBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018358")]
    [Address(RVA = "0x26D4E2C", Offset = "0x26D4E2C", VA = "0x26D4E2C")]
    public byte[] GetAnchorNameArray() => (byte[]) null;

    [Token(Token = "0x17004F33")]
    public Vec3? OffsetPos
    {
      [Token(Token = "0x6018359"), Address(RVA = "0x26D4E78", Offset = "0x26D4E78", VA = "0x26D4E78")] get
      {
        return new Vec3?();
      }
    }

    [Token(Token = "0x17004F34")]
    public float RotationY
    {
      [Token(Token = "0x601835A"), Address(RVA = "0x26D4F28", Offset = "0x26D4F28", VA = "0x26D4F28")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x601835B")]
    [Address(RVA = "0x26D4F70", Offset = "0x26D4F70", VA = "0x26D4F70")]
    public static void StartStartPosition(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601835C")]
    [Address(RVA = "0x26D4F88", Offset = "0x26D4F88", VA = "0x26D4F88")]
    public static void AddChapterId(FlatBufferBuilder builder, int chapterId)
    {
    }

    [Token(Token = "0x601835D")]
    [Address(RVA = "0x26D4FA8", Offset = "0x26D4FA8", VA = "0x26D4FA8")]
    public static void AddSequenceId(FlatBufferBuilder builder, int sequenceId)
    {
    }

    [Token(Token = "0x601835E")]
    [Address(RVA = "0x26D4FC8", Offset = "0x26D4FC8", VA = "0x26D4FC8")]
    public static void AddAreaId(FlatBufferBuilder builder, int areaId)
    {
    }

    [Token(Token = "0x601835F")]
    [Address(RVA = "0x26D4FE8", Offset = "0x26D4FE8", VA = "0x26D4FE8")]
    public static void AddAnchorName(FlatBufferBuilder builder, StringOffset anchorNameOffset)
    {
    }

    [Token(Token = "0x6018360")]
    [Address(RVA = "0x26D5008", Offset = "0x26D5008", VA = "0x26D5008")]
    public static void AddOffsetPos(FlatBufferBuilder builder, Offset<Vec3> offsetPosOffset)
    {
    }

    [Token(Token = "0x6018361")]
    [Address(RVA = "0x26D5028", Offset = "0x26D5028", VA = "0x26D5028")]
    public static void AddRotationY(FlatBufferBuilder builder, float rotationY)
    {
    }

    [Token(Token = "0x6018362")]
    [Address(RVA = "0x26D5044", Offset = "0x26D5044", VA = "0x26D5044")]
    public static Offset<StartPosition> EndStartPosition(FlatBufferBuilder builder)
    {
      return new Offset<StartPosition>();
    }
  }
}
