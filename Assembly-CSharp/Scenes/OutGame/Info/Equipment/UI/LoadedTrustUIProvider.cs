// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.UI.LoadedTrustUIProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Equipment.UI
{
  [Token(Token = "0x20035C0")]
  public class LoadedTrustUIProvider
  {
    [Token(Token = "0x400E9E1")]
    private const string AB_LABEL = "ui_page_abridged";
    [Token(Token = "0x400E9E2")]
    private const string ASSET_NAME = "Container_Equipment_Trust";

    [Token(Token = "0x6015277")]
    [Address(RVA = "0x4AAEEB8", Offset = "0x4AAEEB8", VA = "0x4AAEEB8")]
    public EquipmentTrustUI Instantiate(Transform parent) => (EquipmentTrustUI) null;

    [Token(Token = "0x6015278")]
    [Address(RVA = "0x4AAF030", Offset = "0x4AAF030", VA = "0x4AAF030")]
    public LoadedTrustUIProvider()
    {
    }
  }
}
