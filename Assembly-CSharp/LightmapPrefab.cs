// Decompiled with JetBrains decompiler
// Type: LightmapPrefab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000B2")]
[ExecuteInEditMode]
public class LightmapPrefab : MonoBehaviour
{
  [Token(Token = "0x40002C4")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private LightmapPrefab.LightmapParameter[] lightmapParameters;

  [Token(Token = "0x6000587")]
  [Address(RVA = "0x44B31C0", Offset = "0x44B31C0", VA = "0x44B31C0")]
  private void Start()
  {
  }

  [Token(Token = "0x6000588")]
  [Address(RVA = "0x44B3258", Offset = "0x44B3258", VA = "0x44B3258")]
  [ContextMenu("Setup")]
  private void Setup()
  {
  }

  [Token(Token = "0x6000589")]
  [Address(RVA = "0x44B3410", Offset = "0x44B3410", VA = "0x44B3410")]
  public LightmapPrefab()
  {
  }

  [Token(Token = "0x20000B3")]
  [Serializable]
  private class LightmapParameter
  {
    [Token(Token = "0x40002C5")]
    [FieldOffset(Offset = "0x10")]
    public int lightmapIndex;
    [Token(Token = "0x40002C6")]
    [FieldOffset(Offset = "0x14")]
    public Vector4 scaleOffset;
    [Token(Token = "0x40002C7")]
    [FieldOffset(Offset = "0x28")]
    public Renderer renderer;

    [Token(Token = "0x600058A")]
    [Address(RVA = "0x44B321C", Offset = "0x44B321C", VA = "0x44B321C")]
    public void UpdateLightmapUVs()
    {
    }

    [Token(Token = "0x600058B")]
    [Address(RVA = "0x44B33B0", Offset = "0x44B33B0", VA = "0x44B33B0")]
    public LightmapParameter()
    {
    }
  }
}
