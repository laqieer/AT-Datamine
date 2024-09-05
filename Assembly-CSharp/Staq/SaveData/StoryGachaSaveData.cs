// Decompiled with JetBrains decompiler
// Type: staq.SaveData.StoryGachaSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using staq.SaveSchema;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D4E")]
  public class StoryGachaSaveData
  {
    [Token(Token = "0x4010D86")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, StoryGachaReleaseIdData> releasedStoryGachaIdDatas;
    [Token(Token = "0x4010D87")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, StoryGachaReleaseTitleData> releasedStoryGachaTitleDatas;

    [Token(Token = "0x17005099")]
    private static string Path
    {
      [Token(Token = "0x6018AB9"), Address(RVA = "0x263F2D4", Offset = "0x263F2D4", VA = "0x263F2D4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018ABA")]
    [Address(RVA = "0x263F324", Offset = "0x263F324", VA = "0x263F324")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6018ABB")]
    [Address(RVA = "0x263F36C", Offset = "0x263F36C", VA = "0x263F36C")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018ABC")]
    [Address(RVA = "0x263F384", Offset = "0x263F384", VA = "0x263F384")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018ABD")]
    [Address(RVA = "0x263F3B4", Offset = "0x263F3B4", VA = "0x263F3B4")]
    public void Load()
    {
    }

    [Token(Token = "0x6018ABE")]
    [Address(RVA = "0x263F878", Offset = "0x263F878", VA = "0x263F878")]
    public void Save()
    {
    }

    [Token(Token = "0x6018ABF")]
    [Address(RVA = "0x263F5AC", Offset = "0x263F5AC", VA = "0x263F5AC")]
    private void FromSchema(StoryGachaData storyGachaData)
    {
    }

    [Token(Token = "0x6018AC0")]
    [Address(RVA = "0x263FB3C", Offset = "0x263FB3C", VA = "0x263FB3C")]
    private StoryGachaReleaseIdData FromSchema(StoryGachaReleaseNotificationIDData schema)
    {
      return (StoryGachaReleaseIdData) null;
    }

    [Token(Token = "0x6018AC1")]
    [Address(RVA = "0x263FBC4", Offset = "0x263FBC4", VA = "0x263FBC4")]
    private StoryGachaReleaseTitleData FromSchema(StoryGachaReleaseNotificationTitleData schema)
    {
      return (StoryGachaReleaseTitleData) null;
    }

    [Token(Token = "0x6018AC2")]
    [Address(RVA = "0x263F914", Offset = "0x263F914", VA = "0x263F914")]
    public Offset<StoryGachaData> ToOffset(FlatBufferBuilder fbb) => new Offset<StoryGachaData>();

    [Token(Token = "0x6018AC3")]
    [Address(RVA = "0x263FC58", Offset = "0x263FC58", VA = "0x263FC58")]
    public Offset<StoryGachaReleaseNotificationIDData> ToOffset(
      StoryGachaReleaseIdData data,
      FlatBufferBuilder fbb)
    {
      return new Offset<StoryGachaReleaseNotificationIDData>();
    }

    [Token(Token = "0x6018AC4")]
    [Address(RVA = "0x263FC84", Offset = "0x263FC84", VA = "0x263FC84")]
    public Offset<StoryGachaReleaseNotificationTitleData> ToOffset(
      StoryGachaReleaseTitleData data,
      FlatBufferBuilder fbb)
    {
      return new Offset<StoryGachaReleaseNotificationTitleData>();
    }

    [Token(Token = "0x6018AC5")]
    [Address(RVA = "0x263FCD4", Offset = "0x263FCD4", VA = "0x263FCD4")]
    public void OnNotifiedInFreeAction(string title)
    {
    }

    [Token(Token = "0x6018AC6")]
    [Address(RVA = "0x263FDA0", Offset = "0x263FDA0", VA = "0x263FDA0")]
    public void OnNotifiedInStoryGachaTop(int groupId)
    {
    }

    [Token(Token = "0x6018AC7")]
    [Address(RVA = "0x263FE68", Offset = "0x263FE68", VA = "0x263FE68")]
    public void OnNotifiedInStoryGachaDetail(int groupId)
    {
    }

    [Token(Token = "0x6018AC8")]
    [Address(RVA = "0x263FDA8", Offset = "0x263FDA8", VA = "0x263FDA8")]
    private void ChangeNotificationStatus(int groupId, StoryGachaNotificationStatusType statusType)
    {
    }

    [Token(Token = "0x6018AC9")]
    [Address(RVA = "0x263FCDC", Offset = "0x263FCDC", VA = "0x263FCDC")]
    private void ChangeNotificationStatus(string title, bool isNotified)
    {
    }

    [Token(Token = "0x6018ACA")]
    [Address(RVA = "0x263FE70", Offset = "0x263FE70", VA = "0x263FE70")]
    public bool IsNotifiedGachaTop(int groupId) => new bool();

    [Token(Token = "0x6018ACB")]
    [Address(RVA = "0x263FEFC", Offset = "0x263FEFC", VA = "0x263FEFC")]
    public bool IsNotifiedGachaDetail(int groupId) => new bool();

    [Token(Token = "0x6018ACC")]
    [Address(RVA = "0x263FF88", Offset = "0x263FF88", VA = "0x263FF88")]
    public bool IsNotifiedInFreeAction(string title) => new bool();

    [Token(Token = "0x6018ACD")]
    [Address(RVA = "0x2640024", Offset = "0x2640024", VA = "0x2640024")]
    public IEnumerable<string> NotNotifiedTitles() => (IEnumerable<string>) null;

    [Token(Token = "0x6018ACE")]
    [Address(RVA = "0x26400D0", Offset = "0x26400D0", VA = "0x26400D0")]
    public void AddReleasedStoryGachaTitles(List<string> releasedStoryGachaTitles)
    {
    }

    [Token(Token = "0x6018ACF")]
    [Address(RVA = "0x2640210", Offset = "0x2640210", VA = "0x2640210")]
    public StoryGachaSaveData()
    {
    }
  }
}
