// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;
using System.Reflection;

namespace UnityEditor {
internal interface IMonoCecilHelper {
  IFileOpenInfo TryGetCecilFileOpenInfo(Type type, MethodInfo methodInfo);
}
}
