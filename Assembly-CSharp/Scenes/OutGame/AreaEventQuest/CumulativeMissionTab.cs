// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaEventQuest.CumulativeMissionTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.AreaEventQuest
{
  [Token(Token = "0x200392F")]
  internal class CumulativeMissionTab : MonoBehaviour
  {
    [Token(Token = "0x400F9F9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400F9FA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image backImage;
    [Token(Token = "0x400F9FB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI tabNameText;
    [Token(Token = "0x400F9FC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject badgeObj;
    [Token(Token = "0x400F9FD")]
    [FieldOffset(Offset = "0x38")]
    private int tabId;
    [Token(Token = "0x400F9FE")]
    [FieldOffset(Offset = "0x40")]
    private SpriteAtlas spriteAtlas;
    [Token(Token = "0x400F9FF")]
    [FieldOffset(Offset = "0x48")]
    private TotalMissionTabData master;
    [Token(Token = "0x400FA00")]
    [FieldOffset(Offset = "0x50")]
    private List<TotalMissionDetailData> detail;
    [Token(Token = "0x400FA01")]
    [FieldOffset(Offset = "0x58")]
    private Action<int> onClickAction;

    [Token(Token = "0x60167A6")]
    [Address(RVA = "0x42E671C", Offset = "0x42E671C", VA = "0x42E671C")]
    public void Initialize(
      TotalMissionTabType tabType,
      bool isSelect,
      SpriteAtlas spriteAtlas,
      Action<int> onClickAction)
    {
    }

    [Token(Token = "0x60167A7")]
    [Address(RVA = "0x42E6BB0", Offset = "0x42E6BB0", VA = "0x42E6BB0")]
    public void UpdateTab(TotalMissionTabType tabType, bool isSelect, SpriteAtlas spriteAtlas)
    {
    }

    [Token(Token = "0x60167A8")]
    [Address(RVA = "0x42E6C04", Offset = "0x42E6C04", VA = "0x42E6C04")]
    private void OnClick()
    {
    }

    [Token(Token = "0x60167A9")]
    [Address(RVA = "0x42E6938", Offset = "0x42E6938", VA = "0x42E6938")]
    private void SetButtonBackImage(bool isSelect)
    {
    }

    [Token(Token = "0x60167AA")]
    [Address(RVA = "0x42E69C4", Offset = "0x42E69C4", VA = "0x42E69C4")]
    private bool ExistCanRecieve(TotalMissionTabType tabType) => new bool();

    [Token(Token = "0x60167AB")]
    [Address(RVA = "0x42E6C2C", Offset = "0x42E6C2C", VA = "0x42E6C2C")]
    public CumulativeMissionTab()
    {
    }
  }
}
