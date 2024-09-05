// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AI.AITab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AI
{
  [Token(Token = "0x20032EC")]
  public class AITab : MonoBehaviour
  {
    [Token(Token = "0x400DBD4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400DBD5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text label;
    [Token(Token = "0x400DBD6")]
    [FieldOffset(Offset = "0x28")]
    private AIRoleData role;

    [Token(Token = "0x17004325")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6014027"), Address(RVA = "0x234B58C", Offset = "0x234B58C", VA = "0x234B58C")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17004326")]
    public Action<AIRoleData> OnSelectTab
    {
      [Token(Token = "0x6014028"), Address(RVA = "0x234B594", Offset = "0x234B594", VA = "0x234B594")] get
      {
        return (Action<AIRoleData>) null;
      }
      [Token(Token = "0x6014029"), Address(RVA = "0x234B59C", Offset = "0x234B59C", VA = "0x234B59C")] private set
      {
      }
    }

    [Token(Token = "0x601402A")]
    [Address(RVA = "0x234B5A4", Offset = "0x234B5A4", VA = "0x234B5A4")]
    public void Initialize(AIRoleData role, Action<AIRoleData> onSelectTab)
    {
    }

    [Token(Token = "0x601402B")]
    [Address(RVA = "0x234B6A8", Offset = "0x234B6A8", VA = "0x234B6A8")]
    public void SetupCallback()
    {
    }

    [Token(Token = "0x601402C")]
    [Address(RVA = "0x234B76C", Offset = "0x234B76C", VA = "0x234B76C")]
    public void OnValueChange(bool isOn)
    {
    }

    [Token(Token = "0x601402D")]
    [Address(RVA = "0x234B790", Offset = "0x234B790", VA = "0x234B790")]
    public AITab()
    {
    }
  }
}
