# 🚀 Guia de Deploy

## 🧩 Preparação para Produção

Este guia fornece instruções passo a passo para compilar e distribuir o aplicativo CAA para diferentes plataformas.

---

## ⚙️ Pré-requisitos

### Ferramentas Necessárias

```
🧰 Visual Studio 2022 (v17.8+) com workload .NET MAUI  
🧱 .NET 10 SDK instalado  
📱 Android SDK (para Android)  
🍎 Xcode 15+ (para iOS/macOS - apenas em macOS)  
🪟 Windows SDK 10.0.19041.0+ (para Windows)
```

### Verificar Instalação

```bash
# Verificar .NET SDK
dotnet --version

# Verificar workloads MAUI
dotnet workload list

# Instalar workload MAUI se necessário
dotnet workload install maui
```

---

## 🤖 Deploy para Android

### 1. Configuração do Projeto

#### AndroidManifest.xml

Editar `Platforms/Android/AndroidManifest.xml`:

```xml
<?xml version="1.0" encoding="utf-8"?>
<manifest xmlns:android="http://schemas.android.com/apk/res/android">
  <application 
      android:allowBackup="true" 
      android:icon="@mipmap/appicon" 
      android:label="CAA Luiza"
      android:theme="@style/Maui.SplashTheme" 
      android:supportsRtl="true">
  </application>
  <uses-permission android:name="android.permission.INTERNET" />
  <uses-permission android:name="android.permission.RECORD_AUDIO" />
</manifest>
```

### 2. Compilar APK de Release

```bash
cd CAA
dotnet publish -f net10.0-android -c Release
```

📦 **APK gerado em:**
`bin/Release/net10.0-android/publish/`

### 3. Gerar AAB para Google Play Store

```bash
dotnet publish -f net10.0-android -c Release /p:AndroidPackageFormat=aab
```

📦 **AAB gerado em:**
`bin/Release/net10.0-android/publish/`

### 4. Assinar o Aplicativo

```bash
keytool -genkey -v -keystore caa-luiza.keystore -alias caa_key -keyalg RSA -keysize 2048 -validity 10000
jarsigner -verbose -sigalg SHA256withRSA -digestalg SHA-256 -keystore caa-luiza.keystore bin/Release/net10.0-android/publish/com.companyname.caa.aab caa_key
jarsigner -verify -verbose -certs bin/Release/net10.0-android/publish/com.companyname.caa.aab
```

### 5. Upload para Google Play Console

1. Acesse [Google Play Console](https://play.google.com/console)
2. Crie o app
3. Faça upload do **AAB** assinado
4. Preencha informações
5. Configure classificação
6. Publique 🚀

---

## 🍏 Deploy para iOS

### 1. Configuração no Xcode

```bash
open Platforms/iOS/CAA.iOS.csproj
```

### 2. Configurar Certificados

1. **Xcode → Preferences → Accounts**
2. Adicionar Apple ID
3. Criar **App ID** no [Apple Developer Portal](https://developer.apple.com)

### 3. Info.plist

```xml
<key>CFBundleDisplayName</key>
<string>CAA Luiza</string>
<key>CFBundleIdentifier</key>
<string>com.companyname.caa</string>
<key>CFBundleVersion</key>
<string>1.0</string>
<key>NSMicrophoneUsageDescription</key>
<string>Necessário para síntese de fala</string>
```

### 4. Compilar IPA

```bash
dotnet publish -f net10.0-ios -c Release /p:ArchiveOnBuild=true
```

📦 **IPA gerado em:**
`bin/Release/net10.0-ios/ios-arm64/publish/`

### 5. Upload para App Store Connect

```bash
xcrun altool --upload-app -f "app.ipa" -u "apple_id" -p "senha_app_especifica"
```

---

## 🪟 Deploy para Windows

### 1. Configuração do Pacote

```xml
<Identity Name="CAALuiza" Publisher="CN=YourCompany" Version="1.0.0.0" />
<Properties>
  <DisplayName>CAA Luiza</DisplayName>
  <PublisherDisplayName>Your Company</PublisherDisplayName>
</Properties>
```

### 2. Compilar MSIX

```bash
dotnet publish -f net10.0-windows10.0.19041.0 -c Release -p:RuntimeIdentifierOverride=win10-x64
```

📦 **MSIX gerado em:**
`bin/Release/net10.0-windows10.0.19041.0/win10-x64/publish/`

### 3. Assinar MSIX

```bash
New-SelfSignedCertificate -Type CodeSigningCert -Subject "CN=YourCompany"
signtool sign /fd SHA256 /a /f "certificado.pfx" /p "senha" "app.msix"
```

### 4. Distribuição

* 🏪 Microsoft Store
* 💻 Sideload
* 🏢 Intune (corporativo)

---

## 🍎 Deploy para macOS (Mac Catalyst)

### 1. Compilar

```bash
dotnet publish -f net10.0-maccatalyst -c Release
```

📦 **App gerado em:**
`bin/Release/net10.0-maccatalyst/maccatalyst-arm64/publish/`

### 2. Notarização (fora da App Store)

```bash
codesign --force --deep --sign "Developer ID Application: Your Name" "CAA.app"
xcrun notarytool submit "CAA.app.zip" --apple-id "email" --password "senha_app_especifica" --team-id "TEAM_ID"
xcrun stapler staple "CAA.app"
```

---

## ⚙️ Configurações Importantes

### Versão do App

```xml
<PropertyGroup>
  <ApplicationDisplayVersion>1.0</ApplicationDisplayVersion>
  <ApplicationVersion>1</ApplicationVersion>
</PropertyGroup>
```

### Ícones e Splash

```
Resources/AppIcon/appicon.svg
Resources/Splash/splash.svg
```

### Permissões

* Android → `AndroidManifest.xml`
* iOS → `Info.plist`
* Windows → `Package.appxmanifest`

---

## ✅ Checklist de Pré-Deploy

### Código

* [ ] Testes passam
* [ ] Sem warnings
* [ ] Sem código Debug
* [ ] Logging configurado

### Assets

* [ ] Ícones em todas resoluções
* [ ] Splash configurada
* [ ] Imagens otimizadas
* [ ] Fontes incluídas

### Configuração

* [ ] ApplicationId único
* [ ] Versão incrementada
* [ ] Permissões declaradas
* [ ] Certificados válidos

### Store

* [ ] Screenshots
* [ ] Descrição traduzida
* [ ] Política de privacidade
* [ ] Termos de uso

---

## 🔒 Segurança

### Proteção de Código

```bash
dotnet publish -c Release /p:EnableObfuscation=true
```

### Remover Dados Sensíveis

```csharp
#if !DEBUG
builder.Logging.ClearProviders();
#endif
```

---

## 📊 Monitoramento

### App Center (Recomendado)

```csharp
Microsoft.AppCenter.AppCenter.Start(
    "android={key};ios={key}",
    typeof(Analytics), typeof(Crashes));
```

### Telemetria

* Application Insights
* Crash Reporting
* Performance Monitor

---

## 🧯 Troubleshooting

### Erro: “APK não assinado”

```bash
jarsigner -verify -verbose app.apk
```

### Erro: “Certificado expirado” (iOS)

> Renove no [Apple Developer Portal](https://developer.apple.com)

### Erro: “MSIX não instala”

> Verifique certificado e habilite Developer Mode no Windows

---

## 📚 Recursos Adicionais

* [.NET MAUI Deploy Docs](https://learn.microsoft.com/dotnet/maui/deployment/)
* [Android Publishing Guide](https://developer.android.com/studio/publish)
* [iOS App Distribution](https://developer.apple.com/documentation/xcode/distributing-your-app-for-beta-testing-and-releases)
* [Windows MSIX Packaging](https://learn.microsoft.com/windows/msix/)

**Ferramentas úteis:**

* ⚡ [Fastlane](https://fastlane.tools/)
* 🧠 [App Center](https://appcenter.ms/)
* 🤖 [GitHub Actions](https://github.com/features/actions)

---

## 🔁 Deploy Automatizado (CI/CD)

### GitHub Actions Exemplo

```yaml
name: Build and Deploy

on:
  push:
    branches: [ main ]

jobs:
  build-android:
    runs-on: windows-latest
    steps:
      - uses: actions/checkout@v2
      - name: Setup .NET
        uses: actions/setup-dotnet@v1
        with:
          dotnet-version: '10.0.x'
      - name: Build Android
        run: dotnet publish -f net10.0-android -c Release
      - name: Upload APK
        uses: actions/upload-artifact@v2
        with:
          name: android-apk
          path: bin/Release/net10.0-android/publish/*.apk
```

---

## 🎯 Conclusão

Seguindo este guia, você conseguirá:

* 🧱 Compilar o app para todas as plataformas
* 🔐 Assinar e configurar corretamente
* 🚀 Publicar nas stores
* 📈 Monitorar e manter o app

**Boa sorte com o deploy! 💪**

---

**Desenvolvido com ❤️ para Luiza**
*Janeiro 2025*
