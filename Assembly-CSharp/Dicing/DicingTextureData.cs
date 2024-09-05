// Decompiled with JetBrains decompiler
// Type: Dicing.DicingTextureData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Dicing.Utility;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Dicing
{
  [Token(Token = "0x2001F33")]
  [Serializable]
  public class DicingTextureData
  {
    [Token(Token = "0x40085CF")]
    private const int BothEndsRate = 2;
    [Token(Token = "0x40085D0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string name;
    [Token(Token = "0x40085D1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string atlasName;
    [Token(Token = "0x40085D2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int texWidth;
    [Token(Token = "0x40085D3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int texHeight;
    [Token(Token = "0x40085D4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<int> cellIndexList;
    [Token(Token = "0x40085D5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int transparentIndex;
    [Token(Token = "0x40085D6")]
    [FieldOffset(Offset = "0x38")]
    [NonSerialized]
    private List<QuadVerts> verts;

    [Token(Token = "0x17002682")]
    public string Name
    {
      [Token(Token = "0x600B96C"), Address(RVA = "0x213B968", Offset = "0x213B968", VA = "0x213B968")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002683")]
    public string AtlasName
    {
      [Token(Token = "0x600B96D"), Address(RVA = "0x213B970", Offset = "0x213B970", VA = "0x213B970")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002684")]
    public int TexWidth
    {
      [Token(Token = "0x600B96E"), Address(RVA = "0x213B978", Offset = "0x213B978", VA = "0x213B978")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002685")]
    public int TexHeight
    {
      [Token(Token = "0x600B96F"), Address(RVA = "0x213B980", Offset = "0x213B980", VA = "0x213B980")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002686")]
    public int AtlasCellMaxHeight
    {
      [Token(Token = "0x600B970"), Address(RVA = "0x213B988", Offset = "0x213B988", VA = "0x213B988")] get
      {
        return new int();
      }
      [Token(Token = "0x600B971"), Address(RVA = "0x213B990", Offset = "0x213B990", VA = "0x213B990")] private set
      {
      }
    }

    [Token(Token = "0x600B972")]
    [Address(RVA = "0x213B998", Offset = "0x213B998", VA = "0x213B998")]
    private void InitVerts(DicingTextures atlas)
    {
    }

    [Token(Token = "0x600B973")]
    [Address(RVA = "0x213C0E8", Offset = "0x213C0E8", VA = "0x213C0E8")]
    public List<QuadVerts> GetVerts(DicingTextures textures) => (List<QuadVerts>) null;

    [Token(Token = "0x600B974")]
    [Address(RVA = "0x213A838", Offset = "0x213A838", VA = "0x213A838")]
    public void CalculateVertexList(
      Rect position,
      Rect uvRect,
      bool isSkipTransparentCell,
      DicingTextures dicingTextures,
      Action<Rect, Rect> func)
    {
    }

    [Token(Token = "0x600B975")]
    [Address(RVA = "0x213C114", Offset = "0x213C114", VA = "0x213C114")]
    public void CaluclateVertexList(
      Rect uvRect,
      bool isSkipTransparentCell,
      DicingTextures dicingTextures,
      Action<Rect, Rect> func)
    {
    }

    [Token(Token = "0x600B976")]
    [Address(RVA = "0x213C6AC", Offset = "0x213C6AC", VA = "0x213C6AC")]
    private void CalculateVerticesRect(
      Rect uvRect,
      bool isSkiptransparentCell,
      DicingTextures dicingTextures,
      Action<Rect, Rect> func)
    {
    }

    [Token(Token = "0x600B977")]
    [Address(RVA = "0x213CA78", Offset = "0x213CA78", VA = "0x213CA78")]
    public DicingTextureData()
    {
    }
  }
}
