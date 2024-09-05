// Decompiled with JetBrains decompiler
// Type: staq.SaveData.StoryGachaReleaseTitleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D4D")]
  public class StoryGachaReleaseTitleData
  {
    [Token(Token = "0x4010D84")]
    [FieldOffset(Offset = "0x10")]
    public string Title;
    [Token(Token = "0x4010D85")]
    [FieldOffset(Offset = "0x18")]
    public bool IsNotified;

    [Token(Token = "0x6018AB7")]
    [Address(RVA = "0x263F254", Offset = "0x263F254", VA = "0x263F254")]
    public static StoryGachaReleaseTitleData Create(string title, bool isNotified)
    {
      return (StoryGachaReleaseTitleData) null;
    }

    [Token(Token = "0x6018AB8")]
    [Address(RVA = "0x263F2CC", Offset = "0x263F2CC", VA = "0x263F2CC")]
    public StoryGachaReleaseTitleData()
    {
    }
  }
}
