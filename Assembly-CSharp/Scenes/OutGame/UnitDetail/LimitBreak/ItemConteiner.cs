// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.LimitBreak.ItemConteiner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.LimitBreak
{
  [Token(Token = "0x20032E7")]
  public class ItemConteiner : MonoBehaviour
  {
    [Token(Token = "0x400DBAE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400DBAF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400DBB0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text necessaryNumText;
    [Token(Token = "0x400DBB1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text possessionNumText;
    [Token(Token = "0x400DBB2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Color warningColor;
    [Token(Token = "0x400DBB3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Color defaultColor;

    [Token(Token = "0x1700431E")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6014007"), Address(RVA = "0x2349B0C", Offset = "0x2349B0C", VA = "0x2349B0C")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x6014008")]
    [Address(RVA = "0x2349B14", Offset = "0x2349B14", VA = "0x2349B14")]
    public void SetData(int itemId, int necessaryNum, int possessionNum)
    {
    }

    [Token(Token = "0x6014009")]
    [Address(RVA = "0x2349D08", Offset = "0x2349D08", VA = "0x2349D08")]
    public ItemConteiner()
    {
    }
  }
}
