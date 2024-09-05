// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.UI.GoBackUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.ScenarioQuest.UI
{
  [Token(Token = "0x2002942")]
  [AddComponentMenu("ScenarioQuestTopBackUI")]
  public class GoBackUI : MonoBehaviour
  {
    [Token(Token = "0x400AFEB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button btn;

    [Token(Token = "0x14000144")]
    public event Action OnClick
    {
      [Token(Token = "0x601039C"), Address(RVA = "0x4750CFC", Offset = "0x4750CFC", VA = "0x4750CFC")] add
      {
      }
      [Token(Token = "0x601039D"), Address(RVA = "0x4750D98", Offset = "0x4750D98", VA = "0x4750D98")] remove
      {
      }
    }

    [Token(Token = "0x601039E")]
    [Address(RVA = "0x4750E34", Offset = "0x4750E34", VA = "0x4750E34")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x601039F")]
    [Address(RVA = "0x4750F20", Offset = "0x4750F20", VA = "0x4750F20")]
    private void ClickInvoke()
    {
    }

    [Token(Token = "0x60103A0")]
    [Address(RVA = "0x4750F44", Offset = "0x4750F44", VA = "0x4750F44")]
    public GoBackUI()
    {
    }
  }
}
