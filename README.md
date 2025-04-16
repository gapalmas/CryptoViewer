# 💸 CryptoViewer

Aplicación de escritorio WPF desarrollada en .NET 8 para mostrar en tiempo real el valor de Bitcoin, Ethereum y Stellar utilizando la API de CoinGecko.

---

## 🖼️ Características

- Interfaz amigable en WPF
- Arquitectura basada en MVVM
- Actualización automática cada minuto
- Muestra precio en USD y MXN
- Cambio porcentual en las últimas 24h
- Análisis de estilo con StyleCop
- Automatización de validaciones con GitHub Actions

---


## 🧱 Estructura del Proyecto

```
CryptoViewer/
├── CryptoViewer.csproj
├── App.xaml
├── MainWindow.xaml
├── Models/
│   └── CryptoCurrency.cs
├── ViewModels/
│   └── MainViewModel.cs
├── Services/
│   └── CryptoService.cs
├── Resources/
│   └── Brushes.xaml
├── stylecop.json
└── .github/
    └── workflows/
        └── dotnet-stylecop.yml
```

---

## ⚙️ Requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- Visual Studio Code (o cualquier editor compatible con WPF)
- Windows 10/11

---

## 🛠️ Instalación y Ejecución

1. Clona el repositorio:

```bash
git clone https://github.com/gapalmas/CryptoViewer.git
cd CryptoViewer
```

2. Restaura paquetes y ejecuta:

```bash
dotnet restore
dotnet build
dotnet run
```

---

## 🔁 Actualización Automática

La información se actualiza cada 60 segundos usando un `DispatcherTimer` en el `MainViewModel`.

---

## 🧪 Análisis de Estilo

Usamos StyleCop.Analyzers para validar buenas prácticas de código. Puedes ejecutar manualmente:

```bash
dotnet build --no-restore -warnaserror
```

Y también está automatizado en GitHub Actions (`.github/workflows/stylecop.yml`).

---

## 📦 Compilar para Producción

```bash
dotnet publish -c Release -r win-x64 --self-contained
```

---

## 🧾 Licencia

MIT 
