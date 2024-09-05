// Decompiled with JetBrains decompiler
// Type: Story.FreeAction.Notify.Element
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Story.FreeAction.Notify
{
  [Token(Token = "0x2000698")]
  public struct Element
  {
    [Token(Token = "0x1700057E")]
    public readonly string Title
    {
      [Token(Token = "0x6002581"), Address(RVA = "0x2F3B460", Offset = "0x2F3B460", VA = "0x2F3B460")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700057F")]
    public readonly string Text
    {
      [Token(Token = "0x6002582"), Address(RVA = "0x2F3B468", Offset = "0x2F3B468", VA = "0x2F3B468")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000580")]
    public readonly int Priority
    {
      [Token(Token = "0x6002583"), Address(RVA = "0x2F3B470", Offset = "0x2F3B470", VA = "0x2F3B470")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000581")]
    public readonly int ID
    {
      [Token(Token = "0x6002584"), Address(RVA = "0x2F3B478", Offset = "0x2F3B478", VA = "0x2F3B478")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000582")]
    public readonly bool ShowTitle
    {
      [Token(Token = "0x6002585"), Address(RVA = "0x2F3B480", Offset = "0x2F3B480", VA = "0x2F3B480")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6002586")]
    [Address(RVA = "0x2F3B488", Offset = "0x2F3B488", VA = "0x2F3B488")]
    public Element(StoryNotifyTypeEnum type, string name, int id)
    {
    }
  }
}
