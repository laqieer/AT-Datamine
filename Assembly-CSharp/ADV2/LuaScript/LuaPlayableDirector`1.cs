// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaPlayableDirector`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EC0")]
  [MoonSharpUserData]
  public abstract class LuaPlayableDirector<T> : LuaSignal where T : Adv2PlayableDirectorBase
  {
    [Token(Token = "0x4011348")]
    [FieldOffset(Offset = "0x0")]
    protected T advObject;

    [Token(Token = "0x60194BD")]
    public LuaPlayableDirector(T instance)
    {
    }

    [Token(Token = "0x60194BE")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x60194BF")]
    public bool IsActive() => new bool();
  }
}
