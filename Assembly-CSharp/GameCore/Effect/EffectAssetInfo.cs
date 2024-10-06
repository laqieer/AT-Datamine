// Decompiled with JetBrains decompiler
// Type: GameCore.Effect.EffectAssetInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.ObjectModel;

#nullable disable
namespace GameCore.Effect
{
  [Token(Token = "0x200146A")]
  public class EffectAssetInfo : IEffectAssetInfoProvider
  {
    [Token(Token = "0x4005E03")]
    [FieldOffset(Offset = "0x10")]
    private ReadOnlyDictionary<string, EffectInfo> effectsTable;
    [Token(Token = "0x4005E04")]
    [FieldOffset(Offset = "0x18")]
    private ReadOnlyCollection<string> assetBundleGroupTable;
    [Token(Token = "0x4005E05")]
    [FieldOffset(Offset = "0x20")]
    private bool initialized;

    [Token(Token = "0x600730C")]
    [Address(RVA = "0x4054880", Offset = "0x4054880", VA = "0x4054880", Slot = "5")]
    public EffectInfo Find(string label) => new EffectInfo();

    [Token(Token = "0x600730D")]
    [Address(RVA = "0x4054D60", Offset = "0x4054D60", VA = "0x4054D60")]
    public EffectInfo Find(int labelID) => new EffectInfo();

    [Token(Token = "0x600730E")]
    [Address(RVA = "0x4054944", Offset = "0x4054944", VA = "0x4054944", Slot = "4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600730F")]
    [Address(RVA = "0x4054CDC", Offset = "0x4054CDC", VA = "0x4054CDC")]
    private bool LoadedTable() => new bool();

    [Token(Token = "0x6007310")]
    [Address(RVA = "0x4054E9C", Offset = "0x4054E9C", VA = "0x4054E9C")]
    public void Unload()
    {
    }

    [Token(Token = "0x6007311")]
    [Address(RVA = "0x4054EA4", Offset = "0x4054EA4", VA = "0x4054EA4")]
    public EffectAssetInfo()
    {
    }
  }
}
