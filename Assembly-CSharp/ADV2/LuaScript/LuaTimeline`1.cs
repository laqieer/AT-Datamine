// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaTimeline`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EE4")]
  [MoonSharpUserData]
  public class LuaTimeline<T> : LuaPlayableDirector<T> where T : Adv2Timeline
  {
    [Token(Token = "0x6019670")]
    public LuaTimeline(T instance)
    {
    }

    [Token(Token = "0x6019671")]
    protected void SetMuteTrack(bool isMuted, params string[] patterns)
    {
    }
  }
}
