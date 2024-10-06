// Decompiled with JetBrains decompiler
// Type: Story.BookAdvDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000569")]
  public class BookAdvDirector : IContentDirector
  {
    [Token(Token = "0x4001BE8")]
    [FieldOffset(Offset = "0x18")]
    private ContentBookAdv content;

    [Token(Token = "0x17000447")]
    public ContentTaskList WithTransitionIn
    {
      [Token(Token = "0x6001F32"), Address(RVA = "0x2A026E8", Offset = "0x2A026E8", VA = "0x2A026E8", Slot = "4")] get
      {
        return (ContentTaskList) null;
      }
    }

    [Token(Token = "0x6001F33")]
    [Address(RVA = "0x2A026F0", Offset = "0x2A026F0", VA = "0x2A026F0")]
    public BookAdvDirector(IAdvDirection direction)
    {
    }

    [Token(Token = "0x6001F34")]
    [Address(RVA = "0x2A02798", Offset = "0x2A02798", VA = "0x2A02798", Slot = "6")]
    public void Initialize(IStoryContentSystem contentSystem)
    {
    }

    [Token(Token = "0x6001F35")]
    [Address(RVA = "0x2A02888", Offset = "0x2A02888", VA = "0x2A02888", Slot = "9")]
    public void Abort()
    {
    }

    [Token(Token = "0x6001F36")]
    [Address(RVA = "0x2A028A8", Offset = "0x2A028A8", VA = "0x2A028A8", Slot = "7")]
    public void Start()
    {
    }

    [Token(Token = "0x6001F37")]
    [Address(RVA = "0x2A028D0", Offset = "0x2A028D0", VA = "0x2A028D0", Slot = "8")]
    public void Update()
    {
    }

    [Token(Token = "0x6001F38")]
    [Address(RVA = "0x2A028F0", Offset = "0x2A028F0", VA = "0x2A028F0", Slot = "5")]
    public Content GetContent() => (Content) null;
  }
}
