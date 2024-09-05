// Decompiled with JetBrains decompiler
// Type: Story.ObliviaeContinueDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x200056D")]
  public class ObliviaeContinueDirector : IContentDirector
  {
    [Token(Token = "0x4001BF1")]
    [FieldOffset(Offset = "0x18")]
    private ContentObliviaeContinue content;

    [Token(Token = "0x1700044D")]
    public ContentTaskList WithTransitionIn
    {
      [Token(Token = "0x6001F51"), Address(RVA = "0x2A02E34", Offset = "0x2A02E34", VA = "0x2A02E34", Slot = "4")] get
      {
        return (ContentTaskList) null;
      }
    }

    [Token(Token = "0x6001F52")]
    [Address(RVA = "0x2A02E3C", Offset = "0x2A02E3C", VA = "0x2A02E3C")]
    public ObliviaeContinueDirector()
    {
    }

    [Token(Token = "0x6001F53")]
    [Address(RVA = "0x2A02ED4", Offset = "0x2A02ED4", VA = "0x2A02ED4", Slot = "5")]
    public Content GetContent() => (Content) null;

    [Token(Token = "0x6001F54")]
    [Address(RVA = "0x2A02EDC", Offset = "0x2A02EDC", VA = "0x2A02EDC", Slot = "6")]
    public void Initialize(IStoryContentSystem contentSystem)
    {
    }

    [Token(Token = "0x6001F55")]
    [Address(RVA = "0x2A02EF8", Offset = "0x2A02EF8", VA = "0x2A02EF8", Slot = "7")]
    public void Start()
    {
    }

    [Token(Token = "0x6001F56")]
    [Address(RVA = "0x2A02F20", Offset = "0x2A02F20", VA = "0x2A02F20", Slot = "8")]
    public void Update()
    {
    }

    [Token(Token = "0x6001F57")]
    [Address(RVA = "0x2A02F40", Offset = "0x2A02F40", VA = "0x2A02F40", Slot = "9")]
    public void Abort()
    {
    }
  }
}
