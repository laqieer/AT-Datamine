// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Builder.FreeMapPlayerBuilderBase`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Prop;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Builder
{
  [Token(Token = "0x2001929")]
  public abstract class FreeMapPlayerBuilderBase<TPlayer> : FreeMapCharacterBuilder<TPlayer> where TPlayer : FreeMapPlayerInstance
  {
    [Token(Token = "0x4006C74")]
    private const string PlayerObjectAccessNameString = "Player";
    [Token(Token = "0x4006C75")]
    private const string DefaultPlayerAnimation = "Idl";
    [Token(Token = "0x4006C76")]
    private const float EyesIntervalMin = 0.7f;
    [Token(Token = "0x4006C77")]
    private const float EyesIntervalMax = 2f;
    [Token(Token = "0x4006C78")]
    [FieldOffset(Offset = "0x0")]
    protected RuntimeAnimatorController controller;
    [Token(Token = "0x4006C79")]
    [FieldOffset(Offset = "0x0")]
    private bool isPlayerRegister;

    [Token(Token = "0x6008F06")]
    public FreeMapPlayerBuilderBase(
      string anchorName,
      Vector3 positionOffset,
      float rotationOffsetY,
      StoryCharacterLookWeatherTypeEnum lookWeatherType,
      StoryCharacterUtility.LoadResouceData resourceData,
      PropSettingData[] propData,
      bool isPlayerRegister,
      int instanceKey)
    {
    }

    [Token(Token = "0x6008F07")]
    protected override void InitializeInternal(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6008F08")]
    protected override void BuildInternal(FreeMapCommonElement element)
    {
    }

    [Token(Token = "0x6008F09")]
    protected override void FinalizeInternal()
    {
    }

    [Token(Token = "0x6008F0A")]
    protected override TPlayer CreateInstance(Transform parent) => (TPlayer) null;

    [Token(Token = "0x6008F0B")]
    protected override void CreateController()
    {
    }

    [Token(Token = "0x6008F0C")]
    private void AnimControllerAssetCallback(RuntimeAnimatorController asset)
    {
    }
  }
}
