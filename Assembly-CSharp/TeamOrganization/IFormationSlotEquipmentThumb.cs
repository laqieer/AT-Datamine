// Decompiled with JetBrains decompiler
// Type: TeamOrganization.IFormationSlotEquipmentThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000819")]
  public interface IFormationSlotEquipmentThumb
  {
    [Token(Token = "0x6002E71")]
    void Initialize(
      CommonButton button,
      CommonButton lockButton,
      AssetCachedSpawner assetCachedSpawner);

    [Token(Token = "0x6002E72")]
    void SetAction(Action onClick = null, Action onLongPress = null);

    [Token(Token = "0x6002E73")]
    void UpdateView(EquipmentSlotThumbModel model);
  }
}
