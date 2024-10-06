// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.SlotUnlockEffectPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C8B")]
  public class SlotUnlockEffectPopup : MonoBehaviour
  {
    [Token(Token = "0x400BDF5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400BDF6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image SlotNumber;
    [Token(Token = "0x400BDF7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton bgButton;
    [Token(Token = "0x400BDF8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton nextButton;
    [Token(Token = "0x400BDF9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject styleIcon;
    [Token(Token = "0x400BDFA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject lockIcon;
    [Token(Token = "0x400BDFC")]
    [FieldOffset(Offset = "0x4C")]
    private float animFlameTime;

    [Token(Token = "0x17003C0A")]
    private bool IsAnimFinish
    {
      [Token(Token = "0x60116D5"), Address(RVA = "0x4E24390", Offset = "0x4E24390", VA = "0x4E24390")] get
      {
        return new bool();
      }
      [Token(Token = "0x60116D6"), Address(RVA = "0x4E24398", Offset = "0x4E24398", VA = "0x4E24398")] set
      {
      }
    }

    [Token(Token = "0x60116D7")]
    [Address(RVA = "0x4E243A4", Offset = "0x4E243A4", VA = "0x4E243A4")]
    public void SetData(int slotIndex)
    {
    }

    [Token(Token = "0x60116D8")]
    [Address(RVA = "0x4E24614", Offset = "0x4E24614", VA = "0x4E24614")]
    public void Open()
    {
    }

    [Token(Token = "0x60116D9")]
    [Address(RVA = "0x4E247A8", Offset = "0x4E247A8", VA = "0x4E247A8")]
    public void Close()
    {
    }

    [Token(Token = "0x60116DA")]
    [Address(RVA = "0x4E248F4", Offset = "0x4E248F4", VA = "0x4E248F4")]
    private IEnumerator UpdateAnimTime() => (IEnumerator) null;

    [Token(Token = "0x60116DB")]
    [Address(RVA = "0x4E244C0", Offset = "0x4E244C0", VA = "0x4E244C0")]
    private void UpdateUnitNumber(int slotIndex)
    {
    }

    [Token(Token = "0x60116DC")]
    [Address(RVA = "0x4E24984", Offset = "0x4E24984", VA = "0x4E24984")]
    public void OnClick()
    {
    }

    [Token(Token = "0x60116DD")]
    [Address(RVA = "0x4E249E8", Offset = "0x4E249E8", VA = "0x4E249E8")]
    public SlotUnlockEffectPopup()
    {
    }
  }
}
