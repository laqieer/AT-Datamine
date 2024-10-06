// Decompiled with JetBrains decompiler
// Type: staq.SaveData.ArmouryGridSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003CF5")]
  public class ArmouryGridSaveData
  {
    [Token(Token = "0x4010C63")]
    [FieldOffset(Offset = "0x10")]
    public bool IsStyle;
    [Token(Token = "0x4010C64")]
    [FieldOffset(Offset = "0x11")]
    public bool IsMindEquipment;

    [Token(Token = "0x1700500D")]
    private static string Path
    {
      [Token(Token = "0x60187ED"), Address(RVA = "0x2939308", Offset = "0x2939308", VA = "0x2939308")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60187EE")]
    [Address(RVA = "0x2939358", Offset = "0x2939358", VA = "0x2939358")]
    public string GetPath() => (string) null;

    [Token(Token = "0x60187EF")]
    [Address(RVA = "0x29393A0", Offset = "0x29393A0", VA = "0x29393A0")]
    public bool IsExist() => new bool();

    [Token(Token = "0x60187F0")]
    [Address(RVA = "0x29393B4", Offset = "0x29393B4", VA = "0x29393B4")]
    public void Load()
    {
    }

    [Token(Token = "0x60187F1")]
    [Address(RVA = "0x2939538", Offset = "0x2939538", VA = "0x2939538")]
    public void Save()
    {
    }

    [Token(Token = "0x60187F2")]
    [Address(RVA = "0x2939600", Offset = "0x2939600", VA = "0x2939600")]
    public void ChangeStyle()
    {
    }

    [Token(Token = "0x60187F3")]
    [Address(RVA = "0x2939610", Offset = "0x2939610", VA = "0x2939610")]
    public void ChangeMindEquipment()
    {
    }

    [Token(Token = "0x60187F4")]
    [Address(RVA = "0x2939620", Offset = "0x2939620", VA = "0x2939620")]
    public ArmouryGridSaveData()
    {
    }
  }
}
