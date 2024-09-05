// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;
using UnityEngine;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EAD")]
  [MoonSharpUserData]
  public class LuaCamera : LuaObject
  {
    [Token(Token = "0x401130A")]
    [FieldOffset(Offset = "0x38")]
    private LuaCamera.PostProcessLayerSetupper postprocessLayerSetupper;

    [Token(Token = "0x60193C9")]
    [Address(RVA = "0x2FEE3BC", Offset = "0x2FEE3BC", VA = "0x2FEE3BC")]
    public LuaCamera(Adv2Camera instance)
    {
    }

    [Token(Token = "0x60193CA")]
    [Address(RVA = "0x2FEE450", Offset = "0x2FEE450", VA = "0x2FEE450")]
    public void SetCamera()
    {
    }

    [Token(Token = "0x60193CB")]
    [Address(RVA = "0x2FEE6E0", Offset = "0x2FEE6E0", VA = "0x2FEE6E0", Slot = "6")]
    public override void InitializeTransform(
      float posX,
      float posY,
      float posZ,
      float angX,
      float angY,
      float angZ,
      float scaleX,
      float scaleY,
      float scaleZ)
    {
    }

    [Token(Token = "0x60193CC")]
    [Address(RVA = "0x2FEE870", Offset = "0x2FEE870", VA = "0x2FEE870")]
    public void SetBindObject(LuaObject target)
    {
    }

    [Token(Token = "0x60193CD")]
    [Address(RVA = "0x2FEE984", Offset = "0x2FEE984", VA = "0x2FEE984")]
    public void FieldOfView(float value)
    {
    }

    [Token(Token = "0x60193CE")]
    [Address(RVA = "0x2FEEA14", Offset = "0x2FEEA14", VA = "0x2FEEA14")]
    public void Dutch(float value)
    {
    }

    [Token(Token = "0x60193CF")]
    [Address(RVA = "0x2FEEAA4", Offset = "0x2FEEAA4", VA = "0x2FEEAA4")]
    public void NearClip(float value)
    {
    }

    [Token(Token = "0x60193D0")]
    [Address(RVA = "0x2FEEB34", Offset = "0x2FEEB34", VA = "0x2FEEB34")]
    public void FarClip(float value)
    {
    }

    [Token(Token = "0x60193D1")]
    [Address(RVA = "0x2FEEBC4", Offset = "0x2FEEBC4", VA = "0x2FEEBC4")]
    public void SetLookAt(float posX, float posY, float posZ)
    {
    }

    [Token(Token = "0x60193D2")]
    [Address(RVA = "0x2FEEC6C", Offset = "0x2FEEC6C", VA = "0x2FEEC6C")]
    public void ResetLookAt()
    {
    }

    [Token(Token = "0x60193D3")]
    [Address(RVA = "0x2FEECEC", Offset = "0x2FEECEC", VA = "0x2FEECEC")]
    public float GetFieldOfView() => new float();

    [Token(Token = "0x60193D4")]
    [Address(RVA = "0x2FEED6C", Offset = "0x2FEED6C", VA = "0x2FEED6C")]
    public void StartCrossDissolve(LuaCamera luaCamera, float duration, float scale)
    {
    }

    [Token(Token = "0x60193D5")]
    [Address(RVA = "0x2FEEE3C", Offset = "0x2FEEE3C", VA = "0x2FEEE3C")]
    public void CreateCrossDissolveRenderTexture(float scale)
    {
    }

    [Token(Token = "0x60193D6")]
    [Address(RVA = "0x2FEEED0", Offset = "0x2FEEED0", VA = "0x2FEEED0")]
    public void DestoryCrossDissolveRenderTexture()
    {
    }

    [Token(Token = "0x60193D7")]
    [Address(RVA = "0x2FEEF50", Offset = "0x2FEEF50", VA = "0x2FEEF50")]
    public void DisableCrossDissolveRenderCamera()
    {
    }

    [Token(Token = "0x60193D8")]
    [Address(RVA = "0x2FEEFD0", Offset = "0x2FEEFD0", VA = "0x2FEEFD0")]
    public void StartShake(float amplitude, float duration)
    {
    }

    [Token(Token = "0x60193D9")]
    [Address(RVA = "0x2FEF068", Offset = "0x2FEF068", VA = "0x2FEF068")]
    public void StopShake()
    {
    }

    [Token(Token = "0x60193DA")]
    [Address(RVA = "0x2FEF0E8", Offset = "0x2FEF0E8", VA = "0x2FEF0E8")]
    public void LoadCameraAnim(string animationAssetbundleName, string animationFileName)
    {
    }

    [Token(Token = "0x60193DB")]
    [Address(RVA = "0x2FEF190", Offset = "0x2FEF190", VA = "0x2FEF190")]
    public void LoadExclusiveCamera(
      string animationAssetbundleName,
      string animationFileName,
      LuaObject actor)
    {
    }

    [Token(Token = "0x60193DC")]
    [Address(RVA = "0x2FEF244", Offset = "0x2FEF244", VA = "0x2FEF244")]
    public void CopyOffset(LuaObject srcCamera)
    {
    }

    [Token(Token = "0x60193DD")]
    [Address(RVA = "0x2FEF2D0", Offset = "0x2FEF2D0", VA = "0x2FEF2D0")]
    public void SetSkipOffset()
    {
    }

    [Token(Token = "0x60193DE")]
    [Address(RVA = "0x2FEF354", Offset = "0x2FEF354", VA = "0x2FEF354")]
    public void InitializeOffset()
    {
    }

    [Token(Token = "0x60193DF")]
    [Address(RVA = "0x2FEF3D4", Offset = "0x2FEF3D4", VA = "0x2FEF3D4")]
    public bool IsPositionAnimationPlayng() => new bool();

    [Token(Token = "0x60193E0")]
    [Address(RVA = "0x2FEF454", Offset = "0x2FEF454", VA = "0x2FEF454")]
    public void SetLightEffectParameter(
      float? bgParametersHardlightBlend,
      string bgParametersHardlightColorCode,
      string lightForChrarctersDirectionTypeName,
      float? lightForChrarctersIntensity,
      float? screenGradationIntensity)
    {
    }

    [Token(Token = "0x60193E1")]
    [Address(RVA = "0x2FEF68C", Offset = "0x2FEF68C", VA = "0x2FEF68C")]
    public void SetVignetteEffect(
      float centerX,
      float centerY,
      string colorCode,
      float intensity,
      float smoothness,
      bool rounded)
    {
    }

    [Token(Token = "0x60193E2")]
    [Address(RVA = "0x2FEF778", Offset = "0x2FEF778", VA = "0x2FEF778")]
    public void DisableVignetteEffect()
    {
    }

    [Token(Token = "0x2003EAE")]
    private class PostProcessLayerSetupper
    {
      [Token(Token = "0x401130B")]
      [FieldOffset(Offset = "0x10")]
      private LuaCamera.PostProcessLayerSetupper.LayerSettingBackup layerSettingBackup;
      [Token(Token = "0x401130C")]
      [FieldOffset(Offset = "0x18")]
      private Transform trigger;
      [Token(Token = "0x401130D")]
      [FieldOffset(Offset = "0x20")]
      private bool needRestore;

      [Token(Token = "0x60193E3")]
      [Address(RVA = "0x2FEE598", Offset = "0x2FEE598", VA = "0x2FEE598")]
      public void SetupPostprocessing(Camera camera, Transform trigger)
      {
      }

      [Token(Token = "0x60193E4")]
      [Address(RVA = "0x2FEF900", Offset = "0x2FEF900", VA = "0x2FEF900")]
      public void RestoreLayerSetting()
      {
      }

      [Token(Token = "0x60193E5")]
      [Address(RVA = "0x2FEF7F8", Offset = "0x2FEF7F8", VA = "0x2FEF7F8")]
      private void SetupPostProcess()
      {
      }

      [Token(Token = "0x60193E6")]
      [Address(RVA = "0x2FEE440", Offset = "0x2FEE440", VA = "0x2FEE440")]
      public PostProcessLayerSetupper()
      {
      }

      [Token(Token = "0x2003EAF")]
      private class LayerSettingBackup
      {
        [Token(Token = "0x401130E")]
        [FieldOffset(Offset = "0x10")]
        private LayerMask layerMask;
        [Token(Token = "0x401130F")]
        [FieldOffset(Offset = "0x18")]
        private Camera targetCamera;

        [Token(Token = "0x60193E7")]
        [Address(RVA = "0x2FEF8D0", Offset = "0x2FEF8D0", VA = "0x2FEF8D0")]
        public LayerSettingBackup(Camera camera, LayerMask volumeLayerMask)
        {
        }

        [Token(Token = "0x60193E8")]
        [Address(RVA = "0x2FEF928", Offset = "0x2FEF928", VA = "0x2FEF928")]
        public void Restore()
        {
        }
      }
    }
  }
}
