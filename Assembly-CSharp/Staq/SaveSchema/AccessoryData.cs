// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.AccessoryData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C70")]
  public struct AccessoryData : IFlatbufferObject
  {
    [Token(Token = "0x4010BCF")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DAF")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017D73"), Address(RVA = "0x37BCC84", Offset = "0x37BCC84", VA = "0x37BCC84", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017D74")]
    [Address(RVA = "0x37BCC8C", Offset = "0x37BCC8C", VA = "0x37BCC8C")]
    public static AccessoryData GetRootAsAccessoryData(ByteBuffer _bb) => new AccessoryData();

    [Token(Token = "0x6017D75")]
    [Address(RVA = "0x37BCC98", Offset = "0x37BCC98", VA = "0x37BCC98")]
    public static AccessoryData GetRootAsAccessoryData(ByteBuffer _bb, AccessoryData obj)
    {
      return new AccessoryData();
    }

    [Token(Token = "0x6017D76")]
    [Address(RVA = "0x37BCCDC", Offset = "0x37BCCDC", VA = "0x37BCCDC", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017D77")]
    [Address(RVA = "0x37B7AA8", Offset = "0x37B7AA8", VA = "0x37B7AA8")]
    public AccessoryData __assign(int _i, ByteBuffer _bb) => new AccessoryData();

    [Token(Token = "0x17004DB0")]
    public string Id
    {
      [Token(Token = "0x6017D78"), Address(RVA = "0x37BCCE8", Offset = "0x37BCCE8", VA = "0x37BCCE8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017D79")]
    [Address(RVA = "0x37BCD24", Offset = "0x37BCD24", VA = "0x37BCD24")]
    public ArraySegment<byte>? GetIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017D7A")]
    [Address(RVA = "0x37BCD5C", Offset = "0x37BCD5C", VA = "0x37BCD5C")]
    public byte[] GetIdArray() => (byte[]) null;

    [Token(Token = "0x17004DB1")]
    public string UniqueId
    {
      [Token(Token = "0x6017D7B"), Address(RVA = "0x37BCDA8", Offset = "0x37BCDA8", VA = "0x37BCDA8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017D7C")]
    [Address(RVA = "0x37BCDE4", Offset = "0x37BCDE4", VA = "0x37BCDE4")]
    public ArraySegment<byte>? GetUniqueIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017D7D")]
    [Address(RVA = "0x37BCE1C", Offset = "0x37BCE1C", VA = "0x37BCE1C")]
    public byte[] GetUniqueIdArray() => (byte[]) null;

    [Token(Token = "0x17004DB2")]
    public int MasterId
    {
      [Token(Token = "0x6017D7E"), Address(RVA = "0x37BCE68", Offset = "0x37BCE68", VA = "0x37BCE68")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DB3")]
    public int Level
    {
      [Token(Token = "0x6017D7F"), Address(RVA = "0x37BCEAC", Offset = "0x37BCEAC", VA = "0x37BCEAC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DB4")]
    public int LimitBreak
    {
      [Token(Token = "0x6017D80"), Address(RVA = "0x37BCEF0", Offset = "0x37BCEF0", VA = "0x37BCEF0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017D81")]
    [Address(RVA = "0x37BCF34", Offset = "0x37BCF34", VA = "0x37BCF34")]
    public int Skills(int j) => new int();

    [Token(Token = "0x17004DB5")]
    public int SkillsLength
    {
      [Token(Token = "0x6017D82"), Address(RVA = "0x37BCF94", Offset = "0x37BCF94", VA = "0x37BCF94")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017D83")]
    [Address(RVA = "0x37BCFC8", Offset = "0x37BCFC8", VA = "0x37BCFC8")]
    public ArraySegment<byte>? GetSkillsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017D84")]
    [Address(RVA = "0x37BD000", Offset = "0x37BD000", VA = "0x37BD000")]
    public int[] GetSkillsArray() => (int[]) null;

    [Token(Token = "0x6017D85")]
    [Address(RVA = "0x37BD04C", Offset = "0x37BD04C", VA = "0x37BD04C")]
    public EquipmentOption? Options(int j) => new EquipmentOption?();

    [Token(Token = "0x17004DB6")]
    public int OptionsLength
    {
      [Token(Token = "0x6017D86"), Address(RVA = "0x37BD100", Offset = "0x37BD100", VA = "0x37BD100")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017D87")]
    [Address(RVA = "0x37BD134", Offset = "0x37BD134", VA = "0x37BD134")]
    public static Offset<AccessoryData> CreateAccessoryData(
      FlatBufferBuilder builder,
      StringOffset idOffset = default (StringOffset),
      StringOffset uniqueIdOffset = default (StringOffset),
      int masterId = 0,
      int level = 0,
      int limitBreak = 0,
      VectorOffset skillsOffset = default (VectorOffset),
      VectorOffset optionsOffset = default (VectorOffset))
    {
      return new Offset<AccessoryData>();
    }

    [Token(Token = "0x6017D88")]
    [Address(RVA = "0x37BD324", Offset = "0x37BD324", VA = "0x37BD324")]
    public static void StartAccessoryData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017D89")]
    [Address(RVA = "0x37BD2B4", Offset = "0x37BD2B4", VA = "0x37BD2B4")]
    public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
    {
    }

    [Token(Token = "0x6017D8A")]
    [Address(RVA = "0x37BD294", Offset = "0x37BD294", VA = "0x37BD294")]
    public static void AddUniqueId(FlatBufferBuilder builder, StringOffset uniqueIdOffset)
    {
    }

    [Token(Token = "0x6017D8B")]
    [Address(RVA = "0x37BD274", Offset = "0x37BD274", VA = "0x37BD274")]
    public static void AddMasterId(FlatBufferBuilder builder, int masterId)
    {
    }

    [Token(Token = "0x6017D8C")]
    [Address(RVA = "0x37BD254", Offset = "0x37BD254", VA = "0x37BD254")]
    public static void AddLevel(FlatBufferBuilder builder, int level)
    {
    }

    [Token(Token = "0x6017D8D")]
    [Address(RVA = "0x37BD234", Offset = "0x37BD234", VA = "0x37BD234")]
    public static void AddLimitBreak(FlatBufferBuilder builder, int limitBreak)
    {
    }

    [Token(Token = "0x6017D8E")]
    [Address(RVA = "0x37BD214", Offset = "0x37BD214", VA = "0x37BD214")]
    public static void AddSkills(FlatBufferBuilder builder, VectorOffset skillsOffset)
    {
    }

    [Token(Token = "0x6017D8F")]
    [Address(RVA = "0x37BD33C", Offset = "0x37BD33C", VA = "0x37BD33C")]
    public static VectorOffset CreateSkillsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D90")]
    [Address(RVA = "0x37BD3E4", Offset = "0x37BD3E4", VA = "0x37BD3E4")]
    public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D91")]
    [Address(RVA = "0x37BD46C", Offset = "0x37BD46C", VA = "0x37BD46C")]
    public static void StartSkillsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017D92")]
    [Address(RVA = "0x37BD1F4", Offset = "0x37BD1F4", VA = "0x37BD1F4")]
    public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
    {
    }

    [Token(Token = "0x6017D93")]
    [Address(RVA = "0x37BD48C", Offset = "0x37BD48C", VA = "0x37BD48C")]
    public static VectorOffset CreateOptionsVector(
      FlatBufferBuilder builder,
      Offset<EquipmentOption>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D94")]
    [Address(RVA = "0x37BD534", Offset = "0x37BD534", VA = "0x37BD534")]
    public static VectorOffset CreateOptionsVectorBlock(
      FlatBufferBuilder builder,
      Offset<EquipmentOption>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017D95")]
    [Address(RVA = "0x37BD5BC", Offset = "0x37BD5BC", VA = "0x37BD5BC")]
    public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017D96")]
    [Address(RVA = "0x37BD2D4", Offset = "0x37BD2D4", VA = "0x37BD2D4")]
    public static Offset<AccessoryData> EndAccessoryData(FlatBufferBuilder builder)
    {
      return new Offset<AccessoryData>();
    }
  }
}
