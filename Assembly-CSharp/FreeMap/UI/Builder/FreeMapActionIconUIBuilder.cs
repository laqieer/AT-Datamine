// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Builder.FreeMapActionIconUIBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Instance.Element;
using FreeMap.Loader;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.Control.Animation;
using FreeMap.UI.Data;
using FreeMap.UI.Element;
using FreeMap.UI.Entity;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Builder
{
  [Token(Token = "0x2001771")]
  public class FreeMapActionIconUIBuilder : FreeMapInstanceUIBuilder<FreeMapActionIconUI>
  {
    [Token(Token = "0x40067E9")]
    private const int ViewUINumMax = 3;
    [Token(Token = "0x40067EA")]
    private const float DuplicationClipDistance = 5f;
    [Token(Token = "0x40067EB")]
    [FieldOffset(Offset = "0x0")]
    protected static readonly UIShowTweenNameList DefaultShowTweenNameList;
    [Token(Token = "0x40067EC")]
    [FieldOffset(Offset = "0x8")]
    protected static readonly UIRotationTweenNameList DefaultRotationTweenNameList;
    [Token(Token = "0x40067ED")]
    [FieldOffset(Offset = "0x10")]
    protected static readonly DuplicationUIRotationTweenNameList DefaultDuplicationTweenNameList;
    [Token(Token = "0x40067F1")]
    [FieldOffset(Offset = "0x30")]
    private FreeMapUIParamBase circleLoadParam;

    [Token(Token = "0x170014EE")]
    private FreeMapActionIconUIBuilder.BuildData[] BuildDatas
    {
      [Token(Token = "0x60084C3"), Address(RVA = "0x4067B28", Offset = "0x4067B28", VA = "0x4067B28")] get
      {
        return (FreeMapActionIconUIBuilder.BuildData[]) null;
      }
    }

    [Token(Token = "0x170014EF")]
    private FreeMapUIParamBase MainUIParam
    {
      [Token(Token = "0x60084C4"), Address(RVA = "0x4067B30", Offset = "0x4067B30", VA = "0x4067B30")] get
      {
        return (FreeMapUIParamBase) null;
      }
    }

    [Token(Token = "0x170014F0")]
    private CirclePrefabAssetLoader CircleLoader
    {
      [Token(Token = "0x60084C5"), Address(RVA = "0x4067B60", Offset = "0x4067B60", VA = "0x4067B60")] get
      {
        return (CirclePrefabAssetLoader) null;
      }
      [Token(Token = "0x60084C6"), Address(RVA = "0x4067B68", Offset = "0x4067B68", VA = "0x4067B68")] set
      {
      }
    }

    [Token(Token = "0x170014F1")]
    private ActionIconUIAssetData AssetData
    {
      [Token(Token = "0x60084C7"), Address(RVA = "0x4067B70", Offset = "0x4067B70", VA = "0x4067B70")] get
      {
        return (ActionIconUIAssetData) null;
      }
    }

    [Token(Token = "0x170014F2")]
    protected float duplicationClipDistance
    {
      [Token(Token = "0x60084C8"), Address(RVA = "0x4067B78", Offset = "0x4067B78", VA = "0x4067B78")] set
      {
      }
      [Token(Token = "0x60084C9"), Address(RVA = "0x4067B80", Offset = "0x4067B80", VA = "0x4067B80")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170014F3")]
    protected override Vector3 OffsetPos
    {
      [Token(Token = "0x60084CA"), Address(RVA = "0x4067B88", Offset = "0x4067B88", VA = "0x4067B88", Slot = "8")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x60084CB")]
    [Address(RVA = "0x4067BA8", Offset = "0x4067BA8", VA = "0x4067BA8")]
    public FreeMapActionIconUIBuilder(
      ActionIconUIAssetData data,
      params FreeMapUIParamBase[] uiParams)
    {
    }

    [Token(Token = "0x60084CC")]
    [Address(RVA = "0x4067F28", Offset = "0x4067F28", VA = "0x4067F28")]
    public FreeMapActionIconUIBuilder(
      FreeMapActionIconUI uiInstance,
      ActionIconUIAssetData data,
      params FreeMapUIParamBase[] uiParams)
    {
    }

    [Token(Token = "0x60084CD")]
    [Address(RVA = "0x4067F54", Offset = "0x4067F54", VA = "0x4067F54", Slot = "9")]
    protected override void InitializeInternal(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x60084CE")]
    [Address(RVA = "0x4068268", Offset = "0x4068268", VA = "0x4068268", Slot = "10")]
    protected override void BuildInternal(
      Transform uiParent,
      FreeMapInstance target,
      FreeMapUITransformHolder holder,
      FreeMapCommonElement commonElement,
      FreeMapIconEventControlElement iconEventElement)
    {
    }

    [Token(Token = "0x60084CF")]
    [Address(RVA = "0x4068710", Offset = "0x4068710", VA = "0x4068710", Slot = "11")]
    protected override void AddBuildInternal(
      Transform uiParent,
      FreeMapInstance target,
      FreeMapUITransformHolder holder,
      FreeMapCommonElement commonElement,
      FreeMapIconEventControlElement iconEventElement)
    {
    }

    [Token(Token = "0x60084D0")]
    [Address(RVA = "0x4068398", Offset = "0x4068398", VA = "0x4068398")]
    private void CreateElement(
      Transform uiParent,
      FreeMapInstance target,
      FreeMapUITransformHolder holder,
      FreeMapCommonElement commonElement,
      FreeMapIconEventControlElement iconEventElement)
    {
    }

    [Token(Token = "0x60084D1")]
    [Address(RVA = "0x4068850", Offset = "0x4068850", VA = "0x4068850", Slot = "12")]
    protected override void FinalizeInternal()
    {
    }

    [Token(Token = "0x60084D2")]
    [Address(RVA = "0x40688F4", Offset = "0x40688F4", VA = "0x40688F4", Slot = "13")]
    protected override FreeMapMovePosition GetMovePoint(FreeMapInstance target)
    {
      return (FreeMapMovePosition) null;
    }

    [Token(Token = "0x60084D3")]
    [Address(RVA = "0x4068950", Offset = "0x4068950", VA = "0x4068950")]
    static FreeMapActionIconUIBuilder()
    {
    }

    [Token(Token = "0x2001772")]
    private class BuildData
    {
      [Token(Token = "0x170014F4")]
      public FreeMapUIParamBase UIParam
      {
        [Token(Token = "0x60084D4"), Address(RVA = "0x4068B44", Offset = "0x4068B44", VA = "0x4068B44")] set
        {
        }
        [Token(Token = "0x60084D5"), Address(RVA = "0x4068B4C", Offset = "0x4068B4C", VA = "0x4068B4C")] get
        {
          return (FreeMapUIParamBase) null;
        }
      }

      [Token(Token = "0x170014F5")]
      public SpriteAssetLoader SpriteLoader
      {
        [Token(Token = "0x60084D6"), Address(RVA = "0x4068B54", Offset = "0x4068B54", VA = "0x4068B54")] set
        {
        }
        [Token(Token = "0x60084D7"), Address(RVA = "0x4068B5C", Offset = "0x4068B5C", VA = "0x4068B5C")] get
        {
          return (SpriteAssetLoader) null;
        }
      }

      [Token(Token = "0x170014F6")]
      public IconPrefabAssetLoader IconLoader
      {
        [Token(Token = "0x60084D8"), Address(RVA = "0x4068B64", Offset = "0x4068B64", VA = "0x4068B64")] set
        {
        }
        [Token(Token = "0x60084D9"), Address(RVA = "0x4068B6C", Offset = "0x4068B6C", VA = "0x4068B6C")] get
        {
          return (IconPrefabAssetLoader) null;
        }
      }

      [Token(Token = "0x60084DA")]
      [Address(RVA = "0x4067FE0", Offset = "0x4067FE0", VA = "0x4067FE0")]
      public void Load(IFreeMapResourceLoader loader)
      {
      }

      [Token(Token = "0x60084DB")]
      [Address(RVA = "0x40688C0", Offset = "0x40688C0", VA = "0x40688C0")]
      public void Release()
      {
      }

      [Token(Token = "0x60084DC")]
      [Address(RVA = "0x4067E40", Offset = "0x4067E40", VA = "0x4067E40")]
      public BuildData()
      {
      }
    }
  }
}
