// Decompiled with JetBrains decompiler
// Type: StaqPostProcessPassFeature
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x200033D")]
[Serializable]
public class StaqPostProcessPassFeature : ScriptableRendererFeature
{
  [Token(Token = "0x4001396")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private StaqPostProcessData postProcessData;
  [Token(Token = "0x4001397")]
  [FieldOffset(Offset = "0x28")]
  private StaqPostprocessTiming timing;
  [Token(Token = "0x4001398")]
  [FieldOffset(Offset = "0x30")]
  private StaqPostProcessPass m_StaqPPPass;

  [Token(Token = "0x60012FB")]
  [Address(RVA = "0x2865310", Offset = "0x2865310", VA = "0x2865310", Slot = "5")]
  public override void Create()
  {
  }

  [Token(Token = "0x60012FC")]
  [Address(RVA = "0x2865384", Offset = "0x2865384", VA = "0x2865384", Slot = "7")]
  public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
  {
  }

  [Token(Token = "0x60012FD")]
  [Address(RVA = "0x286565C", Offset = "0x286565C", VA = "0x286565C")]
  public StaqPostProcessPassFeature()
  {
  }
}
