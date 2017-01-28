@echo off

mystem.exe -ig --format json --weight input.txt output.txt

chcp 65001
echo.
type output.txt
echo.
echo.
pause