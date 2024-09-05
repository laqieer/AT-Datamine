// Decompiled with JetBrains decompiler
// Type: Battle.MapDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle
{
  [Token(Token = "0x200227A")]
  public sealed class MapDirector : MapDirectorBase, ISubDirector<MainDirector>, IStepUpdate
  {
    [Token(Token = "0x4009153")]
    [FieldOffset(Offset = "0xA8")]
    private Transform mapRoot;

    [Token(Token = "0x17002D98")]
    public bool Initialized
    {
      [Token(Token = "0x600D1F9"), Address(RVA = "0x195CFC8", Offset = "0x195CFC8", VA = "0x195CFC8", Slot = "12")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D1FA"), Address(RVA = "0x195CFD0", Offset = "0x195CFD0", VA = "0x195CFD0")] private set
      {
      }
    }

    [Token(Token = "0x600D1FB")]
    [Address(RVA = "0x195855C", Offset = "0x195855C", VA = "0x195855C", Slot = "13")]
    public void Initialize(MainDirector mainDirector)
    {
    }

    [Token(Token = "0x600D1FC")]
    [Address(RVA = "0x195D064", Offset = "0x195D064", VA = "0x195D064", Slot = "14")]
    public void Abort()
    {
    }

    [Token(Token = "0x600D1FD")]
    [Address(RVA = "0x19586C4", Offset = "0x19586C4", VA = "0x19586C4", Slot = "15")]
    public void Release()
    {
    }

    [Token(Token = "0x600D1FE")]
    [Address(RVA = "0x1958924", Offset = "0x1958924", VA = "0x1958924", Slot = "16")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600D1FF")]
    [Address(RVA = "0x195D068", Offset = "0x195D068", VA = "0x195D068")]
    public MapDirector()
    {
    }
  }
}
