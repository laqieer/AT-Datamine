// Decompiled with JetBrains decompiler
// Type: Story.AdvDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000563")]
  public class AdvDirector : IContentDirector
  {
    [Token(Token = "0x4001BDC")]
    [FieldOffset(Offset = "0x18")]
    private ContentAdv content;

    [Token(Token = "0x17000443")]
    public ContentTaskList WithTransitionIn
    {
      [Token(Token = "0x6001F10"), Address(RVA = "0x2A019C0", Offset = "0x2A019C0", VA = "0x2A019C0", Slot = "4")] get
      {
        return (ContentTaskList) null;
      }
    }

    [Token(Token = "0x6001F11")]
    [Address(RVA = "0x2A019C8", Offset = "0x2A019C8", VA = "0x2A019C8")]
    public AdvDirector(IAdvDirection direction)
    {
    }

    [Token(Token = "0x6001F12")]
    [Address(RVA = "0x2A01AEC", Offset = "0x2A01AEC", VA = "0x2A01AEC", Slot = "6")]
    public void Initialize(IStoryContentSystem contentSystem)
    {
    }

    [Token(Token = "0x6001F13")]
    [Address(RVA = "0x2A01C20", Offset = "0x2A01C20", VA = "0x2A01C20", Slot = "9")]
    public void Abort()
    {
    }

    [Token(Token = "0x6001F14")]
    [Address(RVA = "0x2A01C40", Offset = "0x2A01C40", VA = "0x2A01C40", Slot = "7")]
    public void Start()
    {
    }

    [Token(Token = "0x6001F15")]
    [Address(RVA = "0x2A01C68", Offset = "0x2A01C68", VA = "0x2A01C68", Slot = "8")]
    public void Update()
    {
    }

    [Token(Token = "0x6001F16")]
    [Address(RVA = "0x2A01C88", Offset = "0x2A01C88", VA = "0x2A01C88", Slot = "5")]
    public Content GetContent() => (Content) null;
  }
}
