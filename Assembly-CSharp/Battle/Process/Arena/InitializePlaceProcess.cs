// Decompiled with JetBrains decompiler
// Type: Battle.Process.Arena.InitializePlaceProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Battle.Process.Arena
{
  [Token(Token = "0x20026BF")]
  public sealed class InitializePlaceProcess : InitializeProcess
  {
    [Token(Token = "0x170032AE")]
    private ArenaPlaceConfig config
    {
      [Token(Token = "0x600EFE1"), Address(RVA = "0x40DF5FC", Offset = "0x40DF5FC", VA = "0x40DF5FC")] get
      {
        return (ArenaPlaceConfig) null;
      }
    }

    [Token(Token = "0x600EFE2")]
    [Address(RVA = "0x40DF680", Offset = "0x40DF680", VA = "0x40DF680", Slot = "23")]
    protected override void CreatePlayers()
    {
    }

    [Token(Token = "0x600EFE3")]
    [Address(RVA = "0x40DF9B8", Offset = "0x40DF9B8", VA = "0x40DF9B8", Slot = "21")]
    protected override void CreateUnitView()
    {
    }

    [Token(Token = "0x600EFE4")]
    [Address(RVA = "0x40DFE78", Offset = "0x40DFE78", VA = "0x40DFE78", Slot = "22")]
    protected override IEnumerator InitializeUI() => (IEnumerator) null;

    [Token(Token = "0x600EFE5")]
    [Address(RVA = "0x40DF414", Offset = "0x40DF414", VA = "0x40DF414")]
    public InitializePlaceProcess()
    {
    }
  }
}
