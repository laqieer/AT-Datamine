// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.EffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C69")]
  public struct EffectData : IFlatbufferObject
  {
    [Token(Token = "0x4010BC8")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004D74")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017C7D"), Address(RVA = "0x37B8B28", Offset = "0x37B8B28", VA = "0x37B8B28", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017C7E")]
    [Address(RVA = "0x37B8B30", Offset = "0x37B8B30", VA = "0x37B8B30")]
    public static EffectData GetRootAsEffectData(ByteBuffer _bb) => new EffectData();

    [Token(Token = "0x6017C7F")]
    [Address(RVA = "0x37B8B3C", Offset = "0x37B8B3C", VA = "0x37B8B3C")]
    public static EffectData GetRootAsEffectData(ByteBuffer _bb, EffectData obj)
    {
      return new EffectData();
    }

    [Token(Token = "0x6017C80")]
    [Address(RVA = "0x37B8B80", Offset = "0x37B8B80", VA = "0x37B8B80", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017C81")]
    [Address(RVA = "0x37B76A8", Offset = "0x37B76A8", VA = "0x37B76A8")]
    public EffectData __assign(int _i, ByteBuffer _bb) => new EffectData();

    [Token(Token = "0x17004D75")]
    public int Id
    {
      [Token(Token = "0x6017C82"), Address(RVA = "0x37B8B8C", Offset = "0x37B8B8C", VA = "0x37B8B8C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017C83")]
    [Address(RVA = "0x37B8BD0", Offset = "0x37B8BD0", VA = "0x37B8BD0")]
    public static Offset<EffectData> CreateEffectData(FlatBufferBuilder builder, int id = 0)
    {
      return new Offset<EffectData>();
    }

    [Token(Token = "0x6017C84")]
    [Address(RVA = "0x37B8C88", Offset = "0x37B8C88", VA = "0x37B8C88")]
    public static void StartEffectData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017C85")]
    [Address(RVA = "0x37B8C18", Offset = "0x37B8C18", VA = "0x37B8C18")]
    public static void AddId(FlatBufferBuilder builder, int id)
    {
    }

    [Token(Token = "0x6017C86")]
    [Address(RVA = "0x37B8C38", Offset = "0x37B8C38", VA = "0x37B8C38")]
    public static Offset<EffectData> EndEffectData(FlatBufferBuilder builder)
    {
      return new Offset<EffectData>();
    }
  }
}
