# ?? Design System - App CAA Luiza

## Vis�o Geral do Design Profissional

O aplicativo CAA para Luiza foi redesenhado com um **sistema de design profissional e moderno**, mantendo a acessibilidade e adequa��o para crian�as com TEA.

---

## ?? Paleta de Cores

### Cores Prim�rias
```
Primary: #6366F1 (�ndigo vibrante)
Primary Dark: #4F46E5
Primary Light: #818CF8
```

### Cores de Categorias
```
?? Pedidos: #EF4444 (Vermelho) - Urg�ncia e necessidade
?? Socializa��o: #14B8A6 (Turquesa) - Intera��o e amizade
?? Informa��o: #F59E0B (�mbar) - Conhecimento e express�o
?? Rotina: #10B981 (Verde) - Consist�ncia e seguran�a
```

### Cores Neutras (Escala de Cinza)
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

### Cores Sem�nticas
```
? Success: #10B981
?? Warning: #F59E0B
? Error: #EF4444
?? Info: #3B82F6
```

---

## ?? Sistema de Tipografia

### Hierarquia de Texto

#### Display
- **Display Large**: 32px, Bold - Para t�tulos principais
- **Display Medium**: 28px, Bold - Para t�tulos de se��o

#### Headline
- **Headline Large**: 24px, Bold - Para cabe�alhos importantes
- **Headline Medium**: 20px, Bold - Para cabe�alhos de cards

#### Title
- **Title Large**: 18px, Bold - Para t�tulos de componentes
- **Title Medium**: 16px, Bold - Para subt�tulos

#### Body
- **Body Large**: 16px, Regular - Para texto principal
- **Body Medium**: 14px, Regular - Para texto secund�rio
- **Body Small**: 12px, Regular - Para legendas

#### Label
- **Label Large**: 14px, Bold - Para labels de formul�rios
- **Label Medium**: 12px, Bold - Para labels de bot�es

---

## ?? Componentes de Design

### Cards

#### Card Padr�o
```
- Background: Branco (#FFFFFF)
- Border: Gray 200 (#E5E7EB)
- Border Radius: 16px
- Shadow: Sim (sutil)
- Padding: 16px
```

#### Card Elevado
```
- Background: Branco (#FFFFFF)
- Border: Transparente
- Border Radius: 16px
- Shadow: Sim (mais pronunciada)
- Padding: 16px
```

#### Pictogram Card
```
- Background: Cor da categoria com 15% de opacidade
- Border: Cor da categoria
- Border Radius: 12px
- Padding: 12px
- Height: 100px (fixo)
- Shadow: Sim
```

### Bot�es

#### Button Primary
```
- Background: Primary (#6366F1)
- Text: Branco
- Font Size: 16px, Bold
- Border Radius: 12px
- Padding: 24px horizontal, 12px vertical
- Height: 56px
```

#### Button Secondary
```
- Background: Gray 100
- Text: Text Primary
- Font Size: 16px, Bold
- Border Radius: 12px
- Height: 56px
```

#### Button Success
```
- Background: Success (#10B981)
- Text: Branco
- Font Size: 16px, Bold
- Border Radius: 12px
- Height: 56px
```

### Entries (Campos de Entrada)
```
- Background: Branco
- Text Color: Text Primary
- Placeholder: Text Tertiary
- Font Size: 16px
- Height: 56px
- Border Radius: 12px
```

---

## ?? Layout e Espa�amento

### Sistema de Espa�amento (m�ltiplos de 4px)
```
4px  - Muito pequeno (espa�amento m�nimo)
8px  - Pequeno (entre elementos relacionados)
12px - M�dio (espa�amento padr�o)
16px - Grande (padding de containers)
20px - Extra grande (separa��o de se��es)
24px - Muito grande (margens externas)
```

### Grid System
- **Pictogramas**: 4 colunas em tablets/landscape
- **Spacing**: 12px entre pictogramas
- **Padding**: 16px nas laterais

---

## ?? Princ�pios de Design para TEA

### 1. **Clareza Visual**
- ? Alto contraste entre texto e fundo
- ? �cones grandes e reconhec�veis (28-36px)
- ? Espa�amento generoso entre elementos
- ? Sem gradientes complexos ou texturas

### 2. **Consist�ncia**
- ? Cores consistentes por categoria
- ? Mesmo estilo de bot�o para mesma a��o
- ? Pictogramas sempre no mesmo formato
- ? Navega��o previs�vel

### 3. **Redu��o de Sobrecarga Cognitiva**
- ? Uma a��o por bot�o
- ? Hierarquia visual clara
- ? Informa��es agrupadas logicamente
- ? Feedback visual imediato

### 4. **Acessibilidade**
- ? �rea de toque m�nima: 44x44px
- ? Labels descritivos
- ? Suporte a SemanticProperties
- ? Cores com contraste WCAG AA

---

## ?? Componentes Espec�ficos

### Header (Cabe�alho)
```xaml
<StackLayout Style="{StaticResource HeaderStyle}">
 - Background: Primary
    - Padding: 20px
    - Spacing: 8px
</StackLayout>
```

### Message Composition Area
```
- Frame elevado com sombra
- Background interno: Gray 50
- Altura m�nima: 50px
- Placeholder em it�lico quando vazio
```

### Category Card
```
- Card elevado
- �cone em c�rculo colorido (56x56px)
- Nome da categoria em Headline Medium
- Contador de pictogramas em Body Small
- Grid de pictogramas 4 colunas
```

### Selected Pictogram
```
- Card de 90px de largura
- Background: Cor com 20% de opacidade
- Border: Cor s�lida da categoria
- S�mbolo: 32px
- Texto: Label Medium
- Tappable para remover
```

---

## ?? Estados de Intera��o

### Normal
- Cor padr�o do componente

### Hover (Desktop/Web)
- Ligeiro escurecimento da cor de fundo
- Eleva��o da sombra

### Pressed
- Escurecimento mais pronunciado
- Redu��o da eleva��o

### Disabled
- Opacidade 50%
- Cor de texto Gray 400

### Selected
- Border mais espessa
- Background com cor de destaque

---

## ?? M�tricas de UX

### �reas de Toque
```
M�nimo: 44x44px (WCAG)
Recomendado para TEA: 56x56px ou maior
Pictogramas: 100x100px
```

### Tempo de Resposta
```
Feedback visual: Imediato (<100ms)
Anima��es: Sutis (200-300ms)
Transi��es: Suaves (300ms)
```

### Densidade de Informa��o
```
M�ximo 4 pictogramas por linha
M�ximo 8 pictogramas vis�veis por categoria sem scroll
Espa�amento generoso (12px+)
```

---

## ?? Melhorias Implementadas

### ? Interface Redesenhada
- Cards com eleva��o e sombras profissionais
- Hierarquia visual clara com tipografia escal�vel
- Espa�amento consistente e respir�vel
- Cores sem�nticas e categ�ricas

### ? Componentes Modernos
- Frames com border radius suaves (12-16px)
- Bot�es com altura adequada (56px)
- �cones de categoria em c�rculos coloridos
- Empty states ilustrados

### ? Feedback Visual
- Estados de intera��o claros
- Separadores sutis entre se��es
- Sombras para criar profundidade
- Cores de destaque para a��es importantes

### ? Acessibilidade Melhorada
- Alto contraste em todos os elementos
- �reas de toque generosas
- Labels descritivos
- Suporte a leitores de tela

---

## ?? Guia de Uso do Design System

### Para Adicionar Nova Categoria
```xaml
<Frame Style="{StaticResource CardElevated}">
    <Frame BackgroundColor="[COR]20" BorderColor="[COR]">
      <!-- Conte�do -->
    </Frame>
</Frame>
```

### Para Criar Novo Bot�o
```xaml
<Button Text="A��o" 
        Command="{Binding Command}"
   Style="{StaticResource ButtonPrimary}"/>
```

### Para Adicionar Novo Card
```xaml
<Frame Style="{StaticResource Card}">
    <!-- Conte�do -->
</Frame>
```

---

## ?? Responsividade

### Breakpoints
```
Small (Phone): < 600px
Medium (Tablet): 600px - 900px
Large (Desktop): > 900px
```

### Adapta��es
- **Phone**: 3-4 colunas de pictogramas
- **Tablet**: 4-6 colunas de pictogramas
- **Desktop**: 6-8 colunas de pictogramas

---

## ?? Inspira��o de Design

O design system foi inspirado em:
- **Material Design 3** (Google) - Hierarquia e componentes
- **Apple Human Interface Guidelines** - Clareza e acessibilidade
- **Autism Accessibility Guidelines** - Princ�pios para TEA
- **WCAG 2.1** - Padr�es de acessibilidade

---

## ?? Notas Finais

Este design system garante:
- ? **Consist�ncia** em toda a aplica��o
- ? **Escalabilidade** para futuras funcionalidades
- ? **Acessibilidade** para crian�as com TEA
- ? **Profissionalismo** visual
- ? **Manutenibilidade** do c�digo

**Desenvolvido com ?? e aten��o aos detalhes para Luiza**

*Vers�o 2.0 - Design Profissional - Janeiro 2025*
