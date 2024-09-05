// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.UI.Top.GotoNextUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.ScenarioQuest.UI.Top
{
  [Token(Token = "0x200294C")]
  [AddComponentMenu("ScenarioQuestTopNextUI")]
  public class GotoNextUI : MonoBehaviour
  {
    [Token(Token = "0x400B008")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button btn;
    [Token(Token = "0x400B009")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor txtTitle;

    [Token(Token = "0x14000148")]
    public event Action OnClick
    {
      [Token(Token = "0x60103CB"), Address(RVA = "0x4752170", Offset = "0x4752170", VA = "0x4752170")] add
      {
      }
      [Token(Token = "0x60103CC"), Address(RVA = "0x475220C", Offset = "0x475220C", VA = "0x475220C")] remove
      {
      }
    }

    [Token(Token = "0x60103CD")]
    [Address(RVA = "0x47522A8", Offset = "0x47522A8", VA = "0x47522A8")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60103CE")]
    [Address(RVA = "0x4752394", Offset = "0x4752394", VA = "0x4752394")]
    private void ClickInvoke()
    {
    }

    [Token(Token = "0x60103CF")]
    [Address(RVA = "0x47523B8", Offset = "0x47523B8", VA = "0x47523B8")]
    public void Set(string title)
    {
    }

    [Token(Token = "0x60103D0")]
    [Address(RVA = "0x47523D4", Offset = "0x47523D4", VA = "0x47523D4")]
    public GotoNextUI()
    {
    }
  }
}
