// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.StoryGachaReleaseNotificationIDData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CE3")]
  public struct StoryGachaReleaseNotificationIDData : IFlatbufferObject
  {
    [Token(Token = "0x4010C44")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FEA")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601873E"), Address(RVA = "0x2935EF8", Offset = "0x2935EF8", VA = "0x2935EF8", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601873F")]
    [Address(RVA = "0x2935F00", Offset = "0x2935F00", VA = "0x2935F00")]
    public static StoryGachaReleaseNotificationIDData GetRootAsStoryGachaReleaseNotificationIDData(
      ByteBuffer _bb)
    {
      return new StoryGachaReleaseNotificationIDData();
    }

    [Token(Token = "0x6018740")]
    [Address(RVA = "0x2935F0C", Offset = "0x2935F0C", VA = "0x2935F0C")]
    public static StoryGachaReleaseNotificationIDData GetRootAsStoryGachaReleaseNotificationIDData(
      ByteBuffer _bb,
      StoryGachaReleaseNotificationIDData obj)
    {
      return new StoryGachaReleaseNotificationIDData();
    }

    [Token(Token = "0x6018741")]
    [Address(RVA = "0x2935F68", Offset = "0x2935F68", VA = "0x2935F68", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018742")]
    [Address(RVA = "0x2935F50", Offset = "0x2935F50", VA = "0x2935F50")]
    public StoryGachaReleaseNotificationIDData __assign(int _i, ByteBuffer _bb)
    {
      return new StoryGachaReleaseNotificationIDData();
    }

    [Token(Token = "0x17004FEB")]
    public int GroupId
    {
      [Token(Token = "0x6018743"), Address(RVA = "0x2935F74", Offset = "0x2935F74", VA = "0x2935F74")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004FEC")]
    public int NotificationStatus
    {
      [Token(Token = "0x6018744"), Address(RVA = "0x2935FB8", Offset = "0x2935FB8", VA = "0x2935FB8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018745")]
    [Address(RVA = "0x2935FFC", Offset = "0x2935FFC", VA = "0x2935FFC")]
    public static Offset<StoryGachaReleaseNotificationIDData> CreateStoryGachaReleaseNotificationIDData(
      FlatBufferBuilder builder,
      int groupId = 0,
      int notificationStatus = 0)
    {
      return new Offset<StoryGachaReleaseNotificationIDData>();
    }

    [Token(Token = "0x6018746")]
    [Address(RVA = "0x29360E4", Offset = "0x29360E4", VA = "0x29360E4")]
    public static void StartStoryGachaReleaseNotificationIDData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018747")]
    [Address(RVA = "0x2936074", Offset = "0x2936074", VA = "0x2936074")]
    public static void AddGroupId(FlatBufferBuilder builder, int groupId)
    {
    }

    [Token(Token = "0x6018748")]
    [Address(RVA = "0x2936054", Offset = "0x2936054", VA = "0x2936054")]
    public static void AddNotificationStatus(FlatBufferBuilder builder, int notificationStatus)
    {
    }

    [Token(Token = "0x6018749")]
    [Address(RVA = "0x2936094", Offset = "0x2936094", VA = "0x2936094")]
    public static Offset<StoryGachaReleaseNotificationIDData> EndStoryGachaReleaseNotificationIDData(
      FlatBufferBuilder builder)
    {
      return new Offset<StoryGachaReleaseNotificationIDData>();
    }
  }
}
