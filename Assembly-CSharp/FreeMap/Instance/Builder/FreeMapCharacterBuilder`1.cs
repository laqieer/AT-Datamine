// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Builder.FreeMapCharacterBuilder`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Prop;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Builder
{
  [Token(Token = "0x200191D")]
  public abstract class FreeMapCharacterBuilder<TCharacter> : FreeMapInstanceBuilderBase<TCharacter> where TCharacter : FreeMapCharacter
  {
    [Token(Token = "0x4006C59")]
    protected const string CharaInstanceNamePrefix = "CharaInstance";
    [Token(Token = "0x4006C5A")]
    [FieldOffset(Offset = "0x0")]
    protected string startAnimationName;
    [Token(Token = "0x4006C5B")]
    [FieldOffset(Offset = "0x0")]
    protected StoryCharacterLookWeatherTypeEnum lookWeatherType;
    [Token(Token = "0x4006C5C")]
    [FieldOffset(Offset = "0x0")]
    protected StoryCharacterUtility.LoadResouceData resourceData;
    [Token(Token = "0x4006C5D")]
    [FieldOffset(Offset = "0x0")]
    protected PropSettingData[] propDatas;
    [Token(Token = "0x4006C5E")]
    [FieldOffset(Offset = "0x0")]
    protected List<FreeMapAssetHolder<GameObject>> propHolder;

    [Token(Token = "0x170016D8")]
    protected override string ObjectName
    {
      [Token(Token = "0x6008EC1")] get => (string) null;
    }

    [Token(Token = "0x170016D9")]
    protected override string LayerName
    {
      [Token(Token = "0x6008EC2")] get => (string) null;
    }

    [Token(Token = "0x170016DA")]
    public override FreeMapBuildOrder BuildOrder
    {
      [Token(Token = "0x6008EC3")] get => new FreeMapBuildOrder();
    }

    [Token(Token = "0x6008EC4")]
    public FreeMapCharacterBuilder(
      InstanceID id,
      string objectAccessName,
      string anchorName,
      Vector3 positionOffset,
      float rotationOffsetY,
      string startAnimationName,
      StoryCharacterLookWeatherTypeEnum lookWeatherType,
      StoryCharacterUtility.LoadResouceData resourceData,
      PropSettingData[] propDatas)
    {
    }

    [Token(Token = "0x6008EC5")]
    protected override void InitializeInternal(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6008EC6")]
    protected override void BuildInternal(FreeMapCommonElement element)
    {
    }

    [Token(Token = "0x6008EC7")]
    protected override void FinalizeInternal()
    {
    }

    [Token(Token = "0x6008EC8")]
    protected virtual void CreateController()
    {
    }

    [Token(Token = "0x6008EC9")]
    private void ModelAssetCallback(ResourceCacheHandle handle)
    {
    }

    [Token(Token = "0x6008ECA")]
    private void ClipAssetCallback(ResourceCacheHandle handle)
    {
    }

    [Token(Token = "0x6008ECB")]
    private void SetupPropBuild(IFreeMapResourceLoader loader, PropSettingData param)
    {
    }

    [Token(Token = "0x6008ECC")]
    private void AttachProp(GameObject obj, PropSettingData attachParam)
    {
    }
  }
}
