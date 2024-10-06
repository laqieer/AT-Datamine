// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.TrustData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C72")]
  public struct TrustData : IFlatbufferObject
  {
    [Token(Token = "0x4010BD1")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DBE")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017DB3"), Address(RVA = "0x37BDC48", Offset = "0x37BDC48", VA = "0x37BDC48", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017DB4")]
    [Address(RVA = "0x37BDC50", Offset = "0x37BDC50", VA = "0x37BDC50")]
    public static TrustData GetRootAsTrustData(ByteBuffer _bb) => new TrustData();

    [Token(Token = "0x6017DB5")]
    [Address(RVA = "0x37BDC5C", Offset = "0x37BDC5C", VA = "0x37BDC5C")]
    public static TrustData GetRootAsTrustData(ByteBuffer _bb, TrustData obj) => new TrustData();

    [Token(Token = "0x6017DB6")]
    [Address(RVA = "0x37BDCA0", Offset = "0x37BDCA0", VA = "0x37BDCA0", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017DB7")]
    [Address(RVA = "0x37B7CA8", Offset = "0x37B7CA8", VA = "0x37B7CA8")]
    public TrustData __assign(int _i, ByteBuffer _bb) => new TrustData();

    [Token(Token = "0x17004DBF")]
    public int Id
    {
      [Token(Token = "0x6017DB8"), Address(RVA = "0x37BDCAC", Offset = "0x37BDCAC", VA = "0x37BDCAC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DC0")]
    public string UniqueId
    {
      [Token(Token = "0x6017DB9"), Address(RVA = "0x37BDCF0", Offset = "0x37BDCF0", VA = "0x37BDCF0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017DBA")]
    [Address(RVA = "0x37BDD2C", Offset = "0x37BDD2C", VA = "0x37BDD2C")]
    public ArraySegment<byte>? GetUniqueIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017DBB")]
    [Address(RVA = "0x37BDD64", Offset = "0x37BDD64", VA = "0x37BDD64")]
    public byte[] GetUniqueIdArray() => (byte[]) null;

    [Token(Token = "0x17004DC1")]
    public int MasterId
    {
      [Token(Token = "0x6017DBC"), Address(RVA = "0x37BDDB0", Offset = "0x37BDDB0", VA = "0x37BDDB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DC2")]
    public BattleParameter? BattleParam
    {
      [Token(Token = "0x6017DBD"), Address(RVA = "0x37BDDF4", Offset = "0x37BDDF4", VA = "0x37BDDF4")] get
      {
        return new BattleParameter?();
      }
    }

    [Token(Token = "0x17004DC3")]
    public int Weight
    {
      [Token(Token = "0x6017DBE"), Address(RVA = "0x37BDE8C", Offset = "0x37BDE8C", VA = "0x37BDE8C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017DBF")]
    [Address(RVA = "0x37BDED0", Offset = "0x37BDED0", VA = "0x37BDED0")]
    public int Skills(int j) => new int();

    [Token(Token = "0x17004DC4")]
    public int SkillsLength
    {
      [Token(Token = "0x6017DC0"), Address(RVA = "0x37BDF30", Offset = "0x37BDF30", VA = "0x37BDF30")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017DC1")]
    [Address(RVA = "0x37BDF64", Offset = "0x37BDF64", VA = "0x37BDF64")]
    public ArraySegment<byte>? GetSkillsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017DC2")]
    [Address(RVA = "0x37BDF9C", Offset = "0x37BDF9C", VA = "0x37BDF9C")]
    public int[] GetSkillsArray() => (int[]) null;

    [Token(Token = "0x6017DC3")]
    [Address(RVA = "0x37BDFE8", Offset = "0x37BDFE8", VA = "0x37BDFE8")]
    public static Offset<TrustData> CreateTrustData(
      FlatBufferBuilder builder,
      int id = 0,
      StringOffset uniqueIdOffset = default (StringOffset),
      int masterId = 0,
      Offset<BattleParameter> battleParamOffset = default (Offset<BattleParameter>),
      int weight = 0,
      VectorOffset skillsOffset = default (VectorOffset))
    {
      return new Offset<TrustData>();
    }

    [Token(Token = "0x6017DC4")]
    [Address(RVA = "0x37BE1A0", Offset = "0x37BE1A0", VA = "0x37BE1A0")]
    public static void StartTrustData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017DC5")]
    [Address(RVA = "0x37BE130", Offset = "0x37BE130", VA = "0x37BE130")]
    public static void AddId(FlatBufferBuilder builder, int id)
    {
    }

    [Token(Token = "0x6017DC6")]
    [Address(RVA = "0x37BE110", Offset = "0x37BE110", VA = "0x37BE110")]
    public static void AddUniqueId(FlatBufferBuilder builder, StringOffset uniqueIdOffset)
    {
    }

    [Token(Token = "0x6017DC7")]
    [Address(RVA = "0x37BE0F0", Offset = "0x37BE0F0", VA = "0x37BE0F0")]
    public static void AddMasterId(FlatBufferBuilder builder, int masterId)
    {
    }

    [Token(Token = "0x6017DC8")]
    [Address(RVA = "0x37BE0D0", Offset = "0x37BE0D0", VA = "0x37BE0D0")]
    public static void AddBattleParam(
      FlatBufferBuilder builder,
      Offset<BattleParameter> battleParamOffset)
    {
    }

    [Token(Token = "0x6017DC9")]
    [Address(RVA = "0x37BE0B0", Offset = "0x37BE0B0", VA = "0x37BE0B0")]
    public static void AddWeight(FlatBufferBuilder builder, int weight)
    {
    }

    [Token(Token = "0x6017DCA")]
    [Address(RVA = "0x37BE090", Offset = "0x37BE090", VA = "0x37BE090")]
    public static void AddSkills(FlatBufferBuilder builder, VectorOffset skillsOffset)
    {
    }

    [Token(Token = "0x6017DCB")]
    [Address(RVA = "0x37BE1B8", Offset = "0x37BE1B8", VA = "0x37BE1B8")]
    public static VectorOffset CreateSkillsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017DCC")]
    [Address(RVA = "0x37BE260", Offset = "0x37BE260", VA = "0x37BE260")]
    public static VectorOffset CreateSkillsVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017DCD")]
    [Address(RVA = "0x37BE2E8", Offset = "0x37BE2E8", VA = "0x37BE2E8")]
    public static void StartSkillsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017DCE")]
    [Address(RVA = "0x37BE150", Offset = "0x37BE150", VA = "0x37BE150")]
    public static Offset<TrustData> EndTrustData(FlatBufferBuilder builder)
    {
      return new Offset<TrustData>();
    }
  }
}
