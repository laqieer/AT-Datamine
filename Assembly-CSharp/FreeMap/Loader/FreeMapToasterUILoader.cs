// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.FreeMapToasterUILoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Story;
using System.Collections;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x20018A9")]
  public class FreeMapToasterUILoader
  {
    [Token(Token = "0x4006B18")]
    private const string TARGET_DLC_LABEL = "2dassets_ui_common";
    [Token(Token = "0x4006B19")]
    private const string TARGET_PREFAB_NAME = "Com_Toaster_03";

    [Token(Token = "0x6008C0A")]
    [Address(RVA = "0x452AE8C", Offset = "0x452AE8C", VA = "0x452AE8C")]
    public static IEnumerator LoadAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x6008C0B")]
    [Address(RVA = "0x452AF14", Offset = "0x452AF14", VA = "0x452AF14")]
    public static ToasterUI CreateObject() => (ToasterUI) null;

    [Token(Token = "0x6008C0C")]
    [Address(RVA = "0x452B084", Offset = "0x452B084", VA = "0x452B084")]
    public static void UnloadAssetBundle()
    {
    }

    [Token(Token = "0x6008C0D")]
    [Address(RVA = "0x452B118", Offset = "0x452B118", VA = "0x452B118")]
    public FreeMapToasterUILoader()
    {
    }
  }
}
