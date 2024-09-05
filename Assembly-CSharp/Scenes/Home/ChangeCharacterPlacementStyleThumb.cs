// Decompiled with JetBrains decompiler
// Type: Scenes.Home.ChangeCharacterPlacementStyleThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Home
{
  [Token(Token = "0x2002AD1")]
  public class ChangeCharacterPlacementStyleThumb : MonoBehaviour
  {
    [Token(Token = "0x400B634")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject characterImageMain;
    [Token(Token = "0x400B635")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button changeButton;
    [Token(Token = "0x400B636")]
    [FieldOffset(Offset = "0x28")]
    private StyleThumb _styleThumb;

    [Token(Token = "0x6010BC8")]
    [Address(RVA = "0x4BDA2B8", Offset = "0x4BDA2B8", VA = "0x4BDA2B8")]
    public IEnumerator InitializeAsync(int styleId) => (IEnumerator) null;

    [Token(Token = "0x170039E1")]
    public Action OnClickButton
    {
      [Token(Token = "0x6010BC9"), Address(RVA = "0x4BDA358", Offset = "0x4BDA358", VA = "0x4BDA358")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6010BCA"), Address(RVA = "0x4BDA360", Offset = "0x4BDA360", VA = "0x4BDA360")] set
      {
      }
    }

    [Token(Token = "0x6010BCB")]
    [Address(RVA = "0x4BDA368", Offset = "0x4BDA368", VA = "0x4BDA368")]
    private void OnClickButtonWithItemIndex(int _)
    {
    }

    [Token(Token = "0x6010BCC")]
    [Address(RVA = "0x4BDA384", Offset = "0x4BDA384", VA = "0x4BDA384")]
    private void OnClickButtonCallBack()
    {
    }

    [Token(Token = "0x6010BCD")]
    [Address(RVA = "0x4BDA3A0", Offset = "0x4BDA3A0", VA = "0x4BDA3A0")]
    public ChangeCharacterPlacementStyleThumb()
    {
    }
  }
}
