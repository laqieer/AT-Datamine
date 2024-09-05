// Decompiled with JetBrains decompiler
// Type: ADV2.SystemMenu.SystemMenuBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace ADV2.SystemMenu
{
  [Token(Token = "0x2003F07")]
  internal abstract class SystemMenuBase : Adv2Manager.OnProccessSignal
  {
    [Token(Token = "0x6019778")]
    [Address(RVA = "0x37402AC", Offset = "0x37402AC", VA = "0x37402AC")]
    public void Execute()
    {
    }

    [Token(Token = "0x6019779")]
    protected abstract void OnExecute();

    [Token(Token = "0x601977A")]
    [Address(RVA = "0x37402D8", Offset = "0x37402D8", VA = "0x37402D8")]
    protected SystemMenuBase()
    {
    }
  }
}
