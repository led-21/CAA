# 🎨 Design System

## 🧭 Visão Geral do Design Profissional

O aplicativo CAA para Luiza foi redesenhado com um **sistema de design profissional e moderno**, mantendo a acessibilidade e adequação para crianças com TEA.

---

## 🎨 Paleta de Cores

### 🎯 Cores Primárias

```
Primary: #6366F1 (Índigo vibrante)
Primary Dark: #4F46E5
Primary Light: #818CF8
```

### 🟪 Cores de Categorias

```
🛒 Pedidos: #EF4444 (Vermelho) - Urgência e necessidade
💬 Socialização: #14B8A6 (Turquesa) - Interação e amizade
📘 Informação: #F59E0B (Âmbar) - Conhecimento e expressão
⏰ Rotina: #10B981 (Verde) - Consistência e segurança
```

### ⚪ Cores Neutras (Escala de Cinza)

```
Gray 50: #F9FAFB (Background)
Gray 100: #F3F4F6 (Surface Variant)
Gray 200: #E5E7EB (Borders)
Gray 300: #D1D5DB
Gray 400: #9CA3AF
Gray 500: #6B7280 (Text Secondary)
Gray 600: #4B5563
Gray 700: #374151
Gray 800: #1F2937
Gray 900: #111827 (Text Primary)
```

### 🚦 Cores Semânticas

```
✅ Success: #10B981
⚠️ Warning: #F59E0B
❌ Error: #EF4444
ℹ️ Info: #3B82F6
```

---

## ✍️ Sistema de Tipografia

### 📏 Hierarquia de Texto

#### 📰 Display

* **Display Large**: 32px, Bold - Para títulos principais
* **Display Medium**: 28px, Bold - Para títulos de seção

#### 🧩 Headline

* **Headline Large**: 24px, Bold - Para cabeçalhos importantes
* **Headline Medium**: 20px, Bold - Para cabeçalhos de cards

#### 🏷️ Title

* **Title Large**: 18px, Bold - Para títulos de componentes
* **Title Medium**: 16px, Bold - Para subtítulos

#### 📖 Body

* **Body Large**: 16px, Regular - Para texto principal
* **Body Medium**: 14px, Regular - Para texto secundário
* **Body Small**: 12px, Regular - Para legendas

#### 🪪 Label

* **Label Large**: 14px, Bold - Para labels de formulários
* **Label Medium**: 12px, Bold - Para labels de botões

---

## 🧱 Componentes de Design

### 🧩 Cards

#### 📦 Card Padrão

```
- Background: Branco (#FFFFFF)
- Border: Gray 200 (#E5E7EB)
- Border Radius: 16px
- Shadow: Sim (sutil)
- Padding: 16px
```

#### 🪄 Card Elevado

```
- Background: Branco (#FFFFFF)
- Border: Transparente
- Border Radius: 16px
- Shadow: Sim (mais pronunciada)
- Padding: 16px
```

#### 🖼️ Pictogram Card

```
- Background: Cor da categoria com 15% de opacidade
- Border: Cor da categoria
- Border Radius: 12px
- Padding: 12px
- Height: 100px (fixo)
- Shadow: Sim
```

### 🔘 Botões

#### 🟣 Button Primary

```
- Background: Primary (#6366F1)
- Text: Branco
- Font Size: 16px, Bold
- Border Radius: 12px
- Padding: 24px horizontal, 12px vertical
- Height: 56px
```

#### ⚪ Button Secondary

```
- Background: Gray 100
- Text: Text Primary
- Font Size: 16px, Bold
- Border Radius: 12px
- Height: 56px
```

#### ✅ Button Success

```
- Background: Success (#10B981)
- Text: Branco
- Font Size: 16px, Bold
- Border Radius: 12px
- Height: 56px
```

### ✏️ Entries (Campos de Entrada)

```
- Background: Branco
- Text Color: Text Primary
- Placeholder: Text Tertiary
- Font Size: 16px
- Height: 56px
- Border Radius: 12px
```

---

## 📐 Layout e Espaçamento

### 📏 Sistema de Espaçamento (múltiplos de 4px)

```
4px  - Muito pequeno (espaçamento mínimo)
8px  - Pequeno (entre elementos relacionados)
12px - Médio (espaçamento padrão)
16px - Grande (padding de containers)
20px - Extra grande (separação de seções)
24px - Muito grande (margens externas)
```

### 🧩 Grid System

* **Pictogramas**: 4 colunas em tablets/landscape
* **Spacing**: 12px entre pictogramas
* **Padding**: 16px nas laterais

---

## 🧠 Princípios de Design para TEA

### 1. **Clareza Visual**

* 🔆 Alto contraste entre texto e fundo
* 🧩 Ícones grandes e reconhecíveis (28–36px)
* 🪶 Espaçamento generoso entre elementos
* 🚫 Sem gradientes complexos ou texturas

### 2. **Consistência**

* 🎨 Cores consistentes por categoria
* 🔁 Mesmo estilo de botão para mesma ação
* 🖼️ Pictogramas sempre no mesmo formato
* 🧭 Navegação previsível

### 3. **Redução de Sobrecarga Cognitiva**

* 🎯 Uma ação por botão
* 🧩 Hierarquia visual clara
* 📚 Informações agrupadas logicamente
* 💡 Feedback visual imediato

### 4. **Acessibilidade**

* 🖐️ Área de toque mínima: 44x44px
* 🏷️ Labels descritivos
* ♿ Suporte a SemanticProperties
* 🌈 Cores com contraste WCAG AA

---

## 🧩 Componentes Específicos

### 🧭 Header (Cabeçalho)

```xaml
<StackLayout Style="{StaticResource HeaderStyle}">
 - Background: Primary
 - Padding: 20px
 - Spacing: 8px
</StackLayout>
```

### 💬 Message Composition Area

```
- Frame elevado com sombra
- Background interno: Gray 50
- Altura mínima: 50px
- Placeholder em itálico quando vazio
```

### 🗂️ Category Card

```
- Card elevado
- Ícone em círculo colorido (56x56px)
- Nome da categoria em Headline Medium
- Contador de pictogramas em Body Small
- Grid de pictogramas 4 colunas
```

### 🖼️ Selected Pictogram

```
- Card de 90px de largura
- Background: Cor com 20% de opacidade
- Border: Cor sólida da categoria
- Símbolo: 32px
- Texto: Label Medium
- Tappable para remover
```

---

## 🧭 Estados de Interação

### 🟢 Normal

* Cor padrão do componente

### 🖱️ Hover (Desktop/Web)

* Ligeiro escurecimento da cor de fundo
* Elevação da sombra

### 🔘 Pressed

* Escurecimento mais pronunciado
* Redução da elevação

### 🚫 Disabled

* Opacidade 50%
* Cor de texto Gray 400

### 🔲 Selected

* Border mais espessa
* Background com cor de destaque

---

## 📊 Métricas de UX

### 🖐️ Áreas de Toque

```
Mínimo: 44x44px (WCAG)
Recomendado para TEA: 56x56px ou maior
Pictogramas: 100x100px
```

### ⚡ Tempo de Resposta

```
Feedback visual: Imediato (<100ms)
Animações: Sutis (200–300ms)
Transições: Suaves (300ms)
```

### 🧮 Densidade de Informação

```
Máximo 4 pictogramas por linha
Máximo 8 pictogramas visíveis por categoria sem scroll
Espaçamento generoso (12px+)
```

---

## 🚀 Melhorias Implementadas

### 🎨 Interface Redesenhada

* Cards com elevação e sombras profissionais
* Hierarquia visual clara com tipografia escalável
* Espaçamento consistente e respirável
* Cores semânticas e categóricas

### 🧱 Componentes Modernos

* Frames com border radius suaves (12–16px)
* Botões com altura adequada (56px)
* Ícones de categoria em círculos coloridos
* Empty states ilustrados

### 💡 Feedback Visual

* Estados de interação claros
* Separadores sutis entre seções
* Sombras para criar profundidade
* Cores de destaque para ações importantes

### ♿ Acessibilidade Melhorada

* Alto contraste em todos os elementos
* Áreas de toque generosas
* Labels descritivos
* Suporte a leitores de tela

---

## 📘 Guia de Uso do Design System

### ➕ Para Adicionar Nova Categoria

```xaml
<Frame Style="{StaticResource CardElevated}">
    <Frame BackgroundColor="[COR]20" BorderColor="[COR]">
      <!-- Conteúdo -->
    </Frame>
</Frame>
```

### 🔘 Para Criar Novo Botão

```xaml
<Button Text="Ação" 
        Command="{Binding Command}"
        Style="{StaticResource ButtonPrimary}"/>
```

### 🧩 Para Adicionar Novo Card

```xaml
<Frame Style="{StaticResource Card}">
    <!-- Conteúdo -->
</Frame>
```

---

## 📱 Responsividade

### 🔢 Breakpoints

```
Small (Phone): < 600px
Medium (Tablet): 600px – 900px
Large (Desktop): > 900px
```

### ⚙️ Adaptações

* **Phone**: 3–4 colunas de pictogramas
* **Tablet**: 4–6 colunas de pictogramas
* **Desktop**: 6–8 colunas de pictogramas

---

## 🌈 Inspiração de Design

O design system foi inspirado em:

* **Material Design 3** (Google) – Hierarquia e componentes
* **Apple Human Interface Guidelines** – Clareza e acessibilidade
* **Autism Accessibility Guidelines** – Princípios para TEA
* **WCAG 2.1** – Padrões de acessibilidade

---

## 🏁 Notas Finais

Este design system garante:

* 🎨 **Consistência** em toda a aplicação
* ⚙️ **Escalabilidade** para futuras funcionalidades
* ♿ **Acessibilidade** para crianças com TEA
* 💼 **Profissionalismo** visual
* 🧩 **Manutenibilidade** do código

**Desenvolvido com ❤️ e atenção aos detalhes para Luiza**
