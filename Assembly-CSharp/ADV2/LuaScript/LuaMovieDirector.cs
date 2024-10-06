// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaMovieDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;
using System;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EB9")]
  [MoonSharpUserData]
  public class LuaMovieDirector : LuaSignal, IDisposable
  {
    [Token(Token = "0x401133D")]
    [FieldOffset(Offset = "0x18")]
    protected Adv2MovieDirector advObject;

    [Token(Token = "0x6019461")]
    [Address(RVA = "0x2FF50EC", Offset = "0x2FF50EC", VA = "0x2FF50EC", Slot = "5")]
    public void Dispose()
    {
    }

    [Token(Token = "0x6019462")]
    [Address(RVA = "0x2FF50F0", Offset = "0x2FF50F0", VA = "0x2FF50F0")]
    public LuaMovieDirector(Adv2MovieDirector instance)
    {
    }

    [Token(Token = "0x6019463")]
    [Address(RVA = "0x2FF5118", Offset = "0x2FF5118", VA = "0x2FF5118")]
    public LuaSignalMini LoadMovie(
      string movieAssetPath,
      string subtitlesBaseName,
      bool existH265,
      int movieWidth,
      int movieHeight,
      bool verticalFit)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019464")]
    [Address(RVA = "0x2FF5220", Offset = "0x2FF5220", VA = "0x2FF5220")]
    public LuaSignalMini Play() => (LuaSignalMini) null;

    [Token(Token = "0x6019465")]
    [Address(RVA = "0x2FF52E0", Offset = "0x2FF52E0", VA = "0x2FF52E0")]
    public void Stop()
    {
    }

    [Token(Token = "0x6019466")]
    [Address(RVA = "0x2FF52FC", Offset = "0x2FF52FC", VA = "0x2FF52FC")]
    public void Pause()
    {
    }

    [Token(Token = "0x6019467")]
    [Address(RVA = "0x2FF5318", Offset = "0x2FF5318", VA = "0x2FF5318")]
    public void SetActive(bool active)
    {
    }

    [Token(Token = "0x6019468")]
    [Address(RVA = "0x2FF5338", Offset = "0x2FF5338", VA = "0x2FF5338")]
    public void SetPlaybackSpeed(float speed)
    {
    }
  }
}
