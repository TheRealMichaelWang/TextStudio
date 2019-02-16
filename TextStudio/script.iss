; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "TextStudio"
#define MyAppVersion "1.0"
#define MyAppPublisher "Michael Wang"
#define MyAppURL "https://github.com/TheRealMichaelWang"
#define MyAppExeName "TextStudio.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{72361EB0-D4C9-4112-AB97-966EC5065CD2}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableDirPage=yes
DisableProgramGroupPage=yes
LicenseFile=C:\Users\Michael Wang\Documents\Visual Studio 2017\Projects\TextStudio\license.txt
OutputDir=C:\Users\Michael Wang\Documents\Visual Studio 2017\Projects\TextStudio
OutputBaseFilename=TextStudioSetup
SetupIconFile=C:\Users\Michael Wang\Documents\Visual Studio 2017\Projects\TextStudio\icon.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "C:\Users\Michael Wang\Documents\Visual Studio 2017\Projects\TextStudio\TextStudio\bin\Debug\TextStudio.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Michael Wang\Documents\Visual Studio 2017\Projects\TextStudio\TextStudio\bin\Debug\english.dic"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Michael Wang\Documents\Visual Studio 2017\Projects\TextStudio\TextStudio\bin\Debug\Updater.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Michael Wang\Documents\Visual Studio 2017\Projects\TextStudio\icon.ico"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}";
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent