// Decompiled with JetBrains decompiler
// Type: Lua.LuaScriptableObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Lua
{
  [Token(Token = "0x200096B")]
  public class LuaScriptableObject : ScriptableObject
  {
    [Token(Token = "0x4002BAB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected char[] textData;

    [Token(Token = "0x1700077B")]
    public string Text
    {
      [Token(Token = "0x600352D"), Address(RVA = "0x35241E0", Offset = "0x35241E0", VA = "0x35241E0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600352E"), Address(RVA = "0x3524310", Offset = "0x3524310", VA = "0x3524310")] set
      {
      }
    }

    [Token(Token = "0x600352F")]
    [Address(RVA = "0x3524390", Offset = "0x3524390", VA = "0x3524390")]
    public LuaScriptableObject()
    {
    }
  }
}
