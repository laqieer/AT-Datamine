// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.ContentMasterBonusDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x2003511")]
  public class ContentMasterBonusDetail : MonoBehaviour
  {
    [Token(Token = "0x400E6EC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ContentMasterBonusDetail.ViewObject currentValues;
    [Token(Token = "0x400E6ED")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ContentMasterBonusDetail.ViewObject hilightValues;

    [Token(Token = "0x6014D10")]
    [Address(RVA = "0x1B39670", Offset = "0x1B39670", VA = "0x1B39670")]
    public void SetValues(string name, int value, bool isHilight)
    {
    }

    [Token(Token = "0x6014D11")]
    [Address(RVA = "0x1B3A15C", Offset = "0x1B3A15C", VA = "0x1B3A15C")]
    public ContentMasterBonusDetail()
    {
    }

    [Token(Token = "0x2003512")]
    [Serializable]
    private class ViewObject
    {
      [Token(Token = "0x400E6EE")]
      [FieldOffset(Offset = "0x10")]
      public GameObject objectRoot;
      [Token(Token = "0x400E6EF")]
      [FieldOffset(Offset = "0x18")]
      public Text textName;
      [Token(Token = "0x400E6F0")]
      [FieldOffset(Offset = "0x20")]
      public Text textValue;

      [Token(Token = "0x6014D12")]
      [Address(RVA = "0x1B3A164", Offset = "0x1B3A164", VA = "0x1B3A164")]
      public ViewObject()
      {
      }
    }
  }
}
