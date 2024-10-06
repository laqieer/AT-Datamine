// Decompiled with JetBrains decompiler
// Type: CommonOptionLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x2000298")]
public class CommonOptionLoader
{
  [Token(Token = "0x4000F49")]
  public const string SubSceneAssetBundleName = "2dassets_ui_common";
  [Token(Token = "0x4000F4A")]
  public const string SubScenePrefabName = "Com_Popup_Option";
  [Token(Token = "0x4000F4B")]
  [FieldOffset(Offset = "0x10")]
  private CommonOptionScene popup;

  [Token(Token = "0x6001018")]
  [Address(RVA = "0x1BE51D4", Offset = "0x1BE51D4", VA = "0x1BE51D4")]
  public void OpenCommonOptionPopup(Action callback, CommonOptionScene.PAGETYPE pageType = CommonOptionScene.PAGETYPE.BATTLE)
  {
  }

  [Token(Token = "0x6001019")]
  [Address(RVA = "0x1BE5404", Offset = "0x1BE5404", VA = "0x1BE5404")]
  private CommonOptionScene CreateCommonOptionPopup(string assetBundleName, string assetName)
  {
    return (CommonOptionScene) null;
  }

  [Token(Token = "0x600101A")]
  [Address(RVA = "0x1BE589C", Offset = "0x1BE589C", VA = "0x1BE589C")]
  public CommonOptionLoader()
  {
  }
}
