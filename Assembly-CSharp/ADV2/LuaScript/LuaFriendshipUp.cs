// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaFriendshipUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;
using UnityEngine;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EB6")]
  [MoonSharpUserData]
  public class LuaFriendshipUp : LuaTimeline<Adv2FriendshipUp>
  {
    [Token(Token = "0x401131C")]
    [FieldOffset(Offset = "0x20")]
    private LuaObject followObject;

    [Token(Token = "0x6019418")]
    [Address(RVA = "0x2FF1B0C", Offset = "0x2FF1B0C", VA = "0x2FF1B0C")]
    public LuaFriendshipUp(Adv2FriendshipUp instance, Canvas rootCanvas)
    {
    }

    [Token(Token = "0x6019419")]
    [Address(RVA = "0x2FF1B98", Offset = "0x2FF1B98", VA = "0x2FF1B98")]
    public void SetFollowObject(LuaObject followObject, bool updateFollowPosition)
    {
    }

    [Token(Token = "0x601941A")]
    [Address(RVA = "0x2FF1BC4", Offset = "0x2FF1BC4", VA = "0x2FF1BC4")]
    public LuaSignalMini MoveFollowObject(float posX, float posY, float posZ, float duration)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x601941B")]
    [Address(RVA = "0x2FF1CA8", Offset = "0x2FF1CA8", VA = "0x2FF1CA8")]
    public void Play(int expDif)
    {
    }
  }
}
