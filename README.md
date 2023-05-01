# UnityDeveloperChallenge-CarlosGabriel
Unity Developer Challenge - Carlos Gabriel Ferreira Silva

#bugs não solucionados e demais tarefas não implementadas devido ao tempo e erros de código

- Base - Menu
    - [x]  Main menu scene
    - [x]  options scene
    - [x]  options - resolution
    - [x]  options - sound
- Board creation
    - [x]  Mapa/tabulerio base 16x16
    - [ ]  ~~Criação de mapa dinâmico (tamanho e forma diferentes)~~
        
        —Bugs: Colisão de objetos de forma incostante
        
    - [x]  Diferentes formas de mapeameto ( Quadrado e hexagonal)
        
        — Bugs:  Erros de incompatibilidade de script com bases hexagonais
        
- Players
    - [x]  2 jogadores
    - [x]  turno para cara jogador no mesmo teclado
    - [ ]  ~~AI para jogar contra~~
        
        — Bugs: Geração de IA com repetição de movimentos
        
    - [ ]  ~~opção de escolher entre 1vsAI ou 1vs1 local no menu~~
    - [x]  jogadores só podem atuar no seu turno
- Characters
    - [x]  Cada um controla seu próprio personagem
    - [x]  pode ou não ser o mesmo
    - [x]  cada um tem seus pontos de vida e dano
    - [x]  Variações de personagens com diferentes configurações de mecânicas
    - [x]  opção de escolher personagens no menu
- Turns
    - [x]  pode se mover a áreas adjacentes com o clique do mouse
    - [x]  personagens não podem estar no mesmo espaço
    - [x]  Guiar movimentos possíveis do espaço atual
    - [x]  Cada jogador tem 3 movimentos por turno
        
        — Bugs: em certos momentos um personagem se move o dobro de movimentos
        
    - [x]  Mostrar movimentos restantes
        
        — Bugs: bug visual que congela o numero de movimentos restantes
        
    - [x]  o turno muda quando acabar os movimentos
    
- Câmera
    - [x]  Câmera que segue o player do turno atual
        
        — Bugs: posicionamento de câmera inconsistente
        
- Espaços
    - [x]  Todos os espaços tem que ter um item coletável
    - [x]  o ponto inicial predefinido mas dinâmico (diferentes inícios por partida)
- Coletáveis
    - [x]  Pelo menos 3 coletáveis
    - [ ]  Item de movimento extra
    - [x]  Item de ataque extra
    - [x]  Item de recuperar vida
    - [x]  Ganhar dados extras ate o fim do turno
    - [x]  coleta ao passar por cima
    - [x]  se há apenas 10% dos coletáveis, o game preenche o mapa com mais
    - [x]  diferentes tiers para cada coletável
- Battle
    - [x]  Sempre acontece luta quando estão adjacentes
        
        —Bugs: Após a luta fica em um loop infinito
        
    - [x]  Se a batalha acontece no ultimo turno, ele só termina ao fim da batalha
    - [x]  adjacentes de forma direta e diagonal (Range de área de 1 quadrado )
    - [x]  a luta acontece em com rolagens de dados
    - [x]  dados de diferentes cores para cada um
    - [x]  dados de 6 lados e e diferentes
        
        — sem versão 3D dos dados, apenas os resultados
        
    - [x]  Cada um rola 3 dados
    - [x]  ordena do maior para o menor e compara os valores, dizendo um vencedor para cada um dos 3 pares
    - [x]  em caso de números iguais, o jogador no turno atual tem vantagem
    - [x]  jogador com maior numero de vitorias na comparação dos pares ganha a luta
    - [x]  o perdedor leva dano na vida, baseado no poder de ataque do vencedor
- Sound
    
    — Assets de sons individuais separados mas não implementados
    
    - [ ]  cada ação no jogo precisa de um som (Mover, atacar, coletar)
    - [ ]  Sons únicos e diferentes para cada ação
    - [x]  Musica de fundo para certas etapas
- Effects
    
    — Conjunto de animações individuais separados mas não implementados
    
    - [ ]  cada ação no jogo precisa de um efeito (Mover, atacar, coletar)
    - [ ]  Efeitos únicos e diferentes para cada ação
- General Rules
    - [ ]  O jogo acaba quando os pontos de vida de alguém são zerado
    - [ ]  mostrar tela de fim de jogo com vencedor
    - [ ]  apresentar na tela de fim de jogo, botão de replay e de voltar ao menu
- Profiling
    - [ ]  Rodar Profiler tool (Performance)
    - [ ]  Mapear problemas
    - [ ]  Relatório de performance
    - [ ]  criar documentação explicando os problemas encontrados e como os solucionaria
