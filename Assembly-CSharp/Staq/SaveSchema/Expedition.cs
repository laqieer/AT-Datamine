// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.Expedition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CA8")]
  public struct Expedition : IFlatbufferObject
  {
    [Token(Token = "0x4010C07")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F24")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601830E"), Address(RVA = "0x26D3E38", Offset = "0x26D3E38", VA = "0x26D3E38", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601830F")]
    [Address(RVA = "0x26D3E40", Offset = "0x26D3E40", VA = "0x26D3E40")]
    public static Expedition GetRootAsExpedition(ByteBuffer _bb) => new Expedition();

    [Token(Token = "0x6018310")]
    [Address(RVA = "0x26D3E4C", Offset = "0x26D3E4C", VA = "0x26D3E4C")]
    public static Expedition GetRootAsExpedition(ByteBuffer _bb, Expedition obj)
    {
      return new Expedition();
    }

    [Token(Token = "0x6018311")]
    [Address(RVA = "0x26D3EA8", Offset = "0x26D3EA8", VA = "0x26D3EA8")]
    public static bool ExpeditionBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018312")]
    [Address(RVA = "0x26D3EF4", Offset = "0x26D3EF4", VA = "0x26D3EF4", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018313")]
    [Address(RVA = "0x26D3E90", Offset = "0x26D3E90", VA = "0x26D3E90")]
    public Expedition __assign(int _i, ByteBuffer _bb) => new Expedition();

    [Token(Token = "0x17004F25")]
    public int LastSelectedBossPanelIndex
    {
      [Token(Token = "0x6018314"), Address(RVA = "0x26D3F00", Offset = "0x26D3F00", VA = "0x26D3F00")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018315")]
    [Address(RVA = "0x26D3F44", Offset = "0x26D3F44", VA = "0x26D3F44")]
    public static Offset<Expedition> CreateExpedition(
      FlatBufferBuilder builder,
      int last_selected_boss_panel_index = 0)
    {
      return new Offset<Expedition>();
    }

    [Token(Token = "0x6018316")]
    [Address(RVA = "0x26D3FFC", Offset = "0x26D3FFC", VA = "0x26D3FFC")]
    public static void StartExpedition(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018317")]
    [Address(RVA = "0x26D3F8C", Offset = "0x26D3F8C", VA = "0x26D3F8C")]
    public static void AddLastSelectedBossPanelIndex(
      FlatBufferBuilder builder,
      int lastSelectedBossPanelIndex)
    {
    }

    [Token(Token = "0x6018318")]
    [Address(RVA = "0x26D3FAC", Offset = "0x26D3FAC", VA = "0x26D3FAC")]
    public static Offset<Expedition> EndExpedition(FlatBufferBuilder builder)
    {
      return new Offset<Expedition>();
    }

    [Token(Token = "0x6018319")]
    [Address(RVA = "0x26D4014", Offset = "0x26D4014", VA = "0x26D4014")]
    public static void FinishExpeditionBuffer(FlatBufferBuilder builder, Offset<Expedition> offset)
    {
    }

    [Token(Token = "0x601831A")]
    [Address(RVA = "0x26D4070", Offset = "0x26D4070", VA = "0x26D4070")]
    public static void FinishSizePrefixedExpeditionBuffer(
      FlatBufferBuilder builder,
      Offset<Expedition> offset)
    {
    }
  }
}
