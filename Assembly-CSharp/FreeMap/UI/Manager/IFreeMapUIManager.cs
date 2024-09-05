// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Manager.IFreeMapUIManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.Control.Position;
using FreeMap.UI.Entity;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Manager
{
  [Token(Token = "0x200167F")]
  public interface IFreeMapUIManager
  {
    [Token(Token = "0x6007EFA")]
    void Update(Camera usingCamera, FreeMapPlayerInstance player);

    [Token(Token = "0x6007EFB")]
    IEnumerator WaitForUIBinding();

    [Token(Token = "0x6007EFC")]
    FreeMapUIBase Get(FreeMapUIParamBase param);

    [Token(Token = "0x6007EFD")]
    void ChangeUI(
      FreeMapCommonElement commonElement,
      FreeMapUIParamBase from,
      FreeMapUIParamBase to,
      string buttonObjectName,
      string spriteAtlasAssetBundleName,
      string spriteAtlasAssetName);

    [Token(Token = "0x6007EFE")]
    FreeMapUIBase RemoveUI(FreeMapUIParamBase param);

    [Token(Token = "0x6007EFF")]
    FreeMapUIBase RemoveUI(int objectID);

    [Token(Token = "0x6007F00")]
    FreeMapUIBase RemoveUI(InstanceID instanceID);

    [Token(Token = "0x6007F01")]
    void AttachAfterBinding(UITransformAvoidHandler correctiongHandler);
  }
}
