namespace Diablo_Battle_Chest_Installer {
	#region Using Statements

	using Microsoft.Win32;
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.IO;
	using System.Linq;
	using System.Text;

	#endregion Using Statements

	public static class Global {
		public static class Diablo {
			public const string GAME_NAME = "Diablo";
			public const string MAIN_PATH = @"Diablo\";
			public const string CD_PATH = MAIN_PATH + @"Diablo.img";
			public const string PATCH_PATH = MAIN_PATH + @"Patches\";
			public const string EXTRA_PATH = MAIN_PATH + @"Extras\";

			public static string[] installLocationRegKeys = {
				@"HKEY_LOCAL_MACHINE\SOFTWARE\Blizzard Entertainment\Archives",
				@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Blizzard Entertainment\Archives",
				@"HKEY_CURRENT_USER\Software\Blizzard Entertainment\Archives",
				@"HKEY_CURRENT_USER\Software\Classes\VirtualStore\MACHINE\SOFTWARE\Blizzard Entertainment\Archives"
			};

			private static IDictionary<string, FileInfo> patchToVersionDictionary = new Dictionary<string, FileInfo>();
			private static IDictionary<string, DirectoryInfo> extraToDirectoryDictionary = new Dictionary<string, DirectoryInfo>();

			public static string DetectedInstallFolder {
				get;
				private set;
			}

			static Diablo() {
				Diablo.patchToVersionDictionary.Add("Patch 1.04", new FileInfo(Path.Combine(PATCH_PATH, "drtl104.exe")));
				Diablo.patchToVersionDictionary.Add("Patch 1.07", new FileInfo(Path.Combine(PATCH_PATH, "drtl107.exe")));
				Diablo.patchToVersionDictionary.Add("Patch 1.08", new FileInfo(Path.Combine(PATCH_PATH, "drtl108.exe")));
				Diablo.patchToVersionDictionary.Add("Patch 1.09", new FileInfo(Path.Combine(PATCH_PATH, "drtl109.exe")));
				Diablo.patchToVersionDictionary.Add("Patch 1.09b", new FileInfo(Path.Combine(PATCH_PATH, "drtl109b.exe")));

				Diablo.extraToDirectoryDictionary.Add("Animation Fix v1.1", new DirectoryInfo(Path.Combine(EXTRA_PATH, "AnimFix_Diablo&HF v1.1")));
				Diablo.extraToDirectoryDictionary.Add("DiabloPatch 2.0.1", new DirectoryInfo(Path.Combine(EXTRA_PATH, "DiabloPatch 2.0.1")));
				Diablo.extraToDirectoryDictionary.Add("DDraw.dll Fix", new DirectoryInfo(Path.Combine(EXTRA_PATH, "DDraw")));
				Diablo.extraToDirectoryDictionary.Add("DDraw Color Reg Fix", new DirectoryInfo(Path.Combine(EXTRA_PATH, "DDraw Color Reg Fix")));
				Diablo.extraToDirectoryDictionary.Add("IPX to UDP Wrapper 0.6.0", new DirectoryInfo(Path.Combine(EXTRA_PATH, "ipxwrapper-0.6.0")));

				WarnIfPatchRemains();
				WarnIfExtraRemains();
			}

			public static void InstallPatch(string versionName) {
				if (string.IsNullOrEmpty(versionName)) {
					return;
				}

				FileInfo patchPath = null;
				if (!Diablo.patchToVersionDictionary.TryGetValue(versionName, out patchPath)) {
					throw new ArgumentException("Patch number not recognized or found.");
				}
				Console.WriteLine("Patching game to {0}...", versionName);
				Process.Start(patchPath.FullName);
				Console.WriteLine("Patch succeeded!");
			}

			public static void InstallExtra(string extraName) {
				if (string.IsNullOrEmpty(extraName)) {
					return;
				}

				DirectoryInfo extraPath = null;
				if (!Diablo.extraToDirectoryDictionary.TryGetValue(extraName, out extraPath)) {
					throw new ArgumentException("Invalid extra or not handled!");
				}

				if (extraName.Equals("DDraw Color Reg Fix")) {
					if (Environment.Is64BitOperatingSystem) {
						Process.Start(extraPath + @"\d109_x64.reg");
					} else {
						Process.Start(extraPath + @"\d109_x32.reg");
					}
				} else {
					var installPath = GetInstallLocation();
					Console.WriteLine("Installing {0} to {1}", extraPath, installPath);
					CopyFilesToDirectory(extraPath.FullName, installPath);
				}
			}

			public static void WarnIfPatchRemains() {
				var directoryInfo = new DirectoryInfo(PATCH_PATH);
				var knownPatchesList = Diablo.patchToVersionDictionary.Values.ToList();

				foreach (var fileInfo in directoryInfo.GetFiles().Where(fileInfo => fileInfo.Extension.ToLower().Equals(".exe"))) {
					if (!knownPatchesList.Exists(patch => patch.FullName.Equals(fileInfo.FullName))) {
						Console.WriteLine("Warning: The patch at {0} is not found in the {1} patch dictionary.", fileInfo.FullName, GAME_NAME);
						//throw new NotImplementedException($"Unknown patch {fileInfo.Name}");
					}
				}
			}

			public static void WarnIfExtraRemains() {
				var extrasDirectoryInfo = new DirectoryInfo(EXTRA_PATH);
				var knownExtrasList = Diablo.extraToDirectoryDictionary.Values.ToList();

				foreach (var unverifiedExtra in extrasDirectoryInfo.GetDirectories()) {
					if (!knownExtrasList.Exists(knownExtra => knownExtra.FullName.Equals(unverifiedExtra.FullName))) {
						Console.WriteLine("Warning: The extras at {0} is not found in the {1} extras dictionary.", unverifiedExtra.FullName, GAME_NAME);
						//throw new NotImplementedException($"Unknown patch {fileInfo.Name}");
					}
				}
			}

			public static string GetInstallLocation() {
				if (DetectedInstallFolder != null && Directory.Exists(DetectedInstallFolder)) {
					return DetectedInstallFolder;
				}

				DetectedInstallFolder = Global.GetInstallLocation(installLocationRegKeys);
				return DetectedInstallFolder;
			}

			public static bool IsGameInstalled() {
				return GetInstallLocation() != null;
			}
		}

		public static void CopyFilesToDirectory(string fromDirectory, string toDirectory) {
			var filesInfo = new DirectoryInfo(fromDirectory);

			foreach (var file in filesInfo.GetFiles()) {
				var finalPath = Path.Combine(toDirectory, file.Name);
				file.CopyTo(finalPath, true);
			}
		}

		public static string GetInstallLocation(string[] installLocationRegKeys) {
			foreach (string location in installLocationRegKeys) {
				object value = Registry.GetValue(location, "DiabloInstall", null);
				if (value != null) {
					// Console.WriteLine("{0} found at: \"{1}\"", GAME_NAME, value.ToString());
					return value.ToString(); 
				}
			}

			return null;
		}
	}
}
