# ?? Aplicativo CAA - Luiza Lopes Guimarães Godoy

## ?? Comunicação Aumentativa e Alternativa (CAA) para MAUI

Aplicativo especializado em comunicação aumentativa e alternativa desenvolvido em **.NET MAUI** para atender as necessidades específicas de Luiza, uma criança de 6 anos e 10 meses com Transtorno do Espectro Autista (TEA) e Transtorno de Linguagem.

---

## ?? Perfil da Criança

**Nome:** Luiza Lopes Guimarães Godoy  
**Idade:** 6 anos e 10 meses  
**Diagnóstico:** TEA + Transtorno de Linguagem ? Necessidades Complexas de Comunicação (NCC)

### Habilidades
- ? Gosta de desenhar
- ? Conhece letras
- ? Canta músicas inteiras
- ? Boa coordenação motora

### Dificuldades
- ? Fala inicial precoce, mas atualmente não funcional
- ? Ecolalias frequentes
- ? Seletividade alimentar
- ? Esquivas em tarefas de linguagem
- ? Dependência de celular
- ? Fala parcialmente compreensível para desconhecidos

### Nível de Comunicação Atual
- **Nível Principal:** Nível 4 – Comunicação Convencional (gestos, olhar, vocalizações específicas)
- **Níveis Emergentes:** Nível 7 – Linguagem (frases curtas, pedidos, nomeações)
- **Funções mais usadas:** Pedir objetos/ações, ecolalias, scripts
- **Funções pouco exploradas:** Socialização e troca de informações

---

## ?? Funcionalidades

### 1. **4 Categorias de Comunicação**

#### ?? **Pedidos** (Vermelho)
Para pedir objetos e ações:
- Água ??
- Comida ??
- Brincar ??
- Desenhar ???
- Música ??
- Descansar ??
- Ajuda ??
- Banheiro ??

#### ?? **Socialização** (Turquesa)
Para interações sociais:
- Olá ??
- Tchau ??
- Obrigada ??
- Por favor ??
- Legal! ??
- Não gosto ??

#### ?? **Informação** (Amarelo)
Para expressar sentimentos e opiniões:
- Sim ?
- Não ?
- Gosto ??
- Cansada ??
- Feliz ??
- Triste ??
- Dói ??
- Medo ??

#### ?? **Rotina** (Verde)
Para atividades do dia a dia:
- Manhã ??
- Tarde ??
- Noite ??
- Escola ??
- Casa ??
- Banho ??
- Dormir ???

### 2. **Interface Amigável para TEA**
- ? Pictogramas grandes e coloridos (4 colunas)
- ? Cores vibrantes e diferenciadas por categoria
- ? Botões com alta taxa de contraste
- ? Sem elementos piscantes ou confusos
- ? Navegação simples com 2 abas principais

### 3. **Síntese de Fala (Text-to-Speech)**
- ?? Botão "Falar" com voz em português
- ?? Frases pré-gravadas personalizadas para cada pictograma
- ? Ativação fácil com um toque

### 4. **Histórico de Comunicação**
- ?? Registra todas as comunicações
- ?? Marca hora de cada mensagem
- ?? Visualização em abas separadas

### 5. **Seleção de Pictogramas**
- ?? Adicionar/remover pictogramas da sequência
- ?? Visualização da frase formada em tempo real
- ??? Botão para limpar toda a sequência

---

## ??? Stack Técnico

- **Framework:** .NET MAUI 10
- **Linguagem:** C# 14.0
- **Padrão de Arquitetura:** MVVM (Model-View-ViewModel)
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
?   ??? TextToSpeechService.cs      # Síntese de fala
?   ??? CommunicationDataService.cs   # Dados de comunicação
??? ViewModels/
?   ??? CommunicationViewModel.cs     # ViewModel principal
?   ??? HistoryViewModel.cs           # ViewModel de histórico
??? Views/
?   ??? CommunicationPage.xaml        # Interface de comunicação
?   ??? CommunicationPage.xaml.cs
?   ??? HistoryPage.xaml              # Interface de histórico
?   ??? HistoryPage.xaml.cs
??? Resources/
?   ??? Styles/
?       ??? LuizaStyles.xaml          # Estilos personalizados
??? MauiProgram.cs        # Configuração DI
??? AppShell.xaml       # Navegação
??? App.xaml            # Aplicação
```

---

## ?? Design & Acessibilidade

### Para Crianças com TEA
- ? **Cores Vibrantes:** Cada categoria tem cor diferente e consistente
- ? **Interfaces Claras:** Sem elementos confusos ou animações piscantes
- ? **Pictogramas Grandes:** Fáceis de identificar e tocar
- ? **Feedback Imediato:** Som ao selecionar, visualização da frase
- ? **Redução Cognitiva:** Categorias claras e lógicas
- ? **Fonte Grande:** Letras claras e legíveis

### Cores por Categoria
| Categoria | Cor | Hex |
|-----------|-----|-----|
| Pedidos | Vermelho | #FF6B6B |
| Socialização | Turquesa | #4ECDC4 |
| Informação | Amarelo | #FFE66D |
| Rotina | Verde | #95E1D3 |

---

## ?? Como Usar

### Instalação

```bash
# Clonar ou abrir a solução MAUI
cd CAA

# Restaurar dependências
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
- Toque em um pictograma para adicioná-lo à sequência
- A frase é formada automaticamente

### 2. **Ouvir a Frase**
- Toque em "?? Falar" para ouvir a frase em voz alta
- A voz é em português brasileiro

### 3. **Limpar**
- Toque em "??? Limpar" para remover todos os pictogramas
- Ou toque novamente em um pictograma para removê-lo

### 4. **Ver Histórico**
- Acesse a aba "?? Histórico"
- Veja todas as comunicações registradas com horário

---

## ?? Extensões Futuras

- [ ] Banco de dados local para histórico persistente
- [ ] Criação de frases customizadas por terapeuta
- [ ] Modo offline completo
- [ ] Suporte a múltiplos perfis de crianças
- [ ] Integração com Google Cloud Text-to-Speech para vozes mais naturais
- [ ] Relatórios de uso para terapeutas
- [ ] Reconhecimento de fala para comandos por voz
- [ ] Sincronização com nuvem

---

## ?? Notas Importantes

### Para Terapeutas e Cuidadores
1. **Personalize conforme necessário:** As categorias e pictogramas podem ser ajustados
2. **Reforce o uso:** Estimule o uso regular do app nas atividades diárias
3. **Observe padrões:** O histórico ajuda a entender as preferências
4. **Combine com terapia:** Use como ferramenta complementar à terapia fonoaudiológica
5. **Acompanhe o progresso:** Monitore avanços na comunicação

### Considerações Especiais para Luiza
- ? Reforce o uso através de atividades que ela gosta (desenho, música)
- ? Mantenha a rotina consistente ao usar o app
- ? Combine com gestos e olhares para melhorar compreensão
- ? Use como forma de reduzir esquivas em comunicação
- ? Adapte se notar saturação ou falta de interesse

---

## ?? Troubleshooting

### Som não funciona
- Verifique se o volume do dispositivo está ativo
- Certifique-se de que a localidade é "pt-BR"
- Reinicie o app

### Interface com lag
- Redja números de pictogramas por categoria
- Limpe o histórico periodicamente
- Reinicie o dispositivo

### App cai
- Atualize para a versão mais recente do MAUI
- Verifique compatibilidade do SO

---

## ?? Suporte

Para problemas ou sugestões, contacte o desenvolvedor ou o terapeuta responsável.

---

**Desenvolvido com ?? para Luiza e crianças com necessidades complexas de comunicação**

*Última atualização: 2024*
