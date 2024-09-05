// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Builder.FreeMapSoundObjectBuilder
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
  [Token(Token = "0x200192C")]
  public class FreeMapSoundObjectBuilder : FreeMapInstanceBuilderBase<FreeMapSoundObject>
  {
    [Token(Token = "0x4006C80")]
    private const string SoundObjectInstanceNamePrefix = "SoundInstance";
    [Token(Token = "0x4006C81")]
    public const string AssetBundleName = "freemap_sound_npcevent";
    [Token(Token = "0x4006C86")]
    [FieldOffset(Offset = "0x70")]
    private GameObject soundObject;

    [Token(Token = "0x170016F3")]
    protected override string ObjectName
    {
      [Token(Token = "0x6008F20"), Address(RVA = "0x4B05B30", Offset = "0x4B05B30", VA = "0x4B05B30", Slot = "11")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170016F4")]
    public override FreeMapBuildOrder BuildOrder
    {
      [Token(Token = "0x6008F21"), Address(RVA = "0x4B05B88", Offset = "0x4B05B88", VA = "0x4B05B88", Slot = "13")] get
      {
        return new FreeMapBuildOrder();
      }
    }

    [Token(Token = "0x170016F5")]
    protected override string LayerName
    {
      [Token(Token = "0x6008F22"), Address(RVA = "0x4B05B90", Offset = "0x4B05B90", VA = "0x4B05B90", Slot = "12")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170016F6")]
    public InstanceID TargetInstanceID
    {
      [Token(Token = "0x6008F23"), Address(RVA = "0x4B05BD0", Offset = "0x4B05BD0", VA = "0x4B05BD0")] get
      {
        return new InstanceID();
      }
    }

    [Token(Token = "0x170016F7")]
    public string PrefabAssetName
    {
      [Token(Token = "0x6008F24"), Address(RVA = "0x4B05BD8", Offset = "0x4B05BD8", VA = "0x4B05BD8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170016F8")]
    public string SoundFileName
    {
      [Token(Token = "0x6008F25"), Address(RVA = "0x4B05BE0", Offset = "0x4B05BE0", VA = "0x4B05BE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170016F9")]
    public string[] Events
    {
      [Token(Token = "0x6008F26"), Address(RVA = "0x4B05BE8", Offset = "0x4B05BE8", VA = "0x4B05BE8")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x6008F27")]
    [Address(RVA = "0x4B05BF0", Offset = "0x4B05BF0", VA = "0x4B05BF0")]
    public FreeMapSoundObjectBuilder(
      int targetObject,
      string objectAccessName,
      string assetName,
      string fileName,
      string[] events)
    {
    }

    [Token(Token = "0x6008F28")]
    [Address(RVA = "0x4B05CE0", Offset = "0x4B05CE0", VA = "0x4B05CE0", Slot = "14")]
    protected override void InitializeInternal(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6008F29")]
    [Address(RVA = "0x4B05E1C", Offset = "0x4B05E1C", VA = "0x4B05E1C", Slot = "15")]
    protected override void BuildInternal(FreeMapCommonElement element)
    {
    }

    [Token(Token = "0x6008F2A")]
    [Address(RVA = "0x4B06084", Offset = "0x4B06084", VA = "0x4B06084", Slot = "17")]
    protected override void FinalizeInternal()
    {
    }

    [Token(Token = "0x6008F2B")]
    [Address(RVA = "0x4B0608C", Offset = "0x4B0608C", VA = "0x4B0608C")]
    protected void LoadAssetCallback(GameObject asset)
    {
    }

    [Token(Token = "0x6008F2C")]
    [Address(RVA = "0x4B0611C", Offset = "0x4B0611C", VA = "0x4B0611C")]
    public static FreeMapSoundObjectBuilder Create(
      StoryFreeActionSoundEffectData data,
      StoryFreeActionSoundObjectData objData)
    {
      return (FreeMapSoundObjectBuilder) null;
    }
  }
}
