// Decompiled with JetBrains decompiler
// Type: UI.Utilities.ImageAdjustController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Dicing;
using GameCore;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.Utilities
{
  [Token(Token = "0x2000885")]
  public class ImageAdjustController : MonoBehaviour
  {
    [Token(Token = "0x4002827")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ImageAdjustController.ImageType imageType;
    [Token(Token = "0x4002828")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ImageAdjustController.ComponentMode mode;
    [Token(Token = "0x4002829")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string layoutPattern;
    [Token(Token = "0x400282A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private IllustLayoutComponent.MatchMode matchMode;
    [Token(Token = "0x400282B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private float standardScale;
    [Token(Token = "0x400282C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private DicingImage dicingImage;
    [Token(Token = "0x400282D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private RawImage rawImage;
    [Token(Token = "0x400282E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image image;
    [Token(Token = "0x400282F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject[] targetGameObjects;

    [Token(Token = "0x60030B0")]
    [Address(RVA = "0x3E79F18", Offset = "0x3E79F18", VA = "0x3E79F18")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60030B1")]
    [Address(RVA = "0x3E7AC6C", Offset = "0x3E7AC6C", VA = "0x3E7AC6C")]
    public void Preload(AssetCachedSpawner spawner, int styleId)
    {
    }

    [Token(Token = "0x60030B2")]
    [Address(RVA = "0x3E7B094", Offset = "0x3E7B094", VA = "0x3E7B094")]
    public void Load(AssetCachedSpawner spawner, int styleId)
    {
    }

    [Token(Token = "0x60030B3")]
    [Address(RVA = "0x3E7B31C", Offset = "0x3E7B31C", VA = "0x3E7B31C")]
    public IEnumerator WaitLoading(AssetCachedSpawner spawner) => (IEnumerator) null;

    [Token(Token = "0x60030B4")]
    [Address(RVA = "0x3E7A004", Offset = "0x3E7A004", VA = "0x3E7A004")]
    public void SetImage(Sprite sprite, IllustLayoutInfo info)
    {
    }

    [Token(Token = "0x60030B5")]
    [Address(RVA = "0x3E7B384", Offset = "0x3E7B384", VA = "0x3E7B384")]
    private void Setup(IllustLayoutInfo info)
    {
    }

    [Token(Token = "0x60030B6")]
    [Address(RVA = "0x3E7ADE4", Offset = "0x3E7ADE4", VA = "0x3E7ADE4")]
    private (string, string) GetImageTupleByStyleId(int styleId) => ();

    [Token(Token = "0x60030B7")]
    [Address(RVA = "0x3E7AFC0", Offset = "0x3E7AFC0", VA = "0x3E7AFC0")]
    private (string, string) GetImageLayoutTupleByStyleId(int styleId) => ();

    [Token(Token = "0x60030B8")]
    [Address(RVA = "0x3E7B5A4", Offset = "0x3E7B5A4", VA = "0x3E7B5A4")]
    private void LoadImage(Texture texture)
    {
    }

    [Token(Token = "0x60030B9")]
    [Address(RVA = "0x3E7B628", Offset = "0x3E7B628", VA = "0x3E7B628")]
    private void LoadDicingImage(
      GameObject prefab,
      AssetCachedSpawner spawner,
      (string, string) layoutTuple)
    {
    }

    [Token(Token = "0x60030BA")]
    [Address(RVA = "0x3E7B7E4", Offset = "0x3E7B7E4", VA = "0x3E7B7E4")]
    public void SetupDicingImage(DicingImage dicingImage, IllustLayoutInfo info, bool targetUpdate = false)
    {
    }

    [Token(Token = "0x60030BB")]
    [Address(RVA = "0x3E7B9E8", Offset = "0x3E7B9E8", VA = "0x3E7B9E8")]
    public ImageAdjustController()
    {
    }

    [Token(Token = "0x2000886")]
    public enum ComponentMode
    {
      [Token(Token = "0x4002831")] Auto,
      [Token(Token = "0x4002832")] DicingImage,
      [Token(Token = "0x4002833")] RawImage,
      [Token(Token = "0x4002834")] Image,
    }

    [Token(Token = "0x2000887")]
    public enum ImageType
    {
      [Token(Token = "0x4002836")] HiRes,
      [Token(Token = "0x4002837")] Face,
    }
  }
}
