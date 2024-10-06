// Decompiled with JetBrains decompiler
// Type: Story.Chart.IBranch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006D3")]
  public interface IBranch
  {
    [Token(Token = "0x170005BC")]
    List<Node> Parents { [Token(Token = "0x60026B8")] get; }

    [Token(Token = "0x170005BD")]
    List<Node> Childs { [Token(Token = "0x60026B9")] get; }
  }
}
