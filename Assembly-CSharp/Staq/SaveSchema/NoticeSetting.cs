// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.NoticeSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CC6")]
  public struct NoticeSetting : IFlatbufferObject
  {
    [Token(Token = "0x4010C24")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F84")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018531"), Address(RVA = "0x26DC25C", Offset = "0x26DC25C", VA = "0x26DC25C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018532")]
    [Address(RVA = "0x26DC264", Offset = "0x26DC264", VA = "0x26DC264")]
    public static NoticeSetting GetRootAsNoticeSetting(ByteBuffer _bb) => new NoticeSetting();

    [Token(Token = "0x6018533")]
    [Address(RVA = "0x26DC270", Offset = "0x26DC270", VA = "0x26DC270")]
    public static NoticeSetting GetRootAsNoticeSetting(ByteBuffer _bb, NoticeSetting obj)
    {
      return new NoticeSetting();
    }

    [Token(Token = "0x6018534")]
    [Address(RVA = "0x26DC2CC", Offset = "0x26DC2CC", VA = "0x26DC2CC")]
    public static bool NoticeSettingBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018535")]
    [Address(RVA = "0x26DC318", Offset = "0x26DC318", VA = "0x26DC318", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018536")]
    [Address(RVA = "0x26DC2B4", Offset = "0x26DC2B4", VA = "0x26DC2B4")]
    public NoticeSetting __assign(int _i, ByteBuffer _bb) => new NoticeSetting();

    [Token(Token = "0x17004F85")]
    public bool BattleFinishVibration
    {
      [Token(Token = "0x6018537"), Address(RVA = "0x26DC324", Offset = "0x26DC324", VA = "0x26DC324")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F86")]
    public bool PushNotice
    {
      [Token(Token = "0x6018538"), Address(RVA = "0x26DC374", Offset = "0x26DC374", VA = "0x26DC374")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F87")]
    public bool AllApRecovery
    {
      [Token(Token = "0x6018539"), Address(RVA = "0x26DC3C4", Offset = "0x26DC3C4", VA = "0x26DC3C4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F88")]
    public bool FragmentPoolFull
    {
      [Token(Token = "0x601853A"), Address(RVA = "0x26DC414", Offset = "0x26DC414", VA = "0x26DC414")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F89")]
    public bool FactorizeRexovery
    {
      [Token(Token = "0x601853B"), Address(RVA = "0x26DC464", Offset = "0x26DC464", VA = "0x26DC464")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601853C")]
    [Address(RVA = "0x26DC4B4", Offset = "0x26DC4B4", VA = "0x26DC4B4")]
    public static Offset<NoticeSetting> CreateNoticeSetting(
      FlatBufferBuilder builder,
      bool battle_finish_vibration = true,
      bool push_notice = true,
      bool all_ap_recovery = true,
      bool fragment_pool_full = true,
      bool factorize_rexovery = true)
    {
      return new Offset<NoticeSetting>();
    }

    [Token(Token = "0x601853D")]
    [Address(RVA = "0x26DC63C", Offset = "0x26DC63C", VA = "0x26DC63C")]
    public static void StartNoticeSetting(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601853E")]
    [Address(RVA = "0x26DC5CC", Offset = "0x26DC5CC", VA = "0x26DC5CC")]
    public static void AddBattleFinishVibration(
      FlatBufferBuilder builder,
      bool battleFinishVibration)
    {
    }

    [Token(Token = "0x601853F")]
    [Address(RVA = "0x26DC5AC", Offset = "0x26DC5AC", VA = "0x26DC5AC")]
    public static void AddPushNotice(FlatBufferBuilder builder, bool pushNotice)
    {
    }

    [Token(Token = "0x6018540")]
    [Address(RVA = "0x26DC58C", Offset = "0x26DC58C", VA = "0x26DC58C")]
    public static void AddAllApRecovery(FlatBufferBuilder builder, bool allApRecovery)
    {
    }

    [Token(Token = "0x6018541")]
    [Address(RVA = "0x26DC56C", Offset = "0x26DC56C", VA = "0x26DC56C")]
    public static void AddFragmentPoolFull(FlatBufferBuilder builder, bool fragmentPoolFull)
    {
    }

    [Token(Token = "0x6018542")]
    [Address(RVA = "0x26DC54C", Offset = "0x26DC54C", VA = "0x26DC54C")]
    public static void AddFactorizeRexovery(FlatBufferBuilder builder, bool factorizeRexovery)
    {
    }

    [Token(Token = "0x6018543")]
    [Address(RVA = "0x26DC5EC", Offset = "0x26DC5EC", VA = "0x26DC5EC")]
    public static Offset<NoticeSetting> EndNoticeSetting(FlatBufferBuilder builder)
    {
      return new Offset<NoticeSetting>();
    }

    [Token(Token = "0x6018544")]
    [Address(RVA = "0x26DC654", Offset = "0x26DC654", VA = "0x26DC654")]
    public static void FinishNoticeSettingBuffer(
      FlatBufferBuilder builder,
      Offset<NoticeSetting> offset)
    {
    }

    [Token(Token = "0x6018545")]
    [Address(RVA = "0x26DC6B0", Offset = "0x26DC6B0", VA = "0x26DC6B0")]
    public static void FinishSizePrefixedNoticeSettingBuffer(
      FlatBufferBuilder builder,
      Offset<NoticeSetting> offset)
    {
    }
  }
}
