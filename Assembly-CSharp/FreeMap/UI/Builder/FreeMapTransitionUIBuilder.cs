// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Builder.FreeMapTransitionUIBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Loader;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.Control.Animation;
using FreeMap.UI.Element;
using FreeMap.UI.Entity;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Builder
{
  [Token(Token = "0x2001777")]
  public class FreeMapTransitionUIBuilder : FreeMapInstanceUIBuilder<FreeMapTransitionUI>
  {
    [Token(Token = "0x4006804")]
    private const float TransitionThresholdDistance = 6f;
    [Token(Token = "0x4006805")]
    [FieldOffset(Offset = "0x0")]
    private static readonly UIShowTweenNameList TransitionShowTweenNameList;
    [Token(Token = "0x4006806")]
    [FieldOffset(Offset = "0x8")]
    private static readonly UIRotationTweenNameList TransitionRotationTweenNameList;
    [Token(Token = "0x400680D")]
    [FieldOffset(Offset = "0x48")]
    private bool isPurposeMark;

    [Token(Token = "0x170014FA")]
    private FreeMapUIParamBase UIParam
    {
      [Token(Token = "0x60084F6"), Address(RVA = "0x4069AFC", Offset = "0x4069AFC", VA = "0x4069AFC")] get
      {
        return (FreeMapUIParamBase) null;
      }
    }

    [Token(Token = "0x170014FB")]
    private TransitionUIAssetData TransitionUIAsset
    {
      [Token(Token = "0x60084F7"), Address(RVA = "0x4069B04", Offset = "0x4069B04", VA = "0x4069B04")] get
      {
        return (TransitionUIAssetData) null;
      }
    }

    [Token(Token = "0x170014FC")]
    private SpriteAssetLoader SpriteLoader
    {
      [Token(Token = "0x60084F8"), Address(RVA = "0x4069B0C", Offset = "0x4069B0C", VA = "0x4069B0C")] set
      {
      }
      [Token(Token = "0x60084F9"), Address(RVA = "0x4069B14", Offset = "0x4069B14", VA = "0x4069B14")] get
      {
        return (SpriteAssetLoader) null;
      }
    }

    [Token(Token = "0x170014FD")]
    private IconPrefabAssetLoader DefaultIconLoader
    {
      [Token(Token = "0x60084FA"), Address(RVA = "0x4069B1C", Offset = "0x4069B1C", VA = "0x4069B1C")] set
      {
      }
      [Token(Token = "0x60084FB"), Address(RVA = "0x4069B24", Offset = "0x4069B24", VA = "0x4069B24")] get
      {
        return (IconPrefabAssetLoader) null;
      }
    }

    [Token(Token = "0x170014FE")]
    private IconPrefabAssetLoader NearIconLoader
    {
      [Token(Token = "0x60084FC"), Address(RVA = "0x4069B2C", Offset = "0x4069B2C", VA = "0x4069B2C")] set
      {
      }
      [Token(Token = "0x60084FD"), Address(RVA = "0x4069B34", Offset = "0x4069B34", VA = "0x4069B34")] get
      {
        return (IconPrefabAssetLoader) null;
      }
    }

    [Token(Token = "0x170014FF")]
    private string ToAreaName
    {
      [Token(Token = "0x60084FE"), Address(RVA = "0x4069B3C", Offset = "0x4069B3C", VA = "0x4069B3C")] set
      {
      }
      [Token(Token = "0x60084FF"), Address(RVA = "0x4069B44", Offset = "0x4069B44", VA = "0x4069B44")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001500")]
    protected override Vector3 OffsetPos
    {
      [Token(Token = "0x6008500"), Address(RVA = "0x4069B4C", Offset = "0x4069B4C", VA = "0x4069B4C", Slot = "8")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x6008501")]
    [Address(RVA = "0x4069B6C", Offset = "0x4069B6C", VA = "0x4069B6C")]
    public FreeMapTransitionUIBuilder(
      FreeMapUIParamBase uiParam,
      TransitionUIAssetData data,
      int toAreaID,
      bool purposeMark)
    {
    }

    [Token(Token = "0x6008502")]
    [Address(RVA = "0x4069BD0", Offset = "0x4069BD0", VA = "0x4069BD0")]
    public FreeMapTransitionUIBuilder(
      FreeMapUIParamBase uiParam,
      TransitionUIAssetData data,
      string toAreaName)
    {
    }

    [Token(Token = "0x6008503")]
    [Address(RVA = "0x4069D50", Offset = "0x4069D50", VA = "0x4069D50", Slot = "9")]
    protected override void InitializeInternal(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6008504")]
    [Address(RVA = "0x4069D98", Offset = "0x4069D98", VA = "0x4069D98", Slot = "10")]
    protected override void BuildInternal(
      Transform uiParent,
      FreeMapInstance target,
      FreeMapUITransformHolder holder,
      FreeMapCommonElement commonElement,
      FreeMapIconEventControlElement iconEventElement)
    {
    }

    [Token(Token = "0x6008505")]
    [Address(RVA = "0x406A298", Offset = "0x406A298", VA = "0x406A298", Slot = "12")]
    protected override void FinalizeInternal()
    {
    }

    [Token(Token = "0x6008506")]
    [Address(RVA = "0x406A2CC", Offset = "0x406A2CC", VA = "0x406A2CC")]
    static FreeMapTransitionUIBuilder()
    {
    }
  }
}
