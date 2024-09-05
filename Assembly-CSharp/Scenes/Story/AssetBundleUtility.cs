// Decompiled with JetBrains decompiler
// Type: Scenes.Story.AssetBundleUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DLC;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Scenes.Story
{
  [Token(Token = "0x2002D68")]
  public static class AssetBundleUtility
  {
    [Token(Token = "0x400C2D9")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string[] paths;

    [Token(Token = "0x6011BE8")]
    [Address(RVA = "0x42BC500", Offset = "0x42BC500", VA = "0x42BC500")]
    public static IEnumerator LoadAsync() => (IEnumerator) null;

    [Token(Token = "0x6011BE9")]
    [Address(RVA = "0x42BC588", Offset = "0x42BC588", VA = "0x42BC588")]
    public static void Release()
    {
    }

    [Token(Token = "0x6011BEA")]
    [Address(RVA = "0x42BC684", Offset = "0x42BC684", VA = "0x42BC684")]
    private static IEnumerator LoadAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x6011BEB")]
    [Address(RVA = "0x42BC70C", Offset = "0x42BC70C", VA = "0x42BC70C")]
    private static LoadedAssetBundle GetLoadedAssetBundle(string path) => (LoadedAssetBundle) null;

    [Token(Token = "0x6011BEC")]
    [Address(RVA = "0x42BC7A0", Offset = "0x42BC7A0", VA = "0x42BC7A0")]
    public static LoadedAssetBundle LoadedABMap() => (LoadedAssetBundle) null;

    [Token(Token = "0x6011BED")]
    [Address(RVA = "0x42BC804", Offset = "0x42BC804", VA = "0x42BC804")]
    public static LoadedAssetBundle LoadedABMapUISpriteAtlas() => (LoadedAssetBundle) null;

    [Token(Token = "0x6011BEE")]
    [Address(RVA = "0x42BC868", Offset = "0x42BC868", VA = "0x42BC868")]
    static AssetBundleUtility()
    {
    }

    [Token(Token = "0x2002D69")]
    private static class Paths
    {
      [Token(Token = "0x400C2DA")]
      public const string StoryMapUI = "2dassets_ui_story_map";
      [Token(Token = "0x400C2DB")]
      public const string StoryMapUISpriteAtlas = "2dassets_ui_spriteatlases";
    }
  }
}
