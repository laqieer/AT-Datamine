// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Common.IDotArrayControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Common
{
  [Token(Token = "0x20036FD")]
  internal interface IDotArrayControl
  {
    [Token(Token = "0x170047A4")]
    GameObject Root { [Token(Token = "0x6015A88")] get; }

    [Token(Token = "0x170047A5")]
    bool this[int index] { [Token(Token = "0x6015A89")] get; [Token(Token = "0x6015A8A")] set; }

    [Token(Token = "0x170047A6")]
    int Size { [Token(Token = "0x6015A8B")] get; }

    [Token(Token = "0x170047A7")]
    int DisplaySize { [Token(Token = "0x6015A8C")] get; [Token(Token = "0x6015A8D")] set; }

    [Token(Token = "0x6015A8E")]
    void SetNumber(int number);
  }
}
