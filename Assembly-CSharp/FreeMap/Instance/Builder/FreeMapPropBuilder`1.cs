// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Builder.FreeMapPropBuilder`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Builder
{
  [Token(Token = "0x200192A")]
  public class FreeMapPropBuilder<T> : FreeMapInstanceBuilderBase<T> where T : FreeMapPropInstance
  {
    [Token(Token = "0x4006C7A")]
    private const string InstanceNamePrefix = "PropInstance";

    [Token(Token = "0x170016EA")]
    protected override string ObjectName
    {
      [Token(Token = "0x6008F0D")] get => (string) null;
    }

    [Token(Token = "0x170016EB")]
    public override FreeMapBuildOrder BuildOrder
    {
      [Token(Token = "0x6008F0E")] get => new FreeMapBuildOrder();
    }

    [Token(Token = "0x170016EC")]
    protected override string LayerName
    {
      [Token(Token = "0x6008F0F")] get => (string) null;
    }

    [Token(Token = "0x170016ED")]
    public string AssetBundleName
    {
      [Token(Token = "0x6008F10")] get => (string) null;
    }

    [Token(Token = "0x170016EE")]
    public string PrefabAssetName
    {
      [Token(Token = "0x6008F11")] get => (string) null;
    }

    [Token(Token = "0x6008F12")]
    public FreeMapPropBuilder(
      int id,
      string objectAccessName,
      string anchorName,
      Vector3 offsetPos,
      float rotationOffsetY,
      int propID)
    {
    }

    [Token(Token = "0x6008F13")]
    protected override void InitializeInternal(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6008F14")]
    protected void LoadAssetCallback(GameObject asset)
    {
    }

    [Token(Token = "0x6008F15")]
    public static FreeMapPropBuilder<T> Create(
      IFreeActionLayoutData layoutData,
      IFreeActionObjectData objectData)
    {
      return (FreeMapPropBuilder<T>) null;
    }
  }
}
