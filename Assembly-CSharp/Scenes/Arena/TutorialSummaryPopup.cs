// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.TutorialSummaryPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x200316E")]
  public class TutorialSummaryPopup : PopupBase
  {
    [Token(Token = "0x400D294")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Transform scrollContent;

    [Token(Token = "0x60134AB")]
    [Address(RVA = "0x4A2BD9C", Offset = "0x4A2BD9C", VA = "0x4A2BD9C", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x60134AC")]
    [Address(RVA = "0x4A2BDA4", Offset = "0x4A2BDA4", VA = "0x4A2BDA4", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x60134AD")]
    [Address(RVA = "0x4A28E04", Offset = "0x4A28E04", VA = "0x4A28E04")]
    public void Initialize(
      TutorialSummaryPopup.TutorialCategoryId categoryId,
      GameObject buttonPrefab)
    {
    }

    [Token(Token = "0x60134AE")]
    [Address(RVA = "0x4A2BDAC", Offset = "0x4A2BDAC", VA = "0x4A2BDAC")]
    public TutorialSummaryPopup()
    {
    }

    [Token(Token = "0x200316F")]
    public enum TutorialCategoryId
    {
      [Token(Token = "0x400D296")] Arena = 1,
    }
  }
}
