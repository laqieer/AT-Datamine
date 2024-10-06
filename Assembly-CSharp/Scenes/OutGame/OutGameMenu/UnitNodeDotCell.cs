// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.UnitNodeDotCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AFF")]
  public class UnitNodeDotCell : MonoBehaviour
  {
    [Token(Token = "0x4010421")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image sihousetteImage;
    [Token(Token = "0x4010422")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform dotObjParent;
    [Token(Token = "0x4010423")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject attentionObj;
    [Token(Token = "0x4010424")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ElementIconView elementIcon;
    [Token(Token = "0x4010425")]
    [FieldOffset(Offset = "0x38")]
    private GameObject dotAnimObject;
    [Token(Token = "0x4010426")]
    [FieldOffset(Offset = "0x40")]
    private Animator dotAnimator;
    [Token(Token = "0x4010427")]
    [FieldOffset(Offset = "0x48")]
    private int styleId;

    [Token(Token = "0x6017373")]
    [Address(RVA = "0x30131F0", Offset = "0x30131F0", VA = "0x30131F0")]
    public void InitCell(int styleId, bool dotInitSkip = false)
    {
    }

    [Token(Token = "0x6017374")]
    [Address(RVA = "0x301C9B0", Offset = "0x301C9B0", VA = "0x301C9B0")]
    public bool ExistsChangedAsset(int styleId) => new bool();

    [Token(Token = "0x6017375")]
    [Address(RVA = "0x3013448", Offset = "0x3013448", VA = "0x3013448")]
    public void SetAttentionIcon(bool isAttention)
    {
    }

    [Token(Token = "0x6017376")]
    [Address(RVA = "0x301C9CC", Offset = "0x301C9CC", VA = "0x301C9CC")]
    private IEnumerator LoadDotAnimObject(int styleId) => (IEnumerator) null;

    [Token(Token = "0x6017377")]
    [Address(RVA = "0x301C898", Offset = "0x301C898", VA = "0x301C898")]
    private void DestroyDotAnimObject()
    {
    }

    [Token(Token = "0x6017378")]
    [Address(RVA = "0x301CA44", Offset = "0x301CA44", VA = "0x301CA44")]
    private void ShowDotAnimObject()
    {
    }

    [Token(Token = "0x6017379")]
    [Address(RVA = "0x301CACC", Offset = "0x301CACC", VA = "0x301CACC")]
    private void SetDotPosition()
    {
    }

    [Token(Token = "0x601737A")]
    [Address(RVA = "0x301C928", Offset = "0x301C928", VA = "0x301C928")]
    private void HideDotAnimObject()
    {
    }

    [Token(Token = "0x601737B")]
    [Address(RVA = "0x301CBE4", Offset = "0x301CBE4", VA = "0x301CBE4")]
    public UnitNodeDotCell()
    {
    }
  }
}
