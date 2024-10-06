// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.FreeMapSubQuestResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Story.SubQuest;
using System.Collections;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x20018A6")]
  public class FreeMapSubQuestResult
  {
    [Token(Token = "0x4006B11")]
    private const string TARGET_DLC_LABEL = "ui_page_adv";
    [Token(Token = "0x4006B12")]
    private const string TARGET_PREFAB_NAME = "Adv_SubQuestResult";

    [Token(Token = "0x6008BF9")]
    [Address(RVA = "0x452A460", Offset = "0x452A460", VA = "0x452A460")]
    public static IEnumerator LoadAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x6008BFA")]
    [Address(RVA = "0x452A4E8", Offset = "0x452A4E8", VA = "0x452A4E8")]
    public static SubQuestResult CreateObject() => (SubQuestResult) null;

    [Token(Token = "0x6008BFB")]
    [Address(RVA = "0x452A658", Offset = "0x452A658", VA = "0x452A658")]
    public static void UnloadAssetBundle()
    {
    }

    [Token(Token = "0x6008BFC")]
    [Address(RVA = "0x452A6EC", Offset = "0x452A6EC", VA = "0x452A6EC")]
    public FreeMapSubQuestResult()
    {
    }
  }
}
