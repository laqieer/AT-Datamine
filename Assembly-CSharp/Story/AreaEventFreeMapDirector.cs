// Decompiled with JetBrains decompiler
// Type: Story.AreaEventFreeMapDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000564")]
  public class AreaEventFreeMapDirector : IContentDirector
  {
    [Token(Token = "0x4001BDE")]
    [FieldOffset(Offset = "0x18")]
    private ContentAreaEventFreeMap content;

    [Token(Token = "0x17000444")]
    public ContentTaskList WithTransitionIn
    {
      [Token(Token = "0x6001F17"), Address(RVA = "0x2A01C90", Offset = "0x2A01C90", VA = "0x2A01C90", Slot = "4")] get
      {
        return (ContentTaskList) null;
      }
    }

    [Token(Token = "0x6001F18")]
    [Address(RVA = "0x2A01C98", Offset = "0x2A01C98", VA = "0x2A01C98")]
    public AreaEventFreeMapDirector(IFreeMapDirection direction)
    {
    }

    [Token(Token = "0x6001F19")]
    [Address(RVA = "0x2A01D40", Offset = "0x2A01D40", VA = "0x2A01D40", Slot = "6")]
    public void Initialize(IStoryContentSystem contentSystem)
    {
    }

    [Token(Token = "0x6001F1A")]
    [Address(RVA = "0x2A01E14", Offset = "0x2A01E14", VA = "0x2A01E14", Slot = "9")]
    public void Abort()
    {
    }

    [Token(Token = "0x6001F1B")]
    [Address(RVA = "0x2A01E34", Offset = "0x2A01E34", VA = "0x2A01E34", Slot = "7")]
    public void Start()
    {
    }

    [Token(Token = "0x6001F1C")]
    [Address(RVA = "0x2A01E5C", Offset = "0x2A01E5C", VA = "0x2A01E5C", Slot = "8")]
    public void Update()
    {
    }

    [Token(Token = "0x6001F1D")]
    [Address(RVA = "0x2A01E7C", Offset = "0x2A01E7C", VA = "0x2A01E7C", Slot = "5")]
    public Content GetContent() => (Content) null;
  }
}
