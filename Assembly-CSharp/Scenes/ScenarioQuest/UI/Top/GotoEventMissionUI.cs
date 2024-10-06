// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.UI.Top.GotoEventMissionUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.ScenarioQuest.UI.Top
{
  [Token(Token = "0x2002944")]
  [AddComponentMenu("ScenarioQuestTopEventMissionUI")]
  public class GotoEventMissionUI : MonoBehaviour
  {
    [Token(Token = "0x400AFEF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button btn;

    [Token(Token = "0x14000145")]
    public event Action OnClick
    {
      [Token(Token = "0x60103A4"), Address(RVA = "0x475109C", Offset = "0x475109C", VA = "0x475109C")] add
      {
      }
      [Token(Token = "0x60103A5"), Address(RVA = "0x4751138", Offset = "0x4751138", VA = "0x4751138")] remove
      {
      }
    }

    [Token(Token = "0x60103A6")]
    [Address(RVA = "0x47511D4", Offset = "0x47511D4", VA = "0x47511D4")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60103A7")]
    [Address(RVA = "0x47512C0", Offset = "0x47512C0", VA = "0x47512C0")]
    private void ClickInvoke()
    {
    }

    [Token(Token = "0x60103A8")]
    [Address(RVA = "0x47512E4", Offset = "0x47512E4", VA = "0x47512E4")]
    public GotoEventMissionUI()
    {
    }
  }
}
