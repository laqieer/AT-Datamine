// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2PlayableDirectorBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E4B")]
  public abstract class Adv2PlayableDirectorBase : MonoBehaviour
  {
    [Token(Token = "0x6019188")]
    public abstract void SetActive(bool isActive);

    [Token(Token = "0x6019189")]
    public abstract bool IsActive();

    [Token(Token = "0x601918A")]
    [Address(RVA = "0x29749E0", Offset = "0x29749E0", VA = "0x29749E0", Slot = "6")]
    public virtual void SetBindObject(GameObject prefab)
    {
    }

    [Token(Token = "0x601918B")]
    [Address(RVA = "0x2974A78", Offset = "0x2974A78", VA = "0x2974A78")]
    private static GameObject CreateObject(string objectName, GameObject parent, bool isUI)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x601918C")]
    protected static T CreateDirector<T>(string objectName, GameObject parent, bool isUI) where T : Adv2PlayableDirectorBase
    {
      return (T) null;
    }

    [Token(Token = "0x601918D")]
    [Address(RVA = "0x2974B48", Offset = "0x2974B48", VA = "0x2974B48")]
    protected Adv2PlayableDirectorBase()
    {
    }
  }
}
