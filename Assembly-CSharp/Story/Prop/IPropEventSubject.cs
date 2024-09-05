// Decompiled with JetBrains decompiler
// Type: Story.Prop.IPropEventSubject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story.Prop
{
  [Token(Token = "0x200066C")]
  public interface IPropEventSubject
  {
    [Token(Token = "0x60024D6")]
    void Subscribe(IPropEventObserver observer);
  }
}
