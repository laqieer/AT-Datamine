// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.Common.UI.ActionIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.Common.UI
{
  [Token(Token = "0x2002DE8")]
  public class ActionIcon : MonoBehaviour
  {
    [Token(Token = "0x400C54C")]
    [FieldOffset(Offset = "0x18")]
    [Header("アイコン切り替え対象のImageを自動で探す")]
    [SerializeField]
    private bool autoSearch;
    [Token(Token = "0x400C54D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string iconImgName;
    [Token(Token = "0x400C54E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Header("アイコン画像")]
    private Image icon;
    [Token(Token = "0x400C54F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x400C550")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image purposeIcon;
    [Token(Token = "0x400C551")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Header("スケール参照")]
    private Transform scale;
    [Token(Token = "0x400C552")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [Header("ピボット制御")]
    private RectTransform[] pivotControls;
    [Token(Token = "0x400C553")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    protected UITweenGroup tweenGroup;
    [Token(Token = "0x400C554")]
    [FieldOffset(Offset = "0x58")]
    private WayControl control;

    [Token(Token = "0x6011F23")]
    [Address(RVA = "0x437258C", Offset = "0x437258C", VA = "0x437258C")]
    public Button GetButton() => (Button) null;

    [Token(Token = "0x17003D3F")]
    public Image Icon
    {
      [Token(Token = "0x6011F24"), Address(RVA = "0x4372620", Offset = "0x4372620", VA = "0x4372620")] get
      {
        return (Image) null;
      }
    }

    [Token(Token = "0x6011F25")]
    [Address(RVA = "0x4372628", Offset = "0x4372628", VA = "0x4372628")]
    public WayControl GetWayControl() => (WayControl) null;

    [Token(Token = "0x6011F26")]
    [Address(RVA = "0x43726FC", Offset = "0x43726FC", VA = "0x43726FC")]
    public void Change(Sprite sprite)
    {
    }

    [Token(Token = "0x6011F27")]
    [Address(RVA = "0x4372718", Offset = "0x4372718", VA = "0x4372718")]
    public void SetPurpose(bool sw)
    {
    }

    [Token(Token = "0x6011F28")]
    [Address(RVA = "0x4372750", Offset = "0x4372750", VA = "0x4372750")]
    public void Rankup(bool rankup)
    {
    }

    [Token(Token = "0x6011F29")]
    [Address(RVA = "0x43727C8", Offset = "0x43727C8", VA = "0x43727C8", Slot = "4")]
    protected virtual void OnValidate()
    {
    }

    [Token(Token = "0x6011F2A")]
    [Address(RVA = "0x437293C", Offset = "0x437293C", VA = "0x437293C")]
    private Image SearchIconImage() => (Image) null;

    [Token(Token = "0x6011F2B")]
    [Address(RVA = "0x437286C", Offset = "0x437286C", VA = "0x437286C")]
    private Transform SearchScaleTransform() => (Transform) null;

    [Token(Token = "0x6011F2C")]
    [Address(RVA = "0x43729F8", Offset = "0x43729F8", VA = "0x43729F8")]
    public ActionIcon()
    {
    }
  }
}
