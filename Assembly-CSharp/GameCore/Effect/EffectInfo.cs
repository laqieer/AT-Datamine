// Decompiled with JetBrains decompiler
// Type: GameCore.Effect.EffectInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.Effect
{
  [Token(Token = "0x2001473")]
  public struct EffectInfo
  {
    [Token(Token = "0x4005E11")]
    [FieldOffset(Offset = "0x0")]
    public string AssetBundleLabel;
    [Token(Token = "0x4005E12")]
    [FieldOffset(Offset = "0x8")]
    public string Label;
    [Token(Token = "0x4005E13")]
    [FieldOffset(Offset = "0x10")]
    public string SEName;
    [Token(Token = "0x4005E14")]
    [FieldOffset(Offset = "0x18")]
    public string PrefabName;
    [Token(Token = "0x4005E15")]
    [FieldOffset(Offset = "0x20")]
    public bool AllowMultipleClone;
  }
}
