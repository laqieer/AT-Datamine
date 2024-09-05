// Decompiled with JetBrains decompiler
// Type: Story.Chart.UI.ILine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Story.Chart.UI
{
  [Token(Token = "0x20006FA")]
  public interface ILine
  {
    [Token(Token = "0x6002783")]
    void Set(Vector2 from, Vector2 to);

    [Token(Token = "0x6002784")]
    void ChangeStateNormal();

    [Token(Token = "0x6002785")]
    void ChangeStatePassed();

    [Token(Token = "0x6002786")]
    void ChangeStateEffect();

    [Token(Token = "0x6002787")]
    void Locked(bool locked);
  }
}
