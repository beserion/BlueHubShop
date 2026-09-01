@echo off
echo ===================================================
echo     BlueHubShop Projesi Baslatiliyor...
echo ===================================================

echo [1/2] Backend API (dotnet) calistiriliyor...
start "BlueHubShop Backend (API)" cmd /k "cd src\BlueHubShop.Backend\Presentation\BlueHubShop.API && dotnet run"

echo [2/2] Frontend (Next.js) calistiriliyor...
start "BlueHubShop Frontend (UI)" cmd /k "cd src\BlueHubShop.Frontend && npm run dev"

echo ===================================================
echo Hizmetler baslatiliyor! Acilan yeni siyah pencereleri 
echo kapatmadiginiz surece proje calismaya devam edecektir.
echo ===================================================
pause
