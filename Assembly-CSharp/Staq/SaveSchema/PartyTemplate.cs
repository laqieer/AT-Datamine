// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.PartyTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CC7")]
  public struct PartyTemplate : IFlatbufferObject
  {
    [Token(Token = "0x4010C25")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F8A")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018546"), Address(RVA = "0x26DC70C", Offset = "0x26DC70C", VA = "0x26DC70C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018547")]
    [Address(RVA = "0x26DC714", Offset = "0x26DC714", VA = "0x26DC714")]
    public static PartyTemplate GetRootAsPartyTemplate(ByteBuffer _bb) => new PartyTemplate();

    [Token(Token = "0x6018548")]
    [Address(RVA = "0x26DC720", Offset = "0x26DC720", VA = "0x26DC720")]
    public static PartyTemplate GetRootAsPartyTemplate(ByteBuffer _bb, PartyTemplate obj)
    {
      return new PartyTemplate();
    }

    [Token(Token = "0x6018549")]
    [Address(RVA = "0x26DC77C", Offset = "0x26DC77C", VA = "0x26DC77C")]
    public static bool PartyTemplateBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601854A")]
    [Address(RVA = "0x26DC7C8", Offset = "0x26DC7C8", VA = "0x26DC7C8", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601854B")]
    [Address(RVA = "0x26DC764", Offset = "0x26DC764", VA = "0x26DC764")]
    public PartyTemplate __assign(int _i, ByteBuffer _bb) => new PartyTemplate();

    [Token(Token = "0x17004F8B")]
    public int ShowTemplateId
    {
      [Token(Token = "0x601854C"), Address(RVA = "0x26DC7D4", Offset = "0x26DC7D4", VA = "0x26DC7D4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601854D")]
    [Address(RVA = "0x26DC818", Offset = "0x26DC818", VA = "0x26DC818")]
    public static Offset<PartyTemplate> CreatePartyTemplate(
      FlatBufferBuilder builder,
      int show_template_id = 0)
    {
      return new Offset<PartyTemplate>();
    }

    [Token(Token = "0x601854E")]
    [Address(RVA = "0x26DC8D0", Offset = "0x26DC8D0", VA = "0x26DC8D0")]
    public static void StartPartyTemplate(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601854F")]
    [Address(RVA = "0x26DC860", Offset = "0x26DC860", VA = "0x26DC860")]
    public static void AddShowTemplateId(FlatBufferBuilder builder, int showTemplateId)
    {
    }

    [Token(Token = "0x6018550")]
    [Address(RVA = "0x26DC880", Offset = "0x26DC880", VA = "0x26DC880")]
    public static Offset<PartyTemplate> EndPartyTemplate(FlatBufferBuilder builder)
    {
      return new Offset<PartyTemplate>();
    }

    [Token(Token = "0x6018551")]
    [Address(RVA = "0x26DC8E8", Offset = "0x26DC8E8", VA = "0x26DC8E8")]
    public static void FinishPartyTemplateBuffer(
      FlatBufferBuilder builder,
      Offset<PartyTemplate> offset)
    {
    }

    [Token(Token = "0x6018552")]
    [Address(RVA = "0x26DC944", Offset = "0x26DC944", VA = "0x26DC944")]
    public static void FinishSizePrefixedPartyTemplateBuffer(
      FlatBufferBuilder builder,
      Offset<PartyTemplate> offset)
    {
    }
  }
}
