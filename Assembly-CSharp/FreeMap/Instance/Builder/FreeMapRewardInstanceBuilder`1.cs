// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Builder.FreeMapRewardInstanceBuilder`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Builder
{
  [Token(Token = "0x200192B")]
  public abstract class FreeMapRewardInstanceBuilder<TReward> : FreeMapInstanceBuilderBase<TReward> where TReward : FreeMapRewardInstance
  {
    [Token(Token = "0x4006C7D")]
    private const string RewardObjectInstanceNamePrefix = "RewardInstance";
    [Token(Token = "0x4006C7E")]
    [FieldOffset(Offset = "0x0")]
    protected GameObject model;

    [Token(Token = "0x170016EF")]
    protected override string ObjectName
    {
      [Token(Token = "0x6008F16")] get => (string) null;
    }

    [Token(Token = "0x170016F0")]
    public int SettingID
    {
      [Token(Token = "0x6008F17")] get => new int();
    }

    [Token(Token = "0x170016F1")]
    protected override string LayerName
    {
      [Token(Token = "0x6008F18")] get => (string) null;
    }

    [Token(Token = "0x170016F2")]
    protected int PropID
    {
      [Token(Token = "0x6008F19")] get => new int();
      [Token(Token = "0x6008F1A")] set
      {
      }
    }

    [Token(Token = "0x6008F1B")]
    public FreeMapRewardInstanceBuilder(
      int rewardLayoutID,
      int propID,
      string anchorName,
      Vector3 positionOffset,
      float rotationOffsetY)
    {
    }

    [Token(Token = "0x6008F1C")]
    protected override void InitializeInternal(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6008F1D")]
    protected override void BuildInternal()
    {
    }

    [Token(Token = "0x6008F1E")]
    protected override void FinalizeInternal()
    {
    }

    [Token(Token = "0x6008F1F")]
    protected void LoadModelCallback(GameObject asset)
    {
    }
  }
}
