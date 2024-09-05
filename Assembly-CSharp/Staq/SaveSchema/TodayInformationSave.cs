// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.TodayInformationSave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CE6")]
  public struct TodayInformationSave : IFlatbufferObject
  {
    [Token(Token = "0x4010C47")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FF3")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018769"), Address(RVA = "0x2936708", Offset = "0x2936708", VA = "0x2936708", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601876A")]
    [Address(RVA = "0x2936710", Offset = "0x2936710", VA = "0x2936710")]
    public static TodayInformationSave GetRootAsTodayInformationSave(ByteBuffer _bb)
    {
      return new TodayInformationSave();
    }

    [Token(Token = "0x601876B")]
    [Address(RVA = "0x293671C", Offset = "0x293671C", VA = "0x293671C")]
    public static TodayInformationSave GetRootAsTodayInformationSave(
      ByteBuffer _bb,
      TodayInformationSave obj)
    {
      return new TodayInformationSave();
    }

    [Token(Token = "0x601876C")]
    [Address(RVA = "0x2936778", Offset = "0x2936778", VA = "0x2936778")]
    public static bool TodayInformationSaveBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601876D")]
    [Address(RVA = "0x29367C4", Offset = "0x29367C4", VA = "0x29367C4", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601876E")]
    [Address(RVA = "0x2936760", Offset = "0x2936760", VA = "0x2936760")]
    public TodayInformationSave __assign(int _i, ByteBuffer _bb) => new TodayInformationSave();

    [Token(Token = "0x17004FF4")]
    public bool Check
    {
      [Token(Token = "0x601876F"), Address(RVA = "0x29367D0", Offset = "0x29367D0", VA = "0x29367D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004FF5")]
    public string Date
    {
      [Token(Token = "0x6018770"), Address(RVA = "0x2936818", Offset = "0x2936818", VA = "0x2936818")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018771")]
    [Address(RVA = "0x2936854", Offset = "0x2936854", VA = "0x2936854")]
    public ArraySegment<byte>? GetDateBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018772")]
    [Address(RVA = "0x293688C", Offset = "0x293688C", VA = "0x293688C")]
    public byte[] GetDateArray() => (byte[]) null;

    [Token(Token = "0x6018773")]
    [Address(RVA = "0x29368D8", Offset = "0x29368D8", VA = "0x29368D8")]
    public static Offset<TodayInformationSave> CreateTodayInformationSave(
      FlatBufferBuilder builder,
      bool check = false,
      StringOffset dateOffset = default (StringOffset))
    {
      return new Offset<TodayInformationSave>();
    }

    [Token(Token = "0x6018774")]
    [Address(RVA = "0x29369C0", Offset = "0x29369C0", VA = "0x29369C0")]
    public static void StartTodayInformationSave(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018775")]
    [Address(RVA = "0x2936950", Offset = "0x2936950", VA = "0x2936950")]
    public static void AddCheck(FlatBufferBuilder builder, bool check)
    {
    }

    [Token(Token = "0x6018776")]
    [Address(RVA = "0x2936930", Offset = "0x2936930", VA = "0x2936930")]
    public static void AddDate(FlatBufferBuilder builder, StringOffset dateOffset)
    {
    }

    [Token(Token = "0x6018777")]
    [Address(RVA = "0x2936970", Offset = "0x2936970", VA = "0x2936970")]
    public static Offset<TodayInformationSave> EndTodayInformationSave(FlatBufferBuilder builder)
    {
      return new Offset<TodayInformationSave>();
    }

    [Token(Token = "0x6018778")]
    [Address(RVA = "0x29369D8", Offset = "0x29369D8", VA = "0x29369D8")]
    public static void FinishTodayInformationSaveBuffer(
      FlatBufferBuilder builder,
      Offset<TodayInformationSave> offset)
    {
    }

    [Token(Token = "0x6018779")]
    [Address(RVA = "0x2936A34", Offset = "0x2936A34", VA = "0x2936A34")]
    public static void FinishSizePrefixedTodayInformationSaveBuffer(
      FlatBufferBuilder builder,
      Offset<TodayInformationSave> offset)
    {
    }
  }
}
