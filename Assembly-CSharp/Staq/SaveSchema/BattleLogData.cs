// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.BattleLogData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C76")]
  public struct BattleLogData : IFlatbufferObject
  {
    [Token(Token = "0x4010BD5")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DDC")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017E18"), Address(RVA = "0x37BF300", Offset = "0x37BF300", VA = "0x37BF300", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017E19")]
    [Address(RVA = "0x37BF308", Offset = "0x37BF308", VA = "0x37BF308")]
    public static BattleLogData GetRootAsBattleLogData(ByteBuffer _bb) => new BattleLogData();

    [Token(Token = "0x6017E1A")]
    [Address(RVA = "0x37BF314", Offset = "0x37BF314", VA = "0x37BF314")]
    public static BattleLogData GetRootAsBattleLogData(ByteBuffer _bb, BattleLogData obj)
    {
      return new BattleLogData();
    }

    [Token(Token = "0x6017E1B")]
    [Address(RVA = "0x37BF358", Offset = "0x37BF358", VA = "0x37BF358", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017E1C")]
    [Address(RVA = "0x37BEFAC", Offset = "0x37BEFAC", VA = "0x37BEFAC")]
    public BattleLogData __assign(int _i, ByteBuffer _bb) => new BattleLogData();

    [Token(Token = "0x17004DDD")]
    public int LogType
    {
      [Token(Token = "0x6017E1D"), Address(RVA = "0x37BF364", Offset = "0x37BF364", VA = "0x37BF364")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DDE")]
    public int TextFormatDataID
    {
      [Token(Token = "0x6017E1E"), Address(RVA = "0x37BF3A8", Offset = "0x37BF3A8", VA = "0x37BF3A8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017E1F")]
    [Address(RVA = "0x37BF3EC", Offset = "0x37BF3EC", VA = "0x37BF3EC")]
    public string ReplaceTextList(int j) => (string) null;

    [Token(Token = "0x17004DDF")]
    public int ReplaceTextListLength
    {
      [Token(Token = "0x6017E20"), Address(RVA = "0x37BF444", Offset = "0x37BF444", VA = "0x37BF444")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DE0")]
    public int ActionUnitId
    {
      [Token(Token = "0x6017E21"), Address(RVA = "0x37BF478", Offset = "0x37BF478", VA = "0x37BF478")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DE1")]
    public int TargetUnitId
    {
      [Token(Token = "0x6017E22"), Address(RVA = "0x37BF4BC", Offset = "0x37BF4BC", VA = "0x37BF4BC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DE2")]
    public int Turn
    {
      [Token(Token = "0x6017E23"), Address(RVA = "0x37BF500", Offset = "0x37BF500", VA = "0x37BF500")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DE3")]
    public int ParamNum
    {
      [Token(Token = "0x6017E24"), Address(RVA = "0x37BF544", Offset = "0x37BF544", VA = "0x37BF544")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017E25")]
    [Address(RVA = "0x37BF588", Offset = "0x37BF588", VA = "0x37BF588")]
    public static Offset<BattleLogData> CreateBattleLogData(
      FlatBufferBuilder builder,
      int LogType = 0,
      int TextFormatDataID = 0,
      VectorOffset ReplaceTextListOffset = default (VectorOffset),
      int ActionUnitId = 0,
      int TargetUnitId = 0,
      int Turn = 0,
      int ParamNum = 0)
    {
      return new Offset<BattleLogData>();
    }

    [Token(Token = "0x6017E26")]
    [Address(RVA = "0x37BF778", Offset = "0x37BF778", VA = "0x37BF778")]
    public static void StartBattleLogData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017E27")]
    [Address(RVA = "0x37BF708", Offset = "0x37BF708", VA = "0x37BF708")]
    public static void AddLogType(FlatBufferBuilder builder, int LogType)
    {
    }

    [Token(Token = "0x6017E28")]
    [Address(RVA = "0x37BF6E8", Offset = "0x37BF6E8", VA = "0x37BF6E8")]
    public static void AddTextFormatDataID(FlatBufferBuilder builder, int TextFormatDataID)
    {
    }

    [Token(Token = "0x6017E29")]
    [Address(RVA = "0x37BF6C8", Offset = "0x37BF6C8", VA = "0x37BF6C8")]
    public static void AddReplaceTextList(
      FlatBufferBuilder builder,
      VectorOffset ReplaceTextListOffset)
    {
    }

    [Token(Token = "0x6017E2A")]
    [Address(RVA = "0x37BF790", Offset = "0x37BF790", VA = "0x37BF790")]
    public static VectorOffset CreateReplaceTextListVector(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E2B")]
    [Address(RVA = "0x37BF838", Offset = "0x37BF838", VA = "0x37BF838")]
    public static VectorOffset CreateReplaceTextListVectorBlock(
      FlatBufferBuilder builder,
      StringOffset[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E2C")]
    [Address(RVA = "0x37BF8C0", Offset = "0x37BF8C0", VA = "0x37BF8C0")]
    public static void StartReplaceTextListVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017E2D")]
    [Address(RVA = "0x37BF6A8", Offset = "0x37BF6A8", VA = "0x37BF6A8")]
    public static void AddActionUnitId(FlatBufferBuilder builder, int ActionUnitId)
    {
    }

    [Token(Token = "0x6017E2E")]
    [Address(RVA = "0x37BF688", Offset = "0x37BF688", VA = "0x37BF688")]
    public static void AddTargetUnitId(FlatBufferBuilder builder, int TargetUnitId)
    {
    }

    [Token(Token = "0x6017E2F")]
    [Address(RVA = "0x37BF668", Offset = "0x37BF668", VA = "0x37BF668")]
    public static void AddTurn(FlatBufferBuilder builder, int Turn)
    {
    }

    [Token(Token = "0x6017E30")]
    [Address(RVA = "0x37BF648", Offset = "0x37BF648", VA = "0x37BF648")]
    public static void AddParamNum(FlatBufferBuilder builder, int ParamNum)
    {
    }

    [Token(Token = "0x6017E31")]
    [Address(RVA = "0x37BF728", Offset = "0x37BF728", VA = "0x37BF728")]
    public static Offset<BattleLogData> EndBattleLogData(FlatBufferBuilder builder)
    {
      return new Offset<BattleLogData>();
    }
  }
}
