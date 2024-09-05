// Decompiled with JetBrains decompiler
// Type: ADV2.SystemMenu.ShopMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace ADV2.SystemMenu
{
  [Token(Token = "0x2003F08")]
  internal class ShopMenu : SystemMenuBase
  {
    [Token(Token = "0x401144D")]
    [FieldOffset(Offset = "0x18")]
    private string currentSceneName;

    [Token(Token = "0x601977B")]
    [Address(RVA = "0x37402E0", Offset = "0x37402E0", VA = "0x37402E0", Slot = "5")]
    protected override void OnExecute()
    {
    }

    [Token(Token = "0x601977C")]
    [Address(RVA = "0x37404A8", Offset = "0x37404A8", VA = "0x37404A8")]
    private void Callback(string sceneName)
    {
    }

    [Token(Token = "0x601977D")]
    [Address(RVA = "0x374029C", Offset = "0x374029C", VA = "0x374029C")]
    public ShopMenu()
    {
    }
  }
}
