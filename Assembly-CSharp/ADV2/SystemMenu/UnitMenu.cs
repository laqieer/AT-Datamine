// Decompiled with JetBrains decompiler
// Type: ADV2.SystemMenu.UnitMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace ADV2.SystemMenu
{
  [Token(Token = "0x2003F09")]
  internal class UnitMenu : SystemMenuBase
  {
    [Token(Token = "0x401144E")]
    [FieldOffset(Offset = "0x18")]
    private string currentSceneName;

    [Token(Token = "0x601977E")]
    [Address(RVA = "0x37405E4", Offset = "0x37405E4", VA = "0x37405E4", Slot = "5")]
    protected override void OnExecute()
    {
    }

    [Token(Token = "0x601977F")]
    [Address(RVA = "0x37407E4", Offset = "0x37407E4", VA = "0x37407E4")]
    private void Callback(string sceneName)
    {
    }

    [Token(Token = "0x6019780")]
    [Address(RVA = "0x37402A4", Offset = "0x37402A4", VA = "0x37402A4")]
    public UnitMenu()
    {
    }
  }
}
