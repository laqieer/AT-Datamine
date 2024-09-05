// Decompiled with JetBrains decompiler
// Type: Dicing.DicingImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Dicing
{
  [Token(Token = "0x2001F2C")]
  [AddComponentMenu("Staq/UI/DicingImage")]
  [ExecuteAlways]
  [RequireComponent(typeof (RectTransform))]
  [RequireComponent(typeof (CanvasRenderer))]
  public class DicingImage : MaskableGraphic, ICanvasRaycastFilter
  {
    [Token(Token = "0x40085B7")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private DicingTextures dicingTextures;
    [Token(Token = "0x40085B8")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private string pattern;
    [Token(Token = "0x40085BA")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private DicingTextureData patternData;
    [Token(Token = "0x40085BB")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private bool isSkipTransparentCell;
    [Token(Token = "0x40085BC")]
    [FieldOffset(Offset = "0xF4")]
    [SerializeField]
    private Rect uvRect;
    [Token(Token = "0x40085BD")]
    [FieldOffset(Offset = "0x108")]
    private Texture myTexture;

    [Token(Token = "0x17002675")]
    public DicingTextures DicingTextures
    {
      [Token(Token = "0x600B938"), Address(RVA = "0x2139CBC", Offset = "0x2139CBC", VA = "0x2139CBC")] get
      {
        return (DicingTextures) null;
      }
    }

    [Token(Token = "0x17002676")]
    private string Pattern
    {
      [Token(Token = "0x600B939"), Address(RVA = "0x2139CC4", Offset = "0x2139CC4", VA = "0x2139CC4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002677")]
    public string MainPattern
    {
      [Token(Token = "0x600B93A"), Address(RVA = "0x2139CCC", Offset = "0x2139CCC", VA = "0x2139CCC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600B93B"), Address(RVA = "0x2139CD4", Offset = "0x2139CD4", VA = "0x2139CD4")] private set
      {
      }
    }

    [Token(Token = "0x17002678")]
    public DicingTextureData PatternData
    {
      [Token(Token = "0x600B93C"), Address(RVA = "0x2139CDC", Offset = "0x2139CDC", VA = "0x2139CDC")] get
      {
        return (DicingTextureData) null;
      }
    }

    [Token(Token = "0x17002679")]
    public bool IsSkipTransparentCell
    {
      [Token(Token = "0x600B93D"), Address(RVA = "0x2139CE4", Offset = "0x2139CE4", VA = "0x2139CE4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600B93E"), Address(RVA = "0x2139CEC", Offset = "0x2139CEC", VA = "0x2139CEC")] set
      {
      }
    }

    [Token(Token = "0x1700267A")]
    public Rect UvRect
    {
      [Token(Token = "0x600B93F"), Address(RVA = "0x2139CF8", Offset = "0x2139CF8", VA = "0x2139CF8")] get
      {
        return new Rect();
      }
      [Token(Token = "0x600B940"), Address(RVA = "0x2139D04", Offset = "0x2139D04", VA = "0x2139D04")] set
      {
      }
    }

    [Token(Token = "0x1700267B")]
    public override Texture mainTexture
    {
      [Token(Token = "0x600B941"), Address(RVA = "0x2139D1C", Offset = "0x2139D1C", VA = "0x2139D1C", Slot = "35")] get
      {
        return (Texture) null;
      }
    }

    [Token(Token = "0x600B942")]
    [Address(RVA = "0x2139E74", Offset = "0x2139E74", VA = "0x2139E74")]
    public void SetPattern(string nextPattern)
    {
    }

    [Token(Token = "0x600B943")]
    [Address(RVA = "0x21397F8", Offset = "0x21397F8", VA = "0x21397F8")]
    public void ChangePattern(string pattern)
    {
    }

    [Token(Token = "0x600B944")]
    [Address(RVA = "0x2139164", Offset = "0x2139164", VA = "0x2139164")]
    public List<string> GetPatternList() => (List<string>) null;

    [Token(Token = "0x600B945")]
    [Address(RVA = "0x2139848", Offset = "0x2139848", VA = "0x2139848")]
    public void SetDicintTextures(DicingTextures dicingTextures)
    {
    }

    [Token(Token = "0x600B946")]
    [Address(RVA = "0x213A030", Offset = "0x213A030", VA = "0x213A030")]
    private void OnChangePattern()
    {
    }

    [Token(Token = "0x600B947")]
    [Address(RVA = "0x213A574", Offset = "0x213A574", VA = "0x213A574", Slot = "45")]
    public override void SetNativeSize()
    {
    }

    [Token(Token = "0x600B948")]
    [Address(RVA = "0x213A5FC", Offset = "0x213A5FC", VA = "0x213A5FC")]
    private Vector2 GetNativeSize() => new Vector2();

    [Token(Token = "0x600B949")]
    [Address(RVA = "0x2139A3C", Offset = "0x2139A3C", VA = "0x2139A3C")]
    public void ChangeAlpha(float alpha)
    {
    }

    [Token(Token = "0x600B94A")]
    [Address(RVA = "0x213A66C", Offset = "0x213A66C", VA = "0x213A66C", Slot = "44")]
    protected override void OnPopulateMesh(VertexHelper vh)
    {
    }

    [Token(Token = "0x600B94B")]
    [Address(RVA = "0x213A7F4", Offset = "0x213A7F4", VA = "0x213A7F4")]
    protected void CaluclateVertexList(Action<Rect, Rect> action)
    {
    }

    [Token(Token = "0x600B94C")]
    [Address(RVA = "0x213A9A4", Offset = "0x213A9A4", VA = "0x213A9A4", Slot = "65")]
    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) => new bool();

    [Token(Token = "0x600B94D")]
    [Address(RVA = "0x213AA8C", Offset = "0x213AA8C", VA = "0x213AA8C")]
    public bool HitTest(Vector2 localPosition) => new bool();

    [Token(Token = "0x600B94E")]
    [Address(RVA = "0x213ABE8", Offset = "0x213ABE8", VA = "0x213ABE8")]
    public DicingImage()
    {
    }
  }
}
