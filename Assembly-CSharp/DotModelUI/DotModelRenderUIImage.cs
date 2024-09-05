// Decompiled with JetBrains decompiler
// Type: DotModelUI.DotModelRenderUIImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace DotModelUI
{
  [Token(Token = "0x2000504")]
  [RequireComponent(typeof (CanvasRenderer))]
  [RequireComponent(typeof (RectTransform))]
  [ExecuteAlways]
  public class DotModelRenderUIImage : MaskableGraphic
  {
    [Token(Token = "0x4001ADC")]
    [FieldOffset(Offset = "0xD0")]
    private List<UIVertex> uivs;
    [Token(Token = "0x4001ADD")]
    [FieldOffset(Offset = "0xD8")]
    private List<int> uiinds;
    [Token(Token = "0x4001ADE")]
    [FieldOffset(Offset = "0xE0")]
    private MeshRenderer dotRendererInRuntime;
    [Token(Token = "0x4001ADF")]
    [FieldOffset(Offset = "0xE8")]
    private Material materialInstanceInInRuntime;
    [Token(Token = "0x4001AE0")]
    [FieldOffset(Offset = "0xF0")]
    private MaterialPropertyBlock propertiesCache;
    [Token(Token = "0x4001AE1")]
    [FieldOffset(Offset = "0xF8")]
    private bool grayColorModeFlag;
    [Token(Token = "0x4001AE2")]
    private const string MaterialVectorNameMainTexST = "_MainTex_ST";
    [Token(Token = "0x4001AE3")]
    [FieldOffset(Offset = "0x100")]
    private WeakReference<Material> nowRenderingMaterialRef;
    [Token(Token = "0x4001AE4")]
    private const string SelfGeneratedMaterialPrefix = "DotRenderUIOnly";

    [Token(Token = "0x6001CD8")]
    [Address(RVA = "0x29F561C", Offset = "0x29F561C", VA = "0x29F561C")]
    public void SetGrayColorModeFlag(bool isOn)
    {
    }

    [Token(Token = "0x6001CD9")]
    [Address(RVA = "0x29F5628", Offset = "0x29F5628", VA = "0x29F5628")]
    private void BuildReset()
    {
    }

    [Token(Token = "0x1700039F")]
    public override Texture mainTexture
    {
      [Token(Token = "0x6001CDA"), Address(RVA = "0x29F56FC", Offset = "0x29F56FC", VA = "0x29F56FC", Slot = "35")] get
      {
        return (Texture) null;
      }
    }

    [Token(Token = "0x6001CDB")]
    [Address(RVA = "0x29F5858", Offset = "0x29F5858", VA = "0x29F5858", Slot = "58")]
    public override Material GetModifiedMaterial(Material baseMaterial) => (Material) null;

    [Token(Token = "0x6001CDC")]
    [Address(RVA = "0x29F5A98", Offset = "0x29F5A98", VA = "0x29F5A98", Slot = "40")]
    protected override void UpdateMaterial()
    {
    }

    [Token(Token = "0x6001CDD")]
    [Address(RVA = "0x29F5C4C", Offset = "0x29F5C4C", VA = "0x29F5C4C")]
    private void UIMeshDataBuild()
    {
    }

    [Token(Token = "0x6001CDE")]
    [Address(RVA = "0x29F678C", Offset = "0x29F678C", VA = "0x29F678C")]
    private void UIMeshDataBuildFromReadableMesh(Mesh mesh)
    {
    }

    [Token(Token = "0x6001CDF")]
    [Address(RVA = "0x29F7194", Offset = "0x29F7194", VA = "0x29F7194")]
    private void BuildIfNeed()
    {
    }

    [Token(Token = "0x6001CE0")]
    [Address(RVA = "0x29F7508", Offset = "0x29F7508", VA = "0x29F7508", Slot = "44")]
    protected override void OnPopulateMesh(VertexHelper vh)
    {
    }

    [Token(Token = "0x6001CE1")]
    [Address(RVA = "0x29F7598", Offset = "0x29F7598", VA = "0x29F7598")]
    private void Update()
    {
    }

    [Token(Token = "0x6001CE2")]
    [Address(RVA = "0x29F58BC", Offset = "0x29F58BC", VA = "0x29F58BC")]
    private bool ApplyMaterialParamFromDotMaterial(Material mat) => new bool();

    [Token(Token = "0x6001CE3")]
    [Address(RVA = "0x29F760C", Offset = "0x29F760C", VA = "0x29F760C", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6001CE4")]
    [Address(RVA = "0x29F7630", Offset = "0x29F7630", VA = "0x29F7630")]
    private void OnTransformChildrenChanged()
    {
    }

    [Token(Token = "0x6001CE5")]
    [Address(RVA = "0x29F765C", Offset = "0x29F765C", VA = "0x29F765C", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6001CE6")]
    [Address(RVA = "0x29F76F4", Offset = "0x29F76F4", VA = "0x29F76F4")]
    public DotModelRenderUIImage()
    {
    }
  }
}
