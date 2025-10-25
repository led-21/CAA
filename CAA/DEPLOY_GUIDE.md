# ?? Guia de Deploy - App CAA Luiza

## ?? Preparação para Produção

Este guia fornece instruções passo a passo para compilar e distribuir o aplicativo CAA para diferentes plataformas.

---

## ?? Pré-requisitos

### Ferramentas Necessárias
```
? Visual Studio 2022 (v17.8+) com workload .NET MAUI
? .NET 10 SDK instalado
? Android SDK (para Android)
? Xcode 15+ (para iOS/macOS - apenas em macOS)
? Windows SDK 10.0.19041.0+ (para Windows)
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

## ?? Deploy para Android

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
# Navegar para o diretório do projeto
cd CAA

# Compilar APK
dotnet publish -f net10.0-android -c Release

# APK será gerado em:
# bin/Release/net10.0-android/publish/
```

### 3. Gerar AAB para Google Play Store

```bash
# Compilar AAB (Android App Bundle)
dotnet publish -f net10.0-android -c Release /p:AndroidPackageFormat=aab

# AAB será gerado em:
# bin/Release/net10.0-android/publish/
```

### 4. Assinar o Aplicativo

```bash
# Criar keystore (apenas primeira vez)
keytool -genkey -v -keystore caa-luiza.keystore -alias caa_key -keyalg RSA -keysize 2048 -validity 10000

# Assinar AAB
jarsigner -verbose -sigalg SHA256withRSA -digestalg SHA-256 -keystore caa-luiza.keystore bin/Release/net10.0-android/publish/com.companyname.caa.aab caa_key

# Verificar assinatura
jarsigner -verify -verbose -certs bin/Release/net10.0-android/publish/com.companyname.caa.aab
```

### 5. Upload para Google Play Console
1. Acesse [Google Play Console](https://play.google.com/console)
2. Criar novo app
3. Upload do AAB assinado
4. Preencher informações da store
5. Configurar classificação de conteúdo
6. Publicar

---

## ?? Deploy para iOS

### 1. Configuração no Xcode

```bash
# Abrir projeto no Xcode (apenas macOS)
open Platforms/iOS/CAA.iOS.csproj
```

### 2. Configurar Certificados

1. Abrir **Xcode** ? **Preferences** ? **Accounts**
2. Adicionar Apple ID
3. Gerenciar certificados
4. Criar **App ID** no [Apple Developer Portal](https://developer.apple.com)

### 3. Info.plist Configuração

Editar `Platforms/iOS/Info.plist`:
```xml
<key>CFBundleDisplayName</key>
<string>CAA Luiza</string>
<key>CFBundleIdentifier</key>
<string>com.companyname.caa</string>
<key>CFBundleVersion</key>
<string>1.0</string>
<key>NSMicrophoneUsageDescription</key>
<string>Necessario para sintese de fala</string>
```

### 4. Compilar IPA

```bash
# Compilar para iOS
dotnet publish -f net10.0-ios -c Release /p:ArchiveOnBuild=true

# IPA será gerado em:
# bin/Release/net10.0-ios/ios-arm64/publish/
```

### 5. Upload para App Store Connect

```bash
# Usar Transporter app ou comando:
xcrun altool --upload-app -f "caminho/para/app.ipa" -u "seu_apple_id" -p "senha_app_especifica"
```

---

## ?? Deploy para Windows

### 1. Configuração do Pacote

Editar `Platforms/Windows/Package.appxmanifest`:
```xml
<Identity Name="CAALuiza" 
        Publisher="CN=YourCompany" 
    Version="1.0.0.0" />
<Properties>
  <DisplayName>CAA Luiza</DisplayName>
  <PublisherDisplayName>Your Company</PublisherDisplayName>
</Properties>
```

### 2. Compilar MSIX

```bash
# Compilar para Windows
dotnet publish -f net10.0-windows10.0.19041.0 -c Release -p:RuntimeIdentifierOverride=win10-x64

# MSIX será gerado em:
# bin/Release/net10.0-windows10.0.19041.0/win10-x64/publish/
```

### 3. Assinar MSIX

```bash
# Criar certificado (apenas primeira vez)
New-SelfSignedCertificate -Type CodeSigningCert -Subject "CN=YourCompany" -KeyUsage DigitalSignature -FriendlyName "CAA Certificate"

# Assinar MSIX
signtool sign /fd SHA256 /a /f "certificado.pfx" /p "senha" "caminho/para/app.msix"
```

### 4. Distribuição

**Opções:**
1. **Microsoft Store** - Upload via Partner Center
2. **Sideload** - Instalar diretamente em dispositivos
3. **Intune** - Distribuição corporativa

---

## ?? Deploy para macOS (Mac Catalyst)

### 1. Compilar para Mac Catalyst

```bash
# Compilar para macOS
dotnet publish -f net10.0-maccatalyst -c Release

# App será gerado em:
# bin/Release/net10.0-maccatalyst/maccatalyst-arm64/publish/
```

### 2. Notarização (para distribuição fora da App Store)

```bash
# Assinar app
codesign --force --deep --sign "Developer ID Application: Your Name" "CAA.app"

# Notarizar
xcrun notarytool submit "CAA.app.zip" --apple-id "seu_email" --password "senha_app_especifica" --team-id "TEAM_ID"

# Staple
xcrun stapler staple "CAA.app"
```

---

## ?? Configurações Importantes

### 1. Versão do App

Editar `CAA.csproj`:
```xml
<PropertyGroup>
  <ApplicationDisplayVersion>1.0</ApplicationDisplayVersion>
  <ApplicationVersion>1</ApplicationVersion>
</PropertyGroup>
```

### 2. Ícones e Splash Screen

Substituir arquivos em:
```
Resources/AppIcon/appicon.svg
Resources/Splash/splash.svg
```

### 3. Permissões

Garantir que as permissões estão configuradas:
- **Android**: AndroidManifest.xml
- **iOS**: Info.plist
- **Windows**: Package.appxmanifest

---

## ?? Checklist de Pré-Deploy

### Código
- [ ] Todos os testes passam
- [ ] Sem warnings de compilação
- [ ] Sem código Debug em produção
- [ ] Logging configurado corretamente

### Assets
- [ ] Ícone do app em todas as resoluções
- [ ] Splash screen configurada
- [ ] Imagens otimizadas
- [ ] Fontes incluídas

### Configuração
- [ ] ApplicationId único configurado
- [ ] Versão incrementada
- [ ] Permissões declaradas
- [ ] Certificados válidos

### Store
- [ ] Screenshots preparados
- [ ] Descrição traduzida
- [ ] Política de privacidade
- [ ] Termos de uso

---

## ?? Segurança

### Proteção de Código
```bash
# Habilitar ofuscação (opcional)
dotnet publish -c Release /p:EnableObfuscation=true
```

### Remover Dados Sensíveis
```csharp
// Remover logs de debug em produção
#if !DEBUG
builder.Logging.ClearProviders();
#endif
```

---

## ?? Monitoramento

### App Center (Recomendado)
```csharp
// Adicionar em MauiProgram.cs
Microsoft.AppCenter.AppCenter.Start(
    "android={key};ios={key}",
  typeof(Analytics), typeof(Crashes));
```

### Telemetria
- Implementar Application Insights
- Configurar crash reporting
- Monitorar performance

---

## ?? Troubleshooting

### Erro: "APK não assinado"
```bash
# Verificar assinatura
jarsigner -verify -verbose app.apk
```

### Erro: "Certificado expirado" (iOS)
```bash
# Renovar certificado no Apple Developer Portal
# Atualizar provisioning profiles
```

### Erro: "MSIX não instala" (Windows)
```bash
# Verificar certificado confiável
# Habilitar Developer Mode no Windows
```

---

## ?? Recursos Adicionais

### Documentação Oficial
- [.NET MAUI Deploy Docs](https://learn.microsoft.com/dotnet/maui/deployment/)
- [Android Publishing Guide](https://developer.android.com/studio/publish)
- [iOS App Distribution](https://developer.apple.com/documentation/xcode/distributing-your-app-for-beta-testing-and-releases)
- [Windows MSIX Packaging](https://learn.microsoft.com/windows/msix/)

### Ferramentas
- [Fastlane](https://fastlane.tools/) - Automação de deploy
- [App Center](https://appcenter.ms/) - CI/CD e monitoramento
- [GitHub Actions](https://github.com/features/actions) - CI/CD

---

## ?? Deploy Automatizado (CI/CD)

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

## ? Conclusão

Seguindo este guia, você conseguirá:
- ? Compilar o app para todas as plataformas
- ? Assinar e configurar corretamente
- ? Publicar nas stores
- ? Monitorar e manter o app

**Boa sorte com o deploy! ??**

---

**Desenvolvido com ?? para Luiza**  
*Janeiro 2025*
