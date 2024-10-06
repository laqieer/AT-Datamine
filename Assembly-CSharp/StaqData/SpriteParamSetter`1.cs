// Decompiled with JetBrains decompiler
// Type: StaqData.SpriteParamSetter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200208B")]
  [Serializable]
  public abstract class SpriteParamSetter<T>
  {
    [Token(Token = "0x4008A80")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private SpriteParamSetter<T>.AssetBundleInformation spriteAtlasLoadInfo;
    [Token(Token = "0x4008A81")]
    protected const string SpriteParamsPropertyName = "spriteParams";

    [Token(Token = "0x600C4E0")]
    public SpriteAtlas LoadSpriteAtlas() => (SpriteAtlas) null;

    [Token(Token = "0x600C4E1")]
    public string GetAssetBundleLabel() => (string) null;

    [Token(Token = "0x17002A02")]
    protected abstract string SpriteIdentityToken { [Token(Token = "0x600C4E2")] get; }

    [Token(Token = "0x600C4E3")]
    public abstract IReadOnlyList<T> GetParams();

    [Token(Token = "0x17002A03")]
    protected int ClonedTextSymbolLength
    {
      [Token(Token = "0x600C4E4")] get => new int();
    }

    [Token(Token = "0x17002A04")]
    public string[] SpriteNames
    {
      [Token(Token = "0x600C4E5")] get => (string[]) null;
      [Token(Token = "0x600C4E6")] protected set
      {
      }
    }

    [Token(Token = "0x600C4E7")]
    protected SpriteParamSetter()
    {
    }

    [Token(Token = "0x200208C")]
    [Serializable]
    public class AssetBundleInformation
    {
      [Token(Token = "0x4008A83")]
      [FieldOffset(Offset = "0x0")]
      [SerializeField]
      public string labelName;
      [Token(Token = "0x4008A84")]
      [FieldOffset(Offset = "0x0")]
      [SerializeField]
      public string assetName;

      [Token(Token = "0x600C4E8")]
      public AssetBundleInformation()
      {
      }
    }
  }
}
