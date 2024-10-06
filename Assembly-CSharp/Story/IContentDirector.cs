// Decompiled with JetBrains decompiler
// Type: Story.IContentDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000593")]
  public interface IContentDirector
  {
    [Token(Token = "0x17000479")]
    ContentTaskList WithTransitionIn { [Token(Token = "0x6002035")] get; }

    [Token(Token = "0x6002036")]
    Content GetContent();

    [Token(Token = "0x6002037")]
    void Initialize(IStoryContentSystem contentSystem);

    [Token(Token = "0x6002038")]
    void Start();

    [Token(Token = "0x6002039")]
    void Update();

    [Token(Token = "0x600203A")]
    void Abort();
  }
}
