// Decompiled with JetBrains decompiler
// Type: Story.Chart.Chapter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006B9")]
  public class Chapter
  {
    [Token(Token = "0x4002011")]
    [FieldOffset(Offset = "0x10")]
    public Tree Tree;
    [Token(Token = "0x4002012")]
    [FieldOffset(Offset = "0x18")]
    private StoryChapterData chapter;

    [Token(Token = "0x1700059F")]
    public int ID
    {
      [Token(Token = "0x6002613"), Address(RVA = "0x2F3FD44", Offset = "0x2F3FD44", VA = "0x2F3FD44")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170005A0")]
    public string Name
    {
      [Token(Token = "0x6002614"), Address(RVA = "0x2F3FD60", Offset = "0x2F3FD60", VA = "0x2F3FD60")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6002615")]
    [Address(RVA = "0x2F3FD7C", Offset = "0x2F3FD7C", VA = "0x2F3FD7C")]
    public Chapter(StoryChapterData chapter)
    {
    }

    [Token(Token = "0x6002616")]
    [Address(RVA = "0x2F402A4", Offset = "0x2F402A4", VA = "0x2F402A4")]
    public Chapter(StoryChapterData chapter, Dictionary<int, Node> nodes)
    {
    }

    [Token(Token = "0x6002617")]
    [Address(RVA = "0x2F403F4", Offset = "0x2F403F4", VA = "0x2F403F4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6002618")]
    [Address(RVA = "0x2F40C60", Offset = "0x2F40C60", VA = "0x2F40C60")]
    public Node GetCurrentNode() => (Node) null;
  }
}
