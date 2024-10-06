// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.StoryGachaReleaseNotificationTitleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CE4")]
  public struct StoryGachaReleaseNotificationTitleData : IFlatbufferObject
  {
    [Token(Token = "0x4010C45")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FED")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601874A"), Address(RVA = "0x29360FC", Offset = "0x29360FC", VA = "0x29360FC", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601874B")]
    [Address(RVA = "0x2936104", Offset = "0x2936104", VA = "0x2936104")]
    public static StoryGachaReleaseNotificationTitleData GetRootAsStoryGachaReleaseNotificationTitleData(
      ByteBuffer _bb)
    {
      return new StoryGachaReleaseNotificationTitleData();
    }

    [Token(Token = "0x601874C")]
    [Address(RVA = "0x2936110", Offset = "0x2936110", VA = "0x2936110")]
    public static StoryGachaReleaseNotificationTitleData GetRootAsStoryGachaReleaseNotificationTitleData(
      ByteBuffer _bb,
      StoryGachaReleaseNotificationTitleData obj)
    {
      return new StoryGachaReleaseNotificationTitleData();
    }

    [Token(Token = "0x601874D")]
    [Address(RVA = "0x293616C", Offset = "0x293616C", VA = "0x293616C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601874E")]
    [Address(RVA = "0x2936154", Offset = "0x2936154", VA = "0x2936154")]
    public StoryGachaReleaseNotificationTitleData __assign(int _i, ByteBuffer _bb)
    {
      return new StoryGachaReleaseNotificationTitleData();
    }

    [Token(Token = "0x17004FEE")]
    public string Title
    {
      [Token(Token = "0x601874F"), Address(RVA = "0x2936178", Offset = "0x2936178", VA = "0x2936178")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018750")]
    [Address(RVA = "0x29361B4", Offset = "0x29361B4", VA = "0x29361B4")]
    public ArraySegment<byte>? GetTitleBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018751")]
    [Address(RVA = "0x29361EC", Offset = "0x29361EC", VA = "0x29361EC")]
    public byte[] GetTitleArray() => (byte[]) null;

    [Token(Token = "0x17004FEF")]
    public bool Notified
    {
      [Token(Token = "0x6018752"), Address(RVA = "0x2936238", Offset = "0x2936238", VA = "0x2936238")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6018753")]
    [Address(RVA = "0x2936280", Offset = "0x2936280", VA = "0x2936280")]
    public static Offset<StoryGachaReleaseNotificationTitleData> CreateStoryGachaReleaseNotificationTitleData(
      FlatBufferBuilder builder,
      StringOffset titleOffset = default (StringOffset),
      bool notified = false)
    {
      return new Offset<StoryGachaReleaseNotificationTitleData>();
    }

    [Token(Token = "0x6018754")]
    [Address(RVA = "0x2936368", Offset = "0x2936368", VA = "0x2936368")]
    public static void StartStoryGachaReleaseNotificationTitleData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018755")]
    [Address(RVA = "0x29362D8", Offset = "0x29362D8", VA = "0x29362D8")]
    public static void AddTitle(FlatBufferBuilder builder, StringOffset titleOffset)
    {
    }

    [Token(Token = "0x6018756")]
    [Address(RVA = "0x29362F8", Offset = "0x29362F8", VA = "0x29362F8")]
    public static void AddNotified(FlatBufferBuilder builder, bool notified)
    {
    }

    [Token(Token = "0x6018757")]
    [Address(RVA = "0x2936318", Offset = "0x2936318", VA = "0x2936318")]
    public static Offset<StoryGachaReleaseNotificationTitleData> EndStoryGachaReleaseNotificationTitleData(
      FlatBufferBuilder builder)
    {
      return new Offset<StoryGachaReleaseNotificationTitleData>();
    }
  }
}
