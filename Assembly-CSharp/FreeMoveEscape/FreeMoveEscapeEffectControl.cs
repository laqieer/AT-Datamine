// Decompiled with JetBrains decompiler
// Type: FreeMoveEscape.FreeMoveEscapeEffectControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
namespace FreeMoveEscape
{
  [Token(Token = "0x20015D5")]
  public class FreeMoveEscapeEffectControl : MonoBehaviour
  {
    [Token(Token = "0x40063A6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private AnimationCurve fadeFactorCurve;
    [Token(Token = "0x40063A7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AnimationCurve bgPrametersFactorCurve;
    [Token(Token = "0x40063A8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private AnimationCurve bloomThresholdFactorCurve;
    [Token(Token = "0x40063A9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject[] spawnEffectPrefabs;
    [Token(Token = "0x40063AA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Color bgPrametersHardlightColor;
    [Token(Token = "0x40063AB")]
    [FieldOffset(Offset = "0x48")]
    private BGParameters bgPrametersCom;
    [Token(Token = "0x40063AC")]
    [FieldOffset(Offset = "0x50")]
    private Bloom bloom;
    [Token(Token = "0x40063AD")]
    [FieldOffset(Offset = "0x58")]
    public float Factor01;
    [Token(Token = "0x40063AE")]
    [FieldOffset(Offset = "0x5C")]
    private Color nowFadeColor;
    [Token(Token = "0x40063B0")]
    [FieldOffset(Offset = "0x6D")]
    private bool isBgPrametersUpdate;

    [Token(Token = "0x170012FE")]
    public bool IsFadeUpdate
    {
      [Token(Token = "0x6007B6A"), Address(RVA = "0x22A15F0", Offset = "0x22A15F0", VA = "0x22A15F0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007B6B"), Address(RVA = "0x22A15F8", Offset = "0x22A15F8", VA = "0x22A15F8")] set
      {
      }
    }

    [Token(Token = "0x170012FF")]
    public bool IsBgPrametersUpdate
    {
      [Token(Token = "0x6007B6C"), Address(RVA = "0x22A1604", Offset = "0x22A1604", VA = "0x22A1604")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007B6D"), Address(RVA = "0x22A160C", Offset = "0x22A160C", VA = "0x22A160C")] set
      {
      }
    }

    [Token(Token = "0x17001300")]
    public bool IsBloomUpate
    {
      [Token(Token = "0x6007B6E"), Address(RVA = "0x22A169C", Offset = "0x22A169C", VA = "0x22A169C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007B6F"), Address(RVA = "0x22A16A4", Offset = "0x22A16A4", VA = "0x22A16A4")] set
      {
      }
    }

    [Token(Token = "0x6007B70")]
    [Address(RVA = "0x22A16B0", Offset = "0x22A16B0", VA = "0x22A16B0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6007B71")]
    [Address(RVA = "0x22A1988", Offset = "0x22A1988", VA = "0x22A1988")]
    private void Update()
    {
    }

    [Token(Token = "0x6007B72")]
    [Address(RVA = "0x22A1940", Offset = "0x22A1940", VA = "0x22A1940")]
    private void Sample(float factor)
    {
    }

    [Token(Token = "0x6007B73")]
    [Address(RVA = "0x22A1C2C", Offset = "0x22A1C2C", VA = "0x22A1C2C")]
    public void SetGlobalVolume(GameObject go)
    {
    }

    [Token(Token = "0x6007B74")]
    [Address(RVA = "0x22A16D4", Offset = "0x22A16D4", VA = "0x22A16D4")]
    private void CreateEffectObjectAwake()
    {
    }

    [Token(Token = "0x6007B75")]
    [Address(RVA = "0x22A18A4", Offset = "0x22A18A4", VA = "0x22A18A4")]
    private void SetupBGParameters()
    {
    }

    [Token(Token = "0x6007B76")]
    [Address(RVA = "0x22A1990", Offset = "0x22A1990", VA = "0x22A1990")]
    private void OnBgParametersUpdate(float factor01)
    {
    }

    [Token(Token = "0x6007B77")]
    [Address(RVA = "0x22A1A34", Offset = "0x22A1A34", VA = "0x22A1A34")]
    private void OnFadeUpdate(float factor01)
    {
    }

    [Token(Token = "0x6007B78")]
    [Address(RVA = "0x22A1B64", Offset = "0x22A1B64", VA = "0x22A1B64")]
    private void OnBloomThresholdUpdate(float factor01)
    {
    }

    [Token(Token = "0x6007B79")]
    [Address(RVA = "0x22A1D14", Offset = "0x22A1D14", VA = "0x22A1D14")]
    public FreeMoveEscapeEffectControl()
    {
    }
  }
}
