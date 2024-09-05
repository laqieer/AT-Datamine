// Decompiled with JetBrains decompiler
// Type: Scenes.Story.MinimapItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Story.PocketBook.StoryIndex.MapViewer;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story
{
  [Token(Token = "0x2002D71")]
  public class MinimapItem : MonoBehaviour
  {
    [Token(Token = "0x400C30A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button mapButton;
    [Token(Token = "0x400C30B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image mapImage;
    [Token(Token = "0x400C30C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image triangleImage;
    [Token(Token = "0x400C30D")]
    [FieldOffset(Offset = "0x30")]
    private bool activatable;
    [Token(Token = "0x400C30E")]
    [FieldOffset(Offset = "0x38")]
    private MinimapRectalize rectalize;

    [Token(Token = "0x17003CB0")]
    private bool isActive
    {
      [Token(Token = "0x6011C32"), Address(RVA = "0x42BDC1C", Offset = "0x42BDC1C", VA = "0x42BDC1C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6011C33")]
    [Address(RVA = "0x42BDC3C", Offset = "0x42BDC3C", VA = "0x42BDC3C")]
    public void SetArea(int backGroundID, int minimapID, Action callback)
    {
    }

    [Token(Token = "0x6011C34")]
    [Address(RVA = "0x42BDEC0", Offset = "0x42BDEC0", VA = "0x42BDEC0")]
    private IEnumerator Load(string abname, string assetname, Action<Sprite> onloaded)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011C35")]
    [Address(RVA = "0x42BDF64", Offset = "0x42BDF64", VA = "0x42BDF64")]
    private void OnLoaded()
    {
    }

    [Token(Token = "0x6011C36")]
    [Address(RVA = "0x42BDF68", Offset = "0x42BDF68", VA = "0x42BDF68")]
    public void SetActivate(bool activatable)
    {
    }

    [Token(Token = "0x6011C37")]
    [Address(RVA = "0x42BDF74", Offset = "0x42BDF74", VA = "0x42BDF74")]
    public void Show()
    {
    }

    [Token(Token = "0x6011C38")]
    [Address(RVA = "0x42BDFBC", Offset = "0x42BDFBC", VA = "0x42BDFBC")]
    public void Hide()
    {
    }

    [Token(Token = "0x6011C39")]
    [Address(RVA = "0x42BDFE8", Offset = "0x42BDFE8", VA = "0x42BDFE8")]
    public void InteractEnable()
    {
    }

    [Token(Token = "0x6011C3A")]
    [Address(RVA = "0x42BE008", Offset = "0x42BE008", VA = "0x42BE008")]
    public void InteractDisable()
    {
    }

    [Token(Token = "0x6011C3B")]
    [Address(RVA = "0x42BE028", Offset = "0x42BE028", VA = "0x42BE028")]
    public void Release()
    {
    }

    [Token(Token = "0x6011C3C")]
    [Address(RVA = "0x42BE050", Offset = "0x42BE050", VA = "0x42BE050")]
    public void ObservedPlayerPosition(Vector3 position, Quaternion quaternion)
    {
    }

    [Token(Token = "0x6011C3D")]
    [Address(RVA = "0x42BE114", Offset = "0x42BE114", VA = "0x42BE114")]
    public MinimapItem()
    {
    }
  }
}
