// Decompiled with JetBrains decompiler
// Type: Story.Facility.FacilityInfoPopupHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Story.Facility
{
  [Token(Token = "0x20006AB")]
  public class FacilityInfoPopupHandler
  {
    [Token(Token = "0x4001FEF")]
    [FieldOffset(Offset = "0x10")]
    private FacilityInfoPopup popup;
    [Token(Token = "0x4001FF0")]
    [FieldOffset(Offset = "0x18")]
    private FacilityInfoLoader loader;
    [Token(Token = "0x4001FF1")]
    [FieldOffset(Offset = "0x20")]
    private FacilityInfoAnimation animation;
    [Token(Token = "0x4001FF2")]
    [FieldOffset(Offset = "0x28")]
    public Action OnClickFastTravelAction;
    [Token(Token = "0x4001FF3")]
    [FieldOffset(Offset = "0x30")]
    public Action OnCloseAction;

    [Token(Token = "0x1700058F")]
    public bool IsOpening
    {
      [Token(Token = "0x60025D5"), Address(RVA = "0x2F3E89C", Offset = "0x2F3E89C", VA = "0x2F3E89C")] get
      {
        return new bool();
      }
      [Token(Token = "0x60025D6"), Address(RVA = "0x2F3E8A4", Offset = "0x2F3E8A4", VA = "0x2F3E8A4")] private set
      {
      }
    }

    [Token(Token = "0x60025D7")]
    [Address(RVA = "0x2F3E8B0", Offset = "0x2F3E8B0", VA = "0x2F3E8B0")]
    public void SetActive(bool active)
    {
    }

    [Token(Token = "0x60025D8")]
    [Address(RVA = "0x2F3E944", Offset = "0x2F3E944", VA = "0x2F3E944")]
    public FacilityInfoPopupHandler()
    {
    }

    [Token(Token = "0x60025D9")]
    [Address(RVA = "0x2F3E9D8", Offset = "0x2F3E9D8", VA = "0x2F3E9D8")]
    public IEnumerator Show(int facilityId) => (IEnumerator) null;

    [Token(Token = "0x60025DA")]
    [Address(RVA = "0x2F3EA78", Offset = "0x2F3EA78", VA = "0x2F3EA78")]
    public void Clear()
    {
    }
  }
}
