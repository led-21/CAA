# ?? Aplicativo CAA - Luiza Lopes Guimar�es Godoy

## ?? Comunica��o Aumentativa e Alternativa (CAA) para MAUI

Aplicativo especializado em comunica��o aumentativa e alternativa desenvolvido em **.NET MAUI** para atender as necessidades espec�ficas de Luiza, uma crian�a de 6 anos e 10 meses com Transtorno do Espectro Autista (TEA) e Transtorno de Linguagem.

---

## ?? Perfil da Crian�a

**Nome:** Luiza Lopes Guimar�es Godoy  
**Idade:** 6 anos e 10 meses  
**Diagn�stico:** TEA + Transtorno de Linguagem ? Necessidades Complexas de Comunica��o (NCC)

### Habilidades
- ? Gosta de desenhar
- ? Conhece letras
- ? Canta m�sicas inteiras
- ? Boa coordena��o motora

### Dificuldades
- ? Fala inicial precoce, mas atualmente n�o funcional
- ? Ecolalias frequentes
- ? Seletividade alimentar
- ? Esquivas em tarefas de linguagem
- ? Depend�ncia de celular
- ? Fala parcialmente compreens�vel para desconhecidos

### N�vel de Comunica��o Atual
- **N�vel Principal:** N�vel 4 � Comunica��o Convencional (gestos, olhar, vocaliza��es espec�ficas)
- **N�veis Emergentes:** N�vel 7 � Linguagem (frases curtas, pedidos, nomea��es)
- **Fun��es mais usadas:** Pedir objetos/a��es, ecolalias, scripts
- **Fun��es pouco exploradas:** Socializa��o e troca de informa��es

---

## ?? Funcionalidades

### 1. **4 Categorias de Comunica��o**

#### ?? **Pedidos** (Vermelho)
Para pedir objetos e a��es:
- �gua ??
- Comida ??
- Brincar ??
- Desenhar ???
- M�sica ??
- Descansar ??
- Ajuda ??
- Banheiro ??

#### ?? **Socializa��o** (Turquesa)
Para intera��es sociais:
- Ol� ??
- Tchau ??
- Obrigada ??
- Por favor ??
- Legal! ??
- N�o gosto ??

#### ?? **Informa��o** (Amarelo)
Para expressar sentimentos e opini�es:
- Sim ?
- N�o ?
- Gosto ??
- Cansada ??
- Feliz ??
- Triste ??
- D�i ??
- Medo ??

#### ?? **Rotina** (Verde)
Para atividades do dia a dia:
- Manh� ??
- Tarde ??
- Noite ??
- Escola ??
- Casa ??
- Banho ??
- Dormir ???

### 2. **Interface Amig�vel para TEA**
- ? Pictogramas grandes e coloridos (4 colunas)
- ? Cores vibrantes e diferenciadas por categoria
- ? Bot�es com alta taxa de contraste
- ? Sem elementos piscantes ou confusos
- ? Navega��o simples com 2 abas principais

### 3. **S�ntese de Fala (Text-to-Speech)**
- ?? Bot�o "Falar" com voz em portugu�s
- ?? Frases pr�-gravadas personalizadas para cada pictograma
- ? Ativa��o f�cil com um toque

### 4. **Hist�rico de Comunica��o**
- ?? Registra todas as comunica��es
- ?? Marca hora de cada mensagem
- ?? Visualiza��o em abas separadas

### 5. **Sele��o de Pictogramas**
- ?? Adicionar/remover pictogramas da sequ�ncia
- ?? Visualiza��o da frase formada em tempo real
- ??? Bot�o para limpar toda a sequ�ncia

---

## ??? Stack T�cnico

- **Framework:** .NET MAUI 10
- **Linguagem:** C# 14.0
- **Padr�o de Arquitetura:** MVVM (Model-View-ViewModel)
- **State Management:** MVVM Toolkit
- **Text-to-Speech:** Microsoft.Maui.Controls (nativo)
- **Plataformas:** Android, iOS, macOS, Windows

---

## ?? Estrutura do Projeto

```
CAA/
??? Models/
?   ??? PictogramCategory.cs          # Modelos de dados
??? Services/
?   ??? TextToSpeechService.cs      # S�ntese de fala
?   ??? CommunicationDataService.cs   # Dados de comunica��o
??? ViewModels/
?   ??? CommunicationViewModel.cs     # ViewModel principal
?   ??? HistoryViewModel.cs           # ViewModel de hist�rico
??? Views/
?   ??? CommunicationPage.xaml        # Interface de comunica��o
?   ??? CommunicationPage.xaml.cs
?   ??? HistoryPage.xaml              # Interface de hist�rico
?   ??? HistoryPage.xaml.cs
??? Resources/
?   ??? Styles/
?       ??? LuizaStyles.xaml          # Estilos personalizados
??? MauiProgram.cs        # Configura��o DI
??? AppShell.xaml       # Navega��o
??? App.xaml            # Aplica��o
```

---

## ?? Design & Acessibilidade

### Para Crian�as com TEA
- ? **Cores Vibrantes:** Cada categoria tem cor diferente e consistente
- ? **Interfaces Claras:** Sem elementos confusos ou anima��es piscantes
- ? **Pictogramas Grandes:** F�ceis de identificar e tocar
- ? **Feedback Imediato:** Som ao selecionar, visualiza��o da frase
- ? **Redu��o Cognitiva:** Categorias claras e l�gicas
- ? **Fonte Grande:** Letras claras e leg�veis

### Cores por Categoria
| Categoria | Cor | Hex |
|-----------|-----|-----|
| Pedidos | Vermelho | #FF6B6B |
| Socializa��o | Turquesa | #4ECDC4 |
| Informa��o | Amarelo | #FFE66D |
| Rotina | Verde | #95E1D3 |

---

## ?? Como Usar

### Instala��o

```bash
# Clonar ou abrir a solu��o MAUI
cd CAA

# Restaurar depend�ncias
dotnet restore

# Compilar o projeto
dotnet build
```

### Executar

```bash
# Para Android
dotnet build -f net10.0-android -c Release

# Para iOS
dotnet build -f net10.0-ios -c Release

# Para Windows
dotnet build -f net10.0-windows10.0.19041.0 -c Release

# Para macOS (Mac Catalyst)
dotnet build -f net10.0-maccatalyst -c Release
```

---

## ?? Como Funciona

### 1. **Selecionar Pictogramas**
- Toque em um pictograma para adicion�-lo � sequ�ncia
- A frase � formada automaticamente

### 2. **Ouvir a Frase**
- Toque em "?? Falar" para ouvir a frase em voz alta
- A voz � em portugu�s brasileiro

### 3. **Limpar**
- Toque em "??? Limpar" para remover todos os pictogramas
- Ou toque novamente em um pictograma para remov�-lo

### 4. **Ver Hist�rico**
- Acesse a aba "?? Hist�rico"
- Veja todas as comunica��es registradas com hor�rio

---

## ?? Extens�es Futuras

- [ ] Banco de dados local para hist�rico persistente
- [ ] Cria��o de frases customizadas por terapeuta
- [ ] Modo offline completo
- [ ] Suporte a m�ltiplos perfis de crian�as
- [ ] Integra��o com Google Cloud Text-to-Speech para vozes mais naturais
- [ ] Relat�rios de uso para terapeutas
- [ ] Reconhecimento de fala para comandos por voz
- [ ] Sincroniza��o com nuvem

---

## ?? Notas Importantes

### Para Terapeutas e Cuidadores
1. **Personalize conforme necess�rio:** As categorias e pictogramas podem ser ajustados
2. **Reforce o uso:** Estimule o uso regular do app nas atividades di�rias
3. **Observe padr�es:** O hist�rico ajuda a entender as prefer�ncias
4. **Combine com terapia:** Use como ferramenta complementar � terapia fonoaudiol�gica
5. **Acompanhe o progresso:** Monitore avan�os na comunica��o

### Considera��es Especiais para Luiza
- ? Reforce o uso atrav�s de atividades que ela gosta (desenho, m�sica)
- ? Mantenha a rotina consistente ao usar o app
- ? Combine com gestos e olhares para melhorar compreens�o
- ? Use como forma de reduzir esquivas em comunica��o
- ? Adapte se notar satura��o ou falta de interesse

---

## ?? Troubleshooting

### Som n�o funciona
- Verifique se o volume do dispositivo est� ativo
- Certifique-se de que a localidade � "pt-BR"
- Reinicie o app

### Interface com lag
- Redja n�meros de pictogramas por categoria
- Limpe o hist�rico periodicamente
- Reinicie o dispositivo

### App cai
- Atualize para a vers�o mais recente do MAUI
- Verifique compatibilidade do SO

---

## ?? Suporte

Para problemas ou sugest�es, contacte o desenvolvedor ou o terapeuta respons�vel.

---

**Desenvolvido com ?? para Luiza e crian�as com necessidades complexas de comunica��o**

*�ltima atualiza��o: 2024*
