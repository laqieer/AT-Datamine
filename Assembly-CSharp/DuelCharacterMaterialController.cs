// Decompiled with JetBrains decompiler
// Type: DuelCharacterMaterialController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000109")]
[ExecuteInEditMode]
public class DuelCharacterMaterialController : MonoBehaviour
{
  [Token(Token = "0x400053C")]
  [FieldOffset(Offset = "0x18")]
  [Header("Base Color")]
  public bool overrideBaseColor;
  [Token(Token = "0x400053D")]
  [FieldOffset(Offset = "0x1C")]
  [Space(10f)]
  public Color characterAndVehicleBaseColor;
  [Token(Token = "0x400053E")]
  [FieldOffset(Offset = "0x2C")]
  public Color weaponBaseColor;
  [Token(Token = "0x400053F")]
  [FieldOffset(Offset = "0x3C")]
  [Header("Condition Texture")]
  public bool overrideConditionTexture;
  [Token(Token = "0x4000540")]
  [FieldOffset(Offset = "0x3D")]
  [Space(10f)]
  public bool conditionTexture;
  [Token(Token = "0x4000541")]
  [FieldOffset(Offset = "0x40")]
  public float conditionTextureBlend;
  [Token(Token = "0x4000542")]
  [FieldOffset(Offset = "0x44")]
  public float monochrome;
  [Token(Token = "0x4000543")]
  [FieldOffset(Offset = "0x48")]
  public float hardlightBlend;
  [Token(Token = "0x4000544")]
  [FieldOffset(Offset = "0x4C")]
  public Color hardlightColor;
  [Token(Token = "0x4000545")]
  [FieldOffset(Offset = "0x5C")]
  public float mixBlend;
  [Token(Token = "0x4000546")]
  [FieldOffset(Offset = "0x60")]
  public Color mixBlendColor;
  [Token(Token = "0x4000547")]
  [FieldOffset(Offset = "0x70")]
  [Header("Rim Light")]
  public bool overrideRimLight;
  [Token(Token = "0x4000548")]
  [FieldOffset(Offset = "0x74")]
  [Space(10f)]
  public Color rimLightColor;
  [Token(Token = "0x4000549")]
  [FieldOffset(Offset = "0x84")]
  public float rimLightPower;
  [Token(Token = "0x400054A")]
  [FieldOffset(Offset = "0x88")]
  public float rimLightInsideMask;
  [Token(Token = "0x400054B")]
  [FieldOffset(Offset = "0x8C")]
  public bool enableRimLightMask;
  [Token(Token = "0x400054C")]
  [FieldOffset(Offset = "0x8D")]
  [Header("Outline")]
  public bool overrideOutline;
  [Token(Token = "0x400054D")]
  [FieldOffset(Offset = "0x90")]
  [Space(10f)]
  public Color outlineColor;
  [Token(Token = "0x400054E")]
  [FieldOffset(Offset = "0xA0")]
  public bool enableOutline;
  [Token(Token = "0x400054F")]
  [FieldOffset(Offset = "0xA1")]
  [Header("Emission")]
  public bool overrideEmission;
  [Token(Token = "0x4000550")]
  [FieldOffset(Offset = "0xA2")]
  [Space(10f)]
  public bool emission;
  [Token(Token = "0x4000551")]
  [FieldOffset(Offset = "0xA4")]
  public Color emissionColor1;
  [Token(Token = "0x4000552")]
  [FieldOffset(Offset = "0xB4")]
  public Color emissionColor2;
  [Token(Token = "0x4000553")]
  [FieldOffset(Offset = "0xC4")]
  public float emissionThreshold;
  [Token(Token = "0x4000554")]
  [FieldOffset(Offset = "0xC8")]
  public float emissionPower;
  [Token(Token = "0x4000555")]
  [FieldOffset(Offset = "0xCC")]
  public bool useHDR;
  [Token(Token = "0x4000556")]
  [FieldOffset(Offset = "0x0")]
  private static readonly int baseColorPropertyID;
  [Token(Token = "0x4000557")]
  [FieldOffset(Offset = "0x4")]
  private static readonly int stoneBlendPropertyID;
  [Token(Token = "0x4000558")]
  [FieldOffset(Offset = "0x8")]
  private static readonly int monochromePropertyID;
  [Token(Token = "0x4000559")]
  [FieldOffset(Offset = "0xC")]
  private static readonly int hardlightBlendPropertyID;
  [Token(Token = "0x400055A")]
  [FieldOffset(Offset = "0x10")]
  private static readonly int hardlightBlendColorPropertyID;
  [Token(Token = "0x400055B")]
  [FieldOffset(Offset = "0x14")]
  private static readonly int mixBlendPropertyID;
  [Token(Token = "0x400055C")]
  [FieldOffset(Offset = "0x18")]
  private static readonly int mixBlendColorPropertyID;
  [Token(Token = "0x400055D")]
  private const string stonedOnKeyword = "_STONED_ON";
  [Token(Token = "0x400055E")]
  [FieldOffset(Offset = "0x1C")]
  private static readonly int rimLightColorPropertyID;
  [Token(Token = "0x400055F")]
  [FieldOffset(Offset = "0x20")]
  private static readonly int rimLightPowerPropertyID;
  [Token(Token = "0x4000560")]
  [FieldOffset(Offset = "0x24")]
  private static readonly int rimLightInsideMaskPropertyID;
  [Token(Token = "0x4000561")]
  [FieldOffset(Offset = "0x28")]
  private static readonly int enableRimLightMaskPropertyID;
  [Token(Token = "0x4000562")]
  [FieldOffset(Offset = "0x2C")]
  private static readonly int outlineColorPropertyID;
  [Token(Token = "0x4000563")]
  [FieldOffset(Offset = "0x30")]
  private static readonly int farthestOutlineWidthPropertyID;
  [Token(Token = "0x4000564")]
  [FieldOffset(Offset = "0x34")]
  private static readonly int middleOutlineWidthPropertyID;
  [Token(Token = "0x4000565")]
  [FieldOffset(Offset = "0x38")]
  private static readonly int nearestOutlineWidthPropertyID;
  [Token(Token = "0x4000566")]
  [FieldOffset(Offset = "0x3C")]
  private static readonly int emissionColor1PropertyID;
  [Token(Token = "0x4000567")]
  [FieldOffset(Offset = "0x40")]
  private static readonly int emissionColor2PropertyID;
  [Token(Token = "0x4000568")]
  [FieldOffset(Offset = "0x44")]
  private static readonly int emissionThresholdPropertyID;
  [Token(Token = "0x4000569")]
  [FieldOffset(Offset = "0x48")]
  private static readonly int emissionPowerPropertyID;
  [Token(Token = "0x400056A")]
  [FieldOffset(Offset = "0x4C")]
  private static readonly int useHDRPropertyID;
  [Token(Token = "0x400056B")]
  private const string emissionOnKeyword = "_EMISSION_ON";
  [Token(Token = "0x400056C")]
  [FieldOffset(Offset = "0xD0")]
  [SerializeField]
  private List<GameObject> equipmentGameObjects;
  [Token(Token = "0x400056D")]
  [FieldOffset(Offset = "0xD8")]
  private Dictionary<Renderer, Material[]> originalMaterialDictionary;
  [Token(Token = "0x400056E")]
  [FieldOffset(Offset = "0xE0")]
  private Dictionary<Renderer, Material[]> animatedMaterialDictionary;
  [Token(Token = "0x400056F")]
  [FieldOffset(Offset = "0xE8")]
  private Material currentMaterial;
  [Token(Token = "0x4000570")]
  [FieldOffset(Offset = "0xF0")]
  private Material originalMaterial;

  [Token(Token = "0x6000753")]
  [Address(RVA = "0x48527E8", Offset = "0x48527E8", VA = "0x48527E8")]
  private void Start()
  {
  }

  [Token(Token = "0x6000754")]
  [Address(RVA = "0x48527EC", Offset = "0x48527EC", VA = "0x48527EC")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000755")]
  [Address(RVA = "0x4852FAC", Offset = "0x4852FAC", VA = "0x4852FAC")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000756")]
  [Address(RVA = "0x485331C", Offset = "0x485331C", VA = "0x485331C")]
  private void Update()
  {
  }

  [Token(Token = "0x6000757")]
  [Address(RVA = "0x48527F0", Offset = "0x48527F0", VA = "0x48527F0")]
  private void CollectMaterials()
  {
  }

  [Token(Token = "0x6000758")]
  [Address(RVA = "0x4852FB0", Offset = "0x4852FB0", VA = "0x4852FB0")]
  private void ResumeMaterials()
  {
  }

  [Token(Token = "0x6000759")]
  [Address(RVA = "0x485342C", Offset = "0x485342C", VA = "0x485342C")]
  public void UpdateMaterialParameters(
    Dictionary<Renderer, Material[]> originalMaterialDictionary,
    Dictionary<Renderer, Material[]> targetMaterialDictionary,
    bool overrideBaseColor,
    Color characterAndVehicleBaseColor,
    Color weaponBaseColor,
    bool overrideConditionTexture,
    bool conditionTexture,
    float conditionTextureBlend,
    float monochrome,
    float hardlightBlend,
    Color hardlightColor,
    float mixBlend,
    Color mixBlendColor,
    bool overrideRimLight,
    Color rimLightColor,
    float rimLightPower,
    float rimLightInsideMask,
    bool enableRimLightMask,
    bool overrideOutline,
    Color outlineColor,
    bool enableOutline,
    bool overrideEmission,
    bool emission,
    Color emissionColor1,
    Color emissionColor2,
    float emissionThreshold,
    float emissionPower,
    bool useHDR)
  {
  }

  [Token(Token = "0x600075A")]
  [Address(RVA = "0x48545D8", Offset = "0x48545D8", VA = "0x48545D8")]
  public void Initialize(List<GameObject> equipementGameObjects)
  {
  }

  [Token(Token = "0x600075B")]
  [Address(RVA = "0x48545E0", Offset = "0x48545E0", VA = "0x48545E0")]
  public void DisableOverrideFlags()
  {
  }

  [Token(Token = "0x600075C")]
  [Address(RVA = "0x48545F8", Offset = "0x48545F8", VA = "0x48545F8")]
  public DuelCharacterMaterialController()
  {
  }

  [Token(Token = "0x600075D")]
  [Address(RVA = "0x485474C", Offset = "0x485474C", VA = "0x485474C")]
  static DuelCharacterMaterialController()
  {
  }
}
