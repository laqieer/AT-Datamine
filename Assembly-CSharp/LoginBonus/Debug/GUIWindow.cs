// Decompiled with JetBrains decompiler
// Type: LoginBonus.Debug.GUIWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace LoginBonus.Debug
{
  [Token(Token = "0x2000B18")]
  internal abstract class GUIWindow : IGUIWindow
  {
    [Token(Token = "0x400329C")]
    [FieldOffset(Offset = "0x18")]
    private readonly int id;

    [Token(Token = "0x17000926")]
    public string WindowTitle
    {
      [Token(Token = "0x6003F26"), Address(RVA = "0x2C1AA58", Offset = "0x2C1AA58", VA = "0x2C1AA58", Slot = "4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6003F27"), Address(RVA = "0x2C1AA60", Offset = "0x2C1AA60", VA = "0x2C1AA60")] private set
      {
      }
    }

    [Token(Token = "0x17000927")]
    public Rect Position
    {
      [Token(Token = "0x6003F28"), Address(RVA = "0x2C1AA68", Offset = "0x2C1AA68", VA = "0x2C1AA68", Slot = "5")] get
      {
        return new Rect();
      }
      [Token(Token = "0x6003F29"), Address(RVA = "0x2C1AA74", Offset = "0x2C1AA74", VA = "0x2C1AA74", Slot = "6")] set
      {
      }
    }

    [Token(Token = "0x6003F2A")]
    [Address(RVA = "0x2C195CC", Offset = "0x2C195CC", VA = "0x2C195CC")]
    public GUIWindow(int id, string title)
    {
    }

    [Token(Token = "0x6003F2B")]
    public abstract void OnGUI(int id);

    [Token(Token = "0x6003F2C")]
    [Address(RVA = "0x2C18314", Offset = "0x2C18314", VA = "0x2C18314", Slot = "7")]
    public void OnGUI()
    {
    }
  }
}
