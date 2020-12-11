// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor.Modules;
using UnityEngine;

namespace UnityEditor {
internal class DesktopPluginImporterExtension : DefaultPluginImporterExtension {
  internal enum DesktopPluginCPUArchitecture { None, AnyCPU, x86, x86_64 }

  internal class DesktopSingleCPUProperty : Property {
    public DesktopSingleCPUProperty(GUIContent name, string platformName,
                                    DesktopPluginCPUArchitecture architecture)
        : base(name, "CPU", architecture, platformName) {}

    internal bool IsTargetEnabled(PluginImporterInspector inspector) {
      PluginImporterInspector.Compatibility compatibililty =
          inspector.GetPlatformCompatibility(platformName);
      if (compatibililty == PluginImporterInspector.Compatibility.Mixed)
        throw new Exception("Unexpected mixed value for '" +
                            inspector.importer.assetPath +
                            "', platform: " + platformName);
      if (compatibililty != PluginImporterInspector.Compatibility.Compatible)
        return false;

      var pluginCPU =
          value as DesktopPluginCPUArchitecture ? ?? DesktopPluginCPUArchitecture
              .None;
      return pluginCPU == (DesktopPluginCPUArchitecture) defaultValue ||
             pluginCPU == DesktopPluginCPUArchitecture.AnyCPU;
    }

    internal override void OnGUI(PluginImporterInspector inspector) {
      EditorGUILayout.BeginHorizontal();
      GUILayout.Space(10);
      EditorGUI.BeginChangeCheck();

      // This toggle controls two things:
      // * Is platform enabled/disabled?
      // * Platform CPU value
      bool isTargetEnabled =
          EditorGUILayout.Toggle(name, IsTargetEnabled(inspector));
      if (EditorGUI.EndChangeCheck()) {
        value =
            isTargetEnabled ? defaultValue : DesktopPluginCPUArchitecture.None;
        inspector.SetPlatformCompatibility(platformName, isTargetEnabled);
      }
      EditorGUILayout.EndHorizontal();
    }
  }

  private DesktopSingleCPUProperty m_WindowsX86;
  private DesktopSingleCPUProperty m_WindowsX86_X64;

  private DesktopSingleCPUProperty m_LinuxX86_X64;

  private DesktopSingleCPUProperty m_OSX_X64;

  public DesktopPluginImporterExtension() : base(null) {
    properties = GetProperties();
  }

  private Property[] GetProperties() {
    List<Property> properties = new List<Property>();
    m_WindowsX86 = new DesktopSingleCPUProperty(
        EditorGUIUtility.TrTextContent("x86"),
        BuildPipeline.GetBuildTargetName(BuildTarget.StandaloneWindows),
        DesktopPluginCPUArchitecture.x86);
    m_WindowsX86_X64 = new DesktopSingleCPUProperty(
        EditorGUIUtility.TrTextContent("x86_x64"),
        BuildPipeline.GetBuildTargetName(BuildTarget.StandaloneWindows64),
        DesktopPluginCPUArchitecture.x86_64);

    m_LinuxX86_X64 = new DesktopSingleCPUProperty(
        EditorGUIUtility.TrTextContent("x86_x64"),
        BuildPipeline.GetBuildTargetName(BuildTarget.StandaloneLinux64),
        DesktopPluginCPUArchitecture.x86_64);

    m_OSX_X64 = new DesktopSingleCPUProperty(
        EditorGUIUtility.TrTextContent("x64"),
        BuildPipeline.GetBuildTargetName(BuildTarget.StandaloneOSX),
        DesktopPluginCPUArchitecture.x86_64);

    properties.Add(m_WindowsX86);
    properties.Add(m_WindowsX86_X64);

    properties.Add(m_LinuxX86_X64);

    properties.Add(m_OSX_X64);

    return properties.ToArray();
  }

  private DesktopPluginCPUArchitecture CalculateMultiCPUArchitecture(bool x86,
                                                                     bool x64) {
    if (x86 && x64)
      return DesktopPluginCPUArchitecture.AnyCPU;
    if (x86)
      return DesktopPluginCPUArchitecture.x86;
    if (x64)
      return DesktopPluginCPUArchitecture.x86_64;
    return DesktopPluginCPUArchitecture.None;
  }

  private bool IsUsableOnWindows(PluginImporter imp) {
    if (!imp.isNativePlugin)
      return true;

    string ext = Path.GetExtension(imp.assetPath).ToLower();
    return ext == ".dll" || IsCppPluginFile(imp.assetPath);
  }

  private bool IsUsableOnOSX(PluginImporter imp) {
    if (!imp.isNativePlugin)
      return true;

    string ext = Path.GetExtension(imp.assetPath).ToLower();
    return ext == ".so" || ext == ".bundle" || ext == ".dylib" ||
           IsCppPluginFile(imp.assetPath);
  }

  private bool IsUsableOnLinux(PluginImporter imp) {
    if (!imp.isNativePlugin)
      return true;

    string ext = Path.GetExtension(imp.assetPath).ToLower();
    return ext == ".so" || IsCppPluginFile(imp.assetPath);
  }

  public override void
  OnPlatformSettingsGUI(PluginImporterInspector inspector) {
    PluginImporter imp = inspector.importer;
    EditorGUI.BeginChangeCheck();
    if (IsUsableOnWindows(imp)) {
      EditorGUILayout.LabelField(EditorGUIUtility.TrTextContent("Windows"),
                                 EditorStyles.boldLabel);
      m_WindowsX86.OnGUI(inspector);
      m_WindowsX86_X64.OnGUI(inspector);
      EditorGUILayout.Space();
    }

    if (IsUsableOnLinux(imp)) {
      EditorGUILayout.LabelField(EditorGUIUtility.TrTextContent("Linux"),
                                 EditorStyles.boldLabel);
      m_LinuxX86_X64.OnGUI(inspector);
      EditorGUILayout.Space();
    }

    if (IsUsableOnOSX(imp)) {
      EditorGUILayout.LabelField(EditorGUIUtility.TrTextContent("Mac OS X"),
                                 EditorStyles.boldLabel);
      m_OSX_X64.OnGUI(inspector);
    }

    if (EditorGUI.EndChangeCheck()) {
      ValidateUniversalTargets(inspector);
      hasModified = true;
    }
  }

  public void ValidateSingleCPUTargets(PluginImporterInspector inspector) {
    DesktopSingleCPUProperty[] singleCPUTargets =
        new[]{m_WindowsX86, m_WindowsX86_X64, m_LinuxX86_X64, m_OSX_X64};

    foreach (var target in singleCPUTargets) {
      target.value = target.IsTargetEnabled(inspector)
                         ? target.defaultValue
                         : DesktopPluginCPUArchitecture.None;

      foreach (var importer in inspector.importers) {
        importer.SetPlatformData(target.platformName, "CPU",
                                 target.value.ToString());
      }
    }

    ValidateUniversalTargets(inspector);
  }

  private void ValidateUniversalTargets(PluginImporterInspector inspector) {
    bool linuxX86_X64Enabled = m_LinuxX86_X64.IsTargetEnabled(inspector);

    DesktopPluginCPUArchitecture linuxUniversal =
        CalculateMultiCPUArchitecture(true, linuxX86_X64Enabled);
    foreach (var importer in inspector.importers)
      importer.SetPlatformData(BuildTarget.StandaloneLinux64, "CPU",
                               linuxUniversal.ToString());
    inspector.SetPlatformCompatibility(
        BuildPipeline.GetBuildTargetName(BuildTarget.StandaloneLinux64),
        linuxX86_X64Enabled);

    bool osxX64Enabled = m_OSX_X64.IsTargetEnabled(inspector);

    DesktopPluginCPUArchitecture osxUniversal =
        CalculateMultiCPUArchitecture(true, osxX64Enabled);
    foreach (var importer in inspector.importers)
      importer.SetPlatformData(BuildTarget.StandaloneOSX, "CPU",
                               osxUniversal.ToString());
    inspector.SetPlatformCompatibility(
        BuildPipeline.GetBuildTargetName(BuildTarget.StandaloneOSX),
        osxX64Enabled);
  }

  public override string CalculateFinalPluginPath(string platformName,
                                                  PluginImporter imp) {
    BuildTarget target = BuildPipeline.GetBuildTargetByName(platformName);
    bool pluginForWindows = target == BuildTarget.StandaloneWindows ||
                            target == BuildTarget.StandaloneWindows64;
#pragma warning disable 612, 618
    bool pluginForOSX = target == BuildTarget.StandaloneOSXIntel ||
                        target == BuildTarget.StandaloneOSXIntel64 ||
                        target == BuildTarget.StandaloneOSX;
    bool pluginForLinux = target == BuildTarget.StandaloneLinux ||
                          target == BuildTarget.StandaloneLinux64 ||
                          target == BuildTarget.StandaloneLinuxUniversal;
#pragma warning restore 612, 618

    if (!pluginForLinux && !pluginForOSX && !pluginForWindows)
      throw new Exception(string.Format(
          "Failed to resolve standalone platform, platform string '{0}', resolved target '{1}'",
          platformName, target.ToString()));

    if (pluginForWindows && !IsUsableOnWindows(imp))
      return string.Empty;
    if (pluginForOSX && !IsUsableOnOSX(imp))
      return string.Empty;
    if (pluginForLinux && !IsUsableOnLinux(imp))
      return string.Empty;

    string cpu = imp.GetPlatformData(platformName, "CPU");

    if (string.Compare(cpu, "None", true) == 0)
      return string.Empty;

    if (pluginForWindows) {
      // Fix case 1185926: plugins for x86_64 are supposed to be copied to
      // Plugins/x86_64 Plugins for x86 are supposed to be copied to Plugins/x86
      var cpuName = target == BuildTarget.StandaloneWindows ? nameof(
                                  DesktopPluginCPUArchitecture.x86)
          : nameof(DesktopPluginCPUArchitecture.x86_64);
      return Path.Combine(cpuName, Path.GetFileName(imp.assetPath));
    }

    // For files this will return filename, for directories, this will return
    // last path component
    return Path.GetFileName(imp.assetPath);
  }

  internal static bool IsCppPluginFile(string assetPath) {
    var extension = Path.GetExtension(assetPath).ToLower();
    return extension == ".cpp" || extension == ".c" || extension == ".h" ||
           extension == ".mm" || extension == ".m";
  }
}
}
