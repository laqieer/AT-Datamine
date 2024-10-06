// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Builder.FreeMapInstanceBuilderBase`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Builder
{
  [Token(Token = "0x2001924")]
  public abstract class FreeMapInstanceBuilderBase<TInstance> : IFreeMapInstanceBuilder where TInstance : FreeMapInstance
  {
    [Token(Token = "0x4006C69")]
    [FieldOffset(Offset = "0x0")]
    protected InstanceID instanceID;
    [Token(Token = "0x4006C6A")]
    [FieldOffset(Offset = "0x0")]
    protected string objectAccessName;
    [Token(Token = "0x4006C6B")]
    [FieldOffset(Offset = "0x0")]
    protected string anchorName;
    [Token(Token = "0x4006C6C")]
    [FieldOffset(Offset = "0x0")]
    protected Vector3 positionOffset;
    [Token(Token = "0x4006C6D")]
    [FieldOffset(Offset = "0x0")]
    protected float rotationOffsetY;
    [Token(Token = "0x4006C6E")]
    [FieldOffset(Offset = "0x0")]
    protected TInstance instance;
    [Token(Token = "0x4006C70")]
    [FieldOffset(Offset = "0x0")]
    protected IFreeMapBuildCondition buildCondition;

    [Token(Token = "0x170016DF")]
    public InstanceID InstanceID
    {
      [Token(Token = "0x6008EE3")] get => new InstanceID();
    }

    [Token(Token = "0x170016E0")]
    public string ObjectAccessName
    {
      [Token(Token = "0x6008EE4")] get => (string) null;
    }

    [Token(Token = "0x170016E1")]
    public string AnchorName
    {
      [Token(Token = "0x6008EE5")] get => (string) null;
      [Token(Token = "0x6008EE6")] set
      {
      }
    }

    [Token(Token = "0x170016E2")]
    public Vector3 PositionOffset
    {
      [Token(Token = "0x6008EE7")] get => new Vector3();
    }

    [Token(Token = "0x170016E3")]
    public float RotationOffsetY
    {
      [Token(Token = "0x6008EE8")] get => new float();
    }

    [Token(Token = "0x170016E4")]
    protected abstract string ObjectName { [Token(Token = "0x6008EE9")] get; }

    [Token(Token = "0x170016E5")]
    protected abstract string LayerName { [Token(Token = "0x6008EEA")] get; }

    [Token(Token = "0x170016E6")]
    public virtual FreeMapBuildOrder BuildOrder
    {
      [Token(Token = "0x6008EEB")] get => new FreeMapBuildOrder();
    }

    [Token(Token = "0x6008EEC")]
    public FreeMapInstanceBuilderBase(
      InstanceID instanceID,
      string objectAccessName,
      string anchorName,
      Vector3 positionOffset,
      float rotationOffsetY)
    {
    }

    [Token(Token = "0x6008EED")]
    public FreeMapInstance InitializeBuilder(Transform parent, IFreeMapResourceLoader loader)
    {
      return (FreeMapInstance) null;
    }

    [Token(Token = "0x6008EEE")]
    protected virtual void InitializeInternal(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6008EEF")]
    public FreeMapInstance Build(FreeMapCommonElement element) => (FreeMapInstance) null;

    [Token(Token = "0x6008EF0")]
    protected virtual void BuildInternal(FreeMapCommonElement element)
    {
    }

    [Token(Token = "0x6008EF1")]
    protected virtual void BuildInternal()
    {
    }

    [Token(Token = "0x6008EF2")]
    public void FinalizeBuilder()
    {
    }

    [Token(Token = "0x6008EF3")]
    protected virtual void FinalizeInternal()
    {
    }

    [Token(Token = "0x6008EF4")]
    public void SetBuildCondition(IFreeMapBuildCondition buildCondition)
    {
    }

    [Token(Token = "0x6008EF5")]
    public virtual bool CanCreate() => new bool();

    [Token(Token = "0x6008EF6")]
    public virtual bool CanCreate(int sequenceID) => new bool();

    [Token(Token = "0x6008EF7")]
    protected virtual TInstance CreateInstance(Transform parent) => (TInstance) null;
  }
}
