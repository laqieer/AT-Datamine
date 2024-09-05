// Decompiled with JetBrains decompiler
// Type: Story.IContentTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x200058A")]
  public interface IContentTask
  {
    [Token(Token = "0x6001FFC")]
    IEnumerator Start();

    [Token(Token = "0x6001FFD")]
    void Update();

    [Token(Token = "0x6001FFE")]
    bool IsBusy();
  }
}
