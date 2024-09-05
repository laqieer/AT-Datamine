// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.MindEquipmentData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C71")]
  public struct MindEquipmentData : IFlatbufferObject
  {
    [Token(Token = "0x4010BD0")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DB7")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017D97"), Address(RVA = "0x37BD5DC", Offset = "0x37BD5DC", VA = "0x37BD5DC", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017D98")]
    [Address(RVA = "0x37BD5E4", Offset = "0x37BD5E4", VA = "0x37BD5E4")]
    public static MindEquipmentData GetRootAsMindEquipmentData(ByteBuffer _bb)
    {
      return new MindEquipmentData();
    }

    [Token(Token = "0x6017D99")]
    [Address(RVA = "0x37BD5F0", Offset = "0x37BD5F0", VA = "0x37BD5F0")]
    public static MindEquipmentData GetRootAsMindEquipmentData(
      ByteBuffer _bb,
      MindEquipmentData obj)
    {
      return new MindEquipmentData();
    }

    [Token(Token = "0x6017D9A")]
    [Address(RVA = "0x37BD634", Offset = "0x37BD634", VA = "0x37BD634", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017D9B")]
    [Address(RVA = "0x37B7BA8", Offset = "0x37B7BA8", VA = "0x37B7BA8")]
    public MindEquipmentData __assign(int _i, ByteBuffer _bb) => new MindEquipmentData();

    [Token(Token = "0x17004DB8")]
    public int Id
    {
      [Token(Token = "0x6017D9C"), Address(RVA = "0x37BD640", Offset = "0x37BD640", VA = "0x37BD640")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DB9")]
    public string UniqueId
    {
      [Token(Token = "0x6017D9D"), Address(RVA = "0x37BD684", Offset = "0x37BD684", VA = "0x37BD684")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017D9E")]
    [Address(RVA = "0x37BD6C0", Offset = "0x37BD6C0", VA = "0x37BD6C0")]
    public ArraySegment<byte>? GetUniqueIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017D9F")]
    [Address(RVA = "0x37BD6F8", Offset = "0x37BD6F8", VA = "0x37BD6F8")]
    public byte[] GetUniqueIdArray() => (byte[]) null;

    [Token(Token = "0x17004DBA")]
    public int MasterId
    {
      [Token(Token = "0x6017DA0"), Address(RVA = "0x37BD744", Offset = "0x37BD744", VA = "0x37BD744")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DBB")]
    public int Level
    {
      [Token(Token = "0x6017DA1"), Address(RVA = "0x37BD788", Offset = "0x37BD788", VA = "0x37BD788")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DBC")]
    public int LimitBreak
    {
      [Token(Token = "0x6017DA2"), Address(RVA = "0x37BD7CC", Offset = "0x37BD7CC", VA = "0x37BD7CC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017DA3")]
    [Address(RVA = "0x37BD810", Offset = "0x37BD810", VA = "0x37BD810")]
    public int Skills(int j) => new int();

    [Token(Token = "0x17004DBD")]
    public int SkillsLength
    {
      [Token(Token = "0x6017DA4"), Address(RVA = "0x37BD870", Offset = "0x37BD870", VA = "0x37BD870")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017DA5")]
    [Address(RVA = "0x37BD8A4", Offset = "0x37BD8A4", VA = "0x37BD8A4")]
    public ArraySegment<byte>? GetSkillsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017DA6")]
    [Address(RVA = "0x37BD8DC", Offset = "0x37BD8DC", VA = "0x37BD8DC")]
    public int[] GetSkillsArray() => (int[]) null;

    [Token(Token = "0x6017DA7")]
    [Address(RVA = "0x37BD928", Offset = "0x37BD928", VA = "0x37BD928")]
    public static Offset<MindEquipmentData> CreateMindEquipmentData(
      FlatBufferBuilder builder,
      int id = 0,
      StringOffset uniqueIdOffset = default (StringOffset),
      int masterId = 0,
      int level = 0,
      int limitBreak = 0,
      VectorOffset skillsOffset = default (VectorOffset))
    {
      return new Offset<MindEquipmentData>();
    }

    [Token(Token = "0x6017DA8")]
    [Address(RVA = "0x37BDAE0", Offset = "0x37BDAE0", VA = "0x37BDAE0")]
    public static void StartMindEquipmentData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017DA9")]
    [Address(RVA = "0x37BDA70", Offset = "0x37BDA70", VA = "0x37BDA70")]
    public static void AddId(FlatBufferBuilder builder, int id)
    {
    }

    [Token(Token = "0x6017DAA")]
    [Address(RVA = "0x37BDA50", Offset = "0x37BDA50", VA = "0x37BDA50")]
    public static void AddUniqueId(FlatBufferBuilder builder, StringOffset uniqueIdOffset)
    {
    }

    [Token(Token = "0x6017DAB")]
    [Address(RVA = "0x37BDA30", Offset = "0x37BDA30", VA = "0x37BDA30")]
    public static void AddMasterId(FlatBufferBuilder builder, int masterId)
    {
    }

    [Token(Token = "0x6017DAC")]
    [Address(RVA = "0x37BDA10", Offset = "0x37BDA10", VA = "0x37BDA10")]
    public static void AddLevel(FlatBufferBuilder builder, int level)
    {
    }

    [Token(Token = "0x6017DAD")]
    [Address(RVA = "0x37BD9F0", Offset = "0x37BD9F0", VA = "0x37BD9F0")]
    public static void AddLimitBreak(FlatBufferBuilder builder, int limitBreak)
    {
    }

    [Token(Token = "0x6017DAE")]
    [Address(RVA = "0x37BD9D0", Offset = "0x37BD9D0", VA = "0x37BD9D0")]
    public static void AddSkills(FlatBufferBuilder builder, VectorOffset skillsOffset)
    {
    }

    [Token(Token = "0x6017DAF")]
    [Address(RVA = "0x37BDAF8", Offset = "0x37BDAF8", VA = "0x37BDAF8")]
    public static VectorOffset CreateSkillsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017DB0")]
    [Address(RVA = "0x37BDBA0", Offset = "0x37BDBA0", VA = "0x37BDBA0")]
    public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017DB1")]
    [Address(RVA = "0x37BDC28", Offset = "0x37BDC28", VA = "0x37BDC28")]
    public static void StartSkillsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017DB2")]
    [Address(RVA = "0x37BDA90", Offset = "0x37BDA90", VA = "0x37BDA90")]
    public static Offset<MindEquipmentData> EndMindEquipmentData(FlatBufferBuilder builder)
    {
      return new Offset<MindEquipmentData>();
    }
  }
}
