// Decompiled with JetBrains decompiler
// Type: UI.Utilities.SerializeUI.ImageContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.Utilities.SerializeUI
{
  [Token(Token = "0x20008A9")]
  [Serializable]
  public class ImageContainer : ContainerBase
  {
    [Token(Token = "0x40028AE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image image;

    [Token(Token = "0x17000721")]
    public bool IsEmpty
    {
      [Token(Token = "0x6003147"), Address(RVA = "0x3C16340", Offset = "0x3C16340", VA = "0x3C16340")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003148")]
    [Address(RVA = "0x3C163AC", Offset = "0x3C163AC", VA = "0x3C163AC")]
    public void Set(Sprite value, bool autoActive = true)
    {
    }

    [Token(Token = "0x6003149")]
    [Address(RVA = "0x3C16458", Offset = "0x3C16458", VA = "0x3C16458", Slot = "4")]
    public override void SetActive(bool active)
    {
    }

    [Token(Token = "0x600314A")]
    [Address(RVA = "0x3C164BC", Offset = "0x3C164BC", VA = "0x3C164BC")]
    public ImageContainer()
    {
    }
  }
}
