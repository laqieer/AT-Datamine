// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.TodayInfomationSave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CE5")]
  public struct TodayInfomationSave : IFlatbufferObject
  {
    [Token(Token = "0x4010C46")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FF0")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018758"), Address(RVA = "0x2936380", Offset = "0x2936380", VA = "0x2936380", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018759")]
    [Address(RVA = "0x2936388", Offset = "0x2936388", VA = "0x2936388")]
    public static TodayInfomationSave GetRootAsTodayInfomationSave(ByteBuffer _bb)
    {
      return new TodayInfomationSave();
    }

    [Token(Token = "0x601875A")]
    [Address(RVA = "0x2936394", Offset = "0x2936394", VA = "0x2936394")]
    public static TodayInfomationSave GetRootAsTodayInfomationSave(
      ByteBuffer _bb,
      TodayInfomationSave obj)
    {
      return new TodayInfomationSave();
    }

    [Token(Token = "0x601875B")]
    [Address(RVA = "0x29363F0", Offset = "0x29363F0", VA = "0x29363F0")]
    public static bool TodayInfomationSaveBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601875C")]
    [Address(RVA = "0x293643C", Offset = "0x293643C", VA = "0x293643C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601875D")]
    [Address(RVA = "0x29363D8", Offset = "0x29363D8", VA = "0x29363D8")]
    public TodayInfomationSave __assign(int _i, ByteBuffer _bb) => new TodayInfomationSave();

    [Token(Token = "0x17004FF1")]
    public bool Check
    {
      [Token(Token = "0x601875E"), Address(RVA = "0x2936448", Offset = "0x2936448", VA = "0x2936448")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004FF2")]
    public string Date
    {
      [Token(Token = "0x601875F"), Address(RVA = "0x2936490", Offset = "0x2936490", VA = "0x2936490")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018760")]
    [Address(RVA = "0x29364CC", Offset = "0x29364CC", VA = "0x29364CC")]
    public ArraySegment<byte>? GetDateBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018761")]
    [Address(RVA = "0x2936504", Offset = "0x2936504", VA = "0x2936504")]
    public byte[] GetDateArray() => (byte[]) null;

    [Token(Token = "0x6018762")]
    [Address(RVA = "0x2936550", Offset = "0x2936550", VA = "0x2936550")]
    public static Offset<TodayInfomationSave> CreateTodayInfomationSave(
      FlatBufferBuilder builder,
      bool check = false,
      StringOffset dateOffset = default (StringOffset))
    {
      return new Offset<TodayInfomationSave>();
    }

    [Token(Token = "0x6018763")]
    [Address(RVA = "0x2936638", Offset = "0x2936638", VA = "0x2936638")]
    public static void StartTodayInfomationSave(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018764")]
    [Address(RVA = "0x29365C8", Offset = "0x29365C8", VA = "0x29365C8")]
    public static void AddCheck(FlatBufferBuilder builder, bool check)
    {
    }

    [Token(Token = "0x6018765")]
    [Address(RVA = "0x29365A8", Offset = "0x29365A8", VA = "0x29365A8")]
    public static void AddDate(FlatBufferBuilder builder, StringOffset dateOffset)
    {
    }

    [Token(Token = "0x6018766")]
    [Address(RVA = "0x29365E8", Offset = "0x29365E8", VA = "0x29365E8")]
    public static Offset<TodayInfomationSave> EndTodayInfomationSave(FlatBufferBuilder builder)
    {
      return new Offset<TodayInfomationSave>();
    }

    [Token(Token = "0x6018767")]
    [Address(RVA = "0x2936650", Offset = "0x2936650", VA = "0x2936650")]
    public static void FinishTodayInfomationSaveBuffer(
      FlatBufferBuilder builder,
      Offset<TodayInfomationSave> offset)
    {
    }

    [Token(Token = "0x6018768")]
    [Address(RVA = "0x29366AC", Offset = "0x29366AC", VA = "0x29366AC")]
    public static void FinishSizePrefixedTodayInfomationSaveBuffer(
      FlatBufferBuilder builder,
      Offset<TodayInfomationSave> offset)
    {
    }
  }
}
