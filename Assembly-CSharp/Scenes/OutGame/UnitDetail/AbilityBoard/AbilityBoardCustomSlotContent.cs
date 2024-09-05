// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardCustomSlotContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003320")]
  internal class AbilityBoardCustomSlotContent : MonoBehaviour
  {
    [Token(Token = "0x400DD2D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject[] icons;
    [Token(Token = "0x400DD2E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text effectText;

    [Token(Token = "0x6014193")]
    [Address(RVA = "0x20C6F80", Offset = "0x20C6F80", VA = "0x20C6F80")]
    public void FirstOpen()
    {
    }

    [Token(Token = "0x6014194")]
    [Address(RVA = "0x20C7020", Offset = "0x20C7020", VA = "0x20C7020")]
    public void SetData(AbilityboardCustomANodeData nodeData, string effect, bool showText)
    {
    }

    [Token(Token = "0x6014195")]
    [Address(RVA = "0x20C7120", Offset = "0x20C7120", VA = "0x20C7120")]
    private void SetIcon(MoldTypeEnum type)
    {
    }

    [Token(Token = "0x6014196")]
    [Address(RVA = "0x20C71C0", Offset = "0x20C71C0", VA = "0x20C71C0")]
    public AbilityBoardCustomSlotContent()
    {
    }
  }
}
