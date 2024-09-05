// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.RewardItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000C0D")]
  public class RewardItem : MonoBehaviour
  {
    [Token(Token = "0x40036B8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x40036B9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI itemName;
    [Token(Token = "0x40036BA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject firstTimeObject;

    [Token(Token = "0x6004509")]
    [Address(RVA = "0x364E5F0", Offset = "0x364E5F0", VA = "0x364E5F0")]
    public void Initialize(Sprite itemIcon, int itemNum, string itemName, bool isFirstTime)
    {
    }

    [Token(Token = "0x600450A")]
    [Address(RVA = "0x364E6E8", Offset = "0x364E6E8", VA = "0x364E6E8")]
    public RewardItem()
    {
    }
  }
}
