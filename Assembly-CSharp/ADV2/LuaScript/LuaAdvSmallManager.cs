// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaAdvSmallManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;
using UnityEngine;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EA2")]
  [MoonSharpUserData]
  public class LuaAdvSmallManager : LuaObject
  {
    [Token(Token = "0x40112E6")]
    [FieldOffset(Offset = "0x38")]
    private AdvSmallManager manager;
    [Token(Token = "0x40112E7")]
    [FieldOffset(Offset = "0x40")]
    private int selectedMobsNo;
    [Token(Token = "0x40112E8")]
    [FieldOffset(Offset = "0x48")]
    private GameObject mobsGameObject;

    [Token(Token = "0x601935B")]
    [Address(RVA = "0x2D06B88", Offset = "0x2D06B88", VA = "0x2D06B88")]
    public LuaAdvSmallManager(AdvSmallManager instance)
    {
    }

    [Token(Token = "0x601935C")]
    [Address(RVA = "0x2D06BC8", Offset = "0x2D06BC8", VA = "0x2D06BC8")]
    public void RegisterExclusiveCamera(LuaObject camera, LuaObject actor)
    {
    }

    [Token(Token = "0x601935D")]
    [Address(RVA = "0x2D06C84", Offset = "0x2D06C84", VA = "0x2D06C84")]
    public void ResetExclusiveCamera()
    {
    }

    [Token(Token = "0x601935E")]
    [Address(RVA = "0x2D06CA0", Offset = "0x2D06CA0", VA = "0x2D06CA0")]
    public void RegisterRandomCamera(LuaObject camera)
    {
    }

    [Token(Token = "0x601935F")]
    [Address(RVA = "0x2D06D44", Offset = "0x2D06D44", VA = "0x2D06D44")]
    public void ResetRandomCamera()
    {
    }

    [Token(Token = "0x6019360")]
    [Address(RVA = "0x2D06D60", Offset = "0x2D06D60", VA = "0x2D06D60")]
    public void CloseupUpExclusiveCamera(LuaObject actor)
    {
    }

    [Token(Token = "0x6019361")]
    [Address(RVA = "0x2D06D84", Offset = "0x2D06D84", VA = "0x2D06D84")]
    public void DontCameraOffset(LuaObject actor)
    {
    }

    [Token(Token = "0x6019362")]
    [Address(RVA = "0x2D06DA8", Offset = "0x2D06DA8", VA = "0x2D06DA8")]
    public void DontChangeRandomCamera(bool flag)
    {
    }

    [Token(Token = "0x6019363")]
    [Address(RVA = "0x2D06DC8", Offset = "0x2D06DC8", VA = "0x2D06DC8")]
    public void RestartRandomCamera()
    {
    }

    [Token(Token = "0x6019364")]
    [Address(RVA = "0x2D06DE4", Offset = "0x2D06DE4", VA = "0x2D06DE4")]
    public bool IsRndCameraActive() => new bool();

    [Token(Token = "0x6019365")]
    [Address(RVA = "0x2D06E00", Offset = "0x2D06E00", VA = "0x2D06E00")]
    private void loadMobCallback(Object loaded)
    {
    }

    [Token(Token = "0x6019366")]
    [Address(RVA = "0x2D06F84", Offset = "0x2D06F84", VA = "0x2D06F84")]
    public LuaSignal LoadMobs(int modelId, int templateNo) => (LuaSignal) null;

    [Token(Token = "0x6019367")]
    [Address(RVA = "0x2D071BC", Offset = "0x2D071BC", VA = "0x2D071BC")]
    public LuaSignal LoadMobsDuel(int templateNo) => (LuaSignal) null;

    [Token(Token = "0x6019368")]
    [Address(RVA = "0x2D073D8", Offset = "0x2D073D8", VA = "0x2D073D8")]
    public void SetMobsNo(int selectedMobNo)
    {
    }

    [Token(Token = "0x6019369")]
    [Address(RVA = "0x2D073E0", Offset = "0x2D073E0", VA = "0x2D073E0")]
    public void SwitchMob(bool active)
    {
    }
  }
}
