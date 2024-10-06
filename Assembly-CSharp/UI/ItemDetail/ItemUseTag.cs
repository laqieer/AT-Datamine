// Decompiled with JetBrains decompiler
// Type: UI.ItemDetail.ItemUseTag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.ItemDetail
{
  [Token(Token = "0x20008E9")]
  public class ItemUseTag : MonoBehaviour
  {
    [Token(Token = "0x40029C0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x40029C1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text usageName;

    [Token(Token = "0x1700074A")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6003273"), Address(RVA = "0x3C22F88", Offset = "0x3C22F88", VA = "0x3C22F88")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x6003274")]
    [Address(RVA = "0x3C188C0", Offset = "0x3C188C0", VA = "0x3C188C0")]
    public void SetUsageName(string usageName)
    {
    }

    [Token(Token = "0x6003275")]
    [Address(RVA = "0x3C22F90", Offset = "0x3C22F90", VA = "0x3C22F90")]
    public ItemUseTag()
    {
    }
  }
}
