// Decompiled with JetBrains decompiler
// Type: Story.ISuperDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000592")]
  public interface ISuperDirector
  {
    [Token(Token = "0x6002030")]
    void Start();

    [Token(Token = "0x6002031")]
    void Update();

    [Token(Token = "0x6002032")]
    void Destroy();

    [Token(Token = "0x6002033")]
    void Direction(FlowTransition flowTransition, FlowContentPlay flowContent);

    [Token(Token = "0x6002034")]
    void OnEndContent(Content content);
  }
}
