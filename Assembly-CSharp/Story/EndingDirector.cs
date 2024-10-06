// Decompiled with JetBrains decompiler
// Type: Story.EndingDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x200056A")]
  public class EndingDirector : IContentDirector
  {
    [Token(Token = "0x4001BEA")]
    [FieldOffset(Offset = "0x18")]
    private ContentEnding content;

    [Token(Token = "0x17000448")]
    public ContentTaskList WithTransitionIn
    {
      [Token(Token = "0x6001F39"), Address(RVA = "0x2A028F8", Offset = "0x2A028F8", VA = "0x2A028F8", Slot = "4")] get
      {
        return (ContentTaskList) null;
      }
    }

    [Token(Token = "0x6001F3A")]
    [Address(RVA = "0x2A02900", Offset = "0x2A02900", VA = "0x2A02900")]
    public EndingDirector()
    {
    }

    [Token(Token = "0x6001F3B")]
    [Address(RVA = "0x2A029A0", Offset = "0x2A029A0", VA = "0x2A029A0", Slot = "6")]
    public void Initialize(IStoryContentSystem contentSystem)
    {
    }

    [Token(Token = "0x6001F3C")]
    [Address(RVA = "0x2A029BC", Offset = "0x2A029BC", VA = "0x2A029BC", Slot = "9")]
    public void Abort()
    {
    }

    [Token(Token = "0x6001F3D")]
    [Address(RVA = "0x2A029DC", Offset = "0x2A029DC", VA = "0x2A029DC", Slot = "7")]
    public void Start()
    {
    }

    [Token(Token = "0x6001F3E")]
    [Address(RVA = "0x2A02A04", Offset = "0x2A02A04", VA = "0x2A02A04", Slot = "8")]
    public void Update()
    {
    }

    [Token(Token = "0x6001F3F")]
    [Address(RVA = "0x2A02A24", Offset = "0x2A02A24", VA = "0x2A02A24", Slot = "5")]
    public Content GetContent() => (Content) null;
  }
}
