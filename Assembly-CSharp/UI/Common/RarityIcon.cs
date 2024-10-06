// Decompiled with JetBrains decompiler
// Type: UI.Common.RarityIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.Common
{
  [Token(Token = "0x200091D")]
  public class RarityIcon : MonoBehaviour
  {
    [Token(Token = "0x4002A78")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image _rarityImage;

    [Token(Token = "0x6003359")]
    [Address(RVA = "0x362674C", Offset = "0x362674C", VA = "0x362674C")]
    public static void PreloadSizeS(RarityTypeEnum rarity, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x600335A")]
    [Address(RVA = "0x3626800", Offset = "0x3626800", VA = "0x3626800")]
    public void SetSizeS(RarityTypeEnum rarity, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x600335B")]
    [Address(RVA = "0x3626940", Offset = "0x3626940", VA = "0x3626940")]
    public void SetSizeM(RarityTypeEnum rarity, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x600335C")]
    [Address(RVA = "0x362691C", Offset = "0x362691C", VA = "0x362691C")]
    public void Unset()
    {
    }

    [Token(Token = "0x600335D")]
    [Address(RVA = "0x3626A5C", Offset = "0x3626A5C", VA = "0x3626A5C")]
    private void SetImage(Sprite sprite)
    {
    }

    [Token(Token = "0x600335E")]
    [Address(RVA = "0x3626B10", Offset = "0x3626B10", VA = "0x3626B10")]
    public RarityIcon()
    {
    }
  }
}
