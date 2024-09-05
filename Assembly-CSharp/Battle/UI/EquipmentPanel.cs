// Decompiled with JetBrains decompiler
// Type: Battle.UI.EquipmentPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Equipment.UI;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002381")]
  public class EquipmentPanel : BattlePopupPanel
  {
    [Token(Token = "0x400972A")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;

    [Token(Token = "0x17002E9C")]
    public EquipmentPopup Popup
    {
      [Token(Token = "0x600D8D8"), Address(RVA = "0x1B99C40", Offset = "0x1B99C40", VA = "0x1B99C40")] get
      {
        return (EquipmentPopup) null;
      }
      [Token(Token = "0x600D8D9"), Address(RVA = "0x1B99C48", Offset = "0x1B99C48", VA = "0x1B99C48")] private set
      {
      }
    }

    [Token(Token = "0x17002E9D")]
    public IAssetProvider AssetProvider
    {
      [Token(Token = "0x600D8DA"), Address(RVA = "0x1B91C00", Offset = "0x1B91C00", VA = "0x1B91C00")] get
      {
        return (IAssetProvider) null;
      }
    }

    [Token(Token = "0x600D8DB")]
    [Address(RVA = "0x1B99C50", Offset = "0x1B99C50", VA = "0x1B99C50")]
    public void Initialize(EquipmentPopup popup)
    {
    }

    [Token(Token = "0x600D8DC")]
    [Address(RVA = "0x1B94108", Offset = "0x1B94108", VA = "0x1B94108")]
    public void OnChange(IEquipmentModel model)
    {
    }

    [Token(Token = "0x600D8DD")]
    [Address(RVA = "0x1B99CFC", Offset = "0x1B99CFC", VA = "0x1B99CFC")]
    public EquipmentPanel()
    {
    }
  }
}
