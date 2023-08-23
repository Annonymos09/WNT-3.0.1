@echo off
setlocal

REM Festlegen der Priorit�t des Skripts auf "Hoch"
wmic process where name="cmd.exe" CALL setpriority "high priority"

REM Deaktivieren von visuellen Effekten
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects" /v VisualFXSetting /t REG_DWORD /d 2 /f
echo Visuelle Effekte wurden deaktiviert.

REM Festlegen der Energieeinstellungen auf "Hochleistung"
powercfg /setactive 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c
echo Energieeinstellungen wurden auf "Hochleistung" festgelegt.

REM Deaktivieren von Hintergrundprogrammen beim Start
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Serialize" /v StartupDelayInMSec /t REG_DWORD /d 0 /f
echo Hintergrundprogramme beim Start wurden deaktiviert.

REM L�schen von tempor�ren Dateien
del /s /q "%TEMP%\*.*"
echo Tempor�re Dateien wurden gel�scht.

REM Defragmentieren der Festplatte (optional)
defrag C: /U /V
echo Die Festplatte wurde defragmentiert.

REM Leeren des Seitenaustauschdatei (optional)
wmic pagefileset delete
echo Die Seitenaustauschdatei wurde geleert.

echo Optimierung abgeschlossen. Bitte starten Sie den Computer neu, um die �nderungen zu �bernehmen.

endlocal