// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ExpeditionPartyLock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CA7")]
  public struct ExpeditionPartyLock : IFlatbufferObject
  {
    [Token(Token = "0x4010C06")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F22")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018301"), Address(RVA = "0x26D3BA0", Offset = "0x26D3BA0", VA = "0x26D3BA0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018302")]
    [Address(RVA = "0x26D3BA8", Offset = "0x26D3BA8", VA = "0x26D3BA8")]
    public static ExpeditionPartyLock GetRootAsExpeditionPartyLock(ByteBuffer _bb)
    {
      return new ExpeditionPartyLock();
    }

    [Token(Token = "0x6018303")]
    [Address(RVA = "0x26D3BB4", Offset = "0x26D3BB4", VA = "0x26D3BB4")]
    public static ExpeditionPartyLock GetRootAsExpeditionPartyLock(
      ByteBuffer _bb,
      ExpeditionPartyLock obj)
    {
      return new ExpeditionPartyLock();
    }

    [Token(Token = "0x6018304")]
    [Address(RVA = "0x26D3C10", Offset = "0x26D3C10", VA = "0x26D3C10")]
    public static bool ExpeditionPartyLockBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018305")]
    [Address(RVA = "0x26D3C5C", Offset = "0x26D3C5C", VA = "0x26D3C5C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018306")]
    [Address(RVA = "0x26D3BF8", Offset = "0x26D3BF8", VA = "0x26D3BF8")]
    public ExpeditionPartyLock __assign(int _i, ByteBuffer _bb) => new ExpeditionPartyLock();

    [Token(Token = "0x17004F23")]
    public int PartyUnlock
    {
      [Token(Token = "0x6018307"), Address(RVA = "0x26D3C68", Offset = "0x26D3C68", VA = "0x26D3C68")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018308")]
    [Address(RVA = "0x26D3CB0", Offset = "0x26D3CB0", VA = "0x26D3CB0")]
    public static Offset<ExpeditionPartyLock> CreateExpeditionPartyLock(
      FlatBufferBuilder builder,
      int party_unlock = 1)
    {
      return new Offset<ExpeditionPartyLock>();
    }

    [Token(Token = "0x6018309")]
    [Address(RVA = "0x26D3D68", Offset = "0x26D3D68", VA = "0x26D3D68")]
    public static void StartExpeditionPartyLock(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601830A")]
    [Address(RVA = "0x26D3CF8", Offset = "0x26D3CF8", VA = "0x26D3CF8")]
    public static void AddPartyUnlock(FlatBufferBuilder builder, int partyUnlock)
    {
    }

    [Token(Token = "0x601830B")]
    [Address(RVA = "0x26D3D18", Offset = "0x26D3D18", VA = "0x26D3D18")]
    public static Offset<ExpeditionPartyLock> EndExpeditionPartyLock(FlatBufferBuilder builder)
    {
      return new Offset<ExpeditionPartyLock>();
    }

    [Token(Token = "0x601830C")]
    [Address(RVA = "0x26D3D80", Offset = "0x26D3D80", VA = "0x26D3D80")]
    public static void FinishExpeditionPartyLockBuffer(
      FlatBufferBuilder builder,
      Offset<ExpeditionPartyLock> offset)
    {
    }

    [Token(Token = "0x601830D")]
    [Address(RVA = "0x26D3DDC", Offset = "0x26D3DDC", VA = "0x26D3DDC")]
    public static void FinishSizePrefixedExpeditionPartyLockBuffer(
      FlatBufferBuilder builder,
      Offset<ExpeditionPartyLock> offset)
    {
    }
  }
}
