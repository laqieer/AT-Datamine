// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.Adv2LuaUIShader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EF5")]
  [MoonSharpUserData]
  public class Adv2LuaUIShader : LuaUI
  {
    [Token(Token = "0x4011409")]
    [FieldOffset(Offset = "0x40")]
    private string ImageObject;
    [Token(Token = "0x401140A")]
    [FieldOffset(Offset = "0x48")]
    protected Adv2Manager.OnProccessSignal playingSignal;
    [Token(Token = "0x401140B")]
    [FieldOffset(Offset = "0x50")]
    private Material targetMaterial;
    [Token(Token = "0x401140C")]
    [FieldOffset(Offset = "0x58")]
    private Image image;
    [Token(Token = "0x401140D")]
    [FieldOffset(Offset = "0x60")]
    private float referenceWidth;

    [Token(Token = "0x6019715")]
    [Address(RVA = "0x373D8C8", Offset = "0x373D8C8", VA = "0x373D8C8")]
    public Adv2LuaUIShader(Adv2UI instance)
    {
    }

    [Token(Token = "0x6019716")]
    [Address(RVA = "0x373D95C", Offset = "0x373D95C", VA = "0x373D95C")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6019717")]
    [Address(RVA = "0x373DA5C", Offset = "0x373DA5C", VA = "0x373DA5C")]
    public void SetParameter(string parameterName, float n)
    {
    }

    [Token(Token = "0x6019718")]
    [Address(RVA = "0x373DABC", Offset = "0x373DABC", VA = "0x373DABC")]
    public LuaSignalMini ParameterAnimation(string parameterName, float to, float duration)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x6019719")]
    [Address(RVA = "0x373DC6C", Offset = "0x373DC6C", VA = "0x373DC6C")]
    private void signalEnd()
    {
    }

    [Token(Token = "0x601971A")]
    [Address(RVA = "0x373DBDC", Offset = "0x373DBDC", VA = "0x373DBDC")]
    private IEnumerator coParamatorAnimation(
      string paramaterName,
      float to,
      float duration,
      Action callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601971B")]
    [Address(RVA = "0x373DCB8", Offset = "0x373DCB8", VA = "0x373DCB8")]
    public float GetScreenRatioX(float pixelSize) => new float();

    [Token(Token = "0x601971C")]
    [Address(RVA = "0x373DDD0", Offset = "0x373DDD0", VA = "0x373DDD0")]
    public float GetScreenRatioY(float pixelSize) => new float();

    [Token(Token = "0x601971D")]
    [Address(RVA = "0x373DCF0", Offset = "0x373DCF0", VA = "0x373DCF0")]
    private float GetScreenRatioPos(float pixelSize) => new float();
  }
}
