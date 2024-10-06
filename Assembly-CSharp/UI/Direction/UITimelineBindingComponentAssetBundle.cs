// Decompiled with JetBrains decompiler
// Type: UI.Direction.UITimelineBindingComponentAssetBundle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UI.Direction
{
  [Token(Token = "0x20008EF")]
  [Serializable]
  public class UITimelineBindingComponentAssetBundle
  {
    [Token(Token = "0x40029CE")]
    [FieldOffset(Offset = "0x10")]
    [Tooltip("トラックにアタッチしているアセットの種類")]
    [SerializeField]
    public UITimelineBindingComponentAssetBundle.AssetType type;
    [Token(Token = "0x40029CF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [ResourceType(typeof (UnityEngine.Object))]
    [Tooltip("ロードに必要なAssetBundle情報")]
    public AssetBundleLoadData assetBundleLoad;

    [Token(Token = "0x600327C")]
    [Address(RVA = "0x3C22FE0", Offset = "0x3C22FE0", VA = "0x3C22FE0")]
    public UITimelineBindingComponentAssetBundle()
    {
    }

    [Token(Token = "0x20008F0")]
    public enum AssetType
    {
      [Token(Token = "0x40029D1")] Animator,
      [Token(Token = "0x40029D2")] Animation,
    }
  }
}
