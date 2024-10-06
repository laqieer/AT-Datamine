// Decompiled with JetBrains decompiler
// Type: TeamOrganization.AccessoryStatusViewBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x200078D")]
  public abstract class AccessoryStatusViewBase : MonoBehaviour
  {
    [Token(Token = "0x40022D4")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Color NomalTextColor;
    [Token(Token = "0x40022D5")]
    [FieldOffset(Offset = "0x10")]
    public static readonly Color DownTextColor;
    [Token(Token = "0x40022D6")]
    [FieldOffset(Offset = "0x20")]
    public static readonly Color UpTextColor;

    [Token(Token = "0x6002A58")]
    public abstract void ResetEquipParameter();

    [Token(Token = "0x6002A59")]
    public abstract void UpdateEquipParameter(Accessory accessory, Style selectStyle);

    [Token(Token = "0x6002A5A")]
    public abstract void UpdateEquipParameter(
      Accessory baseAccessory,
      Accessory selectAccessory,
      Style selectStyle);

    [Token(Token = "0x6002A5B")]
    [Address(RVA = "0x3501820", Offset = "0x3501820", VA = "0x3501820")]
    public static Color GetParameterColor(int baseValue, int selectValue) => new Color();

    [Token(Token = "0x6002A5C")]
    [Address(RVA = "0x35018E0", Offset = "0x35018E0", VA = "0x35018E0")]
    protected AccessoryStatusViewBase()
    {
    }

    [Token(Token = "0x6002A5D")]
    [Address(RVA = "0x35018E8", Offset = "0x35018E8", VA = "0x35018E8")]
    static AccessoryStatusViewBase()
    {
    }
  }
}
