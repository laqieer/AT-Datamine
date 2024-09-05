// Decompiled with JetBrains decompiler
// Type: GameCore.URPAssetAccessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
namespace GameCore
{
  [Token(Token = "0x2000BCD")]
  public class URPAssetAccessor : Singleton<URPAssetAccessor>
  {
    [Token(Token = "0x40035C2")]
    [FieldOffset(Offset = "0x10")]
    private FieldInfo MSAAFieldInfo;
    [Token(Token = "0x40035C3")]
    [FieldOffset(Offset = "0x18")]
    private FieldInfo MainLightCastShadowsFieldInfo;
    [Token(Token = "0x40035C4")]
    [FieldOffset(Offset = "0x20")]
    private FieldInfo AdditionalLightCastShadowsFieldInfo;
    [Token(Token = "0x40035C5")]
    [FieldOffset(Offset = "0x28")]
    private FieldInfo MainLightShadowmapResolutionFieldInfo;
    [Token(Token = "0x40035C6")]
    [FieldOffset(Offset = "0x30")]
    private FieldInfo AdditionalLightShadowmapResolution_FieldInfo;
    [Token(Token = "0x40035C7")]
    [FieldOffset(Offset = "0x38")]
    private FieldInfo Cascade2SplitFieldInfo;
    [Token(Token = "0x40035C8")]
    [FieldOffset(Offset = "0x40")]
    private FieldInfo Cascade4SplitFieldInfo;
    [Token(Token = "0x40035C9")]
    [FieldOffset(Offset = "0x48")]
    private FieldInfo SoftShadowsEnabledFieldInfo;
    [Token(Token = "0x40035CA")]
    [FieldOffset(Offset = "0x50")]
    private FieldInfo ColorGradingModeFieldInfo;
    [Token(Token = "0x40035CB")]
    [FieldOffset(Offset = "0x58")]
    private FieldInfo MainLightRenderingModeFieldInfo;
    [Token(Token = "0x40035CC")]
    [FieldOffset(Offset = "0x60")]
    private FieldInfo AdditionaLightRenderingModeFieldInfo;
    [Token(Token = "0x40035CD")]
    [FieldOffset(Offset = "0x68")]
    private FieldInfo HDRFieldInfo;

    [Token(Token = "0x6004369")]
    [Address(RVA = "0x363DA9C", Offset = "0x363DA9C", VA = "0x363DA9C")]
    public void Initialize(bool isDebug = false)
    {
    }

    [Token(Token = "0x170009C5")]
    public MsaaQuality MSAA
    {
      [Token(Token = "0x600436A"), Address(RVA = "0x3640440", Offset = "0x3640440", VA = "0x3640440")] get
      {
        return new MsaaQuality();
      }
      [Token(Token = "0x600436B"), Address(RVA = "0x363E128", Offset = "0x363E128", VA = "0x363E128")] set
      {
      }
    }

    [Token(Token = "0x170009C6")]
    public LightRenderingMode MainLightRenderingMode
    {
      [Token(Token = "0x600436C"), Address(RVA = "0x36404D4", Offset = "0x36404D4", VA = "0x36404D4")] get
      {
        return new LightRenderingMode();
      }
      [Token(Token = "0x600436D"), Address(RVA = "0x3640568", Offset = "0x3640568", VA = "0x3640568")] set
      {
      }
    }

    [Token(Token = "0x170009C7")]
    public LightRenderingMode AdditionaLightRenderingMode
    {
      [Token(Token = "0x600436E"), Address(RVA = "0x36405F0", Offset = "0x36405F0", VA = "0x36405F0")] get
      {
        return new LightRenderingMode();
      }
      [Token(Token = "0x600436F"), Address(RVA = "0x3640684", Offset = "0x3640684", VA = "0x3640684")] set
      {
      }
    }

    [Token(Token = "0x170009C8")]
    public bool MainLightCastShadows
    {
      [Token(Token = "0x6004370"), Address(RVA = "0x364070C", Offset = "0x364070C", VA = "0x364070C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004371"), Address(RVA = "0x36407A0", Offset = "0x36407A0", VA = "0x36407A0")] set
      {
      }
    }

    [Token(Token = "0x170009C9")]
    public bool AdditionalLightCastShadows
    {
      [Token(Token = "0x6004372"), Address(RVA = "0x3640828", Offset = "0x3640828", VA = "0x3640828")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004373"), Address(RVA = "0x36408BC", Offset = "0x36408BC", VA = "0x36408BC")] set
      {
      }
    }

    [Token(Token = "0x170009CA")]
    public ShadowResolution MainLightShadowResolution
    {
      [Token(Token = "0x6004374"), Address(RVA = "0x3640944", Offset = "0x3640944", VA = "0x3640944")] get
      {
        return new ShadowResolution();
      }
      [Token(Token = "0x6004375"), Address(RVA = "0x36409D8", Offset = "0x36409D8", VA = "0x36409D8")] set
      {
      }
    }

    [Token(Token = "0x170009CB")]
    public ShadowResolution AdditionalLightShadowResolution
    {
      [Token(Token = "0x6004376"), Address(RVA = "0x3640A60", Offset = "0x3640A60", VA = "0x3640A60")] get
      {
        return new ShadowResolution();
      }
      [Token(Token = "0x6004377"), Address(RVA = "0x3640AF4", Offset = "0x3640AF4", VA = "0x3640AF4")] set
      {
      }
    }

    [Token(Token = "0x170009CC")]
    public float Cascade2Split
    {
      [Token(Token = "0x6004378"), Address(RVA = "0x3640B7C", Offset = "0x3640B7C", VA = "0x3640B7C")] get
      {
        return new float();
      }
      [Token(Token = "0x6004379"), Address(RVA = "0x3640C10", Offset = "0x3640C10", VA = "0x3640C10")] set
      {
      }
    }

    [Token(Token = "0x170009CD")]
    public Vector3 Cascade4Split
    {
      [Token(Token = "0x600437A"), Address(RVA = "0x3640C98", Offset = "0x3640C98", VA = "0x3640C98")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x600437B"), Address(RVA = "0x3640D30", Offset = "0x3640D30", VA = "0x3640D30")] set
      {
      }
    }

    [Token(Token = "0x170009CE")]
    public bool SoftShadowsEnabled
    {
      [Token(Token = "0x600437C"), Address(RVA = "0x3640DD4", Offset = "0x3640DD4", VA = "0x3640DD4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600437D"), Address(RVA = "0x3640E68", Offset = "0x3640E68", VA = "0x3640E68")] set
      {
      }
    }

    [Token(Token = "0x170009CF")]
    public ColorGradingMode ColorGrading
    {
      [Token(Token = "0x600437E"), Address(RVA = "0x3640EF0", Offset = "0x3640EF0", VA = "0x3640EF0")] get
      {
        return new ColorGradingMode();
      }
      [Token(Token = "0x600437F"), Address(RVA = "0x3640F84", Offset = "0x3640F84", VA = "0x3640F84")] set
      {
      }
    }

    [Token(Token = "0x170009D0")]
    public bool HDR
    {
      [Token(Token = "0x6004380"), Address(RVA = "0x364100C", Offset = "0x364100C", VA = "0x364100C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004381"), Address(RVA = "0x36410A0", Offset = "0x36410A0", VA = "0x36410A0")] set
      {
      }
    }

    [Token(Token = "0x6004382")]
    [Address(RVA = "0x3641128", Offset = "0x3641128", VA = "0x3641128")]
    public URPAssetAccessor()
    {
    }
  }
}
