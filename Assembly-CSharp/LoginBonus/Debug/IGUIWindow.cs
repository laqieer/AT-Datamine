// Decompiled with JetBrains decompiler
// Type: LoginBonus.Debug.IGUIWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace LoginBonus.Debug
{
  [Token(Token = "0x2000B19")]
  internal interface IGUIWindow
  {
    [Token(Token = "0x17000928")]
    string WindowTitle { [Token(Token = "0x6003F2D")] get; }

    [Token(Token = "0x17000929")]
    Rect Position { [Token(Token = "0x6003F2E")] get; [Token(Token = "0x6003F2F")] set; }

    [Token(Token = "0x6003F30")]
    void OnGUI();
  }
}
