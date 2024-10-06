// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.TitleSelect.SelectedTitlePanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.TitleEmblem;
using System.Threading;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Popup.TitleSelect
{
  [Token(Token = "0x2003467")]
  public class SelectedTitlePanel : TitlePanel
  {
    [Token(Token = "0x400E3EC")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject[] underLines;
    [Token(Token = "0x400E3ED")]
    [FieldOffset(Offset = "0x68")]
    private CancellationTokenSource canceller;

    [Token(Token = "0x601490A")]
    [Address(RVA = "0x1AA5CFC", Offset = "0x1AA5CFC", VA = "0x1AA5CFC")]
    public void Set(TitleSet titleSet, ITitleLoader loader)
    {
    }

    [Token(Token = "0x601490B")]
    [Address(RVA = "0x1AA5DD8", Offset = "0x1AA5DD8", VA = "0x1AA5DD8")]
    private void SetUnderLine(bool visible)
    {
    }

    [Token(Token = "0x601490C")]
    [Address(RVA = "0x1AA5E48", Offset = "0x1AA5E48", VA = "0x1AA5E48")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x601490D")]
    [Address(RVA = "0x1AA5E5C", Offset = "0x1AA5E5C", VA = "0x1AA5E5C")]
    public SelectedTitlePanel()
    {
    }
  }
}
