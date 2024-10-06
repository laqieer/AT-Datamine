// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Unit.UI.UnitPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Unit.UI
{
  [Token(Token = "0x2003550")]
  public class UnitPopup : PopupBase
  {
    [Token(Token = "0x400E7DC")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private UnitInfoUI unitInfoUI;
    [Token(Token = "0x400E7DE")]
    [FieldOffset(Offset = "0x98")]
    private UnitInfoView unitInfoView;

    [Token(Token = "0x17004561")]
    public CoroutineHandler CoroutineHandler
    {
      [Token(Token = "0x6014EB6"), Address(RVA = "0x1B4B874", Offset = "0x1B4B874", VA = "0x1B4B874")] get
      {
        return (CoroutineHandler) null;
      }
      [Token(Token = "0x6014EB7"), Address(RVA = "0x1B4B87C", Offset = "0x1B4B87C", VA = "0x1B4B87C")] private set
      {
      }
    }

    [Token(Token = "0x6014EB8")]
    [Address(RVA = "0x1B4B884", Offset = "0x1B4B884", VA = "0x1B4B884")]
    private void Update()
    {
    }

    [Token(Token = "0x6014EB9")]
    [Address(RVA = "0x1B4B58C", Offset = "0x1B4B58C", VA = "0x1B4B58C")]
    public void Initialize(bool isNeedLp)
    {
    }

    [Token(Token = "0x6014EBA")]
    [Address(RVA = "0x1B42C78", Offset = "0x1B42C78", VA = "0x1B42C78")]
    public UnitInfoView CreateUnitInfoView() => (UnitInfoView) null;

    [Token(Token = "0x6014EBB")]
    [Address(RVA = "0x1B42268", Offset = "0x1B42268", VA = "0x1B42268")]
    public void SetEquipEnhanceOpenAction(Action action)
    {
    }

    [Token(Token = "0x6014EBC")]
    [Address(RVA = "0x1B422F0", Offset = "0x1B422F0", VA = "0x1B422F0")]
    public void SetEquipEnhanceBackAction(Action action)
    {
    }

    [Token(Token = "0x6014EBD")]
    [Address(RVA = "0x1B4B8A0", Offset = "0x1B4B8A0", VA = "0x1B4B8A0", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6014EBE")]
    [Address(RVA = "0x1B4B8AC", Offset = "0x1B4B8AC", VA = "0x1B4B8AC")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6014EBF")]
    [Address(RVA = "0x1B4B8C8", Offset = "0x1B4B8C8", VA = "0x1B4B8C8")]
    public UnitPopup()
    {
    }
  }
}
