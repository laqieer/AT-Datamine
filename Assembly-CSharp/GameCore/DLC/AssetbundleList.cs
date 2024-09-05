// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.AssetbundleList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x2001481")]
  [Serializable]
  public class AssetbundleList : List<string>, ISerializationCallbackReceiver
  {
    [Token(Token = "0x4005E36")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<string> list;

    [Token(Token = "0x6007362")]
    [Address(RVA = "0x40583A0", Offset = "0x40583A0", VA = "0x40583A0", Slot = "35")]
    public void OnBeforeSerialize()
    {
    }

    [Token(Token = "0x6007363")]
    [Address(RVA = "0x4058450", Offset = "0x4058450", VA = "0x4058450", Slot = "36")]
    public void OnAfterDeserialize()
    {
    }

    [Token(Token = "0x6007364")]
    [Address(RVA = "0x40584F8", Offset = "0x40584F8", VA = "0x40584F8")]
    public AssetbundleList()
    {
    }
  }
}
