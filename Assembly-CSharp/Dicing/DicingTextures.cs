// Decompiled with JetBrains decompiler
// Type: Dicing.DicingTextures
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Dicing.Attribute;
using Dicing.Utility;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Dicing
{
  [Token(Token = "0x2001F37")]
  [CreateAssetMenu(menuName = "Staq/Dicingtextures")]
  public class DicingTextures : ScriptableObject
  {
    [Token(Token = "0x40085E5")]
    [FieldOffset(Offset = "0x18")]
    private readonly Dictionary<DicingTextures.CellSizePattern, int> cellSizeMap;
    [Token(Token = "0x40085E6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private DicingTextures.CellSizePattern cellSizePattern;
    [Token(Token = "0x40085E7")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    [Min(1f)]
    private int padding;
    [Token(Token = "0x40085E8")]
    [FieldOffset(Offset = "0x28")]
    [ReadOnly]
    [SerializeField]
    private List<Texture2D> atlasTextures;
    [Token(Token = "0x40085E9")]
    [FieldOffset(Offset = "0x30")]
    [ReadOnly]
    [SerializeField]
    private List<DicingTextureData> textureDataList;

    [Token(Token = "0x17002687")]
    public int CellSize
    {
      [Token(Token = "0x600B97D"), Address(RVA = "0x213C050", Offset = "0x213C050", VA = "0x213C050")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002688")]
    public int Padding
    {
      [Token(Token = "0x600B97E"), Address(RVA = "0x213CE74", Offset = "0x213CE74", VA = "0x213CE74")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002689")]
    public List<Texture2D> AtlasTextures
    {
      [Token(Token = "0x600B97F"), Address(RVA = "0x213CE7C", Offset = "0x213CE7C", VA = "0x213CE7C")] get
      {
        return (List<Texture2D>) null;
      }
    }

    [Token(Token = "0x1700268A")]
    public List<DicingTextureData> TextureDataList
    {
      [Token(Token = "0x600B980"), Address(RVA = "0x213CE84", Offset = "0x213CE84", VA = "0x213CE84")] get
      {
        return (List<DicingTextureData>) null;
      }
    }

    [Token(Token = "0x600B981")]
    [Address(RVA = "0x213A314", Offset = "0x213A314", VA = "0x213A314")]
    public DicingTextureData GetTextureData(string pattern) => (DicingTextureData) null;

    [Token(Token = "0x600B982")]
    [Address(RVA = "0x2139F54", Offset = "0x2139F54", VA = "0x2139F54")]
    public bool Exists(string pattern) => new bool();

    [Token(Token = "0x600B983")]
    [Address(RVA = "0x213A498", Offset = "0x213A498", VA = "0x213A498")]
    public Texture2D GetTexture2D(string name) => (Texture2D) null;

    [Token(Token = "0x600B984")]
    [Address(RVA = "0x213A110", Offset = "0x213A110", VA = "0x213A110")]
    public List<string> GetPattenNameList() => (List<string>) null;

    [Token(Token = "0x600B985")]
    [Address(RVA = "0x213CE9C", Offset = "0x213CE9C", VA = "0x213CE9C")]
    public List<QuadVerts> GetVerts(DicingTextureData data) => (List<QuadVerts>) null;

    [Token(Token = "0x600B986")]
    [Address(RVA = "0x213CECC", Offset = "0x213CECC", VA = "0x213CECC")]
    public DicingTextures()
    {
    }

    [Token(Token = "0x2001F38")]
    public enum CellSizePattern
    {
      [Token(Token = "0x40085EB")] Size32,
      [Token(Token = "0x40085EC")] Size64,
      [Token(Token = "0x40085ED")] Size128,
      [Token(Token = "0x40085EE")] Size256,
    }
  }
}
