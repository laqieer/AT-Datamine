// Decompiled with JetBrains decompiler
// Type: StaqData.StoryID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020DA")]
  public struct StoryID
  {
    [Token(Token = "0x17002ABF")]
    public StoryID.Types Type
    {
      [Token(Token = "0x600C6F5"), Address(RVA = "0x1CDA4D8", Offset = "0x1CDA4D8", VA = "0x1CDA4D8")] readonly get
      {
        return new StoryID.Types();
      }
      [Token(Token = "0x600C6F6"), Address(RVA = "0x1CDA4E0", Offset = "0x1CDA4E0", VA = "0x1CDA4E0")] set
      {
      }
    }

    [Token(Token = "0x17002AC0")]
    public int ID
    {
      [Token(Token = "0x600C6F7"), Address(RVA = "0x1CDA4E8", Offset = "0x1CDA4E8", VA = "0x1CDA4E8")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600C6F8"), Address(RVA = "0x1CDA4F0", Offset = "0x1CDA4F0", VA = "0x1CDA4F0")] set
      {
      }
    }

    [Token(Token = "0x600C6F9")]
    [Address(RVA = "0x1CDA4F8", Offset = "0x1CDA4F8", VA = "0x1CDA4F8")]
    public StoryID(StoryID.Types type, int id)
    {
    }

    [Token(Token = "0x600C6FA")]
    [Address(RVA = "0x1CDA500", Offset = "0x1CDA500", VA = "0x1CDA500")]
    public void NotFoundLog()
    {
    }

    [Token(Token = "0x17002AC1")]
    public static StoryID MainStory
    {
      [Token(Token = "0x600C6FB"), Address(RVA = "0x1CD8DBC", Offset = "0x1CD8DBC", VA = "0x1CD8DBC")] get
      {
        return new StoryID();
      }
    }

    [Token(Token = "0x600C6FC")]
    [Address(RVA = "0x1CDA504", Offset = "0x1CDA504", VA = "0x1CDA504")]
    public static StoryID Chapter(int chapter) => new StoryID();

    [Token(Token = "0x600C6FD")]
    [Address(RVA = "0x1CDA50C", Offset = "0x1CDA50C", VA = "0x1CDA50C", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600C6FE")]
    [Address(RVA = "0x1CD8DC4", Offset = "0x1CD8DC4", VA = "0x1CD8DC4")]
    public static bool operator ==(StoryID first, StoryID second) => new bool();

    [Token(Token = "0x600C6FF")]
    [Address(RVA = "0x1CDA61C", Offset = "0x1CDA61C", VA = "0x1CDA61C")]
    public static bool operator !=(StoryID first, StoryID second) => new bool();

    [Token(Token = "0x600C700")]
    [Address(RVA = "0x1CDA68C", Offset = "0x1CDA68C", VA = "0x1CDA68C", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x20020DB")]
    public enum Types
    {
      [Token(Token = "0x4008B3C")] StoryChapter,
    }
  }
}
