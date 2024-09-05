// Decompiled with JetBrains decompiler
// Type: staq.SaveData.StoryGachaReleaseIdData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D4C")]
  public class StoryGachaReleaseIdData
  {
    [Token(Token = "0x4010D82")]
    [FieldOffset(Offset = "0x10")]
    public int GroupId;
    [Token(Token = "0x4010D83")]
    [FieldOffset(Offset = "0x14")]
    public StoryGachaNotificationStatusType NotificationStatus;

    [Token(Token = "0x6018AB5")]
    [Address(RVA = "0x263F1DC", Offset = "0x263F1DC", VA = "0x263F1DC")]
    public static StoryGachaReleaseIdData Create(
      int groupId,
      StoryGachaNotificationStatusType statusType)
    {
      return (StoryGachaReleaseIdData) null;
    }

    [Token(Token = "0x6018AB6")]
    [Address(RVA = "0x263F24C", Offset = "0x263F24C", VA = "0x263F24C")]
    public StoryGachaReleaseIdData()
    {
    }
  }
}
